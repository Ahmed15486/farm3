using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1.PL.Pur
{
    public partial class frm_Pre : Form
    {
        #region Declarations
        BL.BL.G g = new BL.BL.G();
        PL.G.frm_Search search = new G.frm_Search();
        PL.Pur.frm_PurAdd add = new PL.Pur.frm_PurAdd();
        BL.BL.Units units = new BL.BL.Units();

        DataTable Temp_dgv = new DataTable();
        BL.BL.Ven ven = new BL.BL.Ven();
        BL.BL.Pre pre = new BL.BL.Pre();
        DataTable dt_Units = new DataTable();
        DataSet st = new DataSet();
        public int UserID;
        public PL.G.frm_Main frm_Main;
        #endregion

        public frm_Pre()
        {
            InitializeComponent();

            dgv.AutoGenerateColumns = false;
            dt_Units = units.Select();
            com_PayType.DataSource = g.Select("DocPayTypes");
            com_Ven.DataSource = ven.Select();

            Form_Mode("Empty");

            #region dgv Fildes
            var Item_ID = new DataGridViewTextBoxColumn();
            Item_ID.Name = "ID";
            Item_ID.DataPropertyName = "Items2ID";
            Item_ID.HeaderText = "كود الصنف";
            Item_ID.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Item_ID.Width = 130;
            dgv.Columns.Add(Item_ID);

            var Item_Name = new DataGridViewTextBoxColumn();
            Item_Name.Name = "Name";
            Item_Name.DataPropertyName = "Name";
            Item_Name.HeaderText = "أسم الصنف";
            Item_Name.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Item_Name.Width = 130;
            dgv.Columns.Add(Item_Name);

            var Unit = new DataGridViewComboBoxColumn();
            Unit.Name = "Unit";
            Unit.DataPropertyName = "UnitID";
            Unit.DataSource = dt_Units;
            Unit.ValueMember = "ID";
            Unit.DisplayMember = "Name";
            Unit.HeaderText = "الوحدة";
            Unit.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Unit.Width = 75;
            dgv.Columns.Add(Unit);

            var Item_Quan = new DataGridViewTextBoxColumn();
            Item_Quan.Name = "Quan";
            Item_Quan.HeaderText = "الكمية";
            Item_Quan.DataPropertyName = "Quan";
            Item_Quan.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Item_Quan.Width = 100;
            Item_Quan.Visible = true;
            dgv.Columns.Add(Item_Quan);

            var PPrice = new DataGridViewTextBoxColumn();
            PPrice.Name = "PPrice";
            PPrice.HeaderText = "سعر الشراء";
            PPrice.DataPropertyName = "PPrice";
            PPrice.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            PPrice.Width = 100;
            PPrice.Visible = true;
            dgv.Columns.Add(PPrice);

            var Items_Total = new DataGridViewTextBoxColumn();
            Items_Total.Name = "Total";
            Items_Total.HeaderText = "الإجمالي";
            Items_Total.DataPropertyName = "Total";
            Items_Total.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Items_Total.Width = 100;
            Items_Total.Visible = true;
            dgv.Columns.Add(Items_Total);
            #endregion
        }

        #region Pro
        public void AddRow()
        {
            dgv.CurrentCell = dgv.Rows[dgv.Rows.Count - 1].Cells[0];

            dgv.CurrentRow.Cells["ID"].Value = add.com_Item_Name.SelectedValue.ToString();
            dgv.CurrentRow.Cells["Name"].Value = add.com_Item_Name.Text;
            dgv.CurrentRow.Cells["Unit"].Value = add.UnitID;
            dgv.CurrentRow.Cells["Quan"].Value = add.txt_Quan.Text;
            dgv.CurrentRow.Cells["PPrice"].Value = add.txt_PPrice.Text;
            dgv.CurrentRow.Cells["Total"].Value = Math.Round(Convert.ToDecimal(add.txt_Quan.Text) * Convert.ToDecimal(add.txt_PPrice.Text), 2).ToString();
            Console.Beep();
            decimal pp = Math.Round(Convert.ToDecimal((txt_TotalPPrice.Text == "") ? "0" : txt_TotalPPrice.Text), 2) + Convert.ToDecimal(dgv.CurrentRow.Cells["Total"].Value);
            txt_TotalPPrice.Text = pp.ToString();
        }
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

                    if (cell.Value.ToString() == "") { dRow[cell.ColumnIndex] = null; }
                    else { dRow[cell.ColumnIndex] = cell.Value; }
                }
                dt.Rows.Add(dRow);
            }
            return dt;
        }
        void calc_Total()
        {
            decimal t = 0;
            if (txt_DisVal.Text.Trim() == "") txt_DisVal.Text = "0";

            decimal d = Convert.ToDecimal(txt_DisVal.Text);
            foreach (DataGridViewRow r in dgv.Rows)
            {
                t += Convert.ToDecimal(r.Cells["Total"].Value);
            }
            txt_TotalPPrice.Text = t.ToString();
            txt_Net.Text = (t - d).ToString();

        }
        private DataTable IO()
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
                    if (cell.Value.ToString() == "") { dRow[cell.ColumnIndex] = null; }
                    else { dRow[cell.ColumnIndex] = cell.Value; }
                }
                dt.Rows.Add(dRow);
            }
            dt.Columns.Remove("أسم الصنف");
            dt.Columns.Remove("الإجمالي");
            return dt;
        }
        void Other_Col()
        {
            for (int i = 0; i < dgv.Rows.Count; i++)
            {
                dgv.Rows[i].Cells["Items_Total"].Value = Math.Round(Convert.ToDecimal(dgv.Rows[i].Cells["Item_Quan"].Value) * Convert.ToDecimal(dgv.Rows[i].Cells["Items_PPrice"].Value), 2);
                dgv.Rows[i].Cells["Net"].Value = Math.Round(Convert.ToDecimal(dgv.Rows[i].Cells["Items_Total"].Value) - Convert.ToDecimal(dgv.Rows[i].Cells["Items_Dis_Value"].Value), 2);
            }
        }
        void Form_Mode(string mode)
        {
            switch (mode)
            {
                #region Select
                case "Select":

                    st = pre.Select();
                    if (st.Tables[0].Rows.Count == 0) return;

                    Tag = "Select";

                    btn_New.Visible = true;
                    btn_Edit.Visible = true;
                    btn_Save.Visible = false;
                    btn_Delete.Visible = true;
                    btn_Cancel.Visible = false;

                    txt_Date.ReadOnly = true;
                    dtp_Date.Enabled = false;
                    txt_VenDocID.ReadOnly = true;
                    txt_Notes.ReadOnly = true;
                    grbx_Add.Visible = false;
                    com_PayType.Enabled = false;
                    com_Ven.Enabled = false;
                    btn_Ven_Search.Visible = false;
                    btn_Ven_Edit.Visible = false;
                    btn_Ven_Del.Visible = false;
                    txt_DisVal.ReadOnly = true;

                    txt_ID.Text = st.Tables[0].Rows[0]["ID"].ToString();
                    btn_JorID.Text = st.Tables[0].Rows[0]["JorID"].ToString();
                    txt_Date.Text = Convert.ToDateTime(st.Tables[0].Rows[0]["Date"]).ToString("dd/MM/yyyy");
                    com_PayType.SelectedValue = st.Tables[0].Rows[0]["PayTypeID"].ToString();
                    com_Ven.SelectedValue = st.Tables[0].Rows[0]["VenID"].ToString();
                    txt_VenDocID.Text = st.Tables[0].Rows[0]["VenDocID"].ToString();
                    txt_Notes.Text = st.Tables[0].Rows[0]["Notes"].ToString();
                    com_User.SelectedValue = st.Tables[0].Rows[0]["UserID"];
                    txt_DisVal.Text = st.Tables[0].Rows[0]["DisVal"].ToString();


                    dgv.DataSource = st.Tables[1];
                    calc_Total();

                    dgv.AllowUserToDeleteRows = false;

                    txt_TotalPPrice.ReadOnly = true;

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
                    txt_VenDocID.ReadOnly = false;
                    txt_Notes.ReadOnly = false;
                    com_PayType.Enabled = true;
                    com_Ven.Enabled = true;
                    btn_Ven_Search.Visible = true;
                    btn_Ven_Edit.Visible = true;
                    btn_Ven_Del.Visible = true;
                    grbx_Add.Visible = true;
                    txt_DisVal.ReadOnly = false;

                    txt_ID.Text = "";
                    btn_JorID.Text = "";
                    txt_Date.Text = DateTime.Today.ToString("dd/MM/yyyy");
                    com_PayType.SelectedIndex = 0;
                    com_Ven.SelectedValue = -1;
                    txt_VenDocID.Text = "";
                    txt_Notes.Text = "";
                    txt_TotalPPrice.Text = "";
                    txt_DisVal.Text = "";
                    txt_Net.Text = "";
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
                    txt_VenDocID.ReadOnly = false;
                    txt_Notes.ReadOnly = false;
                    grbx_Add.Visible = true;
                    com_PayType.Enabled = true;
                    com_Ven.Enabled = true;
                    btn_Ven_Search.Visible = true;
                    btn_Ven_Edit.Visible = true;
                    btn_Ven_Del.Visible = true;
                    txt_DisVal.ReadOnly = false;

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
                    txt_VenDocID.ReadOnly = true;
                    txt_Notes.ReadOnly = true;
                    grbx_Add.Visible = false;
                    com_PayType.Enabled = false;
                    com_Ven.Enabled = false;
                    btn_Ven_Search.Visible = false;
                    btn_Ven_Edit.Visible = false;
                    btn_Ven_Del.Visible = false;
                    txt_DisVal.ReadOnly = true;

                    dgv.DataSource = null;

                    com_PayType.SelectedValue = -1;
                    com_Ven.SelectedValue = -1;
                    txt_ID.Text = "";
                    btn_JorID.Text = "";
                    txt_Date.Text = "";
                    txt_VenDocID.Text = "";
                    txt_Notes.Text = "";
                    txt_TotalPPrice.Text = "";
                    txt_DisVal.Text = "";
                    txt_Net.Text = "";

                    break;

                    #endregion
            }
        }

        void var()
        {
            pre.ID = (txt_ID.Text == "") ? "" : txt_ID.Text;
            pre.Date = DateTime.ParseExact(txt_Date.Text.Trim(), "dd/MM/yyyy", null);
            pre.PayTypeID = Convert.ToInt32(com_PayType.SelectedValue);
            pre.VenID = (com_Ven.SelectedValue != null) ? com_Ven.SelectedValue.ToString() : "";
            pre.VenDocID = txt_VenDocID.Text;
            pre.Notes = txt_Notes.Text;
            pre.TotalPPrice = (txt_TotalPPrice.Text != "") ? Convert.ToDecimal(txt_TotalPPrice.Text) : 0;
            pre.DisVal = (txt_DisVal.Text.Trim() != "") ? Convert.ToDecimal(txt_DisVal.Text.Trim()) : 0;
            pre.Net = (txt_Net.Text != "") ? Convert.ToDecimal(txt_Net.Text) : 0;
            pre.UserID = UserID;
            pre.IO = IO();
        }
        void EmptyZero()
        {
            foreach (DataGridViewRow r in dgv.Rows)
            {
                foreach (DataGridViewCell c in r.Cells)
                {
                    if (c.ColumnIndex > 2)
                    {
                        if (Convert.ToDecimal(c.Value) == 0) { c.Style.ForeColor = Color.Transparent; }
                    }
                }
            }
        }
        #endregion

        #region Form
        private void frm_OpenStock_Shown(object sender, EventArgs e)
        {
            if (txt_ID.Text != "")
            {
                pre.ID = txt_ID.Text;
                pre.nav = -1;
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
            if (Tag.ToString() == "Select")
            {
                Temp_dgv = table(1);
                Form_Mode("Edit");

                foreach (DataRow row in Temp_dgv.Rows)
                {
                    dgv.Rows.Add();
                    dgv.CurrentCell = dgv.Rows[dgv.Rows.Count - 1].Cells[0];

                    dgv.CurrentRow.Cells["ID"].Value = row["ID"].ToString();
                    dgv.CurrentRow.Cells["Name"].Value = row["Name"].ToString();
                    int x = Convert.ToInt32(row["Unit"]);
                    dgv.CurrentRow.Cells["Unit"].Value = x;
                    dgv.CurrentRow.Cells["Quan"].Value = row["Quan"].ToString();
                    dgv.CurrentRow.Cells["PPrice"].Value = row["PPrice"].ToString();
                    dgv.CurrentRow.Cells["Total"].Value = row["Total"].ToString();
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
            if (com_PayType.SelectedIndex == 1 && com_Ven.SelectedValue == null)
            {
                MessageBox.Show("يجب أختيار مورد قبل حفظ الفاتورة الآجلة");
                com_Ven.DroppedDown = true;
                return;
            }
            if (dgv.RowCount == 0)
            {
                MessageBox.Show("يجب إدخال أصناف");
                btn_Add_Click(null, null);
                return;
            }
            #endregion

            calc_Total();

            var();

            #region New
            if (Tag.ToString() == "New")
            {
                string t = pre.Insert();
                if (t.Length > 2)
                {
                    if (t.Substring(0, 3) == "SQL")
                    {
                        MessageBox.Show(t);
                        return;
                    }
                }
                pre.ID = t;
                pre.nav = -1;
                Form_Mode("Select");
            }
            #endregion

            #region Edit
            else if (Tag.ToString() == "Edit")
            {
                string t = pre.Update();
                if (t.Length > 2)
                {
                    if (t.Substring(0, 3) == "SQL")
                    {
                        MessageBox.Show(t);
                        return;
                    }
                }
                pre.ID = t;
                pre.nav = -1;
                Form_Mode("Select");
            }
            #endregion

            frm_Main.FillChart();
        }
        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("هل تريد بالفعل حذف السند ؟", "تأكيد الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                pre.ID = txt_ID.Text;
                string t = pre.Delete();
                Form_Mode("Empty");
                frm_Main.FillChart();
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
        private void btn_JorID_Click(object sender, EventArgs e)
        {
            if (btn_JorID.Text == "") return;
            PL.ACC.frm_Jor jor = new ACC.frm_Jor();
            jor.txt_ID.Text = btn_JorID.Text;
            jor.Show();
        }
        private void btn_Add_Click(object sender, EventArgs e)
        {
            add.dgv = dgv;
            add.txt_TotalPPrice = txt_TotalPPrice;

            add.Text = "إضافة";
            add.btn_Add.Text = "+ إضافة";

            add.com_Item_Name.SelectedValue = -1;
            add.txt_Quan.Text = "";
            add.txt_PPrice.Text = "";

            add.Location = new Point(Location.X + ((Width / 2) - add.Width / 2), Location.Y + 120);
            add.ShowDialog();
        }
        private void dtp_BirthDate_ValueChanged(object sender, EventArgs e)
        {
            txt_Date.Text = dtp_Date.Value.ToString("dd/MM/yyyy");
        }
        private void btn_Ven_Search_Click(object sender, EventArgs e)
        {
            search.Text = "بحث عن مورد";

            search.dt = (DataTable)com_Ven.DataSource;

            search.dgv.Columns[0].DataPropertyName = "ID";
            search.dgv.Columns[1].DataPropertyName = "Name";

            search.dgv.AutoGenerateColumns = false;
            search.dgv.DataSource = search.dt;
            search.ShowDialog();

            com_Ven.Text = search.txt;
        }
        private void btn_Ven_Edit_Click(object sender, EventArgs e)
        {
            PL.Pur.frm_Ven v = new PL.Pur.frm_Ven();
            v.FormBorderStyle = FormBorderStyle.Sizable;
            v.ShowDialog();
            com_Ven.DataSource = ven.Select();
            com_Ven.SelectedValue = v.txt_ID.Text;
        }
        private void btn_Ven_Del_Click(object sender, EventArgs e)
        {
            com_Ven.SelectedValue = -1;
        }
        #endregion

        #region dgv
        private void dgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Tag.ToString() != "New" & Tag.ToString() != "Edit") { return; }

            add.edit = true;
            add.dgv = dgv;
            add.txt_TotalPPrice = txt_TotalPPrice;

            add.Text = "تعديل";
            add.btn_Add.Text = "تعديل";

            add.rowindex = e.RowIndex;
            add.com_Item_Name.SelectedValue = dgv.Rows[e.RowIndex].Cells["ID"].Value;
            add.txt_Quan.Text = dgv.Rows[e.RowIndex].Cells["Quan"].Value.ToString();
            add.txt_PPrice.Text = dgv.Rows[e.RowIndex].Cells["PPrice"].Value.ToString();

            add.Location = new Point(Location.X + ((Width / 2) - add.Width / 2), Location.Y + 120);
            add.ShowDialog();
            calc_Total();
        }
        #endregion

        #region Navigation
        int n;
        bool nav;
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
            pre.nav = 1;
            Form_Mode("Select");
        }
        private void button_Prev_Click(object sender, EventArgs e)
        {
            pre.ID = (txt_ID.Text == "") ? "" : txt_ID.Text;
            pre.nav = 2;
            Form_Mode("Select");
        }
        private void button_Next_Click(object sender, EventArgs e)
        {
            pre.ID = (txt_ID.Text == "") ? "" : txt_ID.Text;
            pre.nav = 3;
            Form_Mode("Select");
        }
        private void button_Last_Click(object sender, EventArgs e)
        {
            pre.nav = 4;
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
                pre.ID =  txt_Search.Text.Trim();
                pre.nav = -1;
                Form_Mode("Select");
            }
        }
        #endregion
    }
}
