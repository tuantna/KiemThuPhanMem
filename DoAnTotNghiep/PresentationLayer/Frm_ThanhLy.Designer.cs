namespace DoAnTotNghiep.PresentationLayer
{
    partial class Frm_ThanhLy
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.datangay = new System.Windows.Forms.DateTimePicker();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.cbodonvi = new System.Windows.Forms.ComboBox();
            this.cbophongban = new System.Windows.Forms.ComboBox();
            this.cbonhanvien = new System.Windows.Forms.ComboBox();
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.buttonX2 = new DevComponents.DotNetBar.ButtonX();
            this.buttonX3 = new DevComponents.DotNetBar.ButtonX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.txtghichuTL = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtbenmua = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.luoithanhly = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.chon = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ThietBiID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaThietBi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenTB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenTinhTrang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonX4 = new DevComponents.DotNetBar.ButtonX();
            ((System.ComponentModel.ISupportInitialize)(this.luoithanhly)).BeginInit();
            this.SuspendLayout();
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.Class = "";
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(364, 22);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(84, 28);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "Ngày thanh lý";
            // 
            // datangay
            // 
            this.datangay.CustomFormat = "dd/MM/yyyy";
            this.datangay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datangay.Location = new System.Drawing.Point(486, 25);
            this.datangay.Name = "datangay";
            this.datangay.Size = new System.Drawing.Size(159, 22);
            this.datangay.TabIndex = 1;
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.Class = "";
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(29, 71);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(84, 28);
            this.labelX2.TabIndex = 0;
            this.labelX2.Text = "Khoa thanh lý:";
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.Class = "";
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(29, 105);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(117, 28);
            this.labelX3.TabIndex = 0;
            this.labelX3.Text = "Phòng ban thanh lý:";
            // 
            // labelX4
            // 
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.Class = "";
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Location = new System.Drawing.Point(29, 139);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(117, 28);
            this.labelX4.TabIndex = 0;
            this.labelX4.Text = "Nhân viên thanh lý:";
            this.labelX4.Visible = false;
            // 
            // cbodonvi
            // 
            this.cbodonvi.FormattingEnabled = true;
            this.cbodonvi.Location = new System.Drawing.Point(165, 75);
            this.cbodonvi.Name = "cbodonvi";
            this.cbodonvi.Size = new System.Drawing.Size(226, 22);
            this.cbodonvi.TabIndex = 2;
            this.cbodonvi.SelectedIndexChanged += new System.EventHandler(this.cbodonvi_SelectedIndexChanged);
            // 
            // cbophongban
            // 
            this.cbophongban.FormattingEnabled = true;
            this.cbophongban.Location = new System.Drawing.Point(165, 109);
            this.cbophongban.Name = "cbophongban";
            this.cbophongban.Size = new System.Drawing.Size(226, 22);
            this.cbophongban.TabIndex = 2;
            this.cbophongban.SelectedIndexChanged += new System.EventHandler(this.cbophongban_SelectedIndexChanged);
            // 
            // cbonhanvien
            // 
            this.cbonhanvien.FormattingEnabled = true;
            this.cbonhanvien.Location = new System.Drawing.Point(165, 143);
            this.cbonhanvien.Name = "cbonhanvien";
            this.cbonhanvien.Size = new System.Drawing.Size(226, 22);
            this.cbonhanvien.TabIndex = 2;
            this.cbonhanvien.Visible = false;
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX1.Location = new System.Drawing.Point(407, 75);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Size = new System.Drawing.Size(31, 24);
            this.buttonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX1.TabIndex = 3;
            this.buttonX1.Text = "+";
            this.buttonX1.Click += new System.EventHandler(this.buttonX1_Click);
            // 
            // buttonX2
            // 
            this.buttonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX2.Location = new System.Drawing.Point(407, 109);
            this.buttonX2.Name = "buttonX2";
            this.buttonX2.Size = new System.Drawing.Size(31, 24);
            this.buttonX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX2.TabIndex = 3;
            this.buttonX2.Text = "+";
            this.buttonX2.Click += new System.EventHandler(this.buttonX2_Click);
            // 
            // buttonX3
            // 
            this.buttonX3.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX3.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX3.Location = new System.Drawing.Point(407, 143);
            this.buttonX3.Name = "buttonX3";
            this.buttonX3.Size = new System.Drawing.Size(31, 24);
            this.buttonX3.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX3.TabIndex = 3;
            this.buttonX3.Text = "+";
            this.buttonX3.Visible = false;
            this.buttonX3.Click += new System.EventHandler(this.buttonX3_Click);
            // 
            // labelX5
            // 
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.Class = "";
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Location = new System.Drawing.Point(458, 75);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(111, 28);
            this.labelX5.TabIndex = 0;
            this.labelX5.Text = "Đại diện bên mua:";
            // 
            // labelX6
            // 
            // 
            // 
            // 
            this.labelX6.BackgroundStyle.Class = "";
            this.labelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX6.Location = new System.Drawing.Point(458, 126);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(84, 28);
            this.labelX6.TabIndex = 0;
            this.labelX6.Text = "Ghi chú:";
            // 
            // txtghichuTL
            // 
            // 
            // 
            // 
            this.txtghichuTL.Border.Class = "TextBoxBorder";
            this.txtghichuTL.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtghichuTL.Location = new System.Drawing.Point(583, 117);
            this.txtghichuTL.Multiline = true;
            this.txtghichuTL.Name = "txtghichuTL";
            this.txtghichuTL.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtghichuTL.Size = new System.Drawing.Size(265, 53);
            this.txtghichuTL.TabIndex = 4;
            this.txtghichuTL.WatermarkFont = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtghichuTL.WatermarkText = "Ghi chú thanh lý";
            // 
            // txtbenmua
            // 
            // 
            // 
            // 
            this.txtbenmua.Border.Class = "TextBoxBorder";
            this.txtbenmua.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtbenmua.Location = new System.Drawing.Point(583, 80);
            this.txtbenmua.Name = "txtbenmua";
            this.txtbenmua.Size = new System.Drawing.Size(265, 22);
            this.txtbenmua.TabIndex = 5;
            this.txtbenmua.WatermarkFont = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbenmua.WatermarkText = "Đại diện bên mua";
            // 
            // luoithanhly
            // 
            this.luoithanhly.AllowUserToAddRows = false;
            this.luoithanhly.AllowUserToDeleteRows = false;
            this.luoithanhly.AllowUserToOrderColumns = true;
            this.luoithanhly.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.luoithanhly.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(217)))), ((int)(((byte)(247)))));
            this.luoithanhly.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.luoithanhly.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.luoithanhly.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.luoithanhly.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.chon,
            this.ThietBiID,
            this.MaThietBi,
            this.TenTB,
            this.TenTinhTrang,
            this.GiaBan});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.luoithanhly.DefaultCellStyle = dataGridViewCellStyle2;
            this.luoithanhly.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.luoithanhly.Location = new System.Drawing.Point(17, 197);
            this.luoithanhly.Name = "luoithanhly";
            this.luoithanhly.RowHeadersVisible = false;
            this.luoithanhly.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.luoithanhly.Size = new System.Drawing.Size(834, 238);
            this.luoithanhly.TabIndex = 6;
            // 
            // chon
            // 
            this.chon.HeaderText = "Chọn";
            this.chon.Name = "chon";
            // 
            // ThietBiID
            // 
            this.ThietBiID.DataPropertyName = "ThietBiID";
            this.ThietBiID.HeaderText = "ThietBiID";
            this.ThietBiID.Name = "ThietBiID";
            this.ThietBiID.Visible = false;
            // 
            // MaThietBi
            // 
            this.MaThietBi.DataPropertyName = "MaThietBi";
            this.MaThietBi.HeaderText = "Mã thiết bị";
            this.MaThietBi.Name = "MaThietBi";
            // 
            // TenTB
            // 
            this.TenTB.DataPropertyName = "TenTB";
            this.TenTB.HeaderText = "Tên thiết bị";
            this.TenTB.Name = "TenTB";
            // 
            // TenTinhTrang
            // 
            this.TenTinhTrang.DataPropertyName = "TenTinhTrang";
            this.TenTinhTrang.HeaderText = "Tình trạng";
            this.TenTinhTrang.Name = "TenTinhTrang";
            // 
            // GiaBan
            // 
            this.GiaBan.HeaderText = "Giá Bán";
            this.GiaBan.Name = "GiaBan";
            // 
            // buttonX4
            // 
            this.buttonX4.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX4.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonX4.Image = global::DoAnTotNghiep.Properties.Resources._4345aaa;
            this.buttonX4.ImageFixedSize = new System.Drawing.Size(35, 35);
            this.buttonX4.Location = new System.Drawing.Point(718, 441);
            this.buttonX4.Name = "buttonX4";
            this.buttonX4.Size = new System.Drawing.Size(130, 55);
            this.buttonX4.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX4.TabIndex = 7;
            this.buttonX4.Text = "Đồng ý";
            this.buttonX4.Click += new System.EventHandler(this.buttonX4_Click);
            // 
            // Frm_ThanhLy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 525);
            this.Controls.Add(this.buttonX4);
            this.Controls.Add(this.luoithanhly);
            this.Controls.Add(this.txtbenmua);
            this.Controls.Add(this.txtghichuTL);
            this.Controls.Add(this.buttonX3);
            this.Controls.Add(this.buttonX2);
            this.Controls.Add(this.buttonX1);
            this.Controls.Add(this.cbonhanvien);
            this.Controls.Add(this.cbophongban);
            this.Controls.Add(this.cbodonvi);
            this.Controls.Add(this.datangay);
            this.Controls.Add(this.labelX4);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.labelX6);
            this.Controls.Add(this.labelX5);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.labelX1);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Frm_ThanhLy";
            this.Text = "Frm_ThanhLy";
            this.Load += new System.EventHandler(this.Frm_ThanhLy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.luoithanhly)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.LabelX labelX1;
        private System.Windows.Forms.DateTimePicker datangay;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX4;
        private System.Windows.Forms.ComboBox cbodonvi;
        private System.Windows.Forms.ComboBox cbophongban;
        private System.Windows.Forms.ComboBox cbonhanvien;
        private DevComponents.DotNetBar.ButtonX buttonX1;
        private DevComponents.DotNetBar.ButtonX buttonX2;
        private DevComponents.DotNetBar.ButtonX buttonX3;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.DotNetBar.Controls.TextBoxX txtghichuTL;
        private DevComponents.DotNetBar.Controls.TextBoxX txtbenmua;
        private DevComponents.DotNetBar.Controls.DataGridViewX luoithanhly;
        private DevComponents.DotNetBar.ButtonX buttonX4;
        private System.Windows.Forms.DataGridViewCheckBoxColumn chon;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThietBiID;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaThietBi;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenTB;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenTinhTrang;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaBan;

    }
}