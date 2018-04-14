using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DoAnTotNghiep.DataAcessLayer;
using System.Data.Linq;

namespace DoAnTotNghiep.BusinessLayer
{
    public class BLSoTheoDoi
    {
        #region Thực hiện lệnh
        public int ThucHienLenhCapNhat(string lenh)
        {
            return PhamMem.db.ThucHienLenhCapNhat(lenh);
        }
        public List<object> ThucHienLenh(string lenh)
        {
            return PhamMem.db.ThucHienLenh(lenh);
        }
        public object ThucHienLenhTinhToan(string lenh)
        {
            return PhamMem.db.ThucHienLenhTinhToan(lenh);
        }
        #endregion

        #region Khai báo ban đầu
        Table<SOTHEODOI> query;
        public BLSoTheoDoi()
        {
            query = PhamMem.db.SOTHEODOIs;
        }
        #endregion

        #region Xử lý đọc dữ liệu
        public IList<SOTHEODOI> DocSoTheoDoi()
        {
            return query.ToList();
        }
        public double TongSoThietBI()
        {
            string Lenh = "Select Count(ThietBiID) From SOTHEODOI";
            double tien = double.Parse(ThucHienLenhTinhToan(Lenh).ToString());
            return tien;
        }
        public double TongTienTBDangSD()
        {
            string Lenh = "Select Count(ThietBiID) From SOTHEODOI Where TinhTrangID=" + 1;
            double tien = double.Parse(ThucHienLenhTinhToan(Lenh).ToString());
            return tien;
        }
        public double TongTienTBHu()
        {
            string Lenh = "Select Count(ThietBiID) From SOTHEODOI Where TinhTrangID=" + 2;
            double tien = double.Parse(ThucHienLenhTinhToan(Lenh).ToString());
            return tien;
        }
        public double TongTienTBBiMat()
        {
            string Lenh = "Select Count(ThietBiID) From SOTHEODOI Where TinhTrangID=" + 3;
            double tien = double.Parse(ThucHienLenhTinhToan(Lenh).ToString());
            return tien;
        }
        public double TongTienTBSuaChua()
        {
            string Lenh = "Select Count(ThietBiID) From SOTHEODOI Where TinhTrangID=" + 4;
            double tien = double.Parse(ThucHienLenhTinhToan(Lenh).ToString());
            return tien;
        }
        public double TongTienTBDaTLy()
        {
            string Lenh = "Select Count(ThietBiID) From SOTHEODOI Where TinhTrangID=" + 5;
            double tien = double.Parse(ThucHienLenhTinhToan(Lenh).ToString());
            return tien;
        }
        public IList<SOTHEODOI> DocSTDTheoTrang(int ID)
        {
            IList<SOTHEODOI> dh = query.Where(x => x.TinhTrangID == ID).ToList();
            return dh;
        }
        //public THIETBI DocThietBiTheoID(int pTBID)
        //{
        //    return query.Where(THIETBI => THIETBI.ThietBiID == pTBID).FirstOrDefault();
        //}
        public IList<SOTHEODOI> DocSTBTheoPBID(int LoaiTB)
        {
            IList<SOTHEODOI> dh = query.Where(x => x.PhongBanID == LoaiTB).ToList();
            return dh;
        }
        public IList<SOTHEODOI> DocSTDTheoTBID(int pTBID)
        {
            IList<SOTHEODOI> dh = query.Where(x => x.ThietBiID == pTBID).ToList();
            return dh;
        }       
        //public IList<THIETBI> DocThietBiTheoNSX(int pTBID)
        //{
        //    IList<THIETBI> dh = query.Where(x => x.NUOCSXID == pTBID).ToList();
        //    return dh;
        //}
        public IList<object> TimKiemThietBi(string ten)
        {
            var n = from nc in query
                    where nc.THIETBI.TenTB.ToUpper().Contains(ten.ToUpper())
                    select new { nc.THIETBI.MaThietBi,nc.THIETBI.TenTB,nc.THIETBI.DVTINH.TenDVT,nc.PHONGBAN.DONVI.TenDonVi,nc.PHONGBAN.TenPhongBan};
            return n.Cast<object>().ToList();
        }
        public IList<object> DocSoTheoDoiTheoPBID(int PBID)
        {            
            var n = from nc in query
                    where nc.PhongBanID==PBID
                    select new {nc.SoTheoDoiID, nc.ThietBiID,nc.THIETBI.MaThietBi,nc.TinhTrangID, nc.THIETBI.TenTB,nc.TINHTRANG.TenTinhTrang};
            return n.Cast<object>().ToList();
        }
        public SOTHEODOI DocSOTHEODOITheoID(int SoTheoDoiID)
        {
            return query.Where(SOTHEODOI => SOTHEODOI.SoTheoDoiID == SoTheoDoiID).FirstOrDefault();
        }
        public SOTHEODOI DocSOTHEODOITheoTB_PB(int TBID, int PBID)
        {
            return query.Where(SOTHEODOI => SOTHEODOI.ThietBiID == TBID && SOTHEODOI.PhongBanID==PBID).FirstOrDefault();
        }
        //public IList<object> DocThietBiTheoIDTB(int pDK)
        //{
        //    var q = from nc in query
        //            where nc.ThietBiID == pDK
        //            select new {nc.ThietBiID, nc.MaThietBi, nc.TenTB,nc.DVTINH.TenDVT};

