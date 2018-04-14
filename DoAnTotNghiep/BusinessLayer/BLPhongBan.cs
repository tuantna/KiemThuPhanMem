using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DoAnTotNghiep.DataAcessLayer;
using System.Data.Linq;

namespace DoAnTotNghiep.BusinessLayer
{
    public class BLPhongBan
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
        Table<PHONGBAN> query;
        public BLPhongBan()
        {
            query = PhamMem.db.PHONGBANs;
        }
        #endregion

        #region Xử lý đọc dữ liệu
        public IList<PHONGBAN> DocPhongBan()
        {
            return query.ToList();
        }
        //public IList<THIETBI> DocThietBi22(int ID)
        //{
        //    IList<THIETBI> dh = query.Where(x => x.ThietBiID == ID).ToList();
        //    return dh;
        //}
        public PHONGBAN DocPhongBanTheoID(int pTBID)
        {
            return query.Where(PHONGBAN => PHONGBAN.PhongBanID == pTBID).FirstOrDefault();
        }
        public double TongTienSOTB(int PBID)
        {
            string Lenh = "Select Count(ThietBiID) From SOTHEODOI Where PhongBanID=" + PBID;
            double tien = double.Parse(ThucHienLenhTinhToan(Lenh).ToString());
            return tien;
        }
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
        //public IList<object> DocLoaiTB()
        //{
        //    //return query.ToList();
        //    var n = from nc in query
        //            select new { nc.MaThietBi, nc.TenTB, nc.SoLuongTB, nc.DVTINH.TenDVT, nc.NUOCSX.TenNuoc, nc.NamSanXuat, nc.MoTa };

        //    return n.Cast<object>().ToList();
        //}
        public IList<PHONGBAN> DocPhongBanTheoDK(int pID)
        {
            IList<PHONGBAN> dh = query.Where(x => x.DonViID == pID).ToList();
            return dh;
        }
        //public IList<object> DocLoaiTBheoTen(string pDK,int maloai)
        //{
        //    var q = from nc in query
        //            where nc.TenTB.ToUpper().Contains(pDK.ToUpper()) && nc.LoaiTBID==maloai
        //            select new { nc.ThietBiID, nc.MaThietBi, nc.TenTB, nc.SoLuongTB, nc.DVTINH.TenDVT, nc.NUOCSX.TenNuoc, nc.NamSanXuat, nc.MoTa };

        //    return q.Cast<object>().ToList();
        //}
        #endregion

        #region Kiểm tra
        private bool PhongbanHopLe(PHONGBAN pTB)
        {
            StringBuilder loi = new StringBuilder();
            if (string.IsNullOrEmpty(pTB.TenPhongBan))
                loi.AppendLine("Tên phòng ban bị rỗng");          
            if (!string.IsNullOrEmpty(loi.ToString()))
                throw new CapNhatPhongBanException { Mess = loi.ToString() };

            return true;
        }
        private bool KiemTraDOTKK(PHONGBAN pTB)
        {
            BLDotKK BTB = new BLDotKK();
            int dem = BTB.DocTDotKiemKeTheoPNID(pTB.PhongBanID).Count;
            return (dem > 0);
            //return false;
        }
        private bool KiemTraSTD(PHONGBAN pTB)
        {
            BLSoTheoDoi BTB = new BLSoTheoDoi();
            int dem = BTB.DocSTBTheoPBID(pTB.PhongBanID).Count;
            return (dem > 0);
            //return false;
        }
        private bool KiemTraPNhap(PHONGBAN pTB)
        {
            BLPNhap BTB = new BLPNhap();
            int dem = BTB.DocPNhapTheoPBID(pTB.PhongBanID).Count;
            return (dem > 0);
            //return false;
        }
        private bool KiemTraBanGiao(PHONGBAN pTB)
        {
            BLBanGiao BTB = new BLBanGiao();
            int dem = BTB.DocBanGiaoTheiIDPB(pTB.PhongBanID).Count;
            return (dem > 0);
            //return false;
        }
        #endregion


        #region Cập nhật dữ liệu
        public IList<PHONGBAN> Them(PHONGBAN pTB)
        {
            if (PhongbanHopLe(pTB))
            {
                query.InsertOnSubmit(pTB);
                PhamMem.db.SubmitChanges();
            }
            return query.ToList();
        }
        public IList<PHONGBAN> Xoa(PHONGBAN pTB)
        {
           if (KiemTraDOTKK(pTB))
               throw new DeletePhongBanSTDxception();   //ném ngoại lệ lên Presentation Layer
           else if(KiemTraSTD(pTB))
                throw new DeletePhongBanDOKKException();   //ném ngoại lệ lên Presentation Layer
           else if (KiemTraPNhap(pTB))
                throw new DeletePhongBanPNhapxception();   //ném ngoại lệ lên Presentation Layer
            else if (KiemTraBanGiao(pTB))
                throw new DeletePhongBanBanGiaoxception();   //ném ngoại lệ lên Presentation Layer
            else
            {
                // var d = DocNhaCCTheoID(pNh.NhaCCID);
                query.DeleteOnSubmit(pTB);
                PhamMem.db.SubmitChanges();
                return query.ToList();
            }
        }
        public IList<PHONGBAN> CapNhat(PHONGBAN pLoaiTB)
        {
            if (PhongbanHopLe(pLoaiTB))
            {
                PhamMem.db.SubmitChanges();
            }
            return query.ToList();
        }
        #endregion
    }
}
