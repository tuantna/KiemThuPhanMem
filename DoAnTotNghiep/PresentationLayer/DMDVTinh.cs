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
    public partial class DMDVTinh : Office2007RibbonForm
    {
        public DMDVTinh()
        {
            InitializeComponent();
        }
        BLDVTinh DVTBL = new BLDVTinh();
        IList<DVTINH> DsDVT = new List<DVTINH>();
        DVTINH dvt;
        int vitri = 0;
        void xuat_luoi_DVT()
        {
            luoidvtinh.AutoGenerateColumns = false;
            luoidvtinh.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            luoidvtinh.DataSource = null;
            luoidvtinh.DataSource = DsDVT;
            //Xuat_STT();  
        }       
        private void DMDVTinh_Load(object sender, EventArgs e)
        {          
            DsDVT = DVTBL.DocDVT();
            xuat_luoi_DVT();
            //Xuat_STT();  
            txttongso.Text = "Tổng số: " + luoidvtinh.RowCount.ToString();
            //this.txtten.Text = vitri.ToString();
            dvt = DsDVT[0];
        }              
        private void btnThem_Click(object sender, EventArgs e)
        {
            var frmdvt = new PresentationLayer.DVT_edit();
            frmdvt.ShowDialog();
            DsDVT = DVTBL.DocDVT();
            xuat_luoi_DVT();
            vitri = luoidvtinh.RowCount - 1;
            luoidvtinh.CurrentCell = luoidvtinh.Rows[vitri].Cells[0];
            luoidvtinh.Rows[vitri].Selected = true;
           
            txttongso.Text = "Tổng số: " + luoidvtinh.RowCount.ToString();
            dvt = DsDVT[vitri];
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (vitri >=0)
            {
                var frmdvt = new PresentationLayer.DVT_edit();
                frmdvt.dvt = dvt;
                frmdvt.ShowDialog();


                DsDVT = DVTBL.DocDVT();
                xuat_luoi_DVT();

                luoidvtinh.CurrentCell = luoidvtinh.Rows[vitri].Cells[0];
                luoidvtinh.Rows[vitri].Selected = true;
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
                    DialogResult Tl = MessageBox.Show("Chương trình sẽ xoá đơn vị tính:  " + dvt.TenDVT, "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (Tl == DialogResult.OK)
                    {
                        if (luoidvtinh.RowCount == 1)
                        {
                            DsDVT = DVTBL.Xoa(dvt);
                            luoidvtinh.DataSource = null;
                            txttongso.Text = "Tổng số: 0";
                        }
                        if (vitri == 0)
                        {
                            DsDVT = DVTBL.Xoa(dvt);
                            vitri += 1;
                            dvt = DsDVT[vitri];

                            DsDVT = DVTBL.DocDVT();
                            xuat_luoi_DVT();
                            luoidvtinh.CurrentCell = luoidvtinh.Rows[vitri].Cells[0];
                            luoidvtinh.Rows[vitri].Selected = true;
                        }
                        if (vitri > 0 && vitri < DsDVT.Count - 1)
                        {
                            DsDVT = DVTBL.Xoa(dvt);
                            vitri -= 1;
                            dvt = DsDVT[vitri];

                            DsDVT = DVTBL.DocDVT();
                            xuat_luoi_DVT();
                            luoidvtinh.CurrentCell = luoidvtinh.Rows[vitri].Cells[0];
                            luoidvtinh.Rows[vitri].Selected = true;
                        }
                        if (vitri == DsDVT.Count - 1)
                        {
                            DsDVT = DVTBL.Xoa(dvt);
                            vitri -= 1;
                            dvt = DsDVT[vitri];

                            DsDVT = DVTBL.DocDVT();
                            xuat_luoi_DVT();
                            luoidvtinh.CurrentCell = luoidvtinh.Rows[vitri].Cells[0];
                            luoidvtinh.Rows[vitri].Selected = true;
                        }
                        txttongso.Text = "Tổng số: " + luoidvtinh.RowCount.ToString();
                    }
                }
                else
                {
                    MessageBox.Show("Bạn chưa chọn dòng để Xóa ");
                }

            }
            catch (DeleteDVTException ex)
            {
                MessageBox.Show(ex.Mess);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi trong quá trình cập nhật dữ liệu: Lỗi:" + ex.Message);
            }
        }
       
        private void luoidvtinh_Click(object sender, EventArgs e)
        {
            vitri = luoidvtinh.CurrentRow.Index;
            dvt = DsDVT[vitri];
          
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            DsDVT = DVTBL.DocDVT();
            luoidvtinh.DataSource = DsDVT;
            vitri = -1;
            luoidvtinh.Rows[0].Selected = false;
            
        }

        private void txtten_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string dk = txtten.Text;
                DsDVT = DVTBL.DocDVTTheodieukien(dk);
                if (DsDVT.Count > 0)
                {
                    vitri = 0;
                    xuat_luoi_DVT();
                                   }
                else
                {
                    luoidvtinh.DataSource = null;                    
                }
            }
        }        
    }
}
