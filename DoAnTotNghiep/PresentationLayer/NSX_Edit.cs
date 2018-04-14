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
    public partial class NSX_Edit : Office2007Form
    {
        public NSX_Edit()
        {
            InitializeComponent();
        }
        BLNuocSX NSXBL = new BLNuocSX();
        IList<NUOCSX> DsNSX = new List<NUOCSX>();
        public NUOCSX nsx = null;      
        void Nhap_NSX()
        {
            if (nsx == null) nsx = new NUOCSX();
            nsx.TenNuoc = txtnsx.Text;
        }
        public void xuat_NSX_moi()
        {
            txtnsx.Text = "";
            txtnsx.Select();
            this.Text = "Thêm Xuất Xứ";
        }
        public void xuat_NSX_edit()
        {
            txtnsx.Text = nsx.TenNuoc;
            txtnsx.Select();
            this.Text = "Cập nhật Xuất Xứ";

        }

        private void NSX_Edit_Load(object sender, EventArgs e)
        {

            if (nsx == null)
            {
                xuat_NSX_moi();

            }
            else
            {
                xuat_NSX_edit();
            }
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            try
            {
                if (nsx == null)
                {
                    if (btnluu.Text == "Lưu")
                    {
                        Nhap_NSX();
                        NSXBL.Them(nsx);
                        MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnluu.Text = "Thêm Mới";

                    }
                    else
                    {
                        xuat_NSX_moi();
                        btnluu.Text = "Lưu";
                    }
                    nsx = null;
                }
                else
                {
                    Nhap_NSX();
                    DsNSX = NSXBL.CapNhat(nsx);
                    this.Close();
                }
            }
            catch (CapNhatNhaCCException ex)
            {
                MessageBox.Show(ex.Mess);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi trong quá trình cập nhật dữ liệu: Lỗi:" + ex.Message);
            }
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
