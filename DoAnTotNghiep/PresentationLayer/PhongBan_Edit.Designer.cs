namespace DoAnTotNghiep.PresentationLayer
{
    partial class PhongBan_Edit
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
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.cbodonvi = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.txttenphongban = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtdiengiai = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btnthem = new DevComponents.DotNetBar.ButtonX();
            this.btnluulai = new DevComponents.DotNetBar.ButtonX();
            this.btndong = new DevComponents.DotNetBar.ButtonX();
            this.SuspendLayout();
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.Class = "";
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelX1.Location = new System.Drawing.Point(10, 20);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(108, 25);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "Đơn vị";
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.Class = "";
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelX2.Location = new System.Drawing.Point(9, 56);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(108, 25);
            this.labelX2.TabIndex = 1;
            this.labelX2.Text = "Tên phòng ban";
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.Class = "";
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelX3.Location = new System.Drawing.Point(10, 85);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(108, 25);
            this.labelX3.TabIndex = 2;
            this.labelX3.Text = "Diễn giải";
            // 
            // cbodonvi
            // 
            this.cbodonvi.DisplayMember = "Text";
            this.cbodonvi.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbodonvi.FormattingEnabled = true;
            this.cbodonvi.ItemHeight = 16;
            this.cbodonvi.Location = new System.Drawing.Point(144, 23);
            this.cbodonvi.Name = "cbodonvi";
            this.cbodonvi.Size = new System.Drawing.Size(256, 22);
            this.cbodonvi.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbodonvi.TabIndex = 3;
            // 
            // txttenphongban
            // 
            // 
            // 
            // 
            this.txttenphongban.Border.Class = "TextBoxBorder";
            this.txttenphongban.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txttenphongban.Location = new System.Drawing.Point(144, 60);
            this.txttenphongban.Name = "txttenphongban";
            this.txttenphongban.Size = new System.Drawing.Size(257, 22);
            this.txttenphongban.TabIndex = 4;
            // 
            // txtdiengiai
            // 
            // 
            // 
            // 
            this.txtdiengiai.Border.Class = "TextBoxBorder";
            this.txtdiengiai.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtdiengiai.Location = new System.Drawing.Point(10, 117);
            this.txtdiengiai.Multiline = true;
            this.txtdiengiai.Name = "txtdiengiai";
            this.txtdiengiai.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtdiengiai.Size = new System.Drawing.Size(450, 131);
            this.txtdiengiai.TabIndex = 5;
            // 
            // btnthem
            // 
            this.btnthem.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnthem.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnthem.Location = new System.Drawing.Point(408, 20);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(45, 25);
            this.btnthem.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnthem.TabIndex = 6;
            this.btnthem.Text = "+";
            // 
            // btnluulai
            // 
            this.btnluulai.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnluulai.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnluulai.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnluulai.Location = new System.Drawing.Point(242, 270);
            this.btnluulai.Name = "btnluulai";
            this.btnluulai.Size = new System.Drawing.Size(87, 31);
            this.btnluulai.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnluulai.TabIndex = 7;
            this.btnluulai.Text = "Lưu";
            this.btnluulai.Click += new System.EventHandler(this.btnluulai_Click);
            // 
            // btndong
            // 
            this.btndong.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btndong.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btndong.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btndong.Location = new System.Drawing.Point(366, 270);
            this.btndong.Name = "btndong";
            this.btndong.Size = new System.Drawing.Size(87, 31);
            this.btndong.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btndong.TabIndex = 8;
            this.btndong.Text = "Đóng";
            this.btndong.Click += new System.EventHandler(this.btndong_Click);
            // 
            // PhongBan_Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 313);
            this.Controls.Add(this.btndong);
            this.Controls.Add(this.btnluulai);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.txtdiengiai);
            this.Controls.Add(this.txttenphongban);
            this.Controls.Add(this.cbodonvi);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.labelX1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Name = "PhongBan_Edit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PhongBan_Edit";
            this.Load += new System.EventHandler(this.PhongBan_Edit_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbodonvi;
        private DevComponents.DotNetBar.Controls.TextBoxX txttenphongban;
        private DevComponents.DotNetBar.Controls.TextBoxX txtdiengiai;
        private DevComponents.DotNetBar.ButtonX btnthem;
        private DevComponents.DotNetBar.ButtonX btnluulai;
        private DevComponents.DotNetBar.ButtonX btndong;
    }
}