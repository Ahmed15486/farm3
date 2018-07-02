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
    public partial class frm_AlarmShow : Form
    {
        #region Declarations
        public int UserID;
        BL.BL.G g = new BL.BL.G();
        public Label lbl_AlarmCount;
        public frm_Main frm_Main;
        #endregion

        public frm_AlarmShow()
        {
            InitializeComponent();

            dgv.AutoGenerateColumns = false;

            foreach (DataGridViewColumn c in dgv.Columns)
            {
                c.ReadOnly = true;
            }
        }

        #region Pro
        void AlarmRefresh()
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

            dgv.DataSource = null;
            dgv.DataSource = dt;
            if (dgv.Rows.Count > 0)
            {
                lbl_AlarmCount.Text = dgv.Rows.Count.ToString();
                lbl_AlarmCount.Visible = true;
            }
            else
            {
                lbl_AlarmCount.Visible = false;
            }
        }
        #endregion

        #region Form
        private void frm_AlarmShow_Shown(object sender, EventArgs e)
        {
            foreach (DataGridViewRow r in dgv.Rows)
            {
                r.Cells["OK"].Value = false;
            }
        }
        #endregion

        #region Controls
        private void btn_Tat3eemAll_Click(object sender, EventArgs e)
        {
            string tsi = "";

            foreach (DataGridViewRow r in dgv.Rows)
            {
                if (Convert.ToBoolean(r.Cells["OK"].Value) == true)
                {
                    tsi += "," + r.Cells["Tat3eemShowID"].Value.ToString();
                }
            }

            if(tsi == "")
            {
                MessageBox.Show("يجب أختيار تطعيمات","تطعيم",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else
            {
                tsi = " Where Tat3eemShowID IN (" + tsi.Substring(1) + ") And WithoutItem = 0";
            }

            DataTable dt = new DataTable();
            dt = g.Select2("Select * From AlarmShow_Select " + tsi);

            if(dt.Rows.Count == 0)
            {
                MessageBox.Show("التنبيهات المحددة بدون صنف محدد بالإعدادات الخاصة بها لكي يتم توجيهها إلى شاشة التطعيم", "تطعيم", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }
            else
            {
                PL.Store.Tat3eemWithdraw t = new Store.Tat3eemWithdraw();
                t.AlarmShow = this;
                t.lbl_AlarmCount = lbl_AlarmCount;
                t.UserID = UserID;
                t.mode = "New";
                t.dt = dt;

                t.Location = new Point(Location.X + ((Width / 2) - t.Width / 2), Location.Y + 7);
                t.frm_Main = frm_Main;
                t.Show();
                Hide();
            }
        }
        private void btn_SelectAll_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow r in dgv.Rows)
            {
                r.Cells["OK"].Value = true;
                r.DefaultCellStyle.BackColor = System.Drawing.ColorTranslator.FromHtml("#ACCBC6");
            }
        }
        private void btn_CancelAll_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow r in dgv.Rows)
            {
                r.Cells["OK"].Value = false;
                r.DefaultCellStyle.BackColor = Color.White;
            }
        }
        private void btn_OK_Click(object sender, EventArgs e)
        {
            int i = 0;
            foreach (DataGridViewRow r in dgv.Rows)
            {
                if (Convert.ToBoolean(r.Cells["OK"].Value) == true)
                {
                    i++;
                }
                if(i > 0)
                {
                    break;
                }
            }
            if (i > 0)
            {
                if (MessageBox.Show("لن تظهر التنبيهات المحددة مرة أخرى", "تأكيد التنبيهات", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    string s = "";
                    foreach (DataGridViewRow r in dgv.Rows)
                    {
                        if (Convert.ToBoolean(r.Cells["OK"].Value) == true)
                        {
                            s += "," + r.Cells["Tat3eemShowID"].Value.ToString();
                        }
                    }


                    s = " Where ID IN (" + s.Substring(1) + ")";

                    g.Cancel_Alarms(s);
                    AlarmRefresh();
                }
            }
            else
            {
                MessageBox.Show("لم يتم أختيار أي تنبيهات", "إلغاء التنبيهات", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        #endregion

        #region dgv
        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                if (Convert.ToBoolean(dgv.Rows[e.RowIndex].Cells["OK"].Value) == true)
                {
                    dgv.Rows[e.RowIndex].Cells["OK"].Value = false;
                    dgv.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
                }
                else
                {
                    dgv.Rows[e.RowIndex].Cells["OK"].Value = true;
                    dgv.Rows[e.RowIndex].DefaultCellStyle.BackColor = System.Drawing.ColorTranslator.FromHtml("#ACCBC6");
                }

            }
        }
        private void dgv_SelectionChanged(object sender, EventArgs e)
        {
            dgv.ClearSelection();
        }
        #endregion
    }
}
