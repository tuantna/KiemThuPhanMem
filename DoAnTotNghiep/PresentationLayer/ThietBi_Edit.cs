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
    public partial class ThietBi_Edit : Office2007Form
    {
        public ThietBi_Edit()
        {
            InitializeComponent();
        }
        BLDVTinh DVTinhBL = new BLDVTinh();
        BLNuocSX NuocSXBL = new BLNuocSX();
        BLLoaiTB LoaiTBBL = new BLLoaiTB();
        BLThietBi ThietBiBL = new BLThietBi();

        IList<LOAITHIETBI> DSLoaiTB=new List<LOAITHIETBI>();
        IList<DVTINH> DSDVTinh = new List<DVTINH>();
        IList<NUOCSX> DSNuocSX = new List<NUOCSX>();
        IList<THIETBI> DSThietBi = new List<THIETBI>();
        public string THANHCONG = "";

        public THIETBI thietbi;

        public void xuatloaiTB()
        {
            cboloaitb.DisplayMember = "TenLoaiTB";
            cboloaitb.ValueMember = "LoaiTBID";
            cboloaitb.DataSource = DSLoaiTB;
        }
        void xuatDVTinh()
        {
            cbodonvitinh.DisplayMember = "TenDVT";
            cbodonvitinh.ValueMember = "DVTID";
            cbodonvitinh.DataSource = DSDVTinh;
        }
        void xuatNuocSX()
        {
            cbonuocsx.DisplayMember = "TenNuoc";
            cbonuocsx.ValueMember = "NUOCSXID";
            cbonuocsx.DataSource = DSNuocSX;
        }
        void xuat_thietbi_moi()
        {
            this.Text = "Thêm mới thiết bị";
            txtmathietbi.Text = "";
            txttentb.Text = "";
            cboloaitb.SelectedIndex = 0;
            cbonuocsx.SelectedIndex = 0;
            cbodonvitinh.SelectedIndex = 0;
            nunamsx.Value = 2000;
            nubaohanh.Value = 0;
            nusoluong.Value = 0;
            imghinh.Image = null;
            imghinh.SizeMode = PictureBoxSizeMode.StretchImage;
            imghinh.Image = Image.FromFile(Application.StartupPath + @"\HinhTB\NoPhoto.jpg");
            txtthongso.Text = "";
            txtmota.Text = "";
        }
        void xuat_thietbi()
        {
            this.Text = "Cập nhật thiết bị: " + thietbi.MaThietBi;
            txtmathietbi.Text = thietbi.MaThietBi;
            txttentb.Text = thietbi.TenTB ;
            cboloaitb.SelectedValue=thietbi.LoaiTBID;
            cbonuocsx.SelectedValue = thietbi.NUOCSXID ;
            cbodonvitinh.SelectedValue=thietbi.DVTID;
            nunamsx.Value =(int)thietbi.NamSanXuat;
            nubaohanh.Value =(int)thietbi.ThoiGianBH;
            nusoluong.Value =(int)thietbi.SoLuongTB;
            imghinh.SizeMode = PictureBoxSizeMode.StretchImage;
            imghinh.Image = Image.FromFile(Application.StartupPath + @"\HinhTB\"+thietbi.HinhAnh);
           // hinh = thietbi.HinhAnh;
            txtthongso.Text = thietbi.ThongSoKT;
            txtmota.Text = thietbi.MoTa;
        }
        void nhap_thietbi()
        {
            if (thietbi == null) thietbi = new THIETBI();
            thietbi.MaThietBi = txtmathietbi.Text;
            thietbi.TenTB = txttentb.Text;
            thietbi.LoaiTBID = (int)cboloaitb.SelectedValue;
            thietbi.DVTID = (int)cbodonvitinh.SelectedValue;
            thietbi.NUOCSXID = (int)cbonuocsx.SelectedValue;
            thietbi.NamSanXuat =(int)nunamsx.Value;
            thietbi.ThoiGianBH = (int)nubaohanh.Value;
            thietbi.SoLuongTB = (int)nusoluong.Value;
            thietbi.ThongSoKT = txtthongso.Text;
            thietbi.MoTa = txtmota.Text;
            if (thietbi == null)
            {
                if (hinh.ToString() == "")
                    thietbi.HinhAnh = "NoPhoto.jpg";
                else
                    thietbi.HinhAnh = hinh.ToString();
            }
            else
            {
                if (hinh == thietbi.HinhAnh)
                {
                    thietbi.HinhAnh = hinh;
                }
                if (hinh != thietbi.HinhAnh)
                {
                    thietbi.HinhAnh = hinh;
                }  

            }

        }
        void nhap_thietbi2()
        {
            if (thietbi == null) thietbi = new THIETBI();
            thietbi.MaThietBi = txtmathietbi.Text;
            thietbi.TenTB = txttentb.Text;
            thietbi.LoaiTBID = (int)cboloaitb.SelectedValue;
            thietbi.DVTID = (int)cbodonvitinh.SelectedValue;
            thietbi.NUOCSXID = (int)cbonuocsx.SelectedValue;
            thietbi.NamSanXuat = (int)nunamsx.Value;
            thietbi.ThoiGianBH = (int)nubaohanh.Value;
            thietbi.SoLuongTB = (int)nusoluong.Value;
            thietbi.ThongSoKT = txtthongso.Text;
            thietbi.MoTa = txtmota.Text;
            if (hinh.ToString() == "")
                thietbi.HinhAnh = "NoPhoto.jpg";
            else
                thietbi.HinhAnh = hinh.ToString();
        }
        private void ThietBi_Edit_Load(object sender, EventArgs e)
        {
            DSDVTinh = DVTinhBL.DocDVT();
            DSNuocSX = NuocSXBL.DocNSX();
            DSLoaiTB = LoaiTBBL.DocLoaiTBi();
            DSThietBi = ThietBiBL.DocThietBi();
            xuatDVTinh();
            xuatNuocSX();
            xuatloaiTB();
            if (thietbi == null)
            {
                xuat_thietbi_moi();
            }
            else
            {
                xuat_thietbi();
                hinh = thietbi.HinhAnh;
            }
        }
        string hinh = "";
        private void btnchonanh_Click(object sender, EventArgs e)
        {
            OpenFileDialog f = new OpenFileDialog();
            if (f.ShowDialog() == DialogResult.OK)
            {
                imghinh.Image = Image.FromFile(f.FileName);
                //hinh = System.IO.Path.GetFileName(f.FileName);
                //MessageBox.Show(hinh);
                hinh = System.IO.Path.GetFileName(f.FileName);
                for (int i = 0; i < DSThietBi.Count; i++)
                {
                    if (hinh.Equals(DSThietBi[i].HinhAnh.ToString()))
                    {
                        MessageBox.Show("Hình đã có --  Chọn hình khác đi !!!!");
                        if (thietbi == null)
                        {
                            imghinh.SizeMode = PictureBoxSizeMode.StretchImage;
                            imghinh.Image = Image.FromFile(Application.StartupPath+ @"\HinhTB\NoPhoto.jpg");
                            hinh = "NoPhoto.jpg";
                        }
                        else
                        {
                            imghinh.SizeMode = PictureBoxSizeMode.StretchImage;
                            imghinh.Image = Image.FromFile(Application.StartupPath + @"\HinhTB\" + thietbi.HinhAnh);
                            hinh = thietbi.HinhAnh.ToString();
                        }
                        break;
                    }
                }
               // MessageBox.Show(hinh);

            }
            else
            {
                if (thietbi == null)
                {
                    imghinh.SizeMode = PictureBoxSizeMode.StretchImage;
                    imghinh.Image = Image.FromFile(Application.StartupPath + @"\HinhTB\NoPhoto.jpg");
                    hinh = "NoPhoto.jpg";
                }
                else
                {
                    imghinh.SizeMode = PictureBoxSizeMode.StretchImage;
                    imghinh.Image = Image.FromFile(Application.StartupPath + @"\HinhTB\" + thietbi.HinhAnh);
                    hinh = thietbi.HinhAnh.ToString();
                }
            }
        }
        public delegate void TruyenLaiDuLieu(int maloai);
        public TruyenLaiDuLieu truyendulieu;
        private void btnluu_Click(object sender, EventArgs e)
        {
            try
            {
                if (thietbi != null)
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
                    //File.Delete(Environment.CurrentDirectory + @"\HinhTB\" + thietbi.HinhAnh);  
                    string ten = thietbi.HinhAnh;
                    nhap_thietbi();
                    DSThietBi = ThietBiBL.CapNhat(thietbi);
                    if (truyendulieu != null)
                    {
                        int maloaitb = int.Parse(cboloaitb.SelectedValue.ToString());
                        truyendulieu(maloaitb);

                    }
                    if (hinh !=ten)
                    {
                        imghinh.Image.Save(Application.StartupPath + @"\HinhTB\" + hinh.ToString());
                    }            
                    this.Close();
                }
                else
                {
                    if (btnluu.Text == "Lưu")
                    {
                        nhap_thietbi2();
                        ThietBiBL.Them(thietbi);
                        if (truyendulieu != null)
                        {
                            int maloaitb = int.Parse(cboloaitb.SelectedValue.ToString());
                            truyendulieu(maloaitb);

                        }
                        btnluu.Text = "Thêm Mới";
                        MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        THANHCONG = "Thêm thành công";
                        if (hinh.ToString() != "")
                            imghinh.Image.Save(Application.StartupPath + @"\HinhTB\" + hinh.ToString());
                        //else
                            //imghinh.Image.Save(Application.StartupPath + @"\HinhTB\NoPhoto.jpg");
                       

                    }
                    else
                    {
                        xuat_thietbi_moi();
                        btnluu.Text = "Lưu";
                    }
                    thietbi = null;
                }
            }
            catch (CapNhatThietBiException ex)
            {
                MessageBox.Show(ex.Mess);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi trong quá trình cập nhật dữ liệu: Lỗi:" + ex.Message);
            }
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
            if (truyendulieu != null)
            {
                int maloaitb = int.Parse(cboloaitb.SelectedValue.ToString());
                truyendulieu(maloaitb);
            }
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            var frmthemloaitb=new PresentationLayer.LoaiTB_Edit();
            frmthemloaitb.ShowDialog();
            DSLoaiTB = LoaiTBBL.DocLoaiTBi();
            xuatloaiTB();
        }

        private void buttonX3_Click(object sender, EventArgs e)
        {
            var frmthemnuocsx = new PresentationLayer.NSX_Edit();
            frmthemnuocsx.ShowDialog();
            DSNuocSX = NuocSXBL.DocNSX();
            xuatNuocSX();
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            var frmthemdvtinh = new PresentationLayer.DVT_edit();
            frmthemdvtinh.ShowDialog();
            DSDVTinh = DVTinhBL.DocDVT();
            xuatDVTinh();
        }
    }
}
