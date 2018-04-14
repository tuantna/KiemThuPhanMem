namespace DoAnTotNghiep.PresentationLayer
{
    partial class Frm_InBaoCao
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
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.cbocluachon = new System.Windows.Forms.ComboBox();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbophongnban = new System.Windows.Forms.ComboBox();
            this.cbokhoa = new System.Windows.Forms.ComboBox();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.txtduongdan = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.radtaptin = new System.Windows.Forms.RadioButton();
            this.grouptaptin = new System.Windows.Forms.GroupBox();
            this.radslx = new System.Windows.Forms.RadioButton();
            this.raddoc = new System.Windows.Forms.RadioButton();
            this.radmayin = new System.Windows.Forms.RadioButton();
            this.radmanhinh = new System.Windows.Forms.RadioButton();
            this.btninbc = new DevComponents.DotNetBar.ButtonX();
            this.btnthoat = new DevComponents.DotNetBar.ButtonX();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.grouptaptin.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.Class = "";
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(30, 21);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(94, 28);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "Chọn báo cáo";
            // 
            // cbocluachon
            // 
            this.cbocluachon.FormattingEnabled = true;
            this.cbocluachon.Location = new System.Drawing.Point(141, 24);
            this.cbocluachon.Name = "cbocluachon";
            this.cbocluachon.Size = new System.Drawing.Size(219, 22);
            this.cbocluachon.TabIndex = 1;
            // 
            // labelX3
            // 
            this.labelX3.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.Class = "";
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(6, 21);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(104, 37);
            this.labelX3.TabIndex = 0;
            this.labelX3.Text = "Chọn khoa:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbophongnban);
            this.groupBox1.Controls.Add(this.cbokhoa);
            this.groupBox1.Controls.Add(this.labelX2);
            this.groupBox1.Controls.Add(this.labelX3);
            this.groupBox1.Location = new System.Drawing.Point(30, 75);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(330, 104);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lọc dữ liệu";
            // 
            // cbophongnban
            // 
            this.cbophongnban.FormattingEnabled = true;
            this.cbophongnban.Location = new System.Drawing.Point(118, 70);
            this.cbophongnban.Name = "cbophongnban";
            this.cbophongnban.Size = new System.Drawing.Size(188, 22);
            this.cbophongnban.TabIndex = 1;
            this.cbophongnban.SelectedIndexChanged += new System.EventHandler(this.cbophongnban_SelectedIndexChanged);
            // 
            // cbokhoa
            // 
            this.cbokhoa.FormattingEnabled = true;
            this.cbokhoa.Location = new System.Drawing.Point(119, 24);
            this.cbokhoa.Name = "cbokhoa";
            this.cbokhoa.Size = new System.Drawing.Size(188, 22);
            this.cbokhoa.TabIndex = 1;
            this.cbokhoa.SelectedIndexChanged += new System.EventHandler(this.cbokhoa_SelectedIndexChanged);
            // 
            // labelX2
            // 
            this.labelX2.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.Class = "";
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(6, 61);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(104, 37);
            this.labelX2.TabIndex = 0;
            this.labelX2.Text = "Chọn phòng ban:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonX1);
            this.groupBox2.Controls.Add(this.txtduongdan);
            this.groupBox2.Controls.Add(this.radtaptin);
            this.groupBox2.Controls.Add(this.grouptaptin);
            this.groupBox2.Controls.Add(this.radmayin);
            this.groupBox2.Controls.Add(this.radmanhinh);
            this.groupBox2.Location = new System.Drawing.Point(388, 24);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(322, 212);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hướng kết xuất";
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonX1.Location = new System.Drawing.Point(252, 164);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Size = new System.Drawing.Size(49, 32);
            this.buttonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX1.TabIndex = 3;
            this.buttonX1.Text = ". . .";
            this.buttonX1.Click += new System.EventHandler(this.buttonX1_Click);
            // 
            // txtduongdan
            // 
            // 
            // 
            // 
            this.txtduongdan.Border.Class = "TextBoxBorder";
            this.txtduongdan.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtduongdan.Location = new System.Drawing.Point(27, 170);
            this.txtduongdan.Name = "txtduongdan";
            this.txtduongdan.Size = new System.Drawing.Size(218, 22);
            this.txtduongdan.TabIndex = 2;
            // 
            // radtaptin
            // 
            this.radtaptin.AutoSize = true;
            this.radtaptin.Location = new System.Drawing.Point(27, 119);
            this.radtaptin.Name = "radtaptin";
            this.radtaptin.Size = new System.Drawing.Size(63, 18);
            this.radtaptin.TabIndex = 0;
            this.radtaptin.Text = "Tập tin";
            this.radtaptin.UseVisualStyleBackColor = true;
            this.radtaptin.CheckedChanged += new System.EventHandler(this.radtaptin_CheckedChanged);
            // 
            // grouptaptin
            // 
            this.grouptaptin.Controls.Add(this.radslx);
            this.grouptaptin.Controls.Add(this.raddoc);
            this.grouptaptin.Location = new System.Drawing.Point(108, 105);
            this.grouptaptin.Name = "grouptaptin";
            this.grouptaptin.Size = new System.Drawing.Size(159, 41);
            this.grouptaptin.TabIndex = 1;
            this.grouptaptin.TabStop = false;
            // 
            // radslx
            // 
            this.radslx.AutoSize = true;
            this.radslx.Location = new System.Drawing.Point(77, 17);
            this.radslx.Name = "radslx";
            this.radslx.Size = new System.Drawing.Size(45, 18);
            this.radslx.TabIndex = 1;
            this.radslx.TabStop = true;
            this.radslx.Text = "XLS";
            this.radslx.UseVisualStyleBackColor = true;
            // 
            // raddoc
            // 
            this.raddoc.AutoSize = true;
            this.raddoc.Location = new System.Drawing.Point(6, 17);
            this.raddoc.Name = "raddoc";
            this.raddoc.Size = new System.Drawing.Size(49, 18);
            this.raddoc.TabIndex = 0;
            this.raddoc.TabStop = true;
            this.raddoc.Text = "DOC";
            this.raddoc.UseVisualStyleBackColor = true;
            // 
            // radmayin
            // 
            this.radmayin.AutoSize = true;
            this.radmayin.Location = new System.Drawing.Point(27, 80);
            this.radmayin.Name = "radmayin";
            this.radmayin.Size = new System.Drawing.Size(60, 18);
            this.radmayin.TabIndex = 0;
            this.radmayin.Text = "Máy in";
            this.radmayin.UseVisualStyleBackColor = true;
            this.radmayin.CheckedChanged += new System.EventHandler(this.radmayin_CheckedChanged);
            // 
            // radmanhinh
            // 
            this.radmanhinh.AutoSize = true;
            this.radmanhinh.Checked = true;
            this.radmanhinh.Location = new System.Drawing.Point(27, 40);
            this.radmanhinh.Name = "radmanhinh";
            this.radmanhinh.Size = new System.Drawing.Size(75, 18);
            this.radmanhinh.TabIndex = 0;
            this.radmanhinh.TabStop = true;
            this.radmanhinh.Text = "Màn hình";
            this.radmanhinh.UseVisualStyleBackColor = true;
            this.radmanhinh.CheckedChanged += new System.EventHandler(this.radmanhinh_CheckedChanged);
            // 
            // btninbc
            // 
            this.btninbc.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btninbc.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btninbc.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btninbc.Image = global::DoAnTotNghiep.Properties.Resources.Printer_Text_icon;
            this.btninbc.ImageFixedSize = new System.Drawing.Size(50, 50);
            this.btninbc.Location = new System.Drawing.Point(65, 188);
            this.btninbc.Name = "btninbc";
            this.btninbc.Size = new System.Drawing.Size(138, 42);
            this.btninbc.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btninbc.TabIndex = 5;
            this.btninbc.Text = "In báo cáo";
            this.btninbc.Click += new System.EventHandler(this.btninbc_Click);
            // 
            // btnthoat
            // 
            this.btnthoat.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnthoat.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnthoat.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthoat.Image = global::DoAnTotNghiep.Properties.Resources.no;
            this.btnthoat.ImageFixedSize = new System.Drawing.Size(40, 40);
            this.btnthoat.Location = new System.Drawing.Point(219, 188);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(108, 42);
            this.btnthoat.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnthoat.TabIndex = 5;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // Frm_InBaoCao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 286);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.btninbc);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cbocluachon);
            this.Controls.Add(this.labelX1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_InBaoCao";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "In báo cáo";
            this.Load += new System.EventHandler(this.Frm_InBaoCao_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.grouptaptin.ResumeLayout(false);
            this.grouptaptin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.LabelX labelX1;
        private System.Windows.Forms.ComboBox cbocluachon;
        private DevComponents.DotNetBar.LabelX labelX3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbophongnban;
        private System.Windows.Forms.ComboBox cbokhoa;
        private DevComponents.DotNetBar.LabelX labelX2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radtaptin;
        private System.Windows.Forms.GroupBox grouptaptin;
        private System.Windows.Forms.RadioButton radmayin;
        private System.Windows.Forms.RadioButton radmanhinh;
        private System.Windows.Forms.RadioButton radslx;
        private System.Windows.Forms.RadioButton raddoc;
        private DevComponents.DotNetBar.ButtonX buttonX1;
        private DevComponents.DotNetBar.Controls.TextBoxX txtduongdan;
        private DevComponents.DotNetBar.ButtonX btninbc;
        private DevComponents.DotNetBar.ButtonX btnthoat;
    }
}