using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1.PL.Cash
{
    public partial class frm_PayOut : Form
    {
        #region Declarations
        public int UserID;
        BL.BL.PayOut PayOut = new BL.BL.PayOut();
        PL.G.frm_Search search = new G.frm_Search();
        BL.BL.G g = new BL.BL.G();
        DataTable dt = new DataTable();
        DataTable dt_ACC = new DataTable();
        int RowIndex;
        #endregion

        public frm_PayOut()
        {
            InitializeComponent();

            dt_ACC = g.Select2("Select * from  ACC where parent = 0");
            com_ACC.DataSource = dt_ACC;
            com_PayType.DataSource = g.Select2("Select * from  PayTypes");
            dgv.AutoGenerateColumns = false;

            #region dgv Fildes
            var Item_ID = new DataGridViewTextBoxColumn();
            Item_ID.Name = "ID";
            Item_ID.DataPropertyName = "ID";
            Item_ID.HeaderText = "رقم السند";
            Item_ID.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Item_ID.Width = 75;
            dgv.Columns.Add(Item_ID);

            var Date = new DataGridViewTextBoxColumn();
            Date.Name = "Date";
            Date.DataPropertyName = "Date";
            Date.HeaderText = "التاريخ";
            Date.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Date.Width = 100;
            dgv.Columns.Add(Date);

            var Value = new DataGridViewTextBoxColumn();
            Value.Name = "Value";
            Value.HeaderText = "المبلغ";
            Value.DataPropertyName = "Value";
            Value.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Value.Width = 100;
            Value.Visible = true;
            dgv.Columns.Add(Value);

            var ACC = new DataGridViewComboBoxColumn();
            ACC.Name = "ACCID";
            ACC.DataPropertyName = "ACCID";
            ACC.DataSource = dt_ACC;
            ACC.ValueMember = "ID";
            ACC.DisplayMember = "Name";
            ACC.HeaderText = "الحساب";
            ACC.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            ACC.Width = 200;
            dgv.Columns.Add(ACC);

            var Notes = new DataGridViewTextBoxColumn();
            Notes.Name = "Notes";
            Notes.HeaderText = "البيان";
            Notes.DataPropertyName = "Notes";
            Notes.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Notes.Width = 100;
            Notes.Visible = true;
            dgv.Columns.Add(Notes);
            #endregion

            Fill();
        }

        #region pro
        void var()
        {
            PayOut.ID = txt_ID.Text;
            PayOut.Date = DateTime.ParseExact(txt_Date.Text.Trim(), "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None);
            PayOut.No = txt_No.Text.Trim();
            PayOut.ACCID = com_ACC.SelectedValue.ToString();
            PayOut.Value = Convert.ToDecimal(txt_Value.Text.Trim());
            PayOut.PayTypeID = Convert.ToInt32(com_PayType.SelectedValue);
            PayOut.ChekNo = txt_ChekNo.Text;
            if (txt_CheckDate.Text.Trim() != "") PayOut.CheckDate = Convert.ToDateTime(txt_CheckDate.Text.Trim());
            PayOut.Notes = txt_Notes.Text.Trim();
            PayOut.UserID = UserID;
        }
        void Fill()
        {
            dt = PayOut.Select();
            dgv.DataSource = null;
            dgv.DataSource = dt;
            //dgv.DataSource = g.Select2("Select * from  PayOut");
            //dgv.DataSource = g.Select2("Select * from  PayOut Where ACCID = '" + com_ACC.SelectedValue.ToString() + "'");
        }
        void Form_Mode(string mode)
        {
            switch (mode)
            {
                #region Select
                case "Select":
                    Tag = "Select";
                    btn_New.Visible = true;
                    btn_Edit.Visible = true;
                    btn_Save.Visible = false;
                    btn_Delete.Visible = true;
                    btn_Cancel.Visible = false;
                    dgv.Enabled = true;

                    txt_Date.ReadOnly = true;
                    txt_No.ReadOnly = true;
                    com_User.Enabled = false;
                    com_ACC.Enabled = false;
                    txt_Value.ReadOnly = true;
                    com_PayType.Enabled = false;
                    txt_ChekNo.ReadOnly = true;
                    txt_CheckDate.ReadOnly = true;
                    dtp_ChekDate.Enabled = false;
                    txt_Notes.ReadOnly = true;
                    btn_ACC_Search.Visible = false;
                    btn_ACC_Edit.Visible = false;
                    btn_ACC_Del.Visible = false;

                    foreach (DataRow r in dt.Rows)
                    {
                        if (r["ID"].ToString() == dgv.SelectedRows[0].Cells[0].Value.ToString())
                        {
                            txt_ID.Text = r["ID"].ToString();
                            btn_JorID.Text = r["JorID"].ToString();
                            txt_Date.Text = Convert.ToDateTime(r["Date"]).ToString("dd/MM/yyyy");
                            txt_No.Text = r["No"].ToString();
                            com_User.SelectedValue = r["UserID"].ToString();
                            com_ACC.SelectedValue = r["ACCID"];
                            txt_Value.Text = r["Value"].ToString();
                            com_PayType.SelectedValue = r["PayTypeID"];
                            txt_ChekNo.Text = r["ChekNo"].ToString();
                            if (!(r["ChekDate"] is DBNull)) txt_CheckDate.Text = Convert.ToDateTime(r["ChekDate"]).ToString("dd/MM/yyyy");
                            txt_Notes.Text = r["Notes"].ToString();
                            break;
                        }
                    }
                    break;
                #endregion
                #region New
                case "New":
                    Tag = "New";
                    btn_New.Visible = false;
                    btn_Edit.Visible = false;
                    btn_Save.Visible = true;
                    btn_Delete.Visible = false;
                    btn_Cancel.Visible = true;
                    dgv.Enabled = false;

                    txt_Date.ReadOnly = false;
                    txt_No.ReadOnly = false;
                    com_User.Enabled = true;
                    com_ACC.Enabled = true;
                    txt_Value.ReadOnly = false;
                    com_PayType.Enabled = true;
                    txt_ChekNo.ReadOnly = false;
                    txt_CheckDate.ReadOnly = false;
                    dtp_ChekDate.Enabled = true;
                    txt_Notes.ReadOnly = false;
                    btn_ACC_Search.Visible = true;
                    btn_ACC_Edit.Visible = true;
                    btn_ACC_Del.Visible = true;

                    txt_ID.Text = "";
                    btn_JorID.Text = "";
                    txt_Date.Text = DateTime.Today.ToString("dd/MM/yyyy");
                    txt_No.Text = "";
                    com_User.SelectedValue = -1;
                    com_ACC.SelectedValue = -1;
                    com_PayType.SelectedIndex = 0;
                    txt_ChekNo.Text = "";
                    txt_CheckDate.Text = "";
                    txt_Value.Text = "";
                    txt_Notes.Text = "";
                    break;
                #endregion
                #region Edit
                case "Edit":
                    Tag = "Edit";
                    btn_New.Visible = false;
                    btn_Edit.Visible = false;
                    btn_Save.Visible = true;
                    btn_Delete.Visible = false;
                    btn_Cancel.Visible = true;
                    dgv.Enabled = false;

                    txt_Date.ReadOnly = false;
                    txt_No.ReadOnly = false;
                    com_User.Enabled = true;
                    com_ACC.Enabled = true;
                    txt_Value.ReadOnly = false;
                    com_PayType.Enabled = true;
                    txt_ChekNo.ReadOnly = false;
                    txt_CheckDate.ReadOnly = false;
                    dtp_ChekDate.Enabled = true;
                    txt_Notes.ReadOnly = false;
                    btn_ACC_Search.Visible = true;
                    btn_ACC_Edit.Visible = true;
                    btn_ACC_Del.Visible = true;
                    break;
                #endregion
                #region Empty
                case "Empty":
                    Tag = "Empty";
                    btn_New.Visible = true;
                    btn_Edit.Visible = false;
                    btn_Save.Visible = false;
                    btn_Delete.Visible = false;
                    btn_Cancel.Visible = false;
                    dgv.Enabled = true;
                    if (dgv.CurrentRow != null) dgv.CurrentRow.Selected = false;

                    txt_Date.ReadOnly = true;
                    txt_No.ReadOnly = true;
                    com_User.Enabled = false;
                    com_ACC.Enabled = false;
                    txt_Value.ReadOnly = true;
                    com_PayType.Enabled = false;
                    txt_ChekNo.ReadOnly = true;
                    txt_CheckDate.ReadOnly = true;
                    dtp_ChekDate.Enabled = false;
                    txt_Notes.ReadOnly = true;
                    btn_ACC_Search.Visible = false;
                    btn_ACC_Edit.Visible = false;
                    btn_ACC_Del.Visible = false;

                    txt_ID.Text = "";
                    txt_Date.Text = "";
                    txt_No.Text = "";
                    com_User.SelectedValue = -1;
                    com_ACC.SelectedValue = -1;
                    txt_Value.Text = "";
                    txt_Notes.Text = "";
                    break;
                    #endregion
            }
        }
        #endregion

        #region Form
        private void frm_PayOut_Shown(object sender, EventArgs e)
        {
            if (dgv.Rows.Count > 0)
            {
                Form_Mode("Select");
            }
            else
            {
                Form_Mode("Empty");
            }
        }
        #endregion

        #region Controls
        private void btn_New_Click(object sender, EventArgs e)
        {
            Form_Mode("New");
        }
        private void btn_Edit_Click(object sender, EventArgs e)
        {
            Form_Mode("Edit");
            RowIndex = dgv.SelectedRows[0].Index;
        }
        private void btn_Save_Click(object sender, EventArgs e)
        {

            #region Validations
            if (txt_Date.Text.Trim() == "")
            {
                MessageBox.Show("يجب إدخال تاريخ السند", "حفظ البيان", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                txt_Date.Focus();
                return;
            }
            if (com_ACC.SelectedValue == null)
            {
                MessageBox.Show("يجب اختيار الحساب", "حفظ البيان", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                com_ACC.DroppedDown = true;
                return;
            }
            if (txt_Value.Text.Trim() == "")
            {
                MessageBox.Show("يجب ادخال المبلغ", "حفظ البيان", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                txt_Value.Focus();
                return;
            }
            #endregion

            var();

            #region New
            if (Tag.ToString() == "New")
            {
                string t = PayOut.Insert();
                if (t.Length > 2)
                {
                    if (t.Substring(0, 3) == "SQL")
                    {
                        MessageBox.Show(t);
                        return;
                    }
                }
                Fill();
                dgv.CurrentCell = dgv.Rows[dgv.RowCount - 1].Cells[0];
                Form_Mode("Select");
            }
            #endregion

            #region Edit
            else if (Tag.ToString() == "Edit")
            {
                string t = PayOut.Update();
                if (t.Length > 2)
                {
                    if (t.Substring(0, 3) == "SQL")
                    {
                        MessageBox.Show(t);
                        return;
                    }
                }
                Fill();
                dgv.CurrentCell = dgv.Rows[RowIndex].Cells[0];
                Form_Mode("Select");
            }
            #endregion
        }
        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل بالفعل تريد الحذف ؟", "حذف", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.No)
            {
                return;
            }

            var();

            string t = PayOut.Delete();
            if (t.Length > 2)
            {
                if (t.Substring(0, 3) == "SQL")
                {
                    MessageBox.Show(t);
                    return;
                }
            }

            Fill();
            if (dgv.RowCount > 0)
            {
                Tag = "Select";
                Form_Mode("Select");
            }
            else
            {
                Tag = "Empty";
                Form_Mode("Empty");
            }
        }
        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            if (Tag.ToString() == "New")
            {
                Form_Mode("Empty");
            }
            else if (Tag.ToString() == "Edit")
            {
                Form_Mode("Select");
            }
        }
        #endregion

        #region Details
        private void dtp_BirthDate_ValueChanged(object sender, EventArgs e)
        {
            txt_Date.Text = dtp_BirthDate.Value.ToString("dd/MM/yyyy");
        }
        private void btn_Cust_Search_Click(object sender, EventArgs e)
        {
            search.com = com_ACC;
            search.Text = "بحث عن حساب";

            search.dt = (DataTable)com_ACC.DataSource;

            search.dgv.Columns[0].DataPropertyName = "ID";
            search.dgv.Columns[1].DataPropertyName = "Name";

            search.dgv.AutoGenerateColumns = false;
            search.dgv.DataSource = search.dt;
            search.ShowDialog();

            com_ACC.Text = search.txt;
        }
        private void btn_Cust_Edit_Click(object sender, EventArgs e)
        {
            PL.ACC.frm_ACC c = new PL.ACC.frm_ACC();
            c.FormBorderStyle = FormBorderStyle.Sizable;
            c.ShowDialog();
            com_ACC.DataSource = g.Select2("Select * from  ACC where parent = 0");
            com_ACC.SelectedValue = c.txt_ID.Text;
        }
        private void btn_Cust_Del_Click(object sender, EventArgs e)
        {
            com_ACC.SelectedValue = -1;
        }
        private void btn_JorID_Click(object sender, EventArgs e)
        {
            if (btn_JorID.Text == "") return;
            PL.ACC.frm_Jor jor = new ACC.frm_Jor();
            jor.txt_ID.Text = btn_JorID.Text;
            jor.Show();
        }
        private void com_PayType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (com_PayType.SelectedIndex == 1)
            {
                lbl_ChekNo.Visible = true;
                txt_ChekNo.Visible = true;
                lbl_CheckDate.Visible = true;
                txt_CheckDate.Visible = true;
                dtp_ChekDate.Visible = true;
            }
            else
            {
                lbl_ChekNo.Visible = false;
                txt_ChekNo.Visible = false;
                txt_ChekNo.Text = "";
                lbl_CheckDate.Visible = false;
                txt_CheckDate.Visible = false;
                txt_CheckDate.Text = "";
                dtp_ChekDate.Visible = false;
            }
        }
        private void txt_Value_KeyPress(object sender, KeyPressEventArgs e)
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
        }
        private void dtp_ChekDate_ValueChanged(object sender, EventArgs e)
        {
            txt_CheckDate.Text = dtp_ChekDate.Value.ToString("dd/MM/yyyy");
        }
        #endregion

        #region dgv
        private void dgv_SelectionChanged(object sender, EventArgs e)
        {
            if (Tag == null) return;
            if (dgv.CurrentRow.Selected == false) return;
            if (Tag.ToString() == "Select" || Tag.ToString() == "Empty")
            {
                Form_Mode("Select");
            }
        }
        #endregion
    }
}
