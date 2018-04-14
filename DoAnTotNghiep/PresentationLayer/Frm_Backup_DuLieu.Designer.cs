namespace DoAnTotNghiep.PresentationLayer
{
    partial class Frm_Backup_DuLieu
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
            this.progressBar1 = new DevComponents.DotNetBar.Controls.ProgressBarX();
            this.PT = new DevComponents.DotNetBar.LabelX();
            this.btnthoat = new DevComponents.DotNetBar.ButtonX();
            this.btnthuchien = new DevComponents.DotNetBar.ButtonX();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            // 
            // 
            // 
            this.progressBar1.BackgroundStyle.Class = "";
            this.progressBar1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.progressBar1.Location = new System.Drawing.Point(12, 22);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(525, 40);
            this.progressBar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.Windows7;
            this.progressBar1.TabIndex = 0;
            this.progressBar1.Text = "progressBarX1";
            // 
            // PT
            // 
            // 
            // 
            // 
            this.PT.BackgroundStyle.Class = "";
            this.PT.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.PT.Location = new System.Drawing.Point(543, 22);
            this.PT.Name = "PT";
            this.PT.Size = new System.Drawing.Size(45, 40);
            this.PT.TabIndex = 1;
            this.PT.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // btnthoat
            // 
            this.btnthoat.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnthoat.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnthoat.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnthoat.Image = global::DoAnTotNghiep.Properties.Resources.Exitasdd;
            this.btnthoat.ImageFixedSize = new System.Drawing.Size(30, 30);
            this.btnthoat.Location = new System.Drawing.Point(327, 80);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(119, 48);
            this.btnthoat.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnthoat.TabIndex = 2;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // btnthuchien
            // 
            this.btnthuchien.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnthuchien.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnthuchien.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnthuchien.Image = global::DoAnTotNghiep.Properties.Resources._4345aaa;
            this.btnthuchien.ImageFixedSize = new System.Drawing.Size(30, 30);
            this.btnthuchien.Location = new System.Drawing.Point(141, 80);
            this.btnthuchien.Name = "btnthuchien";
            this.btnthuchien.Size = new System.Drawing.Size(129, 48);
            this.btnthuchien.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnthuchien.TabIndex = 2;
            this.btnthuchien.Text = "Thực hiện";
            this.btnthuchien.Click += new System.EventHandler(this.btnthuchien_Click);
            // 
            // Frm_Backup_DuLieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 140);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.btnthuchien);
            this.Controls.Add(this.PT);
            this.Controls.Add(this.progressBar1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Backup_DuLieu";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sao lưu dữ liệu";
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.ProgressBarX progressBar1;
        private DevComponents.DotNetBar.LabelX PT;
        private DevComponents.DotNetBar.ButtonX btnthuchien;
        private DevComponents.DotNetBar.ButtonX btnthoat;
    }
}