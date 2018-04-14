using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.Linq;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using DoAnTotNghiep.BusinessLayer;
using DoAnTotNghiep.DataAcessLayer;
using DoAnTotNghiep.PresentationLayer;
using System.Configuration;
using System.Net;
using DevComponents.DotNetBar.Rendering;


namespace DoAnTotNghiep
{
    public partial class Frmain : Office2007RibbonForm 
    {
       string server=null;
       string csdl = null;


        BLSoTheoDoi SOTDOIBL = new BLSoTheoDoi();
        public Frmain()
        {
            InitializeComponent();
        }

        //------Phân Quyền--------------
        public void phanquyen(bool aa,bool bb)
        {
            Danhmuc.Visible = aa;
            Nghiepvu.Visible = aa;
            Baocao.Visible = aa;
            Quantri.Visible = aa;
            Menunhanh.Visible = aa;
            ChucnangDV.Visible = bb;
            Tracuu.Visible = aa;
        }

        //-----------------------------

        public bool CheckOpenTabs(string name)
        {
            for (int i = 0; i < tabControl1.Tabs.Count; i++)
            {
                if (tabControl1.Tabs[i].Text == name)
                {
                    tabControl1.SelectedTabIndex = i;
                    return true;
                }
            }
            return false;
        }
        
        private void buttonX1_Click(object sender, EventArgs e)
        {

        }

        private void buttonX1_Click_1(object sender, EventArgs e)
        {
            if (!CheckOpenTabs("Xuất xứ"))
            {
                TabItem t = tabControl1.CreateTab("Xuất xứ");
                DMNSX frm = new DMNSX();
                //frmMaterials frm = new frmMaterials();
                frm.TopLevel = false;
                frm.Dock = DockStyle.Fill;
                frm.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
                t.AttachedControl.Controls.Add(frm);
                frm.Show();
                tabControl1.SelectedTabIndex = tabControl1.Tabs.Count - 1;
            }
            else
                tabControl1.TabIndex = tabControl1.Tabs.Count - 1;

        }
        private void buttonX2_Click(object sender, EventArgs e)
        {
            if (!CheckOpenTabs("Đơn vị tính"))
            {
                TabItem t = tabControl1.CreateTab("Đơn vị tính");
                DMDVTinh frm = new DMDVTinh();
                //frmMaterials frm = new frmMaterials();
                frm.TopLevel = false;
                frm.Dock = DockStyle.Fill;
                frm.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
                t.AttachedControl.Controls.Add(frm);
                frm.Show();
                tabControl1.SelectedTabIndex = tabControl1.Tabs.Count - 1;
            }
            else
                tabControl1.TabIndex = tabControl1.Tabs.Count - 1;

        }

        private void buttonX3_Click(object sender, EventArgs e)
        {
            if (!CheckOpenTabs("Loại thiết bị"))
            {
                TabItem t = tabControl1.CreateTab("Loại thiết bị");
                DMLoaiTB frm = new DMLoaiTB();
                //frmMaterials frm = new frmMaterials();
                frm.TopLevel = false;
                frm.Dock = DockStyle.Fill;
                frm.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
                t.AttachedControl.Controls.Add(frm);
                frm.Show();
                tabControl1.SelectedTabIndex = tabControl1.Tabs.Count - 1;
            }
            else
                tabControl1.TabIndex = tabControl1.Tabs.Count - 1;

        }

        private void buttonX11_Click(object sender, EventArgs e)
        {
            if (!CheckOpenTabs("Nhà cung cấp"))
            {
                TabItem t = tabControl1.CreateTab("Nhà cung cấp");
                DMNhaCC frm = new DMNhaCC();
                //frmMaterials frm = new frmMaterials();
                frm.TopLevel = false;
                frm.Dock = DockStyle.Fill;
                frm.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
                t.AttachedControl.Controls.Add(frm);
                frm.Show();
                tabControl1.SelectedTabIndex = tabControl1.Tabs.Count - 1;
            }
            else
                tabControl1.TabIndex = tabControl1.Tabs.Count - 1;

        }

