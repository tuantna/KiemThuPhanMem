using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DoAnTotNghiep.DataAcessLayer;
using System.Data.Linq;

namespace DoAnTotNghiep.BusinessLayer
{
    public class BLThanhLy
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
        Table<THANHLY> query;
        public BLThanhLy()
        {
            query = PhamMem.db.THANHLies;
        }
        #endregion

        #region Xử lý đọc dữ liệu
        public IList<THANHLY> DocThanhLy()
        {
            return query.ToList();
        }       
        //public IList<SOTHEODOI> DocThietBi22(int ID)
        //{
        //    IList<SOTHEODOI> dh = query.Where(x => x.ThietBiID == ID).ToList();
        //    return dh;
        //}
        public THANHLY DocThanhLyTheoNgay(DateTime pTBID)
        {
            return query.Where(THANHLY => THANHLY.NgayThanhLy == pTBID).FirstOrDefault();
        }
        //public IList<THIETBI> DocThietBiTheoLoaiTB(int LoaiTB)
        //{
        //    IList<THIETBI> dh = query.Where(x => x.LoaiTBID == LoaiTB).ToList();
        //    return dh;
        //}
        //public IList<THIETBI> DocLoaiThietBiTheoDV(int pTBID)
        //{
        //    IList<THIETBI> dh = query.Where(x => x.DVTID == pTBID).ToList();
        //    return dh;
        //}
        //public IList<THIETBI> DocThietBiTheoNSX(int pTBID)
        //{
        //    IList<THIETBI> dh = query.Where(x => x.NUOCSXID == pTBID).ToList();
        //    return dh;
        //}
        //public IList<object> DocSoTheoDoiTheoPBID(int PBID)
        //{            
        //    var n = from nc in query
        //            where nc.PhongBanID==PBID
        //            select new {nc.SoTheoDoiID, nc.ThietBiID,nc.THIETBI.MaThietBi,nc.TinhTrangID, nc.THIETBI.TenTB,nc.TINHTRANG.TenTinhTrang, nc.HienTrang };
        //    return n.Cast<object>().ToList();
        //}
        //public SOTHEODOI DocSOTHEODOITheoID(int SoTheoDoiID)
        //{
        //    return query.Where(SOTHEODOI => SOTHEODOI.SoTheoDoiID == SoTheoDoiID).FirstOrDefault();
        //}
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
        public IList<THANHLY> Them(THANHLY pTB)
        {
           // if (ThietBiHopLe(pTB))
            //{
                query.InsertOnSubmit(pTB);
                PhamMem.db.SubmitChanges();
           // }
            return query.ToList();
        }
        //public IList<THIETBI> Xoa(THIETBI pTB)
        //{
        //    if (KiemTraKiemKe(pTB))
        //        throw new DeleteThietBiException();   //ném ngoại lệ lên Presentation Layer
        //    else
        //    {
        //        // var d = DocNhaCCTheoID(pNh.NhaCCID);
        //        query.DeleteOnSubmit(pTB);
        //        PhamMem.db.SubmitChanges();
        //        return query.ToList();
        //    }
        //}
        //public IList<BANGIAO> CapNhat(BANGIAO pSTD)
        //{
        //    //if (CTPNhapHopLe(pCTPNhap, pSL))
        //   // {
        //        PhamMem.db.SubmitChanges();
        //    //}
        //    return query.ToList();
        //}
        //#endregion
    }
}
