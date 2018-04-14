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
    public partial class Frm_DanhGia_Edit : Office2007Form
    {
        int PhongBanID;
        BLTinhTrang TinhTrangBL = new BLTinhTrang();
        IList<TINHTRANG> DSTinhTrang = new List<TINHTRANG>();

        public Frm_DanhGia_Edit(int id)
        {
            InitializeComponent();
            PhongBanID = id;
        }
        void xuat_luoi_TB()
        {
            //Thêm column combobox chứa thông tin về nhà cung cấp
            DataGridViewComboBoxColumn dgrCC = new DataGridViewComboBoxColumn();
            dgrCC.HeaderText = "Tình trạng mới";
            dgrCC.AutoComplete = true;
            dgrCC.DataSource = DSTinhTrang;
            dgrCC.DisplayMember = "TenTinhTrang"; //Phần hiển thị là trường CompanyName
            dgrCC.ValueMember = "TinhTrangID"; //Phần giá trị là trường CompanyName (hoặc trường khác)           
            dgrCC.DataPropertyName = "TinhTrangID";
            dgrCC.Name = "TinhTrang";
            dgrCC.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            var query = (from ct in PhamMem.db.SOTHEODOIs
                         where ct.PhongBanID == PhongBanID
                         select new { ct.ThietBiID, ct.THIETBI.MaThietBi, ct.THIETBI.TenTB, ct.TINHTRANG.TenTinhTrang }
                         );
            // luoiTBKK.Columns["TenTinhTrang"].HeaderText = "Tình trạng mới";

           // luoiTBKK.Columns["HienTrang"].HeaderText = "Hiện trạng mới";

            //Thêm vào GridView
            luoiTBKK.Columns.Add(dgrCC);


            luoiTBKK.DataSource = query;
           // luoiTBKK.Columns[5].HeaderText = "Tình trạng";
            // luoiTBKK.Columns[6].HeaderText = "Hiện trạng";
            //luoiTBKK.Rows[0].Selected = true;
        }

        private void Frm_DanhGia_Edit_Load(object sender, EventArgs e)
        {
            DSTinhTrang = TinhTrangBL.DocTinhTrang();
            xuat_luoi_TB();
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            try
            {

                BLSoTheoDoi SOTDBL = new BLSoTheoDoi();
                for (int i = 0; i < luoiTBKK.Rows.Count; i++)
                {
                    string aa=luoiTBKK.Rows[i].Cells["TinhTrang"].Value.ToString();
                    if (aa != null)
                    {
                        int IDTB = int.Parse(luoiTBKK.Rows[i].Cells["ThietBiID"].Value.ToString());
                        int TR = (int)luoiTBKK.Rows[i].Cells["TinhTrang"].Value;
                        int idPB = PhongBanID;

                        SOTHEODOI std = SOTDBL.DocSOTHEODOITheoTB_PB(IDTB, idPB);
                        std.TinhTrangID = TR;
                        SOTDBL.CapNhat(std);

                    }                                        
                }
                MessageBox.Show("Cập nhật lại thành công");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bạn chưa chọn tình trạng mới" );
            }
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