        //    return q.Cast<object>().ToList();
        //}
        //public IList<object> DocLoaiTBheodieukien(int pDK)
        //{
        //    var q = from nc in query
        //            where nc.LoaiTBID == pDK
        //            select new { nc.ThietBiID,nc.MaThietBi, nc.TenTB, nc.SoLuongTB,nc.DVTINH.TenDVT, nc.NUOCSX.TenNuoc,nc.NamSanXuat,nc.MoTa };

        //    return q.Cast<object>().ToList();
        //}
        //public IList<object> DocLoaiTBheoTen(string pDK,int maloai)
        //{
        //    var q = from nc in query
        //            where nc.TenTB.ToUpper().Contains(pDK.ToUpper()) && nc.LoaiTBID==maloai
        //            select new { nc.ThietBiID, nc.MaThietBi, nc.TenTB, nc.SoLuongTB, nc.DVTINH.TenDVT, nc.NUOCSX.TenNuoc, nc.NamSanXuat, nc.MoTa };

        //    return q.Cast<object>().ToList();
        //}
        #endregion

        //#region Kiểm tra
        //private bool ThietBiHopLe(THIETBI pTB)
        //{
        //    StringBuilder loi = new StringBuilder();
        //    if (string.IsNullOrEmpty(pTB.MaThietBi))
        //        loi.AppendLine("Mã thiết bị bị rỗng");
        //    if (string.IsNullOrEmpty(pTB.TenTB))
        //        loi.AppendLine("Tên thiết bị bị rỗng");          

        //    if (!string.IsNullOrEmpty(loi.ToString()))
        //        throw new CapNhatThietBiException { Mess = loi.ToString() };

        //    return true;
        //}
        //private bool KiemTraKiemKe(THIETBI pTB)
        //{
        //    //BLThietBi BTB = new BLThietBi();
        //    //int dem = BPN.DocThietBiTheoLoaiTB(pLoaiTB.NhaCCID).Count;
        //    //return (dem > 0);
        //    return false;

        //}
        //#endregion


        //#region Cập nhật dữ liệu
        public IList<SOTHEODOI> Them(SOTHEODOI pTB)
        {
            //if (ThietBiHopLe(pTB))
           // {
                query.InsertOnSubmit(pTB);
                PhamMem.db.SubmitChanges();
          //  }
            return query.ToList();
        }
        public IList<SOTHEODOI> Xoa(SOTHEODOI pTB)
        {
            //if (KiemTraKiemKe(pTB))
            //    throw new DeleteThietBiException();   //ném ngoại lệ lên Presentation Layer
            //else
           // {
                // var d = DocNhaCCTheoID(pNh.NhaCCID);
                query.DeleteOnSubmit(pTB);
                PhamMem.db.SubmitChanges();
                return query.ToList();
           // }
        }
        public IList<SOTHEODOI> CapNhat(SOTHEODOI pSTD)
        {
            //if (CTPNhapHopLe(pCTPNhap, pSL))
           // {
                PhamMem.db.SubmitChanges();
            //}
            return query.ToList();
        }
        //#endregion
    }
}
