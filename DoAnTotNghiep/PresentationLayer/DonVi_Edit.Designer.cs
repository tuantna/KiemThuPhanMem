namespace DoAnTotNghiep.PresentationLayer
{
    partial class DonVi_Edit
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
            this.btnthoat = new DevComponents.DotNetBar.ButtonX();
            this.btnluu = new DevComponents.DotNetBar.ButtonX();
            this.txtdiengiai = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txttendv = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.txtdiachi = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.SuspendLayout();
            // 
            // btnthoat
            // 
            this.btnthoat.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnthoat.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnthoat.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthoat.Image = global::DoAnTotNghiep.Properties.Resources.no;
            this.btnthoat.ImageFixedSize = new System.Drawing.Size(35, 35);
            this.btnthoat.Location = new System.Drawing.Point(288, 231);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(89, 41);
            this.btnthoat.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnthoat.TabIndex = 9;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // btnluu
            // 
            this.btnluu.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnluu.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnluu.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnluu.Image = global::DoAnTotNghiep.Properties.Resources.Floppy_64;
            this.btnluu.ImageFixedSize = new System.Drawing.Size(35, 35);
            this.btnluu.Location = new System.Drawing.Point(177, 231);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(96, 42);
            this.btnluu.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnluu.TabIndex = 8;
            this.btnluu.Text = "Lưu";
            this.btnluu.Click += new System.EventHandler(this.btnluu_Click);
            // 
            // txtdiengiai
            // 
            // 
            // 
            // 
            this.txtdiengiai.Border.Class = "TextBoxBorder";
            this.txtdiengiai.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtdiengiai.Location = new System.Drawing.Point(118, 130);
            this.txtdiengiai.Multiline = true;
            this.txtdiengiai.Name = "txtdiengiai";
            this.txtdiengiai.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtdiengiai.Size = new System.Drawing.Size(262, 88);
            this.txtdiengiai.TabIndex = 7;
            this.txtdiengiai.WatermarkText = "Diễn giải đơn vị";
            // 
            // txttendv
            // 
            // 
            // 
            // 
            this.txttendv.Border.Class = "TextBoxBorder";
            this.txttendv.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txttendv.Location = new System.Drawing.Point(118, 12);
            this.txttendv.Name = "txttendv";
            this.txttendv.Size = new System.Drawing.Size(262, 22);
            this.txttendv.TabIndex = 6;
            this.txttendv.WatermarkText = "Tên đơn vị";
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.Class = "";
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(34, 125);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(101, 27);
            this.labelX2.TabIndex = 4;
            this.labelX2.Text = "Diễn giải:";
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.Class = "";
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(34, 12);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(101, 27);
            this.labelX1.TabIndex = 5;
            this.labelX1.Text = "Khoa:";
            // 
            // txtdiachi
            // 
            // 
            // 
            // 
            this.txtdiachi.Border.Class = "TextBoxBorder";
            this.txtdiachi.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtdiachi.Location = new System.Drawing.Point(118, 45);
            this.txtdiachi.Multiline = true;
            this.txtdiachi.Name = "txtdiachi";
            this.txtdiachi.Size = new System.Drawing.Size(262, 66);
            this.txtdiachi.TabIndex = 11;
            this.txtdiachi.WatermarkText = "Địa chỉ đơn vị";
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.Class = "";
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(34, 45);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(101, 27);
            this.labelX3.TabIndex = 10;
            this.labelX3.Text = "Địa chỉ:";
            // 
            // DonVi_Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 285);
            this.Controls.Add(this.txtdiachi);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.btnluu);
            this.Controls.Add(this.txtdiengiai);
            this.Controls.Add(this.txttendv);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.labelX1);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DonVi_Edit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DonVi_Edit";
            this.Load += new System.EventHandler(this.DonVi_Edit_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ButtonX btnthoat;
        private DevComponents.DotNetBar.ButtonX btnluu;
        private DevComponents.DotNetBar.Controls.TextBoxX txtdiengiai;
        private DevComponents.DotNetBar.Controls.TextBoxX txttendv;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.TextBoxX txtdiachi;
        private DevComponents.DotNetBar.LabelX labelX3;
    }
}