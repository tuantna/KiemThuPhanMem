namespace DoAnTotNghiep.PresentationLayer
{
    partial class Frm_NhapTBPQuyen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_NhapTBPQuyen));
            this.datangay = new System.Windows.Forms.DateTimePicker();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.cbonguoinhan = new System.Windows.Forms.ComboBox();
            this.cbophongban = new System.Windows.Forms.ComboBox();
            this.cbodonvi = new System.Windows.Forms.ComboBox();
            this.labelX8 = new DevComponents.DotNetBar.LabelX();
            this.labelX7 = new DevComponents.DotNetBar.LabelX();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.cbotenncc = new System.Windows.Forms.ComboBox();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.txtnguoilh = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.txtdiachincc = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.luoichitiet = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txttongtien = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.buttonX4 = new DevComponents.DotNetBar.ButtonX();
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.buttonX2 = new DevComponents.DotNetBar.ButtonX();
            ((System.ComponentModel.ISupportInitialize)(this.luoichitiet)).BeginInit();
            this.SuspendLayout();
            // 
            // datangay
            // 
            this.datangay.CustomFormat = "dd/MM/yyyy";
            this.datangay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datangay.Location = new System.Drawing.Point(470, 28);
            this.datangay.Name = "datangay";
            this.datangay.Size = new System.Drawing.Size(235, 22);
            this.datangay.TabIndex = 18;
            // 
            // labelX1
            // 
            this.labelX1.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.Class = "";
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(336, 24);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(128, 29);
            this.labelX1.TabIndex = 17;
            this.labelX1.Text = "Ngày nhập thiết bị:";
            // 
            // cbonguoinhan
            // 
            this.cbonguoinhan.BackColor = System.Drawing.Color.White;
            this.cbonguoinhan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbonguoinhan.FormattingEnabled = true;
            this.cbonguoinhan.Location = new System.Drawing.Point(151, 138);
            this.cbonguoinhan.Name = "cbonguoinhan";
            this.cbonguoinhan.Size = new System.Drawing.Size(293, 22);
            this.cbonguoinhan.TabIndex = 23;
            // 
            // cbophongban
            // 
            this.cbophongban.FormattingEnabled = true;
            this.cbophongban.Location = new System.Drawing.Point(152, 106);
            this.cbophongban.Name = "cbophongban";
            this.cbophongban.Size = new System.Drawing.Size(292, 22);
            this.cbophongban.TabIndex = 24;
            // 
            // cbodonvi
            // 
            this.cbodonvi.FormattingEnabled = true;
            this.cbodonvi.Location = new System.Drawing.Point(151, 73);
            this.cbodonvi.Name = "cbodonvi";
            this.cbodonvi.Size = new System.Drawing.Size(293, 22);
            this.cbodonvi.TabIndex = 22;
            this.cbodonvi.SelectedIndexChanged += new System.EventHandler(this.cbodonvi_SelectedIndexChanged);
            // 
            // labelX8
            // 
            this.labelX8.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX8.BackgroundStyle.Class = "";
            this.labelX8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX8.Location = new System.Drawing.Point(47, 138);
            this.labelX8.Name = "labelX8";
            this.labelX8.Size = new System.Drawing.Size(93, 27);
            this.labelX8.TabIndex = 19;
            this.labelX8.Text = "Mã nhân viên";
            // 
            // labelX7
            // 
            this.labelX7.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX7.BackgroundStyle.Class = "";
            this.labelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX7.Location = new System.Drawing.Point(48, 105);
            this.labelX7.Name = "labelX7";
            this.labelX7.Size = new System.Drawing.Size(95, 27);
            this.labelX7.TabIndex = 20;
            this.labelX7.Text = "Bộ phận nhận :";
            // 
            // labelX6
            // 
            this.labelX6.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX6.BackgroundStyle.Class = "";
            this.labelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX6.Location = new System.Drawing.Point(47, 69);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(110, 27);
            this.labelX6.TabIndex = 21;
            this.labelX6.Text = "Khoa nhận:";
            // 
            // cbotenncc
            // 
            this.cbotenncc.FormattingEnabled = true;
            this.cbotenncc.Location = new System.Drawing.Point(627, 72);
            this.cbotenncc.Name = "cbotenncc";
            this.cbotenncc.Size = new System.Drawing.Size(223, 22);
            this.cbotenncc.TabIndex = 30;
            this.cbotenncc.SelectedIndexChanged += new System.EventHandler(this.cbotenncc_SelectedIndexChanged);
            // 
            // labelX2
            // 
            this.labelX2.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.Class = "";
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(511, 73);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(110, 27);
            this.labelX2.TabIndex = 28;
            this.labelX2.Text = "Tên công ty:";
            // 
            // labelX4
            // 
            this.labelX4.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.Class = "";
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Location = new System.Drawing.Point(511, 136);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(95, 27);
            this.labelX4.TabIndex = 29;
            this.labelX4.Text = "Địa chỉ công ty:";
            // 
            // txtnguoilh
            // 
            this.txtnguoilh.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtnguoilh.Border.Class = "TextBoxBorder";
            this.txtnguoilh.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtnguoilh.Enabled = false;
            this.txtnguoilh.Location = new System.Drawing.Point(627, 109);
            this.txtnguoilh.Name = "txtnguoilh";
            this.txtnguoilh.Size = new System.Drawing.Size(275, 22);
            this.txtnguoilh.TabIndex = 32;
            // 
            // labelX3
            // 
            this.labelX3.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.Class = "";
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(511, 103);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(110, 27);
            this.labelX3.TabIndex = 27;
            this.labelX3.Text = "Đại điện công ty:";
            // 
            // txtdiachincc
            // 
            this.txtdiachincc.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtdiachincc.Border.Class = "TextBoxBorder";
            this.txtdiachincc.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtdiachincc.Enabled = false;
            this.txtdiachincc.Location = new System.Drawing.Point(629, 142);
            this.txtdiachincc.Name = "txtdiachincc";
            this.txtdiachincc.Size = new System.Drawing.Size(276, 22);
            this.txtdiachincc.TabIndex = 31;
            // 
            // luoichitiet
            // 
            this.luoichitiet.AllowUserToAddRows = false;
            this.luoichitiet.AllowUserToDeleteRows = false;
            this.luoichitiet.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.luoichitiet.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(217)))), ((int)(((byte)(247)))));
            this.luoichitiet.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.luoichitiet.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.luoichitiet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.luoichitiet.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column7,
            this.Column4,
            this.Column5,
            this.Column6});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.luoichitiet.DefaultCellStyle = dataGridViewCellStyle2;
            this.luoichitiet.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.luoichitiet.Location = new System.Drawing.Point(57, 270);
            this.luoichitiet.Name = "luoichitiet";
            this.luoichitiet.ReadOnly = true;
            this.luoichitiet.Size = new System.Drawing.Size(868, 202);
            this.luoichitiet.TabIndex = 35;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "PhieuNhapID";
            this.Column1.HeaderText = "PhieuNhapID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "MaThietBi";
            this.Column2.HeaderText = "Mã thiết bị";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "TenTB";
            this.Column3.HeaderText = "Tên thiết bị";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "TenDVT";
            this.Column7.HeaderText = "Đơn vị tính";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "SoLuongNhap";
            this.Column4.HeaderText = "Số lượng";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "dongia";
            this.Column5.HeaderText = "Đơn giá";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "ThietBiID";
            this.Column6.HeaderText = "Thiết bịID";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Visible = false;
            // 
            // txttongtien
            // 
            // 
            // 
            // 
            this.txttongtien.Border.Class = "TextBoxBorder";
            this.txttongtien.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txttongtien.Location = new System.Drawing.Point(775, 478);
            this.txttongtien.Name = "txttongtien";
            this.txttongtien.Size = new System.Drawing.Size(150, 22);
            this.txttongtien.TabIndex = 36;
            // 
            // buttonX4
            // 
            this.buttonX4.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX4.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonX4.Image = global::DoAnTotNghiep.Properties.Resources.label_blue_new;
            this.buttonX4.ImageFixedSize = new System.Drawing.Size(40, 40);
            this.buttonX4.Location = new System.Drawing.Point(485, 188);
            this.buttonX4.Name = "buttonX4";
            this.buttonX4.Size = new System.Drawing.Size(156, 57);
            this.buttonX4.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX4.TabIndex = 37;
            this.buttonX4.Text = "Thêm nới";
            this.buttonX4.Click += new System.EventHandler(this.buttonX4_Click);
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonX1.Image = global::DoAnTotNghiep.Properties.Resources.add;
            this.buttonX1.ImageFixedSize = new System.Drawing.Size(40, 40);
            this.buttonX1.Location = new System.Drawing.Point(305, 186);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Size = new System.Drawing.Size(159, 60);
            this.buttonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX1.TabIndex = 34;
            this.buttonX1.Text = "Chọn thiết bị";
            this.buttonX1.Click += new System.EventHandler(this.buttonX1_Click);
            // 
            // buttonX2
            // 
            this.buttonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX2.Image = ((System.Drawing.Image)(resources.GetObject("buttonX2.Image")));
            this.buttonX2.Location = new System.Drawing.Point(870, 71);
            this.buttonX2.Name = "buttonX2";
            this.buttonX2.Size = new System.Drawing.Size(32, 24);
            this.buttonX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX2.TabIndex = 33;
            this.buttonX2.Click += new System.EventHandler(this.buttonX2_Click);
            // 
            // Frm_NhapTBPQuyen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 532);
            this.Controls.Add(this.buttonX4);
            this.Controls.Add(this.txttongtien);
            this.Controls.Add(this.luoichitiet);
            this.Controls.Add(this.buttonX1);
            this.Controls.Add(this.buttonX2);
            this.Controls.Add(this.cbotenncc);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.labelX4);
            this.Controls.Add(this.txtnguoilh);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.txtdiachincc);
            this.Controls.Add(this.cbonguoinhan);
            this.Controls.Add(this.cbophongban);
            this.Controls.Add(this.cbodonvi);
            this.Controls.Add(this.labelX8);
            this.Controls.Add(this.labelX7);
            this.Controls.Add(this.labelX6);
            this.Controls.Add(this.datangay);
            this.Controls.Add(this.labelX1);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Frm_NhapTBPQuyen";
            this.Text = "Frm_NhapTBPQuyen";
            this.Load += new System.EventHandler(this.Frm_NhapTBPQuyen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.luoichitiet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker datangay;
        private DevComponents.DotNetBar.LabelX labelX1;
        private System.Windows.Forms.ComboBox cbonguoinhan;
        private System.Windows.Forms.ComboBox cbophongban;
        private System.Windows.Forms.ComboBox cbodonvi;
        private DevComponents.DotNetBar.LabelX labelX8;
        private DevComponents.DotNetBar.LabelX labelX7;
        private DevComponents.DotNetBar.LabelX labelX6;
        private System.Windows.Forms.ComboBox cbotenncc;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.Controls.TextBoxX txtnguoilh;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.Controls.TextBoxX txtdiachincc;
        private DevComponents.DotNetBar.ButtonX buttonX2;
        private DevComponents.DotNetBar.ButtonX buttonX1;
        private DevComponents.DotNetBar.Controls.DataGridViewX luoichitiet;
        private DevComponents.DotNetBar.Controls.TextBoxX txttongtien;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private DevComponents.DotNetBar.ButtonX buttonX4;
    }
}