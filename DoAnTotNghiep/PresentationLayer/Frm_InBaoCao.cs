using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using System.Configuration;
using DoAnTotNghiep.BusinessLayer;
using DoAnTotNghiep.DataAcessLayer;
using System.IO;

namespace DoAnTotNghiep.PresentationLayer
{
    public partial class Frm_InBaoCao : Office2007Form
    {
        public Frm_InBaoCao()
        {
            InitializeComponent();
        }
        string server = null;
        string csdl = null;
        private void Xuat_danh_khoa()
        {
            BLDonVi DonViBl = new BLDonVi();
            cbokhoa.DisplayMember = "TenDonVi";
            cbokhoa.ValueMember = "DonViID";
            cbokhoa.DataSource = DonViBl.DocDonVi();
        }
        private void Xuat_danh_phongban()
        {
            BLPhongBan PhongBanBL = new BLPhongBan();
            cbophongnban.DisplayMember = "TenPhongBan";
            cbophongnban.ValueMember = "PhongBanID";
            cbophongnban.DataSource = PhongBanBL.DocPhongBanTheoDK((int)cbokhoa.SelectedValue);
        }

        private void Frm_InBaoCao_Load(object sender, EventArgs e)
        {
            server = ConfigurationManager.AppSettings["server_name"];
            csdl = ConfigurationManager.AppSettings["CSDL"];

            cbocluachon.Items.Add("Danh mục Thiết bị");
            cbocluachon.Items.Add("Danh sách Nhà Cung cấp");          
            cbocluachon.Items.Add("Phiếu Nhập hàng");
            cbocluachon.Items.Add("Phiếu Kiểm kê");
            cbocluachon.Items.Add("Phiếu bàn giao");
            cbocluachon.Items.Add("Phiếu thanh lý");
            cbocluachon.Items.Add("Danh mục loại thiết bị");
            cbocluachon.SelectedIndex = 0;
            if (PhamMem.QuyenID == 2)
            {                
                Xuat_danh_khoa();
                cbokhoa.SelectedValue = PhamMem.DonViID;
                cbokhoa.Enabled = false;
            }
            else
            {
                Xuat_danh_khoa();
            }
            grouptaptin.Enabled = false;
            //raddoc.Enabled = true;
            //radslx.Enabled = true;
            txtduongdan.Enabled = false;

        }

        private void cbokhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (PhamMem.QuyenID == 2)
            //{
            //    Xuat_danh_khoa();
            //    cbokhoa.SelectedValue = PhamMem.DonViID;
            //    cbokhoa.Enabled = false;
            //    Xuat_danh_phongban();
            //}
            //else
            //{
                Xuat_danh_phongban();
            //}            
        }

        private void radtaptin_CheckedChanged(object sender, EventArgs e)
        {
            grouptaptin.Enabled = true;
            //raddoc.Enabled = true;
            //radslx.Enabled = true;
            txtduongdan.Enabled = true;
            buttonX1.Enabled = true;
        }

        private void radmanhinh_CheckedChanged(object sender, EventArgs e)
        {
            grouptaptin.Enabled = false;
            //raddoc.Enabled = true;
            //radslx.Enabled = true;
            txtduongdan.Enabled = false;
            buttonX1.Enabled = false;
        }

