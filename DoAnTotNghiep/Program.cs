using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace DoAnTotNghiep
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var frm = new PresentationLayer.DangNhap();
            frm.ShowDialog();
            if (PhamMem.codangnhap == true)
            { 
               // Application.EnableVisualStyles();
               // Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Frmain());
                //Application.Run(new PresentationLayer.Frm_NhapTBPQuyen());
           }          

        }
    }
}
