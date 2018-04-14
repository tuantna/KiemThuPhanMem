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
    public partial class Frm_DSThietBiKKe : Office2007Form
    {
        int PhongBanID;
        int KKeID;
        BLTinhTrang TinhTrangBL = new BLTinhTrang();
        IList<TINHTRANG> DSTinhTrang = new List<TINHTRANG>();
        BLPKiemKe PKeBL = new BLPKiemKe();
        public Frm_DSThietBiKKe(int id,int kkid)
        {
            InitializeComponent();
            PhongBanID = id;
            KKeID = kkid;
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

            luoiTBKK.Columns["HienTrang"].HeaderText = "Hiện trạng mới";

            //Thêm vào GridView
            luoiTBKK.Columns.Add(dgrCC);

            
            luoiTBKK.DataSource = query;
            luoiTBKK.Columns[5].HeaderText = "Tình trạng";
           // luoiTBKK.Columns[6].HeaderText = "Hiện trạng";
            //luoiTBKK.Rows[0].Selected = true;
        }
        private void Frm_DSThietBiKKe_Load(object sender, EventArgs e)
        {
            DSTinhTrang = TinhTrangBL.DocTinhTrang();
            xuat_luoi_TB();
        }       
        private void buttonX3_Click(object sender, EventArgs e)
        {           
          // string aa = luoiTBKK.Rows[0].Cells["TinhTrang"].Value.ToString();
          // MessageBox.Show(aa.ToString());
            try
            {

                BLPKiemKe CTPNhapBL = new BLPKiemKe();
                for (int i = 0; i < luoiTBKK.Rows.Count; i++)
                {
                    if (luoiTBKK.Rows[i].Cells["HienTrang"].Value != null && (int)luoiTBKK.Rows[0].Cells["TinhTrang"].Value > 0)
                    {
                        int TBID = int.Parse(luoiTBKK.Rows[i].Cells["ThietBiID"].Value.ToString());
                        string TR = luoiTBKK.Rows[0].Cells["TinhTrang"].EditedFormattedValue.ToString();
                        string htrang = luoiTBKK.Rows[i].Cells["HienTrang"].Value.ToString();

                        PHIEUKIEMKE ct = new PHIEUKIEMKE();
                        ct.KiemKeID = KKeID;
                        ct.ThietBiID = TBID;
                        ct.TinhTrangKK =TR;
                        ct.HienTrangKK = htrang;
                        PKeBL.Them(ct);
                    }
                }
                MessageBox.Show("Cập nhật phiếu kiểm kê thành công");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi :" + ex.Message);
            }
        }        
        private void luoiTBKK_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
           //int currentRow = e.RowIndex;
           //int currentCol = e.ColumnIndex;
            
           //// if (currentCol == 4)//chon ma lop
           //// {
           ////     DataGridViewTextBoxCell aa = (DataGridViewTextBoxCell)luoiTBKK.Rows[currentRow].Cells[currentCol];   
           ////     //DataGridViewComboBoxCell cellMaLop= (DataGridViewComboBoxCell)luoiTBKK.Rows[currentRow].Cells[currentCol];               
           ////     //Lay gia tri hien tại
           ////    // bb =(int)cellMaLop.Value;
           ////     chuoi = aa.Value.ToString();
           ////// }
           //// }
           //if (currentCol == 5)//chon ma lop
           //{
           //    DataGridViewComboBoxCell cellMaLop = (DataGridViewComboBoxCell)luoiTBKK.Rows[currentRow].Cells[currentCol];
           //    //Lay gia tri hien tại
           //    bb = (int)cellMaLop.Value;
           //}         
           // }
        }        
    }
}
