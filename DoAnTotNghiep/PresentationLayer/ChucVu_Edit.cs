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
    public partial class ChucVu_Edit : Office2007Form
    {
        public ChucVu_Edit()
        {
            InitializeComponent();
        }
        BLChucVu ChucVuBL = new BLChucVu();
        IList<CHUCVU> DsChucVu = new List<CHUCVU>();
        public CHUCVU cv = null;
        void Nhap_ChucVu()
        {
            if (cv == null) cv = new CHUCVU();
            cv.TenChucVU = txtchucvu.Text;           
            cv.DienGiaiCV = txtdiengiai.Text;
        }
        public void xuat_ChucVu_moi()
        {
            txtchucvu.Text = "";           
            txtdiengiai.Text = "";
            txtchucvu.Select();
            this.Text = "Thêm chức vụ";
        }
        public void xuat_ChucVu_edit()
        {
            txtchucvu.Text = cv.TenChucVU;           
            txtdiengiai.Text = cv.DienGiaiCV;
            txtchucvu.Select();
            this.Text = "Cập nhật chức vụ";

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
                        ChucVuBL.Them(cv);
                        MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnluu.Text = "Thêm Mới";

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
                    DsChucVu = ChucVuBL.CapNhat(cv);
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

        private void ChucVu_Edit_Load(object sender, EventArgs e)
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
    }
}
