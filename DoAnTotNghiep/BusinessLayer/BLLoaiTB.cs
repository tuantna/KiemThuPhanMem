using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DoAnTotNghiep.DataAcessLayer;
using System.Data.Linq;

namespace DoAnTotNghiep.BusinessLayer
{
    public class BLLoaiTB
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
        Table<LOAITHIETBI> query;
        public BLLoaiTB()
        {
            query = PhamMem.db.LOAITHIETBIs;
        }
        #endregion

        #region Xử lý đọc dữ liệu
        public IList<LOAITHIETBI> DocLoaiTBi()
        {
            return query.ToList();
            //var n = from nc in query
            //        select new { nc.LoaiTBID, nc.TenLoaiTB, nc.TYLEHAOMON.TLHaoMon, nc.DienGiaiLTB, nc.TLHaoMonID };

            //return n.Cast<object>().ToList();
        }       
        public IList<object> DocLoaiTB()
        {
           // return query.ToList();
            var n = from nc in query
                    select new { nc.LoaiTBID, nc.TenLoaiTB,nc.DienGiaiLTB };

            return n.Cast<object>().ToList();      
        }
        public IList<object> DocLoaiTBheodieukien(string pDK)
        {
            var q = from nc in query
                    where nc.TenLoaiTB.ToUpper().Contains(pDK.ToUpper())
                    select new {nc.LoaiTBID,nc.TenLoaiTB,nc.DienGiaiLTB};

            return q.Cast<object>().ToList();           
        }
        #endregion

        #region Kiểm tra
        private bool LoaiTBHopLe(LOAITHIETBI pLoaiTB)
        {
            StringBuilder loi = new StringBuilder();
            if (string.IsNullOrEmpty(pLoaiTB.TenLoaiTB))
                loi.AppendLine(" Tên loại thiết bị  bị rỗng");          

            if (!string.IsNullOrEmpty(loi.ToString()))
                throw new CapNhatLoaiTBException { Mess = loi.ToString() };

            return true;
        }
        private bool KiemTraLoaiThietBi(LOAITHIETBI pLoaiTB)
        {
            BLThietBi BTB = new BLThietBi();
            int dem = BTB.DocThietBiTheoLoaiTB(pLoaiTB.LoaiTBID).Count;
            return (dem > 0);
           // return false;

        }
        #endregion


        #region Cập nhật dữ liệu
        public IList<LOAITHIETBI> Them(LOAITHIETBI pTB)
        {
            if (LoaiTBHopLe(pTB))
            {
                query.InsertOnSubmit(pTB);
                PhamMem.db.SubmitChanges();
            }
            return query.ToList();
        }
        public IList<LOAITHIETBI> Xoa(LOAITHIETBI pTB)
        {
            if (KiemTraLoaiThietBi(pTB))
                throw new DeleteLoaiTBException();   //ném ngoại lệ lên Presentation Layer
            else
            {
                // var d = DocNhaCCTheoID(pNh.NhaCCID);
                query.DeleteOnSubmit(pTB);
                PhamMem.db.SubmitChanges();
                return query.ToList();
            }
        }
        public IList<LOAITHIETBI> CapNhat(LOAITHIETBI pLoaiTB)
        {
            if (LoaiTBHopLe(pLoaiTB))
            {
                PhamMem.db.SubmitChanges();
            }
            return query.ToList();
        }
        #endregion
    }
}
