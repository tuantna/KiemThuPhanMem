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
    public partial class NhanVien_Edit : Office2007Form
    {
        public NhanVien_Edit()
        {
            InitializeComponent();
        }
        BLDonVi DonViBL = new BLDonVi();
        BLChucVu ChucVuBL = new BLChucVu();
        BLNhanVien NhanVienBL = new BLNhanVien();
        IList<DONVI> DSDonVi = new List<DONVI>();
        IList<CHUCVU> DSChucVu = new List<CHUCVU>();
        IList<NHANVIEN> DSNhanVien = new List<NHANVIEN>();
        public NHANVIEN nhanvien;
        void xuatdonvi()
        {
            cbodonvi.DisplayMember = "TenDonVi";
            cbodonvi.ValueMember = "DonViID";
            cbodonvi.DataSource = DSDonVi;
        }
        void xuatchucvu()
        {
            cbochucvu.DisplayMember = "TenChucVU";
            cbochucvu.ValueMember = "ChucVuID";
            cbochucvu.DataSource = DSChucVu;
        }
        void Nhap_NhanVien()
        {
            if (nhanvien == null) nhanvien = new NHANVIEN();
            nhanvien.MaNV = txtmanv.Text;
            nhanvien.HoNV = txthonv.Text;
            nhanvien.TenNV = txttennh.Text;
            if (cbogioitinh.Text == "Nam")
                nhanvien.GioiTinh = true;
            else
                nhanvien.GioiTinh = false;
            nhanvien.NgaySinh = Convert.ToDateTime(datangay.Value);
            nhanvien.DiaChiNV = txtdiachi.Text;
            nhanvien.Email = txtemail.Text;
            nhanvien.DienThoaiNV = txtdienthoai.Text;
            nhanvien.GhiChuNV = txtghichu.Text;
            nhanvien.DonViID = int.Parse(cbodonvi.SelectedValue.ToString());
            nhanvien.ChucVuID = int.Parse(cbochucvu.SelectedValue.ToString());
            if (nhanvien == null)
            {
                if (hinh.ToString() == "")
                    nhanvien.HinhAnhNV = "NoPhoto.jpg";
                else
                    nhanvien.HinhAnhNV = hinh.ToString();
            }
            else
            {
                if (hinh == nhanvien.HinhAnhNV)
                {
                    nhanvien.HinhAnhNV = hinh;
                } 
                if (hinh != nhanvien.HinhAnhNV)
                {
                    nhanvien.HinhAnhNV = hinh;
                }                
            }

        }
        void Nhap_NhanVien2()
        {
            if (nhanvien == null) nhanvien = new NHANVIEN();
            nhanvien.MaNV = txtmanv.Text;
            nhanvien.HoNV = txthonv.Text;
            nhanvien.TenNV = txttennh.Text;
            if (cbogioitinh.Text == "Nam")
                nhanvien.GioiTinh = true;
            else
                nhanvien.GioiTinh = false;
            nhanvien.NgaySinh = Convert.ToDateTime(datangay.Value);
            nhanvien.DiaChiNV = txtdiachi.Text;
            nhanvien.Email = txtemail.Text;
            nhanvien.DienThoaiNV = txtdienthoai.Text;
            nhanvien.GhiChuNV = txtghichu.Text;
            nhanvien.DonViID = int.Parse(cbodonvi.SelectedValue.ToString());
            nhanvien.ChucVuID = int.Parse(cbochucvu.SelectedValue.ToString());
            if (hinh.ToString() == "")
                nhanvien.HinhAnhNV = "NoPhoto.jpg";
            else
                nhanvien.HinhAnhNV = hinh.ToString();

        }
        void xuat_nhanvien()
        {
            txtnhanvienID.Text = nhanvien.NhanVienID.ToString();
            txtmanv.Text = nhanvien.MaNV;
            txthonv.Text = nhanvien.HoNV;
            txttennh.Text = nhanvien.TenNV;
            txtdienthoai.Text = nhanvien.DienThoaiNV;
            txtdiachi.Text = nhanvien.DiaChiNV;
            txtemail.Text = nhanvien.Email;
            cbodonvi.SelectedValue = nhanvien.DonViID;
            cbochucvu.SelectedValue = nhanvien.ChucVuID;
            if (nhanvien.GioiTinh == true)
            {
                cbogioitinh.Text = "Nam";
            }
            else
            {
                cbogioitinh.Text = "Nữ";
            }
            datangay.Value =Convert.ToDateTime(nhanvien.NgaySinh);
            txtghichu.Text = nhanvien.GhiChuNV;
            imghinh.Image = Image.FromFile(Application.StartupPath + @"\HinhNV\" + nhanvien.HinhAnhNV);            
            btnxoaanh.Enabled = true;

        }
        void Xuat_nhanvien_moi()
        {
            txtnhanvienID.Text = "";
            txtmanv.Text = "";
            txthonv.Text = "";
            txttennh.Text = "";
            txtdienthoai.Text = "";
            txtdiachi.Text = "";
            txtemail.Text = "";
            cbodonvi.SelectedIndex = 0;
            cbochucvu.SelectedIndex = 0;
            datangay.Value = Convert.ToDateTime("02/02/1992");
            txtghichu.Text = "";
            cbogioitinh.SelectedIndex = 0;
            imghinh.Image = null;
            imghinh.SizeMode = PictureBoxSizeMode.StretchImage;
            imghinh.Image = Image.FromFile(Application.StartupPath + @"\HinhNV\NoPhoto.jpg");
            btnxoaanh.Enabled = false;
            txtmanv.Select();
        }
        void xuat_gioitinh()
        {
            cbogioitinh.Items.Add("Nam");
            cbogioitinh.Items.Add("Nữ");
        }
        private void NhanVien_Edit_Load(object sender, EventArgs e)
        {
            DSDonVi = DonViBL.DocDonVi();
            DSChucVu = ChucVuBL.DocChucVu();
            DSNhanVien = NhanVienBL.DocNhanVienLen();
            xuatdonvi();
            xuatchucvu();
            xuat_gioitinh();
            if (nhanvien == null)
            {
                Xuat_nhanvien_moi();
            }
            else
            {
                xuat_nhanvien();
                hinh = nhanvien.HinhAnhNV;
            }
        }

        private void btnadd2_Click(object sender, EventArgs e)
        {
            var frmthem = new PresentationLayer.ChucVu_Edit();
            frmthem.ShowDialog();
        }
        private void btnadd1_Click(object sender, EventArgs e)
        {
            var frmthem = new PresentationLayer.DonVi_Edit();
            frmthem.ShowDialog();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnluu_Click(object sender, EventArgs e)
        {
            try
            {
                if (nhanvien != null)
                {
                   // DirectoryInfo drInfo = new DirectoryInfo(Environment.CurrentDirectory + @"\HinhNV");
                   //// DirectoryInfo[] folders = drInfo.GetDirectories(); // lay cac folder
                   // FileInfo[] files = drInfo.GetFiles(); //lay cac files
                   // if (files != null)
                   // {
                   //     foreach (FileInfo f in files)
                   //     {
                   //         string anh=f.FullName;
                   //         if(anh==nhanvien.HinhAnhNV)                           
                   //             File.Delete(anh);
                   //         //Console.WriteLine("Xoa File: " + f.FullName);
                   //     }
                   // }
                    //imghinh.ImageLocation = Environment.CurrentDirectory+@"\HinhNV\"+nhanvien.HinhAnhNV;
                    //File.Delete(Environment.CurrentDirectory + @"\HinhNV\" + nhanvien.HinhAnhNV);                     

                    //string duongdan = Application.StartupPath + @"\HinhNV\" + nhanvien.HinhAnhNV;
                    //File.Delete(duongdan);

                    string ten = nhanvien.HinhAnhNV;
                    Nhap_NhanVien();                    
                    DSNhanVien = NhanVienBL.CapNhat(nhanvien);
                    if (hinh != ten)
                    {
                        imghinh.Image.Save(Application.StartupPath + @"\HinhNV\" + hinh.ToString());
                    }                                     
                    this.Close();
                }
                else
                {
                    if (btnluu.Text == "Lưu")
                    {
                        Nhap_NhanVien2();
                        NhanVienBL.Them(nhanvien);
                        btnluu.Text = "Thêm Mới";
                        MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);                        
                        if (hinh.ToString() != "")
                            imghinh.Image.Save(Application.StartupPath + @"\HinhNV\" + hinh.ToString());                       
                            

                    }
                    else
                    {
                        Xuat_nhanvien_moi();
                        btnluu.Text = "Lưu";
                    }
                    nhanvien = null;
                }
            }
            catch (CapNhatNhanVienException ex)
            {
                MessageBox.Show(ex.Mess);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi trong quá trình cập nhật dữ liệu: Lỗi:" + ex.Message);
            }
        }
        string hinh = "";
        private void btnchonanh_Click(object sender, EventArgs e)
        {
        //    if (nhanvien != null)
        //    {

        //        File.Delete(Application.StartupPath + @"\HinhNV\" + nhanvien.HinhAnhNV);   
        //    }
            OpenFileDialog f = new OpenFileDialog();
            if (f.ShowDialog() == DialogResult.OK)
            {
                imghinh.Image = Image.FromFile(f.FileName);
                hinh = System.IO.Path.GetFileName(f.FileName);
                //MessageBox.Show(hinh);
                hinh = System.IO.Path.GetFileName(f.FileName);
                for (int i = 0; i < DSNhanVien.Count; i++)
                {
                    if (hinh.Equals(DSNhanVien[i].HinhAnhNV))
                    {
                        MessageBox.Show("Hình đã có --  Chọn hình khác đi !!!!");
                        if (nhanvien == null)
                        {
                            imghinh.SizeMode = PictureBoxSizeMode.StretchImage;
                            imghinh.Image = Image.FromFile(Application.StartupPath + @"\HinhNV\NoPhoto.jpg");
                            hinh = "NoPhoto.jpg";
                        }
                        else
                        {
                            imghinh.SizeMode = PictureBoxSizeMode.StretchImage;
                            imghinh.Image = Image.FromFile(Application.StartupPath + @"\HinhNV\" + nhanvien.HinhAnhNV);
                            hinh = nhanvien.HinhAnhNV.ToString();
                        }
                        break;
                    }                   
                }
                MessageBox.Show(hinh);
                
            }
            else
            {
                if (nhanvien == null)
                {
                    imghinh.SizeMode = PictureBoxSizeMode.StretchImage;
                    imghinh.Image = Image.FromFile(Application.StartupPath + @"\HinhNV\NoPhoto.jpg");
                    hinh = "NoPhoto.jpg";
                }
                else
                {
                    imghinh.SizeMode = PictureBoxSizeMode.StretchImage;
                    imghinh.Image = Image.FromFile(Application.StartupPath + @"\HinhNV\" + nhanvien.HinhAnhNV);
                    hinh = nhanvien.HinhAnhNV.ToString();
                }
            }
        }
    }
}
