using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DoAnTotNghiep.DataAcessLayer;
using System.Data.Linq;

namespace DoAnTotNghiep.BusinessLayer
{
    public class BLDVTinh
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
        Table<DVTINH> query;
        public BLDVTinh()
        {
            query = PhamMem.db.DVTINHs;
        }
        #endregion

        #region Xử lý đọc dữ liệu
        public IList<DVTINH> DocDVT()
        {
            return query.ToList();
        }
        public IList<DVTINH> DocDVTTheodieukien(string pDK)
        {
            var q = from nc in query
                    where nc.TenDVT.ToUpper().Contains(pDK.ToUpper())
                    select nc;
            return q.ToList();
            //pDK = pDK.ToUpper();
            //return query.Where(nc=>nc.TenNhaCc.ToUpper().Contains(pDK.ToUpper())).ToList();

            //return query.ToList().FindAll(delegate(NhaCC nh) { return nh.TenNhaCc.ToUpper().Contains(pDK); });
        }
        #endregion

        #region Kiểm tra
        private bool DVTHopLe(DVTINH pDVT)
        {
            StringBuilder loi = new StringBuilder();
            if (string.IsNullOrEmpty(pDVT.TenDVT))
                loi.AppendLine("Tên đơn vị tính bị rỗng");          

            if (!string.IsNullOrEmpty(loi.ToString()))
                throw new CapNhatDVTException { Mess = loi.ToString() };

            return true;
        }
        private bool KiemTraThietBi(DVTINH pNhacc)
        {
            BLThietBi BPN = new BLThietBi();
            int dem = BPN.DocLoaiThietBiTheoDV(pNhacc.DVTID).Count;
            return (dem > 0);
            //return false;

        }
        #endregion


        #region Cập nhật dữ liệu
        public IList<DVTINH> Them(DVTINH pNh)
        {
            if (DVTHopLe(pNh))
            {
                query.InsertOnSubmit(pNh);
                PhamMem.db.SubmitChanges();
            }
            return query.ToList();
        }
        public IList<DVTINH> Xoa(DVTINH pNh)
        {
            if (KiemTraThietBi(pNh))
                throw new DeleteDVTException();   //ném ngoại lệ lên Presentation Layer
            else
            {
                // var d = DocNhaCCTheoID(pNh.NhaCCID);
                query.DeleteOnSubmit(pNh);
                PhamMem.db.SubmitChanges();
                return query.ToList();
            }
        }
        public IList<DVTINH> CapNhat(DVTINH pNhacc)
        {
            if (DVTHopLe(pNhacc))
            {
                PhamMem.db.SubmitChanges();
            }
            return query.ToList();
        }
        #endregion
    }
}
