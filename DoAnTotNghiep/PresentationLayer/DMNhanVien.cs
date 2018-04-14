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
using System.IO;

namespace DoAnTotNghiep.PresentationLayer
{
    public partial class DMNhanVien : Office2007RibbonForm
    {
        public DMNhanVien()
        {
            InitializeComponent();
        }
        BLNhanVien NhanVienBL = new BLNhanVien();
        IList<object> DSNhanVien2 = new List<object>();
        IList<NHANVIEN> DSNhanVien = new List<NHANVIEN>();
        NHANVIEN nhanvien;
        int vitri = 0;        
        public void xuat_luoi()
        {
            luoinhanvien.AutoGenerateColumns = false;
            luoinhanvien.DataSource = null;
            luoinhanvien.DataSource = DSNhanVien2;
        }
        void xuat_chitiet_moi()
        {
            imghinh.Image = null;
            imghinh.BackgroundImage = Image.FromFile(Application.StartupPath + "/HinhNV/NoPhoto.jpg ");
            txtchitiet.Text = "";
        }       
        void xuat_chitiet_nhanvien(int vitri)
        {
            bar1.AutoHide = false;
            bar1.Show();            
            NHANVIEN dong = NhanVienBL.DocNhanVienTheoID(int.Parse(luoinhanvien.Rows[vitri].Cells[0].Value.ToString()));
            bar1.Text = "Chi tiết nhân viên: " + dong.MaNV;
            imghinh.SizeMode = PictureBoxSizeMode.StretchImage;
            imghinh.Image = Image.FromFile(Application.StartupPath+@"\HinhNV\"+dong.HinhAnhNV);
            txtchitiet.Text = "** Họ Tên NV: " + dong.HoNV.ToString() +" "+ dong.TenNV + Environment.NewLine;
            txtchitiet.Text += "** Ngày sinh: " + Convert.ToDateTime(dong.NgaySinh).ToString("dd/MM/yyyy");
            if (dong.GioiTinh == true)
            {
                txtchitiet.Text += " ----- Giới tính: Nam" + Environment.NewLine;
            }
            else
                txtchitiet.Text += " ----- Giới tính: Nữ" + Environment.NewLine;
           
            txtchitiet.Text += "** Địa chỉ: " + dong.DiaChiNV.ToString() + Environment.NewLine;
            txtchitiet.Text += "** Email: " + dong.Email.ToString() + Environment.NewLine;
            txtchitiet.Text += "** Điện thoại: " + dong.DienThoaiNV.ToString() + Environment.NewLine;
            txtchitiet.Text += "** Ghi chú: " + dong.GhiChuNV;
          
        }
        private void DMNhanVien_Load(object sender, EventArgs e)
        {
            DSNhanVien2 = NhanVienBL.DocNhanVien();
            DSNhanVien = NhanVienBL.DocNhanVienLen();
            xuat_luoi();
            if (vitri >= 0)
                xuat_chitiet_nhanvien(vitri);
            else
            {
                xuat_chitiet_moi();
                //chitiet.AutoHide = true;
            }
            nhanvien = DSNhanVien[0];
           // xuat_luoi();
            //xuat_chitiet_nhanvien(0);
        }
        private void luoinhanvien_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            switch (e.ColumnIndex)
            {
                case 4:
                    if (e.Value == null || e.Value == DBNull.Value)
                        return;
                    if ((Boolean)e.Value == true)
                        e.Value = "Nam";
                   else
                         e.Value = "Nữ";
                    break;                   
            }
        }

        private void luoinhanvien_Click(object sender, EventArgs e)
        {
            if (DSNhanVien.Count == 0)
            {
                vitri = -1;
            }
            else
            {
                vitri = luoinhanvien.CurrentCell.RowIndex;
                if (vitri < 0)
                {
                    xuat_chitiet_moi();
                }
                nhanvien = DSNhanVien[vitri];
                xuat_chitiet_nhanvien(vitri);
            }
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            var frmnhanvien = new PresentationLayer.NhanVien_Edit();
            frmnhanvien.ShowDialog();           
            DSNhanVien2 = NhanVienBL.DocNhanVien();
            DSNhanVien = NhanVienBL.DocNhanVienLen();
            xuat_luoi();
            vitri = luoinhanvien.RowCount - 1;
            luoinhanvien.CurrentCell = luoinhanvien.Rows[vitri].Cells[1];
            luoinhanvien.Rows[vitri].Selected = true;
            xuat_chitiet_nhanvien(vitri);

        }

