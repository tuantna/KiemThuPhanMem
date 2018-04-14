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
    public partial class Cap_Quyen : Office2007RibbonForm
    {
        public Cap_Quyen()
        {
            InitializeComponent();
        }
        BLNguoiDung NguoiDungBL = new BLNguoiDung();
        IList<NguoiDung> DsNguoiDung = new List<NguoiDung>();
        private void Cap_Quyen_Load(object sender, EventArgs e)
        {
            DsNguoiDung = NguoiDungBL.DocNguoiDung();

            luoicapquyen.AutoGenerateColumns = false;
            luoicapquyen.DataSource = DsNguoiDung;
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            PhamMem.db.SubmitChanges();
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
