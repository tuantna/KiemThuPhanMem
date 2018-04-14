using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using Microsoft.SqlServer.Management.Smo;
using Microsoft.SqlServer.Management.Common;
using System.Threading;
using System.Configuration;

namespace DoAnTotNghiep.PresentationLayer
{
    public partial class Frm_Backup_DuLieu : Office2007Form
    {
        public Frm_Backup_DuLieu()
        {
            InitializeComponent();
        }
        #region Cac xu ly
        string serverName = ConfigurationManager.AppSettings["server_name"];
        private Server GetServer()
        {
            ServerConnection conn = new ServerConnection(serverName);//, "sa", "sa");     //, userName, password);
            Server myServer = new Server(conn);
            return myServer;
        }

        private void BackupDataBase(string databaseName, string destinationPath)
        {

            Server myServer = GetServer();
            Backup backup = new Backup();
            backup.Action = BackupActionType.Database;  //Loai Backup
            backup.Database = databaseName;             //Ten DataBase duoc backup
            destinationPath = System.IO.Path.Combine(destinationPath, databaseName + ".bak");
            backup.Devices.Add(new BackupDeviceItem(destinationPath, DeviceType.File));
            backup.Initialize = true;       //Tao bo backup moi
            backup.Checksum = true;
            backup.ContinueAfterError = true;
            backup.Incremental = false; //false: Backup day du; true: chi ghi khi so voi lan ghi cuoi cung co thay doi
            backup.LogTruncation = BackupTruncateLogType.Truncate;
            //giam sat qua trinh thuc hien backup, theo %
            backup.PercentComplete += new PercentCompleteEventHandler(backup_PercentComplete);
            //Khi backup hoan tat
            backup.Complete += new Microsoft.SqlServer.Management.Common.ServerMessageEventHandler(backup_Complete);
            // Perform backup.
            backup.SqlBackup(myServer);
        }
        //The event handlers
        void backup_Complete(object sender, Microsoft.SqlServer.Management.Common.ServerMessageEventArgs e)
        {
            MessageBox.Show("Backup cơ sở dữ liệu đã hoàn tất!","Thông báo",MessageBoxButtons.OK);
        }
        void backup_PercentComplete(object sender, PercentCompleteEventArgs e)
        {
            progressBar1.Value = e.Percent;
            PT.Text = e.Percent.ToString() + "%";
            PT.Update();
        }
        #endregion
        private void btnthuchien_Click(object sender, EventArgs e)
        {

            try
            {
                FolderBrowserDialog f = new FolderBrowserDialog();                
                string path = null;
                if (f.ShowDialog() == DialogResult.OK)
                {
                    path = f.SelectedPath;
                    //BackupDataBase("QlSV", Application.StartupPath + "\\..\\..\\Backup\\");
                    BackupDataBase("QLTB", path);
                }
                else
                {
                    MessageBox.Show("Chọn đường dẫn lưu file");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
