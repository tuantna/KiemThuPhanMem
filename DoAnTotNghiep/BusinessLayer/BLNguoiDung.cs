using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DoAnTotNghiep.DataAcessLayer;
using System.Data.Linq;
using System.Data.Common;


namespace DoAnTotNghiep.BusinessLayer
{
    class BLNguoiDung
    {
        
        #region Khai báo ban đầu
        Table<NguoiDung> query;       
        public BLNguoiDung()
        {
            query = PhamMem.db.NguoiDungs;           
        }
        #endregion

        #region Xử lý đọc dữ liệu
        public IList<NguoiDung> DocNguoiDung()
        {
            return query.ToList();
        }
        public IList<object> DocDSNguoiDung()
        {
            var q = from nv in query
                    select new
                    {
                        NguoiDungID = nv.NguoiDungID,
                        MaDangNhap = nv.NHANVIEN.HoNV + ' ' + nv.NHANVIEN.TenNV
                    };
            return q.Cast<object>().ToList();
        }
        public IList<object> DocDSNguoiDungchoCBo()
        {
            var q = from nv in query                    
                    select new
                    {
                        NguoiDungID = nv.NguoiDungID,
                        MaDangNhap = nv.NHANVIEN.HoNV + ' ' + nv.NHANVIEN.TenNV
                    };
            return q.Cast<object>().ToList();
        }
        public IList<NguoiDung> DocNguoiDungheoNVID(int pTBID)
        {
            IList<NguoiDung> dh = query.Where(x => x.NhanVienID == pTBID).ToList();
            return dh;
        }
        //public IList<NguoiDung> DocNguoiDungTheodieukien(string pDK)
        //{
        //    pDK = pDK.ToUpper();
        //    return query.ToList().FindAll(delegate(NguoiDung nh) { return nh.HoTen.ToUpper().Contains(pDK); });
        //}
        public NguoiDung NguoiDung()
        {
            return query.FirstOrDefault();
        }
        public Table<NguoiDung> DocNguoiDungToTable()
        {
            return query;
        }
        public NguoiDung DocNguoiDungTheoID(int pNguoiDungID)
        {
            return query.Where(NguoiDung => NguoiDung.NguoiDungID == pNguoiDungID).FirstOrDefault();
        }
        public NguoiDung DocNguoiDungTheoMaDangNhap(string pMaDangNhap)
        {
            return query.Where(NguoiDung => NguoiDung.MaDangNhap == pMaDangNhap).FirstOrDefault();
        }
        public IList<object> DocNguoiDungLen()
        {
            var n = from nc in query
                    select new { nc.NguoiDungID,nc.NHANVIEN.MaNV,nc.NHANVIEN.HoNV,nc.NHANVIEN.TenNV,nc.MaDangNhap};
           return n.Cast<object>().ToList();    
        }
        public IList<object> DocNguoiDungTheoTaiKhoan(string qtaikhoan)
        {
            var n = from nc in query
                    where nc.MaDangNhap.ToUpper().Contains(qtaikhoan.ToUpper())
                    select new { nc.NguoiDungID, nc.NHANVIEN.MaNV, nc.NHANVIEN.HoNV, nc.NHANVIEN.TenNV, nc.MaDangNhap };
            return n.Cast<object>().ToList();
        }
        public IList<object> DocNguoiDungTheoTenNV(string qTen)
        {
            var n = from nc in query
                    where nc.NHANVIEN.TenNV.ToUpper().Contains(qTen.ToUpper())
                    select new { nc.NguoiDungID, nc.NHANVIEN.MaNV, nc.NHANVIEN.HoNV, nc.NHANVIEN.TenNV, nc.MaDangNhap };
            return n.Cast<object>().ToList();
        }  

        //public IList<NguoiDung> DocNguoiDungTheoTen(string pTen)
        //{
        //    pTen = pTen.ToUpper();
        //    IList<NguoiDung> q = query.Select(x => x).Where(x => x.HoTen.Contains(pTen))
        //     .OrderBy(x => x.NguoiDungID).ToList();
        //    return q;
        //}
        //public NguoiDung DocNguoiDungHienHanh(int vtri)
        //{
        //    IQueryable<NguoiDung> q = (from s in query select s).Skip(vtri).Take(1);
        //    NguoiDung ncc = null;
        //    if (q.Count() > 0)
        //        foreach (NguoiDung k in q)
        //        {
        //            ncc = new NguoiDung
        //            {
        //                NguoiDungID = k.NguoiDungID,
        //                HoTen = k.HoTen,
        //                MaDangNhap = k.MaDangNhap,
        //                MatKhau = k.MatKhau,
        //                BaoCao=k.BaoCao,
        //                DanhMuc=k.DanhMuc,
        //                PhatSinh=k.PhatSinh,
        //                QuanTri=k.QuanTri,
        //                TraCuu=k.TraCuu 

        //            };
        //        }
        //    return ncc;
        //}
        #endregion

        #region Kiểm tra
        private bool NguoiDungHopLe(NguoiDung pNguoiDung)
        {
            StringBuilder loi = new StringBuilder();
            //if (string.IsNullOrEmpty(pNguoiDung.))
             //   loi.AppendLine("Tên Người dùng cấp bị rỗng");

            if (string.IsNullOrEmpty(pNguoiDung.MaDangNhap))
                loi.AppendLine("Tên đăng nhập bị rỗng");

            if (!string.IsNullOrEmpty(loi.ToString()))
                throw new CapNhatNguoiDungException { Mess = loi.ToString() };

            return true;
        }

        private bool KiemTraPNhap(NguoiDung pNguoiDung)
        {
            BLPNhap Bdh = new BLPNhap();
            int dem = Bdh.DocPNhapTheoNDungID(pNguoiDung.NguoiDungID).Count;
            return (dem > 0);
            //return false;
        }

        #endregion

        #region Cập nhật dữ liệu
        public IList<NguoiDung> Them(NguoiDung pNh)
        {
            if (NguoiDungHopLe(pNh))
            {
                query.InsertOnSubmit(pNh);
                PhamMem.db.SubmitChanges();
            }
            return query.ToList();
        }
        public IList<NguoiDung> Xoa(NguoiDung pNh)
        {
            if (KiemTraPNhap(pNh))
                throw new DeleteNguoiDungException();   //ném ngoại lệ lên Presentation Layer
            else
            {
                var d = DocNguoiDungTheoID(pNh.NguoiDungID);
                query.DeleteOnSubmit(d);
                PhamMem.db.SubmitChanges();
                return query.ToList();
            }
        }
        public IList<NguoiDung> CapNhat(NguoiDung pNguoiDung)
        {
            if (NguoiDungHopLe(pNguoiDung))
            {
                PhamMem.db.SubmitChanges();
            }
            return query.ToList();
        }
        #endregion

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

        #region Các nghiệp vụ khác
        public Binary MaHoaMatKhau(string pPass)
        {
            return PhamMem.Ma_hoa_matkhau(pPass);
            
        }
        public string GiaiMaMatKhau(Binary pMkhau)
        {
            return PhamMem.Giai_ma_matkhau(pMkhau);

        }
        #endregion

    }
}
