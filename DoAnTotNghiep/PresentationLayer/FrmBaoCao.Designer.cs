namespace DoAnTotNghiep.PresentationLayer
{
    partial class FrmBaoCao
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
            this.Crv = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // Crv
            // 
            this.Crv.ActiveViewIndex = -1;
            this.Crv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Crv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Crv.Location = new System.Drawing.Point(0, 0);
            this.Crv.Name = "Crv";
            this.Crv.SelectionFormula = "";
            this.Crv.Size = new System.Drawing.Size(458, 266);
            this.Crv.TabIndex = 0;
            this.Crv.ViewTimeSelectionFormula = "";
            // 
            // FrmBaoCao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 266);
            this.Controls.Add(this.Crv);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmBaoCao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "In báo cáo";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        public CrystalDecisions.Windows.Forms.CrystalReportViewer Crv;

    }
}