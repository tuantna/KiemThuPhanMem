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
    public partial class DMChucVu : Office2007RibbonForm
    {
        public DMChucVu()
        {
            InitializeComponent();
        }
        BLChucVu ChucVuBL = new BLChucVu();
        IList<CHUCVU> DsChucVu = new List<CHUCVU>();
        CHUCVU cv;
        int vitri = 0;
        void xuat_luoi_ChucVu()
        {
            luoichucvu.AutoGenerateColumns = false;
            luoichucvu.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            luoichucvu.DataSource = null;           
            luoichucvu.DataSource = DsChucVu;
            //Xuat_STT();
        }
        void Xuat_STT()
        {
            for (int i = 0; i < luoichucvu.RowCount; i++)
            {
                luoichucvu.Rows[i].Cells["STT"].Value = i + 1;
            }  
        }
        private void DMChucVu_Load(object sender, EventArgs e)
        {
            DsChucVu = ChucVuBL.DocChucVu();            
            xuat_luoi_ChucVu();           
            txttongso.Text = "Tổng số: " + luoichucvu.RowCount.ToString();
            //this.txtten.Text = vitri.ToString();
            cv = DsChucVu[0];
        }

        private void txtten_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string dk = txtten.Text;
                DsChucVu = ChucVuBL.DocChucVuTheodieukien(dk);
                if (DsChucVu.Count > 0)
                {
                    vitri = 0;
                    xuat_luoi_ChucVu();
                }
                else
                {
                    luoichucvu.DataSource = null;
                }
            }
        }      

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (vitri >= 0)
            {
                var frmcv = new PresentationLayer.ChucVu_Edit();
                frmcv.cv = cv;
                frmcv.ShowDialog();


                DsChucVu = ChucVuBL.DocChucVu();
                xuat_luoi_ChucVu();

                luoichucvu.CurrentCell = luoichucvu.Rows[vitri].Cells[1];
                luoichucvu.Rows[vitri].Selected = true;
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
                    DialogResult Tl = MessageBox.Show("Chương trình sẽ xoá chức vụ:  " + cv.TenChucVU, "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (Tl == DialogResult.OK)
                    {
                        if (luoichucvu.RowCount == 1)
                        {
                            DsChucVu = ChucVuBL.Xoa(cv);
                            luoichucvu.DataSource = null;
                            txttongso.Text = "Tổng số: 0";
                        }
                        if (vitri == 0)
                        {
                            DsChucVu = ChucVuBL.Xoa(cv);                            
                            vitri += 1;
                            cv = DsChucVu[vitri];

                            DsChucVu = ChucVuBL.DocChucVu();
                            xuat_luoi_ChucVu();
                            luoichucvu.CurrentCell = luoichucvu.Rows[vitri].Cells[1];
                            luoichucvu.Rows[vitri].Selected = true;
                        }
                        if (vitri > 0 && vitri < DsChucVu.Count - 1)
                        {
                            DsChucVu = ChucVuBL.Xoa(cv);                           
                            vitri -= 1;
                            cv = DsChucVu[vitri];

                            DsChucVu = ChucVuBL.DocChucVu();
                            xuat_luoi_ChucVu();
                            luoichucvu.CurrentCell = luoichucvu.Rows[vitri].Cells[1];
                            luoichucvu.Rows[vitri].Selected = true;
                        }
                        if (vitri == DsChucVu.Count - 1)
                        {
                            DsChucVu = ChucVuBL.Xoa(cv);                           
                            vitri -= 1;
                            cv = DsChucVu[vitri];

                            DsChucVu = ChucVuBL.DocChucVu();
                            xuat_luoi_ChucVu();
                            luoichucvu.CurrentCell = luoichucvu.Rows[vitri].Cells[1];
                            luoichucvu.Rows[vitri].Selected = true;
                        }
                        txttongso.Text = "Tổng số: " + luoichucvu.RowCount.ToString();
                    }
                }
                else
                {
                    MessageBox.Show("Bạn chưa chọn dòng để Xóa ");
                }
            }
            catch (DeleteChucVuException ex)
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
            DsChucVu = ChucVuBL.DocChucVu();
            luoichucvu.DataSource = DsChucVu;
            vitri = -1;
            luoichucvu.Rows[0].Selected = false;
            
        }

        private void luoichucvu_Click(object sender, EventArgs e)
        {
            vitri = luoichucvu.CurrentRow.Index;
            cv = DsChucVu[vitri];
        }

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            var frmcv = new PresentationLayer.ChucVu_Edit();
            frmcv.ShowDialog();
            DsChucVu = ChucVuBL.DocChucVu();
            xuat_luoi_ChucVu();
            vitri = -1;
            luoichucvu.Rows[0].Selected = false;
            txttongso.Text = "Tổng số: " + luoichucvu.RowCount.ToString();
        }

        private void labelItem4_Click(object sender, EventArgs e)
        {

        }

        private void labelItem1_Click(object sender, EventArgs e)
        {

        }

    }
}
