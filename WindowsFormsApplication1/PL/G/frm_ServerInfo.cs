using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1.PL.G
{
    public partial class frm_ServerInfo : Form
    {
        SqlConnection con;
        Thread thread;
        string lbl;

        public frm_ServerInfo()
        {
            InitializeComponent();

            textBox_Server.Text = Properties.Settings.Default.Server;
            textBox_DataBase.Text = Properties.Settings.Default.DataBase;
            if (Properties.Settings.Default.Mode == "SQL")
            {
                radio_Windows.Checked = false;
                groupBox1.Visible = true;
                textBox_ID.Text = Properties.Settings.Default.SQLID;
                textBox_Password.Text = Properties.Settings.Default.Password;
            }
            else
            {
                radio_SQL.Checked = false;
                groupBox1.Visible = false;
            }
        }

        #region Pro
        void SaveSettings()
        {
            Properties.Settings.Default.Server = textBox_Server.Text;
            Properties.Settings.Default.DataBase = textBox_DataBase.Text;
            Properties.Settings.Default.Mode = radio_Windows.Checked == true ? "WINDOWS" : "SQL";
            Properties.Settings.Default.SQLID = textBox_ID.Text;
            Properties.Settings.Default.Password = textBox_Password.Text;

            Properties.Settings.Default.Save();
        }
       
        void RestoreDatabase(string path)
        {
            if (Properties.Settings.Default.Mode == "WINDOWS")
            {
                con = new SqlConnection(@"Server=" + Properties.Settings.Default.Server +
                                                    "; Database=" + "Master" + "; Integrated Security=True");
            }
            else
            {
                con = new SqlConnection(@"Server=" + Properties.Settings.Default.Server +
                                                    "; Database=" + Properties.Settings.Default.DataBase + "; Integrated Security=False; User ID=" +
                                                      Properties.Settings.Default.SQLID + "; Password=" + Properties.Settings.Default.Password);
            }

            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }
            try
            {
                string s = "USE MASTER RESTORE DATABASE [Farm] FROM DISK='" + path + "'WITH REPLACE;";
                SqlCommand cmd = new SqlCommand(s, con);

                lbl = "جارٍ اضافة قاعدة البيانات ...";
                Start_Waiting();
                cmd.ExecuteNonQuery();
                con.Close();
                Abort_Waiting();

                MessageBox.Show("تم اضافة قاعدة البيانات بنجاح", "اضافة قاعدة البيانات", MessageBoxButtons.OK , MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                con.Close();
                Abort_Waiting();
                MessageBox.Show(ex.ToString());
            }
        }
        void Start_Waiting()
        {
            thread = new Thread(Waiting);
            thread.IsBackground = true;
            thread.Start();
        }
        void Waiting()
        {
            PL.G.frm_Witing w = new PL.G.frm_Witing();
            w.lbl.Text = lbl;

            w.ShowDialog();
        }
        void Abort_Waiting()
        {
            thread.Abort();
        }
        #endregion

        private void button2_Click(object sender, EventArgs e)
        {
            Dispose();
        }
        private void button_OK_Click(object sender, EventArgs e)
        {
            SaveSettings();
            Close();
        }
        private void radio_Windows_CheckedChanged(object sender, EventArgs e)
        {
            if (radio_Windows.Checked == true)
            {
                groupBox1.Visible = false;
            }
            else
            {
                groupBox1.Visible = true;
            }
        }
        private void lbl_Database_DoubleClick(object sender, EventArgs e)
        {
            SaveSettings();
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                RestoreDatabase(ofd.FileName);
            }
        }
    }
}
