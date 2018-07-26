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
    public partial class frm_ACC : Form
    {
        #region Declarations
        public int UserID;
        BL.BL.ACC acc = new BL.BL.ACC();
        DataTable dt = new DataTable();
        BL.BL.G g = new BL.BL.G();
        int level = 1;
        List<string> ParentID = new List<string>();
        int RowIndex;
        #endregion

        public frm_ACC()
        {
            InitializeComponent();

            dgv.AutoGenerateColumns = false;
            com_ACCProper.DataSource = g.Select("ACCProper");
            Fill();
        }

        #region Pro
        void Fill()
        {
            dt = acc.Select();
            dt.DefaultView.RowFilter = (ParentID.Count == 0) ? "ParentID IS NULL" : "ParentID = " + ParentID[ParentID.Count - 1];
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
                    txt_ItemName.ReadOnly = true;
                    com_ACCProper.Enabled = false;

                    foreach (DataRow r in dt.Rows)
                    {
                        if (r["ID"].ToString() == dgv.SelectedRows[0].Cells[0].Value.ToString())
                        {
                            txt_ID.Text = r["ID"].ToString();
                            txt_ItemName.Text = r["Name"].ToString();
                            com_ACCProper.SelectedValue = r["ACCProperID"];
                            txt_Balance.Text = r["Balance"].ToString();
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
                    txt_ItemName.ReadOnly = false;
                    com_ACCProper.Enabled = true;

                    dgv.ClearSelection();
                    txt_ID.Text = "";
                    txt_ItemName.Text = "";
                    com_ACCProper.SelectedValue = -1;
                    txt_ItemName.Focus();
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
                    txt_ItemName.ReadOnly = false;
                    com_ACCProper.Enabled = true;
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
                    txt_ItemName.ReadOnly = true;
                    com_ACCProper.Enabled = false;

                    dgv.ClearSelection();
                    txt_ID.Text = "";
                    txt_ItemName.Text = "";
                    com_ACCProper.Text = "";
                    break;
                    #endregion
            }
        }

        void var()
        {
            acc.ID = (txt_ID.Text != "") ? txt_ID.Text : null;
            acc.Name = txt_ItemName.Text;
            acc.ACCProperID = (com_ACCProper.SelectedValue == null)? 0 : Convert.ToInt32(com_ACCProper.SelectedValue);
            acc.Level = level;
            acc.ParentID = (ParentID.Count > 0) ? ParentID[ParentID.Count - 1] : null;
            acc.UserID = UserID;
        }
        #endregion

        #region Form
        private void frm_ItemsCard_Shown(object sender, EventArgs e)
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
            if (txt_ItemName.Text.Trim() == "")
            {
                MessageBox.Show("يجب إدخال التعريف");
                txt_ItemName.Focus();
                return;
            }
            var();
            if (Tag.ToString() == "New")
            {
                acc.Insert();
                Fill();
                if(dgv.RowCount > 0) dgv.CurrentCell = dgv.Rows[dgv.RowCount - 1].Cells[0];
                Form_Mode("Select");
            }
            else if (Tag.ToString() == "Edit")
            {
                acc.Update();
                Fill();
                dgv.CurrentCell = dgv.Rows[RowIndex].Cells[0];
                Form_Mode("Select");
            }

        }
        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (dgv.CurrentCell != null)
            {
                if (dgv.SelectedRows[0].Cells["Used"].Value.ToString() == "1")
                {
                    MessageBox.Show("هذا الحساب مستخدم ولا يمكن حذفه");
                    return;
                }

                if (DialogResult.Yes == MessageBox.Show("هل تريد بالفعل حذف الصنف المحدد ؟", "تأكيد الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    //Delete Item In DataBase
                    acc.ID = txt_ID.Text;
                    string t = acc.Delete();
                    if (t.Length > 2)
                    {
                        if (t.Substring(0, 3) == "SQL")
                        {
                            MessageBox.Show(t);
                            Form_Mode("Select");
                            return;
                        }
                    }
                    Fill();
                }
            }
            Form_Mode("Empty");
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
        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Tag.ToString() == "Select" || Tag.ToString() == "Empty")
            {
                Form_Mode("Select");
            }
        }
        private void dgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv.SelectedRows[0].Cells["Used"].Value.ToString() == "1")
            {
                MessageBox.Show("هذا الحساب مستخدم ولا يمكن التفرع منه");
                return;
            }
            if (dgv.SelectedRows.Count != 0)
            {
                ParentID.Add(dgv.SelectedRows[0].Cells[0].Value.ToString());
                level++;
                dt.DefaultView.RowFilter = "ParentID = " + ParentID[ParentID.Count - 1];

                if (dgv.RowCount > 0)
                {
                    dgv.CurrentCell = dgv.Rows[0].Cells[0];
                    Form_Mode("Select");
                }
                else
                {
                    Form_Mode("Empty");
                }
                grbx_SubDetails.Visible = true;
            }
        }
        #endregion

        #region Details
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
                    if (r.Cells[0].Value.ToString() == i)
                    {
                        dgv.CurrentCell = dgv.Rows[r.Index].Cells[0];
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
                dt.DefaultView.RowFilter = "ParentID = " + ParentID[ParentID.Count - 1];
                foreach (DataGridViewRow r in dgv.Rows)
                {
                    if (r.Cells[0].Value.ToString() == i)
                    {
                        dgv.CurrentCell = dgv.Rows[r.Index].Cells[0];
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
        private void btn_Unit_Add_Click(object sender, EventArgs e)
        {
            G.frm_G frm_g = new G.frm_G();
            frm_g.Table = "Units";
            frm_g.Text = "الوحدات";
            frm_g.ShowDialog();
            com_ACCProper.DataSource = g.Select("Units");
            com_ACCProper.SelectedValue = frm_g.txt_ID.Text;
        }
        #endregion
    }
}
