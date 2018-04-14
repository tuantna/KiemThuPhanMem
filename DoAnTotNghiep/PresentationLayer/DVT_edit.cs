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
    public partial class DVT_edit : Office2007Form
    {
        public DVT_edit()
        {
            InitializeComponent();
        }
        BLDVTinh DVTBL = new BLDVTinh();
        IList<DVTINH> DsDVT = new List<DVTINH>();
        public DVTINH dvt = null;
        void Nhap_DVT()
        {
            if (dvt == null) dvt = new DVTINH();
            dvt.TenDVT = txttendv.Text;
            dvt.DienGiaiDVT = txtdiengiai.Text;
        }
        public void xuat_DVT_moi()
        {
           txttendv.Text="";
           txtdiengiai.Text="";
           txttendv.Select();
           this.Text = "Thêm đơn vị tính";
        }
        public void xuat_DVT_edit()
        {
            txttendv.Text =dvt.TenDVT;
            txtdiengiai.Text =dvt.DienGiaiDVT;
            txttendv.Select();
            this.Text = "Cập nhật đơn vị tính";
           
        }

        private void DVT_edit_Load(object sender, EventArgs e)
        {
            if (dvt == null)
            {
                xuat_DVT_moi();

            }
            else
            {
                xuat_DVT_edit();
            }
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            try
            {
                if (dvt == null)
                {
                    if (btnluu.Text == "Lưu")
                    {
                        Nhap_DVT();
                        DVTBL.Them(dvt);
                        MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnluu.Text = "Thêm Mới";

                    }
                    else
                    {
                        xuat_DVT_moi();
                        btnluu.Text = "Lưu";
                    }
                    dvt = null;
                }
                else
                {
                    Nhap_DVT();
                    DsDVT = DVTBL.CapNhat(dvt);
                    this.Close();
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

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
