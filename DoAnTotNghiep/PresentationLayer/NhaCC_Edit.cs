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
    public partial class NhaCC_Edit : Office2007Form
    {
        public NhaCC_Edit()
        {
            InitializeComponent();
        }
        BLNhaCC NhaCCBL = new BLNhaCC();
        IList<NHACUNGCAP> DsNhaCC = new List<NHACUNGCAP>();
        public NHACUNGCAP Nhacc=null;     
        void Nhap_NhaCC()
        {
            if(Nhacc ==null)Nhacc = new NHACUNGCAP();
            Nhacc.TenNhaCC = txtTenNhaCC.Text;
            Nhacc.HoTenNguoiLH = txtHoTenNguoiLH.Text;
            Nhacc.ChucVuNLH = txtchucvu.Text;
            Nhacc.DiaChiNhaCC = txtdiachi.Text;
            Nhacc.DienThoaiNhaCC = txtdienthoai.Text;
            Nhacc.Sofax = Convert.ToInt32(txtsofax.Text);
            Nhacc.Email = txtemail.Text;
            Nhacc.Wesite = txtwebsite.Text;
            Nhacc.GhiChuNhaCC = txtghichu.Text;
        }
        void xuat_NhaCC()
        {
            txtTenNhaCC.Text = Nhacc.TenNhaCC;
            txtHoTenNguoiLH.Text=Nhacc.HoTenNguoiLH;
            txtchucvu.Text=Nhacc.ChucVuNLH;
            txtdiachi.Text=Nhacc.DiaChiNhaCC;
            txtdienthoai.Text=Nhacc.DienThoaiNhaCC;
            txtsofax.Text=Convert.ToString(Nhacc.Sofax);
            txtemail.Text=Nhacc.Email;
            txtwebsite.Text=Nhacc.Wesite;
            txtghichu.Text=Nhacc.GhiChuNhaCC;
        }
        void Xuat_NhaCC_moi()
        {
            txtTenNhaCC.Text = "";
            txtHoTenNguoiLH.Text = "";
            txtchucvu.Text = "";
            txtdiachi.Text = "";
            txtdienthoai.Text = "";
            txtsofax.Text = "";
            txtemail.Text = "";
            txtwebsite.Text = "";
            txtghichu.Text = "";
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {           
            this.Close();           
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            try
            {                          
                if (Nhacc != null)
                {
                    Nhap_NhaCC(); 
                    DsNhaCC = NhaCCBL.CapNhat(Nhacc);
                    this.Close();
                }
                else
                {
                    if (btnluu.Text == "Lưu Lại")
                     {
                        Nhap_NhaCC(); 
                        NhaCCBL.Them(Nhacc);              
                        MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnluu.Text = "Thêm NhàCC";
                        
                     }
                    else
                    {
                        Xuat_NhaCC_moi();
                        btnluu.Text = "Lưu Lại";
                    }
                    Nhacc = null;
                }                      
            }
            catch (CapNhatNhaCCException ex)
            {
                MessageBox.Show(ex.Mess);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi trong quá trình cập nhật dữ liệu: Lỗi:" + ex.Message);
            }
        }

        private void NhaCC_Edit_Load(object sender, EventArgs e)
        {
            if (Nhacc != null)
                xuat_NhaCC();
            else
                Xuat_NhaCC_moi();
        }
        public NHACUNGCAP Vt { get; set; }
    }
}
