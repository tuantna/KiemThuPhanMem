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
    public partial class CN_Nguoi_dung : Office2007RibbonForm
    {
        public CN_Nguoi_dung()
        {
            InitializeComponent();
        }
        BLQuyen QuyenBL = new BLQuyen();
        IList<QUYEN> DSQuyen = new List<QUYEN>();

        int idnv = 0;
        #region Các phương thức xử lý
        void xuat_luoi()
        {
            luoinguoidung.AutoGenerateColumns = false;
            luoinguoidung.DataSource = null;
            luoinguoidung.DataSource = DsNguoiDung2;
        }
        void xuat_nhanvien()
        {
            cbonhanvien.DisplayMember = "HoTenNV";
            cbonhanvien.ValueMember = "NhanVienID";
            cbonhanvien.DataSource = DsNhanVien;
        }
        public void Xuat(int vt)
        {          
            txtmatkhau.UseSystemPasswordChar = true;           
            bar1.Text = "Cập nhật người dùng";
            //them_moi = false;
            NguoiDung nguoidung = DsNguoiDung[vt];           
            txtnguoidungid.Text = nguoidung.NguoiDungID.ToString();
            txtmadn.Text = nguoidung.MaDangNhap;
           // cbonhanvien.Enabled = false;
            cbonhanvien.SelectedValue = nguoidung.NhanVienID;
            txtmatkhau.Text = nguoidung.MatKhau.ToString();
            cbophanquyen.SelectedValue = nguoidung.QuyenID;           
            chkHien.Checked = false;           

        }
        void xuat_phanquyen()
        {
            cbophanquyen.DisplayMember = "TenQuenHan";
            cbophanquyen.ValueMember = "QuyenID";
            cbophanquyen.DataSource = DSQuyen;
        }
        private void Xuat_moi()
        {
            //them_moi = true;
            bar1.Text = "Hồ sơ mới ";
            txtnguoidungid.Text = "";
            cbonhanvien.SelectedIndex = 1;
            txtmadn.Text = "";
           // Ten_nd.Text = "";
            txtmatkhau.Text = "";
            chkHien.Checked = false;
            cbophanquyen.SelectedIndex = 1;
        }
        void Nhap_ND()
        {
            if (them_moi == true) nguoidung = new NguoiDung();
            nguoidung.MaDangNhap = txtmadn.Text;
            nguoidung.MatKhau = txtmatkhau.Text;          
            nguoidung.NhanVienID =(int)cbonhanvien.SelectedValue;          
            nguoidung.QuyenID = (int)cbophanquyen.SelectedValue;
        }
       
        #endregion


        BLNguoiDung NguoidungBL;
        BLNhanVien NhanVienBL = new BLNhanVien();
        IList<NguoiDung> DsNguoiDung = new List<NguoiDung>();
        IList<object> DsNhanVien = new List<object>();
        IList<object> DsNguoiDung2 = new List<object>();
        bool them_moi = false;
        int vt = -1;
        NguoiDung nguoidung;     
        private void CN_Nguoi_dung_Load_1(object sender, EventArgs e)
        {
            DSQuyen = QuyenBL.DocQuyen();
            xuat_phanquyen();
            bar1.AutoHide = false;
            cboloai.Items.Add("Tất cả");
            cboloai.Items.Add("Tài khoản");
            cboloai.Items.Add("Tên nhân viên");
            cboloai.SelectedIndex = 0;

            NguoidungBL = new BLNguoiDung();

            DsNguoiDung = NguoidungBL.DocNguoiDung();
            DsNguoiDung2 = NguoidungBL.DocNguoiDungLen();

            DsNhanVien = NhanVienBL.DocNhanVienLenCbo();
            xuat_nhanvien();
            xuat_luoi();
            Xuat(0);
        }     
  
           
        private void btnadd_Click(object sender, EventArgs e)
        {
            var frmthemnv = new PresentationLayer.NhanVien_Edit();
            frmthemnv.ShowDialog();
            DsNhanVien = NhanVienBL.DocNhanVienLenCbo();
            xuat_nhanvien();
            
        }       
        private void luoinguoidung_Click(object sender, EventArgs e)
        {
            them_moi = false;
            vt = luoinguoidung.CurrentRow.Index;           
            nguoidung = DsNguoiDung[vt];
            Xuat(vt);          
            bar1.AutoHide = false;
            bar1.Show();
        }
      
        private void btnluu_Click(object sender, EventArgs e)
        {
            try
            {                
                if (them_moi)
                {
                    Nhap_ND();
                    DsNguoiDung = NguoidungBL.Them(nguoidung);
                    vt = DsNguoiDung.Count - 1;

                    DsNguoiDung2 = NguoidungBL.DocNguoiDungLen();
                    xuat_luoi();

                    luoinguoidung.CurrentCell = luoinguoidung.Rows[vt].Cells[1];
                    luoinguoidung.Rows[vt].Selected = true;
                    nguoidung = DsNguoiDung[vt];
                }
                else
                {
                    Nhap_ND();
                    NguoidungBL.CapNhat(nguoidung);

                    DsNguoiDung2 = NguoidungBL.DocNguoiDungLen();
                    xuat_luoi();

                    luoinguoidung.CurrentCell = luoinguoidung.Rows[vt].Cells[1];
                    luoinguoidung.Rows[vt].Selected = true;
                    nguoidung = DsNguoiDung[vt];
                }
                // Xuat();              



                MessageBox.Show("Ghi thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            catch (Exception ex)
            {
                MessageBox.Show("Có một lỗi xảy ra: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnkhong_Click(object sender, EventArgs e)
        {
            them_moi = false;
            luoinguoidung.Rows[0].Selected = true;
            Xuat(vt);
        }

        private void chkHien_CheckedChanged(object sender, EventArgs e)
        {
            if (chkHien.Checked)
            {
                txtmatkhau.UseSystemPasswordChar = false;
                //NguoiDung nd = DsNguoiDung[vt];
                //txtmatkhau.Text = NguoidungBL.GiaiMaMatKhau(nd.MatKhau);                
            }
            else
                txtmatkhau.UseSystemPasswordChar = true;
            //txtmatkhau.Text = NguoidungBL.GiaiMaMatKhau(nd.MatKhau); 
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            them_moi = true;
            bar1.AutoHide = false;
            Xuat_moi();
            cbonhanvien.Select();
            //luoinguoidung.Rows[0].Selected = false;
        }

        private void btnhuy_Click(object sender, EventArgs e)
        {
             try
            {
                if (vt >= 0)
                {
                    DialogResult Tl = MessageBox.Show("Chương trình sẽ xoá Người dùng:  " + nguoidung.MaDangNhap, "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (Tl == DialogResult.OK)
                    {
                        if (luoinguoidung.RowCount == 1)
                        {
                            DsNguoiDung = NguoidungBL.Xoa(nguoidung);
                            luoinguoidung.DataSource = null;
                            // txttongso.Text = "Tổng số: 0";
                        }
                        if (vt == 0)
                        {
                            DsNguoiDung = NguoidungBL.Xoa(nguoidung);
                            DsNguoiDung2 = NguoidungBL.DocNguoiDungLen();
                            xuat_luoi();
                            vt += 1;
                            nguoidung = DsNguoiDung[vt];
                            luoinguoidung.CurrentCell = luoinguoidung.Rows[vt].Cells[1];
                            luoinguoidung.Rows[vt].Selected = true;
                            Xuat(vt);
                        }
                        if (vt > 0 && vt < DsNguoiDung.Count - 1)
                        {
                            DsNguoiDung = NguoidungBL.Xoa(nguoidung);
                            DsNguoiDung2 = NguoidungBL.DocNguoiDungLen();
                            xuat_luoi();
                            vt -= 1;
                            nguoidung = DsNguoiDung[vt];
                            luoinguoidung.CurrentCell = luoinguoidung.Rows[vt].Cells[1];
                            luoinguoidung.Rows[vt].Selected = true;
                             Xuat(vt);
                        }
                        if (vt == DsNguoiDung.Count - 1)
                        {
                            DsNguoiDung = NguoidungBL.Xoa(nguoidung);
                            DsNguoiDung2 = NguoidungBL.DocNguoiDungLen();
                            xuat_luoi();
                            vt -= 1;
                            nguoidung = DsNguoiDung[vt];
                            luoinguoidung.CurrentCell = luoinguoidung.Rows[vt].Cells[1];
                            luoinguoidung.Rows[vt].Selected = true;
                            Xuat(vt);
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

        private void txttimkiem_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
               
            }                        
        }

        private void cbonhanvien_SelectedIndexChanged(object sender, EventArgs e)
        {
            NHANVIEN nv = NhanVienBL.DocNhanVienTheoID((int)cbonhanvien.SelectedValue);
           // DsNguoiDung = NguoidungBL.DocNguoiDung();
            txtmadn.Text = nv.MaNV;              
        }

        private void txttimkiem_TextChanged(object sender, EventArgs e)
        {
            if (cboloai.Text == "Tài khoản")
            {
                string dk = txttimkiem.Text;
                DsNguoiDung2 = NguoidungBL.DocNguoiDungTheoTaiKhoan(dk);
                if (DsNguoiDung2.Count > 0)
                {
                    vt = 0;
                    luoinguoidung.AutoGenerateColumns = false;
                    luoinguoidung.DataSource = DsNguoiDung2;
                    Xuat(vt);
                }
                else
                {
                    luoinguoidung.DataSource = null;
                    Xuat_moi();
                }
            }
            else if (cboloai.Text == "Tên nhân viên")
            {

                string dk = txttimkiem.Text;
                DsNguoiDung2 = NguoidungBL.DocNguoiDungTheoTenNV(dk);
                if (DsNguoiDung2.Count > 0)
                {
                    vt = 0;
                    luoinguoidung.AutoGenerateColumns = false;
                    luoinguoidung.DataSource = DsNguoiDung2;
                    Xuat(vt);
                }
                else
                {
                    luoinguoidung.DataSource = null;
                    Xuat_moi();
                }
            }
            else
            {
                DsNguoiDung2 = NguoidungBL.DocNguoiDungLen();
                luoinguoidung.AutoGenerateColumns = false;
                luoinguoidung.DataSource = DsNguoiDung2;
                Xuat(vt);
            }
        } 
    }
}

