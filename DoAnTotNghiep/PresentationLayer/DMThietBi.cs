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
    public partial class DMThietBi : Office2007RibbonForm
    {
        public DMThietBi()
        {
            InitializeComponent();
        }
        BLThietBi ThietBiBL = new BLThietBi();
        IList<LOAITHIETBI> DsLoaiTB = new List<LOAITHIETBI>();
        IList<object> DsThietBi = new List<object>();
        IList<THIETBI> DsTB1 = new List<THIETBI>();
        THIETBI thietbi;
        int vitri = 0;
        void xuat_luoi_ThietBi()
        {
            luoithietbi.AutoGenerateColumns = false;
            luoithietbi.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;           
            luoithietbi.DataSource = null;
            luoithietbi.DataSource = DsThietBi;
        }
        void xuat_chitiet_moi()
        {
            barchitiet.AutoHide = false;
            barchitiet.Text = "Chi tiết thiết bị";
            imghinh.Image = null;
            imghinh.SizeMode = PictureBoxSizeMode.StretchImage;
            imghinh.BackgroundImage = Image.FromFile(Application.StartupPath + "/HinhTB/NoPhoto.jpg ");
            txtchitiet.Text = "";
            txttongso.Text = "Tổng số: 0";
          
        }
        void xuat_chitiet_Thietbi(int vitri)
        {
            try
            {
                THIETBI dong = ThietBiBL.DocThietBiTheoID(int.Parse(luoithietbi.Rows[vitri].Cells[0].Value.ToString()));
                barchitiet.Show();

                imghinh.SizeMode = PictureBoxSizeMode.StretchImage;
                imghinh.Image = Image.FromFile(Application.StartupPath + "/HinhTB/" + dong.HinhAnh);
                txtchitiet.Text = "** Thiết bị: " + dong.TenTB.ToString() + Environment.NewLine;
                txtchitiet.Text += " -------- THÔNG TIN CHI TIẾT  --------: " + Environment.NewLine;
                txtchitiet.Text += "** Hạn bảo hành: " + dong.ThoiGianBH.ToString() + " tháng" + Environment.NewLine;
                txtchitiet.Text += " --------------- THÔNG SỐ KỸ THUẬT --------: " + Environment.NewLine;
                txtchitiet.Text += "** Thông số: " + dong.ThongSoKT.ToString() + Environment.NewLine;
                barchitiet.Text = "Chi tiết thiết bị: " + dong.MaThietBi;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi 1:" + ex.Message);
            }
        }
        void xuat_LoaiTB()
        {

            BLLoaiTB LoaiTBBL = new BLLoaiTB();
            DsLoaiTB = LoaiTBBL.DocLoaiTBi();

            //cbothietbi.Items.Add(new ListItem("Tất cả ", "0"));
            //DataTable dt = ChuDeBLLSERVICE.SelectByAll();
            //foreach (DataRow row in dt.Rows)
            //{
            //    cbothietbi.Items.Add(new ListItem(row[1].ToString(), row[0].ToString()));

            //}
            cbothietbi.DisplayMember = "TenLoaiTB";
            cbothietbi.ValueMember = "LoaiTBID";
            cbothietbi.DataSource = DsLoaiTB;
            cbothietbi.SelectedIndex = 0;
        }

        private void DMThietBi_Load(object sender, EventArgs e)
        {
            xuat_LoaiTB();
           // if (vitri >= 0)
            //    xuat_chitiet_Thietbi(vitri);
           // else
            //{
               // xuat_chitiet_moi();
                //chitiet.AutoHide = true;
           // }
            txttongso.Text = "Tổng số: " + luoithietbi.RowCount.ToString();
            //DsTB1 = ThietBiBL.DocThietBi();            
            xuat_chitiet_Thietbi(0);
            thietbi = ThietBiBL.DocThietBiTheoID(int.Parse(luoithietbi.Rows[0].Cells[0].Value.ToString()));
        }
        int maloai=0;
        private void cbothietbi_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                maloai = (int)cbothietbi.SelectedValue;

                DsThietBi = ThietBiBL.DocLoaiTBheodieukien(maloai);
                // txtten.Text = cbothietbi.SelectedValue.ToString();
                if (DsThietBi.Count == 0)
                {
                    luoithietbi.DataSource = null;
                    xuat_chitiet_moi();
                }
                else
                {
                    xuat_luoi_ThietBi();
                    thietbi = ThietBiBL.DocThietBiTheoID(int.Parse(luoithietbi.Rows[0].Cells[0].Value.ToString()));
                    txttongso.Text = "Tổng số: " + luoithietbi.RowCount.ToString();
                    xuat_chitiet_Thietbi(0);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi 2:" + ex.Message);
            }
           
        }

        private void luoithietbi_Click(object sender, EventArgs e)
        {
            try
            {
                if (DsThietBi.Count == 0)
                {
                    luoithietbi.DataSource = null;
                }
                else
                {
                    vitri = luoithietbi.CurrentCell.RowIndex;
                    if (vitri < 0)
                    {
                        xuat_chitiet_moi();

                    }
                    else
                    {
                        //DsLoaiTB1 = ThietBiBL.DocThietBi22(int.Parse(luoithietbi.Rows[vitri].Cells[0].Value.ToString()));
                        thietbi = ThietBiBL.DocThietBiTheoID(int.Parse(luoithietbi.Rows[vitri].Cells[0].Value.ToString()));
                        xuat_chitiet_Thietbi(vitri);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi 3:" + ex.Message);
            }      
  
        }      

        // Truyen du lieu tu from con sang from cha
        int loaitbid;
        public void laydulieu(int maloaitbid)
        {
            loaitbid = maloaitbid;            
        }
        //-----------------------------------     

        private void buttonItem2_Click(object sender, EventArgs e)
        {
            try
            {
                var frmthietbi = new PresentationLayer.ThietBi_Edit();
                frmthietbi.truyendulieu = new ThietBi_Edit.TruyenLaiDuLieu(laydulieu);
                frmthietbi.ShowDialog();

                DsThietBi = ThietBiBL.DocLoaiTBheodieukien(maloai);
                DsTB1 = ThietBiBL.DocThietBi();
                cbothietbi.SelectedValue = loaitbid;
                xuat_luoi_ThietBi();

                vitri = luoithietbi.RowCount - 1;
                luoithietbi.CurrentCell = luoithietbi.Rows[vitri].Cells[2];
                luoithietbi.Rows[vitri].Selected = true;
                xuat_chitiet_Thietbi(vitri);
                txttongso.Text = "Tổng số: " + luoithietbi.RowCount.ToString();
                thietbi = ThietBiBL.DocThietBiTheoID(int.Parse(luoithietbi.Rows[vitri].Cells[0].Value.ToString()));
            }catch(Exception ex )
            {
                MessageBox.Show("Lỗi 4:" + ex.Message);
            }

        }

        private void buttonItem3_Click(object sender, EventArgs e)
        {
            try
            {
                //MessageBox.Show(maloai.ToString());
                vitri = luoithietbi.CurrentRow.Index;
                if (thietbi != null)
                {
                    var frmthietbi = new ThietBi_Edit();
                    frmthietbi.truyendulieu = new ThietBi_Edit.TruyenLaiDuLieu(laydulieu);
                    frmthietbi.thietbi = thietbi;
                    frmthietbi.ShowDialog();


                    DsThietBi = ThietBiBL.DocLoaiTBheodieukien(loaitbid);
                    cbothietbi.SelectedValue = loaitbid;
                    xuat_luoi_ThietBi();
                    xuat_chitiet_Thietbi(0);

                }
                else
                {
                    MessageBox.Show("Bạn chưa chọn Nhân viên để sửa");
                }
                if (luoithietbi.Rows.Count > vitri)
                {
                    luoithietbi.CurrentCell = luoithietbi.Rows[vitri + (luoithietbi.Rows.Count - vitri - 1)].Cells[2];
                    luoithietbi.Rows[vitri + (luoithietbi.Rows.Count - vitri - 1)].Selected = true;
                    xuat_chitiet_Thietbi(vitri + (luoithietbi.Rows.Count - vitri - 1));
                }
                if (luoithietbi.Rows.Count < vitri)
                {
                    luoithietbi.CurrentCell = luoithietbi.Rows[(luoithietbi.Rows.Count - 1)].Cells[2];
                    luoithietbi.Rows[(luoithietbi.Rows.Count - 1)].Selected = true;
                    xuat_chitiet_Thietbi((luoithietbi.Rows.Count - 1));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi 5:" + ex.Message);
            }
        }

        private void buttonItem4_Click(object sender, EventArgs e)
        {
            try
            {
                if (thietbi!=null)
                {
                    DialogResult Tl = MessageBox.Show("Chương trình sẽ xoá thiết bị: " + thietbi.TenTB , "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (Tl == DialogResult.OK)
                    {

                        if (vitri == 0)
                        {
                                DsTB1 = ThietBiBL.Xoa(thietbi);
                                DsThietBi = ThietBiBL.DocLoaiTBheodieukien((int)cbothietbi.SelectedValue);
                                if (DsThietBi.Count != 0)
                                {
                                    vitri += 1;
                                    DsThietBi = ThietBiBL.DocLoaiTBheodieukien(maloai);
                                    xuat_luoi_ThietBi();
                                    luoithietbi.CurrentCell = luoithietbi.Rows[vitri].Cells[1];
                                    luoithietbi.Rows[vitri].Selected = true;
                                    xuat_chitiet_Thietbi(vitri);
                                }
                                else
                                {
                                    luoithietbi.DataSource = null;
                                    imghinh.Image = null;
                                    imghinh.SizeMode = PictureBoxSizeMode.StretchImage;
                                    imghinh.BackgroundImage = Image.FromFile(Application.StartupPath + "/HinhTB/NoPhoto.jpg ");
                                    txtchitiet.Text = "";
                                }                            
                        }
                        if (vitri > 0 && vitri < DsThietBi.Count - 1)
                        {
                            DsTB1 = ThietBiBL.Xoa(thietbi);
                            vitri -= 1;

                            thietbi = ThietBiBL.DocThietBiTheoID(int.Parse(luoithietbi.Rows[vitri].Cells[0].Value.ToString()));

                            DsThietBi = ThietBiBL.DocLoaiTBheodieukien(maloai);
                            xuat_luoi_ThietBi();
                            luoithietbi.CurrentCell = luoithietbi.Rows[vitri].Cells[1];
                            luoithietbi.Rows[vitri].Selected = true;
                            xuat_chitiet_Thietbi(vitri);

                        }
                        if (vitri == DsThietBi.Count - 1)
                        {
                            //File.Delete(Environment.CurrentDirectory + @"\HinhNV\" + nhanvien.HinhAnhNV);  
                            DsTB1 = ThietBiBL.Xoa(thietbi);
                            vitri -= 1;

                            thietbi = ThietBiBL.DocThietBiTheoID(int.Parse(luoithietbi.Rows[vitri].Cells[0].Value.ToString()));

                            DsThietBi = ThietBiBL.DocLoaiTBheodieukien(maloai);
                            xuat_luoi_ThietBi();
                            luoithietbi.CurrentCell = luoithietbi.Rows[vitri].Cells[1];
                            luoithietbi.Rows[vitri].Selected = true;
                            xuat_chitiet_Thietbi(vitri);
                        }
                        txttongso.Text = "Tổng số: " + luoithietbi.RowCount.ToString();
                    }
                }
                else
                {
                    MessageBox.Show("Bạn chưa chọn dòng để Xóa ");
                }

            }
            catch (DeleteThietBiCTPNException ex)
            {
                MessageBox.Show(ex.Mess);
            }
            catch (DeleteThietBiCTBGException ex)
            {
                MessageBox.Show(ex.Mess);
            }
            catch (DeleteThietBiSTDException ex)
            {
                MessageBox.Show(ex.Mess);
            }
            catch (DeleteThietBiPKEException ex)
            {
                MessageBox.Show(ex.Mess);
            }
            catch (DeleteThietBiCTTLyException ex)
            {
                MessageBox.Show(ex.Mess);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi trong quá trình cập nhật dữ liệu: Lỗi:" + ex.Message);
            }
        }

        private void txtten_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string dk = txtten.Text;
                DsThietBi = ThietBiBL.DocLoaiTBheoTen(dk,(int)cbothietbi.SelectedValue);
                if (DsThietBi.Count > 0)
                {
                    vitri = 0;
                    xuat_luoi_ThietBi();
                }
                else
                {
                    luoithietbi.DataSource = null;
                }
            }
        }

        
    }
}
