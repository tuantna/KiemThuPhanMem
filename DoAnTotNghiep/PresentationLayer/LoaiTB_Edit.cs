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
    public partial class LoaiTB_Edit : Office2007Form
    {       
        public LoaiTB_Edit()
        {
            InitializeComponent();            
        }        
        BLLoaiTB LoaiTBBL = new BLLoaiTB();       
        IList<LOAITHIETBI> DsLoaiTB = new List<LOAITHIETBI>();      
        public LOAITHIETBI Loai= null;
       
        void Nhap_LoaiTB()
        {
            if (Loai == null) Loai = new LOAITHIETBI();
            Loai.TenLoaiTB = txttenloaiTB.Text;
            Loai.DienGiaiLTB = txtdiengiai.Text;           
            
        }
        void xuat_LoaiTB()
        {
            txttenloaiTB.Text = Loai.TenLoaiTB;
            txtdiengiai.Text = Loai.DienGiaiLTB;          
            txttenloaiTB.Select();
        }
        void Xuat_LoaiTB_moi()
        {
            txttenloaiTB.Text = "";
            txtdiengiai.Text = "";          
            txttenloaiTB.Select();
        }   
        private void btnthoat_Click(object sender, EventArgs e)
        {
            //if (MessageBox.Show("Bạn muốn thoát không??", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            //{
                this.Close();
            //}
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            try
            {
                if (Loai != null)
                {
                    Nhap_LoaiTB();
                    DsLoaiTB = LoaiTBBL.CapNhat(Loai);
                    this.Close();
                }
                else
                {
                    if (btnluu.Text == "Lưu Lại")
                    {
                        Nhap_LoaiTB();
                        LoaiTBBL.Them(Loai);
                        MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnluu.Text = "Thêm Mới";

                    }
                    else
                    {
                        Xuat_LoaiTB_moi();
                        btnluu.Text = "Lưu Lại";
                    }
                    Loai = null;
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
            if (Loai==null)
            {
                Xuat_LoaiTB_moi();               
            }
            else
            {
                xuat_LoaiTB();               
            }
        }

    }
}
