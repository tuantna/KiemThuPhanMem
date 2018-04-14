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
    public partial class Frm_DanhGiaTBi : Office2007RibbonForm
    {
        public Frm_DanhGiaTBi()
        {
            InitializeComponent();
        }
        BLDonVi DonViBL = new BLDonVi();
        BLPhongBan PhongBanBL = new BLPhongBan();
        BLSoTheoDoi SoTheoDoiBL = new BLSoTheoDoi();
        BLTinhTrang TinhTrangBL = new BLTinhTrang();

        IList<TINHTRANG> DSTinhTrang = new List<TINHTRANG>();
        IList<DONVI> DSDonVi = new List<DONVI>();
        IList<PHONGBAN> DSPhongBan = new List<PHONGBAN>();
        IList<object> DSSoTDoiGiao = new List<object>();       
       
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
        void xuat_luoi()
        {
            luoithietbi.AutoGenerateColumns = false;
            luoithietbi.DataSource = null;
            luoithietbi.DataSource = DSSoTDoiGiao;
        }
        private void Frm_DanhGiaTBi_Load(object sender, EventArgs e)
        {
            if (PhamMem.QuyenID == 2)
            {
                DSDonVi = DonViBL.DocDonVi();
                xuat_donvi();
                cbokhoa.SelectedValue = PhamMem.DonViID;
                cbokhoa.Enabled = false;
            }
            else
            {
                DSDonVi = DonViBL.DocDonVi();
                xuat_donvi();
            }
            DSTinhTrang = TinhTrangBL.DocTinhTrang();                     
        }

        private void cbokhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            DSPhongBan = PhongBanBL.DocPhongBanTheoDK((int)cbokhoa.SelectedValue);
            if (DSPhongBan.Count == 0)
            {
                cbophongban.DataSource =null;
            }
            else
                xuat_phongban();
        }

        private void cbophongban_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbophongban.DataSource != null)
                {
                    int PBID = (int)cbophongban.SelectedValue;
                    DSSoTDoiGiao = SoTheoDoiBL.DocSoTheoDoiTheoPBID((int)cbophongban.SelectedValue);
                    if (DSSoTDoiGiao.Count == 0)
                        luoithietbi.DataSource = null;
                    else
                        xuat_luoi();
                }
                else
                    luoithietbi.DataSource = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã có lỗi hệ thống");
            }
        }
        private void buttonX1_Click(object sender, EventArgs e)
        {
            if (DSSoTDoiGiao.Count == 0) return;
            int idpb = (int)cbophongban.SelectedValue;

            var frm = new Frm_DanhGia_Edit(idpb);
            frm.ShowDialog();
            DSSoTDoiGiao = SoTheoDoiBL.DocSoTheoDoiTheoPBID(idpb);
            xuat_luoi();
        }

    }
}
