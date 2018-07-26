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
    public partial class frm_Items : Form
    {
        #region Declarations
        BL.BL.Items2 items2 = new BL.BL.Items2();
        DataTable dt = new DataTable();
        BL.BL.G g = new BL.BL.G();
        int level = 1;
        List<string> ParentID = new List<string>();
        int RowIndex;
        public int UserID;
        PL.G.frm_Main frm_Main = new G.frm_Main();
        #endregion

        public frm_Items()
        {
            InitializeComponent();

            dgv.AutoGenerateColumns = false;
            com_Unit.DataSource = g.Select("Units");
            Fill();
        }

        #region Pro
        void Fill()
        {
            dt = items2.Select();
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
                    txt_PPrice.ReadOnly = true;
                    txt_SPrice.ReadOnly = true;
                    com_Unit.Enabled = false;

                    foreach (DataRow r in dt.Rows)
                    {
                        if (r["ID"].ToString() == dgv.SelectedRows[0].Cells[0].Value.ToString())
                        {
                            txt_ID.Text = r["ID"].ToString();
                            txt_ItemName.Text = r["Name"].ToString();
                            txt_PPrice.Text = r["PPrice"].ToString();
                            txt_SPrice.Text = r["SPrice"].ToString();
                            txt_CPrice.Text = r["CPrice"].ToString();
                            com_Unit.SelectedValue = r["Unit"];
                            txt_Quan.Text = r["Quan"].ToString();
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
                    txt_PPrice.ReadOnly = false;
                    txt_SPrice.ReadOnly = false;
                    com_Unit.Enabled = true;

                    dgv.ClearSelection();
                    txt_ID.Text = "";
                    txt_ItemName.Text = "";
                    txt_PPrice.Text = "";
                    txt_SPrice.Text = "";
                    txt_CPrice.Text = "";
                    com_Unit.SelectedValue = -1;
                    txt_Quan.Text = "";
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
                    txt_PPrice.ReadOnly = false;
                    txt_SPrice.ReadOnly = false;
                    com_Unit.Enabled = true;
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
                    txt_PPrice.ReadOnly = true;
                    txt_SPrice.ReadOnly = true;
                    com_Unit.Enabled = false;

                    dgv.ClearSelection();
                    txt_ID.Text = "";
                    txt_ItemName.Text = "";
                    txt_PPrice.Text = "";
                    txt_SPrice.Text = "";
                    txt_CPrice.Text = "";
                    com_Unit.SelectedValue = -1;
                    txt_Quan.Text = "";
                    break;
                    #endregion
            }
        }
        void var()
        {
            items2.ID = (txt_ID.Text != "") ? txt_ID.Text : null;
            items2.Name = txt_ItemName.Text;
            items2.PPrice = txt_PPrice.Text.Trim() != "" ? Convert.ToDecimal(txt_PPrice.Text.Trim()) : 0;
            items2.SPrice = txt_SPrice.Text.Trim() != "" ? Convert.ToDecimal(txt_SPrice.Text.Trim()) : 0;
            items2.CPrice = txt_CPrice.Text.Trim() != "" ? Convert.ToDecimal(txt_CPrice.Text.Trim()) : 0;
            items2.Unit = Convert.ToInt32(com_Unit.SelectedValue);
            items2.Quan = txt_Quan.Text.Trim() != "" ? Convert.ToDecimal(txt_Quan.Text.Trim()) : 0;
            items2.Level = level;
            items2.ParentID = (ParentID.Count > 0) ? ParentID[ParentID.Count - 1] : null;
            items2.UserID = UserID;
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
            if (txt_ItemName.Text.Trim() == "")
            {
                MessageBox.Show("يجب إدخال التعريف");
                txt_ItemName.Focus();
                return;
            }
            if(grbx_SubDetails.Visible == true && com_Unit.SelectedValue == null)
            {
                MessageBox.Show("يجب اختيار الوحدة");
                com_Unit.DroppedDown = true;
                return;
            }
            #endregion

            var();

            #region New
            if (Tag.ToString() == "New")
            {
                string t = items2.Insert();
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
                string t = items2.Update();
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

            frm_Main.FillChart();
        }
        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (dgv.CurrentCell != null)
            {
                if (DialogResult.Yes == MessageBox.Show("هل تريد بالفعل حذف الصنف المحدد ؟", "تأكيد الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    items2.ID = txt_ID.Text;
                    string t = items2.Delete();
                    if (t.Length > 2)
                    {
                        if (t.Substring(0, 3) == "SQL")
                        {
                            MessageBox.Show(t);
                            return;
                        }
                    }
                    Fill();
                    Form_Mode("Empty");
                    frm_Main.FillChart();
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
        private void dgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv.SelectedRows[0].Cells["Used"].Value.ToString() == "True")
            {
                MessageBox.Show("هذا الصنف مستخدم ولا يمكن التفرع منه");
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
            com_Unit.DataSource = g.Select("Units");
            com_Unit.SelectedValue = frm_g.txt_ID.Text;
        }
        #endregion
    }
}