        private void btnsua_Click(object sender, EventArgs e)
        {
           // vitri = luoinhanvien.CurrentRow.Index;           
            if (DSNhanVien.Count>0 && nhanvien != null)
            {
                //string hinh = nhanvien.HinhAnhNV;
                //imghinh.Image = null;
                var frmNhanNV_Edit = new NhanVien_Edit();
                frmNhanNV_Edit.nhanvien = nhanvien;
                frmNhanNV_Edit.ShowDialog();
               
                DSNhanVien2 = NhanVienBL.DocNhanVien();
                xuat_luoi();
                xuat_chitiet_nhanvien(vitri);
                luoinhanvien.CurrentCell = luoinhanvien.Rows[vitri].Cells[1];
                luoinhanvien.Rows[vitri].Selected = true;
                //File.Delete(Environment.CurrentDirectory + @"\HinhNV\" + hinh);  
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn Nhân viên để sửa");
            }

        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (vitri >= 0)
                {
                    DialogResult Tl = MessageBox.Show("Chương trình sẽ xoá Nhân Viên: " + nhanvien.HoNV+" "+nhanvien.TenNV, "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (Tl == DialogResult.OK)
                    {

                        if (vitri == 0)
                        {
                            //File.Delete(Environment.CurrentDirectory + @"\HinhNV\" + nhanvien.HinhAnhNV);  
                            DSNhanVien = NhanVienBL.Xoa(nhanvien);
                            vitri += 1;

                            nhanvien = DSNhanVien[vitri];

                            DSNhanVien2 = NhanVienBL.DocNhanVien();
                            xuat_luoi();
                            luoinhanvien.CurrentCell = luoinhanvien.Rows[vitri].Cells[1];
                            luoinhanvien.Rows[vitri].Selected = true;
                            xuat_chitiet_nhanvien(vitri);
                        }
                        if (vitri > 0 && vitri < DSNhanVien.Count - 1)
                        {
                            DSNhanVien = NhanVienBL.Xoa(nhanvien);
                            vitri -= 1;

                            nhanvien = DSNhanVien[vitri];

                            DSNhanVien2 = NhanVienBL.DocNhanVien();
                            xuat_luoi();
                            luoinhanvien.CurrentCell = luoinhanvien.Rows[vitri].Cells[1];
                            luoinhanvien.Rows[vitri].Selected = true;
                            xuat_chitiet_nhanvien(vitri); ;
                        }
                        if (vitri == DSNhanVien.Count - 1)
                        {
                            //File.Delete(Environment.CurrentDirectory + @"\HinhNV\" + nhanvien.HinhAnhNV);  
                            DSNhanVien = NhanVienBL.Xoa(nhanvien);
                            vitri -= 1;

                            nhanvien = DSNhanVien[vitri];

                            DSNhanVien2 = NhanVienBL.DocNhanVien();
                            xuat_luoi();                           
                            luoinhanvien.CurrentCell = luoinhanvien.Rows[vitri].Cells[1];
                            luoinhanvien.Rows[vitri].Selected = true;
                            xuat_chitiet_nhanvien(vitri);
                        }
                        //txttongso.Text = "Tổng số: " + luoinhacc.RowCount.ToString();
                    }
                }
                else
                {
                    MessageBox.Show("Bạn chưa chọn dòng để Xóa ");
                }

            }
            catch (DeleteNhanVienNDungException ex)
            {
                MessageBox.Show(ex.Mess);
            }
            catch (DeleteNhanVienDDException ex)
            {
                MessageBox.Show(ex.Mess);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi trong quá trình cập nhật dữ liệu: Lỗi:" + ex.Message);
            }
        }

        private void txttimkiem_TextChanged(object sender, EventArgs e)
        {
            string dk = txttimkiem.Text;
            DSNhanVien2 = NhanVienBL.DocChucVuTheodieukienTK(dk);
            if (DSNhanVien2.Count > 0)
            {
                vitri = 0;
                xuat_luoi();
                xuat_chitiet_nhanvien(vitri);
            }
            else
            {
                luoinhanvien.DataSource = null;
            }
        }
    }
}
