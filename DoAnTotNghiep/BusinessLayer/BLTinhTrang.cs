using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DoAnTotNghiep.DataAcessLayer;
using System.Data.Linq;

namespace DoAnTotNghiep.BusinessLayer
{
    public class BLTinhTrang
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
        Table<TINHTRANG> query;
        public BLTinhTrang()
        {
            query = PhamMem.db.TINHTRANGs;
        }
        #endregion

        #region Xử lý đọc dữ liệu
        public IList<TINHTRANG> DocTinhTrang()
        {
            return query.ToList();
        }
        public IList<TINHTRANG> DocChucVuTheodieukien(string pDK)
        {
            var q = from nc in query
                    where nc.TenTinhTrang.ToUpper().Contains(pDK.ToUpper())
                    select nc;
            return q.ToList();
            //pDK = pDK.ToUpper();
            //return query.Where(nc=>nc.TenNhaCc.ToUpper().Contains(pDK.ToUpper())).ToList();

            //return query.ToList().FindAll(delegate(NhaCC nh) { return nh.TenNhaCc.ToUpper().Contains(pDK); });
        }
        #endregion

        #region Kiểm tra
        private bool TinhTrangHopLe(TINHTRANG pDVT)
        {
            StringBuilder loi = new StringBuilder();
            if (string.IsNullOrEmpty(pDVT.TenTinhTrang))
                loi.AppendLine("Tên tình trạng bị rỗng");

            if (!string.IsNullOrEmpty(loi.ToString()))
                throw new CapNhatTinhTrangException { Mess = loi.ToString() };

            return true;
        }
        private bool KiemTraTinhTrang(TINHTRANG pCV)
        {
            BLSoTheoDoi NV = new BLSoTheoDoi();
            int dem = NV.DocSTDTheoTrang(pCV.TinhTrangID).Count;
            return (dem > 0);
            //return false;

        }
        #endregion


        #region Cập nhật dữ liệu
        public IList<TINHTRANG> Them(TINHTRANG pNh)
        {
            if (TinhTrangHopLe(pNh))
            {
                query.InsertOnSubmit(pNh);
                PhamMem.db.SubmitChanges();
            }
            return query.ToList();
        }
        public IList<TINHTRANG> Xoa(TINHTRANG pNh)
        {
            if (KiemTraTinhTrang(pNh))
                throw new DeleteTinhTrangException();   //ném ngoại lệ lên Presentation Layer
            else
            {
                // var d = DocNhaCCTheoID(pNh.NhaCCID);
                query.DeleteOnSubmit(pNh);
                PhamMem.db.SubmitChanges();
                return query.ToList();
            }
        }
        public IList<TINHTRANG> CapNhat(TINHTRANG pDK)
        {
            if (TinhTrangHopLe(pDK))
            {
                PhamMem.db.SubmitChanges();
            }
            return query.ToList();
        }
        #endregion
    }
}
