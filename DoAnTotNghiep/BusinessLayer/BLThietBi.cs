using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DoAnTotNghiep.DataAcessLayer;
using System.Data.Linq;

namespace DoAnTotNghiep.BusinessLayer
{
    public class BLThietBi
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
        Table<THIETBI> query;
        public BLThietBi()
        {
            query = PhamMem.db.THIETBIs;
        }
        #endregion

        #region Xử lý đọc dữ liệu
        public IList<THIETBI> DocThietBi()
        {
            return query.ToList();
        }       
        public THIETBI DocThietBiTheoID(int pTBID)
        {
            return query.Where(THIETBI => THIETBI.ThietBiID == pTBID).FirstOrDefault();
        }
        public IList<THIETBI> DocThietBiTheoLoaiTB(int LoaiTB)
        {
            IList<THIETBI> dh = query.Where(x => x.LoaiTBID == LoaiTB).ToList();
            return dh;
        }
        public IList<THIETBI> DocLoaiThietBiTheoDV(int pTBID)
        {
            IList<THIETBI> dh = query.Where(x => x.DVTID == pTBID).ToList();
            return dh;
        }
        public IList<THIETBI> DocThietBiTheoNSX(int pTBID)
        {
            IList<THIETBI> dh = query.Where(x => x.NUOCSXID == pTBID).ToList();
            return dh;
        }
        public IList<object> DocLoaiTB()
        {
            //return query.ToList();
            var n = from nc in query
                    select new { nc.MaThietBi, nc.TenTB, nc.SoLuongTB, nc.DVTINH.TenDVT, nc.NUOCSX.TenNuoc, nc.NamSanXuat, nc.MoTa };

            return n.Cast<object>().ToList();
        }
        public IList<object> DocThietBiTheoIDTB(int pDK)
        {
            var q = from nc in query
                    where nc.ThietBiID == pDK
                    select new {nc.ThietBiID, nc.MaThietBi, nc.TenTB,nc.DVTINH.TenDVT};

            return q.Cast<object>().ToList();
        }
        public IList<object> DocLoaiTBheodieukien(int pDK)
        {
            var q = from nc in query
                    where nc.LoaiTBID == pDK
                    select new { nc.ThietBiID,nc.MaThietBi, nc.TenTB, nc.SoLuongTB,nc.DVTINH.TenDVT, nc.NUOCSX.TenNuoc,nc.NamSanXuat,nc.MoTa };

            return q.Cast<object>().ToList();
        }
        public IList<object> DocLoaiTBheoTen(string pDK,int maloai)
        {
            var q = from nc in query
                    where nc.TenTB.ToUpper().Contains(pDK.ToUpper()) && nc.LoaiTBID==maloai
                    select new { nc.ThietBiID, nc.MaThietBi, nc.TenTB, nc.SoLuongTB, nc.DVTINH.TenDVT, nc.NUOCSX.TenNuoc, nc.NamSanXuat, nc.MoTa };

            return q.Cast<object>().ToList();
        }
        public IList<object> TimKiemThietBi(string pDK)
        {
            var q = from nc in query
                    where nc.TenTB.ToUpper().Contains(pDK.ToUpper())
                    select new { nc.ThietBiID, nc.MaThietBi, nc.TenTB, nc.SoLuongTB, nc.DVTINH.TenDVT, nc.NUOCSX.TenNuoc, nc.NamSanXuat, nc.MoTa };

            return q.Cast<object>().ToList();
        }
        #endregion

        #region Kiểm tra
        private bool ThietBiHopLe(THIETBI pTB)
        {
            StringBuilder loi = new StringBuilder();
            if (string.IsNullOrEmpty(pTB.MaThietBi))
                loi.AppendLine("Mã thiết bị bị rỗng");
            if (string.IsNullOrEmpty(pTB.TenTB))
                loi.AppendLine("Tên thiết bị bị rỗng");          

            if (!string.IsNullOrEmpty(loi.ToString()))
                throw new CapNhatThietBiException { Mess = loi.ToString() };

            return true;
        }
        private bool KiemTraCTPN(THIETBI pTB)
        {
            BLCTPNhap BTB = new BLCTPNhap();
            int dem = BTB.DocCTPNTheoTBID(pTB.ThietBiID).Count;
            return (dem > 0);
            //return false;

        }
        private bool KiemTraCTBG(THIETBI pTB)
        {
            BLCTBanGiao BTB = new BLCTBanGiao();
            int dem = BTB.DocCTBGTheoTBID(pTB.ThietBiID).Count;
            return (dem > 0);
            //return false;
        }
        private bool KiemTraSTD(THIETBI pTB)
        {
            BLSoTheoDoi BTB = new BLSoTheoDoi();
            int dem = BTB.DocSTDTheoTBID(pTB.ThietBiID).Count;
            return (dem > 0);
            //return false;

        }
        private bool KiemTraPKiemKe(THIETBI pTB)
        {
            BLPKiemKe BTB = new BLPKiemKe();
            int dem = BTB.DocPKKeTheoTBID(pTB.ThietBiID).Count;
            return (dem > 0);
            //return false;

        }
        private bool KiemTraCTTLy(THIETBI pTB)
        {
            BLCTThanhLy BTB = new BLCTThanhLy();
            int dem = BTB.DocCTTLyTheoTBID(pTB.ThietBiID).Count;
            return (dem > 0);
            //return false;

        }

        #endregion


        #region Cập nhật dữ liệu
        public IList<THIETBI> Them(THIETBI pTB)
        {
            if (ThietBiHopLe(pTB))
            {
                query.InsertOnSubmit(pTB);
                PhamMem.db.SubmitChanges();
            }
            return query.ToList();
        }
        public IList<THIETBI> Xoa(THIETBI pTB)
        {
            if (KiemTraCTPN(pTB))
                throw new DeleteThietBiCTPNException();   //ném ngoại lệ lên Presentation Layer
            else if (KiemTraCTBG(pTB))
                throw new DeleteThietBiCTBGException();
            else if (KiemTraSTD(pTB))
                throw new DeleteThietBiSTDException();
            else if (KiemTraPKiemKe(pTB))
                throw new DeleteThietBiPKEException();
            else if (KiemTraCTTLy(pTB))
                throw new DeleteThietBiCTTLyException();
            else
            {
                // var d = DocNhaCCTheoID(pNh.NhaCCID);
                query.DeleteOnSubmit(pTB);
                PhamMem.db.SubmitChanges();
                return query.ToList();
            }
        }
        public IList<THIETBI> CapNhat(THIETBI pLoaiTB)
        {
            if (ThietBiHopLe(pLoaiTB))
            {
                PhamMem.db.SubmitChanges();
            }
            return query.ToList();
        }
        #endregion
    }
}
