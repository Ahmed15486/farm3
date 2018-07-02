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
    public partial class frm_AlarmOtherAdd : Form
    {
        #region Declarations
        G.frm_Search s = new G.frm_Search();
        BL.BL.Items2 items = new BL.BL.Items2();
        DataTable dt_Items = new DataTable();


        public DataGridView dgv;
        public TextBox txt_TotalPPrice;
        public int rowindex;
        public bool edit;
        public int UnitID;
        #endregion

        public frm_AlarmOtherAdd()
        {
            InitializeComponent();
        }

        #region Pro
        public void AddRow()
        {
            dgv.Rows.Add();
            dgv.CurrentCell = dgv.Rows[dgv.Rows.Count - 1].Cells[0];

            dgv.CurrentRow.Cells["AlarmOther_ID"].Value = com_Alarm.SelectedValue.ToString();
            dgv.CurrentRow.Cells["AlarmOther_Name"].Value = com_Alarm.Text;
            dgv.CurrentRow.Cells["StartDays"].Value = txt_StartDays.Text.Trim();
            dgv.CurrentRow.Cells["Infinite"].Value = chk_Infinite.Checked;
            dgv.CurrentRow.Cells["Count"].Value = txt_Count.Text.Trim();

            //Console.Beep();
        }
        #endregion

        #region Form
        private void frm_OpenAdd_Shown(object sender, EventArgs e)
        {
            chk_Infinite.Checked = true;

            if (edit != true)
            {
                com_Alarm.SelectedValue = -1;
            }

            edit = false;
            com_Alarm.Focus();
        }

        #endregion

        #region GroupBox_Details
        private void com_Item_Name_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                e.Handled = true;
                txt_StartDays.Focus();
            }
        }
        private void btn_Item_Search_Click(object sender, EventArgs e)
        {
            s.Text = "بحث عن صنف";

            s.com = com_Alarm;
            s.dt = dt_Items;
            s.txt_Search.Text = "Search";

            s.dgv.Columns[0].DataPropertyName = "ID";
            s.dgv.Columns[1].DataPropertyName = "Name";

            s.dgv.AutoGenerateColumns = false;
            s.dgv.DataSource = s.dt;
            s.ShowDialog();

            //com_Item_Name.Text = s.txt;
        }
        private void btn_Item_Edit_Click(object sender, EventArgs e)
        {
            PL.Store.frm_Items i = new PL.Store.frm_Items();
            i.FormBorderStyle = FormBorderStyle.Sizable;
            i.ShowDialog();
            dt_Items = items.Select2();
            com_Alarm.DataSource = dt_Items;
            com_Alarm.SelectedValue = i.txt_ID.Text;
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
                chk_Infinite.Focus();
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
            #region Validations
            txt_StartDays.Text = (txt_StartDays.Text.Trim() == "" | txt_StartDays.Text.Trim() == ".") ? "1" : txt_StartDays.Text.Trim();

            if (com_Alarm.SelectedValue == null)
            {
                MessageBox.Show("يجب تحديد التنبيه", "! حقل فارغ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                com_Alarm.Focus();
                com_Alarm.DroppedDown = true;
                return;
            }
            #endregion

            if (btn_Add.Text != "تعديل")
            {
                AddRow();

                com_Alarm.SelectedValue = -1;
                txt_StartDays.Text = "";
                chk_Infinite.Checked = false;
                txt_Count.Text = "";
            }
            else
            {
                dgv.Rows[rowindex].Cells["ID"].Value = com_Alarm.SelectedValue.ToString();
                dgv.Rows[rowindex].Cells["Name"].Value = com_Alarm.Text;
                dgv.Rows[rowindex].Cells["Unit"].Value = UnitID;
                dgv.Rows[rowindex].Cells["Quan"].Value = txt_StartDays.Text;
                dgv.Rows[rowindex].Cells["PPrice"].Value = chk_Infinite.Text;
                dgv.Rows[rowindex].Cells["Total"].Value = Math.Round(Convert.ToDecimal(txt_StartDays.Text) * Convert.ToDecimal(chk_Infinite.Text), 2).ToString();

                Hide();
            }
            com_Alarm.Focus();
        }
        #endregion

        private void chk_Infinite_CheckedChanged(object sender, EventArgs e)
        {
            pnl_Count.Visible = !chk_Infinite.Checked;
        }
    }
}
