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
    public partial class DMDonVi : Office2007RibbonForm
    {
        public DMDonVi()
        {
            InitializeComponent();
        }
        BLDonVi DonViBL = new BLDonVi();
        IList<DONVI> DsDonVi = new List<DONVI>();
        DONVI dv;
        int vitri = 0;
        void xuat_luoi_DonVi()
        {
            luoidonvi.AutoGenerateColumns = false;
            luoidonvi.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            luoidonvi.DataSource = null;
            luoidonvi.DataSource = DsDonVi;
            //Xuat_STT();
        }
        void Xuat_STT()
        {
            for (int i = 0; i < luoidonvi.RowCount; i++)
            {
                luoidonvi.Rows[i].Cells["STT"].Value = i + 1;
            }
        }
        private void DMDonVi_Load(object sender, EventArgs e)
        {
            DsDonVi = DonViBL.DocDonVi();
            xuat_luoi_DonVi();
            txttongso.Text = "Tổng số: " + luoidonvi.RowCount.ToString();
            //this.txtten.Text = vitri.ToString();
            dv = DsDonVi[0];
        }

        private void txtten_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string dk = txtten.Text;
                DsDonVi = DonViBL.DocDonViTheodieukien(dk);
                if (DsDonVi.Count > 0)
                {
                    vitri = 0;
                    xuat_luoi_DonVi();
                }
                else
                {
                    luoidonvi.DataSource = null;
                }
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            var frmdv = new PresentationLayer.DonVi_Edit();
            frmdv.ShowDialog();
            DsDonVi = DonViBL.DocDonVi();
            xuat_luoi_DonVi();
            vitri = -1;
            luoidonvi.Rows[0].Selected = false;
            txttongso.Text = "Tổng số: " + luoidonvi.RowCount.ToString();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (vitri >= 0)
            {
                var frmdv = new PresentationLayer.DonVi_Edit();
                frmdv.dv = dv;
                frmdv.ShowDialog();


                DsDonVi = DonViBL.DocDonVi();
                xuat_luoi_DonVi();

                luoidonvi.CurrentCell = luoidonvi.Rows[vitri].Cells[1];
                luoidonvi.Rows[vitri].Selected = true;
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn dòng để Sửa ");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (vitri >= 0)
                {
                    DialogResult Tl = MessageBox.Show("Chương trình sẽ xoá đơn vị tính:  " + dv.TenDonVi, "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (Tl == DialogResult.OK)
                    {
                        if (luoidonvi.RowCount == 1)
                        {
                            DsDonVi = DonViBL.Xoa(dv);
                            luoidonvi.DataSource = null;
                            txttongso.Text = "Tổng số: 0";
                        }
                        if (vitri == 0)
                        {
                            DsDonVi = DonViBL.Xoa(dv);
                            vitri += 1;

                            dv = DsDonVi[vitri];
                            DsDonVi = DonViBL.DocDonVi();
                            xuat_luoi_DonVi();

                            luoidonvi.CurrentCell = luoidonvi.Rows[vitri].Cells[1];
                            luoidonvi.Rows[vitri].Selected = true;
                        }
                        if (vitri > 0 && vitri < DsDonVi.Count - 1)
                        {
                            DsDonVi = DonViBL.Xoa(dv);
                            vitri -= 1;
                            dv = DsDonVi[vitri];
                            DsDonVi = DonViBL.DocDonVi();
                            xuat_luoi_DonVi();
                            luoidonvi.CurrentCell = luoidonvi.Rows[vitri].Cells[1];
                            luoidonvi.Rows[vitri].Selected = true;
                        }
                        if (vitri == DsDonVi.Count - 1)
                        {
                            DsDonVi = DonViBL.Xoa(dv);
                            vitri -= 1;
                            dv = DsDonVi[vitri];
                            DsDonVi = DonViBL.DocDonVi();
                            xuat_luoi_DonVi();
                            luoidonvi.CurrentCell = luoidonvi.Rows[vitri].Cells[1];
                            luoidonvi.Rows[vitri].Selected = true;
                        }
                        txttongso.Text = "Tổng số: " + luoidonvi.RowCount.ToString();
                    }
                }
                else
                {
                    MessageBox.Show("Bạn chưa chọn dòng để Xóa ");
                }

            }
            catch (DeleteDonViException ex)
            {
                MessageBox.Show(ex.Mess);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi trong quá trình cập nhật dữ liệu: Lỗi:" + ex.Message);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            DsDonVi = DonViBL.DocDonVi();
            luoidonvi.DataSource = DsDonVi;
            vitri = -1;
            luoidonvi.Rows[0].Selected = false;
            
        }

        private void luoidonvi_Click(object sender, EventArgs e)
        {
            vitri = luoidonvi.CurrentRow.Index;
            dv = DsDonVi[vitri];
          
        }

    }
}
