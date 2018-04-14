using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DoAnTotNghiep.DataAcessLayer;
using DoAnTotNghiep.BusinessLayer;
using DevComponents.DotNetBar;

namespace DoAnTotNghiep.PresentationLayer
{
    public partial class DMNSX : Office2007RibbonForm
    {
        public DMNSX()
        {
            InitializeComponent();
        }
        BLNuocSX NSXBL = new BLNuocSX();
        IList<NUOCSX> DsNSX = new List<NUOCSX>();
        NUOCSX nsx;
        int vitri = 0;
        void xuat_luoi_NSX()
        {
            luoinsx.AutoGenerateColumns = false;

            luoinsx.DataSource = null;
            luoinsx.DataSource = DsNSX;
        }
        private void DMNSX_Load(object sender, EventArgs e)
        {
            DsNSX = NSXBL.DocNSX();
            xuat_luoi_NSX();
            //luoinsx.Rows[0].Selected = false;
            txttongso.Text = "Tổng số: " + luoinsx.RowCount.ToString();
            //this.txttongso.Text = vitri.ToString();
            nsx = DsNSX[0];
        }

        private void luoinsx_Click(object sender, EventArgs e)
        {
            vitri = luoinsx.CurrentRow.Index;
            nsx = DsNSX[vitri];
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            NSX_Edit frmnsx = new PresentationLayer.NSX_Edit();
            frmnsx.ShowDialog();
            DsNSX = NSXBL.DocNSX();
            xuat_luoi_NSX();
            txttongso.Text = "Tổng số: " + luoinsx.RowCount.ToString();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (nsx !=null)
            {
                NSX_Edit frmnsx = new PresentationLayer.NSX_Edit();
                frmnsx.nsx = nsx;
                frmnsx.ShowDialog();                          

                DsNSX = NSXBL.DocNSX();
                xuat_luoi_NSX();

                luoinsx.CurrentCell = luoinsx.Rows[vitri].Cells[0];
                luoinsx.Rows[vitri].Selected = true;
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
                    DialogResult Tl = MessageBox.Show("Chương trình sẽ xoá tên xuất xứ: " + nsx.TenNuoc, "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                   if (Tl == DialogResult.OK)
                    {

                        if (vitri == 0)
                        {
                            DsNSX = NSXBL.Xoa(nsx);
                            xuat_luoi_NSX();
                            vitri += 1;
                            nsx = DsNSX[vitri];  
                            luoinsx.CurrentCell = luoinsx.Rows[vitri].Cells[0];
                            luoinsx.Rows[vitri].Selected = true;
                        }
                        if (vitri > 0 && vitri < DsNSX.Count - 1)
                        {
                            DsNSX = NSXBL.Xoa(nsx);
                            xuat_luoi_NSX();
                            vitri -= 1;
                            nsx = DsNSX[vitri];  
                            luoinsx.CurrentCell = luoinsx.Rows[vitri].Cells[0];
                            luoinsx.Rows[vitri].Selected = true;
                        }
                        if (vitri == DsNSX.Count - 1)
                        {
                            DsNSX = NSXBL.Xoa(nsx);                            
                            xuat_luoi_NSX();
                            vitri -= 1;
                            nsx=DsNSX[vitri];                            
                            luoinsx.CurrentCell = luoinsx.Rows[vitri].Cells[0];
                            luoinsx.Rows[vitri].Selected = true;
                        }
                        txttongso.Text = "Tổng số: " + luoinsx.RowCount.ToString();
                    }
                }
                else
                {
                    MessageBox.Show("Bạn chưa chọn dòng để Xóa ");
                }

            }
            catch (DeleteNSXException ex)
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
            DsNSX = NSXBL.DocNSX();
            luoinsx.DataSource = DsNSX;
            vitri = -1;
            luoinsx.Rows[0].Selected = false;
        }
    }
}
