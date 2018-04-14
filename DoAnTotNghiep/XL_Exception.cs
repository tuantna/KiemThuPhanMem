using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

    //Nhà Cung Cấp
    public class CapNhatNhaCCException : Exception
    {
        public string Mess { get; set; }
        public CapNhatNhaCCException()
        {
        }
    }
    public class DeleteNhaCCPNException: Exception
    {
        public string Mess { get; private set; }
        public DeleteNhaCCPNException()
        { 
            Mess = "Nhà cung cấp này đã có trong Phiếu nhập, không thể hủy được!";
        }
    }
    // Tinh trang
    public class CapNhatTinhTrangException : Exception
    {
        public string Mess { get; set; }
        public CapNhatTinhTrangException()
        {
        }
    }
    public class DeleteTinhTrangException : Exception
    {
        public string Mess { get; private set; }
        public DeleteTinhTrangException()
        {
            Mess = "Tên tình trạng này đã có trong thiết bị, không thể hủy được!";
        }
    }     
    //DVT
    public class CapNhatDVTException : Exception
    {
        public string Mess { get; set; }
        public CapNhatDVTException()
        {
        }
    }
    public class DeleteDVTException : Exception
    {
        public string Mess { get; private set; }
        public DeleteDVTException()
        {
            Mess = "Đơn vị tính này đã có trong Thiết Bị, không thể hủy được!";
        }
    }
    //NSX
    public class CapNhatNSXException : Exception
    {
        public string Mess { get; set; }
        public CapNhatNSXException()
        {
        }
    }
    public class DeleteNSXException : Exception
    {
        public string Mess { get; private set; }
        public DeleteNSXException()
        {
            Mess = "Tên nước SX này đã có trong Thiết Bị, không thể hủy được!";
        }
    }
    //DonVi
    public class CapNhatDonViException : Exception
    {
        public string Mess { get; set; }
        public CapNhatDonViException()
        {
        }
    }
    public class DeleteDonViException : Exception
    {
        public string Mess { get; private set; }
        public DeleteDonViException()
        {
            Mess = "Đơn vị tính này đã có nhân viên, không thể hủy được!";
        }
    }
    //Chuc Vu
    public class CapNhatChucVuException : Exception
    {
        public string Mess { get; set; }
        public CapNhatChucVuException()
        {
        }
    }
    public class DeleteChucVuException : Exception
    {
        public string Mess { get; private set; }
        public DeleteChucVuException()
        {
            Mess = "Chức vụ này đã có trong Nhân viên, không thể hủy được!";
        }
    }
    //Nguoi Dung
    public class CapNhatNguoiDungException : Exception
    {
        public string Mess { get; set; }
        public CapNhatNguoiDungException()
        {
        }
    }
    public class DeleteNguoiDungException : Exception
    {
        public string Mess { get; private set; }
        public DeleteNguoiDungException()
        {
            Mess = "Tài khoản này đã có Nhập thiết bị, không thể hủy được!";
        }
    }
    //NhanCien
    public class CapNhatNhanVienException : Exception
    {
        public string Mess { get; set; }
        public CapNhatNhanVienException()
        {
        }
    }
    public class DeleteNhanVienDDException : Exception
    {
        public string Mess { get; private set; }
        public DeleteNhanVienDDException()
        {
            Mess = "Nhân viên này đã có trong Đại diện KKê, không thể hủy được!";
        }
    }
    public class DeleteNhanVienNDungException : Exception
    {
        public string Mess { get; private set; }
        public DeleteNhanVienNDungException()
        {
            Mess = "Nhân viên này đã tạo mật khẩu, không thể hủy được!";
        }
    }
    //ThietBi
    public class CapNhatThietBiException : Exception
    {
        public string Mess { get; set; }
        public CapNhatThietBiException()
        {
        }
    }
    public class DeleteThietBiCTPNException : Exception
    {
        public string Mess { get; private set; }
        public DeleteThietBiCTPNException()
        {
            Mess = "Thiết bị này đã nhập hàng, không thể hủy được!";
        }
    }
    public class DeleteThietBiCTBGException : Exception
    {
        public string Mess { get; private set; }
        public DeleteThietBiCTBGException()
        {
            Mess = "Thiết bị này đã được bàn giao, không thể hủy được!";
        }
    }
    public class DeleteThietBiSTDException : Exception
    {
        public string Mess { get; private set; }
        public DeleteThietBiSTDException()
        {
            Mess = "Thiết bị này có trong phòng ban, không thể hủy được!";
        }
    }
    public class DeleteThietBiPKEException : Exception
    {
        public string Mess { get; private set; }
        public DeleteThietBiPKEException()
        {
            Mess = "Thiết bị này có trong kiểm kê, không thể hủy được!";
        }
    }
    public class DeleteThietBiCTTLyException : Exception
    {
        public string Mess { get; private set; }
        public DeleteThietBiCTTLyException()
        {
            Mess = "Thiết bị này có trong phiếu thanh lý, không thể hủy được!";
        }
    }

    //Phòng ban
    public class CapNhatPhongBanException : Exception
    {
        public string Mess { get; set; }
        public CapNhatPhongBanException()
        {
        }
    }
    public class DeletePhongBanDOKKException : Exception
    {
        public string Mess { get; private set; }
        public DeletePhongBanDOKKException()
        {
            Mess = "Phòng ban này đã có trong Đợt kiểm kê, không thể hủy được!";
        }
    }
    public class DeletePhongBanSTDxception : Exception
    {
        public string Mess { get; private set; }
        public DeletePhongBanSTDxception()
        {
            Mess = "Phòng ban này đã có thiết, không thể hủy được!";
        }
    }
    public class DeletePhongBanPNhapxception : Exception
    {
        public string Mess { get; private set; }
        public DeletePhongBanPNhapxception()
        {
            Mess = "Phòng ban này đã nhập thiết bị, không thể hủy được!";
        }
    }
    public class DeletePhongBanBanGiaoxception : Exception
    {
        public string Mess { get; private set; }
        public DeletePhongBanBanGiaoxception()
        {
            Mess = "Phòng ban này có trong Phiếu nhập, không thể hủy được!";
        }
    }
    //CTPN
    public class CapNhatCTPNException : Exception
    {
        public string Mess { get; set; }
        public CapNhatCTPNException()
        {
        }
    }
    public class DeleteCTPNhapException : Exception
    {
        public string Mess { get; private set; }
        public DeleteCTPNhapException()
        {
            Mess = "Phiếu nhập này đã có trong CTPNhập";
        }
    }
   /////
    //LoaiTB
    public class CapNhatLoaiTBException : Exception
    {
        public string Mess { get; set; }
        public CapNhatLoaiTBException()
        {
        }
    }
    public class DeleteLoaiTBException : Exception
    {
        public string Mess { get; private set; }
        public DeleteLoaiTBException()
        {
            Mess = "Loại thiết bị này đã có thiết bị !! Không thể xóa được";
        }
    }
    /////
    //Thanh Lý
    public class CapNhatThanhLyException : Exception
    {
        public string Mess { get; set; }
        public CapNhatThanhLyException()
        {
        }
    }
    public class DeleteThanhLyException : Exception
    {
        public string Mess { get; private set; }
        public DeleteThanhLyException()
        {
            Mess = "Loại thiết bị này đã có thiết bị !! Không thể xóa được";
        }
    }
    /////
//Lỗi chung Database
    public class DatabaseException : Exception
    {
        public string Mess { get; private set; }
        public DatabaseException()
        {
            Mess = "Lỗi trên CSDL: " + Message ;
        }
    }