        private void buttonX7_Click(object sender, EventArgs e)
        {
            if (!CheckOpenTabs("Khoa"))
            {
                TabItem t = tabControl1.CreateTab("Khoa");
                DMDonVi frm = new DMDonVi();
                //frmMaterials frm = new frmMaterials();
                frm.TopLevel = false;
                frm.Dock = DockStyle.Fill;
                frm.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
                t.AttachedControl.Controls.Add(frm);
                frm.Show();
                tabControl1.SelectedTabIndex = tabControl1.Tabs.Count - 1;
            }
            else
                tabControl1.TabIndex = tabControl1.Tabs.Count - 1;

        }

        private void buttonX10_Click(object sender, EventArgs e)
        {
            if (!CheckOpenTabs("Chức vụ"))
            {
                TabItem t = tabControl1.CreateTab("Chức vụ");
                DMChucVu frm = new DMChucVu();
                //frmMaterials frm = new frmMaterials();
                frm.TopLevel = false;
                frm.Dock = DockStyle.Fill;
                frm.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
                t.AttachedControl.Controls.Add(frm);
                frm.Show();
                tabControl1.SelectedTabIndex = tabControl1.Tabs.Count - 1;
            }
            else
                tabControl1.TabIndex = tabControl1.Tabs.Count - 1;

        }

      
        //-------Thay doi giao dien 
        #region Automatic Color Scheme creation based on the selected color table

        private bool m_ColorSelected = false;
        private eOffice2007ColorScheme m_BaseColorScheme = eOffice2007ColorScheme.Blue;
        private void buttonStyleCustom_ExpandChange(object sender, System.EventArgs e)
        {
            if (colorPickerDropDown1.Expanded)
            {
                // Remember the starting color scheme to apply if no color is selected during live-preview
                m_ColorSelected = false;
                m_BaseColorScheme = ((Office2007Renderer)GlobalManager.Renderer).ColorTable.InitialColorScheme;
            }
            else
            {
                if (!m_ColorSelected)
                {
                    ribbonControl1.Office2007ColorTable = m_BaseColorScheme;
                }
            }
        }
        private void colorPickerDropDown1_SelectedColorChanged(object sender, EventArgs e)
        {
            m_ColorSelected = true; // Indicate that color was selected for buttonStyleCustom_ExpandChange method
            colorPickerDropDown1.CommandParameter = colorPickerDropDown1.SelectedColor;

        }
        #endregion

        private void colorPickerDropDown1_ColorPreview(object sender, ColorPreviewEventArgs e)
        {
            RibbonPredefinedColorSchemes.ChangeOffice2007ColorTable(this, m_BaseColorScheme, e.Color);
        }

        private void ApplicationTheme_Executed(object sender, EventArgs e)
        {
            ICommandSource source = sender as ICommandSource;
            if (source.CommandParameter is string)
            {
                eOffice2007ColorScheme colorScheme = (eOffice2007ColorScheme)Enum.Parse(typeof(eOffice2007ColorScheme), source.CommandParameter.ToString());
                // This is all that is needed to change the color table for all controls on the form
                ribbonControl1.Office2007ColorTable = colorScheme;
            }
            else if (source.CommandParameter is Color)
            {
                RibbonPredefinedColorSchemes.ChangeOffice2007ColorTable(this, m_BaseColorScheme, (Color)source.CommandParameter);
            }
            this.Invalidate();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            btntime.Text = System.DateTime.Now.ToLongTimeString();
        }

