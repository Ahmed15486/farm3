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
    public partial class frm_Branches : Form
    {
        #region Declarations
        public int UserID;
        DataSet ds = new DataSet();
        BL.BL.G g = new BL.BL.G();
        BL.BL.BS BS = new BL.BL.BS();
        int RowIndexBranche;
        int RowIndexStore;
        #endregion

        public frm_Branches()
        {
            InitializeComponent();

            ds = g.SelectDS("Select * from Branches order by rowid; Select * from Stores");

            //Fill Branches DGV
            DGV_Branches.AutoGenerateColumns = false;
            DGV_Branches.DataSource = ds.Tables[0];

            //Fill Stores DGV
            DGV_Stores.AutoGenerateColumns = false;
            DGV_Stores.DataSource = ds.Tables[1];
        }

        #region Pro
        public void Form_Mode(string mode)
        {
            switch (mode)
            {
                #region Select
                case "Select":

                    Tag = "Select";

                    if (DGV_Branches.SelectedRows.Count != 0)
                    {
                        //Fill Branches Controls From DGV
                        txt_Branche_ID.Text = DGV_Branches.SelectedRows[0].Cells["BrancheID"].Value.ToString();
                        txt_BrancheAnm.Text = DGV_Branches.SelectedRows[0].Cells["BrancheName"].Value.ToString();
                        txt_BrancheEnm.Text = DGV_Branches.SelectedRows[0].Cells["BrancheEnm"].Value.ToString();

                        //Fill Stores Controls From DGV
                        textBox_Store_ID.Text = DGV_Stores.SelectedRows[0].Cells["StoreID"].Value.ToString();
                        txt_StoreAnm.Text = DGV_Stores.SelectedRows[0].Cells["StoreName"].Value.ToString();
                        txt_StoreEnm.Text = DGV_Stores.SelectedRows[0].Cells["StoreEnm"].Value.ToString();

                        //Filter Stores
                        ds.Tables[1].DefaultView.RowFilter = string.Format("Branche_ID='" + DGV_Branches.SelectedRows[0].Cells["BrancheID"].Value.ToString() + "'");

                        txt_Branche_ID.ReadOnly = true;
                        groupBox_Stores.Enabled = true;
                        DGV_Branches.Enabled = true;

                        txt_BrancheAnm.ReadOnly = true;
                        txt_BrancheEnm.ReadOnly = true;

                        btn_New.Visible = true;
                        btn_Edit.Visible = true;
                        btn_Save.Visible = false;
                        btn_Delete.Visible = true;
                        btn_Cancel.Visible = false;
                    }


                    break;
                #endregion

                #region New Branche
                case "New Branche":

                    Tag = "New Branche";

                    //Clare Controls
                    txt_Branche_ID.Clear();
                    txt_BrancheAnm.Clear();
                    txt_BrancheEnm.Clear();
                    textBox_Store_ID.Clear();
                    txt_StoreAnm.Clear();
                    txt_StoreEnm.Clear();

                    txt_Branche_ID.ReadOnly = false;
                    groupBox_Stores.Enabled = false;
                    DGV_Branches.Enabled = false;

                    txt_BrancheAnm.ReadOnly = false;
                    txt_BrancheEnm.ReadOnly = false;
                    txt_BrancheAnm.Focus();

                    btn_New.Visible = false;
                    btn_Edit.Visible = false;
                    btn_Save.Visible = true;
                    btn_Delete.Visible = false;
                    btn_Cancel.Visible = true;
                    break;
                #endregion

                #region Edit Branche
                case "Edit Branche":

                    Tag = "Edit Branche";

                    groupBox_Stores.Enabled = false;
                    DGV_Branches.Enabled = false;

                    btn_New.Visible = false;
                    btn_Edit.Visible = false;
                    btn_Save.Visible = true;
                    btn_Delete.Visible = false;
                    btn_Cancel.Visible = true;

                    txt_BrancheAnm.ReadOnly = false;
                    txt_BrancheEnm.ReadOnly = false;
                    txt_BrancheAnm.Select();
                    break;
                #endregion

                #region New Store
                case "New Store":
                    Tag = "New Store";

                    groupBox_Main_Controls.Visible = false;
                    groupBox_Branches.Enabled = false;
                    DGV_Stores.Enabled = false;

                    button_New_Store.Text = "حفظ";
                    button_New_Store.Image = imageList1.Images["Save"];
                    button_Edit_Store.Visible = false;
                    button_Delete_Store.Visible = false;
                    button_Cancel_Store.Visible = true;

                    textBox_Store_ID.Clear();
                    txt_StoreAnm.Clear();
                    txt_StoreEnm.Clear();
                    txt_StoreAnm.ReadOnly = false;
                    txt_StoreEnm.ReadOnly = false;
                    txt_StoreAnm.Focus();

                    label_Store_Full_Name.Visible = true;
                    break;
                #endregion

                #region Edit Store
                case "Edit Store":
                    Tag = "Edit Store";

                    groupBox_Main_Controls.Visible = false;
                    groupBox_Branches.Enabled = false;
                    DGV_Stores.Enabled = false;

                    button_New_Store.Visible = false;
                    button_Edit_Store.Text = "حفظ";
                    button_Edit_Store.Image = imageList1.Images["Save"];
                    button_Delete_Store.Visible = false;
                    button_Cancel_Store.Visible = true;

                    label_Store_Full_Name.Visible = true;

                    txt_StoreAnm.ReadOnly = false;
                    txt_StoreEnm.ReadOnly = false;
                    txt_StoreAnm.Select();
                    break;
                #endregion

                #region Select Edit
                case "Select Edit Store":
                    Tag = "Select";

                    //Filter Stores
                    ds.Tables[1].DefaultView.RowFilter = "Branche_ID = '" + DGV_Branches.SelectedRows[0].Cells["BrancheID"].Value.ToString() + "'";

                    groupBox_Main_Controls.Visible = true;
                    groupBox_Branches.Enabled = true;
                    DGV_Stores.Enabled = true;

                    button_New_Store.Visible = true;
                    button_Edit_Store.Text = "تعديل";
                    button_Edit_Store.Image = imageList1.Images["Edit"];
                    button_Delete_Store.Visible = true;
                    button_Cancel_Store.Visible = false;

                    label_Store_Full_Name.Visible = false;

                    txt_StoreAnm.ReadOnly = true;
                    txt_StoreEnm.ReadOnly = true;

                    break;
                #endregion

                #region Store Select
                case "Store Select":
                    Tag = "Select";

                    //Filter Stores
                    ds.Tables[1].DefaultView.RowFilter = string.Format("Branche_ID='" + DGV_Branches.SelectedRows[0].Cells["BrancheID"].Value.ToString() + "'");

                    //Fill Stores Controls From DGV
                    textBox_Store_ID.Text = DGV_Stores.SelectedRows[0].Cells["StoreID"].Value.ToString();
                    txt_StoreAnm.Text = DGV_Stores.SelectedRows[0].Cells["StoreName"].Value.ToString();
                    txt_StoreEnm.Text = DGV_Stores.SelectedRows[0].Cells["StoreEnm"].Value.ToString();

                    groupBox_Main_Controls.Visible = true;
                    groupBox_Branches.Enabled = true;
                    DGV_Stores.Enabled = true;

                    button_New_Store.Text = "New";
                    button_New_Store.Image = imageList1.Images["New"];
                    button_Edit_Store.Visible = true;
                    button_Delete_Store.Visible = true;
                    button_Cancel_Store.Visible = false;

                    txt_StoreAnm.ReadOnly = true;
                    txt_StoreEnm.ReadOnly = true;

                    label_Store_Full_Name.Visible = false;
                    break;
                    #endregion
            }
        }
        private void Fill()
        {
            ds = g.SelectDS("Select * from Branches order by rowid; Select * from Stores");
            DGV_Branches.DataSource = null;
            DGV_Stores.DataSource = null;
            DGV_Branches.DataSource = ds.Tables[0];
            DGV_Stores.DataSource = ds.Tables[1];
        }
        private void var()
        {
            BS.User_ID = UserID;
            BS.Branche_ID = txt_Branche_ID.Text;
            BS.Anm = txt_BrancheAnm.Text.Trim();
            BS.Enm = txt_BrancheEnm.Text.Trim();
            BS.Store_ID = (textBox_Store_ID.Text == "") ? 0 : Convert.ToInt16(textBox_Store_ID.Text);
            BS.Store_Anm = (txt_StoreAnm.Text == "") ? "" : txt_StoreAnm.Text;
            BS.Store_Enm = (txt_StoreEnm.Text == "") ? "" : txt_StoreEnm.Text;
        }

        #endregion

        #region Form
        private void FRM_Branches_Shown(object sender, EventArgs e)
        {
            //Filter Stores
            if (DGV_Branches.SelectedRows.Count > 0)
            {
                string s = DGV_Branches.SelectedRows[0].Cells["BrancheID"].Value.ToString();
                ds.Tables[1].DefaultView.RowFilter = string.Format("Branche_ID = '" + s + "'");

                //Fill Controls
                txt_Branche_ID.Text = DGV_Branches.Rows[0].Cells["BrancheID"].Value.ToString();
                txt_BrancheAnm.Text = DGV_Branches.Rows[0].Cells["BrancheName"].Value.ToString();
                textBox_Store_ID.Text = DGV_Stores.Rows[0].Cells["StoreID"].Value.ToString();
                txt_StoreAnm.Text = DGV_Stores.Rows[0].Cells["StoreName"].Value.ToString();
            }
        }
        #endregion

        #region Branches Controls
        #region display
        private void button_New_MouseLeave(object sender, EventArgs e)
        {
            btn_New.FlatStyle = FlatStyle.Flat;
        }
        private void button_New_MouseEnter(object sender, EventArgs e)
        {
            btn_New.FlatStyle = FlatStyle.Popup;
        }
        private void button_Edit_MouseEnter(object sender, EventArgs e)
        {
            btn_Edit.FlatStyle = FlatStyle.Popup;
        }
        private void button_Edit_MouseLeave(object sender, EventArgs e)
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
        private void button_Delete_MouseEnter(object sender, EventArgs e)
        {
            btn_Delete.FlatStyle = FlatStyle.Popup;
        }
        private void button_Delete_MouseLeave(object sender, EventArgs e)
        {
            btn_Delete.FlatStyle = FlatStyle.Flat;
        }
        private void button_Cancel_MouseEnter(object sender, EventArgs e)
        {
            btn_Cancel.FlatStyle = FlatStyle.Popup;
        }
        private void button_Cancel_MouseLeave(object sender, EventArgs e)
        {
            btn_Cancel.FlatStyle = FlatStyle.Flat;
        }
        #endregion
        private void button_New_Click(object sender, EventArgs e)
        {
            Form_Mode("New Branche");
        }
        private void button_Edit_Click(object sender, EventArgs e)
        {
            RowIndexBranche = DGV_Branches.SelectedRows[0].Index;
            Form_Mode("Edit Branche");
        }
        private void btn_Save_Click(object sender, EventArgs e)
        {
            #region validation
            if ((txt_Branche_ID.Text.Trim()).Length < 1)
            {
                MessageBox.Show("من فضلك أدخل كود الفرع");
                return;
            }
            if (txt_Branche_ID.TextLength < 3)
            {
                MessageBox.Show("يجب أن يساوي كود الفرع 3 أحرف");
                return;
            }
            if ((txt_BrancheAnm.Text.Trim()).Length < 1 && (txt_BrancheEnm.Text.Trim()).Length < 1)
            {
                MessageBox.Show("من فضلك أدخل أسم الفرع");
                return;
            }
            #endregion

            if (Tag.ToString() == "New Branche")
            {
                txt_StoreAnm.Text = "مستودع" + " " + txt_BrancheAnm.Text.Trim();
                txt_StoreEnm.Text = txt_BrancheEnm.Text.Trim() + " " + "Store";
                //Insert New Branche In DataBase
                var();
                string t = BS.Insert_Branche();
                if (t != null)
                {
                    if (t.Substring(0, 5) == "Error")
                    {
                        MessageBox.Show(t.Substring(6), "SQL");
                        return;
                    }
                }
                Fill();

                Form_Mode("Select");
                DGV_Branches.CurrentCell = DGV_Branches.Rows[DGV_Branches.Rows.Count - 1].Cells[0];
            }
            else if (Tag.ToString() == "Edit Branche")
            {
                var();
                string t = BS.Update_Branche();
                if (t != null)
                {
                    if (t.Substring(0, 5) == "Error")
                    {
                        MessageBox.Show(t.Substring(6), "SQL");
                        return;
                    }
                }

                Fill();
                DGV_Branches.CurrentCell = DGV_Branches.Rows[RowIndexBranche].Cells[0];
                Form_Mode("Select");
            }

        }
        private void button_Delete_Click(object sender, EventArgs e)
        {
            if (DGV_Branches.RowCount == 1)
            {
                MessageBox.Show("يجب الإحتفاظ بفرع واحد على الأقل");
                return;
            }
            if (DialogResult.Yes == MessageBox.Show("هل تريد بالفعل حذف الفرع ؟  سيتم حذف كافة المستودعات التابعة لهذا الفرع", "تأكيد الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                //Delete Branche In DataBase
                var();
                string t = BS.Delete_Branche();
                if (t != null)
                {
                    if (t.Substring(0, 5) == "Error")
                    {
                        MessageBox.Show(t.Substring(6), "SQL");
                        Form_Mode("Select");
                        return;
                    }
                }

                Fill();
                Form_Mode("Select");
            }
        }
        private void button_Cancel_Click(object sender, EventArgs e)
        {
            Form_Mode("Select");
            Tag = "Select";
        }
        #endregion

        #region Stores Controls
        #region display
        private void button_New_Store_MouseLeave(object sender, EventArgs e)
        {
            button_New_Store.FlatStyle = FlatStyle.Flat;
        }
        private void button_New_Store_MouseEnter(object sender, EventArgs e)
        {
            button_New_Store.FlatStyle = FlatStyle.Popup;
        }
        private void button_Edit_Store_MouseEnter(object sender, EventArgs e)
        {
            button_Edit_Store.FlatStyle = FlatStyle.Popup;
        }
        private void button_Edit_Store_MouseLeave(object sender, EventArgs e)
        {
            button_Edit_Store.FlatStyle = FlatStyle.Flat;
        }
        private void button_Delete_Store_MouseEnter(object sender, EventArgs e)
        {
            button_Delete_Store.FlatStyle = FlatStyle.Popup;
        }
        private void button_Delete_Store_MouseLeave(object sender, EventArgs e)
        {
            button_Delete_Store.FlatStyle = FlatStyle.Flat;
        }
        private void button_Cancel_Store_MouseEnter(object sender, EventArgs e)
        {
            button_Cancel_Store.FlatStyle = FlatStyle.Popup;
        }
        private void button_Cancel_Store_MouseLeave(object sender, EventArgs e)
        {
            button_Cancel_Store.FlatStyle = FlatStyle.Flat;
        }
        #endregion
        private void button_New_Store_Click(object sender, EventArgs e)
        {
            if (Tag.ToString() == "Select")
            {
                RowIndexBranche = DGV_Branches.SelectedRows[0].Index;

                Form_Mode("New Store");
            }
            else if (Tag.ToString() == "New Store")
            {
                if ((txt_StoreAnm.Text.Trim()).Length < 1)
                {
                    MessageBox.Show("من فضلك أدخل أسم المستودع");
                    return;
                }

                //Insert New Store In DataBase
                var();
                BS.Insert_Store();

                Fill();

                Form_Mode("Store Select");
                Tag = "Select";
                //Select Last Row
                DGV_Branches.CurrentCell = DGV_Branches.Rows[RowIndexBranche].Cells[0];
                DGV_Stores.CurrentCell = DGV_Stores.Rows[DGV_Stores.Rows.Count - 1].Cells[0];
            }
        }
        private void button_Edit_Store_Click(object sender, EventArgs e)
        {
            if (Tag.ToString() == "Select")
            {
                RowIndexBranche = DGV_Branches.SelectedRows[0].Index;
                RowIndexStore = DGV_Stores.SelectedRows[0].Index;
                Form_Mode("Edit Store");
            }
            else
            {
                if (Tag.ToString() == "Edit Store")
                {
                    if ((txt_StoreAnm.Text.Trim()).Length < 1)
                    {
                        MessageBox.Show("من فضلك أدخل أسم المستودع");
                        return;
                    }

                    //Update Store In DataBase
                    var();
                    string t = BS.Update_Store();
                    if (t != null)
                    {
                        if (t.Substring(0, 5) == "Error")
                        {
                            MessageBox.Show(t.Substring(6), "SQL");
                            return;
                        }
                    }

                    Fill();

                    DGV_Branches.CurrentCell = DGV_Branches.Rows[RowIndexBranche].Cells[0];
                    DGV_Stores.CurrentCell = DGV_Stores.Rows[RowIndexStore].Cells[0];
                    Form_Mode("Select Edit Store");
                }
            }
        }
        private void button_Delete_Store_Click(object sender, EventArgs e)
        {
            if (DGV_Stores.RowCount == 1)
            {
                MessageBox.Show("يجب الإحتفاظ بمستودع واحد لهذا الفرع على الأقل");
                return;
            }

            if (DialogResult.Yes == MessageBox.Show("هل تريد بالفعل حذف المستودع ؟", "تأكيد الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                //Delete Store In DataBase
                RowIndexBranche = DGV_Branches.SelectedRows[0].Index;

                var();

                string t = BS.Delete_Store();
                if (t != null)
                {
                    if (t.Substring(0, 5) == "Error")
                    {
                        MessageBox.Show(t.Substring(6), "SQL");
                        return;
                    }
                }

                Fill();
                DGV_Branches.CurrentCell = DGV_Branches.Rows[RowIndexBranche].Cells[0];
                Form_Mode("Select");
            }
        }
        private void button_Cancel_Store_Click(object sender, EventArgs e)
        {
            Form_Mode("Select Edit Store");
            Tag = "Select";
        }
        #endregion

        #region Branches Details
        private void DGV_Branches_SelectionChanged(object sender, EventArgs e)
        {
            if (DGV_Branches.SelectedRows.Count > 0)
            {
                //Fill Branches Controls
                txt_Branche_ID.Text = DGV_Branches.SelectedRows[0].Cells["BrancheID"].Value.ToString();
                txt_BrancheAnm.Text = DGV_Branches.SelectedRows[0].Cells["BrancheName"].Value.ToString();
                txt_BrancheEnm.Text = DGV_Branches.SelectedRows[0].Cells["BrancheEnm"].Value.ToString();

                //Filter Stores
                ds.Tables[1].DefaultView.RowFilter = string.Format("Branche_ID='" + DGV_Branches.SelectedRows[0].Cells["BrancheID"].Value.ToString() + "'");

                //Fill Stores Controls From DGV
                if (DGV_Stores.DataSource != null)
                {
                    textBox_Store_ID.Text = DGV_Stores.SelectedRows[0].Cells["StoreID"].Value.ToString();
                    txt_StoreAnm.Text = DGV_Stores.SelectedRows[0].Cells["StoreName"].Value.ToString();
                    txt_StoreEnm.Text = DGV_Stores.SelectedRows[0].Cells["StoreEnm"].Value.ToString();
                }
            }
        }

        private void txt_Branche_ID_KeyPress(object sender, KeyPressEventArgs e)
        {
            lbl_Branche_ID.Text = "";
            if (System.Text.Encoding.UTF8.GetByteCount(new char[] { e.KeyChar }) > 1)
            {
                e.Handled = true;
                lbl_Branche_ID.Text = "English Only";
            }
        }
        private void txt_Branche_ID_TextChanged(object sender, EventArgs e)
        {
            if (txt_Branche_ID.TextLength > 3)
            {
                txt_Branche_ID.Text = txt_Branche_ID.Text.Substring(0, 3);
                txt_Branche_ID.Select(txt_Branche_ID.Text.Length, 0);
            }
        }
        #endregion

        #region Stores Details
        private void textBox_Store_Name_TextChanged(object sender, EventArgs e)
        {
            label_Store_Full_Name.Text = txt_StoreAnm.Text + " (" + DGV_Branches.SelectedRows[0].Cells["BrancheName"].Value.ToString() + ")";
        }
        private void DGV_Stores_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (DGV_Stores.SelectedRows.Count > 0 && DGV_Stores.SelectedRows[0].Cells["StoreID"].Value != null)
            {
                textBox_Store_ID.Text = DGV_Stores.SelectedRows[0].Cells["StoreID"].Value.ToString();
                txt_StoreAnm.Text = DGV_Stores.SelectedRows[0].Cells["StoreName"].Value.ToString();
                txt_StoreEnm.Text = DGV_Stores.SelectedRows[0].Cells["StoreEnm"].Value.ToString();
            }
        }

        #endregion
    }
}