        private void radmayin_CheckedChanged(object sender, EventArgs e)
        {
            grouptaptin.Enabled = false;
            //raddoc.Enabled = true;
            //radslx.Enabled = true;
            txtduongdan.Enabled = false;
            buttonX1.Enabled = false;
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            try
            {
                string duongdan = "";
                SaveFileDialog FileSave = new SaveFileDialog();
                FileSave.ShowDialog();
                this.StartPosition = FormStartPosition.CenterScreen;
                duongdan = FileSave.FileName;
                txtduongdan.Text = Path.GetFullPath(duongdan);
            }catch(Exception ex)
            {
                return;
            }
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btninbc_Click(object sender, EventArgs e)
        {
            CrystalDecisions.CrystalReports.Engine.ReportClass bc = null;
            if (cbocluachon.SelectedIndex == 0)
            {
                bc = new BaoCao.BC_ThietBi();
              
            }
            else if (cbocluachon.SelectedIndex == 1)
            {
                bc = new BaoCao.BC_NhaCC();
              
            }
            else if (cbocluachon.SelectedIndex == 2)
            {
                bc = new BaoCao.BC_PNhap_CTPNhap();               
            }
            else if (cbocluachon.SelectedIndex == 3)
            {
                bc = new BaoCao.BC_KiemKe();
               
            }
            else if (cbocluachon.SelectedIndex == 4)
            {
                bc = new BaoCao.BC_BanGiao();
               
            }
            else if (cbocluachon.SelectedIndex == 5)
            {
                bc = new BaoCao.BC_ThanhLy();
                //if (PhamMem.QuyenID == 2)
                //{
                //    Xuat_danh_khoa();
                //    cbokhoa.SelectedValue = PhamMem.DonViID;
                //    cbokhoa.Enabled = false;
                //}
                //else
                //{
                //    Xuat_danh_khoa();
                //}
            }
            else if (cbocluachon.SelectedIndex == 6)
            {
                bc = new BaoCao.BC_ThietBi_TheoLoai();              
            }
           
            // Dinh lai duong dan Database cho bc
            CrystalDecisions.Shared.TableLogOnInfo Thong_tin;
            Thong_tin = bc.Database.Tables[0].LogOnInfo;
            Thong_tin.ConnectionInfo.ServerName = server;
            Thong_tin.ConnectionInfo.DatabaseName = csdl;

            Thong_tin.ConnectionInfo.IntegratedSecurity = true;
            bc.Database.Tables[0].ApplyLogOnInfo(Thong_tin);
            // Loc du lieu
            if (cbocluachon.SelectedIndex == 2)
            {               
                bc.RecordSelectionFormula = "{PHIEUPHAP.PhongBanID} = " + id;                   
               
            }
            if (cbocluachon.SelectedIndex == 3)
            {
                bc.RecordSelectionFormula = "{DOTKIEMKE.PhongBanID} = " + id;
                if (PhamMem.QuyenID == 2)
                {
                    Xuat_danh_khoa();
                    cbokhoa.SelectedValue = PhamMem.DonViID;
                    cbokhoa.Enabled = false;
                }
            }
            if (cbocluachon.SelectedIndex == 4)
            {
                bc.RecordSelectionFormula = "{BANGIAO.PhongBanID} = " + id;
                if (PhamMem.QuyenID == 2)
                {
                    Xuat_danh_khoa();
                    cbokhoa.SelectedValue = PhamMem.DonViID;
                    cbokhoa.Enabled = false;
                }
            }
            if (cbocluachon.SelectedIndex == 5)
            {
                bc.RecordSelectionFormula = "{THANHLY.PhongBanID} = " + id;
                if (PhamMem.QuyenID == 2)
                {
                    Xuat_danh_khoa();
                    cbokhoa.SelectedValue = PhamMem.DonViID;
                    cbokhoa.Enabled = false;
                }
            }

            // Xuat bao cao
            if (radmayin.Checked == true) // May in
            {
                bc.PrintToPrinter(1, true, 0, 0);               
            }
            else if (radtaptin.Checked == true) // Tap tin
            {
                if (raddoc.Checked == true)
                {
                    bc.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.WordForWindows, txtduongdan.Text + ".doc");
                }
                else
                {
                    bc.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.Excel, txtduongdan.Text + ".xls");


                }
                MessageBox.Show("Xuất thành công");
                string kieu = (raddoc.Checked == true) ? ".doc" : ".xls";
                System.Diagnostics.Process.Start(txtduongdan.Text + kieu);
            }
            else // May hinh
            {
                FrmBaoCao mh = new FrmBaoCao();
                mh.Crv.ReportSource = bc;
                mh.ShowDialog();
                //if (PhamMem.QuyenID == 2)
                //{
                //    cbokhoa.SelectedValue = PhamMem.DonViID;
                 //   cbokhoa.Enabled = false;
                //}
               // Xuat_danh_khoa();

            }
        }
        int id = 0;
        private void cbophongnban_SelectedIndexChanged(object sender, EventArgs e)
        {
            id =(int)cbophongnban.SelectedValue;
        }
    }
}