        private void buttonItem8_Click(object sender, EventArgs e)
        {
            if (!CheckOpenTabs("Người dùng"))
            {
                TabItem t = tabControl1.CreateTab("Người dùng");
                CN_Nguoi_dung frm = new CN_Nguoi_dung();
                //frmMaterials frm = new frmMaterials();
                frm.TopLevel = false;
                frm.Dock = DockStyle.Fill;
                frm.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
                t.AttachedControl.Controls.Add(frm);
                frm.Show();
                tabControl1.SelectedTabIndex = tabControl1.Tabs.Count - 1;
            }
            else
                tabControl1.TabIndex = tabControl1.Tabs.Count - 1;

        }
        void Tao_CaySuDung()
        {
            this.thumuccay.ImageList = this.listhinh;
            BLDonVi DonViBl = new BLDonVi();
            IList<DONVI> DSDVi=new List<DONVI>();
            BLPhongBan PhongBanBL = new BLPhongBan();
            IList<PHONGBAN> DSPhongBan = new List<PHONGBAN>();

                      
            DSDVi = DonViBl.DocDonVi();           
            for (int i = 0; i < DSDVi.Count; i++)
            {
                TreeNode th2 = new TreeNode(DSDVi[i].TenDonVi.ToString(), 0,0);
               
                th2.Tag = DSDVi[i].DonViID.ToString();
                thumuccay.Nodes.Add(th2);
                //tạo node con
                DSPhongBan = PhongBanBL.DocPhongBanTheoDK((int)DSDVi[i].DonViID);            
                for (int j = 0; j < DSPhongBan.Count; j++)
                {
                    string test = DSPhongBan[j].TenPhongBan.ToString()+": "+ PhongBanBL.TongTienSOTB(DSPhongBan[j].PhongBanID)+" thiết bị";
                    TreeNode th = new TreeNode(test, 1,1);                  
                    th.Tag = DSPhongBan[j].PhongBanID.ToString();
                    thumuccay.Nodes[i].Nodes.Add(th);
                }
            
            }
            thumuccay.Nodes[0].ExpandAll();
            
        }
        // Phan quyen khi dang nhap
        public void phanquyendangnhap()
        {
            if (PhamMem.QuyenID == 1)
            {
                phanquyen(true, false);
                lbtentieude.Text = "Admin - Quản trị thiết bị";
                Danhmuc.Select();
                taotranglamviec();
            }
            else
            {
                phanquyen(false, true);
                BLDonVi DonViBL = new BLDonVi();
                DONVI dv = DonViBL.DonViTheoID2(PhamMem.DonViID);
                lbtentieude.Text = "Đơn vị: " + dv.TenDonVi;
                ChucnangDV.Select();
                taotranglamviec();
            }
        }
      //-------
        void taotranglamviec()
        {
            if (!CheckOpenTabs("Bàn làm việc"))
            {
                TabItem t = tabControl1.CreateTab("Bàn làm việc");
                t.CloseButtonVisible = false;
                BanLamViec frm = new BanLamViec();
                //frmMaterials frm = new frmMaterials();
                frm.TopLevel = false;
                frm.Dock = DockStyle.Fill;
                frm.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
                t.AttachedControl.Controls.Add(frm);
                frm.Show();
                tabControl1.SelectedTabIndex = tabControl1.Tabs.Count - 1;
            }
            else
                tabControl1.TabIndex = tabControl1.Tabs.Count - 1;

        }
        void ThongKe()
        {
            lbthongke.Text = "Tổng số thiết bị:   " + SOTDOIBL.TongSoThietBI() +" -thiết bị"+ Environment.NewLine;
            lbthongke.Text += "  + Đang sử dụng:  " + SOTDOIBL.TongTienTBDangSD() + " -thiết bị" + Environment.NewLine;
            lbthongke.Text += "  + Đang sửa chữa: " + SOTDOIBL.TongTienTBSuaChua() + " -thiết bị" + Environment.NewLine;
            lbthongke.Text += "  + Đã thanh lý:   " + SOTDOIBL.TongTienTBDaTLy() + " -thiết bị" + Environment.NewLine;
            lbthongke.Text += "  + Bị mất:        " + SOTDOIBL.TongTienTBBiMat() + " -thiết bị" + Environment.NewLine;
            lbthongke.Text += "  + Bị hỏng:       " + SOTDOIBL.TongTienTBHu() + " -thiết bị" + Environment.NewLine;
        }
        private void Frmain_Load(object sender, EventArgs e)
        {
            server = ConfigurationManager.AppSettings["server_name"];
            csdl = ConfigurationManager.AppSettings["CSDL"];        

            Tao_CaySuDung();
            //Thống kê

            ThongKe();

            //----
            // Mo trang mac dinh
            //taotranglamviec();
            //--------------
            phanquyendangnhap();      
           

            //--------------------   
            btntaikhoan.Text = "Mã nhân viên : " + PhamMem.MaNV;
            btnngay.Text = "Date: " + DateTime.Today.ToString("dd/MM/yyyy");
            //btntime.Text = "Time: " + DateTime.Now.Hour + ":" + DateTime.Now.Minute + ":" + DateTime.Now.Second;
            btnsever.Text = "Server: " + ConfigurationManager.AppSettings["server_name"];
            btncsdl.Text = "CSDL: " + ConfigurationManager.AppSettings["CSDL"];
            string hostname = Dns.GetHostName();
            IPAddress[] ip = Dns.GetHostAddresses(hostname);
            btnip.Text = hostname + ":" + ip[0].ToString();

        }

