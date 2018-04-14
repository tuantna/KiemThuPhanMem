using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using DoAnTotNghiep.DataAcessLayer;
using DoAnTotNghiep.BusinessLayer;
using System.Data.Linq;

namespace DoAnTotNghiep.PresentationLayer
{
    public partial class DangNhap : Office2007Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }
        bool co = true;
        private static byte solan = 0;
        BLNguoiDung DsNguoiDung = new BLNguoiDung();
        BLNhanVien DsNhanVien = new BLNhanVien();
        BLDonVi DonViBL = new BLDonVi();
        List<object> dsNDung =new List<object>();

        private void btnDongY_Click(object sender, EventArgs e)
        {
            //kiểm tra và xử lý
            NguoiDung nd = DsNguoiDung.DocNguoiDungTheoMaDangNhap(txtMa.Text);

            //string ten = "123";
            //Binary mahoa = new byte[150];
            //PhamMem.db.prMaHoa(ten, ref mahoa);
            //string chuoi = null;
            //PhamMem.db.prGiaiMa(mahoa, ref chuoi);
            //nd.MatKhau = mahoa;
            //PhamMem.db.SubmitChanges();

            if (nd != null)
            {
                NHANVIEN nv = DsNhanVien.DocNhanVienTheoID((int)nd.NhanVienID);
               // DsNguoiDung.GiaiMaMatKhau(nd.MatKhau)

                if (txtMatKhau.Text == nd.MatKhau.ToString())
                {
                    PhamMem.idMa = nd.NguoiDungID;
                    PhamMem.Madn = nd.MaDangNhap;
                    PhamMem.Matkhau = txtMatKhau.Text;
                    PhamMem.MaNV = nv.MaNV;
                    PhamMem.QuyenID = nd.QuyenID;
                    PhamMem.DonViID = nv.DonViID;
                    //MessageBox.Show(nv.DonViID.ToString());

                    co = true;                   
                    PhamMem.codangnhap = true;
                    this.Close();
                }
                else
                {
                    solan++;
                    lbthongbao.Text = "Mật khẩu sai, vui lòng nhập lại";
                    txtMatKhau.Focus();
                    co = false;
                }
            }
            else
            {
                solan++;
                co = false;
                lbthongbao.Text = "Mã đăng nhập sai, vui lòng nhập lại";
                txtMa.Focus();
            }
            if (solan >= 3) Application.Exit();  
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (PhamMem.Madn == null)
            {
                PhamMem.codangnhap = false;
                Application.Exit();
            }
            else
                this.Close();
                //Application.Exit();
        }

        private void DangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (solan < 3 && co == false) e.Cancel = true;
        }

        private void DangNhap_Load(object sender, EventArgs e)
        {
            txtMa.Focus();
        }

        
          
    }
}
