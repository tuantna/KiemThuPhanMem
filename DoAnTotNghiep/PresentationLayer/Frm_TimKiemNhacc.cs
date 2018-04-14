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
    public partial class Frm_TimKiemNhacc : Office2007RibbonForm
    {
        public Frm_TimKiemNhacc()
        {
            InitializeComponent();
        }
        BLNhaCC NhaccBL = new BLNhaCC();
        IList<NHACUNGCAP> DSSNhaCC = new List<NHACUNGCAP>();
        void xuat_luoiTB()
        {
            luoinhacc.AutoGenerateColumns = false;
            luoinhacc.DataSource = null;
            luoinhacc.DataSource = DSSNhaCC;
        }

        private void txtten_TextChanged(object sender, EventArgs e)
        {
            string dk = txtten.Text;
            DSSNhaCC = NhaccBL.DocNhaCCTheodieukien(dk);
            if (DSSNhaCC.Count > 0)
            {
                xuat_luoiTB();
            }
            else
            {
                luoinhacc.DataSource = null;
            }
        }
    }
}
