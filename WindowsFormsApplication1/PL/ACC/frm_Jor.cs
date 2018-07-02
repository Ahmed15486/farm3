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

namespace WindowsFormsApplication1.PL.ACC
{
    public partial class frm_Jor : Form
    {
        #region Declarations
        BL.BL.G g = new BL.BL.G();
        PL.ACC.frm_JorAdd add = new PL.ACC.frm_JorAdd();
        BL.BL.Units units = new BL.BL.Units();

        DataTable Temp_dgv = new DataTable();
        BL.BL.Jor jor = new BL.BL.Jor();
        DataTable dt_Units = new DataTable();
        DataSet st_jor = new DataSet();
        public int UserID;
        #endregion

        public frm_Jor()
        {
            InitializeComponent();

            dgv.AutoGenerateColumns = false;
            dt_Units = units.Select();
            com_JorType.DataSource = g.Select("JorType");
            com_RefType.DataSource = g.Select2("Select * from DocType Where JorB = 1");
            //com_User.DataSource = g.Select("Users");

            #region dgv

            var Debit = new DataGridViewTextBoxColumn();
            Debit.Name = "Debit";
            Debit.HeaderText = "مدين";
            Debit.DataPropertyName = "Debit";
            Debit.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Debit.Width = 100;
            dgv.Columns.Add(Debit);

            var Credit = new DataGridViewTextBoxColumn();
            Credit.Name = "Credit";
            Credit.HeaderText = "دائن";
            Credit.DataPropertyName = "Credit";
            Credit.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Credit.Width = 100;
            dgv.Columns.Add(Credit);

            var ACC_Name = new DataGridViewTextBoxColumn();
            ACC_Name.Name = "ACCName";
            ACC_Name.HeaderText = "أسم الحساب";
            ACC_Name.DataPropertyName = "ACCName";
            ACC_Name.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            ACC_Name.Width = 130;
            dgv.Columns.Add(ACC_Name);

            var ACC_ID = new DataGridViewTextBoxColumn();
            ACC_ID.Name = "ACCID";
            ACC_ID.HeaderText = "كود الحساب";
            ACC_ID.DataPropertyName = "ACCID";
            ACC_ID.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            ACC_ID.Width = 100;
            ACC_ID.Visible = true;
            dgv.Columns.Add(ACC_ID);

            var Notes = new DataGridViewTextBoxColumn();
            Notes.Name = "Notes";
            Notes.HeaderText = "البيان";
            Notes.DataPropertyName = "Notes";
            Notes.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Notes.Width = 150;
            Notes.MinimumWidth = 150;
            dgv.Columns.Add(Notes);

            var CC1 = new DataGridViewComboBoxColumn();
            CC1.Name = "CC1";
            CC1.HeaderText = "مركز 1";
            CC1.DataPropertyName = "CC1";
            CC1.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            CC1.Width = 130;
            CC1.Visible = false;
            CC1.FlatStyle = FlatStyle.Popup;
            //CC1.DataSource = Main.ds.Tables[3];
            CC1.ValueMember = "CC_ID";
            CC1.DisplayMember = "CC_Name";
            dgv.Columns.Add(CC1);

            var CC2 = new DataGridViewComboBoxColumn();
            CC2.Name = "CC2";
            CC2.HeaderText = "مركز 2";
            CC2.DataPropertyName = "CC2";
            CC2.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            CC2.Width = 130;
            CC2.Visible = false;
            CC2.FlatStyle = FlatStyle.Popup;
            //CC2.DataSource = Main.ds.Tables[3];
            CC2.ValueMember = "CC_ID";
            CC2.DisplayMember = "CC_Name";
            dgv.Columns.Add(CC2);

            var Branche = new DataGridViewComboBoxColumn();
            Branche.Name = "Branche";
            Branche.HeaderText = "الفرع";
            Branche.DataPropertyName = "Branche";
            Branche.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Branche.Width = 130;
            Branche.Visible = false;
            Branche.FlatStyle = FlatStyle.Popup;
            //Branche.DataSource = Main.ds.Tables[1];
            Branche.ValueMember = "Branche_ID";
            Branche.DisplayMember = "Branche_Name";
            dgv.Columns.Add(Branche);
            #endregion
        }