        private void ribbonTabItem3_Click(object sender, EventArgs e)
        {

        }

        private void buttonItem4_Click(object sender, EventArgs e)
        {                  
            tabControl1.Tabs.Clear();
            taotranglamviec(); 
            var frmdangnhap = new DangNhap();
            frmdangnhap.ShowDialog();
            phanquyendangnhap();
            btntaikhoan.Text = "Mã nhân viên : " + PhamMem.MaNV;
        }

        private void buttonItem5_Click(object sender, EventArgs e)
        {
            tabControl1.Tabs.Clear();
            var frmdangnhap = new DangNhap();
            frmdangnhap.ShowDialog();
           // phanquyen();
        }

        private void buttonItem3_Click(object sender, EventArgs e)
        {
            if (!CheckOpenTabs("Phân quyền"))
            {
                TabItem t = tabControl1.CreateTab("Phân quyền");                
                Cap_Quyen frm = new Cap_Quyen();
                //frmMaterials frm = new frmMaterials();
                frm.TopLevel = false;
                frm.Dock = DockStyle.Fill;
                frm.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
                t.AttachedControl.Controls.Add(frm);
                frm.Show();
                tabControl1.SelectedTabIndex = tabControl1.Tabs.Count - 1;               
            }
            else
                tabControl1.TabIndex = tabControl1.Tabs.Count - 1;
           // tabControl1.Tabs.Remove(tabControl1.Tabs["Phân quyền"]);
            
        }

        private void buttonX9_Click(object sender, EventArgs e)
        {
            if (!CheckOpenTabs("Nhân viên"))
            {
                TabItem t = tabControl1.CreateTab("Nhân viên");
                DMNhanVien frm = new DMNhanVien();                
                frm.TopLevel = false;
                frm.Dock = DockStyle.Fill;
                frm.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
                t.AttachedControl.Controls.Add(frm);
                frm.Show();
                tabControl1.SelectedTabIndex = tabControl1.Tabs.Count - 1;
            }
            else
                tabControl1.TabIndex = tabControl1.Tabs.Count - 1;            
        }

        private void buttonX4_Click(object sender, EventArgs e)
        {
            if (!CheckOpenTabs("Thiết bị"))
            {
                TabItem t = tabControl1.CreateTab("Thiết bị");
                DMThietBi frm = new DMThietBi();
                frm.TopLevel = false;
                frm.Dock = DockStyle.Fill;
                frm.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
                t.AttachedControl.Controls.Add(frm);
                frm.Show();
                tabControl1.SelectedTabIndex = tabControl1.Tabs.Count - 1;
            }
            else
                tabControl1.TabIndex = tabControl1.Tabs.Count - 1;    
        }

        private void buttonX8_Click(object sender, EventArgs e)
        {
            if (!CheckOpenTabs("Phòng ban"))
            {
                TabItem t = tabControl1.CreateTab("Phòng ban");
                DMPhongBan frm = new DMPhongBan();
                frm.TopLevel = false;
                frm.Dock = DockStyle.Fill;
                frm.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
                t.AttachedControl.Controls.Add(frm);
                frm.Show();
                tabControl1.SelectedTabIndex = tabControl1.Tabs.Count - 1;
            }
            else
                tabControl1.TabIndex = tabControl1.Tabs.Count - 1;   
        }

        private void buttonItem6_Click(object sender, EventArgs e)
        {
            var frmdoimatkhau = new Doi_Mat_Khau();
            frmdoimatkhau.ShowDialog();
        }

        private void buttonX12_Click(object sender, EventArgs e)
        {
            if (!CheckOpenTabs("Kiểm kê"))
            {
                TabItem t = tabControl1.CreateTab("Kiểm kê");
                PhieuKiemKe frm = new PhieuKiemKe();
                frm.TopLevel = false;
                frm.Dock = DockStyle.Fill;
                frm.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
                t.AttachedControl.Controls.Add(frm);
                frm.Show();
                tabControl1.SelectedTabIndex = tabControl1.Tabs.Count - 1;
            }
            else
                tabControl1.TabIndex = tabControl1.Tabs.Count - 1;   
        }

