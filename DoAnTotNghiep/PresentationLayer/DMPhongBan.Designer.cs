namespace DoAnTotNghiep.PresentationLayer
{
    partial class DMPhongBan
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
            this.bar1 = new DevComponents.DotNetBar.Bar();
            this.txtten = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.cbodonvi = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.buttonItem1 = new DevComponents.DotNetBar.ButtonItem();
            this.labelItem5 = new DevComponents.DotNetBar.LabelItem();
            this.buttonItem2 = new DevComponents.DotNetBar.ButtonItem();
            this.labelItem6 = new DevComponents.DotNetBar.LabelItem();
            this.buttonItem3 = new DevComponents.DotNetBar.ButtonItem();
            this.labelItem7 = new DevComponents.DotNetBar.LabelItem();
            this.buttonItem4 = new DevComponents.DotNetBar.ButtonItem();
            this.labelItem8 = new DevComponents.DotNetBar.LabelItem();
            this.labelItem9 = new DevComponents.DotNetBar.LabelItem();
            this.controlContainerItem1 = new DevComponents.DotNetBar.ControlContainerItem();
            this.labelItem10 = new DevComponents.DotNetBar.LabelItem();
            this.controlContainerItem2 = new DevComponents.DotNetBar.ControlContainerItem();
            this.luoiphongban = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bar3 = new DevComponents.DotNetBar.Bar();
            this.txttongso = new DevComponents.DotNetBar.TextBoxItem();
            ((System.ComponentModel.ISupportInitialize)(this.bar1)).BeginInit();
            this.bar1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.luoiphongban)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bar3)).BeginInit();
            this.SuspendLayout();
            // 
            // bar1
            // 
            this.bar1.AccessibleDescription = "DotNetBar Bar (bar1)";
            this.bar1.AccessibleName = "DotNetBar Bar";
            this.bar1.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.bar1.Controls.Add(this.txtten);
            this.bar1.Controls.Add(this.cbodonvi);
            this.bar1.Controls.Add(this.labelX1);
            this.bar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bar1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.buttonItem1,
            this.labelItem5,
            this.buttonItem2,
            this.labelItem6,
            this.buttonItem3,
            this.labelItem7,
            this.buttonItem4,
            this.labelItem8,
            this.labelItem9,
            this.controlContainerItem1,
            this.labelItem10,
            this.controlContainerItem2});
            this.bar1.Location = new System.Drawing.Point(5, 1);
            this.bar1.MenuBar = true;
            this.bar1.Name = "bar1";
            this.bar1.Size = new System.Drawing.Size(859, 33);
            this.bar1.Stretch = true;
            this.bar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003;
            this.bar1.TabIndex = 1;
            this.bar1.TabStop = false;
            this.bar1.Text = "bar1";
            // 
            // txtten
            // 
            // 
            // 
            // 
            this.txtten.Border.Class = "TextBoxBorder";
            this.txtten.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtten.Location = new System.Drawing.Point(634, 6);
            this.txtten.Name = "txtten";
            this.txtten.Size = new System.Drawing.Size(168, 21);
            this.txtten.TabIndex = 1;
            this.txtten.WatermarkText = "Nhập thiết bị cần tra cứu";
            // 
            // cbodonvi
            // 
            this.cbodonvi.DisplayMember = "Text";
            this.cbodonvi.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbodonvi.FormattingEnabled = true;
            this.cbodonvi.ItemHeight = 15;
            this.cbodonvi.Location = new System.Drawing.Point(396, 6);
            this.cbodonvi.Name = "cbodonvi";
            this.cbodonvi.Size = new System.Drawing.Size(168, 21);
            this.cbodonvi.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbodonvi.TabIndex = 2;
            this.cbodonvi.SelectedIndexChanged += new System.EventHandler(this.cbodonvi_SelectedIndexChanged);
            // 
            // labelX1
            // 
            this.labelX1.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.Class = "";
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX1.Location = new System.Drawing.Point(576, 4);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(77, 25);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "Tra cứu:";
            // 
            // buttonItem1
            // 
            this.buttonItem1.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItem1.Image = global::DoAnTotNghiep.Properties.Resources.refresh_icon1;
            this.buttonItem1.ImageFixedSize = new System.Drawing.Size(25, 25);
            this.buttonItem1.Name = "buttonItem1";
            this.buttonItem1.Text = "Làm tươi";
            // 
            // labelItem5
            // 
            this.labelItem5.BorderSide = DevComponents.DotNetBar.eBorderSide.Left;
            this.labelItem5.BorderType = DevComponents.DotNetBar.eBorderType.Raised;
            this.labelItem5.Name = "labelItem5";
            this.labelItem5.PaddingLeft = 2;
            // 
            // buttonItem2
            // 
            this.buttonItem2.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItem2.Image = global::DoAnTotNghiep.Properties.Resources.add;
            this.buttonItem2.Name = "buttonItem2";
            this.buttonItem2.Text = "Thêm mới";
            this.buttonItem2.Click += new System.EventHandler(this.buttonItem2_Click);
            // 
            // labelItem6
            // 
            this.labelItem6.BorderSide = DevComponents.DotNetBar.eBorderSide.Left;
            this.labelItem6.BorderType = DevComponents.DotNetBar.eBorderType.Raised;
            this.labelItem6.Name = "labelItem6";
            this.labelItem6.PaddingLeft = 2;
            // 
            // buttonItem3
            // 
            this.buttonItem3.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItem3.Image = global::DoAnTotNghiep.Properties.Resources.pen_write_edit;
            this.buttonItem3.ImageFixedSize = new System.Drawing.Size(25, 25);
            this.buttonItem3.Name = "buttonItem3";
            this.buttonItem3.Text = "Hiệu chỉnh";
            this.buttonItem3.Click += new System.EventHandler(this.buttonItem3_Click);
            // 
            // labelItem7
            // 
            this.labelItem7.BorderSide = DevComponents.DotNetBar.eBorderSide.Left;
            this.labelItem7.BorderType = DevComponents.DotNetBar.eBorderType.Raised;
            this.labelItem7.Name = "labelItem7";
            this.labelItem7.PaddingLeft = 2;
            // 
            // buttonItem4
            // 
            this.buttonItem4.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItem4.Image = global::DoAnTotNghiep.Properties.Resources.delete11;
            this.buttonItem4.ImageFixedSize = new System.Drawing.Size(25, 25);
            this.buttonItem4.Name = "buttonItem4";
            this.buttonItem4.Text = "Xóa";
            this.buttonItem4.Click += new System.EventHandler(this.buttonItem4_Click);
            // 
            // labelItem8
            // 
            this.labelItem8.BorderSide = DevComponents.DotNetBar.eBorderSide.Left;
            this.labelItem8.BorderType = DevComponents.DotNetBar.eBorderType.Raised;
            this.labelItem8.Name = "labelItem8";
            this.labelItem8.PaddingLeft = 2;
            // 
            // labelItem9
            // 
            this.labelItem9.Name = "labelItem9";
            this.labelItem9.Text = "Thuộc khoa:";
            // 
            // controlContainerItem1
            // 
            this.controlContainerItem1.AllowItemResize = false;
            this.controlContainerItem1.Control = this.cbodonvi;
            this.controlContainerItem1.MenuVisibility = DevComponents.DotNetBar.eMenuVisibility.VisibleAlways;
            this.controlContainerItem1.Name = "controlContainerItem1";
            // 
            // labelItem10
            // 
            this.labelItem10.BorderSide = DevComponents.DotNetBar.eBorderSide.Left;
            this.labelItem10.BorderType = DevComponents.DotNetBar.eBorderType.Raised;
            this.labelItem10.Name = "labelItem10";
            this.labelItem10.PaddingLeft = 2;
            // 
            // controlContainerItem2
            // 
            this.controlContainerItem2.AllowItemResize = false;
            this.controlContainerItem2.Control = this.labelX1;
            this.controlContainerItem2.MenuVisibility = DevComponents.DotNetBar.eMenuVisibility.VisibleAlways;
            this.controlContainerItem2.Name = "controlContainerItem2";
            // 
            // luoiphongban
            // 
            this.luoiphongban.AllowUserToAddRows = false;
            this.luoiphongban.AllowUserToDeleteRows = false;
            this.luoiphongban.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.luoiphongban.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(217)))), ((int)(((byte)(247)))));
            this.luoiphongban.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.luoiphongban.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.luoiphongban.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.luoiphongban.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Column4,
            this.Column5,
            this.Column6});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.luoiphongban.DefaultCellStyle = dataGridViewCellStyle2;
            this.luoiphongban.Dock = System.Windows.Forms.DockStyle.Top;
            this.luoiphongban.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.luoiphongban.Location = new System.Drawing.Point(5, 34);
            this.luoiphongban.Name = "luoiphongban";
            this.luoiphongban.ReadOnly = true;
            this.luoiphongban.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.luoiphongban.Size = new System.Drawing.Size(859, 290);
            this.luoiphongban.TabIndex = 2;
            this.luoiphongban.Click += new System.EventHandler(this.luoiphongban_Click);
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "PhongBanID";
            this.Column2.HeaderText = "Phòng Ban ID";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "TenPhongBan";
            this.Column4.HeaderText = "Tên phòng ban";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "DonViID";
            this.Column5.HeaderText = "Khoa";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Visible = false;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "DienGiaiPB";
            this.Column6.HeaderText = "Diễn giải";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // bar3
            // 
            this.bar3.AntiAlias = true;
            this.bar3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bar3.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.txttongso});
            this.bar3.Location = new System.Drawing.Point(5, 330);
            this.bar3.Name = "bar3";
            this.bar3.Size = new System.Drawing.Size(859, 24);
            this.bar3.Stretch = true;
            this.bar3.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.bar3.TabIndex = 18;
            this.bar3.TabStop = false;
            this.bar3.Text = "bar3";
            // 
            // txttongso
            // 
            this.txttongso.ItemAlignment = DevComponents.DotNetBar.eItemAlignment.Far;
            this.txttongso.Name = "txttongso";
            this.txttongso.TextBoxWidth = 120;
            this.txttongso.WatermarkColor = System.Drawing.SystemColors.GrayText;
            // 
            // DMPhongBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 356);
            this.Controls.Add(this.bar3);
            this.Controls.Add(this.luoiphongban);
            this.Controls.Add(this.bar1);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Name = "DMPhongBan";
            this.Text = "DMPhongBan";
            this.Load += new System.EventHandler(this.DMPhongBan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bar1)).EndInit();
            this.bar1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.luoiphongban)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bar3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Bar bar1;
        private DevComponents.DotNetBar.Controls.TextBoxX txtten;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbodonvi;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.ButtonItem buttonItem1;
        private DevComponents.DotNetBar.LabelItem labelItem5;
        private DevComponents.DotNetBar.ButtonItem buttonItem2;
        private DevComponents.DotNetBar.LabelItem labelItem6;
        private DevComponents.DotNetBar.ButtonItem buttonItem3;
        private DevComponents.DotNetBar.LabelItem labelItem7;
        private DevComponents.DotNetBar.ButtonItem buttonItem4;
        private DevComponents.DotNetBar.LabelItem labelItem8;
        private DevComponents.DotNetBar.LabelItem labelItem9;
        private DevComponents.DotNetBar.ControlContainerItem controlContainerItem1;
        private DevComponents.DotNetBar.LabelItem labelItem10;
        private DevComponents.DotNetBar.ControlContainerItem controlContainerItem2;
        private DevComponents.DotNetBar.Controls.DataGridViewX luoiphongban;
        private DevComponents.DotNetBar.Bar bar3;
        private DevComponents.DotNetBar.TextBoxItem txttongso;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;

    }
}