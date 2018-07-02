using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1.PL.G
{
    public partial class frm_Backup : Form
    {
        FolderBrowserDialog fbd = new FolderBrowserDialog();
        OpenFileDialog ofd = new OpenFileDialog();

        public PL.G.frm_Main frm_Main;

        public frm_Backup()
        {
            InitializeComponent();

            txt_Backup.Text = AppDomain.CurrentDomain.BaseDirectory + "BACKUP";
            fbd.SelectedPath = txt_Backup.Text;
            ofd.InitialDirectory = txt_Backup.Text;
        }



        private void btn_BrowseBackup_Click(object sender, EventArgs e)
        {
            if(fbd.ShowDialog() == DialogResult.OK)
            {
                txt_Backup.Text = fbd.SelectedPath;
            }
        }

        private void btn_Backup_Click(object sender, EventArgs e)
        {
            if (System.IO.Directory.Exists(txt_Backup.Text.Trim()))
            {
                BL.BL.G g = new BL.BL.G();
                g.BackupDatabase(txt_Backup.Text.Trim());
            }
            else
            {
                MessageBox.Show("المسار غير موجود");
                return;
            }
        }

        private void btn_BrowseRestore_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                txt_Restore.Text = ofd.FileName;
            }
        }

        private void btn_Restore_Click(object sender, EventArgs e)
        {
            if (System.IO.File.Exists(txt_Restore.Text.Trim()))
            {
                BL.BL.G g = new BL.BL.G();
                g.RestoreDatabase(txt_Restore.Text.Trim());
                frm_Main.FillChart();
                frm_Main.AlarmRefresh();
            }
            else
            {
                MessageBox.Show("مسار الملف غير صحيح");
                return;
            }
        }
    }
}
