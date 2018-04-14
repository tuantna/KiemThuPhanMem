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
using System.Collections;
using System.Configuration;

namespace DoAnTotNghiep.PresentationLayer
{
    public partial class Frm_NhapThietBi : Office2007RibbonForm
    {
        public Frm_NhapThietBi()
        {
            InitializeComponent();
        }
        BLNhaCC NhaCCBL = new BLNhaCC();
        BLDonVi DonViBL = new BLDonVi();
        BLPhongBan PhongBanBL = new BLPhongBan();
        BLNhanVien NhanVienBL = new BLNhanVien();
        BLNguoiDung NguoiDungBL = new BLNguoiDung();
        BLPNhap PhieuNhapBL = new BLPNhap();
       // BLThietBi ThietBiBL = new BLThietBi();

        IList<NHACUNGCAP> DSNhaCC = new List<NHACUNGCAP>();
        IList<DONVI> DSDonVi = new List<DONVI>();
        IList<PHONGBAN> DSPhongBan=new List<PHONGBAN>();
        IList<object> DSNguoiDung = new List<object>();
        IList<PHIEUPHAP> DSPhieuNhap = new List<PHIEUPHAP>();
        IList<NHANVIEN> DSNhanVien=new List<NHANVIEN>();
       // IList<object> DSThietBi = new List<object>();
        PHIEUPHAP pnhap;
        int vitri = 0;
        bool them = false;

        string server = null;
        string csdl = null;


        void xuat_PNhap()
        {
            PHIEUPHAP dong = DSPhieuNhap[vitri];
            txtphieunhapID.Text = dong.PhieuNhapID.ToString();
            datangay.Value = Convert.ToDateTime(dong.NgayNhap);
            txtghichu.Text = dong.GhiChuPNhap;
            cbophongban.SelectedValue = dong.PhongBanID;
            cbotenncc.SelectedValue = dong.NCCID;
            cbonguoinhan.SelectedValue = dong.NguoiDungID;
        }
        void xuat_PNhap(int vitri)
        {
            PHIEUPHAP dong = DSPhieuNhap[vitri];
            txtphieunhapID.Text = dong.PhieuNhapID.ToString();
            datangay.Value = DateTime.Parse(dong.NgayNhap.ToString());
            cbophongban.SelectedValue = dong.PhongBanID;
            cbotenncc.SelectedValue = dong.NCCID;
            cbonguoinhan.SelectedValue = dong.NguoiDungID;
            txtghichu.Text = dong.GhiChuPNhap;
            xuat_chi_tiet(dong.PhieuNhapID);
            lbsotrang.Text = (1 + vitri).ToString() + " / " + DSPhieuNhap.Count.ToString();
        }
        void xuat_hoso_PNhapmoi()
        {
            txtphieunhapID.Text = "";
            datangay.Value = DateTime.Today;
            txtghichu.Text = "";
            //DSDonVi = DonViBL.DocDonVi();
           // xuat_donvi();
            cbodonvi.SelectedIndex= 0;
            cbonguoinhan.SelectedIndex = 0;
            cbotenncc.SelectedIndex = 0;
        }
        void Nhap_Ho_so_PNhap()
        {
            if (them==true) pnhap = new PHIEUPHAP();
            pnhap.NgayNhap = datangay.Value;
            pnhap.NCCID = int.Parse(cbotenncc.SelectedValue.ToString());
            pnhap.PhongBanID = int.Parse(cbophongban.SelectedValue.ToString());
            pnhap.NguoiDungID = int.Parse(cbonguoinhan.SelectedValue.ToString());
            pnhap.GhiChuPNhap = txtghichu.Text;
        }

