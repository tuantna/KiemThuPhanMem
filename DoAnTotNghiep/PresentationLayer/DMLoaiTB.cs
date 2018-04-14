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
    public partial class DMLoaiTB : Office2007RibbonForm
    {
        public DMLoaiTB()
        {
            InitializeComponent();
        }
        BLLoaiTB LoaiTBBL = new BLLoaiTB();
        IList<object> DsLoaiTB = new List<object>();
        IList<LOAITHIETBI> DsLoaiTBi = new List<LOAITHIETBI>();
        LOAITHIETBI Loai;   
        int vitri = 0;
        void xuat_luoi_LoaiTB()
        {
            luoiloaiTB.AutoGenerateColumns = false;
            luoiloaiTB.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            luoiloaiTB.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            luoiloaiTB.DataSource = null;
            luoiloaiTB.DataSource = DsLoaiTB;           
        }        
        private void textBoxX1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string dk = txtten.Text;
                DsLoaiTB = LoaiTBBL.DocLoaiTBheodieukien(dk);
                if (DsLoaiTB.Count > 0)
                {
                   xuat_luoi_LoaiTB();                    
                }
                else {
                    luoiloaiTB.DataSource = null;
                }
            }
        }      
               
        private void btnThem_Click(object sender, EventArgs e)
        {           
            var frmLoaiTB = new PresentationLayer.LoaiTB_Edit();
            frmLoaiTB.ShowDialog();
            DsLoaiTB = LoaiTBBL.DocLoaiTB();
            DMLoaiTB_Load(sender, e);
           // txttongso.Text = vitri.ToString();
            //vitri = 0;
            txttongso.Text = "Tổng số: " + luoiloaiTB.RowCount.ToString();
        }

        private void DMLoaiTB_Load(object sender, EventArgs e)
        {
            DsLoaiTB = LoaiTBBL.DocLoaiTB();
            DsLoaiTBi = LoaiTBBL.DocLoaiTBi();
            xuat_luoi_LoaiTB();          
           // luoiloaiTB.Rows[0].Selected = false;
            txttongso.Text = "Tổng số: " + luoiloaiTB.RowCount.ToString();
            txtten.Select();
            Loai = DsLoaiTBi[0];
            
        }

        private void btnSua_Click(object sender, EventArgs e)
        {            
            vitri = luoiloaiTB.CurrentRow.Index;
            //if (vitri >= 0)
            //{
            if (Loai!=null)
            {              
                var frmNhaCC_Edit = new LoaiTB_Edit();
                frmNhaCC_Edit.Loai = Loai;
                frmNhaCC_Edit.ShowDialog();

                DsLoaiTB = LoaiTBBL.DocLoaiTB();
                xuat_luoi_LoaiTB();

                luoiloaiTB.CurrentCell = luoiloaiTB.Rows[vitri].Cells[0];
                luoiloaiTB.Rows[vitri].Selected = true;
            }
            else {
                MessageBox.Show("Bạn chưa chọn loại thiết bị để sửa");
            }

        }

        private void luoiloaiTB_Click(object sender, EventArgs e)
        {
            vitri = luoiloaiTB.CurrentRow.Index;
            //txttongso.Text = vitri.ToString();
            Loai = DsLoaiTBi[vitri];   
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            DsLoaiTB = LoaiTBBL.DocLoaiTB();
            luoiloaiTB.DataSource = DsLoaiTB;
            Loai = null;
            vitri = -1;
            luoiloaiTB.Rows[0].Selected = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (vitri >= 0 && Loai !=null)
                {
                    DialogResult Tl = MessageBox.Show("Chương trình sẽ xoá Loại thiết bị: " + Loai.TenLoaiTB, "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (Tl == DialogResult.OK)
                    {

                        if (vitri == 0)
                        {                            
                            DsLoaiTBi = LoaiTBBL.Xoa(Loai);
                            vitri += 1;
                            
                            Loai = DsLoaiTBi[vitri];
                            DsLoaiTB = LoaiTBBL.DocLoaiTB();
                            xuat_luoi_LoaiTB();

                          //  DMLoaiTB_Load(sender, e);
                            luoiloaiTB.CurrentCell = luoiloaiTB.Rows[vitri].Cells[0];
                            luoiloaiTB.Rows[vitri].Selected = true;                           
                        }
                        if (vitri > 0 && vitri < DsLoaiTB.Count - 1)
                        {
                            DsLoaiTBi = LoaiTBBL.Xoa(Loai);
                            vitri -= 1;

                            Loai = DsLoaiTBi[vitri];
                            DsLoaiTB = LoaiTBBL.DocLoaiTB();
                            xuat_luoi_LoaiTB();

                            luoiloaiTB.CurrentCell = luoiloaiTB.Rows[vitri].Cells[0];
                            luoiloaiTB.Rows[vitri].Selected = true; 
                        }
                        if (vitri == DsLoaiTB.Count - 1)
                        {
                            DsLoaiTBi = LoaiTBBL.Xoa(Loai);
                            vitri -= 1;

                            Loai = DsLoaiTBi[vitri];
                            DsLoaiTB = LoaiTBBL.DocLoaiTB();
                            xuat_luoi_LoaiTB();

                            luoiloaiTB.CurrentCell = luoiloaiTB.Rows[vitri].Cells[0];
                            luoiloaiTB.Rows[vitri].Selected = true; 
                        }
                        txttongso.Text = "Tổng số: " + luoiloaiTB.RowCount.ToString();
                    }
                }
                else
                {
                    MessageBox.Show("Bạn chưa chọn dòng để Xóa ");
                }

            }
            catch (DeleteLoaiTBException ex)
            {
                MessageBox.Show(ex.Mess);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi trong quá trình cập nhật dữ liệu: Lỗi:" + ex.Message);
            }
        }           
    }
}
