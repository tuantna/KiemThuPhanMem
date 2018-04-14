using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DoAnTotNghiep.DataAcessLayer;
using System.Data.Linq;

namespace DoAnTotNghiep.BusinessLayer
{
    public class BLNuocSX
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
        Table<NUOCSX> query;
        public BLNuocSX()
        {
            query = PhamMem.db.NUOCSXes;
        }
        #endregion

        #region Xử lý đọc dữ liệu
        public IList<NUOCSX> DocNSX()
        {
            return query.ToList();
        }
        //public IList<NUOCSX> DocDVTTheodieukien(string pDK)
        //{
        //    var q = from nc in query
        //            where nc.TenDVT.ToUpper().Contains(pDK.ToUpper())
        //            select nc;
        //    return q.ToList();
        //    //pDK = pDK.ToUpper();
        //    //return query.Where(nc=>nc.TenNhaCc.ToUpper().Contains(pDK.ToUpper())).ToList();

        //    //return query.ToList().FindAll(delegate(NhaCC nh) { return nh.TenNhaCc.ToUpper().Contains(pDK); });
        //}
        #endregion

        #region Kiểm tra
        private bool NSXHopLe(NUOCSX pDVT)
        {
            StringBuilder loi = new StringBuilder();
            if (string.IsNullOrEmpty(pDVT.TenNuoc))
                loi.AppendLine("Tên nước sản xuất tính bị rỗng");          

            if (!string.IsNullOrEmpty(loi.ToString()))
                throw new CapNhatNSXException { Mess = loi.ToString() };

            return true;
        }
        private bool KiemTraNSX(NUOCSX pnsx)
        {
            BLThietBi BPN = new BLThietBi();
            int dem = BPN.DocThietBiTheoNSX(pnsx.NUOCSXID).Count;
            return (dem > 0);
            //return false;

        }
        #endregion


        #region Cập nhật dữ liệu
        public IList<NUOCSX> Them(NUOCSX pNh)
        {
            if (NSXHopLe(pNh))
            {
                query.InsertOnSubmit(pNh);
                PhamMem.db.SubmitChanges();
            }
            return query.ToList();
        }
        public IList<NUOCSX> Xoa(NUOCSX pNh)
        {
            if (KiemTraNSX(pNh))
                throw new DeleteNSXException();   //ném ngoại lệ lên Presentation Layer
            else
            {
                // var d = DocNhaCCTheoID(pNh.NhaCCID);
                query.DeleteOnSubmit(pNh);
                PhamMem.db.SubmitChanges();
                return query.ToList();
            }
        }
        public IList<NUOCSX> CapNhat(NUOCSX pnsx)
        {
            if (NSXHopLe(pnsx))
            {
                PhamMem.db.SubmitChanges();
            }
            return query.ToList();
        }
        #endregion
    }
}