        void xuat_chi_tiet(int pPNhap)
        {
            luoichitiettb.AutoGenerateColumns = false;
            BLCTPNhap CTPNhapBL = new BLCTPNhap();
            luoichitiettb.DataSource = CTPNhapBL.DocCTPNhapToObject(pPNhap);
            txttongtien.Text = CTPNhapBL.TongTienNhapTheoPhieu(pPNhap).ToString("#,###0 VNĐ");
        }
        void xuat_Nhacc()
        {
            cbotenncc.DisplayMember = "TenNhaCC";
            cbotenncc.ValueMember="NCCID";
            cbotenncc.DataSource=DSNhaCC;
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
        private void Frm_NhapThietBi_Load(object sender, EventArgs e)
        {

            server = ConfigurationManager.AppSettings["server_name"];
            csdl = ConfigurationManager.AppSettings["CSDL"];

                    
                DSNhaCC = NhaCCBL.DocNhaCC();
                //if (PhamMem.QuyenID == 2)
                //{
                //    DSDonVi = DonViBL.DocDonVi();
                //    xuat_donvi();
                //    cbodonvi.SelectedValue = PhamMem.DonViID;
                //    cbodonvi.Enabled = false;
                //    DSPhongBan = PhongBanBL.DocPhongBan();
                //    xuat_phongban();
                //}
                //else
                //{
                    DSDonVi = DonViBL.DocDonVi();
                    xuat_donvi();
                    //DSPhongBan = PhongBanBL.DocPhongBan();
                    //xuat_phongban();
                //}                        
                DSPhieuNhap = PhieuNhapBL.DocPNhap();
                DSNguoiDung = NguoiDungBL.DocDSNguoiDung();

                DSPhongBan = PhongBanBL.DocPhongBan();
                xuat_phongban();
                xuat_Nhacc();
                xuat_nhanvien();                             
                if (DSPhieuNhap.Count > 0)
                {
                    vitri = 0;
                    xuat_PNhap(vitri);
                    pnhap = DSPhieuNhap[vitri];
                }
                else
                {
                    xuat_hoso_PNhapmoi();
                }            
        }     
                  
        void xuat_luoiTBNhap()
        {
            //luoichitiettb.AutoGenerateColumns = false;
            //luoichitiettb.DataSource = null;
            //luoichitiettb.DataSource = DSThietBi;
            //foreach (DataGridViewRow row in luoichitiettb.Rows)
            //{
            //    //if ((bool)row.Cells[0].FormattedValue)
            //    //{
            //        //MessageBox.Show(row.Cells[1].Value.ToString());
            //        //THIETBI tb = ThietBiBL.DocThietBiTheoID((int)row.Cells[1].Value);
            //       // int id = (int)row.Cells[1].Value;
            //     //   mang.Add(id);
            //        //MessageBox.Show(id.ToString());
            //    //    truyendulieu(mang);
            //   // }
            //    row.Cells[0].Value = "sds";

            //}
        }
        //private void btnthemtb_Click(object sender, EventArgs e)
        //{
        //    var frmdsthietbi = new PresentationLayer.Frm_DSThietBi();           
        //    frmdsthietbi.ShowDialog();          
        //    xuat_luoiTBNhap();
        //}

        private void buttonX8_Click(object sender, EventArgs e)
        {
            try
            {
                Nhap_Ho_so_PNhap();
                if (them)
                {
                    DSPhieuNhap = PhieuNhapBL.Them(pnhap);
                    vitri = DSPhieuNhap.Count - 1;
                    MessageBox.Show("Thêm thành công");
                }
                else // sua
                {
                    DSPhieuNhap = PhieuNhapBL.CapNhat(pnhap);
                    //luoinhacc.CurrentCell = luoinhacc.Rows[vitri].Cells[1];
                    // luoinhacc.Rows[vitri].Selected = true;
                    MessageBox.Show("Cập nhật thành công");
                }

                //xuat_PNhap();
                them = false;
                DSPhongBan = PhongBanBL.DocPhongBan();
                xuat_phongban();
                xuat_PNhap();               
                lbsotrang.Text = (1 + vitri).ToString() + " / " + DSPhieuNhap.Count.ToString();
            }
            catch (CapNhatNhaCCException ex)
            {
                MessageBox.Show(ex.Mess);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi trong quá trình cập nhật dữ liệu: Lỗi:" + ex.Message);
            }
        }

        private void buttonX3_Click_1(object sender, EventArgs e)
        {
            var frmthemkhoa = new PresentationLayer.DonVi_Edit();
            frmthemkhoa.ShowDialog();
            DSDonVi = DonViBL.DocDonVi();
            xuat_donvi();
        }

        private void buttonX5_Click_1(object sender, EventArgs e)
        {
            var frmthemphongban = new PresentationLayer.PhongBan_Edit();
            frmthemphongban.ShowDialog();
            DSPhongBan = PhongBanBL.DocPhongBan();
            xuat_phongban();
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            var frmthemNhaCC = new PresentationLayer.NhaCC_Edit();
            frmthemNhaCC.ShowDialog();
            DSNhaCC = NhaCCBL.DocNhaCC();
            xuat_Nhacc();
        }

        //private void buttonX6_Click_1(object sender, EventArgs e)
        //{
        //    var frmthemnhanvien = new PresentationLayer.NhanVien_Edit();
        //    frmthemnhanvien.ShowDialog();
        //    xuat_nhanvien();
        //}

       

        private void cbophongban_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbophongban.SelectedIndex == -1)
            {
                return;
            }

