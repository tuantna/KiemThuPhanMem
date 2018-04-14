using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using DoAnTotNghiep.BusinessLayer;
using DoAnTotNghiep.DataAcessLayer;

namespace DoAnTotNghiep.PresentationLayer
{
    public partial class Doi_Mat_Khau : Office2007Form
    {
        public Doi_Mat_Khau()
        {
            InitializeComponent();
        }
        BLNguoiDung NguoiDungBL = new BLNguoiDung();
        
        private void btnDongY_Click(object sender, EventArgs e)
        {
            if (txtmatkhaucu.Text == PhamMem.Matkhau)
            {
                NguoiDung nd = NguoiDungBL.DocNguoiDungTheoMaDangNhap(PhamMem.Madn);
                nd.MatKhau = txtMatKhaumoi.Text;

                NguoiDungBL.CapNhat(nd);
                PhamMem.Matkhau = txtMatKhaumoi.Text;
                this.Close();
            }
            else
            {
                lbthongbao.Text = "Mật khẩu cũ chưa đúng";
                txtmatkhaucu.Focus();
            }
        }

        private void Doi_Mat_Khau_Load(object sender, EventArgs e)
        {
            NguoiDung nd = NguoiDungBL.DocNguoiDungTheoMaDangNhap(PhamMem.Madn);
            this.Text = "Đổi mật khẩu tài khoài: " + nd.MaDangNhap;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