        private void buttonItem9_Click(object sender, EventArgs e)
        {
            var frmbackup = new Frm_Backup_DuLieu();
            frmbackup.ShowDialog();
        }

        private void buttonX13_Click(object sender, EventArgs e)
        {
            if (!CheckOpenTabs("Nhập thiết bị"))
            {
                TabItem t = tabControl1.CreateTab("Nhập thiết bị");
                Frm_NhapThietBi frm = new Frm_NhapThietBi();
                frm.TopLevel = false;
                frm.Dock = DockStyle.Fill;
                frm.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
                t.AttachedControl.Controls.Add(frm);
                frm.Show();
                tabControl1.SelectedTabIndex = tabControl1.Tabs.Count - 1;
            }
            else
                tabControl1.TabIndex = tabControl1.Tabs.Count - 1;   
        }

        private void buttonX18_Click(object sender, EventArgs e)
        {
            if (!CheckOpenTabs("Bàn giao thiết bị"))
            {
                TabItem t = tabControl1.CreateTab("Bàn giao thiết bị");
                Frm_BanGiao frm = new Frm_BanGiao();
                frm.TopLevel = false;
                frm.Dock = DockStyle.Fill;
                frm.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
                t.AttachedControl.Controls.Add(frm);
                frm.Show();
                tabControl1.SelectedTabIndex = tabControl1.Tabs.Count - 1;
            }
            else
                tabControl1.TabIndex = tabControl1.Tabs.Count - 1;   
        }

        private void buttonItem11_Click(object sender, EventArgs e)
        {
            var frmdoimatkhau = new PresentationLayer.Doi_Mat_Khau();
            frmdoimatkhau.ShowDialog();
        }

        private void ribbonControl1_Click(object sender, EventArgs e)
        {

        }

        private void buttonItem13_Click(object sender, EventArgs e)
        {
            tabControl1.Tabs.Clear();
            var frmdangnhap = new DangNhap();
            frmdangnhap.ShowDialog();
            phanquyendangnhap();
            btntaikhoan.Text = "Mã nhân viên : " + PhamMem.MaNV;
           // taotranglamviec();
        }

        private void buttonItem14_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Frmain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn muốn thoát ứng dụng không?? ", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        private void buttonX24_Click(object sender, EventArgs e)
        {
            if (!CheckOpenTabs("Nhập thiết bị"))
            {
                TabItem t = tabControl1.CreateTab("Nhập thiết bị");
                Frm_NhapTBPQuyen frm = new Frm_NhapTBPQuyen();
                frm.TopLevel = false;
                frm.Dock = DockStyle.Fill;
                frm.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
                t.AttachedControl.Controls.Add(frm);
                frm.Show();
                tabControl1.SelectedTabIndex = tabControl1.Tabs.Count - 1;
            }
            else
                tabControl1.TabIndex = tabControl1.Tabs.Count - 1;   
        }

        private void buttonX25_Click(object sender, EventArgs e)
        {
            if (!CheckOpenTabs("Bàn giao thiết bị"))
            {
                TabItem t = tabControl1.CreateTab("Bàn giao thiết bị");
                Frm_BanGiao frm = new Frm_BanGiao();
                frm.TopLevel = false;
                frm.Dock = DockStyle.Fill;
                frm.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
                t.AttachedControl.Controls.Add(frm);
                frm.Show();
                tabControl1.SelectedTabIndex = tabControl1.Tabs.Count - 1;
            }
            else
                tabControl1.TabIndex = tabControl1.Tabs.Count - 1; 
        }

        private void buttonItem7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonX16_Click(object sender, EventArgs e)
        {              
            tabControl1.Tabs.Clear();
            taotranglamviec(); 
            var frmdangnhap = new DangNhap();
            frmdangnhap.ShowDialog();
            phanquyendangnhap();
            btntaikhoan.Text = "Mã nhân viên : " + PhamMem.MaNV;
        }
        private void buttonX15_Click(object sender, EventArgs e)
        {
            if (!CheckOpenTabs("Thanh lý thiết bị"))
            {
                TabItem t = tabControl1.CreateTab("Thanh lý thiết bị");
                Frm_ThanhLy frm = new Frm_ThanhLy();
                frm.TopLevel = false;
                frm.Dock = DockStyle.Fill;
                frm.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
                t.AttachedControl.Controls.Add(frm);
                frm.Show();
                tabControl1.SelectedTabIndex = tabControl1.Tabs.Count - 1;
            }
            else
                tabControl1.TabIndex = tabControl1.Tabs.Count - 1; 
        }

