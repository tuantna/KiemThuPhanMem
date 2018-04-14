using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DoAnTotNghiep.DataAcessLayer;
using System.Data.Linq;

namespace DoAnTotNghiep.BusinessLayer
{
    public class BLChucVu
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
        Table<CHUCVU> query;
        public BLChucVu()
        {
            query = PhamMem.db.CHUCVUs;
        }
        #endregion

        #region Xử lý đọc dữ liệu
        public IList<CHUCVU> DocChucVu()
        {
            return query.ToList();
        }
        public IList<CHUCVU> DocChucVuTheodieukien(string pDK)
        {
            var q = from nc in query
                    where nc.TenChucVU.ToUpper().Contains(pDK.ToUpper())
                    select nc;
            return q.ToList();
            //pDK = pDK.ToUpper();
            //return query.Where(nc=>nc.TenNhaCc.ToUpper().Contains(pDK.ToUpper())).ToList();

            //return query.ToList().FindAll(delegate(NhaCC nh) { return nh.TenNhaCc.ToUpper().Contains(pDK); });
        }
        #endregion

        #region Kiểm tra
        private bool ChucvuHopLe(CHUCVU pDVT)
        {
            StringBuilder loi = new StringBuilder();
            if (string.IsNullOrEmpty(pDVT.TenChucVU))
                loi.AppendLine("Tên chức vụ bị rỗng");          

            if (!string.IsNullOrEmpty(loi.ToString()))
                throw new CapNhatChucVuException { Mess = loi.ToString() };

            return true;
        }
        private bool KiemTraChucVu(CHUCVU pCV)
        {
            BLNhanVien NV = new BLNhanVien();
            int dem = NV.NhanVienDHTheoChucVu(pCV.ChucVuID).Count;
            return (dem > 0);
            //return false;

        }
        #endregion


        #region Cập nhật dữ liệu
        public IList<CHUCVU> Them(CHUCVU pNh)
        {
            if (ChucvuHopLe(pNh))
            {
                query.InsertOnSubmit(pNh);
                PhamMem.db.SubmitChanges();
            }
            return query.ToList();
        }
        public IList<CHUCVU> Xoa(CHUCVU pNh)
        {
            if (KiemTraChucVu(pNh))
                throw new DeleteChucVuException();   //ném ngoại lệ lên Presentation Layer
            else
            {
                // var d = DocNhaCCTheoID(pNh.NhaCCID);
                query.DeleteOnSubmit(pNh);
                PhamMem.db.SubmitChanges();
                return query.ToList();
            }
        }
        public IList<CHUCVU> CapNhat(CHUCVU pDK)
        {
            if (ChucvuHopLe(pDK))
            {
                PhamMem.db.SubmitChanges();
            }
            return query.ToList();
        }
        #endregion
    }
}