        #region Pro
        private DataTable table(int t)
        {
            DataTable dt = new DataTable();
            foreach (DataGridViewColumn col in dgv.Columns)
            {
                dt.Columns.Add(col.Name);
            }

            foreach (DataGridViewRow row in dgv.Rows)
            {
                DataRow dRow = dt.NewRow();
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value == null) { dRow[cell.ColumnIndex] = null; }
                    else if (cell.Value.ToString() == "") { dRow[cell.ColumnIndex] = null; }
                    else { dRow[cell.ColumnIndex] = cell.Value; }
                }
                dt.Rows.Add(dRow);
            }
            return dt;
        }
        void calc_Total()
        {
            decimal d = 0;
            decimal c = 0;
            foreach (DataGridViewRow r in dgv.Rows)
            {
                d += Convert.ToDecimal(r.Cells["Debit"].Value);
                c += Convert.ToDecimal(r.Cells["Credit"].Value);
            }
            txt_TotalDebit.Text = d.ToString();
            txt_TotalCredit.Text = c.ToString();
        }
        private DataTable table()
        {
            DataTable dt = new DataTable();
            foreach (DataGridViewColumn col in dgv.Columns)
            {
                dt.Columns.Add(col.HeaderText);
            }

            foreach (DataGridViewRow row in dgv.Rows)
            {
                DataRow dRow = dt.NewRow();
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if(cell.Value == null)
                    {
                        { dRow[cell.ColumnIndex] = null; }
                    }
                    else if (cell.Value.ToString() == "") { dRow[cell.ColumnIndex] = null; }
                    else { dRow[cell.ColumnIndex] = cell.Value; }
                }
                dt.Rows.Add(dRow);
            }

            dt.Columns.Remove("أسم الحساب");
            return dt;
        }
        void Form_Mode(string mode)
        {
            switch (mode)
            {
                #region Select
                case "Select":

                    st_jor = jor.Select();
                    if (st_jor.Tables[0].Rows.Count == 0) return;

                    Tag = "Select";

                    btn_New.Visible = true;
                    btn_Edit.Visible = true;
                    btn_Save.Visible = false;
                    btn_Delete.Visible = true;
                    btn_Cancel.Visible = false;

                    txt_Date.ReadOnly = true;
                    dtp_Date.Enabled = false;
                    com_JorType.Enabled = false;
                    txt_Notes.ReadOnly = true;
                    grbx_Add.Visible = false;

                    txt_ID.Text = st_jor.Tables[0].Rows[0]["ID"].ToString();
                    txt_Date.Text = Convert.ToDateTime(st_jor.Tables[0].Rows[0]["Date"]).ToString("dd/MM/yyyy");
                    com_JorType.SelectedValue = st_jor.Tables[0].Rows[0]["JorTypeID"];
                    com_RefType.SelectedValue = st_jor.Tables[0].Rows[0]["RefTypeID"];
                    btn_RefID.Text = st_jor.Tables[0].Rows[0]["RefNo"].ToString();
                    txt_Notes.Text = st_jor.Tables[0].Rows[0]["Notes"].ToString();

                    if (com_RefType.SelectedValue != null)
                    {
                        lbl_RefType.Visible = true;
                        lbl_RefID.Visible = true;
                        com_RefType.Visible = true;
                        btn_RefID.Visible = true;
                    }
                    else
                    {
                        lbl_RefType.Visible = false;
                        lbl_RefID.Visible = false;
                        com_RefType.Visible = false;
                        btn_RefID.Visible = false;
                    }

                    dgv.DataSource = st_jor.Tables[1];
                    calc_Total();

                    dgv.AllowUserToDeleteRows = false;


                    if (dgv.SelectedRows.Count > 0) { dgv.SelectedRows[0].Selected = false; }

                    EmptyZero();

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

                    txt_Date.ReadOnly = false;
                    dtp_Date.Enabled = true;
                    com_JorType.Enabled = true;
                    txt_Notes.ReadOnly = false;
                    grbx_Add.Visible = true;

                    txt_ID.Text = "";
                    txt_Date.Text = DateTime.Today.ToString("dd/MM/yyyy");
                    txt_Notes.Text = "";
                    com_JorType.SelectedIndex = 0;

                    com_RefType.SelectedValue = -1;
                    lbl_RefType.Visible = false;
                    lbl_RefID.Visible = false;
                    com_RefType.Visible = false;
                    btn_RefID.Visible = false;

                    txt_TotalDebit.Text = "";
                    txt_TotalCredit.Text = "";
                    txt_Notes.Focus();

                    dgv.DataSource = null;
                    dgv.Rows.Clear();
                    dgv.AllowUserToDeleteRows = true;
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

                    txt_Date.ReadOnly = false;
                    dtp_Date.Enabled = true;
                    com_JorType.Enabled = true;
                    txt_Notes.ReadOnly = false;
                    grbx_Add.Visible = true;

                    dgv.DataSource = null;
                    dgv.Rows.Clear();
                    dgv.AllowUserToDeleteRows = true;

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

                    txt_Date.ReadOnly = true;
                    dtp_Date.Enabled = false;
                    com_JorType.Enabled = false;
                    txt_Notes.ReadOnly = true;
                    grbx_Add.Visible = false;

                    dgv.DataSource = null;
                    dgv.Rows.Clear();

                    txt_ID.Text = "";
                    txt_Date.Text = "";
                    txt_Notes.Text = "";
                    com_JorType.SelectedValue = -1;

                    com_JorType.SelectedValue = -1;
                    com_RefType.SelectedValue = -1;
                    lbl_RefType.Visible = false;
                    lbl_RefID.Visible = false;
                    com_RefType.Visible = false;
                    btn_RefID.Visible = false;

                    txt_TotalDebit.Text = "";
                    txt_TotalCredit.Text = "";
                    break;
                    #endregion
            }
        }
        void var()
        {
            jor.xID = (txt_ID.Text == "") ? "0" : txt_ID.Text;
            jor.Date = DateTime.ParseExact(txt_Date.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            jor.Notes = txt_Notes.Text;
            jor.JorTypeID = Convert.ToInt32(com_JorType.SelectedValue);
            jor.UserID = UserID;
            jor.JorD = table();
        }
        void EmptyZero()
        {
            foreach (DataGridViewRow r in dgv.Rows)
            {
                for (int i = 0; i < 2; i++)
                {
                    if (Convert.ToDecimal(r.Cells[i].Value) == 0) { r.Cells[i].Style.ForeColor = Color.Transparent; }
                }
            }
        }
        #endregion

        #region Form
        private void frm_OpenStock_Shown(object sender, EventArgs e)
        {
            if (txt_ID.Text != "")
            {
                jor.nav = "Select";
                jor.ID = txt_ID.Text;

                Form_Mode("Select");
            }
            else
            {
                Form_Mode("Empty");
            }
        }
        #endregion

        #region Controls
        #region btn display
        private void btn_New_MouseLeave(object sender, EventArgs e)
        {
            btn_New.FlatStyle = FlatStyle.Flat;
        }
        private void btn_New_MouseEnter(object sender, EventArgs e)
        {
            btn_New.FlatStyle = FlatStyle.Popup;
        }
        private void btn_Edit_MouseEnter(object sender, EventArgs e)
        {
            btn_Edit.FlatStyle = FlatStyle.Popup;
        }
        private void btn_Edit_MouseLeave(object sender, EventArgs e)
        {
            btn_Edit.FlatStyle = FlatStyle.Flat;
        }
        private void btn_Save_MouseEnter(object sender, EventArgs e)
        {
            btn_Save.FlatStyle = FlatStyle.Popup;
        }

        private void btn_Save_MouseLeave(object sender, EventArgs e)
        {
            btn_Save.FlatStyle = FlatStyle.Flat;
        }
        private void btn_Delete_MouseEnter(object sender, EventArgs e)
        {
            btn_Delete.FlatStyle = FlatStyle.Popup;
        }
        private void btn_Delete_MouseLeave(object sender, EventArgs e)
        {
            btn_Delete.FlatStyle = FlatStyle.Flat;
        }
        private void btn_Cancel_MouseEnter(object sender, EventArgs e)
        {
            btn_Cancel.FlatStyle = FlatStyle.Popup;
        }
        private void btn_Cancel_MouseLeave(object sender, EventArgs e)
        {
            btn_Cancel.FlatStyle = FlatStyle.Flat;
        }
        #endregion
        private void btn_New_Click(object sender, EventArgs e)
        {
            Form_Mode("New");
        }
        private void btn_Edit_Click(object sender, EventArgs e)
        {
            if(com_RefType.Visible)
            {
                MessageBox.Show("لا يمكن التعديل على قيد له مرجع");
                return;
            }

            if (Tag.ToString() == "Select")
            {
                Temp_dgv = table(1);
                Form_Mode("Edit");

                foreach (DataRow row in Temp_dgv.Rows)
                {
                    dgv.Rows.Add();
                    dgv.CurrentCell = dgv.Rows[dgv.Rows.Count - 1].Cells[0];

                    dgv.CurrentRow.Cells["Debit"].Value = row["Debit"].ToString();
                    dgv.CurrentRow.Cells["Credit"].Value = row["Credit"].ToString();
                    dgv.CurrentRow.Cells["ACCName"].Value = row["ACCName"].ToString();
                    dgv.CurrentRow.Cells["ACCID"].Value = row["ACCID"].ToString();
                    dgv.CurrentRow.Cells["Notes"].Value = row["Notes"].ToString();
                }

            }
        }
        private void btn_Save_Click(object sender, EventArgs e)
        {
            #region Validations
            if (txt_Date.Text.Trim() == "")
            {
                MessageBox.Show("يجب إدخال التاريخ");
                dtp_Date.Select();
                SendKeys.Send("%{DOWN}");
                return;
            }
            if (dgv.RowCount == 0)
            {
                MessageBox.Show("يجب إدخال القيد");
                btn_Add_Click(null, null);
                return;
            }
            if(Convert.ToDecimal(txt_TotalDebit.Text) != Convert.ToDecimal(txt_TotalCredit.Text))
            {
                MessageBox.Show("يجب أن يتساوى إجمالي المدين مع إجمالي الدائن");
                return;
            }
            #endregion

            var();

            #region New
            if (Tag.ToString() == "New")
            {
                string t = jor.Insert();
                if (t.Length > 2)
                {
                    if (t.Substring(0, 3) == "SQL")
                    {
                        MessageBox.Show(t);
                        return;
                    }
                }
                jor.xID = t;
                jor.nav = "Search";
                Form_Mode("Select");
            }
            #endregion

            #region Edit
            else if (Tag.ToString() == "Edit")
            {
                string t = jor.Update();
                if (t.Length > 2)
                {
                    if (t.Substring(0, 3) == "SQL")
                    {
                        MessageBox.Show(t);
                        return;
                    }
                }
                jor.xID = t;
                jor.nav = "Search";
                Form_Mode("Select");
            }
            #endregion
        }
        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (com_JorType.SelectedIndex != 0)
            {
                MessageBox.Show("لا يمكن حذف قيد له مرجع");
                return;
            }
            if (DialogResult.Yes == MessageBox.Show("هل تريد بالفعل حذف السند ؟", "تأكيد الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                jor.xID = txt_ID.Text;
                string t = jor.Delete();
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
        private void btn_RefID_Click(object sender, EventArgs e)
        {
            if (btn_RefID.Text == "") return;
            switch (com_RefType.SelectedValue.ToString())
            {
                case "5":
                    PL.Pur.frm_Pur2 pur = new Pur.frm_Pur2();
                    pur.txt_ID.Text = btn_RefID.Text;
                    pur.Show();
                    break;
            }
        }
        private void btn_Add_Click(object sender, EventArgs e)
        {
            add.dgv = dgv;
            add.txt_TotalDebit = txt_TotalDebit;
            add.txt_TotalCredit = txt_TotalCredit;

            add.Text = "إضافة";
            add.btn_Add.Text = "+ إضافة";

            add.txt_Debit.Text = "";
            add.txt_Credit.Text = "";
            add.com_Acc.SelectedValue = -1;
            add.txt_Notes.Text = "";

            add.Location = new Point(Location.X + ((Width / 2) - add.Width / 2), Location.Y + 120);
            add.ShowDialog();
        }
        private void dtp_BirthDate_ValueChanged(object sender, EventArgs e)
        {
            txt_Date.Text = dtp_Date.Value.ToString("dd/MM/yyyy");
        }
        #endregion

        #region dgv
        private void dgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Tag.ToString() != "New" & Tag.ToString() != "Edit") { return; }

            add.edit = true;
            add.dgv = dgv;
            add.txt_TotalDebit = txt_TotalDebit;
            add.txt_TotalCredit = txt_TotalCredit;

            add.Text = "تعديل";
            add.btn_Add.Text = "تعديل";

            add.rowindex = e.RowIndex;
            add.txt_Debit.Text = dgv.Rows[e.RowIndex].Cells["Debit"].Value.ToString();
            add.txt_Credit.Text = dgv.Rows[e.RowIndex].Cells["Credit"].Value.ToString();
            add.com_Acc.SelectedValue = dgv.Rows[e.RowIndex].Cells["ACCID"].Value;
            add.txt_Notes.Text = dgv.Rows[e.RowIndex].Cells["Notes"].Value.ToString();

            add.Location = new Point(Location.X + ((Width / 2) - add.Width / 2), Location.Y + 120);
            add.ShowDialog();
            calc_Total();
        }
        private void dgv_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            calc_Total();
        }
        #endregion

        #region Navigation

        #region display
        private void button_First_MouseEnter(object sender, EventArgs e)
        {
            button_First.FlatStyle = FlatStyle.Popup;
        }
        private void button_First_MouseLeave(object sender, EventArgs e)
        {
            button_First.FlatStyle = FlatStyle.Flat;
        }
        private void button_Prev_MouseEnter(object sender, EventArgs e)
        {
            button_Prev.FlatStyle = FlatStyle.Popup;
        }
        private void button_Prev_MouseLeave(object sender, EventArgs e)
        {
            button_Prev.FlatStyle = FlatStyle.Flat;
        }
        private void button_Next_MouseEnter(object sender, EventArgs e)
        {
            button_Next.FlatStyle = FlatStyle.Popup;
        }
        private void button_Next_MouseLeave(object sender, EventArgs e)
        {
            button_Next.FlatStyle = FlatStyle.Flat;
        }
        private void button_Last_MouseEnter(object sender, EventArgs e)
        {
            button_Last.FlatStyle = FlatStyle.Popup;
        }
        private void button_Last_MouseLeave(object sender, EventArgs e)
        {
            button_Last.FlatStyle = FlatStyle.Flat;
        }
        private void textBox_Search_MouseEnter(object sender, EventArgs e)
        {
            if (txt_Search.Text == "Search")
            {
                txt_Search.ForeColor = Color.CadetBlue;
                txt_Search.Font = new Font(txt_Search.Font, FontStyle.Bold);
            }
        }
        private void textBox_Search_MouseLeave(object sender, EventArgs e)
        {
            if (txt_Search.Text == "Search")
            {
                txt_Search.ForeColor = Color.Silver;
                txt_Search.Font = new Font(txt_Search.Font, FontStyle.Regular);
            }
        }
        private void textBox_Search_Enter(object sender, EventArgs e)
        {
            txt_Search.Text = "";
            txt_Search.ForeColor = Color.Black;
        }
        private void textBox_Search_Leave(object sender, EventArgs e)
        {
            txt_Search.Text = "Search";
            txt_Search.ForeColor = Color.Silver;
        }
        #endregion

        private void button_First_Click(object sender, EventArgs e)
        {
            jor.nav = "First";
            jor.BrancheID = "001";

            Form_Mode("Select");
        }
        private void button_Prev_Click(object sender, EventArgs e)
        {
            jor.nav = "Prev";
            if (txt_ID.Text != "")
            {
                jor.xID = txt_ID.Text.Substring(6);
                jor.BrancheID = txt_ID.Text.Substring(0,3);
                jor.yy = txt_ID.Text.Substring(3, 2);
            }
            else
            {
                jor.xID = "0";
            }

            Form_Mode("Select");
        }
        private void button_Next_Click(object sender, EventArgs e)
        {
            jor.nav = "Next";
            if (txt_ID.Text != "")
            {
                jor.xID = txt_ID.Text.Substring(6);
                jor.BrancheID = txt_ID.Text.Substring(0, 3);
                jor.yy = txt_ID.Text.Substring(3, 2);
            }
            else
            {
                jor.xID = "0";
            }

            Form_Mode("Select");
        }
        private void button_Last_Click(object sender, EventArgs e)
        {
            jor.nav = "Last";
            jor.BrancheID = "001";

            Form_Mode("Select");
        }
        private void textBox_Search_KeyPress(object sender, KeyPressEventArgs e)
        {
            // only numbers
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                if (e.KeyChar != 043) { System.Media.SystemSounds.Hand.Play(); }
            }

            if (e.KeyChar == 13 && txt_Search.Text.Trim() != "")
            {
                jor.xID = txt_Search.Text.Trim();
                jor.nav = "Search";
                Form_Mode("Select");
            }
        }
        #endregion
    }
}
