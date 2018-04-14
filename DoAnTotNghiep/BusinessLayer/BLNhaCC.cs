using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DoAnTotNghiep.DataAcessLayer;
using System.Data.Linq;

namespace DoAnTotNghiep.BusinessLayer
{
    public class BLNhaCC
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
        Table<NHACUNGCAP> query;
        public BLNhaCC()
        {
            query = PhamMem.db.NHACUNGCAPs;
        }
        #endregion

        #region Xử lý đọc dữ liệu
        public IList<NHACUNGCAP> DocNhaCC()
        {
            return query.ToList();
        }
        public IList<NHACUNGCAP> DocNhaCCTheodieukien(string pDK)
        {
            var q = from nc in query
                    where nc.TenNhaCC.ToUpper().Contains(pDK.ToUpper())
                    select nc;
            return q.ToList();
            //pDK = pDK.ToUpper();
            //return query.Where(nc=>nc.TenNhaCc.ToUpper().Contains(pDK.ToUpper())).ToList();

            //return query.ToList().FindAll(delegate(NhaCC nh) { return nh.TenNhaCc.ToUpper().Contains(pDK); });
        }

        public NHACUNGCAP DocNhaCCTheoID(int pTBID)
        {
            return query.Where(NHACUNGCAP => NHACUNGCAP.NCCID == pTBID).FirstOrDefault();
        }
        #endregion

        #region Kiểm tra
        private bool NhaCCHopLe(NHACUNGCAP pNhacc)
        {
            StringBuilder loi = new StringBuilder();
            if (string.IsNullOrEmpty(pNhacc.TenNhaCC))
                loi.AppendLine("Tên nhà cung cấp bị rỗng");
            if (string.IsNullOrEmpty(pNhacc.HoTenNguoiLH))
                loi.AppendLine("Người liên hệ bị rỗng");
            if (string.IsNullOrEmpty(pNhacc.DiaChiNhaCC))
                loi.AppendLine("Địa chỉ nhà cung cấp bị rỗng");

            if (!string.IsNullOrEmpty(loi.ToString()))
                throw new CapNhatNhaCCException { Mess = loi.ToString() };

            return true;
        }
        private bool KiemTraPNhap(NHACUNGCAP pNhacc)
        {
            BLPNhap BPN = new BLPNhap();
            int dem = BPN.DocPNhapTheoNhaCCID(pNhacc.NCCID).Count;
            return (dem > 0);
            //return false;

        }
        #endregion


        #region Cập nhật dữ liệu
        public IList<NHACUNGCAP> Them(NHACUNGCAP pNh)
        {
            if (NhaCCHopLe(pNh))
            {
                query.InsertOnSubmit(pNh);
                PhamMem.db.SubmitChanges();
            }
            return query.ToList();
        }
        public IList<NHACUNGCAP> Xoa(NHACUNGCAP pNh)
        {
            if (KiemTraPNhap(pNh))
                throw new DeleteNhaCCPNException();   //ném ngoại lệ lên Presentation Layer
            else
            {
                // var d = DocNhaCCTheoID(pNh.NhaCCID);
                query.DeleteOnSubmit(pNh);
                PhamMem.db.SubmitChanges();
                return query.ToList();
            }
        }
        public IList<NHACUNGCAP> CapNhat(NHACUNGCAP pNhacc)
        {
            if (NhaCCHopLe(pNhacc))
            {
                PhamMem.db.SubmitChanges();
            }
            return query.ToList();
        }
        #endregion
    }
}
