using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DoAnTotNghiep.DataAcessLayer;
using System.Data.Linq;

namespace DoAnTotNghiep.BusinessLayer
{
    public class BLCTThanhLy
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
        Table<CHITIETTHANHLY> query;
        public BLCTThanhLy()
        {
            query = PhamMem.db.CHITIETTHANHLies;
        }
        #endregion

        #region Xử lý đọc dữ liệu
        public IList<CHITIETTHANHLY> DocCTTLyTheoTBID(int pTBID)
        {
            IList<CHITIETTHANHLY> dh = query.Where(x => x.ThietBiID == pTBID).ToList();
            return dh;
        }
        public IList<CHITIETTHANHLY> DocCTTLyTheoThanhLyID(int pTBID)
        {
            IList<CHITIETTHANHLY> dh = query.Where(x => x.ThanhLyID == pTBID).ToList();
            return dh;
        }
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

        #endregion

        #region Kiểm tra
        private bool CTPNhapHopLe(CHITIETTHANHLY pCTPNhap)
        {
           // int a=0;
            StringBuilder loi = new StringBuilder();
            if ((int)pCTPNhap.GiaTriThanhLy <= 0)
                loi.AppendLine("Giá bán không được âm");
            if (string.IsNullOrEmpty(pCTPNhap.GiaTriThanhLy.ToString()))
                loi.AppendLine("Giá bán không được để rỗng");
            if (!string.IsNullOrEmpty(loi.ToString()))
                throw new CapNhatThanhLyException { Mess = loi.ToString() };

            return true;
        }

        //private bool KiemTraPhieuNhap(CHITIETPNHAP pCTPNhap)
        //{
        //    //BLTonKho Btk = new BLTonKho();
        //    //int dem=Btk.DocTonKhoTheoVatTu(pCTPNhap.VatTuID).Count;
        //    //return (dem > 0);
        //    return false;
        //}

        #endregion



        #region Cập nhật dữ liệu
        public IList<CHITIETTHANHLY> Them(CHITIETTHANHLY pCTBG)
        {
            if (CTPNhapHopLe(pCTBG))
            {
                query.InsertOnSubmit(pCTBG);
                PhamMem.db.SubmitChanges();
            }
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
