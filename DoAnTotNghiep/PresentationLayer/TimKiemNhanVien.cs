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
    public partial class TimKiemNhanVien : Office2007Form
    {
        public TimKiemNhanVien()
        {
            InitializeComponent();
        }
        int vitri = 0;

        BLDonVi DonViBL = new BLDonVi();
        IList<DONVI> DSDonVi = new List<DONVI>();

        BLNhanVien NhanVienBL = new BLNhanVien();
        IList<object> DSNhanVien = new List<object>();


        private void TimKiemNhanVien_Load(object sender, EventArgs e)
        {
            DSDonVi = DonViBL.DocDonVi();
            cbodonvi.DisplayMember = "TenDonVi";
            cbodonvi.ValueMember = "DonViID";
            cbodonvi.DataSource = DSDonVi;
        }

        private void cbodonvi_SelectedIndexChanged(object sender, EventArgs e)
        {
            DSNhanVien = NhanVienBL.DocNhanVienTheoDonVi((int)cbodonvi.SelectedValue);
            luoinhanvien.AutoGenerateColumns = false;
            luoinhanvien.DataSource = DSNhanVien;
        }

        public delegate void TruyenLaiDuLieu(string MaNV, int manvid,string honv,string tennv);
        public TruyenLaiDuLieu truyendulieu;
        private void btnchon_Click(object sender, EventArgs e)
        {
            if (truyendulieu != null)
            {
                string manvien = luoinhanvien.Rows[vitri].Cells[1].Value.ToString();
                int manvienID=int.Parse(luoinhanvien.Rows[vitri].Cells[0].Value.ToString());
                string honhanv = luoinhanvien.Rows[vitri].Cells[2].Value.ToString();
                string tenhanv = luoinhanvien.Rows[vitri].Cells[3].Value.ToString();

                truyendulieu(manvien,manvienID,honhanv,tenhanv);
            }
            this.Close();
        }

        private void luoinhanvien_Click(object sender, EventArgs e)
        {
            vitri = luoinhanvien.CurrentCell.RowIndex;
        }

        private void btndong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
