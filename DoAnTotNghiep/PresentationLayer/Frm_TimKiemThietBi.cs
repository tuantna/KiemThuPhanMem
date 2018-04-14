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
    public partial class Frm_TimKiemThietBi : Office2007RibbonForm
    {
        public Frm_TimKiemThietBi()
        {
            InitializeComponent();
        }
        BLThietBi ThietBiBL = new BLThietBi();
        IList<object> DSThietBi = new List<object>();
        void xuat_luoiTB()
        {
            luoithietbi.AutoGenerateColumns = false;
            luoithietbi.DataSource = null;
            luoithietbi.DataSource = DSThietBi;
        }
        private void Frm_TimKiemThietBi_Load(object sender, EventArgs e)
        {
            //DSThietBi = ThietBiBL.DocLoaiTBheodieukien(txtten.Text);
        }

        private void txtten_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Enter)
            //{
            //    string dk = txtten.Text;
            //    DSThietBi = ThietBiBL.TimKiemThietBi(dk);
            //    if (DSThietBi.Count > 0)
            //    {
            //        xuat_luoiTB();
            //    }
            //    else
            //    {
            //        luoithietbi.DataSource = null;
            //    }
            //}
        }

        private void txtten_TextChanged(object sender, EventArgs e)
        {
           // if (e. == Keys.Enter)
            //{
                string dk = txtten.Text;
                DSThietBi = ThietBiBL.TimKiemThietBi(dk);
                if (DSThietBi.Count > 0)
                {
                    xuat_luoiTB();
                }
                else
                {
                    luoithietbi.DataSource = null;
                }
           // }
        }

    }
}
