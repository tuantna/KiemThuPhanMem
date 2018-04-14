namespace DoAnTotNghiep.PresentationLayer
{
    partial class Frm_DSThietBi
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
            this.luoidsTB = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.ThietBiID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaThietBi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenTB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenDVT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuongNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dongia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnchon = new DevComponents.DotNetBar.ButtonX();
            this.btndong = new DevComponents.DotNetBar.ButtonX();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            ((System.ComponentModel.ISupportInitialize)(this.luoidsTB)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // luoidsTB
            // 
            this.luoidsTB.AllowUserToAddRows = false;
            this.luoidsTB.AllowUserToDeleteRows = false;
            this.luoidsTB.AllowUserToOrderColumns = true;
            this.luoidsTB.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.luoidsTB.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(217)))), ((int)(((byte)(247)))));
            this.luoidsTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.luoidsTB.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.luoidsTB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.luoidsTB.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ThietBiID,
            this.MaThietBi,
            this.TenTB,
            this.TenDVT,
            this.SoLuongNhap,
            this.dongia});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.luoidsTB.DefaultCellStyle = dataGridViewCellStyle2;
            this.luoidsTB.Dock = System.Windows.Forms.DockStyle.Top;
            this.luoidsTB.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.luoidsTB.Location = new System.Drawing.Point(0, 28);
            this.luoidsTB.Name = "luoidsTB";
            this.luoidsTB.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.luoidsTB.Size = new System.Drawing.Size(883, 244);
            this.luoidsTB.TabIndex = 3;
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
            this.TenTB.FillWeight = 89.54314F;
            this.TenTB.HeaderText = "Tên thiết bị";
            this.TenTB.Name = "TenTB";
            // 
            // TenDVT
            // 
            this.TenDVT.DataPropertyName = "TenDVT";
            this.TenDVT.HeaderText = "ĐV Tính";
            this.TenDVT.Name = "TenDVT";
            // 
            // SoLuongNhap
            // 
            this.SoLuongNhap.HeaderText = "Số lượng nhập";
            this.SoLuongNhap.Name = "SoLuongNhap";
            // 
            // dongia
            // 
            this.dongia.HeaderText = "Đơn giá nhập";
            this.dongia.Name = "dongia";
            // 
            // btnchon
            // 
            this.btnchon.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnchon.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnchon.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnchon.Location = new System.Drawing.Point(665, 278);
            this.btnchon.Name = "btnchon";
            this.btnchon.Size = new System.Drawing.Size(95, 41);
            this.btnchon.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnchon.TabIndex = 4;
            this.btnchon.Text = "Lưu lại";
            this.btnchon.Click += new System.EventHandler(this.btnchon_Click);
            // 
            // btndong
            // 
            this.btndong.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btndong.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btndong.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndong.Location = new System.Drawing.Point(774, 278);
            this.btndong.Name = "btndong";
            this.btndong.Size = new System.Drawing.Size(95, 41);
            this.btndong.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btndong.TabIndex = 4;
            this.btndong.Text = "Đóng";
            this.btndong.Click += new System.EventHandler(this.btndong_Click);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.None;
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(0, 25);
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(883, 28);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // Frm_DSThietBi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 329);
            this.Controls.Add(this.btndong);
            this.Controls.Add(this.btnchon);
            this.Controls.Add(this.luoidsTB);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Frm_DSThietBi";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh sách thiết bị";
            this.Load += new System.EventHandler(this.Frm_DSThietBi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.luoidsTB)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.DataGridViewX luoidsTB;
        private DevComponents.DotNetBar.ButtonX btnchon;
        private DevComponents.DotNetBar.ButtonX btndong;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThietBiID;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaThietBi;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenTB;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenDVT;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuongNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn dongia;

    }
}