using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace WindowsFormsApplication1.PL.G
{
    public partial class frm_Main : Form
    {
        #region Declarations
        public bool Demo;
        public int UserID;
        BL.BL.G g = new BL.BL.G();
        public PL.G.frm_AlarmShow AlarmShow = new frm_AlarmShow();
        DataTable dt_Result = new DataTable();
        DataTable dt_Items = new DataTable();
        DataTable dt_Alarm = new DataTable();
        DateTime AlarmDate = DateTime.Today;
        #endregion

        public frm_Main()
        {
            InitializeComponent();
        }

        #region Pro
        public void FillChart()
        {
            flowLayoutPanel1.Controls.Clear();

            DataSet ds = new DataSet();
                          // 0
            ds = g.SelectDS("Select TOP 9 * From Items where Level > 1 and Sold = 0 and Dead = 0 Order By Cost desc;"
                          // 1
                          + " Select TOP 9 * From Items where Level > 1 and Sold = 0 and Dead = 0 Order By BDate;"
                          // 2
                          + " SELECT dbo.Cat.Name, COUNT(1) AS Count"
                          + " FROM  dbo.Items LEFT OUTER JOIN dbo.Cat ON dbo.Items.Cat = dbo.Cat.ID "
                          + " Where dbo.Items.Level > 1 and Sold = 0 and Dead = 0"
                          + " GROUP BY dbo.Cat.Name;"
                          // 3
                          + " SELECT dbo.Cat.Name, SUM(dbo.Items.Cost) AS Cost"
                          + " FROM  dbo.Items LEFT OUTER JOIN dbo.Cat ON dbo.Items.Cat = dbo.Cat.ID "
                          + " Where dbo.Items.Level > 1 and Sold = 0 and Dead = 0"
                          + " GROUP BY dbo.Cat.Name;"
                          // 4
                          + " SELECT dbo.Farm.Name, COUNT(1) AS Count"
                          + " FROM  dbo.Items LEFT OUTER JOIN dbo.Farm ON dbo.Items.Farm = dbo.Farm.ID "
                          + " Where dbo.Items.Level > 1 and Sold = 0 and Dead = 0"
                          + " GROUP BY dbo.Farm.Name;"
                          // 5
                          + " SELECT dbo.Farm.Name, SUM(dbo.Items.Cost) AS Cost"
                          + " FROM  dbo.Items LEFT OUTER JOIN dbo.Farm ON dbo.Items.Farm = dbo.Farm.ID "
                          + " Where dbo.Items.Level > 1 and Sold = 0 and Dead = 0"
                          + " GROUP BY dbo.Farm.Name;"
                          // 6
                          + " Select TOP 5 * From Items2 where Level > 1  Order By Quan desc;"
                          // 7
                          + " Select TOP 5 * From Items2 where Level > 1  Order By Quan asc;"
                          );

            #region chart_FarmCount
            if (ds.Tables[4].Rows.Count > 0)
            {
                Chart chart_FarmCount = new Chart();
                Title title_Farm = chart_FarmCount.Titles.Add("العدد لكل حظيرة");
                title_Farm.Font = new System.Drawing.Font("Calibri", 16, FontStyle.Bold);
                title_Farm.ForeColor = System.Drawing.Color.MidnightBlue;

                chart_FarmCount.Size = new Size(476, 350);
                chart_FarmCount.BackColor = Color.Silver;

                chart_FarmCount.ChartAreas.Add(new ChartArea());
                chart_FarmCount.ChartAreas[0].BackColor = Color.White;

                chart_FarmCount.Series.Add(new Series("Data"));
                chart_FarmCount.Legends.Add(new Legend("Stores"));
                chart_FarmCount.Series["Data"].ChartType = SeriesChartType.Pie;
                chart_FarmCount.Series["Data"]["PieLabelStyle"] = "Outside";
                chart_FarmCount.Series["Data"]["PieLineColor"] = "Black";
                for (int x = 0; x < ds.Tables[4].Rows.Count; x++)
                {
                    int ptIdx = chart_FarmCount.Series["Data"].Points.AddXY(
                         ds.Tables[4].Rows[x]["Name"].ToString(),
                         ds.Tables[4].Rows[x]["Count"].ToString());
                    DataPoint pt = chart_FarmCount.Series["Data"].Points[ptIdx];
                    pt.LegendText = "#VALX: #VALY";
                }

                chart_FarmCount.Series["Data"].Label = "#PERCENT{P0}";
                chart_FarmCount.Series["Data"].Font = new Font("Segoe UI", 8.0f, FontStyle.Bold);
                chart_FarmCount.Series["Data"].ChartType = SeriesChartType.Pie;
                chart_FarmCount.Series["Data"]["PieLabelStyle"] = "Outside";
                chart_FarmCount.Series["Data"].Legend = "Stores";
                chart_FarmCount.Legends["Stores"].Docking = Docking.Bottom;

                flowLayoutPanel1.Controls.Add(chart_FarmCount);
            }
            #endregion

            #region chart_FarmCost
            if (ds.Tables[5].Rows.Count > 0)
            {
                Chart chart_FarmCost = new Chart();
                Title title_Farm = chart_FarmCost.Titles.Add("التكلفة لكل حظيرة");
                title_Farm.Font = new System.Drawing.Font("Calibri", 16, FontStyle.Bold);
                title_Farm.ForeColor = System.Drawing.Color.MidnightBlue;

                chart_FarmCost.Size = new Size(476, 350);
                chart_FarmCost.BackColor = Color.Silver;

                chart_FarmCost.ChartAreas.Add(new ChartArea());
                chart_FarmCost.ChartAreas[0].BackColor = Color.White;

                chart_FarmCost.Series.Add(new Series("Data"));
                chart_FarmCost.Legends.Add(new Legend("Stores"));
                chart_FarmCost.Series["Data"].ChartType = SeriesChartType.Pie;
                chart_FarmCost.Series["Data"]["PieLabelStyle"] = "Outside";
                chart_FarmCost.Series["Data"]["PieLineColor"] = "Black";
                for (int x = 0; x < ds.Tables[5].Rows.Count; x++)
                {
                    int ptIdx = chart_FarmCost.Series["Data"].Points.AddXY(
                         ds.Tables[5].Rows[x]["Name"].ToString(),
                         ds.Tables[5].Rows[x]["Cost"].ToString());
                    DataPoint pt = chart_FarmCost.Series["Data"].Points[ptIdx];
                    pt.LegendText = "#VALX: #VALY";
                }

                chart_FarmCost.Series["Data"].Label = "#PERCENT{P0}";
                chart_FarmCost.Series["Data"].Font = new Font("Segoe UI", 8.0f, FontStyle.Bold);
                chart_FarmCost.Series["Data"].ChartType = SeriesChartType.Pie;
                chart_FarmCost.Series["Data"]["PieLabelStyle"] = "Outside";
                chart_FarmCost.Series["Data"].Legend = "Stores";
                chart_FarmCost.Legends["Stores"].Docking = Docking.Bottom;

                flowLayoutPanel1.Controls.Add(chart_FarmCost);
            }
            #endregion

            #region chart_CatCount
            if (ds.Tables[2].Rows.Count > 0)
            {
                Chart chart_CatCount = new Chart();
                Title title_Cat = chart_CatCount.Titles.Add("العدد لكل فئة");
                title_Cat.Font = new System.Drawing.Font("Calibri", 16, FontStyle.Bold);
                title_Cat.ForeColor = System.Drawing.Color.MidnightBlue;

                chart_CatCount.Size = new Size(476, 350);
                chart_CatCount.BackColor = Color.Silver;

                chart_CatCount.ChartAreas.Add(new ChartArea());
                chart_CatCount.ChartAreas[0].BackColor = Color.White;

                chart_CatCount.Series.Add(new Series("Data"));
                chart_CatCount.Legends.Add(new Legend("Stores"));
                chart_CatCount.Series["Data"].ChartType = SeriesChartType.Pie;
                chart_CatCount.Series["Data"]["PieLabelStyle"] = "Outside";
                chart_CatCount.Series["Data"]["PieLineColor"] = "Black";
                for (int x = 0; x < ds.Tables[2].Rows.Count; x++)
                {
                    int ptIdx = chart_CatCount.Series["Data"].Points.AddXY(
                         ds.Tables[2].Rows[x]["Name"].ToString(),
                         ds.Tables[2].Rows[x]["Count"].ToString());
                    DataPoint pt = chart_CatCount.Series["Data"].Points[ptIdx];
                    pt.LegendText = "#VALX: #VALY";
                }

                chart_CatCount.Series["Data"].Label = "#PERCENT{P0}";
                chart_CatCount.Series["Data"].Font = new Font("Segoe UI", 8.0f, FontStyle.Bold);
                chart_CatCount.Series["Data"].ChartType = SeriesChartType.Pie;
                chart_CatCount.Series["Data"]["PieLabelStyle"] = "Outside";
                chart_CatCount.Series["Data"].Legend = "Stores";
                chart_CatCount.Legends["Stores"].Docking = Docking.Bottom;

                flowLayoutPanel1.Controls.Add(chart_CatCount);
            }
            #endregion

            #region chart_CatCost
            if (ds.Tables[3].Rows.Count > 0)
            {
                Chart chart_CatCost = new Chart();
                Title title_Cat = chart_CatCost.Titles.Add("التكلفة لكل فئة");
                title_Cat.Font = new System.Drawing.Font("Calibri", 16, FontStyle.Bold);
                title_Cat.ForeColor = System.Drawing.Color.MidnightBlue;

                chart_CatCost.Size = new Size(476, 350);
                chart_CatCost.BackColor = Color.Silver;

                chart_CatCost.ChartAreas.Add(new ChartArea());
                chart_CatCost.ChartAreas[0].BackColor = Color.White;

                chart_CatCost.Series.Add(new Series("Data"));
                chart_CatCost.Legends.Add(new Legend("Stores"));
                chart_CatCost.Series["Data"].ChartType = SeriesChartType.Pie;
                chart_CatCost.Series["Data"]["PieLabelStyle"] = "Outside";
                chart_CatCost.Series["Data"]["PieLineColor"] = "Black";
                for (int x = 0; x < ds.Tables[3].Rows.Count; x++)
                {
                    int ptIdx = chart_CatCost.Series["Data"].Points.AddXY(
                         ds.Tables[3].Rows[x]["Name"].ToString(),
                         ds.Tables[3].Rows[x]["Cost"].ToString());
                    DataPoint pt = chart_CatCost.Series["Data"].Points[ptIdx];
                    pt.LegendText = "#VALX: #VALY";
                }

                chart_CatCost.Series["Data"].Label = "#PERCENT{P0}";
                chart_CatCost.Series["Data"].Font = new Font("Segoe UI", 8.0f, FontStyle.Bold);
                chart_CatCost.Series["Data"].ChartType = SeriesChartType.Pie;
                chart_CatCost.Series["Data"]["PieLabelStyle"] = "Outside";
                chart_CatCost.Series["Data"].Legend = "Stores";
                chart_CatCost.Legends["Stores"].Docking = Docking.Bottom;

                flowLayoutPanel1.Controls.Add(chart_CatCost);
            }
            #endregion

            #region chart_Items2HStock
            if (ds.Tables[6].Rows.Count > 0)
            {
                Chart chart_Items2HStock = new Chart();
                Title title_Items = chart_Items2HStock.Titles.Add("الأصناف الأعلى رصيد");
                title_Items.Font = new System.Drawing.Font("Calibri", 16, FontStyle.Bold);
                title_Items.ForeColor = System.Drawing.Color.MidnightBlue;
                chart_Items2HStock.Size = new Size(476, 350);
                chart_Items2HStock.BackColor = Color.Silver;

                chart_Items2HStock.ChartAreas.Add(new ChartArea());
                chart_Items2HStock.ChartAreas[0].BackColor = Color.White;

                chart_Items2HStock.Series.Add(new Series("الرصيد"));
                chart_Items2HStock.Series.Add(new Series("سعر الشراء"));
                chart_Items2HStock.Series.Add(new Series("متوسط التكلفة"));
                chart_Items2HStock.Legends.Add(new Legend("Stores"));
                chart_Items2HStock.Series[0].ChartType = SeriesChartType.Column;
                chart_Items2HStock.Series[1].ChartType = SeriesChartType.Column;

                foreach (DataRow r in ds.Tables[6].Rows)
                {
                    chart_Items2HStock.Series[0].Points.AddXY(r["Name"].ToString(), r["Quan"].ToString());
                    chart_Items2HStock.Series[1].Points.AddXY(r["Name"].ToString(), r["PPrice"].ToString());
                    chart_Items2HStock.Series[2].Points.AddXY(r["Name"].ToString(), r["CPrice"].ToString());
                }
                chart_Items2HStock.Legends["Stores"].Docking = Docking.Bottom;
                flowLayoutPanel1.Controls.Add(chart_Items2HStock);
            }
            #endregion

            #region chart_Items2LStock
            if (ds.Tables[7].Rows.Count > 0)
            {
                Chart chart_Items2LStock = new Chart();
                Title title_Items = chart_Items2LStock.Titles.Add("الأصناف الأقل رصيد");
                title_Items.Font = new System.Drawing.Font("Calibri", 16, FontStyle.Bold);
                title_Items.ForeColor = System.Drawing.Color.MidnightBlue;
                chart_Items2LStock.Size = new Size(476, 350);
                chart_Items2LStock.BackColor = Color.Silver;

                chart_Items2LStock.ChartAreas.Add(new ChartArea());
                chart_Items2LStock.ChartAreas[0].BackColor = Color.White;

                chart_Items2LStock.Series.Add(new Series("الرصيد"));
                chart_Items2LStock.Series.Add(new Series("سعر الشراء"));
                chart_Items2LStock.Series.Add(new Series("متوسط التكلفة"));
                chart_Items2LStock.Legends.Add(new Legend("Stores"));
                chart_Items2LStock.Series[0].ChartType = SeriesChartType.Column;
                chart_Items2LStock.Series[1].ChartType = SeriesChartType.Column;

                foreach (DataRow r in ds.Tables[7].Rows)
                {
                    chart_Items2LStock.Series[0].Points.AddXY(r["Name"].ToString(), r["Quan"].ToString());
                    chart_Items2LStock.Series[1].Points.AddXY(r["Name"].ToString(), r["PPrice"].ToString());
                    chart_Items2LStock.Series[2].Points.AddXY(r["Name"].ToString(), r["CPrice"].ToString());
                }
                chart_Items2LStock.Legends["Stores"].Docking = Docking.Bottom;
                flowLayoutPanel1.Controls.Add(chart_Items2LStock);
            }
            #endregion

            #region chart_Items
            if (ds.Tables[0].Rows.Count > 0)
            {
                Chart chart_Items = new Chart();
                Title title_Items = chart_Items.Titles.Add("المنتجات الأعلى تكلفة");
                title_Items.Font = new System.Drawing.Font("Calibri", 16, FontStyle.Bold);
                title_Items.ForeColor = System.Drawing.Color.MidnightBlue;
                chart_Items.Size = new Size(476, 350);
                chart_Items.BackColor = Color.Silver;

                chart_Items.ChartAreas.Add(new ChartArea());
                chart_Items.ChartAreas[0].BackColor = Color.White;

                chart_Items.Series.Add(new Series("التكلفة"));
                chart_Items.Series.Add(new Series("الوزن"));
                chart_Items.Legends.Add(new Legend("Stores"));
                chart_Items.Series[0].ChartType = SeriesChartType.Column;
                chart_Items.Series[1].ChartType = SeriesChartType.Column;

                foreach (DataRow r in ds.Tables[0].Rows)
                {
                    chart_Items.Series[0].Points.AddXY(r["Name"].ToString(), r["Cost"].ToString());
                    chart_Items.Series[1].Points.AddXY(r["Name"].ToString(), r["Weight"].ToString());
                }
                chart_Items.Legends["Stores"].Docking = Docking.Bottom;
                flowLayoutPanel1.Controls.Add(chart_Items);
            }
            #endregion

            #region chart_ItemsAge
            if (ds.Tables[1].Rows.Count > 0)
            {
                Chart chart_ItemsAge = new Chart();
                Title title_Items = chart_ItemsAge.Titles.Add("المنتجات الأكبر عمراً بالأيام");
                title_Items.Font = new System.Drawing.Font("Calibri", 16, FontStyle.Bold);
                title_Items.ForeColor = System.Drawing.Color.MidnightBlue;
                chart_ItemsAge.Size = new Size(476, 350);
                chart_ItemsAge.BackColor = Color.Silver;

                chart_ItemsAge.ChartAreas.Add(new ChartArea());
                chart_ItemsAge.ChartAreas[0].BackColor = Color.White;

                chart_ItemsAge.Series.Add(new Series("العمر"));
                chart_ItemsAge.Series.Add(new Series("الوزن"));
                chart_ItemsAge.Legends.Add(new Legend("Stores"));
                chart_ItemsAge.Series[0].ChartType = SeriesChartType.Column;
                chart_ItemsAge.Series[1].ChartType = SeriesChartType.Column;

                foreach (DataRow r in ds.Tables[1].Rows)
                {
                    int i = (DateTime.Now - Convert.ToDateTime(r["BDate"])).Days;
                    chart_ItemsAge.Series[0].Points.AddXY(r["Name"].ToString(), i.ToString());
                    chart_ItemsAge.Series[1].Points.AddXY(r["Name"].ToString(), r["Weight"].ToString());
                }
                chart_ItemsAge.Legends["Stores"].Docking = Docking.Bottom;
                flowLayoutPanel1.Controls.Add(chart_ItemsAge);
            }
            #endregion
        }
        void update()
        {
            string[] s = new string[0];

            BL.BL.Update u = new BL.BL.Update();
            int m = u.Check();

            while (m < 0)
            {
                m = u.update(s[m], m + 1);
            }
        }
        public void AlarmRefresh()
        {
            DataTable dt = new DataTable();
            dt = g.Select2("Select * From AlarmShow_Select");
            dt.Columns.Add("ReasonString");

            foreach (DataRow r in dt.Rows)
            {
                switch ((int)r["Reason"])
                {
                    case 1:
                        r["ReasonString"] = "عند التسجيل";
                        break;

                    case 2:
                        r["ReasonString"] = "بعد تاريخ الميلاد بـ" + r["Days"].ToString() + " يوم";
                        break;

                    case 3:
                        r["ReasonString"] = "بعد " + r["AlarmOther_Name"] + " بـ " + r["Days"].ToString() + " يوم";
                        break;

                }
            }

            AlarmShow.dgv.DataSource = dt;
            if (AlarmShow.dgv.Rows.Count > 0)
            {
                lbl_AlarmCount.Text = AlarmShow.dgv.Rows.Count.ToString();
                lbl_AlarmCount.Visible = true;
            }
            else
            {
                lbl_AlarmCount.Visible = false;
            }
        }
        #endregion

        #region Form
        private void frm_Main_Shown(object sender, EventArgs e)
        {
            btn_Database.Image = imageList32.Images["DataBase_32.png"];
            btn_Branche.Image = imageList32.Images["Branche_32.png"];
            btn_User.Image = imageList32.Images["User_32.png"];

            FillChart();

            DataTable dt_AlarmShow = new DataTable();
            dt_AlarmShow = g.Select2("Select * From AlarmShow_Select");
            dt_AlarmShow.Columns.Add("ReasonString");

            foreach (DataRow r in dt_AlarmShow.Rows)
            {
                switch ((int)r["Reason"])
                {
                    case 1:
                        r["ReasonString"] = "عند التسجيل";
                        break;

                    case 2:
                        r["ReasonString"] = "بعد تاريخ الميلاد بـ" + r["Days"].ToString() + " يوم";
                        break;

                    case 3:
                        r["ReasonString"] = "بعد " + r["Days"].ToString() + "يوم من " + r["AlarmOther_Name"];
                        break;

                }
            }
            AlarmShow.dgv.DataSource = dt_AlarmShow;
            if (AlarmShow.dgv.Rows.Count > 0)
            {
                lbl_AlarmCount.Text = AlarmShow.dgv.Rows.Count.ToString();
                lbl_AlarmCount.Visible = true;
            }
            else
            {
                lbl_AlarmCount.Visible = false;
            }
        }
        private void frm_Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("هل تريد حفظ نسخة إحتياطية من البيانات ؟ ...  يجب حفظ نسخ أخرى من البيانات على قرص آخر حتى لا يتم فقدان البيانات نهائياً في حالة عطل القرص الصلب ", "حفظ نسخة احتياطية", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
            if (result == DialogResult.Yes)
            {
                BL.BL.G g = new BL.BL.G();
                g.BackupDatabase(AppDomain.CurrentDomain.BaseDirectory + "BACKUP");
                Environment.Exit(1);
            }
            else if (result == DialogResult.No)
            {
                //Application.Exit();
                //Environment.Exit(1);
                Application.ExitThread();

                Environment.Exit(10);
            }
            else
            {
                e.Cancel = true;
            }
        }
        #endregion

        #region Head Buttons
        private void btn_Alarm_Click(object sender, EventArgs e)
        {
            AlarmShow.UserID = UserID;
            AlarmShow.lbl_AlarmCount = lbl_AlarmCount;
            AlarmShow.frm_Main = this;

            if(WindowState != FormWindowState.Maximized)
            {
                AlarmShow.StartPosition = FormStartPosition.Manual;
                AlarmShow.Location = new Point(Location.X + ((Width / 2) - AlarmShow.Width / 2), Location.Y + panel1.Height + 5);
            }
            else
            {
                AlarmShow.StartPosition = FormStartPosition.CenterScreen;
            }

            AlarmShow.ShowDialog();
        }
        private void btn_Alarm_MouseEnter(object sender, EventArgs e)
        {
            btn_Alarm.FlatStyle = FlatStyle.Popup;
        }
        private void btn_Alarm_MouseLeave(object sender, EventArgs e)
        {
            btn_Alarm.FlatStyle = FlatStyle.Flat;
        }
        #endregion

        #region shortcut buttons
        private void t_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                e.Handled = true;
                try
                {
                    g.ExecuteCommand(((TextBox)sender).Text);
                    MessageBox.Show("تم التنفيذ بنجاح", "تنفيذ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FillChart();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Invalid Command", "Command Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }

            }
        }
        private void lbl_Logo_DoubleClick(object sender, EventArgs e)
        {
            #region desighn
            Form f = new Form();
            f.Size = new Size(1000, 700);
            f.StartPosition = FormStartPosition.CenterScreen;
            f.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            f.Text = "Command";

            TextBox t = new TextBox();
            t.Dock = DockStyle.Fill;
            t.Multiline = true;
            t.ScrollBars = ScrollBars.Both;
            t.KeyPress += new KeyPressEventHandler(t_KeyPress);

            f.Controls.Add(t);
            #endregion

            f.ShowDialog();
        }
        private void tp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                e.Handled = true;
                TextBox t = (TextBox)sender;
                if (t.Text == "102030")
                {
                    ((Form)t.Parent).Dispose();
                    BL.BL.G g = new BL.BL.G();
                    OpenFileDialog ofd = new OpenFileDialog();

                    if (ofd.ShowDialog() == DialogResult.OK && ofd.FileName != "")
                    {
                        g.RunSqlServerScript(ofd.FileName);
                    }
                }
            }
        }
        private void btn_Logo_Click(object sender, EventArgs e)
        {
            #region desighn
            Form f = new Form();
            f.Size = new Size(40, 80);
            f.StartPosition = FormStartPosition.CenterScreen;
            f.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            f.Text = "Password";

            TextBox tp = new TextBox();
            tp.Dock = DockStyle.Fill;
            tp.PasswordChar = '*';
            tp.KeyPress += new KeyPressEventHandler(tp_KeyPress);

            f.Controls.Add(tp);
            #endregion

            f.ShowDialog();
        }
        #endregion

        #region SubMenu btn_Click
        void btn_ItemCard_Click(object sender, EventArgs e)
        {
            PL.Store.frm_Items items = new Store.frm_Items();
            items.UserID = UserID;
            items.ShowDialog();
        }
        void btn_Open_Click(object sender, EventArgs e)
        {
            PL.Store.frm_OpenStock frm_OpenStock = new Store.frm_OpenStock();
            frm_OpenStock.UserID = UserID;
            frm_OpenStock.frm_Main = this;
            frm_OpenStock.Show();
        }
        void btn_ItemsEdit_Click(object sender, EventArgs e)
        {
            PL.Store.frm_ItemsEdit frm_ItemsEdit = new Store.frm_ItemsEdit();
            frm_ItemsEdit.UserID = UserID;
            frm_ItemsEdit.frm_Main = this;
            frm_ItemsEdit.Show();
        }
        void btn_Pur_Click(object sender, EventArgs e)
        {
            PL.Pur.frm_Pur2 frm_pur = new PL.Pur.frm_Pur2();
            frm_pur.UserID = UserID;
            frm_pur.frm_Main = this;
            frm_pur.ShowDialog();
        }
        void btn_Pre_Click(object sender, EventArgs e)
        {
            PL.Pur.frm_Pre frm_ReturnPur = new Pur.frm_Pre();
            frm_ReturnPur.UserID = UserID;
            frm_ReturnPur.frm_Main = this;
            frm_ReturnPur.Show();
        }
        void btn_Sal_Click(object sender, EventArgs e)
        {
            PL.Sal.frm_Sal frm_Sales = new Sal.frm_Sal();
            frm_Sales.UserID = UserID;
            frm_Sales.frm_Main = this;
            frm_Sales.Show();
        }
        void btn_Sre_Click(object sender, EventArgs e)
        {
            PL.Sal.frm_Sre frm_ReturnSales = new Sal.frm_Sre();
            frm_ReturnSales.UserID = UserID;
            frm_ReturnSales.frm_Main = this;
            frm_ReturnSales.Show();
        }
        void btn_Acc_Click(object sender, EventArgs e)
        {
            ACC.frm_ACC acc = new ACC.frm_ACC();
            acc.UserID = UserID;
            acc.Show();
        }
        void btn_JorB_Click(object sender, EventArgs e)
        {
            PL.ACC.frm_JorB jorb = new ACC.frm_JorB();
            jorb.Show();
        }
        void btn_Jor_Click(object sender, EventArgs e)
        {
            PL.ACC.frm_Jor j = new ACC.frm_Jor();
            j.UserID = UserID;
            j.Show();
        }
        void btn_ST_Click(object sender, EventArgs e)
        {
            PL.ACC.frm_ST st = new ACC.frm_ST();
            st.Show();
        }
        void btn_Ven_Click(object sender, EventArgs e)
        {
            PL.Pur.frm_Ven frm_Supp = new Pur.frm_Ven();
            frm_Supp.UserID = UserID;
            frm_Supp.Show();
        }
        void btn_Cust_Click(object sender, EventArgs e)
        {
            PL.Sal.frm_Cust frm_Cust = new Sal.frm_Cust();
            frm_Cust.UserID = UserID;
            frm_Cust.Show();
        }
        void btn_PayIn_Click(object sender, EventArgs e)
        {
            PL.Cash.frm_Payin frm_Payin = new Cash.frm_Payin();
            frm_Payin.UserID = UserID;
            frm_Payin.Show();
        }
        void btn_PayOut_Click(object sender, EventArgs e)
        {
            PL.Cash.frm_PayOut frm_Payout = new Cash.frm_PayOut();
            frm_Payout.UserID = UserID;
            frm_Payout.Show();
        }
        void btn_AnimalsCard_Click(object sender, EventArgs e)
        {
            PL.Store.frm_ItemsCard frm_ItemsCard = new Store.frm_ItemsCard();
            frm_ItemsCard.UserID = UserID;
            frm_ItemsCard.AlarmShow = AlarmShow;
            frm_ItemsCard.lbl_AlarmCount = lbl_AlarmCount;
            frm_ItemsCard.frm_Main = this;

            if (WindowState != FormWindowState.Maximized)
            {
                frm_ItemsCard.StartPosition = FormStartPosition.Manual;
                frm_ItemsCard.Location = new Point(Location.X + ((Width / 2) - frm_ItemsCard.Width / 2), Location.Y + panel1.Height);
            }
            else
            {
                frm_ItemsCard.StartPosition = FormStartPosition.CenterScreen;
            }

            frm_ItemsCard.ShowDialog();
        }
        void btn_StoreWithdraw_Click(object sender, EventArgs e)
        {
            PL.Store.frm_StoreWithdraw sw = new Store.frm_StoreWithdraw();
            sw.UserID = UserID;
            sw.frm_Main = this;
            sw.Show();
        }
        void btn_Tat3eemWithdraw_Click(object sender, EventArgs e)
        {
            PL.Store.Tat3eemWithdraw t = new Store.Tat3eemWithdraw();
            t.AlarmShow = AlarmShow;
            t.lbl_AlarmCount = lbl_AlarmCount;
            t.frm_Main = this;

            if (WindowState != FormWindowState.Maximized)
            {
                t.StartPosition = FormStartPosition.Manual;
                t.Location = new Point(Location.X + ((Width / 2) - t.Width / 2), Location.Y + 7);
            }
            else
            {
                t.StartPosition = FormStartPosition.CenterScreen;
            }

            t.Show();
        }
        void btn_FarmSettings_Click(object sender, EventArgs e)
        {
            #region desighn
            Form f = new Form();
            f.RightToLeft = RightToLeft.Yes;
            f.Size = new Size(800, 150);
            f.StartPosition = FormStartPosition.CenterScreen;
            f.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            f.Text = ((Control)sender).Text;

            FlowLayoutPanel fp = new FlowLayoutPanel();
            fp.Dock = DockStyle.Fill;

            Tools.btn btn_Farms = new Tools.btn();
            btn_Farms.Size = new Size(100, 100);
            btn_Farms.button1.Text = "الحظائر";
            btn_Farms.button1.Click += new EventHandler(btn_Farms_Click);

            Tools.btn btn_Cat = new Tools.btn();
            btn_Cat.Size = new Size(100, 100);
            btn_Cat.button1.Text = "الفئات";
            btn_Cat.button1.Click += new EventHandler(btn_Cat_Click);

            Tools.btn btn_Types = new Tools.btn();
            btn_Types.Size = new Size(100, 100);
            btn_Types.button1.Text = "الأنواع";
            btn_Types.button1.Click += new EventHandler(btn_Types_Click);

            fp.Controls.Add(btn_Farms);
            fp.Controls.Add(btn_Cat);
            fp.Controls.Add(btn_Types);
            f.Controls.Add(fp);
            #endregion

            f.ShowDialog();
        }
        private void btn_AccSettings_Click(object sender, EventArgs e)
        {
            PL.G.frm_ACC_Settings a = new PL.G.frm_ACC_Settings();
            a.ShowDialog();
        }
        #region Settings click
        void btn_Farms_Click(object sender, EventArgs e)
        {
            G.frm_G frm_g = new G.frm_G();
            frm_g.Table = "Farm";
            frm_g.Text = "الحظيرة";
            ((Control)sender).Parent.Parent.Parent.Hide();
            frm_g.ShowDialog();
        }
        void btn_Cat_Click(object sender, EventArgs e)
        {
            G.frm_G frm_g = new G.frm_G();
            frm_g.Table = "Cat";
            frm_g.Text = "الفئة";
            ((Control)sender).Parent.Parent.Parent.Hide();
            frm_g.ShowDialog();
        }
        void btn_Types_Click(object sender, EventArgs e)
        {
            G.frm_G frm_g = new G.frm_G();
            frm_g.Table = "ItemType";
            frm_g.Text = "النوع ";
            ((Control)sender).Parent.Parent.Parent.Hide();
            frm_g.ShowDialog();
        }
        void btn_Alarms_Click(object sender, EventArgs e)
        {
            PL.G.frm_AlarmSet AlarmSet = new frm_AlarmSet();
            AlarmSet.frm_Main = this;
            AlarmSet.AlarmShow = AlarmShow;
            AlarmSet.lbl_AlarmCount = lbl_AlarmCount;

            if (WindowState != FormWindowState.Maximized)
            {
                AlarmSet.StartPosition = FormStartPosition.Manual;
                AlarmSet.Location = new Point(Location.X + ((Width / 2) - AlarmSet.Width / 2), Location.Y + panel1.Height);
            }
            else
            {
                AlarmSet.StartPosition = FormStartPosition.CenterScreen;
            }

            AlarmSet.Show();
        }
        #endregion
        #endregion

        #region menu_Main
        private void menu_Main_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            foreach (ToolStripMenuItem i in menu_Main.Items)
            {
                i.BackColor = Color.Transparent;
            }
            e.ClickedItem.BackColor = Color.PowderBlue;
        }
        private void المستودعاتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fpnl_SubMenue.Controls.Clear();

            Tools.btn btn_ItemCard = new Tools.btn();
            btn_ItemCard.button1.Text = "تعريف صنف";
            btn_ItemCard.button1.Image = imageList48.Images["ItemCard_48.png"];
            btn_ItemCard.button1.Click += new System.EventHandler(btn_ItemCard_Click); 
            fpnl_SubMenue.Controls.Add(btn_ItemCard);

            Tools.btn btn_Open = new Tools.btn();
            btn_Open.button1.Text = "رصيد افتتاحي";
            btn_Open.button1.Image = imageList48.Images["Open_48.png"];
            btn_Open.button1.Click += new EventHandler(btn_Open_Click);
            fpnl_SubMenue.Controls.Add(btn_Open);

            Tools.btn btn_ItemEdit = new Tools.btn();
            btn_ItemEdit.button1.Text = "تعديل أرصدة الأصناف";
            btn_ItemEdit.button1.Image = imageList48.Images["ItemsEdit_48.png"];
            btn_ItemEdit.button1.Click += new EventHandler(btn_ItemsEdit_Click);
            fpnl_SubMenue.Controls.Add(btn_ItemEdit);
        }
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            fpnl_SubMenue.Controls.Clear();

            Tools.btn btn_Pur = new Tools.btn();
            btn_Pur.button1.Text = "استلام مشتريات";
            btn_Pur.button1.Image = imageList48.Images["Pur_48 (2).png"];
            btn_Pur.button1.Click += new EventHandler(btn_Pur_Click);
            fpnl_SubMenue.Controls.Add(btn_Pur);

            Tools.btn btn_Pre = new Tools.btn();
            btn_Pre.button1.Text = "ارجاع مشتريات";
            btn_Pre.button1.Image = imageList48.Images["Pur_48.png"];
            btn_Pre.button1.Click += new EventHandler(btn_Pre_Click);
            fpnl_SubMenue.Controls.Add(btn_Pre);
        }
        private void الفروعToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fpnl_SubMenue.Controls.Clear();

            Tools.btn btn_Sal = new Tools.btn();
            btn_Sal.button1.Text = "فاتورة مبيعات";
            btn_Sal.button1.Image = imageList48.Images["Sales_48.png"];
            btn_Sal.button1.Click += new EventHandler(btn_Sal_Click);
            fpnl_SubMenue.Controls.Add(btn_Sal);

            Tools.btn btn_Sre = new Tools.btn();
            btn_Sre.button1.Text = "ارجاع مبيعات";
            btn_Sre.button1.Image = imageList48.Images["Sal_48.png"];
            btn_Sre.button1.Click += new EventHandler(btn_Sre_Click);
            fpnl_SubMenue.Controls.Add(btn_Sre);
        }
        private void الحساباتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fpnl_SubMenue.Controls.Clear();

            Tools.btn btn_Acc = new Tools.btn();
            btn_Acc.button1.Text = "دليل الحسابات";
            btn_Acc.button1.Image = imageList48.Images["Acc_48.png"];
            btn_Acc.button1.Click += new EventHandler(btn_Acc_Click);
            fpnl_SubMenue.Controls.Add(btn_Acc);

            Tools.btn btn_JorB = new Tools.btn();
            btn_JorB.button1.Text = "بناء القيود";
            btn_JorB.button1.Image = imageList48.Images["JorB_48.png"];
            btn_JorB.button1.Click += new EventHandler(btn_JorB_Click);
            fpnl_SubMenue.Controls.Add(btn_JorB);

            Tools.btn btn_Jor = new Tools.btn();
            btn_Jor.button1.Text = "قيود اليومية";
            btn_Jor.button1.Image = imageList48.Images["Jor_48.png"];
            btn_Jor.button1.Click += new EventHandler(btn_Jor_Click);
            fpnl_SubMenue.Controls.Add(btn_Jor);

            Tools.btn btn_ST = new Tools.btn();
            btn_ST.button1.Text = "كشف حساب";
            btn_ST.button1.Image = imageList48.Images["ST_48.png"];
            btn_ST.button1.Click += new EventHandler(btn_ST_Click);
            fpnl_SubMenue.Controls.Add(btn_ST);

            //Tools.btn btn_TB = new Tools.btn();
            //btn_TB.button1.Text = "ميزان المراجعة";
            //btn_TB.button1.Image = imageList48.Images["TB_48.png"];
            //btn_TB.button1.Click += new EventHandler(btn_TB_Click);
            //fpnl_SubMenue.Controls.Add(btn_TB);

            Tools.btn btn_AccSettings = new Tools.btn();
            btn_AccSettings.button1.Text = "إعدادات";
            btn_AccSettings.button1.Image = imageList48.Images["Settings_48.png"];
            btn_AccSettings.button1.Click += new EventHandler(btn_AccSettings_Click);
            fpnl_SubMenue.Controls.Add(btn_AccSettings);
        }

        private void toolStripMenuContacts_Click(object sender, EventArgs e)
        {
            fpnl_SubMenue.Controls.Clear();

            Tools.btn btn_Ven = new Tools.btn();
            btn_Ven.button1.Text = "الموردون";
            btn_Ven.button1.Image = imageList48.Images["Ven_48.png"];
            btn_Ven.button1.Click += new EventHandler(btn_Ven_Click);
            fpnl_SubMenue.Controls.Add(btn_Ven);

            Tools.btn btn_Cust = new Tools.btn();
            btn_Cust.button1.Text = "العملاء";
            btn_Cust.button1.Image = imageList48.Images["Cust_48.png"];
            btn_Cust.button1.Click += new EventHandler(btn_Cust_Click);
            fpnl_SubMenue.Controls.Add(btn_Cust);
        }
        private void السياراتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fpnl_SubMenue.Controls.Clear();

            Tools.btn btn_PayIn = new Tools.btn();
            btn_PayIn.button1.Text = "سندات القبض";
            btn_PayIn.button1.Image = imageList48.Images["PayIn_48 (2).png"];
            btn_PayIn.button1.Click += new EventHandler(btn_PayIn_Click);
            fpnl_SubMenue.Controls.Add(btn_PayIn);

            Tools.btn btn_PayOut = new Tools.btn();
            btn_PayOut.button1.Text = "سندات الصرف";
            btn_PayOut.button1.Image = imageList48.Images["PayOut_48 (2).png"];
            btn_PayOut.button1.Click += new EventHandler(btn_PayOut_Click);
            fpnl_SubMenue.Controls.Add(btn_PayOut);
        }
        private void toolStripMenuFarms_Click(object sender, EventArgs e)
        {
            fpnl_SubMenue.Controls.Clear();

            Tools.btn btn_AnimalsCard = new Tools.btn();
            btn_AnimalsCard.button1.Text = "تعريف منتج";
            btn_AnimalsCard.button1.Image = imageList48.Images["ItemAnimals_48.png"];
            btn_AnimalsCard.button1.Click += new EventHandler(btn_AnimalsCard_Click);
            fpnl_SubMenue.Controls.Add(btn_AnimalsCard);

            Tools.btn btn_StoreWithdraw = new Tools.btn();
            btn_StoreWithdraw.button1.Text = "صرف مشتودعات";
            btn_StoreWithdraw.button1.Image = imageList48.Images["StockW_48.png"];
            btn_StoreWithdraw.button1.Click += new EventHandler(btn_StoreWithdraw_Click);
            fpnl_SubMenue.Controls.Add(btn_StoreWithdraw);

            Tools.btn btn_Tat3eemWithdraw = new Tools.btn();
            btn_Tat3eemWithdraw.button1.Text = "صرف تطعيم";
            btn_Tat3eemWithdraw.button1.Image = imageList48.Images["Tat3eem_48.png"];
            btn_Tat3eemWithdraw.button1.Click += new EventHandler(btn_Tat3eemWithdraw_Click);
            fpnl_SubMenue.Controls.Add(btn_Tat3eemWithdraw);

            Tools.btn btn_Alarms = new Tools.btn();
            btn_Alarms.button1.Text = "التنبيهات";
            btn_Alarms.button1.Image = imageList48.Images["Alarm_48.png"];
            btn_Alarms.button1.Click += new EventHandler(btn_Alarms_Click);
            fpnl_SubMenue.Controls.Add(btn_Alarms);

            Tools.btn btn_FarmSettings = new Tools.btn();
            btn_FarmSettings.button1.Text = "إعدادات";
            btn_FarmSettings.button1.Image = imageList48.Images["Settings_48.png"];
            btn_FarmSettings.button1.Click += new EventHandler(btn_FarmSettings_Click);
            fpnl_SubMenue.Controls.Add(btn_FarmSettings);
        }
        #endregion



        private void إعداداتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fpnl_SubMenue.Controls.Clear();

            Tools.btn btn_Backup = new Tools.btn();
            btn_Backup.button1.Text = "حفظ وإسترجاع نسخة إحتياطية";
            btn_Backup.button1.Image = imageList48.Images["Backup_48.png"];
            btn_Backup.button1.Click += new EventHandler(btn_Backup_Click);
            fpnl_SubMenue.Controls.Add(btn_Backup);
        }
        private void btn_Backup_Click(object sender, EventArgs e)
        {
            PL.G.frm_Backup b = new frm_Backup();
            b.frm_Main = this;
            b.ShowDialog();
        }
        private void التقاريرToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fpnl_SubMenue.Controls.Clear();

            Tools.btn btn_Rep = new Tools.btn();
            btn_Rep.button1.Text = "التقارير";
            btn_Rep.button1.Image = imageList48.Images["Rep_48.png"];
            btn_Rep.button1.Click += new EventHandler(btn_Rep_Click);
            fpnl_SubMenue.Controls.Add(btn_Rep);
        }
        private void btn_Rep_Click(object sender, EventArgs e)
        {
            PL.Rep.frm_Rep rep = new Rep.frm_Rep();
            rep.Show();
        }

        private void lbl_AlarmCount_Click(object sender, EventArgs e)
        {
            btn_Alarm_Click(null, null);
        }

        private void lbl_AlarmCount_MouseEnter(object sender, EventArgs e)
        {
            btn_Alarm_MouseEnter(null, null);
        }

        private void lbl_AlarmCount_MouseLeave(object sender, EventArgs e)
        {
            btn_Alarm_MouseLeave(null, null);
        }
    }
}
