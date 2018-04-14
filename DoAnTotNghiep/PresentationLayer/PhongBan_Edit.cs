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

namespace DoAnTotNghiep.PresentationLayer
{
    public partial class PhongBan_Edit : Office2007Form
    {
        public PhongBan_Edit()
        {
            InitializeComponent();
        }
        BLDonVi DonViBL = new BLDonVi();
        BLPhongBan PhongBanBL = new BLPhongBan();
        IList<DONVI> DSDonVi =new List<DONVI>();
        IList<PHONGBAN> DSPhongBan = new List<PHONGBAN>();
        public PHONGBAN phongban;
        void xuat_donvi()
        {
            cbodonvi.DisplayMember = "TenDonVi";
            cbodonvi.ValueMember = "DonViID";
            cbodonvi.DataSource = DSDonVi;
        }
        void xuat_phongban_moi()
        {
            txttenphongban.Text = "";
            txtdiengiai.Text = "";
            cbodonvi.SelectedIndex = 0;
            this.Text = "Thêm phòng ban mới";
        }
        void xuat_phongban()
        {
            this.Text = "Cập nhật phòng ban";
            cbodonvi.SelectedValue = phongban.DonViID;
            txttenphongban.Text = phongban.TenPhongBan;
            txtdiengiai.Text = phongban.DienGiaiPB;            
        }
        void nhap_phongban()
        {
            if (phongban == null) phongban = new PHONGBAN();
            phongban.TenPhongBan = txttenphongban.Text;
            phongban.DienGiaiPB = txtdiengiai.Text;
            phongban.DonViID =(int)cbodonvi.SelectedValue;
        }
        private void PhongBan_Edit_Load(object sender, EventArgs e)
        {
            DSDonVi = DonViBL.DocDonVi();
            DSPhongBan = PhongBanBL.DocPhongBan();
            xuat_donvi();
            if (phongban == null)
            {
                xuat_phongban_moi();
            }
            else
            {
                xuat_phongban();
            }
        }
        public delegate void TruyenLaiDuLieu(int maloai);
        public TruyenLaiDuLieu truyendulieu;
        private void btnluulai_Click(object sender, EventArgs e)
        {
            try
            {
                if (phongban != null)
                {
                    nhap_phongban();
                    DSPhongBan = PhongBanBL.CapNhat(phongban);
                    if (truyendulieu != null)
                    {
                        int maloaitb = int.Parse(cbodonvi.SelectedValue.ToString());
                        truyendulieu(maloaitb);
                    }
                    this.Close();
                }
                else
                {
                    if (btnluulai.Text == "Lưu")
                    {
                        nhap_phongban();
                        PhongBanBL.Them(phongban);
                        if (truyendulieu != null)
                        {
                            int maloaitb = int.Parse(cbodonvi.SelectedValue.ToString());
                            truyendulieu(maloaitb);
                        }
                        btnluulai.Text = "Thêm Mới"; 
                        MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);                                            
                    }
                    else
                    {
                        xuat_phongban_moi();
                        btnluulai.Text = "Lưu";
                    }
                    phongban = null;
                }
            }
            catch (CapNhatThietBiException ex)
            {
                MessageBox.Show(ex.Mess);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi trong quá trình cập nhật dữ liệu: Lỗi:" + ex.Message);
            }
        }

        private void btndong_Click(object sender, EventArgs e)
        {
            //if (phongban == null)
            //{
            //    this.Close();
            //    if (truyendulieu != null)
            //    {
            //        int maloaitb = int.Parse(cbodonvi.SelectedValue.ToString());
            //        truyendulieu(maloaitb);
            //    }
            //}
            //else {
            //    this.Close();
            //}
            this.Close();
            if (truyendulieu != null)
            {
                int maloaitb = int.Parse(cbodonvi.SelectedValue.ToString());
                truyendulieu(maloaitb);
            }
        }
    }
}
