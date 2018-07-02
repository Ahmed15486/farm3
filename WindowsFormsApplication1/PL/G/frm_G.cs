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
    public partial class frm_G : Form
    {
        #region Declarations
        public string Table;
        BL.BL.G G = new BL.BL.G();
        DataTable dt = new DataTable();
        int record_index;
        #endregion

        public frm_G()
        {
            InitializeComponent();

            dgv.AutoGenerateColumns = false;
        }

        #region Form
        private void frm_G_Shown(object sender, EventArgs e)
        {
            Refresh_Data();
        }
        private void frm_G_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (txt_ID.Text == "") txt_ID.Text = "-1";
        }
        #endregion

        #region Pro
        void Form_Mode(string mode)
        {
            switch (mode)
            {
                #region New
                case "New":
                    btn_New.Visible = false;
                    btn_Edit.Visible = false;
                    btn_Save.Visible = true;
                    btn_Delete.Visible = false;
                    btn_Cancel.Visible = true;

                    dgv.Enabled = false;

                    txt_Name.ReadOnly = false;
                    txt_ID.Text = "";
                    txt_Name.Text = "";

                    txt_Name.Focus();
                    break;
                #endregion

                #region Edit
                case "Edit":

                    btn_New.Visible = false;
                    btn_Edit.Visible = false;
                    btn_Save.Visible = true;
                    btn_Delete.Visible = false;
                    btn_Cancel.Visible = true;

                    txt_Name.ReadOnly = false;
                    txt_Name.Select();
                    dgv.Enabled = false;

                    break;
                #endregion

                #region Select
                case "Select":

                    btn_New.Visible = true;
                    btn_Edit.Visible = true;
                    btn_Save.Visible = false;
                    btn_Delete.Visible = true;
                    btn_Cancel.Visible = false;

                    txt_Name.ReadOnly = true;
                    dgv.Enabled = true;

                    foreach (DataRow r in dt.Rows)
                    {
                        if (r["ID"].ToString() == dgv.SelectedRows[0].Cells[0].Value.ToString())
                        {
                            txt_ID.Text = r["ID"].ToString();
                            txt_Name.Text = r["Name"].ToString();

                            break;
                        }
                    }

                    break;
                #endregion

                #region Empty
                case "Empty":

                    btn_New.Visible = true;
                    btn_Edit.Visible = false;
                    btn_Save.Visible = false;
                    btn_Delete.Visible = false;
                    btn_Cancel.Visible = false;

                    txt_Name.ReadOnly = true;
                    dgv.Enabled = true;
                    if (dgv.CurrentRow != null) dgv.CurrentRow.Selected = false;

                    txt_ID.Text = "";
                    txt_Name.Text = "";

                    break;
                    #endregion
            }
        }
        void var()
        {
            G.ID = (txt_ID.Text != "") ? Convert.ToInt32(txt_ID.Text) : 0;
            G.Name = txt_Name.Text.Trim();
        }
        void Refresh_Data()
        {
            dt = G.Select(Table);
            dgv.DataSource = dt;

            if (dgv.Rows.Count > 0)
            {
                dgv.CurrentCell = dgv.Rows[0].Cells[0];
                Tag = "Select";
                Form_Mode("Select");
            }
            else
            {
                Tag = "Empty";
                Form_Mode("Empty");
            }
        }
        #endregion

        #region Controls
        private void btn_New_Click(object sender, EventArgs e)
        {
            Tag = "New";
            Form_Mode("New");
        }
        private void btn_Edit_Click(object sender, EventArgs e)
        {
            Tag = "Edit";
            Form_Mode("Edit");
            record_index = dgv.SelectedRows[0].Index;
        }
        private void btn_Save_Click(object sender, EventArgs e)
        {
            var();
            if (Tag.ToString() == "New")
            {
                if (txt_Name.Text.Trim() == "")
                {
                    MessageBox.Show("يجب إدخال أسم البيان", "حفظ البيان", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    txt_Name.Focus();
                    return;
                }
                G.Insert(Table);
                Refresh_Data();
                if(dgv.RowCount > 0) dgv.CurrentCell = dgv.Rows[dgv.RowCount - 1].Cells[0];
            }
            else if (Tag.ToString() == "Edit")
            {
                G.Update(Table);
                Refresh_Data();
                dgv.CurrentCell = dgv.Rows[record_index].Cells[0];
            }
            Tag = "Select";
            Form_Mode("Select");
        }
        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل بالفعل تريد الحذف ؟", "حذف", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.No)
            {
                return;
            }

            var();
            G.Delete(Table);
            Refresh_Data();
            if (dgv.RowCount > 0)
            {
                Tag = "Select";
                Form_Mode("Select");
            }
            else
            {
                Tag = "Empty";
                Form_Mode("Empty");
            }
        }
        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            if (Tag.ToString() == "New")
            {
                Tag = "Empty";
                Form_Mode("Empty");
            }
            else if (Tag.ToString() == "Edit")
            {
                Tag = "Select";
                Form_Mode("Select");
            }
        }
        #endregion

        #region dgv
        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Tag.ToString() == "Select" || Tag.ToString() == "Empty")
            {
                Tag = "Select";
                Form_Mode("Select");
            }
        }
        #endregion
    }
}
