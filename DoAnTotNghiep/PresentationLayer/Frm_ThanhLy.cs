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
    public partial class Frm_ThanhLy : Office2007RibbonForm
    {
        public Frm_ThanhLy()
        {
            InitializeComponent();
        }
        BLDonVi DonViBL = new BLDonVi();
        BLPhongBan PhongBanBL = new BLPhongBan();
        BLSoTheoDoi STDBL = new BLSoTheoDoi();
        BLNhanVien NhanVienBL = new BLNhanVien();

        IList<DONVI> DSDonVi=new List<DONVI>();
        IList<PHONGBAN> DSPhongBan = new List<PHONGBAN>();
        IList<object> DSSTD = new List<object>();
        IList<object> DSNhanVien = new List<object>();
        void xuat_donvi()
        {
            cbodonvi.DisplayMember = "TenDonVi";
            cbodonvi.ValueMember = "DonViID";
            cbodonvi.DataSource = DSDonVi;
        }
        void xuat_phongban()
        {
            cbophongban.DisplayMember = "TenPhongBan";
            cbophongban.ValueMember = "PhongBanID";
            cbophongban.DataSource = DSPhongBan;
        }
        void xuat_nhanvien()
        {
            cbonhanvien.DisplayMember = "HoTenNV";
            cbonhanvien.ValueMember = "NhanVienID";
            cbonhanvien.DataSource = DSNhanVien;
        }
        void xuat_luoithanhly()
        {
            luoithanhly.AutoGenerateColumns = false;
            luoithanhly.DataSource = null;
            luoithanhly.DataSource = DSSTD;
        }
        private void Frm_ThanhLy_Load(object sender, EventArgs e)
        {

            if (PhamMem.QuyenID == 2)
            {
                DSDonVi = DonViBL.DocDonVi();
                xuat_donvi();
                cbodonvi.SelectedValue = PhamMem.DonViID;
                cbodonvi.Enabled = false;
            }
            else
            {
                DSDonVi = DonViBL.DocDonVi();
                xuat_donvi();
                xuat_phongban();
                xuat_nhanvien();
            }
        }

        private void cbodonvi_SelectedIndexChanged(object sender, EventArgs e)
        {
            DSPhongBan = PhongBanBL.DocPhongBanTheoDK((int)cbodonvi.SelectedValue);
            DSNhanVien = NhanVienBL.NhanVienDHTheoDonViID((int)cbodonvi.SelectedValue);
            if (DSPhongBan.Count == 0)
            {
                cbophongban.DataSource =null;
            }
            else
                xuat_phongban();
            if (DSNhanVien.Count == 0)
                cbonhanvien.DataSource = null;
            else
                xuat_nhanvien();
        }

        private void cbophongban_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbophongban.DataSource != null)
                {
                    DSSTD = STDBL.DocSoTheoDoiTheoPBID((int)cbophongban.SelectedValue);
                    if (DSSTD.Count == 0)
                        luoithanhly.DataSource = null;
                    else
                        xuat_luoithanhly();
                }else
                    luoithanhly.DataSource = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã có lỗi hệ thống");
            }

        }

        private void buttonX4_Click(object sender, EventArgs e)
        {
            BLThanhLy ThanhLyBL = new BLThanhLy();
            BLCTThanhLy CTTLBL = new BLCTThanhLy();
            BLSoTheoDoi STDBL=new BLSoTheoDoi();

            IList<SOTHEODOI> DSSTD1=new List<SOTHEODOI>();
            IList<THANHLY> DSThanhLY = new List<THANHLY>();

            THANHLY TL = new THANHLY();
            TL.NgayThanhLy = datangay.Value;
            TL.DaiDienBenMua = txtbenmua.Text;
            TL.GhiChuTL = txtghichuTL.Text;
            TL.PhongBanID =(int)cbophongban.SelectedValue;

            DSThanhLY = ThanhLyBL.Them(TL);

            THANHLY thanhly = ThanhLyBL.DocThanhLyTheoNgay(datangay.Value);            

            foreach (DataGridViewRow check in luoithanhly.Rows)
            {
                if ((bool)check.Cells["chon"].FormattedValue)
                {
                    //check.Cells["ten_SP"].Value.ToString());// giá trị cần lấy
                    int id = int.Parse(check.Cells["ThietBiID"].Value.ToString());
                    int giaban = int.Parse(check.Cells["GiaBan"].Value.ToString());
                    if (check.Cells["GiaBan"].Value != null || giaban >0)
                    {
                        giaban = int.Parse(check.Cells["GiaBan"].Value.ToString());
                    }
                    else
                    {
                        MessageBox.Show("Giá bán không hợp lệ");
                        return;
                    }
                    CHITIETTHANHLY CTTL = new CHITIETTHANHLY();
                    CTTL.ThietBiID = id;
                    CTTL.ThanhLyID = thanhly.ThanhLyID;
                    CTTL.GiaTriThanhLy = giaban;

                    CTTLBL.Them(CTTL);

                    int pbid = (int)cbophongban.SelectedValue;
                    SOTHEODOI std = STDBL.DocSOTHEODOITheoTB_PB(id, pbid);
                   // std.TinhTrangID = 5;


                    DSSTD1 = STDBL.Xoa(std);

                   // STDBL.CapNhat(std);

                    //MessageBox.Show(giaban.ToString());                   
                }               
                //else
                //{
                //    MessageBox.Show("Bạn chưa chọn thiết bị");
                //}
              
            }

            MessageBox.Show("Thanh lý thành công");

            DSSTD = STDBL.DocSoTheoDoiTheoPBID((int)cbophongban.SelectedValue);
            xuat_luoithanhly();
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            var frmkhoa = new PresentationLayer.DonVi_Edit();
            frmkhoa.ShowDialog();
            DSDonVi = DonViBL.DocDonVi();
            xuat_donvi();
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            var frmphongban = new PresentationLayer.PhongBan_Edit();
            frmphongban.ShowDialog();
            DSPhongBan = PhongBanBL.DocPhongBan();
            xuat_phongban();
        }

        private void buttonX3_Click(object sender, EventArgs e)
        {
            var frmnhanvien = new PresentationLayer.NhanVien_Edit();
            frmnhanvien.ShowDialog();
            DSNhanVien = NhanVienBL.NhanVienDHTheoDonViID((int)cbodonvi.SelectedValue);
            xuat_nhanvien();
        }
    }
}
