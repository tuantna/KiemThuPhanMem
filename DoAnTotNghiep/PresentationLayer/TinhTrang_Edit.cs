using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using DoAnTotNghiep.BusinessLayer;
using DoAnTotNghiep.DataAcessLayer;

namespace DoAnTotNghiep.PresentationLayer
{
    public partial class TinhTrang_Edit : Office2007Form
    {
        public TinhTrang_Edit()
        {
            InitializeComponent();
        }
        BLTinhTrang TinhTrangBL = new BLTinhTrang();
        IList<TINHTRANG> DSTinhTrang = new List<TINHTRANG>();
        public TINHTRANG cv = null;
        void Nhap_ChucVu()
        {
            if (cv == null) cv = new TINHTRANG();
            cv.TenTinhTrang = txttinhtrang.Text;
            cv.TrangThai = txtdiengiai.Text;
        }
        public void xuat_ChucVu_moi()
        {
            txttinhtrang.Text = "";
            txtdiengiai.Text = "";
            txttinhtrang.Select();
            this.Text = "Thêm chức vụ";
        }
        public void xuat_ChucVu_edit()
        {
            txttinhtrang.Text = cv.TenTinhTrang;
            txtdiengiai.Text = cv.TrangThai;
            txttinhtrang.Select();
            this.Text = "Cập nhật chức vụ";
        }

        private void TinhTrang_Edit_Load(object sender, EventArgs e)
        {
            if (cv == null)
            {
                xuat_ChucVu_moi();

            }
            else
            {
                xuat_ChucVu_edit();
            }
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            try
            {
                if (cv == null)
                {
                    if (btnluu.Text == "Lưu")
                    {
                        Nhap_ChucVu();
                        TinhTrangBL.Them(cv);
                        btnluu.Text = "Thêm Mới";
                        MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);                        

                    }
                    else
                    {
                        xuat_ChucVu_moi();
                        btnluu.Text = "Lưu";
                    }
                    cv = null;
                }
                else
                {
                    Nhap_ChucVu();
                    DSTinhTrang = TinhTrangBL.CapNhat(cv);
                    this.Close();
                }
            }
            catch (CapNhatTinhTrangException ex)
            {
                MessageBox.Show(ex.Mess);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi trong quá trình cập nhật dữ liệu: Lỗi:" + ex.Message);
            }
        }
    }
}
