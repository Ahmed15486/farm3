using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1.DAL
{
    class DAL
    {
        SqlConnection con;
        Thread thread;
        string lbl;

        #region Pro
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

        public DAL()
        {
            if (Properties.Settings.Default.Mode == "WINDOWS")
            {
                con = new SqlConnection(@"Server=" + Properties.Settings.Default.Server +
                                                    "; Database=" + Properties.Settings.Default.DataBase + "; Integrated Security=True");
            }
            else
            {
                con = new SqlConnection(@"Server=" + Properties.Settings.Default.Server +
                                                    "; Database=" + Properties.Settings.Default.DataBase + "; Integrated Security=False; User ID=" +
                                                      Properties.Settings.Default.SQLID + "; Password=" + Properties.Settings.Default.Password);
            }
        }
        public void open()
        {
            if (con.State != ConnectionState.Open)
            {
                con.Open();

                if (con.State != ConnectionState.Open)
                {
                    MessageBox.Show("Connection currently {0} when it should be open.", "Data Access Open", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
        }
        public void Close()
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }


        public DataTable Select(string stord_procedure, SqlParameter[] param)
        {
            DataTable dt = new DataTable();
            using (con)
            {
                try
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = stord_procedure;
                    cmd.Connection = con;

                    if (param != null)
                    {
                        for (int i = 0; i < param.Length; i++)
                        {
                            cmd.Parameters.Add(param[i]);
                        }
                    }

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Data Access", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }

            return dt;
        }
        public DataSet Select_Multi(string stord_procedure, SqlParameter[] param)
        {
            DataSet st = new DataSet();
            using (con)
            {
                try
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = stord_procedure;
                    cmd.Connection = con;

                    if (param != null)
                    {
                        for (int i = 0; i < param.Length; i++)
                        {
                            cmd.Parameters.Add(param[i]);
                        }
                    }

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(st);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Data Access", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }

            return st;
        }
        public DataTable Select(string txt)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = txt;
            cmd.Connection = con;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }
        public DataSet Select_Multi(string txt)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = txt;
            cmd.Connection = con;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet st = new DataSet();
            da.Fill(st);

            return st;
        }
        public string ExecuteCommand(string stored_procedure, SqlParameter[] param)
        {
            SqlCommand cmd = new SqlCommand();
            string s;

            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = stored_procedure;

            if (param != null)
            {
                cmd.Parameters.AddRange(param);
            }

            foreach (IDataParameter p in cmd.Parameters)
            {
                if (p.Value == null) p.Value = DBNull.Value;
            }

            con.Open();
            s = (string)cmd.ExecuteScalar();
            con.Close();

            return s;
        }
        public string ExecuteCommand2(string txt, SqlParameter[] param)
        {
            SqlCommand cmd = new SqlCommand();
            string s;

            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = txt;

            if (param != null)
            {
                cmd.Parameters.AddRange(param);
            }

            foreach (IDataParameter p in cmd.Parameters)
            {
                if (p.Value == null) p.Value = DBNull.Value;
            }

            con.Open();
            s = (string)cmd.ExecuteScalar();
            con.Close();

            return s;
        }
        public string ExecuteCommand(string txt)
        {
            SqlCommand cmd = new SqlCommand();
            string s;
            using (con)
            {
                try
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = txt;
                    cmd.Connection = con;

                    con.Open();
                    s = (string)cmd.ExecuteScalar();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "ExecuteCommand", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    s = "!" + ex.Message;
                }
            }

            return s;
        }

        public int BackupDatabase(string path)
        {
            int i = 0;

            string database = con.Database.ToString();
            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }
            try
            {
                string sqlStmt2 = string.Format("BACKUP DATABASE " + Properties.Settings.Default.DataBase + " TO disk = '" + path + "\\DATA_" + DateTime.Now.ToString("yyyy_MM_dd  hh_mm_ss") + ".bak" + "'");
                SqlCommand bu2 = new SqlCommand(sqlStmt2, con);

                lbl = "جارٍ النسخ ...";
                Start_Waiting();
                i = bu2.ExecuteNonQuery();
                con.Close();
                Abort_Waiting();
                MessageBox.Show("تم حفظ النسخة الإحتياطية بنجاح", "حفظ نسخة إحتياطية", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                con.Close();
                Abort_Waiting();
                MessageBox.Show(ex.ToString());
            }

            return i;
        }
        public int RestoreDatabase(string path)
        {
            int i = 0;

            string database = con.Database.ToString();
            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }
            try
            {
                lbl = "جارٍ إسترجاع البيانات ...";
                Start_Waiting();

                string sqlStmt2 = string.Format("ALTER DATABASE [" + database + "] SET SINGLE_USER WITH ROLLBACK IMMEDIATE");
                SqlCommand bu2 = new SqlCommand(sqlStmt2, con);
                bu2.ExecuteNonQuery();

                string sqlStmt3 = "USE MASTER RESTORE DATABASE [" + database + "] FROM DISK='" + path + "'WITH REPLACE;";
                SqlCommand bu3 = new SqlCommand(sqlStmt3, con);
                bu3.ExecuteNonQuery();

                string sqlStmt4 = string.Format("ALTER DATABASE [" + database + "] SET MULTI_USER");
                SqlCommand bu4 = new SqlCommand(sqlStmt4, con);


                i = bu4.ExecuteNonQuery();
                con.Close();
                Abort_Waiting();

                MessageBox.Show("تم إسترجاع النسخة الإحتياطية بنجاح", "إسترجاع نسخة إحتياطية", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                con.Close();
                Abort_Waiting();
                MessageBox.Show(ex.ToString());
            }

            return i;
        }
        public bool runSqlScriptFile(string pathStoreProceduresFile)
        {
            try
            {
                string script = File.ReadAllText(pathStoreProceduresFile);

                // split script on GO command
                System.Collections.Generic.IEnumerable<string> commandStrings = Regex.Split(script, @"^\s*GO\s*$",
                                         RegexOptions.Multiline | RegexOptions.IgnoreCase);

                open();
                foreach (string commandString in commandStrings)
                {
                    if (commandString.Trim() != "")
                    {
                        using (var command = new SqlCommand(commandString, con))
                        {
                            try
                            {
                                command.ExecuteNonQuery();
                            }
                            catch (SqlException ex)
                            {
                                string spError = commandString.Length > 100 ? commandString.Substring(0, 100) + " ...\n..." : commandString;
                                MessageBox.Show(string.Format("Please check the SqlServer script.\nFile: {0} \nLine: {1} \nError: {2} \nSQL Command: \n{3}", pathStoreProceduresFile, ex.LineNumber, ex.Message, spError), "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return false;
                            }
                        }
                    }
                }
                Close();


                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }
    }
}