            if (them)
            {
                DSPhongBan = PhongBanBL.DocPhongBanTheoDK((int)cbodonvi.SelectedValue);
                xuat_phongban();
            }
            else
            {
                //if (PhamMem.QuyenID == 1)
               // {
                PHIEUPHAP dong = DSPhieuNhap[vitri];
                PHONGBAN pb = PhongBanBL.DocPhongBanTheoID(dong.PhongBanID);
                DONVI dv = DonViBL.DonViTheoID2(pb.DonViID);
                cbodonvi.SelectedValue = dv.DonViID;
                //}
               
                //xuat_donvi();
               
            }
        }

        private void buttonX12_Click(object sender, EventArgs e)
        {
            them = false;
            if (vitri <= 0) return;
            vitri = vitri - 1;
            xuat_PNhap(vitri);
            pnhap = DSPhieuNhap[vitri];

        }

        private void buttonX11_Click(object sender, EventArgs e)
        {
            them = false;
            if (vitri >= DSPhieuNhap.Count - 1) return;
            vitri = vitri + 1;
            xuat_PNhap(vitri);
            pnhap = DSPhieuNhap[vitri];
        }

        private void buttonX7_Click(object sender, EventArgs e)
        {
            them = true;
            xuat_hoso_PNhapmoi();
            datangay.Focus();

        }

