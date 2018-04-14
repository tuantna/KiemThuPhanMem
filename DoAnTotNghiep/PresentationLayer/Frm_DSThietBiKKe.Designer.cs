namespace DoAnTotNghiep.PresentationLayer
{
    partial class Frm_DSThietBiKKe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_DSThietBiKKe));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.buttonX6 = new DevComponents.DotNetBar.ButtonX();
            this.luoiTBKK = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.ThietBiID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaThietBi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenTB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HienTrang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonX3 = new DevComponents.DotNetBar.ButtonX();
            ((System.ComponentModel.ISupportInitialize)(this.luoiTBKK)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonX6
            // 
            this.buttonX6.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX6.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX6.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.buttonX6.Image = ((System.Drawing.Image)(resources.GetObject("buttonX6.Image")));
            this.buttonX6.ImageFixedSize = new System.Drawing.Size(40, 40);
            this.buttonX6.Location = new System.Drawing.Point(386, 294);
            this.buttonX6.Name = "buttonX6";
            this.buttonX6.Size = new System.Drawing.Size(116, 46);
            this.buttonX6.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX6.TabIndex = 48;
            this.buttonX6.Text = "Xóa";
            // 
            // luoiTBKK
            // 
            this.luoiTBKK.AllowUserToAddRows = false;
            this.luoiTBKK.AllowUserToDeleteRows = false;
            this.luoiTBKK.AllowUserToOrderColumns = true;
            this.luoiTBKK.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.luoiTBKK.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(217)))), ((int)(((byte)(247)))));
            this.luoiTBKK.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.luoiTBKK.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.luoiTBKK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.luoiTBKK.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ThietBiID,
            this.MaThietBi,
            this.TenTB,
            this.HienTrang});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.luoiTBKK.DefaultCellStyle = dataGridViewCellStyle2;
            this.luoiTBKK.Dock = System.Windows.Forms.DockStyle.Top;
            this.luoiTBKK.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.luoiTBKK.Location = new System.Drawing.Point(0, 0);
            this.luoiTBKK.Name = "luoiTBKK";
            this.luoiTBKK.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.luoiTBKK.Size = new System.Drawing.Size(740, 276);
            this.luoiTBKK.TabIndex = 47;
            this.luoiTBKK.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.luoiTBKK_CellEndEdit);
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
            // HienTrang
            // 
            this.HienTrang.HeaderText = "Hiện trạng";
            this.HienTrang.Name = "HienTrang";
            // 
            // buttonX3
            // 
            this.buttonX3.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX3.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX3.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.buttonX3.Image = ((System.Drawing.Image)(resources.GetObject("buttonX3.Image")));
            this.buttonX3.ImageFixedSize = new System.Drawing.Size(40, 40);
            this.buttonX3.Location = new System.Drawing.Point(213, 294);
            this.buttonX3.Name = "buttonX3";
            this.buttonX3.Size = new System.Drawing.Size(129, 46);
            this.buttonX3.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX3.TabIndex = 49;
            this.buttonX3.Text = "Cập nhật";
            this.buttonX3.Click += new System.EventHandler(this.buttonX3_Click);
            // 
            // Frm_DSThietBiKKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 362);
            this.Controls.Add(this.buttonX6);
            this.Controls.Add(this.luoiTBKK);
            this.Controls.Add(this.buttonX3);
            this.Name = "Frm_DSThietBiKKe";
            this.Text = "Frm_DSThietBiKKe";
            this.Load += new System.EventHandler(this.Frm_DSThietBiKKe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.luoiTBKK)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ButtonX buttonX6;
        private DevComponents.DotNetBar.Controls.DataGridViewX luoiTBKK;
        private DevComponents.DotNetBar.ButtonX buttonX3;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThietBiID;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaThietBi;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenTB;
        private System.Windows.Forms.DataGridViewTextBoxColumn HienTrang;
    }
}