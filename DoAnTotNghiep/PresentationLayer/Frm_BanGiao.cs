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
    public partial class Frm_BanGiao : Office2007RibbonForm
    {
        public Frm_BanGiao()
        {
            InitializeComponent();
        }
        BLDonVi DonViBL = new BLDonVi();
        BLPhongBan PhongBanBL = new BLPhongBan();
        BLNhanVien NhanVienBL = new BLNhanVien();
        BLSoTheoDoi SoTheoDoiBL= new BLSoTheoDoi();
        BLBanGiao BanGiaoBL = new BLBanGiao();
        BLCTBanGiao CTBGBL = new BLCTBanGiao();

        IList<DONVI> DSDonVi=new List<DONVI>();
        IList<DONVI> DSDonVi2 = new List<DONVI>();
        IList<PHONGBAN> DSPhongBan = new List<PHONGBAN>();
        IList<PHONGBAN> DSPhongBan2 = new List<PHONGBAN>();
        IList<object> DSNhanVien = new List<object>();      
        IList<object> DSNhanVien2= new List<object>();

        IList<object> DSSoTDoiGiao=new List<object>();
        IList<object> DSSoTDoiNhan = new List<object>();

        int vitri = 0;
        int vitri2 = 0;
        void xuat_donvigiao()
        {
            cbodonvigiao.DisplayMember = "TenDonVi";
            cbodonvigiao.ValueMember = "DonViID";
            cbodonvigiao.DataSource = DSDonVi;
        }
        void xuat_phongbangiao()
        {
            cbobophangiao.DisplayMember = "TenPhongBan";
            cbobophangiao.ValueMember = "PhongBanID";
            cbobophangiao.DataSource = DSPhongBan;
        }
        void xuat_nhanviengiao()
        {
            cbonvgiao.DisplayMember = "HoTenNV";
            cbonvgiao.ValueMember = "NhanVienID";
            cbonvgiao.DataSource = DSNhanVien;
        }
        void xuat_donvinhan()
        {
            cbodonvinhan.DisplayMember = "TenDonVi";
            cbodonvinhan.ValueMember = "DonViID";
            cbodonvinhan.DataSource = DSDonVi2;
        }
        void xuat_phongbannhan()
        {
            cbobophannhan.DisplayMember = "TenPhongBan";
            cbobophannhan.ValueMember = "PhongBanID";
            cbobophannhan.DataSource = DSPhongBan2;
        }
        void xuat_nhanviennhan()
        {
            cbonvnhan.DisplayMember = "HoTenNV";
            cbonvnhan.ValueMember = "NhanVienID";
            cbonvnhan.DataSource = DSNhanVien2;
        }    
        private void Frm_BanGiao_Load(object sender, EventArgs e)
        {
           // MessageBox.Show(PhamMem.QuyenID.ToString());
           // MessageBox.Show(PhamMem.DonViID.ToString());
            if (PhamMem.QuyenID == 2)
            {
                DSDonVi = DonViBL.DocDonVi();
                xuat_donvigiao();
                cbodonvigiao.SelectedValue = PhamMem.DonViID;
                cbodonvigiao.Enabled = false;
            }
            else
            {
                DSDonVi = DonViBL.DocDonVi();
                xuat_donvigiao();
               
                xuat_phongbangiao();
                xuat_nhanviengiao();              
            }
            DSDonVi2 = DonViBL.DocDonVi();
            xuat_donvinhan();
            xuat_phongbannhan();
            xuat_nhanviennhan();
        }
        private void cbodonvigiao_SelectedIndexChanged(object sender, EventArgs e)
        {
            DSPhongBan = PhongBanBL.DocPhongBanTheoDK((int)cbodonvigiao.SelectedValue);
            DSNhanVien = NhanVienBL.NhanVienDHTheoDonViID((int)cbodonvigiao.SelectedValue);
            if (DSPhongBan.Count == 0)
            {
                cbobophangiao.DataSource =null;
            }else
                xuat_phongbangiao();
            if (DSNhanVien.Count == 0)
                cbonvgiao.DataSource = null;
            else
                xuat_nhanviengiao();
           
           
        }

        private void cbodonvinhan_SelectedIndexChanged(object sender, EventArgs e)
        {
            DSPhongBan2 = PhongBanBL.DocPhongBanTheoDK((int)cbodonvinhan.SelectedValue);  
            DSNhanVien2 = NhanVienBL.NhanVienDHTheoDonViID((int)cbodonvinhan.SelectedValue);
            if (DSPhongBan2.Count == 0)
            {
                cbobophannhan.DataSource =null;
            }
            else                    
                xuat_phongbannhan();
            if (DSNhanVien2.Count == 0)
                cbonvnhan.DataSource = null;
            else
                xuat_nhanviennhan();
        }
        void xuat_luoibengiao()
        {
            luoibengiao.AutoGenerateColumns = false;
            luoibengiao.DataSource = null;
            luoibengiao.DataSource = DSSoTDoiGiao;
        }
        void xuat_luoibenNhan()
        {           
            //var query = (from ct in PhamMem.db.SOTHEODOIs
            //             where ct.PhongBanID == (int)cbobophangiao.SelectedValue
            //             select new { ct.ThietBiID, ct.TinhTrangID, ct.THIETBI.TenTB, ct.TINHTRANG.TenTinhTrang, ct.HienTrang }
            //                );
            //DSSoTDoiNhan=query.Cast<object>().ToList();
            //luoibennhan.Columns["HienTrangMoi"].HeaderText = "Hiện trạng mới";

            luoibennhan.AutoGenerateColumns = false;
            luoibennhan.DataSource = null;
            luoibennhan.DataSource = DSSoTDoiNhan;

            //luoibennhan.Columns[5].HeaderText = "Hiện trạng";
        }
        private void cbobophangiao_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DSSoTDoiGiao = SoTheoDoiBL.DocSoTheoDoiTheoPBID((int)cbobophangiao.SelectedValue);
                xuat_luoibengiao();

                if (luoibennhan.RowCount > 0)
                {
                    luoibennhan.DataSource = null;
                    DSSoTDoiNhan.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã có lỗi hệ thống");
            }


        }

        private void btntoi1_Click(object sender, EventArgs e)
        {
            try{
                if (luoibengiao.Rows.Count != 0)
                {
                    DSSoTDoiNhan.Add(DSSoTDoiGiao[vitri]);
                    DSSoTDoiGiao.RemoveAt(vitri);
                    xuat_luoibengiao();
                    xuat_luoibenNhan();
                }
                else
                {
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã có lỗi hệ thống");
            }

           
        }
        private void luoibengiao_Click(object sender, EventArgs e)
        {
            try
            {
                if (luoibengiao.Rows.Count == 0)
                {
                    vitri = -1;
                }
                else
                    vitri = luoibengiao.CurrentCell.RowIndex;
            } 
            catch (Exception ex)
            {
                MessageBox.Show("Đã có lỗi hệ thống");
            }
        }

        private void btntoi2_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < luoibengiao.Rows.Count; i++)
                {
                    DSSoTDoiNhan.Add(DSSoTDoiGiao[i]);
                }
                DSSoTDoiGiao.Clear();
                xuat_luoibenNhan();
                xuat_luoibengiao();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã có lỗi hệ thống");
            }
        }
       

        private void luoibennhan_Click(object sender, EventArgs e)
        {
            try{
            if (luoibennhan.Rows.Count == 0)
            {
                vitri2 = -1;
            }
            else
                vitri2 = luoibennhan.CurrentCell.RowIndex;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã có lỗi hệ thống");
            }
        }
        private void btnlui1_Click_1(object sender, EventArgs e)
        {
            try{
            if (luoibennhan.Rows.Count!=0)
            {
                DSSoTDoiGiao.Add(DSSoTDoiNhan[vitri2]);
                DSSoTDoiNhan.RemoveAt(vitri2);
                xuat_luoibengiao();
                xuat_luoibenNhan();
            }
            else
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã có lỗi hệ thống");
            }
        }

        private void btnlui2_Click_1(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < luoibennhan.Rows.Count; i++)
                {
                    DSSoTDoiGiao.Add(DSSoTDoiNhan[i]);
                }
                DSSoTDoiNhan.Clear();
                xuat_luoibenNhan();
                xuat_luoibengiao();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã có lỗi hệ thống");
            }
        }

        private void buttonX6_Click(object sender, EventArgs e)
        {
            if (luoibennhan.Rows.Count != 0)
            {
               IList<BANGIAO> DSBanGiao=new List<BANGIAO>();
               List<CHITIETBANGIAO> DSCTBG=new List<CHITIETBANGIAO>();

               BANGIAO BG = new BANGIAO();
               BG.PhongBanID = (int)cbobophangiao.SelectedValue;
               BG.PBNhan =cbobophannhan.Text;
               BG.GhiChuBG = " ";
               BG.DonViNhan = cbodonvinhan.Text;
               BG.NhanVienGiao =cbonvgiao.Text;
               BG.NhanVienNhan =cbonvnhan.Text;
               BG.NgayGiao = datangay.Value;

               DSBanGiao=BanGiaoBL.Them(BG);
               BANGIAO dkk = BanGiaoBL.DocBanGiaoTheoNgay(datangay.Value);
                for (int i = 0; i < luoibennhan.Rows.Count; i++)
                {
                    int STDID = int.Parse(luoibennhan.Rows[i].Cells["ID"].Value.ToString());
                   // int TRID = int.Parse(luoibennhan.Rows[i].Cells["TinhTrangID"].Value.ToString());

                    SOTHEODOI STD = SoTheoDoiBL.DocSOTHEODOITheoID(STDID);
                    STD.PhongBanID= (int)cbobophannhan.SelectedValue;                   
                    //if (luoibennhan.Rows[i].Cells["HienTrangMoi"].Value == null)
                    //{
                    //    MessageBox.Show("Bạn chưa cập nhật hiện trạng mới");
                    //    return;
                    //}
                  
                       // STD.HienTrang = luoibennhan.Rows[i].Cells["HienTrangMoi"].Value.ToString();

                    SoTheoDoiBL.CapNhat(STD);
                  //  int Sold = 0;
                   
                    
                    int tbid =int.Parse(luoibennhan.Rows[i].Cells["ThietBiID"].Value.ToString());
                    int idbg = dkk.BanGiaoID;
                   // MessageBox.Show(tbid.ToString());
                    CHITIETBANGIAO ctbg = new CHITIETBANGIAO();
                    ctbg.BanGiaoID = idbg;
                    ctbg.ThietBiID = tbid;                    
                    ctbg.TinhTrangBG = luoibennhan.Rows[i].Cells["TenTinhTrang"].Value.ToString();
                    if (luoibennhan.Rows[i].Cells["HienTrangMoi"].Value != null)
                    {
                        ctbg.HienTrangBG = luoibennhan.Rows[i].Cells["HienTrangMoi"].Value.ToString();
                    }
                    else
                        ctbg.HienTrangBG = "";

                    CTBGBL.Them(ctbg);                   
                }
                MessageBox.Show("Bàn giao thành công");
                DSSoTDoiNhan.Clear();
                xuat_luoibenNhan();
            }
            else {
                MessageBox.Show("Bạn chưa chọn thiết bị để bàn giao","Thông báo");
            }
        }

        private void luoibennhan_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            //switch (e.ColumnIndex)
            //{
            //    case 4:
            //        if (e.Value == null || e.Value == DBNull.Value)
            //            return;
            //        e.Value = "";
            //        break;
            //}
        }       
    }
}
