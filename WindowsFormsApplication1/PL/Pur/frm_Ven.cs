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
    public partial class frm_Ven : Form
    {
        #region Declarations
        public int UserID;
        BL.BL.Ven ven = new BL.BL.Ven();
        BL.BL.ACC acc = new BL.BL.ACC();
        DataTable dt = new DataTable();
        DataTable dt_ACC = new DataTable();
        int RowIndex;
        #endregion

        public frm_Ven()
        {
            InitializeComponent();

            dgv.AutoGenerateColumns = false;

            dt_ACC = acc.Select3("Select * From ACC Where ACCProperID = 2");
            com_ParentACC.DataSource = dt_ACC;
            Fill();
        }

        #region Pro
        void Fill()
        {
            dt = ven.Select();
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
                    txt_Name.ReadOnly = true;
                    txt_RespoName.ReadOnly = true;
                    txt_Mobile1.ReadOnly = true;
                    txt_Mobile2.ReadOnly = true;
                    txt_Phone1.ReadOnly = true;
                    txt_Phone2.ReadOnly = true;
                    txt_Email.ReadOnly = true;
                    com_ParentACC.Enabled = false;
                    btn_ParentACC_Del.Visible = false;


                    foreach (DataRow r in dt.Rows)
                    {
                        if (r["ID"].ToString() == dgv.SelectedRows[0].Cells[0].Value.ToString())
                        {
                            txt_ID.Text = r["ID"].ToString();
                            txt_Name.Text = r["Name"].ToString();
                            txt_RespoName.Text = r["RespoName"].ToString();
                            txt_Mobile1.Text = r["Mobile1"].ToString();
                            txt_Mobile2.Text = r["Mobile2"].ToString();
                            txt_Phone1.Text = r["Phone1"].ToString();
                            txt_Phone2.Text = r["Phone2"].ToString();
                            txt_Email.Text = r["Email"].ToString();
                            txt_Balance.Text = r["Balance"].ToString();
                            com_ParentACC.SelectedValue = r["ParentACCID"];
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
                    txt_Name.ReadOnly = false;
                    txt_RespoName.ReadOnly = false;
                    txt_Mobile1.ReadOnly = false;
                    txt_Mobile2.ReadOnly = false;
                    txt_Phone1.ReadOnly = false;
                    txt_Phone2.ReadOnly = false;
                    txt_Email.ReadOnly = false;
                    com_ParentACC.Enabled = true;
                    btn_ParentACC_Del.Visible = true;

                    txt_Name.Focus();
                    dgv.ClearSelection();
                    txt_ID.Text = "";
                    txt_Name.Text = "";
                    txt_RespoName.Text = "";
                    txt_Mobile1.Text = "";
                    txt_Mobile2.Text = "";
                    txt_Phone1.Text = "";
                    txt_Phone2.Text = "";
                    txt_Email.Text = "";
                    txt_Balance.Text = "";
                    com_ParentACC.SelectedValue = -1;
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
                    txt_Name.ReadOnly = false;
                    txt_RespoName.ReadOnly = false;
                    txt_Mobile1.ReadOnly = false;
                    txt_Mobile2.ReadOnly = false;
                    txt_Phone1.ReadOnly = false;
                    txt_Phone2.ReadOnly = false;
                    txt_Email.ReadOnly = false;
                    com_ParentACC.Enabled = false;
                    btn_ParentACC_Del.Visible = false;
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
                    txt_Name.ReadOnly = true;
                    txt_RespoName.ReadOnly = true;
                    txt_Mobile1.ReadOnly = true;
                    txt_Mobile2.ReadOnly = true;
                    txt_Phone1.ReadOnly = true;
                    txt_Phone2.ReadOnly = true;
                    txt_Email.ReadOnly = true;
                    com_ParentACC.Enabled = true;
                    btn_ParentACC_Del.Visible = false;


                    dgv.ClearSelection();
                    txt_ID.Text = "";
                    txt_Name.Text = "";
                    txt_RespoName.Text = "";
                    txt_Mobile1.Text = "";
                    txt_Mobile2.Text = "";
                    txt_Phone1.Text = "";
                    txt_Phone2.Text = "";
                    txt_Email.Text = "";
                    txt_Balance.Text = "";
                    com_ParentACC.SelectedValue = -1;
                    break;
                    #endregion
            }
        }
        void var()
        {
            ven.ID = (txt_ID.Text != "") ? Convert.ToInt32(txt_ID.Text) : 0;
            ven.Name = txt_Name.Text.Trim();
            ven.RespoName = txt_RespoName.Text.Trim();
            ven.Mobile1 = txt_Mobile1.Text.Trim();
            ven.Mobile2 = txt_Mobile2.Text.Trim();
            ven.Phone1 = txt_Phone1.Text.Trim();
            ven.Phone2 = txt_Phone2.Text.Trim();
            ven.Email = txt_Email.Text.Trim();
            ven.ParentACCID = (com_ParentACC.SelectedValue != null) ? com_ParentACC.SelectedValue.ToString() : "0";
            ven.UserID = UserID;
        }
        #endregion

        #region Form
        private void frm_cust_Shown(object sender, EventArgs e)
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
            if(com_ParentACC.SelectedValue == null)
            {
                MessageBox.Show("يجب إختيار الحساب الذي سوف يندرج تحته في دليل الحسابات");
                com_ParentACC.DroppedDown = true;
                return;
            }
            var();

            #region New
            if (Tag.ToString() == "New")
            {
                string t = ven.Insert();
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
                string t = ven.Update();
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
            if (dgv.CurrentCell != null)
            {
                if (DialogResult.Yes == MessageBox.Show("هل تريد بالفعل حذف المورد المحدد ؟", "تأكيد الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    //Delete Item In DataBase
                    ven.ID = Convert.ToInt32(txt_ID.Text);
                    string t = ven.Delete();
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

        #region Details
        private void btn_ParentACC_Del_Click(object sender, EventArgs e)
        {
            com_ParentACC.SelectedValue = -1;
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
        #endregion
    }
}
