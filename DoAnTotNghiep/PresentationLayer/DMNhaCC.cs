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
    public partial class DMNhaCC : Office2007RibbonForm
    {
        public DMNhaCC()
        {
            InitializeComponent();
        }
        BLNhaCC NhaCCBL = new BLNhaCC();
        IList<NHACUNGCAP> DsNhacc = new List<NHACUNGCAP>();
        NHACUNGCAP Nhacc;        
        int vitri = 0;
        void xuat_luoi_NhaCC()
        {
            luoinhacc.AutoGenerateColumns = false;
            luoinhacc.DataSource = null;
            luoinhacc.DataSource = DsNhacc;
            luoinhacc.Rows[0].Selected = false;
        }
        void xuat_chitiet_moi()
        {
            lbchitiet.Text = "";
        }
        void xuat_chitie_NhaCC(int vitri)
        {
            NHACUNGCAP dong = DsNhacc[vitri];       
            lbchitiet.Text = "Tên Nhà CC: " + dong.TenNhaCC.ToString() + Environment.NewLine;
            lbchitiet.Text += "Người liên hệ: " + dong.HoTenNguoiLH.ToString() + Environment.NewLine;
            lbchitiet.Text += "Chức vụ: " + dong.ChucVuNLH.ToString() + Environment.NewLine;
            lbchitiet.Text += "Email: " + dong.Email + Environment.NewLine;
            lbchitiet.Text += "Website :" + dong.Wesite + Environment.NewLine;
            
        }
        private void textBoxX1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string dk = txtten.Text;
                DsNhacc = NhaCCBL.DocNhaCCTheodieukien(dk);
                if (DsNhacc.Count > 0)
                {
                    vitri = 0;
                    xuat_luoi_NhaCC();
                    xuat_chitie_NhaCC(vitri);
                }
                else {
                    luoinhacc.DataSource = null;
                    xuat_chitiet_moi();
                }
            }
        }

        private void luoinhacc_Click(object sender, EventArgs e)
        {
            vitri = luoinhacc.CurrentRow.Index;
            if (vitri < 0)
            {
                xuat_chitiet_moi();                
            }
            Nhacc = DsNhacc[vitri];
            chitiet.AutoHide = false;
            chitiet.Show();
            xuat_chitie_NhaCC(vitri);
        }

        private void DMNhaCC_Load(object sender, EventArgs e)
        {
            DsNhacc = NhaCCBL.DocNhaCC();
            xuat_luoi_NhaCC();           
            if (vitri >= 0)
                xuat_chitie_NhaCC(vitri);
            else
            {
                xuat_chitiet_moi();
                chitiet.AutoHide = true;
            }
            Nhacc = DsNhacc[0];
            txttongso.Text = "Tổng số: " + luoinhacc.RowCount.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            var frmNhaCC = new PresentationLayer.NhaCC_Edit();            
            frmNhaCC.ShowDialog();

            DsNhacc = NhaCCBL.DocNhaCC();            
            xuat_luoi_NhaCC();
            txttongso.Text = "Tổng số: " + luoinhacc.RowCount.ToString();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (vitri >= 0)
            {
                if (Nhacc == null) return;
                var frmNhaCC_Edit = new NhaCC_Edit();
                frmNhaCC_Edit.Nhacc = Nhacc;
                frmNhaCC_Edit.ShowDialog();

                DsNhacc = NhaCCBL.DocNhaCC();
                xuat_luoi_NhaCC();

                luoinhacc.CurrentCell = luoinhacc.Rows[vitri].Cells[0];
                luoinhacc.Rows[vitri].Selected = true;
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn dòng để Sửa");
            }
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (vitri >= 0)
                {
                    DialogResult Tl = MessageBox.Show("Chương trình sẽ xoá Nhà cung cấp: " + Nhacc.TenNhaCC, "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (Tl == DialogResult.OK)
                    {
                        if (luoinhacc.RowCount == 1)
                        {
                            DsNhacc = NhaCCBL.Xoa(Nhacc);
                            luoinhacc.DataSource = null;
                            txttongso.Text = "Tổng số: 0";
                        }
                        if (vitri == 0)
                        {
                            DsNhacc = NhaCCBL.Xoa(Nhacc);
                            vitri += 1;

                            Nhacc = DsNhacc[vitri];
                            DsNhacc = NhaCCBL.DocNhaCC();
                            xuat_luoi_NhaCC();

                            luoinhacc.CurrentCell = luoinhacc.Rows[vitri].Cells[0];
                            luoinhacc.Rows[vitri].Selected = true;
                            xuat_chitie_NhaCC(vitri);
                        }
                        if (vitri > 0 && vitri < DsNhacc.Count - 1)
                        {
                            DsNhacc = NhaCCBL.Xoa(Nhacc);
                            vitri -= 1;
                            Nhacc = DsNhacc[vitri];
                            DsNhacc = NhaCCBL.DocNhaCC();
                            xuat_luoi_NhaCC();
                            luoinhacc.CurrentCell = luoinhacc.Rows[vitri].Cells[0];
                            luoinhacc.Rows[vitri].Selected = true;
                            xuat_chitie_NhaCC(vitri);
                        }
                        if (vitri == DsNhacc.Count - 1)
                        {
                            DsNhacc = NhaCCBL.Xoa(Nhacc);
                            vitri -= 1;
                            Nhacc = DsNhacc[vitri];
                            DsNhacc = NhaCCBL.DocNhaCC();
                            xuat_luoi_NhaCC();
                            luoinhacc.CurrentCell = luoinhacc.Rows[vitri].Cells[0];
                            luoinhacc.Rows[vitri].Selected = true;
                            xuat_chitie_NhaCC(vitri);
                        }
                        txttongso.Text = "Tổng số: " + luoinhacc.RowCount.ToString();
                    }
                }
                else
                {
                    MessageBox.Show("Bạn chưa chọn dòng để Xóa ");
                }

            }
            catch (DeleteNhaCCPNException ex)
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
            DsNhacc = NhaCCBL.DocNhaCC();
            luoinhacc.DataSource = DsNhacc;
            txttongso.Text = "Tổng số: " + luoinhacc.RowCount.ToString();
            txtten.Text = "";
            vitri = 0;
            xuat_chitie_NhaCC(vitri);
        }
    }
}
