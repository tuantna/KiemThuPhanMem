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
    public partial class Frm_NhapThemTBPQ : Office2007Form
    {
        int mPNhapID;
        PHIEUPHAP mPn;
        int phongbanID;
        public Frm_NhapThemTBPQ(PHIEUPHAP pPn, int id)
        {
            InitializeComponent();
            mPn = pPn;
            mPNhapID = mPn.PhieuNhapID;
            phongbanID = id;
        }
        //}
        void xuat_luoi_VatTu()
        {
            var q = from ct in PhamMem.db.CHITIETPNHAPs
                    where ct.PhieuNhapID == mPNhapID
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

        private void Frm_NhapThemTBPQ_Load(object sender, EventArgs e)
        {
             xuat_luoi_VatTu();                

        }

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

        private void btndong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
