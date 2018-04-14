namespace DoAnTotNghiep.PresentationLayer
{
    partial class Frm_DanhGiaTBi
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
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.cbokhoa = new System.Windows.Forms.ComboBox();
            this.cbophongban = new System.Windows.Forms.ComboBox();
            this.luoithietbi = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.ThietBiID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaThietBi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenTB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenTinhTrang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            ((System.ComponentModel.ISupportInitialize)(this.luoithietbi)).BeginInit();
            this.SuspendLayout();
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.Class = "";
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelX1.Location = new System.Drawing.Point(5, 1);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(898, 29);
            this.labelX1.TabIndex = 0;
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.Class = "";
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(114, 27);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(98, 33);
            this.labelX2.TabIndex = 1;
            this.labelX2.Text = "Khoa :";
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.Class = "";
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(452, 27);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(98, 33);
            this.labelX3.TabIndex = 1;
            this.labelX3.Text = "Phòng ban:";
            // 
            // cbokhoa
            // 
            this.cbokhoa.FormattingEnabled = true;
            this.cbokhoa.Location = new System.Drawing.Point(207, 34);
            this.cbokhoa.Name = "cbokhoa";
            this.cbokhoa.Size = new System.Drawing.Size(197, 22);
            this.cbokhoa.TabIndex = 2;
            this.cbokhoa.SelectedIndexChanged += new System.EventHandler(this.cbokhoa_SelectedIndexChanged);
            // 
            // cbophongban
            // 
            this.cbophongban.FormattingEnabled = true;
            this.cbophongban.Location = new System.Drawing.Point(556, 34);
            this.cbophongban.Name = "cbophongban";
            this.cbophongban.Size = new System.Drawing.Size(197, 22);
            this.cbophongban.TabIndex = 2;
            this.cbophongban.SelectedIndexChanged += new System.EventHandler(this.cbophongban_SelectedIndexChanged);
            // 
            // luoithietbi
            // 
            this.luoithietbi.AllowUserToAddRows = false;
            this.luoithietbi.AllowUserToDeleteRows = false;
            this.luoithietbi.AllowUserToOrderColumns = true;
            this.luoithietbi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.luoithietbi.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.luoithietbi.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(217)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.luoithietbi.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.luoithietbi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.luoithietbi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ThietBiID,
            this.MaThietBi,
            this.TenTB,
            this.TenTinhTrang});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.luoithietbi.DefaultCellStyle = dataGridViewCellStyle2;
            this.luoithietbi.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.luoithietbi.Location = new System.Drawing.Point(17, 88);
            this.luoithietbi.Name = "luoithietbi";
            this.luoithietbi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.luoithietbi.Size = new System.Drawing.Size(860, 269);
            this.luoithietbi.TabIndex = 3;
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
            this.TenTB.HeaderText = "Thiết bị";
            this.TenTB.Name = "TenTB";
            // 
            // TenTinhTrang
            // 
            this.TenTinhTrang.DataPropertyName = "TenTinhTrang";
            this.TenTinhTrang.HeaderText = "Tình trạng";
            this.TenTinhTrang.Name = "TenTinhTrang";
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonX1.Image = global::DoAnTotNghiep.Properties.Resources._1240;
            this.buttonX1.ImageFixedSize = new System.Drawing.Size(50, 50);
            this.buttonX1.Location = new System.Drawing.Point(418, 376);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Size = new System.Drawing.Size(176, 63);
            this.buttonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX1.TabIndex = 4;
            this.buttonX1.Text = "Cập nhật";
            this.buttonX1.Click += new System.EventHandler(this.buttonX1_Click);
            // 
            // Frm_DanhGiaTBi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 469);
            this.Controls.Add(this.buttonX1);
            this.Controls.Add(this.luoithietbi);
            this.Controls.Add(this.cbophongban);
            this.Controls.Add(this.cbokhoa);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.labelX1);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Frm_DanhGiaTBi";
            this.Text = "Frm_DanhGiaTBi";
            this.Load += new System.EventHandler(this.Frm_DanhGiaTBi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.luoithietbi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX3;
        private System.Windows.Forms.ComboBox cbokhoa;
        private System.Windows.Forms.ComboBox cbophongban;
        private DevComponents.DotNetBar.Controls.DataGridViewX luoithietbi;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThietBiID;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaThietBi;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenTB;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenTinhTrang;
        private DevComponents.DotNetBar.ButtonX buttonX1;
    }
}