        private void buttonX17_Click(object sender, EventArgs e)
        {
            if (!CheckOpenTabs("Thanh lý thiết bị"))
            {
                TabItem t = tabControl1.CreateTab("Thanh lý thiết bị");
                Frm_ThanhLy frm = new Frm_ThanhLy();
                frm.TopLevel = false;
                frm.Dock = DockStyle.Fill;
                frm.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
                t.AttachedControl.Controls.Add(frm);
                frm.Show();
                tabControl1.SelectedTabIndex = tabControl1.Tabs.Count - 1;
            }
            else
                tabControl1.TabIndex = tabControl1.Tabs.Count - 1; 
        }

        private void buttonX28_Click(object sender, EventArgs e)
        {

        }

        private void buttonX28_Click_1(object sender, EventArgs e)
        {
            var frmbaocao = new PresentationLayer.Frm_InBaoCao();
            frmbaocao.ShowDialog();
        }

        private void buttonX35_Click(object sender, EventArgs e)
        {
            var frmbackup = new PresentationLayer.Frm_Backup_DuLieu();
            frmbackup.ShowDialog();
        }

        private void buttonItem21_Click(object sender, EventArgs e)
        {
            if (!CheckOpenTabs("Tìm kiếm thiết bị"))
            {
                TabItem t = tabControl1.CreateTab("Tìm kiếm thiết bị");
                Frm_TimKiemThietBi frm = new Frm_TimKiemThietBi();
                frm.TopLevel = false;
                frm.Dock = DockStyle.Fill;
                frm.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
                t.AttachedControl.Controls.Add(frm);
                frm.Show();
                tabControl1.SelectedTabIndex = tabControl1.Tabs.Count - 1;
            }
            else
                tabControl1.TabIndex = tabControl1.Tabs.Count - 1; 
        }

        private void buttonX26_Click(object sender, EventArgs e)
        {
            if (!CheckOpenTabs("Cập nhập tình trạng"))
            {
                TabItem t = tabControl1.CreateTab("Cập nhập tình trạng");
                Frm_DanhGiaTBi frm = new Frm_DanhGiaTBi();
                frm.TopLevel = false;
                frm.Dock = DockStyle.Fill;
                frm.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
                t.AttachedControl.Controls.Add(frm);
                frm.Show();
                tabControl1.SelectedTabIndex = tabControl1.Tabs.Count - 1;
            }
            else
                tabControl1.TabIndex = tabControl1.Tabs.Count - 1; 
        }
        private void buttonItem1_Click(object sender, EventArgs e)
        {
            if (!CheckOpenTabs("Thiết bị theo phòng ban"))
            {
                TabItem t = tabControl1.CreateTab("Thiết bị theo phòng ban");
                Frm_TimKiemTB_PhongBan frm = new Frm_TimKiemTB_PhongBan();
                frm.TopLevel = false;
                frm.Dock = DockStyle.Fill;
                frm.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
                t.AttachedControl.Controls.Add(frm);
                frm.Show();
                tabControl1.SelectedTabIndex = tabControl1.Tabs.Count - 1;
            }
            else
                tabControl1.TabIndex = tabControl1.Tabs.Count - 1; 
        }

        private void buttonItem3_Click_1(object sender, EventArgs e)
        {
            if (!CheckOpenTabs("Tìm kiếm Nhà CC"))
            {
                TabItem t = tabControl1.CreateTab("Tìm kiếm Nhà CC");
                Frm_TimKiemNhacc frm = new Frm_TimKiemNhacc();
                frm.TopLevel = false;
                frm.Dock = DockStyle.Fill;
                frm.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
                t.AttachedControl.Controls.Add(frm);
                frm.Show();
                tabControl1.SelectedTabIndex = tabControl1.Tabs.Count - 1;
            }
            else
                tabControl1.TabIndex = tabControl1.Tabs.Count - 1; 
        }

