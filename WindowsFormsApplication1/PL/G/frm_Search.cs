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
    public partial class frm_Search : Form
    {
        #region Declaration
        public DataTable dt;
        public string txt;
        public ComboBox com;
        #endregion

        public frm_Search()
        {
            InitializeComponent();
        }

        #region Form
        private void FRM_Search_Shown(object sender, EventArgs e)
        {
            txt_Search.Focus();
        }
        #endregion

        #region txt
        #region display
        private void txt_Search_MouseEnter(object sender, EventArgs e)
        {
            if (txt_Search.Text == "Search")
            {
                txt_Search.ForeColor = Color.CadetBlue;
            }
        }
        private void txt_Search_MouseLeave(object sender, EventArgs e)
        {
            if (txt_Search.Text == "Search")
            {
                txt_Search.ForeColor = Color.Silver;
            }
        }
        private void txt_Search_Enter(object sender, EventArgs e)
        {
            if (txt_Search.Text == "Search")
            {
                txt_Search.Text = "";
                txt_Search.ForeColor = Color.Black;
            }
        }
        private void txt_Search_Leave(object sender, EventArgs e)
        {
            if (txt_Search.Text.Trim() == "Search" || txt_Search.Text.Trim() == "")
            {
                txt_Search.Text = "Search";
                txt_Search.ForeColor = Color.Silver;
            }
        }
        #endregion
        private void txt_Search_TextChanged(object sender, EventArgs e)
        {
            if (txt_Search.Text == "Search")
            {
                dt.DefaultView.RowFilter = string.Format("");
                return;
            }

            dt.DefaultView.RowFilter = string.Format(dgv.Columns[0].DataPropertyName.ToString() + " Like '%" + txt_Search.Text + "%' OR " + dgv.Columns[1].DataPropertyName.ToString() + " Like '%" + txt_Search.Text + "%'");

            if (dgv.Rows.Count > 0)
            {
                dgv.CurrentCell = dgv.Rows[0].Cells[0];
            }
        }
        private void txt_Search_KeyDown(object sender, KeyEventArgs e)
        {
            // Enter
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                if (dgv.CurrentCell == null) { return; }
                btn_OK_Click(null, null);
            }
            // UP
            if (e.KeyCode == Keys.Up)
            {
                e.Handled = true;
                dgv.Focus();
            }
            // Dowen
            else if (e.KeyCode == Keys.Down)
            {
                e.Handled = true;
                dgv.Focus();
                SendKeys.Send("{DOWN}");
            }
        }
        #endregion

        #region DGV
        private void DGV_KeyDown(object sender, KeyEventArgs e)
        {
            // Enter
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                if (dgv.CurrentCell == null) { return; }
                btn_OK_Click(null, null);
            }
        }
        private void DGV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            dgv.Focus();
            if (dgv.CurrentCell == null) { return; }
            btn_OK_Click(null, null);
        }
        #endregion

        #region Control
        private void btn_OK_Click(object sender, EventArgs e)
        {
            txt = dgv.SelectedRows[0].Cells[0].Value.ToString();
            com.SelectedValue = dgv.SelectedRows[0].Cells[0].Value.ToString();

            Hide();
        }
        #endregion
    }
}
