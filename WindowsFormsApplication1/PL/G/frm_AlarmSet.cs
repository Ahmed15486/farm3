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
    public partial class frm_AlarmSet : Form
    {
        #region Declarations
        public frm_Main frm_Main;
        public int UserID;
        BL.BL.AlarmSet alarmset = new BL.BL.AlarmSet();
        BL.BL.G g = new BL.BL.G();
        DataSet ds = new DataSet();
        int RowIndex;

        public PL.G.frm_AlarmShow AlarmShow;
        public DataTable dt_Result;
        public DataTable dt_Items;
        public DataTable dt_Alarm;
        public DateTime AlarmDate;
        public Label lbl_AlarmCount;
        #endregion

        public frm_AlarmSet()
        {
            InitializeComponent();

            dgv.AutoGenerateColumns = false;
            com_Cat.DataSource = g.Select("Cat");
            Fill();
        }

        #region Pro
        void Fill()
        {
            ds = alarmset.Select();
            dgv.DataSource = ds.Tables[0];
            com_Items2.DataSource = g.Select2("Select ID,Name From Items2");
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

                    ReadonlyTextBoxes(true);
                    txt_ID.ReadOnly = true;
                    chk_WithoutItem.Enabled = false;

                    com_Items2.Enabled = false;
                    txt_Quan.ReadOnly = true;
                    btn_Items2_Add.Visible = false;
                    btn_Items2_Del.Visible = false;
                    com_Cat.Enabled = false;
                    btn_Cat_Add.Visible = false;
                    btn_Cat_Del.Visible = false;
                    chk_StartBDate.Enabled = false;
                    chk_WhenInsert.Enabled = false;
                    chk_Other.Enabled = false;
                    btn_Add.Visible = false;

                    dgv_Other.Rows.Clear();
                    foreach (DataRow r in ds.Tables[0].Rows)
                    {
                        if (r["ID"].ToString() == dgv.SelectedRows[0].Cells[0].Value.ToString())
                        {
                            txt_ID.Text = r["ID"].ToString();
                            txt_Name.Text = r["Name"].ToString();
                            chk_WithoutItem.Checked = Convert.ToBoolean(r["WithoutItem"]);
                            com_Cat.SelectedValue = r["CatID"];
                            com_Items2.SelectedValue = (r["Items2ID"] != null) ? r["Items2ID"] : -1;
                            txt_Quan.Text = (r["Quan"] != null) ? r["Quan"].ToString() : "";
                            chk_StartBDate.Checked = (bool)r["StartBDate"];
                            txt_StartDayBDate.Text = (chk_StartBDate.Checked == true) ? r["StartDayBDate"].ToString() : "";
                            chk_WhenInsert.Checked = (bool)r["WhenInsert"];
                            chk_Other.Checked = (bool)r["Other"];
                            
                            foreach (DataRow dr in ds.Tables[1].Rows)
                            {
                                if(dr["AlarmCurrent_ID"].ToString() == txt_ID.Text)
                                {
                                    dgv_Other.Rows.Add(dr["AlarmOther_ID"], dr["AlarmOther_Name"], dr["StartDays"], dr["Infinite"], dr["Count"]);
                                }
                            }
                            if (dgv_Other.SelectedRows.Count > 0) dgv_Other.SelectedRows[0].Selected = false;
                            break;
                        }
                    }

                    dgv_Other.Visible = chk_Other.Checked;
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
                    ReadonlyTextBoxes(false);
                    txt_ID.ReadOnly = true;
                    chk_WithoutItem.Enabled = true;

                    com_Items2.Enabled = true;
                    txt_Quan.ReadOnly = false;
                    btn_Items2_Add.Visible = true;
                    btn_Items2_Del.Visible = true;
                    com_Cat.Enabled = true;
                    btn_Cat_Add.Visible = true;
                    btn_Cat_Del.Visible = true;
                    chk_StartBDate.Enabled = true;
                    chk_WhenInsert.Enabled = true;
                    chk_Other.Enabled = true;

                    dgv.ClearSelection();
                    chk_WithoutItem.Checked = false;
                    ClearTextBoxes();                   
                    com_Items2.SelectedValue = -1;
                    com_Cat.SelectedValue = -1;
                    chk_WhenInsert.Checked = false;
                    chk_Other.Checked = false;
                    chk_StartBDate.Checked = false;
                    btn_Add.Visible = chk_Other.Checked;
                    dgv_Other.Rows.Clear();

                    txt_Name.Focus();
                    break;
                #endregion
                #region Edit
                case "Edit":
                    Tag = "Edit";

                    if((int)g.Select2("select count (ID) from Tat3eemShow where AlarmID = '" + txt_ID.Text + "' and (OK = 1 or Cancel = 1)").Rows[0][0] > 0)
                    {
                        com_Cat.Enabled = false;
                        btn_Cat_Add.Visible = false;
                        btn_Cat_Del.Visible = false;
                    }
                    else
                    {
                        com_Cat.Enabled = true;
                        btn_Cat_Add.Visible = true;
                        btn_Cat_Del.Visible = true;
                    }

                    btn_New.Visible = false;
                    btn_Edit.Visible = false;
                    btn_Save.Visible = true;
                    btn_Delete.Visible = false;
                    btn_Cancel.Visible = true;

                    dgv.Enabled = false;
                    dgv.Enabled = false;
                    ReadonlyTextBoxes(false);
                    txt_ID.ReadOnly = true;
                    chk_WithoutItem.Enabled = true;

                    chk_StartBDate.Enabled = true;
                    chk_WhenInsert.Enabled = true;
                    chk_Other.Enabled = true;

                    com_Items2.Enabled = true;
                    txt_Quan.ReadOnly = false;
                    btn_Items2_Add.Visible = true;
                    btn_Items2_Del.Visible = true;
                    btn_Add.Visible = chk_Other.Checked;
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

                    ReadonlyTextBoxes(true);
                    txt_ID.ReadOnly = true;
                    chk_WithoutItem.Enabled = false;

                    com_Items2.Enabled = false;
                    txt_Quan.ReadOnly = true;
                    btn_Items2_Add.Visible = false;
                    btn_Items2_Del.Visible = false;
                    com_Cat.Enabled = false;
                    btn_Cat_Add.Visible = false;
                    btn_Cat_Del.Visible = false;
                    chk_StartBDate.Enabled = false;
                    chk_WhenInsert.Enabled = false;
                    chk_Other.Enabled = false;

                    dgv.ClearSelection();
                    chk_WithoutItem.Checked = false;
                    ClearTextBoxes();
                    com_Items2.SelectedValue = -1;
                    com_Cat.SelectedValue = -1;
                    chk_StartBDate.Checked = false;
                    chk_Other.Checked = false;
                    btn_Add.Visible = chk_Other.Checked;
                    break;
                    #endregion
            }
        }
        void ReadonlyTextBoxes(bool b)
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                        (control as TextBox).ReadOnly = b;
                    else
                        func(control.Controls);
            };

            func(Controls);
        }
        void ClearTextBoxes()
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                        (control as TextBox).Clear();
                    else
                        func(control.Controls);
            };

            func(Controls);
        }
        void var()
        {
            alarmset.ID = (txt_ID.Text != "") ? Convert.ToInt32(txt_ID.Text) : 0;
            alarmset.Name = txt_Name.Text;
            alarmset.WithoutItem = chk_WithoutItem.Checked;
            alarmset.Items2ID = (com_Items2.SelectedValue != null) ? com_Items2.SelectedValue.ToString() : "";
            alarmset.CatID = (com_Cat.SelectedValue != null) ? (int)com_Cat.SelectedValue : -1;
            alarmset.StartBDate = chk_StartBDate.Checked;
            alarmset.StartDayBDate = (txt_StartDayBDate.Text.Trim() != "")? Convert.ToInt32(txt_StartDayBDate.Text) : -1;
            alarmset.Notes = txt_Notes.Text;
            alarmset.Quan = (txt_Quan.Text.Trim() != "")? Convert.ToDecimal(txt_Quan.Text) : 0;
            alarmset.WhenInsert = chk_WhenInsert.Checked;
            alarmset.Other = chk_Other.Checked;
            alarmset.dt_AlarmOther = table();
        }

        private DataTable table()
        {
            DataTable dt = new DataTable();
            foreach (DataGridViewColumn col in dgv_Other.Columns)
            {
                dt.Columns.Add(col.Name);
            }

            foreach (DataGridViewRow row in dgv_Other.Rows)
            {
                DataRow dRow = dt.NewRow();
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value.ToString() == "") { dRow[cell.ColumnIndex] = null; }
                    else { dRow[cell.ColumnIndex] = cell.Value; }
                }
                dt.Rows.Add(dRow);
            }
            dt.Columns.Remove("AlarmOther_Name");
            return dt;
        }
        #endregion

        #region Form
        private void frm_AlarmSet_Shown(object sender, EventArgs e)
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
            if (txt_Name.Text.Trim() == "")
            {
                MessageBox.Show("يجب إدخال أسم التنبيه");
                txt_Name.Focus();
                return;
            }
            if (com_Cat.SelectedValue == null)
            {
                MessageBox.Show("يجب اختيار الفئة");
                com_Cat.DroppedDown = true;
                return;
            }
            if (chk_StartBDate.Checked == true && txt_StartDayBDate.Text.Trim() == "")
            {
                MessageBox.Show("يجب إدخال عدد الأيام");
                txt_StartDayBDate.Focus();
                return;
            }

            if (chk_WithoutItem.Checked == false)
            {
                if (com_Items2.SelectedValue == null)
                {
                    MessageBox.Show("يجب اختيار صنف التطعيم");
                    com_Items2.DroppedDown = true;
                    return;
                }
                if (com_Items2.SelectedValue != null && txt_Quan.Text.Trim() == "")
                {
                    MessageBox.Show("يجب تحديد الكمية");
                    txt_Quan.Focus();
                    return;
                }
            }
            #endregion

            var();

            #region New
            if (Tag.ToString() == "New")
            {
                string t = alarmset.Insert();
                if (t.Length > 2)
                {
                    if (t.Substring(0, 3) == "SQL")
                    {
                        MessageBox.Show(t.Substring(6), "SQL");
                        return;
                    }
                }
                Fill();
                dgv.CurrentCell = dgv.Rows[dgv.RowCount - 1].Cells[0];
                Form_Mode("Select");
                frm_Main.AlarmRefresh();
            }
            #endregion

            #region Edit
            else if (Tag.ToString() == "Edit")
            {
                string t = alarmset.Update();
                if (t.Length > 2)
                {
                    if (t.Substring(0, 3) == "SQL")
                    {
                        MessageBox.Show(t.Substring(6), "SQL");
                        btn_Cancel_Click(null, null);
                        return;
                    }
                }
                Fill();
                dgv.CurrentCell = dgv.Rows[RowIndex].Cells[0];
                Form_Mode("Select");
                frm_Main.AlarmRefresh();
            }
            #endregion
        }
        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (dgv.CurrentCell != null)
            {
                if (DialogResult.Yes == MessageBox.Show("هل تريد بالفعل حذف التنبيه المحدد ؟", "تأكيد الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    //Delete Item In DataBase
                    alarmset.ID = Convert.ToInt32(txt_ID.Text);
                    string t = alarmset.Delete();
                    if (t.Length > 2)
                    {
                        if (t.Substring(0, 3) == "SQL")
                        {
                            MessageBox.Show(t.Substring(6), "SQL");
                            return;
                        }
                    }
                    Fill();
                    Form_Mode("Empty");
                    frm_Main.AlarmRefresh();
                }
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

        #region Details
        private void btn_Cat_Add_Click(object sender, EventArgs e)
        {
            G.frm_G frm_g = new G.frm_G();
            frm_g.Table = "Cat";
            frm_g.Text = "الفئة";
            frm_g.ShowDialog();
            com_Cat.DataSource = g.Select("Cat");
            com_Cat.SelectedValue = frm_g.txt_ID.Text;
        }
        private void btn_Cat_Del_Click(object sender, EventArgs e)
        {
            com_Cat.SelectedValue = -1;
        }
        #endregion


        private void chk_Other_CheckedChanged(object sender, EventArgs e)
        {
            dgv_Other.Visible = chk_Other.Checked;
            btn_Add.Visible = chk_Other.Checked;
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            frm_AlarmOtherAdd f = new frm_AlarmOtherAdd();
            DataTable d = new DataTable();
            d.Columns.Add("ID");
            d.Columns.Add("Name");

            d.Rows.Add(0, "التنبيه الحالي");
            foreach (DataRow r in ds.Tables[0].Rows)
            {
                d.Rows.Add(r["ID"], r["Name"]);
            }

            f.dgv = dgv_Other;
            f.com_Alarm.DataSource = d;

            f.Location = new Point(Location.X + ((Width / 2) - f.Width / 2) + 145, Location.Y + 370);
            f.ShowDialog();
        }
    }
}
