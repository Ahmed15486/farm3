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
    public partial class frm_StoreWithdraw : Form
    {
        #region Declarations
        public int UserID;
        BL.BL.G g = new BL.BL.G();
        DataTable dt_Units = new DataTable();
        BL.BL.SW sw = new BL.BL.SW();
        DataSet st = new DataSet();
        DataTable Temp_dgv = new DataTable();
        DataTable dt_SupItems = new DataTable();
        public PL.G.frm_Main frm_Main;
        #endregion

        public frm_StoreWithdraw()
        {
            InitializeComponent();

            com_Item2.DataSource = g.Select2("Select * From Items2 Where Parent = 0");
            com_User.DataSource = g.Select2("Select * From Users");
            //com_Item.DataSource = g.Select2("Select * From Items Where Parent = 1");
            com_Cat.DataSource = g.Select2("Select * From Cat");
            com_Farm.DataSource = g.Select2("Select * From Farm");
            com_Type.DataSource = g.Select2("Select * From ItemType");

            dgv.AutoGenerateColumns = false;

            #region dgv Fildes
            var choice = new DataGridViewCheckBoxColumn();
            choice.Name = "choice";
            choice.DataPropertyName = "choice";
            choice.HeaderText = "";
            choice.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            choice.Width = 50;
            dgv.Columns.Add(choice);

            var Item_ID = new DataGridViewTextBoxColumn();
            Item_ID.Name = "ID";
            Item_ID.DataPropertyName = "ItemsID";
            Item_ID.HeaderText = "كود المنتج";
            Item_ID.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Item_ID.Width = 130;
            dgv.Columns.Add(Item_ID);

            var Item_NO = new DataGridViewTextBoxColumn();
            Item_NO.Name = "No";
            Item_NO.DataPropertyName = "No";
            Item_NO.HeaderText = "رقم المنتج";
            Item_NO.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Item_NO.Width = 130;
            dgv.Columns.Add(Item_NO);

            var Item_Name = new DataGridViewTextBoxColumn();
            Item_Name.Name = "Name";
            Item_Name.DataPropertyName = "Name";
            Item_Name.HeaderText = "أسم المنتج";
            Item_Name.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Item_Name.Width = 130;
            dgv.Columns.Add(Item_Name);

            var Item_Quan = new DataGridViewTextBoxColumn();
            Item_Quan.Name = "Quan";
            Item_Quan.HeaderText = "الكمية";
            Item_Quan.DataPropertyName = "Quan";
            Item_Quan.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Item_Quan.Width = 100;
            Item_Quan.Visible = true;
            dgv.Columns.Add(Item_Quan);

            var PPrice = new DataGridViewTextBoxColumn();
            PPrice.Name = "CPrice";
            PPrice.HeaderText = "التكلفة";
            PPrice.DataPropertyName = "CPrice";
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
            foreach (DataGridViewRow r in dgv.Rows)
            {
                t += Convert.ToDecimal(r.Cells["Total"].Value);
            }
            txt_TotalCost.Text = t.ToString();
            txt_TotalCount.Text = dgv.RowCount.ToString();
        }
        private DataTable SWD()
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
                    if (cell.Value != null)
                    {
                        if (cell.Value.ToString() == "") { dRow[cell.ColumnIndex] = null; }
                        else { dRow[cell.ColumnIndex] = cell.Value; }
                    }
                }
                dt.Rows.Add(dRow);
            }
            dt.Columns.Remove("choice");
            dt.Columns.Remove("Name");
            dt.Columns.Remove("No");
            dt.Columns.Remove("Total");

            return dt;
        }
        void Form_Mode(string mode)
        {
            switch (mode)
            {
                #region Select
                case "Select":

                    st = sw.Select();
                    if (st.Tables[0].Rows.Count == 0) return;

                    Tag = "Select";

                    btn_New.Visible = true;
                    btn_Edit.Visible = true;
                    btn_Save.Visible = false;
                    btn_Delete.Visible = true;
                    btn_Cancel.Visible = false;

                    txt_Date.ReadOnly = true;
                    dtp_Date.Enabled = false;
                    com_Item2.Enabled = false;
                    txt_Quan.ReadOnly = true;
                    com_Cat.Enabled = false;
                    com_Farm.Enabled = false;
                    com_Type.Enabled = false;
                    txt_Notes.ReadOnly = true;
                    btn_Cat_Del.Visible = false;
                    btn_Farm_Del.Visible = false;
                    btn_Type_Del.Visible = false;
                    btn_Distribute.Visible = false;
                    btn_SelectAll.Visible = false;
                    btn_CancelAll.Visible = false;
                    btn_dgvrowdel.Visible = false;

                    txt_ID.Text = st.Tables[0].Rows[0]["ID"].ToString();
                    com_Item2.SelectedValue = st.Tables[0].Rows[0]["Items2ID"];
                    txt_Quan.Text = st.Tables[0].Rows[0]["Quan"].ToString();
                    com_User.SelectedValue = st.Tables[0].Rows[0]["UserID"];
                    txt_Date.Text = Convert.ToDateTime(st.Tables[0].Rows[0]["Date"]).ToString("dd/MM/yyyy");
                    com_Cat.SelectedValue = st.Tables[0].Rows[0]["CatID"];
                    com_Farm.SelectedValue = st.Tables[0].Rows[0]["FarmID"];
                    com_Type.SelectedValue = st.Tables[0].Rows[0]["TypeID"];
                    txt_Notes.Text = st.Tables[0].Rows[0]["Notes"].ToString();


                    dgv.Rows.Clear();
                    foreach (DataRow r in st.Tables[1].Rows)
                    {
                        dgv.Rows.Add(false, r["ItemsID"], r["No"], r["Name"], r["Quan"], r["CPrice"], r["Total"]);
                    }

                    calc_Total();

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
                    com_Item2.Enabled = true;
                    txt_Quan.ReadOnly = false;
                    //com_Item.Enabled = true;
                    com_Cat.Enabled = true;
                    com_Farm.Enabled = true;
                    com_Type.Enabled = true;
                    txt_Notes.ReadOnly = false;
                    btn_Cat_Del.Visible = true;
                    btn_Farm_Del.Visible = true;
                    btn_Type_Del.Visible = true;
                    btn_Distribute.Visible = true;
                    btn_SelectAll.Visible = true;
                    btn_CancelAll.Visible = true;
                    btn_dgvrowdel.Visible = true;

                    txt_ID.Text = "";
                    com_Item2.SelectedValue = -1;
                    txt_Quan.Text = "";
                    com_User.SelectedValue = -1;
                    txt_Date.Text = DateTime.Today.ToString("dd/MM/yyyy"); 
                    //com_Item.SelectedValue = -1;
                    com_Cat.SelectedValue = -1;
                    com_Farm.SelectedValue = -1;
                    com_Type.SelectedValue = -1;
                    txt_Notes.Text = "";
                    txt_TotalCount.Text = "";
                    txt_TotalCost.Text = "";
                    txt_Notes.Focus();

                    dgv.Rows.Clear();

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
                    com_Item2.Enabled = true;
                    txt_Quan.ReadOnly = false;
                    //com_Item.Enabled = true;
                    com_Cat.Enabled = true;
                    com_Farm.Enabled = true;
                    com_Type.Enabled = true;
                    txt_Notes.ReadOnly = false;
                    btn_Cat_Del.Visible = true;
                    btn_Farm_Del.Visible = true;
                    btn_Type_Del.Visible = true;
                    btn_Distribute.Visible = true;
                    btn_SelectAll.Visible = true;
                    btn_CancelAll.Visible = true;
                    btn_dgvrowdel.Visible = true;

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
                    com_Item2.Enabled = false;
                    txt_Quan.ReadOnly = true;
                    //com_Item.Enabled = false;
                    com_Cat.Enabled = false;
                    com_Farm.Enabled = false;
                    com_Type.Enabled = false;
                    txt_Notes.ReadOnly = true;
                    btn_Cat_Del.Visible = false;
                    btn_Farm_Del.Visible = false;
                    btn_Type_Del.Visible = false;
                    btn_Distribute.Visible = false;
                    btn_SelectAll.Visible = false;
                    btn_CancelAll.Visible = false;
                    btn_dgvrowdel.Visible = false;

                    dgv.Rows.Clear();

                    txt_ID.Text = "";
                    com_Item2.SelectedValue = -1;
                    txt_Quan.Text = "";
                    com_User.SelectedValue = -1;
                    txt_Date.Text = "";
                    //com_Item.SelectedValue = -1;
                    com_Cat.SelectedValue = -1;
                    com_Farm.SelectedValue = -1;
                    com_Type.SelectedValue = -1;
                    txt_Notes.Text = "";
                    txt_TotalCount.Text = "";
                    txt_TotalCost.Text = "";

                    break;

                    #endregion
            }
        }

        void var()
        {
            sw.ID = (txt_ID.Text == "") ? "" : txt_ID.Text;
            sw.Items2ID = com_Item2.SelectedValue.ToString();
            sw.Quan = Convert.ToDecimal(txt_Quan.Text);
            sw.UserID = UserID;
            sw.Date = DateTime .ParseExact(txt_Date.Text, "dd/MM/yyyy", null);
            sw.CatID = (com_Cat.SelectedValue == null)? 0 : Convert.ToInt32(com_Cat.SelectedValue);
            sw.FarmID = (com_Farm.SelectedValue == null) ? 0 : Convert.ToInt32(com_Farm.SelectedValue);
            sw.TypeID = (com_Type.SelectedValue == null) ? 0 : Convert.ToInt32(com_Type.SelectedValue);
            sw.Notes = txt_Notes.Text;      
            sw.SWD = SWD();
        }
        void EmptyZero()
        {
            foreach (DataGridViewRow r in dgv.Rows)
            {
                foreach (DataGridViewCell c in r.Cells)
                {
                    if (c.ColumnIndex > 3)
                    {
                        if (Convert.ToDecimal(c.Value) == 0) { c.Style.ForeColor = Color.Transparent; }
                    }
                }
            }
        }
        #endregion

        #region Form
        private void frm_SW_Shown(object sender, EventArgs e)
        {
            if (txt_ID.Text != "")
            {
                sw.ID = txt_ID.Text;
                sw.nav = -1;
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
                //Temp_dgv = table(1);
                Form_Mode("Edit");

                //foreach (DataRow row in Temp_dgv.Rows)
                //{
                //    dgv.Rows.Add();
                //    dgv.CurrentCell = dgv.Rows[dgv.Rows.Count - 1].Cells[0];

                //    dgv.CurrentRow.Cells["ID"].Value = row["ID"].ToString();
                //    dgv.CurrentRow.Cells["Name"].Value = row["Name"].ToString();
                //    dgv.CurrentRow.Cells["Quan"].Value = row["Quan"].ToString();
                //    dgv.CurrentRow.Cells["CPrice"].Value = row["CPrice"].ToString();
                //    dgv.CurrentRow.Cells["Total"].Value = row["Total"].ToString();
                //}

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
            if (com_Item2.SelectedValue == null)
            {
                MessageBox.Show("يجب تحديد الصنف");
                com_Item2.DroppedDown = true;
                return;
            }
            if (txt_Quan.Text.Trim() == "")
            {
                MessageBox.Show("يجب إدخال الكمية");
                txt_Quan.Focus();
                return;
            }
            //if (com_Item.SelectedValue == null)
            //{
            //    MessageBox.Show("يجب تحديد المنتج");
            //    com_Item2.DroppedDown = true;
            //    return;
            //}
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
                string t = sw.Insert();
                if (t.Length > 2)
                {
                    if (t.Substring(0, 3) == "SQL")
                    {
                        MessageBox.Show(t.Substring(6));
                        return;
                    }
                }
                sw.ID = t;
                sw.nav = -1;
                Form_Mode("Select");
            }
            #endregion

            #region Edit
            else if (Tag.ToString() == "Edit")
            {
                string t = sw.Update();
                if (t.Length > 2)
                {
                    if (t.Substring(0, 3) == "SQL")
                    {
                        MessageBox.Show(t);
                        return;
                    }
                }
                sw.ID = t;
                sw.nav = -1;
                Form_Mode("Select");
            }
            #endregion

            frm_Main.FillChart();
        }
        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("هل تريد بالفعل حذف السند ؟", "تأكيد الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                sw.ID = txt_ID.Text;
                string t = sw.Delete();
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
        private void dtp_Date_ValueChanged(object sender, EventArgs e)
        {
            txt_Date.Text = dtp_Date.Value.ToString("dd/MM/yyyy");
        }
        private void btn_Distribute_Click(object sender, EventArgs e)
        {
            #region Validations
            if(com_Item2.SelectedValue == null)
            {
                MessageBox.Show("يجب اختيار الصنف");
                com_Item2.DroppedDown = true;
                return;
            }
            if(txt_Quan.Text == "")
            {
                MessageBox.Show("يجب إدخال الكمية");
                txt_Quan.Focus();
                return;
            }
            //if (com_Item.SelectedValue == null)
            //{
            //    MessageBox.Show("يجب اختيار المنتج");
            //    com_Item.DroppedDown = true;
            //    return;
            //}
            #endregion

            #region WHERE
            string Where = " Where (Parent = 0) and (ParentID is not null) and (Sold = 0) and (Dead = 0)"; 
            if (com_Cat.SelectedValue != null) Where += " and Cat = " + com_Cat.SelectedValue.ToString();
            if (com_Farm.SelectedValue != null) Where += " and Farm = " + com_Farm.SelectedValue.ToString();
            if (com_Type.SelectedValue != null) Where += " and ItemType = " + com_Type.SelectedValue.ToString();
            #endregion

            dgv.Rows.Clear();

            dt_SupItems = g.Select2("Select ID,No,Name From Items" + Where );
            if (dt_SupItems.Rows.Count == 0) return;

            dt_SupItems.Columns.Add("Quan");
            dt_SupItems.Columns.Add("CPrice");
            dt_SupItems.Columns.Add("Total");

            decimal q = Math.Round(Convert.ToDecimal(txt_Quan.Text.Trim()) / dt_SupItems.Rows.Count,2);
            decimal c = (decimal)g.Select2("Select CPrice From Items2 Where ID = " + com_Item2.SelectedValue.ToString()).Rows[0][0];
            decimal t = q * c;

            foreach (DataRow r in dt_SupItems.Rows)
            {
                r["Quan"] = q;
                r["CPrice"] = c;
                r["Total"] = t;

                dgv.Rows.Add(false, r["ID"], r["No"], r["Name"], q, c, t);
            }
            if (dgv.SelectedRows.Count > 0) { dgv.SelectedRows[0].Selected = false; }

            decimal d = Convert.ToDecimal(txt_Quan.Text.Trim()) - q * dt_SupItems.Rows.Count;

            dgv.Rows[dgv.RowCount - 1].Cells[4].Value = Convert.ToDecimal(dgv.Rows[dgv.RowCount - 1].Cells[4].Value) + d;
            decimal total_last_record = Convert.ToDecimal(dgv.Rows[dgv.RowCount - 1].Cells[4].Value) * Convert.ToDecimal(dgv.Rows[dgv.RowCount - 1].Cells[5].Value);

            dgv.Rows[dgv.RowCount - 1].Cells[6].Value = total_last_record;

            txt_TotalCount.Text = dgv.RowCount.ToString();
            txt_TotalCost.Text = ((t * (dgv.RowCount - 1)) + total_last_record).ToString();
        }
        private void btn_SelectAll_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow r in dgv.Rows)
            {
                r.Cells["choice"].Value = true;
                r.DefaultCellStyle.BackColor = System.Drawing.ColorTranslator.FromHtml("#ACCBC6");
            }
        }
        private void btn_CancelAll_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow r in dgv.Rows)
            {
                r.Cells["choice"].Value = false;
                r.DefaultCellStyle.BackColor = Color.White;
            }
        }
        private void btn_dgvrowdel_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgv.Rows.Count; i++)
            {
                if (Convert.ToBoolean(dgv.Rows[i].Cells["choice"].Value) == true)
                {
                    dgv.Rows.RemoveAt(i);
                    i--;
                }
            }

            if(dgv.RowCount > 0)
            {
                decimal Quan = Math.Round(Convert.ToDecimal(txt_Quan.Text.Trim()) / dgv.RowCount, 2);
                decimal Cost = Convert.ToDecimal(dgv.Rows[0].Cells["CPrice"].Value);
                decimal Total = Quan * Cost;

                foreach (DataGridViewRow r in dgv.Rows)
                {
                    r.Cells["Quan"].Value = Quan;
                    r.Cells["Total"].Value = Total;
                }


                decimal d = Convert.ToDecimal(txt_Quan.Text.Trim()) - (Quan * dgv.RowCount);
                dgv.Rows[dgv.RowCount - 1].Cells[4].Value = Convert.ToDecimal(dgv.Rows[dgv.RowCount - 1].Cells[4].Value) + d;
                decimal total_last_record = Convert.ToDecimal(dgv.Rows[dgv.RowCount - 1].Cells[4].Value) * Convert.ToDecimal(dgv.Rows[dgv.RowCount - 1].Cells[5].Value);
                dgv.Rows[dgv.RowCount - 1].Cells[6].Value = total_last_record;

                txt_TotalCount.Text = dgv.RowCount.ToString();
                txt_TotalCost.Text = ((Total * (dgv.RowCount - 1)) + total_last_record).ToString();
            }
            else
            {
                txt_TotalCount.Text = "0";
                txt_TotalCost.Text = "0";
            }
        }

        private void btn_Cat_Del_Click(object sender, EventArgs e)
        {
            com_Cat.SelectedValue = -1;
        }
        private void btn_Farm_Del_Click(object sender, EventArgs e)
        {
            com_Farm.SelectedValue = -1;
        }
        private void btn_Type_Del_Click(object sender, EventArgs e)
        {
            com_Type.SelectedValue = -1;
        }

        #region txt_SearchItem
        private void txt_SearchItem_Enter(object sender, EventArgs e)
        {
            txt_SearchItem.Text = "";
            txt_SearchItem.ForeColor = Color.Black;
        }
        private void txt_SearchItem_Leave(object sender, EventArgs e)
        {
            txt_SearchItem.Text = "Search";
            txt_SearchItem.ForeColor = Color.Silver;
        }
        private void txt_SearchItem_MouseEnter(object sender, EventArgs e)
        {
            if (txt_SearchItem.Text == "Search")
            {
                txt_SearchItem.ForeColor = Color.CadetBlue;
                txt_SearchItem.Font = new Font(txt_SearchItem.Font, FontStyle.Bold);
            }
        }
        private void txt_SearchItem_MouseLeave(object sender, EventArgs e)
        {
            if (txt_SearchItem.Text == "Search")
            {
                txt_SearchItem.ForeColor = Color.Silver;
                txt_SearchItem.Font = new Font(txt_SearchItem.Font, FontStyle.Regular);
            }
        }

        private void txt_SearchItem_KeyPress(object sender, KeyPressEventArgs e)
        {
            #region only numbers
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                if (e.KeyChar != 043) { System.Media.SystemSounds.Hand.Play(); }
            }
            #endregion

            if (e.KeyChar == 13 && txt_SearchItem.Text.Trim() != "")
            {
                foreach (DataGridViewRow r in dgv.Rows)
                {
                    if(r.Cells["No"].Value.ToString() == txt_SearchItem.Text)
                    {
                        dgv.CurrentCell = r.Cells["No"];
                        dgv.CurrentRow.Cells["choice"].Value = false;
                        dgv.CurrentRow.DefaultCellStyle.BackColor = Color.White;
                    }
                }
            }
        }
        #endregion
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
            sw.nav = 1;
            Form_Mode("Select");
        }
        private void button_Prev_Click(object sender, EventArgs e)
        {
            sw.ID = (txt_ID.Text == "") ? "" : txt_ID.Text;
            sw.nav = 2;
            Form_Mode("Select");
        }
        private void button_Next_Click(object sender, EventArgs e)
        {
            sw.ID = (txt_ID.Text == "") ? "" : txt_ID.Text;
            sw.nav = 3;
            Form_Mode("Select");
        }
        private void button_Last_Click(object sender, EventArgs e)
        {
            sw.nav = 4;
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
                sw.ID =  txt_Search.Text.Trim();
                sw.nav = -1;
                Form_Mode("Select");
            }
        }
        #endregion

        #region dgv
        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && btn_dgvrowdel.Visible == true)
            {
                if (Convert.ToBoolean(dgv.Rows[e.RowIndex].Cells["choice"].Value) == true)
                {
                    dgv.Rows[e.RowIndex].Cells["choice"].Value = false;
                    dgv.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
                }
                else
                {
                    dgv.Rows[e.RowIndex].Cells["choice"].Value = true;
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