        private void buttonX6_Click(object sender, EventArgs e)
        {
            if (!CheckOpenTabs("Tình trạng"))
            {
                TabItem t = tabControl1.CreateTab("Tình trạng");
                DM_TinhTrang frm = new DM_TinhTrang();
                frm.TopLevel = false;
                frm.Dock = DockStyle.Fill;
                frm.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
                t.AttachedControl.Controls.Add(frm);
                frm.Show();
                tabControl1.SelectedTabIndex = tabControl1.Tabs.Count - 1;
            }
            else
                tabControl1.TabIndex = tabControl1.Tabs.Count - 1; 
        }

        private void buttonItem19_Click(object sender, EventArgs e)
        {
            if (!CheckOpenTabs("Tìm kiếm Nhà CC"))
            {
                TabItem t = tabControl1.CreateTab("Tìm kiếm Nhà CC");
                Frm_TimKiemNhacc frm = new Frm_TimKiemNhacc();
                frm.TopLevel = false;
                frm.Dock = DockStyle.Fill;
                frm.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
                t.AttachedControl.Controls.Add(frm);
                frm.Show();
                tabControl1.SelectedTabIndex = tabControl1.Tabs.Count - 1;
            }
            else
                tabControl1.TabIndex = tabControl1.Tabs.Count - 1; 
        }

        private void buttonX32_Click(object sender, EventArgs e)
        {
            CrystalDecisions.CrystalReports.Engine.ReportClass bc = null;
            if (!CheckOpenTabs("Báo cáo thiết bị"))    
            {

                bc = new BaoCao.BC_ThietBi();
                TabItem t = tabControl1.CreateTab("Báo cáo thiết bị");


                // Dinh lai duong dan Database cho bc
                CrystalDecisions.Shared.TableLogOnInfo Thong_tin;
                Thong_tin = bc.Database.Tables[0].LogOnInfo;
                Thong_tin.ConnectionInfo.ServerName = server;
                Thong_tin.ConnectionInfo.DatabaseName = csdl;

                Thong_tin.ConnectionInfo.IntegratedSecurity = true;
                bc.Database.Tables[0].ApplyLogOnInfo(Thong_tin);

                var frm = new PresentationLayer.FrmBaoCao();
                frm.WindowState = FormWindowState.Normal;
             

                frm.Crv.ReportSource = bc;
                frm.Crv.DisplayGroupTree = false;
                frm.TopLevel = false;
                frm.Dock = DockStyle.Fill;
                frm.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
                t.AttachedControl.Controls.Add(frm);
                frm.Show();
                tabControl1.SelectedTabIndex = tabControl1.Tabs.Count - 1;
            }
            else
                tabControl1.TabIndex = tabControl1.Tabs.Count - 1; 

            //var frmbc = new PresentationLayer.FrmBaoCao();
            //var bc = new BaoCao.BC_ThietBi();
            //frmbc.Crv.ReportSource = bc;
            //frmbc.ShowDialog();
        }

        private void buttonX31_Click(object sender, EventArgs e)
        {
            CrystalDecisions.CrystalReports.Engine.ReportClass bc = null;
            if (!CheckOpenTabs("Báo cáo nhà cung cấp"))
            {

                bc = new BaoCao.BC_NhaCC();

                TabItem t = tabControl1.CreateTab("Báo cáo nhà cung cấp");
              

                // Dinh lai duong dan Database cho bc
                CrystalDecisions.Shared.TableLogOnInfo Thong_tin;
                Thong_tin = bc.Database.Tables[0].LogOnInfo;
                Thong_tin.ConnectionInfo.ServerName = server;
                Thong_tin.ConnectionInfo.DatabaseName = csdl;

                Thong_tin.ConnectionInfo.IntegratedSecurity = true;
                bc.Database.Tables[0].ApplyLogOnInfo(Thong_tin);

                var frm = new PresentationLayer.FrmBaoCao();
                frm.WindowState = FormWindowState.Normal;

                frm.Crv.ReportSource = bc;
                frm.Crv.DisplayGroupTree = false;
                frm.TopLevel = false;
                frm.Dock = DockStyle.Fill;
                frm.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
                t.AttachedControl.Controls.Add(frm);
                frm.Show();
                tabControl1.SelectedTabIndex = tabControl1.Tabs.Count - 1;

          
            }
            else
                tabControl1.TabIndex = tabControl1.Tabs.Count - 1; 
        }

