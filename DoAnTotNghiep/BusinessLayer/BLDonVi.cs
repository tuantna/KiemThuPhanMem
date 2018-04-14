using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DoAnTotNghiep.DataAcessLayer;
using System.Data.Linq;

namespace DoAnTotNghiep.BusinessLayer
{
    public class BLDonVi
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
        Table<DONVI> query;
        public BLDonVi()
        {
            query = PhamMem.db.DONVIs;
        }
        #endregion

        #region Xử lý đọc dữ liệu
        public IList<DONVI> DocDonVi()
        {
            return query.ToList();
        }
        public Table<DONVI> DocDonViToTable()
        {
            return query;
        }
        public DONVI DonViTheoID2(int DonViID)
        {
            return query.Where(DONVI => DONVI.DonViID == DonViID).FirstOrDefault();
        }
        public IList<DONVI> DonViTheoID(int DonViID)
        {
            IList<DONVI> dh = query.Where(x => x.DonViID == DonViID).ToList();
            return dh;
        }
        public IList<DONVI> DocDonViTheodieukien(string pDK)
        {
            var q = from nc in query
                    where nc.TenDonVi.ToUpper().Contains(pDK.ToUpper())
                    select nc;
            return q.ToList();
            //pDK = pDK.ToUpper();
            //return query.Where(nc=>nc.TenNhaCc.ToUpper().Contains(pDK.ToUpper())).ToList();

            //return query.ToList().FindAll(delegate(NhaCC nh) { return nh.TenNhaCc.ToUpper().Contains(pDK); });
        }
        #endregion

        #region Kiểm tra
        private bool DonViHopLe(DONVI pDVT)
        {
            StringBuilder loi = new StringBuilder();
            if (string.IsNullOrEmpty(pDVT.TenDonVi))
                loi.AppendLine("Tên đơn vị bị rỗng");
            if (string.IsNullOrEmpty(pDVT.DiaChiDV))
                loi.AppendLine("Địa chỉ bị rỗng"); 

            if (!string.IsNullOrEmpty(loi.ToString()))
                throw new CapNhatDonViException { Mess = loi.ToString() };

            return true;
        }
        private bool KiemTraNhanVien(DONVI pNhacc)
        {
            BLNhanVien BPN = new BLNhanVien();
            int dem = BPN.NhanVienDHTheoDonViID1(pNhacc.DonViID).Count;
            return (dem > 0);
           // return false;

        }
        #endregion


        #region Cập nhật dữ liệu
        public IList<DONVI> Them(DONVI pNh)
        {
            if (DonViHopLe(pNh))
            {
                query.InsertOnSubmit(pNh);
                PhamMem.db.SubmitChanges();
            }
            return query.ToList();
        }
        public IList<DONVI> Xoa(DONVI pNh)
        {
            if (KiemTraNhanVien(pNh))
                throw new DeleteDonViException();   //ném ngoại lệ lên Presentation Layer
            else
            {
                // var d = DocNhaCCTheoID(pNh.NhaCCID);
                query.DeleteOnSubmit(pNh);
                PhamMem.db.SubmitChanges();
                return query.ToList();
            }
        }
        public IList<DONVI> CapNhat(DONVI pDK)
        {
            if (DonViHopLe(pDK))
            {
                PhamMem.db.SubmitChanges();
            }
            return query.ToList();
        }
        #endregion
    }
}
