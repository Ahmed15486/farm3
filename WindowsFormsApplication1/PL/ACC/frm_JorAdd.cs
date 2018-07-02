using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1.PL.ACC
{
    public partial class frm_JorAdd : Form
    {
        #region Declarations
        G.frm_Search s = new G.frm_Search();
        BL.BL.Jor jor = new BL.BL.Jor();
        DataTable dt_ACC = new DataTable();
        DataRow dr_Jor;


        public DataGridView dgv;
        public TextBox txt_TotalDebit;
        public TextBox txt_TotalCredit;
        public int rowindex;
        public bool edit;
        #endregion

        public frm_JorAdd()
        {
            InitializeComponent();

            dt_ACC = jor.Select2();
            com_Acc.DataSource = dt_ACC;
        }

        #region Pro
        public void AddRow()
        {
            dgv.Rows.Add();
            dgv.CurrentCell = dgv.Rows[dgv.Rows.Count - 1].Cells[0];

            dgv.CurrentRow.Cells["Debit"].Value = txt_Debit.Text;
            dgv.CurrentRow.Cells["Credit"].Value = txt_Credit.Text;
            dgv.CurrentRow.Cells["ACCName"].Value = com_Acc.Text.ToString();
            dgv.CurrentRow.Cells["ACCID"].Value = com_Acc.SelectedValue.ToString();
            dgv.CurrentRow.Cells["Notes"].Value = txt_Notes.Text;
            Console.Beep();
            decimal d = Math.Round(Convert.ToDecimal((txt_TotalDebit.Text == "") ? "0" : txt_TotalDebit.Text), 2) + Convert.ToDecimal(dgv.CurrentRow.Cells["Debit"].Value);
            txt_TotalDebit.Text = d.ToString();
            decimal c = Math.Round(Convert.ToDecimal((txt_TotalCredit.Text == "") ? "0" : txt_TotalCredit.Text), 2) + Convert.ToDecimal(dgv.CurrentRow.Cells["Credit"].Value);
            txt_TotalCredit.Text = c.ToString();
        }
        #endregion

        #region Form
        private void frm_OpenAdd_Shown(object sender, EventArgs e)
        {
            if (edit != true)
            {
                com_Acc.DataSource = dt_ACC;
                com_Acc.SelectedValue = -1;
            }

            edit = false;
            com_Acc.Focus();
        }

        #endregion

        #region GroupBox_Details

        // Itam_Name
        private void com_Item_Name_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (com_Acc.SelectedValue == null) { return; }
            foreach (DataRow dr in dt_ACC.Rows)
            {
                if (dr["ID"] == com_Acc.SelectedValue)
                {
                    dr_Jor = dr;
                }
            }
            txt_Debit.Select();
        }
        private void btn_Item_Search_Click(object sender, EventArgs e)
        {
            s.Text = "بحث عن صنف";

            s.dt = dt_ACC;

            s.dgv.Columns[0].DataPropertyName = "ID";
            s.dgv.Columns[1].DataPropertyName = "Name";

            s.dgv.AutoGenerateColumns = false;
            s.dgv.DataSource = s.dt;
            s.ShowDialog();

            com_Acc.Text = s.txt;
        }
        private void btn_Item_Edit_Click(object sender, EventArgs e)
        {
            PL.ACC.frm_ACC i = new PL.ACC.frm_ACC();
            i.FormBorderStyle = FormBorderStyle.Sizable;
            i.ShowDialog();
            dt_ACC = jor.Select2();
            com_Acc.DataSource = dt_ACC;
            com_Acc.SelectedValue = i.txt_ID.Text;
        }
        // Quan
        private void txt_Quan_KeyPress(object sender, KeyPressEventArgs e)
        {
            #region Only Number
            // only numbers
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
                if (e.KeyChar != 043) { System.Media.SystemSounds.Hand.Play(); ; }
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
                System.Media.SystemSounds.Hand.Play();
            }
            #endregion

            // if press +  if enter
            if (e.KeyChar == 043)
            {
                e.Handled = true;
                btn_Add_Click(null, null);
            }
            else if (e.KeyChar == 13)
            {
                e.Handled = true;
                txt_Credit.Focus();
            }
        }

        // CPrice
        private void txt_CPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            #region Only Numbers
            // only numbers
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
                if (e.KeyChar != 043) { System.Media.SystemSounds.Hand.Play(); ; }
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
                System.Media.SystemSounds.Hand.Play();
            }
            #endregion

            if (e.KeyChar == 043)
            {
                e.Handled = true;
                btn_Add_Click(null, null);

            }
            else if (e.KeyChar == 13)
            {
                e.Handled = true;
                btn_Add_Click(null, null);
            }
        }
        #endregion

        #region Controls
        private void btn_Add_Click(object sender, EventArgs e)
        {
            txt_Debit.Text = (txt_Debit.Text.Trim() == "" | txt_Debit.Text.Trim() == ".") ? "0" : txt_Debit.Text.Trim();
            txt_Credit.Text = (txt_Credit.Text.Trim() == "" | txt_Credit.Text.Trim() == ".") ? "0" : txt_Credit.Text.Trim();

            if (com_Acc.SelectedValue == null)
            {
                MessageBox.Show("يجب تحديد حساب", "! حقل فارغ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                com_Acc.Focus();
                com_Acc.DroppedDown = true;
                return;
            }

            if (Convert.ToDecimal(txt_Debit.Text) == 0 && Convert.ToDecimal(txt_Credit.Text) == 0)
            {
                MessageBox.Show("يجب تحديد إدخال المدين أو الدائن", "! حقل فارغ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txt_Credit.Text = "";
                txt_Credit.Focus();
                return;
            }

            if (btn_Add.Text != "تعديل")
            {
                AddRow();

                com_Acc.SelectedValue = -1;
                txt_Debit.Text = "";
                txt_Credit.Text = "";
            }
            else
            {
                dgv.CurrentCell = dgv.Rows[rowindex].Cells[0];

                dgv.CurrentRow.Cells["Debit"].Value = txt_Debit.Text;
                dgv.CurrentRow.Cells["Credit"].Value = txt_Credit.Text;
                dgv.CurrentRow.Cells["ACCName"].Value = com_Acc.Text.ToString();
                dgv.CurrentRow.Cells["ACCID"].Value = com_Acc.SelectedValue.ToString();
                dgv.CurrentRow.Cells["Notes"].Value = txt_Notes.Text;

                Hide();
            }
            com_Acc.Focus();
        }
        #endregion
    }
}
