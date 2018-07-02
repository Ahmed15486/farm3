using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1.PL.Store
{
    public partial class frm_ProductWhenInsert : Form
    {
        #region Declarations
        public int UserID;
        BL.BL.G g = new BL.BL.G();
        public Label lbl_AlarmCount;
        public G.frm_Main frm_Main;
        public DataTable dt_WhenInsert;
        public bool Continue;
        #endregion

        public frm_ProductWhenInsert()
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
            btn_SelectAll_Click(null, null);
        }
        #endregion

        #region Controls
        private void btn_Tat3eemAll_Click(object sender, EventArgs e)
        {
            dt_WhenInsert.Rows.Clear();

            foreach (DataGridViewRow r in dgv.Rows)
            {
                if (Convert.ToBoolean(r.Cells["OK"].Value) == true)
                {
                    dt_WhenInsert.Rows.Add(r.Cells["AlarmID"].Value);
                }
            }
            Continue = true;
            Hide();
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
            dt_WhenInsert.Columns.Clear();
            dt_WhenInsert.Rows.Clear();
            dt_WhenInsert.Columns.Add("AlarmID");

            Hide();
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
