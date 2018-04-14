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
    public partial class DMPhongBan : Office2007RibbonForm
    {
        public DMPhongBan()
        {
            InitializeComponent();
        }
        BLDonVi DonViBL = new BLDonVi();
        IList<DONVI> DSDonVi =new List<DONVI>();
        BLPhongBan PhongBanBL = new BLPhongBan();
        IList<PHONGBAN> DSPhongBan = new List<PHONGBAN>();
        PHONGBAN phongban;
        int vitri = 0;
        void xuat_donvi()
        {
            cbodonvi.DisplayMember = "TenDonVi";
            cbodonvi.ValueMember = "DonViID";
            cbodonvi.DataSource = DSDonVi;
        }
        void xuat_luoi_phongban()
        {
            luoiphongban.AutoGenerateColumns = false;
            luoiphongban.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            luoiphongban.DataSource = null;
            luoiphongban.DataSource = DSPhongBan;
        }
        private void DMPhongBan_Load(object sender, EventArgs e)
        {
            DSDonVi = DonViBL.DocDonVi();
            xuat_donvi();
        }
        int maloai=0;
        private void cbodonvi_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                maloai = (int)cbodonvi.SelectedValue;
                DSPhongBan = PhongBanBL.DocPhongBanTheoDK(maloai);
                // txtten.Text = cbothietbi.SelectedValue.ToString();
                if (DSPhongBan.Count == 0)
                {
                    luoiphongban.DataSource = null;
                    txttongso.Text = "Tổng số: 0";
                }
                else
                {
                    xuat_luoi_phongban();
                    phongban = PhongBanBL.DocPhongBanTheoID(int.Parse(luoiphongban.Rows[0].Cells[0].Value.ToString()));
                    txttongso.Text = "Tổng số: " + luoiphongban.RowCount.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi:" + ex.Message);
            }
        }
        // Truyen du lieu tu from con sang from cha
        int donviid;
        public void laydulieu(int maloaitbid)
        {
            donviid = maloaitbid;
        }
        //-----------------------------------     
        private void buttonItem2_Click(object sender, EventArgs e)
        {
            try{
                var frmphongban_edit = new PresentationLayer.PhongBan_Edit();
                frmphongban_edit.truyendulieu = new PhongBan_Edit.TruyenLaiDuLieu(laydulieu);
                frmphongban_edit.ShowDialog();
               
                DSPhongBan = PhongBanBL.DocPhongBanTheoDK(donviid);
                cbodonvi.SelectedValue = donviid;
                xuat_luoi_phongban();

                vitri = luoiphongban.RowCount - 1;
                luoiphongban.CurrentCell = luoiphongban.Rows[vitri].Cells[0];
                luoiphongban.Rows[vitri].Selected = true;
                phongban = PhongBanBL.DocPhongBanTheoID(int.Parse(luoiphongban.Rows[vitri].Cells[0].Value.ToString()));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi 1:" + ex.Message);
            }
        }

        private void buttonItem3_Click(object sender, EventArgs e)
        {
            try
            {
                //vitri = luoiphongban.CurrentRow.Index;
                if (DSPhongBan.Count > 0 && phongban != null)
                {
                    var frmphongban_edit = new PhongBan_Edit();
                    frmphongban_edit.truyendulieu = new PhongBan_Edit.TruyenLaiDuLieu(laydulieu);
                    frmphongban_edit.phongban = phongban;
                    frmphongban_edit.ShowDialog();

                    DSPhongBan = PhongBanBL.DocPhongBanTheoDK(donviid);
                    cbodonvi.SelectedValue = donviid;
                    xuat_luoi_phongban();


                }
                else
                {
                    MessageBox.Show("Bạn chưa chọn Phòng ban để sửa");
                }
                if (luoiphongban.Rows.Count > vitri)
                {
                    luoiphongban.CurrentCell = luoiphongban.Rows[vitri + (luoiphongban.Rows.Count - vitri - 1)].Cells[0];
                    luoiphongban.Rows[vitri + (luoiphongban.Rows.Count - vitri - 1)].Selected = true;
                    phongban = DSPhongBan[vitri + (luoiphongban.Rows.Count - vitri - 1)];
                }
                if (luoiphongban.Rows.Count < vitri)
                {
                    luoiphongban.CurrentCell = luoiphongban.Rows[(luoiphongban.Rows.Count - 1)].Cells[0];
                    luoiphongban.Rows[(luoiphongban.Rows.Count - 1)].Selected = true;
                    phongban = DSPhongBan[(luoiphongban.Rows.Count - 1)];
                }
            }catch(Exception ex)
            {
                MessageBox.Show("Lỗi 2:"+ ex.Message);
            }
        }

        private void luoiphongban_Click(object sender, EventArgs e)
        {
            try
            {
                if (DSPhongBan.Count == 0)
                {
                    vitri = -1;
                }
                else
                {
                    vitri = luoiphongban.CurrentCell.RowIndex;

                    //DsLoaiTB1 = ThietBiBL.DocThietBi22(int.Parse(luoithietbi.Rows[vitri].Cells[0].Value.ToString()));
                    phongban = PhongBanBL.DocPhongBanTheoID(int.Parse(luoiphongban.Rows[vitri].Cells[0].Value.ToString()));

                }
            }catch(Exception ex)
            {
                MessageBox.Show("Lỗi 3:"+ ex.Message);
            }
        }

        private void buttonItem4_Click(object sender, EventArgs e)
        {
            try
            {
                if (DSPhongBan.Count>0 && phongban != null)
                {
                    DialogResult Tl = MessageBox.Show("Chương trình sẽ xoá thiết bị: " + phongban.TenPhongBan, "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (Tl == DialogResult.OK)
                    {

                        if (vitri == 0)
                        {
                            //File.Delete(Environment.CurrentDirectory + @"\HinhNV\" + nhanvien.HinhAnhNV);  
                            DSPhongBan = PhongBanBL.Xoa(phongban);
                            vitri += 1;
                            DSPhongBan = PhongBanBL.DocPhongBanTheoDK(maloai);
                            xuat_luoi_phongban();
                            luoiphongban.CurrentCell = luoiphongban.Rows[vitri].Cells[1];
                            luoiphongban.Rows[vitri].Selected = true;                           
                        }
                        if (vitri > 0 && vitri < DSPhongBan.Count - 1)
                        {
                            DSPhongBan = PhongBanBL.Xoa(phongban);
                            vitri -= 1;
                            DSPhongBan = PhongBanBL.DocPhongBanTheoDK(maloai);
                            xuat_luoi_phongban();
                            luoiphongban.CurrentCell = luoiphongban.Rows[vitri].Cells[1];
                            luoiphongban.Rows[vitri].Selected = true;   
                        }
                        if (vitri == DSPhongBan.Count - 1)
                        {
                            DSPhongBan = PhongBanBL.Xoa(phongban);
                            vitri -= 1;
                            DSPhongBan = PhongBanBL.DocPhongBanTheoDK(maloai);
                            xuat_luoi_phongban();
                            luoiphongban.CurrentCell = luoiphongban.Rows[vitri].Cells[1];
                            luoiphongban.Rows[vitri].Selected = true;   
                        }
                        txttongso.Text = "Tổng số: " + luoiphongban.RowCount.ToString();
                    }
                }
                else
                {
                    MessageBox.Show("Bạn chưa chọn dòng để Xóa ");
                }

            }
            catch (DeletePhongBanDOKKException ex)
            {
                MessageBox.Show(ex.Mess);
            }
            catch (DeletePhongBanSTDxception ex)
            {
                MessageBox.Show(ex.Mess);
            }
            catch (DeletePhongBanPNhapxception ex)
            {
                MessageBox.Show(ex.Mess);
            }
            catch (DeletePhongBanBanGiaoxception ex)
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
