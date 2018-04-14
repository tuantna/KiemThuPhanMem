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

namespace DoAnTotNghiep.PresentationLayer
{
    public partial class Frm_DSThietBi :Office2007Form
    {
        bool mthemmoi;
        int mPNhapID;
        PHIEUPHAP mPn;
        int phongbanID;
        public Frm_DSThietBi(bool Capnhap, PHIEUPHAP pPn,int id)
        {
            InitializeComponent();
            mPn = pPn;
            mthemmoi = Capnhap;
            mPNhapID = mPn.PhieuNhapID;
            phongbanID = id;
        }
        public Frm_DSThietBi(bool Capnhap, PHIEUPHAP pPn)
        {
            InitializeComponent();
            mPn = pPn;
            mthemmoi = Capnhap;
            mPNhapID = mPn.PhieuNhapID;           
        }
        BLThietBi ThietBiBL= new BLThietBi();
        IList<object> DSThietBi = new List<object>();
        //BLLoaiTB LoaiTBBL= new BLLoaiTB();
        //IList<LOAITHIETBI> DSLoaiTB = new List<LOAITHIETBI>();

        
        //void xuat_LoaiTB()
        //{
        //    cboloaitb.DisplayMember = "TenLoaiTB";
        //    cboloaitb.ValueMember = "LoaiTBID";
        //    cboloaitb.DataSource = DSLoaiTB;
        //}
        //void xuat_luoiTB()
        //{
        //    luoidsTB.AutoGenerateColumns = false;
        //    luoidsTB.DataSource = null;
        //    //luoidsTB.cells
        //    luoidsTB.DataSource = DSThietBi;
        //}
        void xuat_luoi_VatTu()
        {

            if (mthemmoi) // Thêm vật tư
            {

                var q = from ct in PhamMem.db.CHITIETPNHAPs
                        where ct.PhieuNhapID ==mPNhapID
                        select new { ct.ThietBiID, ct.THIETBI.MaThietBi, ct.THIETBI.TenTB, ct.THIETBI.DVTINH.TenDVT };

                var query = (from vt in PhamMem.db.THIETBIs
                             join ct in q
                             on vt.ThietBiID equals ct.ThietBiID
                             into kq

                             from p in kq.DefaultIfEmpty()
                             where p == null
                             orderby p.TenTB
                             select new { vt.ThietBiID, vt.MaThietBi, vt.TenTB, vt.DVTINH.TenDVT });
                luoidsTB.DataSource = query;
                luoidsTB.Columns[4].HeaderText = "Số lượng đặt";

            }
            else // Sửa vật tư
            {
                var query = (from ct in PhamMem.db.CHITIETPNHAPs
                             where ct.PhieuNhapID == mPNhapID
                             select new { ct.ThietBiID,ct.THIETBI.MaThietBi, ct.THIETBI.TenTB,ct.THIETBI.DVTINH.TenDVT, ct.SoLuongNhap, ct.dongia }
                             );

                luoidsTB.Columns["SoLuongNhap"].HeaderText = "Số lượng mới";
                luoidsTB.Columns["dongia"].HeaderText = "Đơn giá mới";
                luoidsTB.DataSource = query;
                luoidsTB.Columns[6].HeaderText = "Số lượng nhập";
                luoidsTB.Columns[7].HeaderText = "Đơn giá nhập";
                luoidsTB.Columns[7].DefaultCellStyle.Format = "#,##0";
            }
                   

        }
        private void Frm_DSThietBi_Load(object sender, EventArgs e)
        {           
            xuat_luoi_VatTu();
            if (mthemmoi)
            {
                this.Text = "Thêm Vật tư";
            }
            else
            {
                this.Text = "Sửa Vật tư";
                //cboloaitb.Visible = false;
            }
        }
        private void btndong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public delegate void TruyenLaiDuLieu(int  id);
        public TruyenLaiDuLieu truyendulieu;
        //ArrayList mang = new ArrayList();
        private void btnchon_Click(object sender, EventArgs e)
        {
            try
            {

                BLCTPNhap CTPNhapBL = new BLCTPNhap();
               // string lenh = null;
                int SlOld = 0;
                for (int i = 0; i < luoidsTB.Rows.Count; i++)
                {
                    if (luoidsTB.Rows[i].Cells["SoLuongNhap"].Value != null && luoidsTB.Rows[i].Cells["dongia"].Value != null)
                    {
                        int vtuID = int.Parse(luoidsTB.Rows[i].Cells["ThietBiID"].Value.ToString());
                        int Sl = int.Parse(luoidsTB.Rows[i].Cells["SoLuongNhap"].Value.ToString());
                        int Dg = int.Parse(luoidsTB.Rows[i].Cells["dongia"].Value.ToString());

                        if (mthemmoi)
                        {
                            SlOld = 0;
                            CHITIETPNHAP ct = new CHITIETPNHAP();
                            ct.PhieuNhapID = mPNhapID;
                            ct.ThietBiID = vtuID;
                            ct.SoLuongNhap = Sl;
                            ct.dongia = Dg;
                            CTPNhapBL.Them(ct, SlOld);

                            BLSoTheoDoi STDBl = new BLSoTheoDoi();
                            SOTHEODOI STD = new SOTHEODOI();
                            STD.ThietBiID = vtuID;
                            STD.PhongBanID = phongbanID;
                            STD.TinhTrangID = 1;                           
                            STDBl.Them(STD);

                            //lenh = string.Format("Insert Into CTPNhap Values({0},{1},{2},{3})", mPNhapID, vtuID, Sl,Dg);
                        }
                        else
                        {
                            CHITIETPNHAP ct = CTPNhapBL.DocCTPNhapTheoID(mPNhapID, vtuID);

                            //SlOld=ct.SlNhap.Value;
                            SlOld = int.Parse(luoidsTB.Rows[0].Cells[6].Value.ToString());
                            //MessageBox.Show(SlOld.ToString());
                            ct.SoLuongNhap = Sl;
                            ct.dongia = Dg;
                            CTPNhapBL.CapNhat(ct, SlOld);
                            //lenh = string.Format("Update CTPNhap Set SlNhap={0}, DgNhap={1} Where PNhapID={2} and VattuID={3}", Sl,Dg,mPNhapID, vtuID);
                        }
                        //if (lenh != "") // Nếu cập nhật bằng câu lệnh SQL
                        //{
                        //    // CTPNhapBL.ThucHienLenhCapNhat(lenh);
                        //}
                      
                        
                    }
                }
            }
            catch (CapNhatCTPNException ex)
            {
                MessageBox.Show(ex.Mess);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi" + ex.Message);
            }


            this.Close();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            var frmthemmoi = new PresentationLayer.ThietBi_Edit();
            frmthemmoi.ShowDialog();
            Frm_DSThietBi_Load(sender, e);
        }

    }
}