        private void buttonX10_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Tl = MessageBox.Show("Chương trình sẽ xoá Phiếu nhập số: " + txtphieunhapID.Text, "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (Tl == DialogResult.OK)
                {
                    if (vitri == 0)
                    {
                        DSPhieuNhap = PhieuNhapBL.Xoa(pnhap);
                        vitri += 1;
                        xuat_PNhap();
                    }
                    if (vitri > 0 && vitri < DSPhieuNhap.Count - 1)
                    {
                        DSPhieuNhap = PhieuNhapBL.Xoa(pnhap);
                        vitri -= 1;
                        xuat_PNhap();
                    }
                    if (vitri >= DSPhieuNhap.Count - 1)
                    {
                        DSPhieuNhap = PhieuNhapBL.Xoa(pnhap);
                        vitri -= 1;
                        xuat_PNhap();
                    }
                    lbsotrang.Text = (1 + vitri).ToString() + " / " + DSPhieuNhap.Count.ToString();
                }
            }
            catch (DeleteCTPNhapException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonX9_Click(object sender, EventArgs e)
        {
            them = false;
            DSPhongBan = PhongBanBL.DocPhongBan();
            xuat_phongban();
            xuat_PNhap();
           // vitri = 0;
            
        }

        private void txtphieunhapID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtphieunhapID.Text != "")
                {
                    int tim = int.Parse(txtphieunhapID.Text);
                    int tam = DSPhieuNhap.ToList().FindIndex(delegate(PHIEUPHAP ph) { return ph.PhieuNhapID == tim; });
                    if (tam >= 0)
                    {
                        vitri = tam;
                        xuat_PNhap(vitri);
                    }
                }

            }
        }

        private void cbotenncc_SelectedIndexChanged_1(object sender, EventArgs e)
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

        private void cbodonvi_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (them)
            {
                DSPhongBan = PhongBanBL.DocPhongBanTheoDK((int)cbodonvi.SelectedValue);
                //DSNhanVien = NhanVienBL.NhanVienDHTheoDonViID((int)cbodonvi.SelectedValue);
                //NHANVIEN nv=NhanVienBL.DOcNguoiDungTheoaaa((int)cbodonvi.SelectedValue);
                if (DSPhongBan.Count == 0)
                {
                    cbophongban.DataSource = null;
                }
                else
                {
                    //if (PhamMem.QuyenID == 2)
                    //{
                    //    DSPhongBan = PhongBanBL.DocPhongBanTheoDK((int)cbodonvi.SelectedValue);
                    //    xuat_phongban();
                    //}
                    //else
                        xuat_phongban();

                }
            }
            else {
                //if (PhamMem.QuyenID == 2)
                //{
                //    DSPhongBan = PhongBanBL.DocPhongBanTheoDK((int)cbodonvi.SelectedValue);
                //    xuat_phongban();
                //}
                //else
                //    xuat_phongban();
            }
            //if (DSNhanVien.Count == 0)
            //{
            //    cbonguoinhan.DataSource = null;
            //}
            //else
            //{
            //    //for (int i = 0; i < DSNhanVien.Count; i++)
            //    //{
            //    //    cbonguoinhan.Items.Add(DSNhanVien[1].HoNV);
            //    //}

            //    xuat_nhanvien();
            //    //txthotennv.Text = nv.TenNV;
            //}
        }

        private void btnthemtb_Click_1(object sender, EventArgs e)
        {
           // MessageBox.Show(cbophongban.SelectedValue.ToString());
            int idphongban =(int)cbophongban.SelectedValue;
            if (them || DSPhieuNhap.Count == 0) return;
            PHIEUPHAP Pn = DSPhieuNhap[vitri];
            var frm = new Frm_DSThietBi(true, Pn,idphongban);

            frm.ShowDialog();
            xuat_chi_tiet(Pn.PhieuNhapID);
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            if (them || DSPhieuNhap.Count == 0) return;
            PHIEUPHAP Pn = DSPhieuNhap[vitri];
            var frm = new Frm_DSThietBi(false, Pn);
            frm.ShowDialog();
            xuat_chi_tiet(Pn.PhieuNhapID);
        }

        private void buttonX4_Click(object sender, EventArgs e)
        {
            if (luoichitiettb.Rows.Count == 0) return;

            try
            {
                DialogResult tl = MessageBox.Show("Xoá vật tư nhập", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (tl == DialogResult.Cancel) return;
                int mPNhapID = int.Parse(txtphieunhapID.Text);
                int mVatTuID = int.Parse(luoichitiettb.Rows[luoichitiettb.CurrentRow.Index].Cells["ThietBiID"].Value.ToString());
                BLCTPNhap CTPNhapBL = new BLCTPNhap();
                CHITIETPNHAP Ct = CTPNhapBL.DocCTPNhapTheoID(mPNhapID, mVatTuID);
                // Ton kho
                //BLTonKho TonKhoBL = new BLTonKho();
                //int delSL = Ct.SlNhap.Value;
                //TonKho Tk = TonKhoBL.DocTonKhoTheoID(Ngaynhaphang.Value.ToString("yyyyMM"), mVatTuID);
                //if ((Tk.SlCuoi - delSL) < 0)
                //{
                //    MessageBox.Show("Không thể xoá vật tư. Tồn kho âm");
                //}
                //else
                //{
                    // Xoá chi tiet
                    CTPNhapBL.Xoa(Ct);
                    xuat_chi_tiet(mPNhapID);
                    //// Cập nhật lại tồn kho
                    //Tk.TongSlNhap = Tk.TongSlNhap - delSL;
                    //Tk.SlCuoi = Tk.SlCuoi - delSL;
                    //TonKhoBL.CapNhat(Tk);
                    //TonKhoBL.KetChuyenTuDong(Ngaynhaphang.Value.Year, Ngaynhaphang.Value.Month);
                //}
            }
            catch (DeleteCTPNhapException ex)
            {
                MessageBox.Show(ex.Mess);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã có lỗi trong quá trình cập nhật" + ex.Message, "Thông báo");
            }
        }

        private void buttonX13_Click(object sender, EventArgs e)
        {
            CrystalDecisions.CrystalReports.Engine.ReportClass bc = null;
            bc = new BaoCao.BC_PNhap_CTPNhap();

            // Dinh lai duong dan Database cho bc
            CrystalDecisions.Shared.TableLogOnInfo Thong_tin;
            Thong_tin = bc.Database.Tables[0].LogOnInfo;
            Thong_tin.ConnectionInfo.ServerName = server;
            Thong_tin.ConnectionInfo.DatabaseName = csdl;

            Thong_tin.ConnectionInfo.IntegratedSecurity = true;
            bc.Database.Tables[0].ApplyLogOnInfo(Thong_tin);

                      
            bc.RecordSelectionFormula = "{PHIEUPHAP.PhongBanID} = " + cbophongban.SelectedValue;

            FrmBaoCao mh = new FrmBaoCao();
            mh.Crv.ReportSource = bc;
            mh.ShowDialog();
        }

      
    }
}
