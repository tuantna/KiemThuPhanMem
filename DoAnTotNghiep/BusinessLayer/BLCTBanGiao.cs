using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DoAnTotNghiep.DataAcessLayer;
using System.Data.Linq;

namespace DoAnTotNghiep.BusinessLayer
{
    public class BLCTBanGiao
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
        Table<CHITIETBANGIAO> query;
        public BLCTBanGiao()
        {
            query = PhamMem.db.CHITIETBANGIAOs;
        }
        #endregion

        #region Xử lý đọc dữ liệu
        //public IList<CHITIETPNHAP> DocThietBi()
        //{
        //    return query.ToList();
        //}
        //public IList<object> DocCTPNhapToObject(int pPNhapID)
        //{

        //    var Ct = (from ct in PhamMem.db.CHITIETPNHAPs
        //              where ct.PhieuNhapID == pPNhapID
        //              select new { ct.PhieuNhapID,ct.THIETBI.MaThietBi, ct.THIETBI.TenTB,ct.THIETBI.DVTINH.TenDVT, ct.SoLuongNhap, ct.dongia, ct.ThietBiID }
        //            ).Cast<object>().ToList();
        //    return Ct;

        //}
        //public CHITIETPNHAP DocCTPNhapTheoID(int pPNhapID, int pTBID)
        //{
        //    return query.Where(CHITIETPNHAP => CHITIETPNHAP.PhieuNhapID == pPNhapID && CHITIETPNHAP.ThietBiID == pTBID).FirstOrDefault();
        //}
        //public double TongTienNhapTheoPhieu(int pPNhapID)
        //{
        //    string Lenh = "Select Sum(SoLuongNhap * dongia) From CHITIETPNHAP Where PhieuNhapID=" + pPNhapID;
        //    double tien = double.Parse(ThucHienLenhTinhToan(Lenh).ToString());
        //    return tien;
        //}
        public IList<CHITIETBANGIAO> DocCTBGTheoTBID(int pTBID)
        {
            IList<CHITIETBANGIAO> dh = query.Where(x => x.ThietBiID == pTBID).ToList();
            return dh;
        }
        #endregion

        #region Kiểm tra
        private bool CTPNhapHopLe(CHITIETPNHAP pCTPNhap, int pSL)
        {
            StringBuilder loi = new StringBuilder();
            if (pCTPNhap.SoLuongNhap <= 0)
                loi.AppendLine("Số lượng không được âm");
            if (pCTPNhap.dongia < 0)
                loi.AppendLine("Đơn gía không được âm");
            // Tinh so luong nhap
            int slgiam = pSL - pCTPNhap.SoLuongNhap.Value;         
            //BLPNhap PNhapBL = new BLPNhap();
            //PNhap pn = PNhapBL.DocPNhapTheoID(pCTPNhap.PNhapID);          
           
            if (!string.IsNullOrEmpty(loi.ToString()))
                throw new CapNhatCTPNException { Mess = loi.ToString() };

            return true;
        }

        private bool KiemTraPhieuNhap(CHITIETPNHAP pCTPNhap)
        {
            //BLTonKho Btk = new BLTonKho();
            //int dem=Btk.DocTonKhoTheoVatTu(pCTPNhap.VatTuID).Count;
            //return (dem > 0);
            return false;
        }

        #endregion



        #region Cập nhật dữ liệu
        public IList<CHITIETBANGIAO> Them(CHITIETBANGIAO pCTBG)
        {
           // if (CTPNhapHopLe(pCTPNhap, pSL))
            //{
                query.InsertOnSubmit(pCTBG);
                PhamMem.db.SubmitChanges();
            //}
            return query.ToList();
        }
        //public IList<CHITIETPNHAP> Xoa(CHITIETPNHAP pCTPNhap)
        //{
        //    if (KiemTraPhieuNhap(pCTPNhap))
        //        throw new DeleteCTPNhapException();   //ném ngoại lệ lên Presentation Layer
        //    else
        //    {
        //        var d = DocCTPNhapTheoID(pCTPNhap.PhieuNhapID, pCTPNhap.ThietBiID);
        //        query.DeleteOnSubmit(d);
        //        PhamMem.db.SubmitChanges();
        //        return query.ToList();
        //    }
        //}
        //public IList<CHITIETPNHAP> CapNhat(CHITIETPNHAP pCTPNhap, int pSL)
        //{
        //    if (CTPNhapHopLe(pCTPNhap, pSL))
        //    {
        //        PhamMem.db.SubmitChanges();
        //    }
        //    return query.ToList();
        //}
        #endregion
    }
}
