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
    public partial class Frm_TimKiemTB_PhongBan : Office2007RibbonForm
    {
        public Frm_TimKiemTB_PhongBan()
        {
            InitializeComponent();
        }
        BLSoTheoDoi STDBL = new BLSoTheoDoi();
        IList<object> DSSTDoi = new List<object>();
        void xuat_luoiTB()
        {
            luoithietbi.AutoGenerateColumns = false;
            luoithietbi.DataSource = null;
            luoithietbi.DataSource = DSSTDoi;
        }

        private void txtten_TextChanged(object sender, EventArgs e)
        {
            string dk = txtten.Text;
            DSSTDoi = STDBL.TimKiemThietBi(dk);
            if (DSSTDoi.Count > 0)
            {
                xuat_luoiTB();
            }
            else
            {
                luoithietbi.DataSource = null;
            }
        }

    }
}
