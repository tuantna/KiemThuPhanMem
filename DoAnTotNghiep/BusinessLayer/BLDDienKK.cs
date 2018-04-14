using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DoAnTotNghiep.DataAcessLayer;
using System.Data.Linq;

namespace DoAnTotNghiep.BusinessLayer
{
    public class BLDDienKK
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
        Table<DAIDIENKIEMKE> query;
        public BLDDienKK()
        {
            query = PhamMem.db.DAIDIENKIEMKEs;
        }
        #endregion

        #region Xử lý đọc dữ liệu
        public IList<DAIDIENKIEMKE> DocDDKK()
        {
            return query.ToList();
        }
        public DAIDIENKIEMKE DocDDKKTheoID(int PKK)
        {
            return query.Where(DAIDIENKIEMKE => DAIDIENKIEMKE.KiemKeID == PKK).FirstOrDefault();
        }
        public IList<DAIDIENKIEMKE> DocDDKKTheoNVID(int pTBID)
        {
            IList<DAIDIENKIEMKE> dh = query.Where(x => x.NhanVienID == pTBID).ToList();
            return dh;
        }
        //public IList<DOTKIEMKE> DoDKKTheodieukien(int pDK)
        //{
        //    var q = from nc in query
        //            where nc.KiemKeID.ToString().Contains(pDK.ToString())
        //            select nc;
        //    return q.ToList();
        //}
        #endregion
       

        #region Kiểm tra
        //private bool DonDHHopLe(DonDH pDonDH)
        //{
        //    StringBuilder loi = new StringBuilder();
        //    if (string.IsNullOrEmpty(pDonDH.TenNhaCc))
        //        loi.AppendLine("Tên nhà cung cấp bị rỗng");

        //    if (string.IsNullOrEmpty(pNhacc.DiaChi))
        //        loi.AppendLine("Địa chỉ nhà cung cấp bị rỗng");

        //    if (!string.IsNullOrEmpty(loi.ToString()))
        //        throw new CapNhatNhaCCException { Mess = loi.ToString() };

        //    return true;
        //}

        private bool KiemTraDonHang(DOTKIEMKE pDH)
        {
            //BLDonDH Bdh = new BLDonDH();
            //int dem = Bdh.DocDonDHTheoNhaCC(pNhacc.NhaCCID).Count;
            //return (dem > 0);
            return false;		
        }
        #endregion

        #region Cập nhật dữ liệu
        public IList<DAIDIENKIEMKE> Them(DAIDIENKIEMKE pNh)
        {
            //if (NhaCCHopLe(pNh))
            //{
            query.InsertOnSubmit(pNh);
            PhamMem.db.SubmitChanges();
            // }
            return query.ToList();
        }
        //public IList<DOTKIEMKE> Xoa(DOTKIEMKE pDH)
        //{
        //    if (KiemTraDonHang(pDH))
        //        throw new DeleteCTPNhapException();   //ném ngoại lệ lên Presentation Layer
        //    else
        //    {
        //        // var d = DocNhaCCTheoID(pNh.NhaCCID);
        //        query.DeleteOnSubmit(pDH);
        //        PhamMem.db.SubmitChanges();
        //        return query.ToList();
        //    }
        //}
        //public IList<DOTKIEMKE> CapNhat(DOTKIEMKE pNhacc)
        //{
        //    // if (NhaCCHopLe(pNhacc))
        //    // {
        //    PhamMem.db.SubmitChanges();
        //    // }
        //    return query.ToList();
        //}
        #endregion    
    }
}
