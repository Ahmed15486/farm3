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
    public partial class Tat3eemWithdraw : Form
    {
        #region Declarations
        public int UserID;
        public DataTable dt;
        BL.BL.G g = new BL.BL.G();
        public string mode;
        BL.BL.Tat3eem tat3eem = new BL.BL.Tat3eem();
        DataSet st = new DataSet();
        DataTable Temp_dgv = new DataTable();
        DataTable dt_SupItems = new DataTable();

        public PL.G.frm_Main frm_Main;
        public PL.G.frm_AlarmShow AlarmShow;
        public Label lbl_AlarmCount;
        #endregion

        public Tat3eemWithdraw()
        {
            InitializeComponent();

            com_User.DataSource = g.Select2("Select * From Users");
            dgv.AutoGenerateColumns = false;

            #region dgv Fildes
            var Item_ID = new DataGridViewTextBoxColumn();
            Item_ID.Name = "ItemsID";
            Item_ID.DataPropertyName = "ItemsID";
            Item_ID.HeaderText = "كود المنتج";
            Item_ID.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Item_ID.Width = 75;
            dgv.Columns.Add(Item_ID);

            var Item_No = new DataGridViewTextBoxColumn();
            Item_No.Name = "ItemsNo";
            Item_No.DataPropertyName = "ItemsNo";
            Item_No.HeaderText = "رقم المنتج";
            Item_No.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Item_No.Width = 75;
            dgv.Columns.Add(Item_No);

            var Item_Name = new DataGridViewTextBoxColumn();
            Item_Name.Name = "ItemsName";
            Item_Name.DataPropertyName = "ItemsName";
            Item_Name.HeaderText = "أسم المنتج";
            Item_Name.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Item_Name.Width = 130;
            dgv.Columns.Add(Item_Name);

            var Tat3eemID = new DataGridViewTextBoxColumn();
            Tat3eemID.Name = "Alarm_ID";
            Tat3eemID.DataPropertyName = "Alarm_ID";
            Tat3eemID.HeaderText = "كود التطعيم";
            Tat3eemID.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Tat3eemID.Width = 75;
            dgv.Columns.Add(Tat3eemID);

            var Tat3eemName = new DataGridViewTextBoxColumn();
            Tat3eemName.Name = "Tat3eemName";
            Tat3eemName.DataPropertyName = "Tat3eemName";
            Tat3eemName.HeaderText = "أسم التطعيم";
            Tat3eemName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Tat3eemName.Width = 130;
            dgv.Columns.Add(Tat3eemName);

            var Items2ID = new DataGridViewTextBoxColumn();
            Items2ID.Name = "Items2ID";
            Items2ID.DataPropertyName = "Items2ID";
            Items2ID.HeaderText = "كود الصنف";
            Items2ID.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Items2ID.Width = 75;
            dgv.Columns.Add(Items2ID);

            var Items2Name = new DataGridViewTextBoxColumn();
            Items2Name.Name = "Items2Name";
            Items2Name.DataPropertyName = "Items2Name";
            Items2Name.HeaderText = "أسم الصنف";
            Items2Name.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Items2Name.Width = 130;
            dgv.Columns.Add(Items2Name);

            var Item_Quan = new DataGridViewTextBoxColumn();
            Item_Quan.Name = "Quan";
            Item_Quan.HeaderText = "الكمية";
            Item_Quan.DataPropertyName = "Quan";
            Item_Quan.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Item_Quan.Width = 50;
            Item_Quan.Visible = true;
            dgv.Columns.Add(Item_Quan);

            var PPrice = new DataGridViewTextBoxColumn();
            PPrice.Name = "CPrice";
            PPrice.HeaderText = "التكلفة";
            PPrice.DataPropertyName = "CPrice";
            PPrice.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            PPrice.Width = 50;
            PPrice.Visible = true;
            dgv.Columns.Add(PPrice);

            var Items_Total = new DataGridViewTextBoxColumn();
            Items_Total.Name = "Total";
            Items_Total.HeaderText = "الإجمالي";
            Items_Total.DataPropertyName = "Total";
            Items_Total.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Items_Total.Width = 50;
            Items_Total.Visible = true;
            dgv.Columns.Add(Items_Total);

            var Tat3eemShowID = new DataGridViewTextBoxColumn();
            Tat3eemShowID.Name = "Tat3eemShowID";
            Tat3eemShowID.HeaderText = "Tat3eemShowID";
            Tat3eemShowID.DataPropertyName = "Tat3eemShowID";
            Tat3eemShowID.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Tat3eemShowID.Width = 50;
            Tat3eemShowID.Visible = false;
            dgv.Columns.Add(Tat3eemShowID);
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
                    if (cell.Value.ToString() == "") { dRow[cell.ColumnIndex] = null; }
                    else { dRow[cell.ColumnIndex] = cell.Value; }
                }
                dt.Rows.Add(dRow);
            }
            return dt;
        }
        void Form_Mode(string mode)
        {
            switch (mode)
            {
                #region Select
                case "Select":

                    st = tat3eem.Select();
                    if (st.Tables[0].Rows.Count == 0) return;

                    Tag = "Select";

                    //btn_New.Visible = true;
                    //btn_Edit.Visible = true;
                    btn_Save.Visible = false;
                    btn_Delete.Visible = true;
                    btn_Cancel.Visible = false;

                    txt_Date.ReadOnly = true;
                    dtp_Date.Enabled = false;
                    txt_Notes.ReadOnly = true;
                    grbx_Add.Visible = false;

                    txt_ID.Text = st.Tables[0].Rows[0]["ID"].ToString();
                    com_User.SelectedValue = st.Tables[0].Rows[0]["UserID"];
                    txt_Date.Text = Convert.ToDateTime(st.Tables[0].Rows[0]["Date"]).ToString("dd/MM/yyyy");
                    txt_Notes.Text = st.Tables[0].Rows[0]["Notes"].ToString();

                    dgv.DataSource = st.Tables[1];
                    calc_Total();

                    dgv.AllowUserToDeleteRows = false;
                    if (dgv.SelectedRows.Count > 0) { dgv.SelectedRows[0].Selected = false; }
                    calc_Total();

                    break;
                #endregion

                #region New
                case "New":

                    Tag = "New";

                    //btn_New.Visible = false;
                    //btn_Edit.Visible = false;
                    btn_Save.Visible = true;
                    btn_Delete.Visible = false;
                    btn_Cancel.Visible = true;

                    txt_Date.ReadOnly = false;
                    dtp_Date.Enabled = true;
                    txt_Notes.ReadOnly = false;
                    grbx_Add.Visible = true;

                    txt_ID.Text = "";
                    txt_Date.Text = DateTime.Today.ToString("dd/MM/yyyy");
                    txt_Notes.Text = "";
                    txt_TotalCount.Text = "";
                    txt_TotalCost.Text = "";
                    txt_Notes.Focus();

                    dgv.DataSource = null;
                    dgv.Rows.Clear();
                    dgv.AllowUserToDeleteRows = true;

                    break;
                #endregion

                #region Edit
                case "Edit":
                    Tag = "Edit";

                    //btn_New.Visible = false;
                    //btn_Edit.Visible = false;
                    btn_Save.Visible = true;
                    btn_Delete.Visible = false;
                    btn_Cancel.Visible = true;

                    txt_Date.ReadOnly = false;
                    dtp_Date.Enabled = true;
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
                   // btn_New.Visible = true;
                   //btn_Edit.Visible = false;
                    btn_Save.Visible = false;
                    btn_Delete.Visible = false;
                    btn_Cancel.Visible = false;

                    txt_Date.ReadOnly = true;
                    dtp_Date.Enabled = false;
                    txt_Notes.ReadOnly = true;
                    grbx_Add.Visible = false;

                    dgv.DataSource = null;

                    txt_ID.Text = "";
                    com_User.SelectedValue = -1;
                    txt_Date.Text = "";
                    txt_Notes.Text = "";
                    txt_TotalCount.Text = "";
                    txt_TotalCost.Text = "";

                    break;

                    #endregion
            }
        }
        void calc_Total()
        {
            decimal q = 0;
            decimal c = 0;
            decimal t = 0;
            foreach (DataGridViewRow r in dgv.Rows)
            {
                q = Convert.ToDecimal(r.Cells["Quan"].Value);
                c = Convert.ToDecimal(r.Cells["CPrice"].Value);
                r.Cells["Total"].Value = Math.Round(q * c, 2);
                t += Convert.ToDecimal(r.Cells["Total"].Value);
            }
            txt_TotalCost.Text = t.ToString();
            txt_TotalCount.Text = dgv.RowCount.ToString();
        }
        void var()
        {
            tat3eem.ID = (txt_ID.Text == "") ? "" : txt_ID.Text;
            tat3eem.UserID = UserID;
            tat3eem.Date = DateTime.ParseExact(txt_Date.Text.Trim(), "dd/MM/yyyy", null);
            tat3eem.Notes = txt_Notes.Text;
            tat3eem.Tat3eemD = Tat3eemD();
        }
        private DataTable Tat3eemD()
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
            dt.Columns.Remove("ItemsNo");
            dt.Columns.Remove("ItemsName");
            dt.Columns.Remove("Items2Name");
            dt.Columns.Remove("Tat3eemName");
            dt.Columns.Remove("Total");
            return dt;
        }
        #endregion

        #region Form
        private void Tat3eemWithdraw_Shown(object sender, EventArgs e)
        {
            if (mode == "New")
            {
                Form_Mode("New");
                if (dt != null)
                {
                    foreach (DataRow r in dt.Rows)
                    {
                        dgv.Rows.Add(r["ItemsID"], r["ItemsNo"], r["ItemsName"], r["AlarmID"], r["Tat3eemName"], r["Items2ID"], r["Items2Name"], r["Quan"], r["CPrice"], Math.Round((Convert.ToDecimal(r["Quan"]) * Convert.ToDecimal(r["CPrice"])), 2), r["Tat3eemShowID"]);
                    }
                    calc_Total();
                    dgv.ClearSelection();
                }
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
                    dgv.CurrentRow.Cells["Quan"].Value = row["Quan"].ToString();
                    dgv.CurrentRow.Cells["CPrice"].Value = row["CPrice"].ToString();
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
            if (dgv.RowCount == 0)
            {
                MessageBox.Show("لم يتم إستدعاء أي منتجات");
                return;
            }
            #endregion

            calc_Total();

            var();

            #region New
            if (Tag.ToString() == "New")
            {
                string t = tat3eem.Insert();
                if (t.Length > 2)
                {
                    if (t.Substring(0, 3) == "SQL")
                    {
                        MessageBox.Show(t.Substring(6), "SQL");
                        return;
                    }
                }
                tat3eem.ID = t;
                tat3eem.nav = -1;
                Form_Mode("Select");
                frm_Main.AlarmRefresh();
            }
            #endregion

            #region Edit
            else if (Tag.ToString() == "Edit")
            {
                string t = tat3eem.Update();
                if (t.Length > 2)
                {
                    if (t.Substring(0, 3) == "SQL")
                    {
                        MessageBox.Show(t.Substring(6), "SQL");
                        return;
                    }
                }
                tat3eem.ID = t;
                tat3eem.nav = -1;
                Form_Mode("Select");
                frm_Main.AlarmRefresh();
            }
            #endregion

            frm_Main.FillChart();
        }
        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("هل تريد بالفعل حذف السند ؟", "تأكيد الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                tat3eem.ID = txt_ID.Text;
                string t = tat3eem.Delete();
                if (t.Length > 2)
                {
                    if (t.Substring(0, 3) == "SQL")
                    {
                        MessageBox.Show(t.Substring(6), "SQL");
                        return;
                    }
                }
                Form_Mode("Empty");
                frm_Main.AlarmRefresh();
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
        private void dtp_Date_ValueChanged(object sender, EventArgs e)
        {
            txt_Date.Text = dtp_Date.Value.ToString("dd/MM/yyyy");
        }
        #endregion

        #region dgv
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
        private void txt_Search_MouseEnter(object sender, EventArgs e)
        {
            if (txt_Search.Text == "Search")
            {
                txt_Search.ForeColor = Color.CadetBlue;
                txt_Search.Font = new Font(txt_Search.Font, FontStyle.Bold);
            }
        }
        private void txt_Search_MouseLeave(object sender, EventArgs e)
        {
            if (txt_Search.Text == "Search")
            {
                txt_Search.ForeColor = Color.Silver;
                txt_Search.Font = new Font(txt_Search.Font, FontStyle.Regular);
            }
        }
        private void txt_Search_Enter(object sender, EventArgs e)
        {
            txt_Search.Text = "";
            txt_Search.ForeColor = Color.Black;
        }
        private void txt_Search_Leave(object sender, EventArgs e)
        {
            txt_Search.Text = "Search";
            txt_Search.ForeColor = Color.Silver;
        }
        #endregion

        private void button_First_Click(object sender, EventArgs e)
        {
            tat3eem.nav = 1;
            Form_Mode("Select");
        }
        private void button_Prev_Click(object sender, EventArgs e)
        {
            tat3eem.ID = (txt_ID.Text == "") ? "" : txt_ID.Text;
            tat3eem.nav = 2;
            Form_Mode("Select");
        }
        private void button_Next_Click(object sender, EventArgs e)
        {
            tat3eem.ID = (txt_ID.Text == "") ? "" : txt_ID.Text;
            tat3eem.nav = 3;
            Form_Mode("Select");
        }
        private void button_Last_Click(object sender, EventArgs e)
        {
            tat3eem.nav = 4;
            Form_Mode("Select");
        }
        private void txt_Search_KeyPress(object sender, KeyPressEventArgs e)
        {
            // only numbers
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                if (e.KeyChar != 043) { System.Media.SystemSounds.Hand.Play(); }
            }

            if (e.KeyChar == 13 && txt_Search.Text.Trim() != "")
            {
                tat3eem.ID =  txt_Search.Text.Trim();
                tat3eem.nav = -1;
                Form_Mode("Select");
            }
        }
        #endregion
    }
}
