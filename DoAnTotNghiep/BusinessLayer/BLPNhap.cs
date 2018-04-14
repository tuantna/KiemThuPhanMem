using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DoAnTotNghiep.DataAcessLayer;
using System.Data.Linq;

namespace DoAnTotNghiep.BusinessLayer
{
    public class BLPNhap
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
        Table<PHIEUPHAP> query;
        public BLPNhap()
        {
            query = PhamMem.db.PHIEUPHAPs;
        }
        #endregion

        #region Xử lý đọc dữ liệu
        public IList<PHIEUPHAP> DocPNhap()
        {
            return query.ToList();
        }
        public PHIEUPHAP DocPNhapTheoID(int pPNhapID)
        {
            return query.Where(PNhap => PNhap.PhieuNhapID == pPNhapID).FirstOrDefault();
        }
        public IList<PHIEUPHAP> DocPNhapTheoPBID(int LoaiTB)
        {
            IList<PHIEUPHAP> dh = query.Where(x => x.PhongBanID == LoaiTB).ToList();
            return dh;
        }
        public IList<PHIEUPHAP> DocPNhapTheoNDungID(int LoaiTB)
        {
            IList<PHIEUPHAP> dh = query.Where(x => x.NguoiDungID == LoaiTB).ToList();
            return dh;
        }
        public IList<PHIEUPHAP> DocPNhapTheoNhaCCID(int LoaiTB)
        {
            IList<PHIEUPHAP> dh = query.Where(x => x.NCCID == LoaiTB).ToList();
            return dh;
        }
        public PHIEUPHAP DocPNhapTheongay(DateTime ngay)
        {
            return query.Where(PNhap => PNhap.NgayNhap == ngay).FirstOrDefault();
        }
        public IList<PHIEUPHAP> DoPhieuNhapTheodieukien(int pDK)
        {
            var q = from nc in query
                    where nc.PhieuNhapID.ToString().Contains(pDK.ToString())
                    select nc;
            return q.ToList();
        }
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

        private bool KiemTraCTPN(PHIEUPHAP pDH)
        {
            BLCTPNhap Bdh = new BLCTPNhap();
            int dem = Bdh.DocCTPNTheoID(pDH.PhieuNhapID).Count;
            return (dem > 0);
           // return false;		
        }
        #endregion

        #region Cập nhật dữ liệu
        public IList<PHIEUPHAP> Them(PHIEUPHAP pNh)
        {
            //if (NhaCCHopLe(pNh))
            //{
                query.InsertOnSubmit(pNh);
                PhamMem.db.SubmitChanges();
           // }
            return query.ToList();
        }
        public IList<PHIEUPHAP> Xoa(PHIEUPHAP pDH)
        {
            if (KiemTraCTPN(pDH))
                throw new DeleteCTPNhapException();   //ném ngoại lệ lên Presentation Layer
            else
            {
               // var d = DocNhaCCTheoID(pNh.NhaCCID);
                query.DeleteOnSubmit(pDH);
                PhamMem.db.SubmitChanges();
                return query.ToList();
            }
        }
        public IList<PHIEUPHAP> CapNhat(PHIEUPHAP pNhacc)
        {
           // if (NhaCCHopLe(pNhacc))
           // {
                PhamMem.db.SubmitChanges();
           // }
            return query.ToList();
        }
        #endregion    
    }
}
