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
    public partial class frm_JorB : Form
    {
        #region Declarations
        BL.BL.JorB jorb = new BL.BL.JorB();
        DataSet st = new DataSet();
        DataTable dt = new DataTable();
        PL.ACC.frm_JorBAdd add = new frm_JorBAdd();
        DataTable Temp_dgv = new DataTable();
        #endregion

        public frm_JorB()
        {
            InitializeComponent();

            st = jorb.JorB_StartSelect();


            com_DocType.DataSource = st.Tables[0];
            com_DocPayType.DataSource = st.Tables[1];


            #region DGV
            var Side = new DataGridViewComboBoxColumn();
            Side.Name = "Side";
            Side.HeaderText = "الجانب";
            Side.DataPropertyName = "Side";
            Side.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Side.Width = 100;
            Side.FlatStyle = FlatStyle.Popup;
            Side.DataSource = st.Tables[4];
            Side.ValueMember = "ID";
            Side.DisplayMember = "Name";
            dgv.Columns.Add(Side);

            var Value = new DataGridViewComboBoxColumn();
            Value.Name = "Value";
            Value.HeaderText = "القيمة";
            Value.DataPropertyName = "Value";
            Value.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Value.Width = 150;
            Value.FlatStyle = FlatStyle.Popup;
            Value.DataSource = st.Tables[2];
            Value.ValueMember = "ID";
            Value.DisplayMember = "Name";
            dgv.Columns.Add(Value);

            var Rate = new DataGridViewTextBoxColumn();
            Rate.Name = "Rate";
            Rate.HeaderText = "النسبة %";
            Rate.DataPropertyName = "Rate";
            Rate.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Rate.Width = 100;
            dgv.Columns.Add(Rate);

            var ACC_Name = new DataGridViewComboBoxColumn();
            ACC_Name.Name = "ACC";
            ACC_Name.HeaderText = "أسم الحساب";
            ACC_Name.DataPropertyName = "ACCID";
            ACC_Name.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            ACC_Name.Width = 130;
            ACC_Name.FlatStyle = FlatStyle.Popup;
            ACC_Name.DataSource = st.Tables[3];
            ACC_Name.ValueMember = "ID";
            ACC_Name.DisplayMember = "Name";
            dgv.Columns.Add(ACC_Name);

            var ACCInDoc = new DataGridViewCheckBoxColumn();
            ACCInDoc.Name = "ACCInDoc";
            ACCInDoc.HeaderText = "حساب بالسند";
            ACCInDoc.DataPropertyName = "ACCInBillID";
            ACCInDoc.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            ACCInDoc.Width = 130;
            ACCInDoc.FlatStyle = FlatStyle.Popup;
            dgv.Columns.Add(ACCInDoc);

            var Notes = new DataGridViewTextBoxColumn();
            Notes.Name = "Notes";
            Notes.HeaderText = "البيان";
            Notes.DataPropertyName = "Notes";
            Notes.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Notes.Width = 200;
            dgv.Columns.Add(Notes);
            #endregion

            dgv.AutoGenerateColumns = false;
        }

        #region Pro
        void var()
        {
            jorb.DocTypeID = Convert.ToInt32(com_DocType.SelectedValue);
            jorb.DocPayTypeID = Convert.ToInt32(com_DocPayType.SelectedValue);
            jorb.dt_JorB = IO();
        }
        private DataTable IO()
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
                    if (cell.Value == null) { dRow[cell.ColumnIndex] = null; }
                    else if (cell.Value.ToString() == "") { dRow[cell.ColumnIndex] = null; }
                    else { dRow[cell.ColumnIndex] = cell.Value; }
                }
                dt.Rows.Add(dRow);
            }
            return dt;
        }
        #endregion

        #region Form
        private void frm_JorB_Shown(object sender, EventArgs e)
        {
            jorb.DocTypeID = Convert.ToInt32(com_DocType.SelectedValue);
            jorb.DocPayTypeID = Convert.ToInt32(com_DocPayType.SelectedValue);
            dt = jorb.JorB_Select();
            dgv.DataSource = dt;
        }
        #endregion

        #region Header
        private void com_DocType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(com_DocType.Focused)
            {
                if(com_DocType.SelectedValue.ToString() == "9" || com_DocType.SelectedValue.ToString() == "10")
                {
                    lbl_DocPayType.Visible = false;
                    com_DocPayType.Visible = false;
                }
                else
                {
                    lbl_DocPayType.Visible = true;
                    com_DocPayType.Visible = true;
                }

                jorb.DocTypeID = Convert.ToInt32(com_DocType.SelectedValue);
                jorb.DocPayTypeID = Convert.ToInt32(com_DocPayType.SelectedValue);
                dt = jorb.JorB_Select();
                dgv.DataSource = dt;
                btn_Save.Visible = false;
            }
        }
        private void com_DocPayType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(com_DocPayType.Focused)
            {
                jorb.DocTypeID = Convert.ToInt32(com_DocType.SelectedValue);
                jorb.DocPayTypeID = Convert.ToInt32(com_DocPayType.SelectedValue);
                dt = jorb.JorB_Select();
                dgv.DataSource = dt;
                btn_Save.Visible = false;
            }
        }
        #endregion

        #region Control
        private void btn_Save_Click(object sender, EventArgs e)
        {
            var();
            jorb.JorB_Insert();
            btn_Save.Visible = false;
        }
        private void btn_Add_Click(object sender, EventArgs e)
        {
            if(dgv.RowCount > 0)
            {        
                Temp_dgv = IO();
                dgv.DataSource = null;
                dgv.Rows.Clear();
                foreach (DataRow row in Temp_dgv.Rows)
                {
                    dgv.Rows.Add();
                    dgv.CurrentCell = dgv.Rows[dgv.Rows.Count - 1].Cells[0];

                    int s = Convert.ToInt32(row["Side"]);
                    dgv.CurrentRow.Cells["Side"].Value = s;
                    int v = Convert.ToInt32(row["Value"]);
                    dgv.CurrentRow.Cells["Value"].Value = v;
                    dgv.CurrentRow.Cells["Rate"].Value = Convert.ToInt32(row["Rate"]);
                    string a = row["ACC"].ToString();
                    dgv.CurrentRow.Cells["ACC"].Value = a;
                    dgv.CurrentRow.Cells["ACCInDoc"].Value = (a == "")? true : false;
                    dgv.CurrentRow.Cells["Notes"].Value = row["Notes"].ToString();
                }
            }

            add.dgv = dgv;
            add.btn_Save = btn_Save;

            add.Text = "إضافة";
            add.btn_Add.Text = "+ إضافة";

            add.com_Value.DataSource = st.Tables[2];
            add.com_Side.DataSource = st.Tables[4];
            add.com_ACC.DataSource = st.Tables[3];

            add.com_Value.SelectedValue = -1;
            add.num_Rate.Value = 100;
            add.com_Side.SelectedValue = -1;
            add.com_ACC.SelectedValue = -1;
            add.chk_ACCInDoc.Checked = true;
            add.txt_Notes.Text = "";

            add.Location = new Point(Location.X + ((Width / 2) - add.Width / 2), Location.Y + 120);
            add.ShowDialog();
        }
        #endregion

        #region dgv
        private void dgv_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            btn_Save.Visible = true;
        }
        #endregion
    }
}
