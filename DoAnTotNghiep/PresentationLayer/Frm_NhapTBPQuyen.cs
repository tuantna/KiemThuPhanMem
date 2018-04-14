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
    public partial class Frm_NhapTBPQuyen : Office2007RibbonForm
    {
        public Frm_NhapTBPQuyen()
        {
            InitializeComponent();
        }
        BLNhaCC NhaCCBL = new BLNhaCC();
        BLDonVi DonViBL = new BLDonVi();
        BLPhongBan PhongBanBL = new BLPhongBan();    
        BLNguoiDung NguoiDungBL = new BLNguoiDung();
        BLPNhap PhieuNhapBL = new BLPNhap();

        IList<NHACUNGCAP> DSNhaCC = new List<NHACUNGCAP>();
        IList<DONVI> DSDonVi = new List<DONVI>();
        IList<PHONGBAN> DSPhongBan = new List<PHONGBAN>();       
        IList<object> DSNguoiDung = new List<object>();
        IList<PHIEUPHAP> DSPhieuNhap = new List<PHIEUPHAP>();
        void xuat_Nhacc()
        {
            cbotenncc.DisplayMember = "TenNhaCC";
            cbotenncc.ValueMember = "NCCID";
            cbotenncc.DataSource = DSNhaCC;
        }
        void xuat_donvi()
        {
            cbodonvi.DataSource = null;
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
            cbonguoinhan.DisplayMember = "MaDangNhap";
            // cbonguoinhan.DisplayMember += "TenNV";
            cbonguoinhan.ValueMember = "NguoiDungID";
            cbonguoinhan.DataSource = DSNguoiDung;
        }
        void xuat_chi_tiet(int pPNhap)
        {
            luoichitiet.AutoGenerateColumns = false;
            BLCTPNhap CTPNhapBL = new BLCTPNhap();
            luoichitiet.DataSource = CTPNhapBL.DocCTPNhapToObject(pPNhap);
            txttongtien.Visible = true;
            txttongtien.Text ="Tổng cộng: "+ CTPNhapBL.TongTienNhapTheoPhieu(pPNhap).ToString("#,###0 VNĐ");

        }
        private void Frm_NhapTBPQuyen_Load(object sender, EventArgs e)
        {
            if (PhamMem.QuyenID == 2)
            {
                DSDonVi = DonViBL.DocDonVi();
                xuat_donvi();
                cbodonvi.SelectedValue = PhamMem.DonViID;
                cbodonvi.Enabled = false;
                DSNguoiDung = NguoiDungBL.DocDSNguoiDungchoCBo();
                xuat_nhanvien();
                cbonguoinhan.SelectedValue = PhamMem.idMa;
                cbonguoinhan.Enabled = false;
            }
           // DSDonVi = DonViBL.DocDonVi();   
            DSNhaCC=NhaCCBL.DocNhaCC();            
            
            xuat_Nhacc();
            luoichitiet.DataSource = null;
            txttongtien.Visible = false;
        }

        private void cbodonvi_SelectedIndexChanged(object sender, EventArgs e)
        {
            DSPhongBan = PhongBanBL.DocPhongBanTheoDK(PhamMem.DonViID);            
            xuat_phongban();           
        }

        private void cbotenncc_SelectedIndexChanged(object sender, EventArgs e)
        {
            NHACUNGCAP ncc = NhaCCBL.DocNhaCCTheoID((int)cbotenncc.SelectedValue);
            if (ncc != null)
            {
                txtdiachincc.Text = ncc.DiaChiNhaCC;
                txtnguoilh.Text = ncc.HoTenNguoiLH;
            }
            else
            {
                txtdiachincc.Text = "";
                txtnguoilh.Text = "";
            }
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            BLPNhap PhieuNhapBL = new BLPNhap();
            PHIEUPHAP pn =new PHIEUPHAP();
            pn.NgayNhap = datangay.Value;
            pn.NCCID =(int)cbotenncc.SelectedValue;
            pn.PhongBanID = (int)cbophongban.SelectedValue;
            pn.NguoiDungID = PhamMem.idMa;

            DSPhieuNhap = PhieuNhapBL.Them(pn);



            int idphongban = (int)cbophongban.SelectedValue;
            //if (them || DSPhieuNhap.Count == 0) return;
            PHIEUPHAP pnhap = PhieuNhapBL.DocPNhapTheongay(datangay.Value);        
            var frm = new Frm_NhapThemTBPQ(pnhap, idphongban);

            frm.ShowDialog();
            xuat_chi_tiet(pnhap.PhieuNhapID);


        }

        private void buttonX4_Click(object sender, EventArgs e)
        {
            if (PhamMem.QuyenID == 2)
            {
                DSDonVi = DonViBL.DocDonVi();
                xuat_donvi();
                cbodonvi.SelectedValue = PhamMem.DonViID;
                cbodonvi.Enabled = false;
                DSNguoiDung = NguoiDungBL.DocDSNguoiDungchoCBo();
                xuat_nhanvien();
                cbonguoinhan.SelectedValue = PhamMem.idMa;
                cbonguoinhan.Enabled = false;
            }
            // DSDonVi = DonViBL.DocDonVi();   
            DSNhaCC = NhaCCBL.DocNhaCC();

            xuat_Nhacc();
            luoichitiet.DataSource = null;
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            var frmnhacc = new NhaCC_Edit();
            frmnhacc.ShowDialog();
            DSNhaCC = NhaCCBL.DocNhaCC();
            xuat_Nhacc();
        }
    }
}
