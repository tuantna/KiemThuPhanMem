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
    public partial class PhieuKiemKe : Office2007RibbonForm
    {
        public PhieuKiemKe()
        {
            InitializeComponent();
        }
        BLDonVi DonViBL = new BLDonVi();
        BLPhongBan PhongBanBL = new BLPhongBan();
        BLNhanVien NhanVienBL = new BLNhanVien();   
        BLSoTheoDoi STDoiBL = new BLSoTheoDoi();
        BLDotKK DKKBL = new BLDotKK();
        BLDDienKK DaiDienKKBL = new BLDDienKK();

        IList<DONVI> DSDonVi = new List<DONVI>();
        IList<PHONGBAN> DSPhongBan = new List<PHONGBAN>();
        IList<object> DSNhanVien1 = new List<object>();
        IList<object> DSNhanVien2 = new List<object>();

        IList<DOTKIEMKE> DSDOTKK = new List<DOTKIEMKE>();
        IList<object> DSTBKK = new List<object>();
        

        int vitri = 0;
        void xuat_donvi()
        {
            cbokhoa.DisplayMember = "TenDonVi";
            cbokhoa.ValueMember = "DonViID";
            cbokhoa.DataSource = DSDonVi;
        }
        void xuat_phongban()
        {
            cbophongban.DisplayMember = "TenPhongBan";
            cbophongban.ValueMember = "PhongBanID";
            cbophongban.DataSource = DSPhongBan;
        }
        void xuat_nhanvien()
        {
            cbonhanvien1.DisplayMember = "HoTenNV";
            cbonhanvien1.ValueMember = "NhanVienID";
            cbonhanvien1.DataSource = DSNhanVien1;
        }
        void xuat_nhanvien2()
        {
            cbonhanvien2.DisplayMember = "HoTenNV";
            cbonhanvien2.ValueMember = "NhanVienID";
            cbonhanvien2.DataSource = DSNhanVien2;
            //cbonhanvien2.SelectedIndex = 1;
        }
        void xuat_phanquyen()
        {
            cbophanquyen1.Items.Add("Trưởng ban");
            cbophanquyen1.SelectedIndex = 0;
            cbophanquyen2.Items.Add("Ủy viên");
            cbophanquyen2.SelectedIndex = 0;
        }
        void Xuat_DaiDienKK( int PKKID)
        {
            DAIDIENKIEMKE DD = DaiDienKKBL.DocDDKKTheoID(PKKID);
           // cbonhanvien1.SelectedValue = DD.NhanVienID;
            MessageBox.Show(DD.NhanVienID.ToString());
        }
        //void xuat_PhieuKK()
        //{
        //    DOTKIEMKE dong = DSDOTKK[vitri];
        //    txtphieuKKID.Text = dong.KiemKeID.ToString();
        //    datangay.Value = Convert.ToDateTime(dong.NgayKiemKe);
        //    txtghichu.Text = dong.GhiChuKK;
        //    cbophongban.SelectedValue = dong.PhongBanID;

        //    Xuat_DaiDienKK(dong.KiemKeID);
        //    //cbotenncc.SelectedValue = dong.NCCID;
        //    //cbonguoinhan.SelectedValue = dong.NguoiDungID;
        //}
        //void xuat_PhieuKK(int vitri)
        //{
        //    DOTKIEMKE dong = DSDOTKK[vitri];
        //    txtphieuKKID.Text = dong.KiemKeID.ToString();
        //    datangay.Value = Convert.ToDateTime(dong.NgayKiemKe);
        //    txtghichu.Text = dong.GhiChuKK;
        //    cbophongban.SelectedValue = dong.PhongBanID;
        //    Xuat_DaiDienKK(dong.KiemKeID);
        //    //xuat_chi_tiet(dong.PhieuNhapID);
        //    //lbsotrang.Text = (1 + vitri).ToString() + " / " + DSPhieuNhap.Count.ToString();
        //}
        void xuat_luoichitietTB()
        {
            luoichitietKK.AutoGenerateColumns = false;
            luoichitietKK.DataSource = null;
            luoichitietKK.DataSource = DSTBKK;
           // luoichitietKK.Rows[0].Selected = true;
        }
        private void PhieuKiemKe_Load(object sender, EventArgs e)
        {
            //if (PhamMem.QuyenID == 2)
            //{
            //    DSDonVi = DonViBL.DocDonVi();
            //    xuat_donvi();
            //    cbokhoa.SelectedValue = PhamMem.DonViID;
            //    cbokhoa.Enabled = false;

            //}
            //else
            //{
                DSDonVi = DonViBL.DocDonVi();
                xuat_donvi();
            //}
            DSNhanVien1=NhanVienBL.DocNhanVienLenCbo();
            DSNhanVien2 = NhanVienBL.DocNhanVienLenCbo();         
           
            xuat_nhanvien();
            xuat_nhanvien2();
            xuat_phanquyen();           
        }      
        private void cbokhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            DSPhongBan = PhongBanBL.DocPhongBanTheoDK((int)cbokhoa.SelectedValue);
            if (DSPhongBan.Count == 0)
            {
                cbophongban.DataSource = null;
            }else            
                xuat_phongban();
        }
        
        private void buttonX2_Click(object sender, EventArgs e)
        {
           // vae
        }     
        private void cbonhanvien2_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cbonhanvien2.SelectedIndex == cbonhanvien1.SelectedIndex)
            {
                //MessageBox.Show("Trùng nhân viên");
                cbonhanvien2.SelectedIndex = 1;
            }
            else
                xuat_nhanvien2();   
        }

        private void cbophongban_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            DSTBKK = STDoiBL.DocSoTheoDoiTheoPBID((int)cbophongban.SelectedValue);
            xuat_luoichitietTB();
        }

        private void cbokhoa_SelectedIndexChanged_2(object sender, EventArgs e)
        {
            DSPhongBan = PhongBanBL.DocPhongBanTheoDK((int)cbokhoa.SelectedValue);
            xuat_phongban();
        }

        private void cbonhanvien1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbonhanvien1.SelectedIndex == cbonhanvien2.SelectedIndex)
            {
                //MessageBox.Show("Trùng nhân viên");
                cbonhanvien1.SelectedIndex = 0;
            }
            else
                xuat_nhanvien();  
        }

        private void buttonX3_Click_1(object sender, EventArgs e)
        {
            if (luoichitietKK.Rows.Count != 0)
            {
                 //Them DotKK
                DOTKIEMKE dd = new DOTKIEMKE();
                dd.NgayKiemKe = datangay.Value;
                dd.PhongBanID = (int)cbophongban.SelectedValue;
                dd.GhiChuKK = txtghichu.Text;

                DSDOTKK = DKKBL.Them(dd);
                //------

                ////Them DaiDienKK
                DOTKIEMKE dkk = DKKBL.DocDKKTheoPBID(datangay.Value);
                //// MessageBox.Show(dkk.KiemKeID.ToString());

                DAIDIENKIEMKE DaiDien1 = new DAIDIENKIEMKE();
                DaiDien1.KiemKeID = dkk.KiemKeID;
                DaiDien1.NhanVienID = (int)cbonhanvien1.SelectedValue;
                DaiDien1.QuyenHan = cbophanquyen1.Text;

                DAIDIENKIEMKE DaiDien2 = new DAIDIENKIEMKE();
                DaiDien2.KiemKeID = dkk.KiemKeID;
                DaiDien2.NhanVienID = (int)cbonhanvien2.SelectedValue;
                DaiDien2.QuyenHan = cbophanquyen2.Text;

                DaiDienKKBL.Them(DaiDien1);
                DaiDienKKBL.Them(DaiDien2);
                ///-----

                if (DSTBKK.Count == 0) return;
                int idpb = (int)cbophongban.SelectedValue;

                var frm = new Frm_DSThietBiKKe(idpb, dkk.KiemKeID);
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Phòng ban không có thiết bị để kiểm kê");
            }
        }

        private void buttonX2_Click_1(object sender, EventArgs e)
        {
            var frmthemnhanvien = new NhanVien_Edit();
            frmthemnhanvien.ShowDialog();
            xuat_nhanvien();
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            var frmthemnhanvien = new NhanVien_Edit();
            frmthemnhanvien.ShowDialog();
            xuat_nhanvien2();
        }

        private void labelX9_Click(object sender, EventArgs e)
        {

        }

        private void cbophanquyen2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbophanquyen1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void labelX6_Click(object sender, EventArgs e)
        {

        }

        private void labelX7_Click(object sender, EventArgs e)
        {

        }

        private void labelX5_Click(object sender, EventArgs e)
        {

        }

        private void labelX8_Click(object sender, EventArgs e)
        {

        }

        private void txtghichu_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelX10_Click(object sender, EventArgs e)
        {

        }

        private void datangay_ValueChanged(object sender, EventArgs e)
        {

        }

        private void labelX4_Click(object sender, EventArgs e)
        {

        }

        private void labelX3_Click(object sender, EventArgs e)
        {

        }

        private void labelX2_Click(object sender, EventArgs e)
        {

        }

        private void labelX1_Click(object sender, EventArgs e)
        {

        }       
    }
}
