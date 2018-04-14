namespace DoAnTotNghiep.PresentationLayer
{
    partial class Frm_TimKiemTB_PhongBan
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
            this.bar1 = new DevComponents.DotNetBar.Bar();
            this.txtten = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelItem2 = new DevComponents.DotNetBar.LabelItem();
            this.btnRefresh = new DevComponents.DotNetBar.ButtonItem();
            this.luoithietbi = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bar1)).BeginInit();
            this.bar1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.luoithietbi)).BeginInit();
            this.SuspendLayout();
            // 
            // bar1
            // 
            this.bar1.Controls.Add(this.txtten);
            this.bar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bar1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.labelItem2,
            this.btnRefresh});
            this.bar1.Location = new System.Drawing.Point(5, 1);
            this.bar1.Name = "bar1";
            this.bar1.Size = new System.Drawing.Size(844, 59);
            this.bar1.Stretch = true;
            this.bar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003;
            this.bar1.TabIndex = 11;
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
            this.txtten.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtten.Location = new System.Drawing.Point(172, 18);
            this.txtten.Name = "txtten";
            this.txtten.Size = new System.Drawing.Size(201, 22);
            this.txtten.TabIndex = 3;
            this.txtten.WatermarkText = "Nhập chức vụ cần tra cứu";
            this.txtten.TextChanged += new System.EventHandler(this.txtten_TextChanged);
            // 
            // labelItem2
            // 
            this.labelItem2.BorderSide = DevComponents.DotNetBar.eBorderSide.Left;
            this.labelItem2.BorderType = DevComponents.DotNetBar.eBorderType.Sunken;
            this.labelItem2.Name = "labelItem2";
            this.labelItem2.PaddingLeft = 2;
            // 
            // btnRefresh
            // 
            this.btnRefresh.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnRefresh.FontBold = true;
            this.btnRefresh.Image = global::DoAnTotNghiep.Properties.Resources.search_b_icon;
            this.btnRefresh.ImageFixedSize = new System.Drawing.Size(50, 50);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Text = "Nhập tên thiết bị";
            // 
            // luoithietbi
            // 
            this.luoithietbi.AllowUserToAddRows = false;
            this.luoithietbi.AllowUserToDeleteRows = false;
            this.luoithietbi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.luoithietbi.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(217)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.luoithietbi.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.luoithietbi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.luoithietbi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.luoithietbi.Dock = System.Windows.Forms.DockStyle.Top;
            this.luoithietbi.Location = new System.Drawing.Point(5, 60);
            this.luoithietbi.Name = "luoithietbi";
            this.luoithietbi.ReadOnly = true;
            this.luoithietbi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.luoithietbi.Size = new System.Drawing.Size(844, 299);
            this.luoithietbi.TabIndex = 12;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MaThietBi";
            this.Column1.HeaderText = "Mã thiết bị";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "TenTB";
            this.Column2.HeaderText = "Tên thiết bị";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "TenDVT";
            this.Column3.HeaderText = "Đơn vị tính";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "TenDonVi";
            this.Column4.HeaderText = "Khoa";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "TenPhongBan";
            this.Column5.HeaderText = "Phòng ban";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Frm_TimKiemTB_PhongBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 454);
            this.Controls.Add(this.luoithietbi);
            this.Controls.Add(this.bar1);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Frm_TimKiemTB_PhongBan";
            this.Text = "Frm_TimKiemTB_PhongBan";
            ((System.ComponentModel.ISupportInitialize)(this.bar1)).EndInit();
            this.bar1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.luoithietbi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Bar bar1;
        private DevComponents.DotNetBar.Controls.TextBoxX txtten;
        private DevComponents.DotNetBar.LabelItem labelItem2;
        private DevComponents.DotNetBar.ButtonItem btnRefresh;
        private System.Windows.Forms.DataGridView luoithietbi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}