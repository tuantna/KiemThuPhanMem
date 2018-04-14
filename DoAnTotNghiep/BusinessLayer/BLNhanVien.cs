using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DoAnTotNghiep.DataAcessLayer;
using System.Data.Linq;

namespace DoAnTotNghiep.BusinessLayer
{
    public class BLNhanVien
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
        Table<NHANVIEN> query;
        public BLNhanVien()
        {
            query = PhamMem.db.NHANVIENs;
        }
        #endregion

        #region Xử lý đọc dữ liệu
        public IList<NHANVIEN> DocNhanVienLen()
        {
            return query.ToList();
        }
        public IList<object> DocNhanVien()
        {
            var q = from nc in query                    
                    select new {nc.NhanVienID, nc.MaNV,nc.HoNV,nc.TenNV,nc.GioiTinh,nc.DONVI.TenDonVi,nc.CHUCVU.TenChucVU};
            return q.Cast<object>().ToList(); 
        }
        public IList<object> DocNhanVienLenCbo()
        {
            var q = from nc in query
                    select new { 
                        NhanVienID=nc.NhanVienID,
                        HoTenNV=nc.HoNV +' '+nc.TenNV
                    };
            return q.Cast<object>().ToList();
        }
        public IList<object> NhanVienDHTheoDonViID(int dvid)
        {
            var q = from nc in query
                    where nc.DonViID == dvid
                    select new
                    {
                        NhanVienID = nc.NhanVienID,
                        HoTenNV = nc.HoNV + ' ' + nc.TenNV
                    };
            return q.Cast<object>().ToList();
        }
        public NHANVIEN DocNhanVienTheoID(int pTBID)
        {
            return query.Where(NHANVIEN => NHANVIEN.NhanVienID == pTBID).FirstOrDefault();
        }
        public NHANVIEN DOcNguoiDungTheoMaNV(string MaNV)
        {
            return query.Where(NHANVIEN => NHANVIEN.MaNV == MaNV).FirstOrDefault();
        }
        public NHANVIEN DOcNguoiDungTheoaaa(int DonViID)
        {
            return query.Where(NHANVIEN => NHANVIEN.DonViID == DonViID).FirstOrDefault();
        }
        public IList<NHANVIEN> NhanVienDHTheoDonViID1(int DonViID)
        {
            IList<NHANVIEN> dh = query.Where(x => x.DonViID == DonViID).ToList();
            return dh;
        }
        public NHANVIEN NhanVienDHTheoNhanVienID(int NhanVienID)
        {
            return query.Where(NHANVIEN => NHANVIEN.NhanVienID == NhanVienID).FirstOrDefault();
        }
        public IList<NHANVIEN> NhanVienDHTheoChucVu(int pChucvuID)
        {
            IList<NHANVIEN> dh = query.Where(x => x.ChucVuID == pChucvuID).ToList();
            return dh;
        }
        public IList<object> DocNhanVienTheoDonVi(int qDonVi)
        {
            var q = from nc in query       
                    where nc.DonViID==qDonVi
                    select new {nc.NhanVienID, nc.MaNV,nc.HoNV,nc.TenNV,nc.CHUCVU.TenChucVU};
            return q.Cast<object>().ToList(); 
        }
        public IList<object> DocChucVuTheodieukienTK(string pDK)
        {
            var q = from nc in query
                    where nc.HoNV.ToUpper().Contains(pDK.ToUpper()) || nc.TenNV.ToUpper().Contains(pDK.ToUpper())
                   select new {nc.NhanVienID, nc.MaNV,nc.HoNV,nc.TenNV,nc.GioiTinh,nc.DONVI.TenDonVi,nc.CHUCVU.TenChucVU};
            return q.Cast<object>().ToList(); 
            //pDK = pDK.ToUpper();
            //return query.Where(nc=>nc.TenNhaCc.ToUpper().Contains(pDK.ToUpper())).ToList();

            //return query.ToList().FindAll(delegate(NhaCC nh) { return nh.TenNhaCc.ToUpper().Contains(pDK); });
        }
        #endregion

        #region Kiểm tra
        private bool NhanVienHopLe(NHANVIEN pNV)
        {
            StringBuilder loi = new StringBuilder();
            if (string.IsNullOrEmpty(pNV.MaNV))
                loi.AppendLine("Mã NV bị rỗng");
            if (string.IsNullOrEmpty(pNV.HoNV))
                loi.AppendLine("Họ NV bị rỗng");
            if (string.IsNullOrEmpty(pNV.TenNV))
                loi.AppendLine("Tên NV bị rỗng");

            if (!string.IsNullOrEmpty(loi.ToString()))
                throw new CapNhatNhanVienException { Mess = loi.ToString() };

            return true;
        }
        private bool KiemTraDaiDienKK(NHANVIEN pNV)
        {
            BLDDienKK BPN = new BLDDienKK();
            int dem = BPN.DocDDKKTheoNVID(pNV.NhanVienID).Count;
            return (dem > 0);
           // return false;
        }
        private bool KiemTraNguoiDung(NHANVIEN pNV)
        {
            BLNguoiDung BPN = new BLNguoiDung();
            int dem = BPN.DocNguoiDungheoNVID(pNV.NhanVienID).Count;
            return (dem > 0);
            //return false;
        }
        #endregion


        #region Cập nhật dữ liệu
        public IList<NHANVIEN> Them(NHANVIEN pNh)
        {
            if (NhanVienHopLe(pNh))
            {
                query.InsertOnSubmit(pNh);
                PhamMem.db.SubmitChanges();
            }
            return query.ToList();
        }
        public IList<NHANVIEN> Xoa(NHANVIEN pNh)
        {
            if (KiemTraDaiDienKK(pNh))
                throw new DeleteNhanVienDDException();   //ném ngoại lệ lên Presentation Layer
            else if (KiemTraNguoiDung(pNh))
                throw new DeleteNhanVienNDungException();   //ném ngoại lệ lên Presentation Layer
            else
            {
                // var d = DocNhaCCTheoID(pNh.NhaCCID);
                query.DeleteOnSubmit(pNh);
                PhamMem.db.SubmitChanges();
                return query.ToList();
            }
        }
        public IList<NHANVIEN> CapNhat(NHANVIEN pDK)
        {
            if (NhanVienHopLe(pDK))
            {
                PhamMem.db.SubmitChanges();
            }
            return query.ToList();
        }
        #endregion
    }
}
