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
    public partial class DonVi_Edit : Office2007Form
    {
        public DonVi_Edit()
        {
            InitializeComponent();
        }
        BLDonVi DonViBL = new BLDonVi();
        IList<DONVI> DsDonVi = new List<DONVI>();
        public DONVI dv = null;
        void Nhap_DonVi()
        {
            if (dv == null) dv = new DONVI();
            dv.TenDonVi = txttendv.Text;
            dv.DiaChiDV = txtdiachi.Text;
            dv.DienGiaDV = txtdiengiai.Text;
        }
        public void xuat_DonVi_moi()
        {
            txttendv.Text = "";
            txtdiengiai.Text = "";
            txtdiachi.Text = "";
            txttendv.Select();
            this.Text = "Thêm khoa";
        }
        public void xuat_DonVi_edit()
        {
            txttendv.Text = dv.TenDonVi;
            txtdiachi.Text = dv.DiaChiDV;
            txtdiengiai.Text = dv.DienGiaDV;
            txttendv.Select();
            this.Text = "Cập nhật khoa";

        }
        private void btnluu_Click(object sender, EventArgs e)
        {
            try
            {
                if (dv == null)
                {
                    if (btnluu.Text == "Lưu")
                    {
                        Nhap_DonVi();
                        DonViBL.Them(dv);
                        MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnluu.Text = "Thêm Mới";

                    }
                    else
                    {
                        xuat_DonVi_moi();
                        btnluu.Text = "Lưu";
                    }
                    dv = null;
                }
                else
                {
                    Nhap_DonVi();
                    DsDonVi = DonViBL.CapNhat(dv);
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
        private void DonVi_Edit_Load(object sender, EventArgs e)
        {
            if (dv == null)
            {
                xuat_DonVi_moi();

            }
            else
            {
                xuat_DonVi_edit();
            }
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
