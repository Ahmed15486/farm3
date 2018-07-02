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
    public partial class frm_JorBAdd : Form
    {
        #region Declarations
        BL.BL.JorB jorb = new BL.BL.JorB();
        G.frm_Search s = new G.frm_Search();
        BL.BL.ACC acc = new BL.BL.ACC();

        public DataSet st;
        public DataGridView dgv;
        public DataGridView temp_dgv;
        public Button btn_Save;
        public int rowindex;
        public bool edit;
        #endregion

        public frm_JorBAdd()
        {
            InitializeComponent();

           
        }

        #region Pro
        public void AddRow()
        {
            dgv.DataSource = null;
            dgv.Rows.Add();
            dgv.CurrentCell = dgv.Rows[dgv.Rows.Count - 1].Cells[0];

            dgv.CurrentRow.Cells["Value"].Value = com_Value.SelectedValue;
            dgv.CurrentRow.Cells["Rate"].Value = num_Rate.Value.ToString();
            dgv.CurrentRow.Cells["Side"].Value = com_Side.SelectedValue;
            dgv.CurrentRow.Cells["ACC"].Value = com_ACC.SelectedValue;
            dgv.CurrentRow.Cells["ACCInDoc"].Value = chk_ACCInDoc.Checked;
            dgv.CurrentRow.Cells["Notes"].Value = txt_Notes.Text;
        }
        #endregion

        #region Form
        private void frm_OpenAdd_Shown(object sender, EventArgs e)
        {
            com_ACC.SelectedValue = -1;
            edit = false;
        }

        #endregion

        #region GroupBox_Details

        // Itam_Name
        private void com_Item_Name_SelectedIndexChanged(object sender, EventArgs e)
        {
            chk_ACCInDoc.Checked = (com_ACC.SelectedValue == null) ? true : false;
        }
        private void btn_Item_Search_Click(object sender, EventArgs e)
        {
            s.Text = "بحث عن صنف";

            s.dt = (DataTable)com_ACC.DataSource;

            s.dgv.Columns[0].DataPropertyName = "ID";
            s.dgv.Columns[1].DataPropertyName = "Name";

            s.dgv.AutoGenerateColumns = false;
            s.dgv.DataSource = s.dt;
            s.ShowDialog();

            com_ACC.Text = s.txt;
        }
        private void btn_Item_Edit_Click(object sender, EventArgs e)
        {
            PL.ACC.frm_ACC i = new PL.ACC.frm_ACC();
            i.FormBorderStyle = FormBorderStyle.Sizable;
            i.ShowDialog();

            st = jorb.JorB_StartSelect();

            com_ACC.DataSource = acc.Select2(); 
            com_ACC.SelectedValue = i.txt_ID.Text;
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
                txt_Notes.Focus();
            }
        }

        // CPrice
        private void txt_CPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 043 || e.KeyChar == 13)
            {
                e.Handled = true;
                btn_Add_Click(null, null);

            }
        }
        #endregion

        #region Controls
        private void btn_Add_Click(object sender, EventArgs e)
        {
            #region Validations
            if (com_Side.SelectedValue == null)
            {
                MessageBox.Show("يجب إختيار الجانب");
                com_Side.DroppedDown = true;
                return;
            }
            if (com_Value.SelectedValue == null)
            {
                MessageBox.Show("يجب إختيار القيمة");
                com_Value.DroppedDown = true;
                return;
            }
            #endregion

            if (btn_Add.Text != "تعديل")
            {
                AddRow();
                btn_Save.Visible = true;

                com_Value.SelectedValue = -1;
                num_Rate.Value = 100;
                com_Side.SelectedValue = -1;
                com_ACC.SelectedValue = -1;
                txt_Notes.Text = "";
            }
            else
            {
                dgv.Rows[rowindex].Cells["Value"].Value = com_Value.SelectedValue.ToString();
                dgv.Rows[rowindex].Cells["Rate"].Value = num_Rate.Value.ToString();
                dgv.Rows[rowindex].Cells["Side"].Value = com_Side.SelectedValue.ToString();
                dgv.Rows[rowindex].Cells["ACC"].Value = com_ACC.Text;
                dgv.Rows[rowindex].Cells["ACCInDoc"].Value = chk_ACCInDoc.Checked;
                dgv.Rows[rowindex].Cells["Notes"].Value = txt_Notes.Text;

                Hide();
            }
            com_ACC.Focus();
        }
        #endregion

        private void chk_ACCInDoc_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_ACCInDoc.Checked) com_ACC.SelectedValue = -1;
        }
    }
}