        private void buttonX30_Click(object sender, EventArgs e)
        {
            var frmtonghop = new Frm_InBaoCao();
            frmtonghop.ShowDialog();
        }

        private void buttonX21_Click(object sender, EventArgs e)
        {
            if (!CheckOpenTabs("Kiểm kê"))
            {
                TabItem t = tabControl1.CreateTab("Kiểm kê");
                PhieuKiemKe frm = new PhieuKiemKe();
                frm.TopLevel = false;
                frm.Dock = DockStyle.Fill;
                frm.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
                t.AttachedControl.Controls.Add(frm);
                frm.Show();
                tabControl1.SelectedTabIndex = tabControl1.Tabs.Count - 1;
            }
            else
                tabControl1.TabIndex = tabControl1.Tabs.Count - 1;   
        }

        private void buttonX20_Click(object sender, EventArgs e)
        {
            if (!CheckOpenTabs("Nhập thiết bị"))
            {
                TabItem t = tabControl1.CreateTab("Nhập thiết bị");
                Frm_NhapThietBi frm = new Frm_NhapThietBi();
                frm.TopLevel = false;
                frm.Dock = DockStyle.Fill;
                frm.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
                t.AttachedControl.Controls.Add(frm);
                frm.Show();
                tabControl1.SelectedTabIndex = tabControl1.Tabs.Count - 1;
            }
            else
                tabControl1.TabIndex = tabControl1.Tabs.Count - 1;  
        }

        private void buttonX19_Click(object sender, EventArgs e)
        {
            if (!CheckOpenTabs("Bàn giao thiết bị"))
            {
                TabItem t = tabControl1.CreateTab("Bàn giao thiết bị");
                Frm_BanGiao frm = new Frm_BanGiao();
                frm.TopLevel = false;
                frm.Dock = DockStyle.Fill;
                frm.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
                t.AttachedControl.Controls.Add(frm);
                frm.Show();
                tabControl1.SelectedTabIndex = tabControl1.Tabs.Count - 1;
            }
            else
                tabControl1.TabIndex = tabControl1.Tabs.Count - 1; 
        }

        private void buttonX36_Click(object sender, EventArgs e)
        {
            if (!CheckOpenTabs("Thanh lý thiết bị"))
            {
                TabItem t = tabControl1.CreateTab("Thanh lý thiết bị");
                Frm_ThanhLy frm = new Frm_ThanhLy();
                frm.TopLevel = false;
                frm.Dock = DockStyle.Fill;
                frm.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
                t.AttachedControl.Controls.Add(frm);
                frm.Show();
                tabControl1.SelectedTabIndex = tabControl1.Tabs.Count - 1;
            }
            else
                tabControl1.TabIndex = tabControl1.Tabs.Count - 1;
        }

        private void buttonX37_Click(object sender, EventArgs e)
        {
            var frmtonghop = new Frm_InBaoCao();
            frmtonghop.ShowDialog();
        }

        private void tabControl1_TabItemClose(object sender, TabStripActionEventArgs e)
        {
            tabControl1.Tabs.Remove(tabControl1.SelectedTab);
            ThongKe();
        }

        private void buttonX29_Click(object sender, EventArgs e)
        {
            if (!CheckOpenTabs("Cập nhập tình trạng"))
            {
                TabItem t = tabControl1.CreateTab("Cập nhập tình trạng");
                Frm_DanhGiaTBi frm = new Frm_DanhGiaTBi();
                frm.TopLevel = false;
                frm.Dock = DockStyle.Fill;
                frm.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
                t.AttachedControl.Controls.Add(frm);
                frm.Show();
                tabControl1.SelectedTabIndex = tabControl1.Tabs.Count - 1;
            }
            else
                tabControl1.TabIndex = tabControl1.Tabs.Count - 1; 
        }

        private void buttonX14_Click(object sender, EventArgs e)
        {
            var frmdoimatkhau = new Doi_Mat_Khau();
            frmdoimatkhau.ShowDialog();
        }
                   
    }
}
