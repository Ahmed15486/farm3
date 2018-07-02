using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace WindowsFormsApplication1.PL.Store
{
    public partial class frm_ItemsCard : Form
    {
        #region Declarations
        public int UserID;
        BL.BL.Items items = new BL.BL.Items();
        DataTable dt = new DataTable();
        BL.BL.G g = new BL.BL.G();
        int level = 1;
        List<string> ParentID = new List<string>();
        int RowIndex;

        public PL.G.frm_Main frm_Main;
        public PL.G.frm_AlarmShow AlarmShow;
        public Label lbl_AlarmCount;
        #endregion

        public frm_ItemsCard()
        {
            InitializeComponent();

            dgv.AutoGenerateColumns = false;

            com_Sex.DataSource = g.Select("Sex");
            com_Case.DataSource = g.Select("Case");
            com_Cat.DataSource = g.Select("Cat");
            com_Farm.DataSource = g.Select("Farm");
            com_Type.DataSource = g.Select("ItemType");
            com_HealthStatus.DataSource = g.Select("HealthStatus");
            Fill();
        }

        #region Pro
        void Fill()
        {
            dt = items.Select();
            dt.DefaultView.RowFilter = (ParentID.Count == 0)? "ParentID IS NULL" : "ParentID = " + ParentID[ParentID.Count - 1];
            dgv.DataSource = dt;
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
                    txt_No.ReadOnly = true;
                    txt_ItemName.ReadOnly = true;
                    com_Sex.Enabled = false;
                    txt_BirthDate.ReadOnly = true;
                    dtp_BirthDate.Enabled = false;
                    com_Case.Enabled = false;
                    com_Cat.Enabled = false;
                    com_Farm.Enabled = false;
                    com_Type.Enabled = false;
                    txt_Weight.ReadOnly = true;
                    txt_Cost.ReadOnly = true;
                    btn_Cat_Add.Visible = false;
                    btn_Farm_Add.Visible = false;
                    btn_Cat_Del.Visible = false;
                    btn_Farm_Del.Visible = false;
                    btn_ItemType_Add.Visible = false;
                    btn_ItemType_Del.Visible = false;
                    btn_Death.Visible = true;
                    btn_Tat3eem.Visible = true;
                    txt_MotherNo.ReadOnly = true;
                    com_HealthStatus.Enabled = false;
                    btn_HealthStatus_Add.Visible = false;
                    txt_Notes.ReadOnly = true;

                    foreach (DataRow r in dt.Rows)
                    {
                        if (r["ID"].ToString() == dgv.SelectedRows[0].Cells[0].Value.ToString())
                        {
                            txt_ID.Text = r["ID"].ToString();
                            txt_No.Text = r["No"].ToString();
                            txt_ItemName.Text = r["Name"].ToString();
                            com_Sex.SelectedValue = r["Sex"];
                            com_Type.SelectedValue = r["ItemType"];

                            DateTime bd = Convert.ToDateTime(r["BDate"]);
                            DateTime today = DateTime.Today;
                            int d = (today - bd).Days;
                            int m = 0;
                            int y = 0;

                            while (d >= 30)
                            {
                                m++;
                                d -= 30;
                            }
                            while (m >= 12)
                            {
                                y++;
                                m -= 12;
                            }

                            txt_BirthDate.Text = bd.ToString("dd/MM/yyyy");
                            txt_day.Text = d.ToString();
                            txt_Month.Text = m.ToString();
                            txt_year.Text = y.ToString();
                            com_Case.SelectedValue = r["Case"];
                            com_Cat.SelectedValue = r["Cat"];
                            com_Farm.SelectedValue = r["Farm"];
                            com_Type.SelectedValue = r["ItemType"];
                            txt_Weight.Text = r["Weight"].ToString();
                            txt_Cost.Text = r["Cost"].ToString();
                            txt_MotherNo.Text = r["MomNo"].ToString();
                            com_HealthStatus.SelectedValue = r["HealthStatus"];
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
                    txt_No.ReadOnly = false;
                    txt_ItemName.ReadOnly = false;
                    com_Sex.Enabled = true;
                    txt_BirthDate.ReadOnly = false;
                    dtp_BirthDate.Enabled = true;
                    com_Case.Enabled = true;
                    com_Cat.Enabled = true;
                    com_Farm.Enabled = true;
                    com_Type.Enabled = true;
                    txt_Weight.ReadOnly = false;
                    txt_Cost.ReadOnly = false;
                    btn_Cat_Add.Visible = true;
                    btn_Farm_Add.Visible = true;
                    btn_Cat_Del.Visible = true;
                    btn_Farm_Del.Visible = true;
                    btn_ItemType_Add.Visible = true;
                    btn_ItemType_Del.Visible = true;
                    btn_Death.Visible = false;
                    btn_Tat3eem.Visible = false;
                    txt_MotherNo.ReadOnly = false;
                    com_HealthStatus.Enabled = true;
                    btn_HealthStatus_Add.Visible = true;
                    txt_Notes.ReadOnly = false;

                    dgv.ClearSelection();
                    txt_ID.Text = "";
                    txt_No.Text = "";
                    txt_ItemName.Text = ""; txt_ItemName.Focus();
                    com_Sex.SelectedIndex = -1;
                    txt_BirthDate.Text = "";
                    txt_day.Text = "";
                    txt_Month.Text = "";
                    txt_year.Text = "";
                    com_Case.SelectedIndex = -1;
                    txt_MotherNo.Text = "";
                    com_Cat.SelectedValue = -1;
                    com_Farm.SelectedValue = -1;
                    com_Type.SelectedValue = -1;
                    txt_Weight.Text = "";
                    txt_Cost.Text = "";
                    com_HealthStatus.SelectedIndex = 0;
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
                    txt_No.ReadOnly = false;
                    txt_ItemName.ReadOnly = false;
                    com_Sex.Enabled = true;
                    txt_BirthDate.ReadOnly = false;
                    dtp_BirthDate.Enabled = true;
                    com_Case.Enabled = true;
                    com_Cat.Enabled = true;
                    com_Farm.Enabled = true;
                    com_Type.Enabled = true;
                    txt_Weight.ReadOnly = false;
                    txt_Cost.ReadOnly = false;
                    btn_Cat_Add.Visible = true;
                    btn_Farm_Add.Visible = true;
                    btn_Cat_Del.Visible = true;
                    btn_Farm_Del.Visible = true;
                    btn_ItemType_Add.Visible = true;
                    btn_ItemType_Del.Visible = true;
                    btn_Death.Visible = false;
                    btn_Tat3eem.Visible = false;
                    txt_MotherNo.ReadOnly = false;
                    com_HealthStatus.Enabled = true;
                    btn_HealthStatus_Add.Visible = true;
                    txt_Notes.ReadOnly = false;

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
                    txt_No.ReadOnly = true;
                    txt_ItemName.ReadOnly = true;
                    com_Sex.Enabled = false;
                    txt_BirthDate.ReadOnly = true;
                    dtp_BirthDate.Enabled = false;
                    com_Case.Enabled = false;
                    com_Cat.Enabled = false;
                    com_Farm.Enabled = false;
                    com_Type.Enabled = false;
                    txt_Weight.ReadOnly = true;
                    txt_Cost.ReadOnly = true;
                    btn_Cat_Add.Visible = false;
                    btn_Farm_Add.Visible = false;
                    btn_Cat_Del.Visible = false;
                    btn_Farm_Del.Visible = false;
                    btn_ItemType_Add.Visible = false;
                    btn_ItemType_Del.Visible = false;
                    btn_Death.Visible = false;
                    btn_Tat3eem.Visible = false;
                    txt_MotherNo.ReadOnly = true;
                    com_HealthStatus.Enabled = false;
                    btn_HealthStatus_Add.Visible = false;
                    txt_Notes.ReadOnly = true;

                    dgv.ClearSelection();
                    txt_ID.Text = "";
                    txt_No.Text = "";
                    txt_ItemName.Text = "";
                    com_Sex.SelectedIndex = -1;
                    txt_BirthDate.Text = "";
                    txt_day.Text = "";
                    txt_Month.Text = "";
                    txt_year.Text = "";
                    com_Case.SelectedIndex = -1;
                    txt_MotherNo.Text = "";
                    com_Cat.SelectedValue = -1;
                    com_Farm.SelectedValue = -1;
                    com_Type.SelectedValue = -1;
                    txt_Weight.Text = "";
                    txt_Cost.Text = "";
                    com_HealthStatus.SelectedValue = -1;
                    txt_Notes.Text = "";
                    break;
                #endregion
            }
        }
        public byte[] imageToByteArray(System.Drawing.Image imageIn)
        {
            try
            {
                using (var ms = new MemoryStream())
                {
                    imageIn.Save(ms, pic_Item.Image.RawFormat);
                    return ms.ToArray();
                }
            }
            catch { return null; }
        }
        public Image byteArrayToImage(byte[] bytesArr)
        {
            MemoryStream memstr = new MemoryStream(bytesArr);
            Image img = Image.FromStream(memstr);
            return img;
        }
        void var()
        {
            items.ID = (txt_ID.Text != "")? txt_ID.Text : "";
            items.No = txt_No.Text.Trim();
            items.Name = txt_ItemName.Text;
            items.Sex = (com_Sex.SelectedValue != null) ? (int)com_Sex.SelectedValue : -1;
            items.ItemType = (com_Type.SelectedValue != null) ? Convert.ToInt32(com_Type.SelectedValue) : -1; 
            items.Cat = (com_Cat.SelectedValue != null)? (int)com_Cat.SelectedValue : -1;
            items.BDate = (txt_BirthDate.Text.Trim() != "") ? DateTime.ParseExact(txt_BirthDate.Text,"dd/MM/yyyy",null) : DateTime.ParseExact("01/01/1900","dd/MM/yyyy",null);
            items.Farm = (com_Farm.SelectedValue != null)? (int)com_Farm.SelectedValue : -1;
            items.Weight = (txt_Weight.Text.Trim() != "" )? Convert.ToDecimal(txt_Weight.Text) : 0;
            items.Case = (com_Case.SelectedValue != null) ? (int)com_Case.SelectedValue : -1;
            items.Cost = (txt_Cost.Text.Trim() != "") ? Convert.ToDecimal(txt_Cost.Text) : 0;
            items.Pic = (pic_Item.Image != null)? imageToByteArray(pic_Item.Image) : null;
            items.Level = level;
            items.ParentID = (ParentID.Count > 0)? ParentID[ParentID.Count-1] : null;
            items.MomNo = txt_MotherNo.Text.Trim();
            items.HealthStatus = Convert.ToInt32(com_HealthStatus.SelectedValue);
            items.Notes = txt_Notes.Text.Trim();
        }
        #endregion

        #region Form
        private void frm_ItemsCard_Shown(object sender, EventArgs e)
        {
            if(dgv.Rows.Count > 0)
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
            Form_Mode("Edit");
            RowIndex = dgv.SelectedRows[0].Index;
        }
        private void btn_Save_Click(object sender, EventArgs e)
        {
            #region Validations
            if(level == 1)
            {
                if (txt_ItemName.Text.Trim() == "")
                {
                    MessageBox.Show("يجب إدخال أسم المجموعة");
                    txt_No.Focus();
                    return;
                }
            }
            else
            {
                if (txt_No.Text.Trim() == "")
                {
                    MessageBox.Show("يجب إدخال رقم المنتج");
                    txt_No.Focus();
                    return;
                }
                if (grbx_SubDetails.Visible == true && txt_BirthDate.Text.Trim() == "")
                {
                    MessageBox.Show("يجب إدخال تاريخ الميلاد");
                    dtp_BirthDate.Select();
                    SendKeys.Send("%{DOWN}");
                    return;
                }
                if (com_Cat.SelectedValue == null)
                {
                    MessageBox.Show("يجب اختيار الفئة");
                    com_Cat.DroppedDown = true;
                    return;
                }
            }

            #endregion

            var();

            #region New
            if (Tag.ToString() == "New")
            {
                DataTable dt_WhenInsert = new DataTable();
                dt_WhenInsert.Columns.Add("AlarmID");
                DataTable dt_WhenInsertSelect = new DataTable();
                dt_WhenInsertSelect = g.Select2("SELECT dbo.AlarmSet.ID, dbo.AlarmSet.Name, dbo.Items2.Name as ItemName, dbo.AlarmSet.Quan"
                + " FROM dbo.AlarmSet LEFT OUTER JOIN dbo.Items2 ON dbo.AlarmSet.Items2ID = dbo.Items2.ID"
                +" Where WhenInsert = 1 AND CatID = " + Convert.ToInt32(com_Cat.SelectedValue));

                if(dt_WhenInsertSelect.Rows.Count > 0)
                {
                    frm_ProductWhenInsert frm = new frm_ProductWhenInsert();
                    frm.Location = new Point(Location.X + ((Width / 2) - frm.Width / 2), Location.Y + grbx_Controls.Height + grbx_Details.Height + 100);
                    frm.dgv.DataSource = dt_WhenInsertSelect;
                    frm.dt_WhenInsert = dt_WhenInsert;

                    frm.ShowDialog();

                    if (frm.Continue == false) return;
                }
                items.dt_WhenInsert = dt_WhenInsert;

                string t = items.Insert();
                if (t.Length > 2)
                {
                    if (t.Substring(0, 3) == "SQL")
                    {
                        MessageBox.Show(t.Substring(6), "SQL");
                        return;
                    }
                }
                
                Fill();
                dgv.CurrentCell = dgv.Rows[dgv.RowCount - 1].Cells[1];
                Form_Mode("Select");
            }
            #endregion

            #region Edit
            else if (Tag.ToString() == "Edit")
            {
                string t = items.Update();
                if (t.Length > 2)
                {
                    if (t.Substring(0, 3) == "SQL")
                    {
                        MessageBox.Show(t.Substring(6), "SQL");
                        return;
                    }
                }
                Fill();
                dgv.CurrentCell = dgv.Rows[RowIndex].Cells[1];
                Form_Mode("Select");
            }
            #endregion

            frm_Main.AlarmRefresh();
            frm_Main.FillChart();
        }
        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (dgv.CurrentCell != null)
            {
                if (DialogResult.Yes == MessageBox.Show("هل تريد بالفعل حذف الصنف المحدد ؟", "تأكيد الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    //Delete Item In DataBase
                    items.ID = txt_ID.Text;
                    string t = items.Delete();
                    if (t == "0") { MessageBox.Show("لايمكن حذف مجموعة تحتوي على أصناف"); return; }
                    Fill();
                    Form_Mode("Empty");

                    frm_Main.AlarmRefresh();
                    frm_Main.FillChart();
                }
            }
        }
        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            if(Tag.ToString() == "New")
            {
                Form_Mode("Empty");
            }
            else if(Tag.ToString() == "Edit")
            {
                Form_Mode("Select");
            }
        }
        #endregion

        #region dgv
        private void dgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dgv.SelectedRows[0].Cells["Used"].Value.ToString() == "True")
            {
                MessageBox.Show("هذا المنتج مستخدم ولا يمكن التفرع منه");
                return;
            }
            if (dgv.SelectedRows.Count != 0)
            {
                ParentID.Add(dgv.SelectedRows[0].Cells[0].Value.ToString());
                level++;
                dt.DefaultView.RowFilter = "ParentID = " + ParentID[ParentID.Count - 1];

                if(dgv.RowCount > 0)
                {
                    dgv.CurrentCell = dgv.Rows[0].Cells[1];
                    Form_Mode("Select");
                }
                else
                {
                    Form_Mode("Empty");
                }
                grbx_SubDetails.Visible = true;
            }
        }
        private void dgv_SelectionChanged(object sender, EventArgs e)
        {
            if (Tag == null) return; if (dgv.CurrentRow == null) return;
            if (dgv.CurrentRow.Selected == false) return;
            if (Tag.ToString() == "Select" || Tag.ToString() == "Empty")
            {
                Form_Mode("Select");
            }
        }
        #endregion

        #region Details
        #region Display
        private void btn_Tat3eem_MouseEnter(object sender, EventArgs e)
        {
            btn_Tat3eem.FlatStyle = FlatStyle.Popup;
        }
        private void btn_Tat3eem_MouseLeave(object sender, EventArgs e)
        {
            btn_Tat3eem.FlatStyle = FlatStyle.Flat;
        }
        private void btn_Death_MouseEnter(object sender, EventArgs e)
        {
            btn_Death.FlatStyle = FlatStyle.Popup;
        }
        private void btn_Death_MouseLeave(object sender, EventArgs e)
        {
            btn_Death.FlatStyle = FlatStyle.Flat;
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
            if (txt_Search.Text.Trim() == "Search")
            {
                txt_Search.Text = "";
                txt_Search.ForeColor = Color.Black;
            }
        }
        private void txt_Search_Leave(object sender, EventArgs e)
        {
            if (txt_Search.Text.Trim() == "")
            {
                txt_Search.Text = "Search";
                txt_Search.ForeColor = Color.Silver;
            }
        }
        #endregion
        private void btn_UP_Click(object sender, EventArgs e)
        {
            if (level == 2)
            {
                level--;
                string i = ParentID[ParentID.Count - 1];
                ParentID.Clear();
                dt.DefaultView.RowFilter = "ParentID IS NULL";
                foreach (DataGridViewRow r in dgv.Rows)
                {
                    if(r.Cells[0].Value.ToString() == i)
                    {
                        dgv.CurrentCell = dgv.Rows[r.Index].Cells[1];
                        break;
                    }
                }
                Form_Mode("Select");
            }
            else if (level > 2)
            {
                level--;
                string i = ParentID[ParentID.Count - 1];
                ParentID.RemoveAt(ParentID.Count - 1);
                dt.DefaultView.RowFilter = "ParentID = " + ParentID[ParentID.Count-1];
                foreach (DataGridViewRow r in dgv.Rows)
                {
                    if (r.Cells[0].Value.ToString() == i)
                    {
                        dgv.CurrentCell = dgv.Rows[r.Index].Cells[1];
                        break;
                    }
                }
                Form_Mode("Select");
            }
            if (level == 1) grbx_SubDetails.Visible = false;

        }
        private void btn_Dowen_Click(object sender, EventArgs e)
        {
            if (dgv.SelectedRows != null)
            {
                dgv_CellDoubleClick(null, null);
            }
        }
        private void dtp_BirthDate_ValueChanged(object sender, EventArgs e)
        {
            txt_BirthDate.Text = dtp_BirthDate.Value.ToString("dd/MM/yyyy");
        }
        private void btn_Cat_Add_Click(object sender, EventArgs e)
        {
            G.frm_G frm_g = new G.frm_G();
            frm_g.Table = "Cat";
            frm_g.Text = "الفئة";
            frm_g.ShowDialog();
            com_Cat.DataSource = g.Select("Cat");
            com_Cat.SelectedValue = frm_g.txt_ID.Text;
        }
        private void btn_Farm_Add_Click(object sender, EventArgs e)
        {
            G.frm_G frm_g = new G.frm_G();
            frm_g.Table = "Farm";
            frm_g.Text = "الحظيرة";
            frm_g.ShowDialog();
            com_Farm.DataSource = g.Select("Farm");
            com_Farm.SelectedValue = frm_g.txt_ID.Text;
        }
        private void btn_Cat_Del_Click(object sender, EventArgs e)
        {
            com_Cat.SelectedValue = -1;
        }
        private void btn_Farm_Del_Click(object sender, EventArgs e)
        {
            com_Farm.SelectedValue = -1;
        }
        private void btn_ItemType_Add_Click(object sender, EventArgs e)
        {
            G.frm_G frm_g = new G.frm_G();
            frm_g.Table = "ItemType";
            frm_g.Text = "النوع ";
            frm_g.ShowDialog();
            com_Type.DataSource = g.Select("ItemType");
            com_Type.SelectedValue = frm_g.txt_ID.Text;
        }
        private void btn_ItemType_Del_Click(object sender, EventArgs e)
        {
            com_Type.SelectedValue = -1;
        }
        private void btn_Death_Click(object sender, EventArgs e)
        {
            if (dgv.CurrentCell != null)
            {
                if (DialogResult.Yes == MessageBox.Show("هل تريد بالفعل نقل هذا المنتج إلى سجلات النفوق ؟", "تأكيد النفوق", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    //Delete Item In DataBase
                    items.ID = txt_ID.Text;
                    string t = items.Death_Insert();
                    if (t == "0") { MessageBox.Show("لايمكن حذف مجموعة تحتوي على أصناف"); return; }
                    Fill();
                    Form_Mode("Empty");
                }
            }
        }
        private void btn_Tat3eem_Click(object sender, EventArgs e)
        {
            #region Form Design
            Form frm = new Form();
            frm.Size = new Size(800, 360); ;
            frm.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            frm.StartPosition = FormStartPosition.Manual;
            frm.Location = new Point(Location.X + ((Width / 2) - frm.Width / 2) , Location.Y + grbx_Controls.Height + grbx_Details.Height + 45);
            frm.RightToLeft = RightToLeft.Yes;
            frm.RightToLeftLayout = true;
            frm.Text = "التطعيمات الخاصة بـ  " + txt_ItemName.Text + "  رقم  " + txt_No.Text;

            GroupBox grx = new GroupBox();
            grx.Dock = DockStyle.Fill;

            #region dgv
            DataGridView dgv = new DataGridView();
            dgv.ReadOnly = true;
            dgv.AllowUserToOrderColumns = false;
            dgv.AllowUserToDeleteRows = false;
            dgv.AllowUserToAddRows = false;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.DefaultCellStyle.SelectionBackColor = Color.Transparent;
            dgv.DefaultCellStyle.SelectionForeColor = Color.Black;
            dgv.Dock = DockStyle.Fill;
            dgv.RowHeadersVisible = false;
            dgv.AutoGenerateColumns = false;

            var AlarmID = new DataGridViewComboBoxColumn();
            AlarmID.Name = "AlarmID";
            AlarmID.DataPropertyName = "AlarmID";
            AlarmID.DataSource = g.Select2("Select * From AlarmSet");
            AlarmID.ValueMember = "ID";
            AlarmID.DisplayMember = "ID";
            AlarmID.HeaderText = "كود التنبيه";
            AlarmID.Width = 75;
            dgv.Columns.Add(AlarmID);

            var AlarmName = new DataGridViewComboBoxColumn();
            AlarmName.Name = "AlarmName";
            AlarmName.DataPropertyName = "AlarmID";
            AlarmName.DataSource = g.Select2("Select * From AlarmSet");
            AlarmName.ValueMember = "ID";
            AlarmName.DisplayMember = "Name";
            AlarmName.HeaderText = "أسم التنبيه";
            AlarmName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv.Columns.Add(AlarmName);

            DataGridViewTextBoxColumn ReasonString = new DataGridViewTextBoxColumn();
            ReasonString.HeaderText = "سبب التنبيه";
            ReasonString.DataPropertyName = "ReasonString";
            ReasonString.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv.Columns.Add(ReasonString);

            DataGridViewTextBoxColumn AlarmDate = new DataGridViewTextBoxColumn();
            AlarmDate.HeaderText = "تاريخ التنبيه";
            AlarmDate.DataPropertyName = "AlarmDate";
            AlarmDate.Width = 75;
            dgv.Columns.Add(AlarmDate);

            DataGridViewTextBoxColumn ActualDate = new DataGridViewTextBoxColumn();
            ActualDate.HeaderText = "تاريخ التطعيم";
            ActualDate.DataPropertyName = "ActualDate";
            ActualDate.Width = 75;
            dgv.Columns.Add(ActualDate);

            DataGridViewCheckBoxColumn OK = new DataGridViewCheckBoxColumn();
            OK.Name = "OK";
            OK.HeaderText = "تم التطعيم";
            OK.DataPropertyName = "OK";
            OK.Width = 65;
            dgv.Columns.Add(OK);

            DataGridViewCheckBoxColumn Cancel = new DataGridViewCheckBoxColumn();
            Cancel.Name = "Cancel";
            Cancel.HeaderText = "تم الإلغاء";
            Cancel.DataPropertyName = "Cancel";
            Cancel.Width = 65;
            dgv.Columns.Add(Cancel);
            #endregion
            #endregion

            grx.Controls.Add(dgv);
            frm.Controls.Add(grx);

            DataTable dt = new DataTable();
            dt = g.Select2("Select * From viw_ProductTat3eem Where ItemsID = " + txt_ID.Text);

            dt.Columns.Add("ReasonString");
            foreach (DataRow r in dt.Rows)
            {
                switch ((int)r["Reason"])
                {
                    case 1:
                        r["ReasonString"] = "عند التسجيل";
                        break;

                    case 2:
                        r["ReasonString"] = "بعد تاريخ الميلاد بـ  " + r["Days"].ToString() + " يوم";
                        break;

                    case 3:
                        r["ReasonString"] = "بعد " + r["AlarmOther_Name"] + "  بـ  " + r["Days"].ToString() + " يوم";
                        break;

                }
            }

            dgv.DataSource = dt;
            frm.ShowDialog();
        }
        private void txt_Search_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13 && txt_Search.Text.Trim() != "")
            {
                dt.DefaultView.RowFilter = "No = '" + txt_Search.Text + "'";

                if (dgv.Rows.Count > 0)
                {
                    grbx_SubDetails.Visible = true;
                    Form_Mode("Select");
                }
                else
                {
                    Form_Mode("Empty");
                }
            }
        }
        private void com_Case_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (com_Case.SelectedIndex == 0)
            {
                lbl_MotherNo.Visible = true;
                txt_MotherNo.Visible = true;
            }
            else
            {
                lbl_MotherNo.Visible = false;
                txt_MotherNo.Visible = false;
                txt_MotherNo.Text = "";
            }
        }
        private void btn_HealthStatus_Add_Click(object sender, EventArgs e)
        {
            G.frm_G frm_g = new G.frm_G();
            frm_g.Table = "HealthStatus";
            frm_g.Text = "الحالة الصحية ";
            frm_g.ShowDialog();
            com_HealthStatus.DataSource = g.Select("HealthStatus");
            com_HealthStatus.SelectedValue = frm_g.txt_ID.Text;
        }
        #endregion
    }
}
