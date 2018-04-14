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
    public partial class DM_TinhTrang : Office2007RibbonForm
    {
        public DM_TinhTrang()
        {
            InitializeComponent();
        }
        BLTinhTrang TinhTrangBL = new BLTinhTrang();
        IList<TINHTRANG> DsTinhTrang = new List<TINHTRANG>();
        TINHTRANG cv;
        int vitri = 0;
        void xuat_luoi_ChucVu()
        {
            luoitinhtrang.AutoGenerateColumns = false;
            luoitinhtrang.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            luoitinhtrang.DataSource = null;
            luoitinhtrang.DataSource = DsTinhTrang;
            //Xuat_STT();
        }
        void Xuat_STT()
        {
            for (int i = 0; i < luoitinhtrang.RowCount; i++)
            {
                luoitinhtrang.Rows[i].Cells["STT"].Value = i + 1;
            }
        }

        private void DM_TinhTrang_Load(object sender, EventArgs e)
        {
            DsTinhTrang = TinhTrangBL.DocTinhTrang();
            xuat_luoi_ChucVu();
            //txttongso.Text = "Tổng số: " + luoitinhtrang.RowCount.ToString();
            //this.txtten.Text = vitri.ToString();
            cv = DsTinhTrang[0];
        }

        private void txtten_TextChanged(object sender, EventArgs e)
        {
            
            string dk = txtten.Text;
            DsTinhTrang = TinhTrangBL.DocChucVuTheodieukien(dk);
            if (DsTinhTrang.Count > 0)
            {
                vitri = 0;
                xuat_luoi_ChucVu();
            }
            else
            {
                luoitinhtrang.DataSource = null;
            }
            
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            var frmcv = new PresentationLayer.TinhTrang_Edit();
            frmcv.ShowDialog();
            DsTinhTrang = TinhTrangBL.DocTinhTrang();
            xuat_luoi_ChucVu();
            vitri = -1;
            luoitinhtrang.Rows[0].Selected = false;
           // txttongso.Text = "Tổng số: " + luoichucvu.RowCount.ToString();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (vitri >= 0)
            {
                var frmcv = new PresentationLayer.TinhTrang_Edit();
                frmcv.cv = cv;
                frmcv.ShowDialog();


                DsTinhTrang = TinhTrangBL.DocTinhTrang();
                xuat_luoi_ChucVu();

                luoitinhtrang.CurrentCell = luoitinhtrang.Rows[vitri].Cells[0];
                luoitinhtrang.Rows[vitri].Selected = true;
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn dòng để Sửa ");
            }
        }

        private void luoitinhtrang_Click(object sender, EventArgs e)
        {
            vitri = luoitinhtrang.CurrentRow.Index;
            cv = DsTinhTrang[vitri];
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            DsTinhTrang = TinhTrangBL.DocTinhTrang();
            luoitinhtrang.DataSource = DsTinhTrang;
            vitri = -1;
            luoitinhtrang.Rows[0].Selected = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (vitri >= 0)
                {
                    DialogResult Tl = MessageBox.Show("Chương trình sẽ xoá Tình trạng:  " + cv.TenTinhTrang, "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (Tl == DialogResult.OK)
                    {
                        if (luoitinhtrang.RowCount == 1)
                        {
                            DsTinhTrang = TinhTrangBL.Xoa(cv);
                            luoitinhtrang.DataSource = null;
                            // txttongso.Text = "Tổng số: 0";
                        }
                        if (vitri == 0)
                        {
                            DsTinhTrang = TinhTrangBL.Xoa(cv);
                            xuat_luoi_ChucVu();
                            vitri += 1;
                            cv = DsTinhTrang[vitri];
                            luoitinhtrang.CurrentCell = luoitinhtrang.Rows[vitri].Cells[0];
                            luoitinhtrang.Rows[vitri].Selected = true;
                        }
                        if (vitri > 0 && vitri < DsTinhTrang.Count - 1)
                        {
                            DsTinhTrang = TinhTrangBL.Xoa(cv);
                            xuat_luoi_ChucVu();
                            vitri -= 1;
                            cv = DsTinhTrang[vitri];
                            luoitinhtrang.CurrentCell = luoitinhtrang.Rows[vitri].Cells[0];
                            luoitinhtrang.Rows[vitri].Selected = true;
                        }
                        if (vitri == DsTinhTrang.Count - 1)
                        {
                            DsTinhTrang = TinhTrangBL.Xoa(cv);
                            xuat_luoi_ChucVu();
                            vitri -= 1;
                            cv = DsTinhTrang[vitri];
                            luoitinhtrang.CurrentCell = luoitinhtrang.Rows[vitri].Cells[0];
                            luoitinhtrang.Rows[vitri].Selected = true;
                        }
                        // txttongso.Text = "Tổng số: " + luoichucvu.RowCount.ToString();
                    }
                }
                else
                {
                    MessageBox.Show("Bạn chưa chọn dòng để Xóa ");
                }
            }
            catch (DeleteTinhTrangException ex)
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
