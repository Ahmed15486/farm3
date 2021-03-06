﻿using System;
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
    public partial class Tat3eemWithdrawAdd : Form
    {
        #region Declarations
        G.frm_Search s = new G.frm_Search();
        BL.BL.Items items = new BL.BL.Items();
        DataTable dt_Items = new DataTable();
        DataRow dr_Sal;


        public DataGridView dgv;
        public TextBox txt_TotalPPrice;
        public int rowindex;
        public bool edit;
        #endregion

        public Tat3eemWithdrawAdd()
        {
            InitializeComponent();

            dt_Items = items.Select2();
            com_Item_Name.DataSource = dt_Items;
        }

        #region Pro
        public void AddRow()
        {
            dgv.Rows.Add();
            dgv.CurrentCell = dgv.Rows[dgv.Rows.Count - 1].Cells[0];

            dgv.CurrentRow.Cells["ID"].Value = com_Item_Name.SelectedValue.ToString();
            dgv.CurrentRow.Cells["Name"].Value = com_Item_Name.Text;
            dgv.CurrentRow.Cells["Quan"].Value = txt_Quan.Text;
            dgv.CurrentRow.Cells["SPrice"].Value = txt_SPrice.Text;
            dgv.CurrentRow.Cells["Total"].Value = Math.Round(Convert.ToDecimal(txt_Quan.Text) * Convert.ToDecimal(txt_SPrice.Text), 2).ToString();
            Console.Beep();
            decimal pp = Math.Round(Convert.ToDecimal((txt_TotalPPrice.Text == "") ? "0" : txt_TotalPPrice.Text), 2) + Convert.ToDecimal(dgv.CurrentRow.Cells["Total"].Value);
            txt_TotalPPrice.Text = pp.ToString();
        }
        #endregion

        #region Form
        private void frm_OpenAdd_Shown(object sender, EventArgs e)
        {
            if (edit != true)
            {
                com_Item_Name.DataSource = dt_Items;
                com_Item_Name.SelectedValue = -1;
            }

            edit = false;
            com_Item_Name.Focus();
        }
        #endregion

        #region GroupBox_Details

        // Itam_Name
        private void com_Item_Name_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (com_Item_Name.SelectedValue == null) { return; }
            foreach (DataRow dr in dt_Items.Rows)
            {
                if (dr["ID"] == com_Item_Name.SelectedValue)
                {
                    dr_Sal = dr;
                }
            }

            txt_Quan.Text = "1";
            txt_SPrice.Text = dr_Sal["Cost"].ToString();
        }
        private void com_Item_Name_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                e.Handled = true;
                txt_Quan.Focus();
            }
        }
        private void btn_Item_Search_Click(object sender, EventArgs e)
        {
            s.Text = "بحث عن صنف";

            s.dt = dt_Items;

            s.dgv.Columns[0].DataPropertyName = "ID";
            s.dgv.Columns[1].DataPropertyName = "Name";

            s.dgv.AutoGenerateColumns = false;
            s.dgv.DataSource = s.dt;
            s.ShowDialog();

            com_Item_Name.Text = s.txt;
        }
        private void btn_Item_Edit_Click(object sender, EventArgs e)
        {
            PL.Store.frm_Items i = new PL.Store.frm_Items();
            i.FormBorderStyle = FormBorderStyle.Sizable;
            i.ShowDialog();
            dt_Items = items.Select2();
            com_Item_Name.DataSource = dt_Items;
            com_Item_Name.SelectedValue = i.txt_ID.Text;
        }
        // Quan
        private void txt_Quan_KeyPress(object sender, KeyPressEventArgs e)
        {
            #region Only Number
            // only numbers
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
                if (e.KeyChar != 043) { System.Media.SystemSounds.Hand.Play(); ; }
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
                System.Media.SystemSounds.Hand.Play();
            }
            #endregion

            // if press +  if enter
            if (e.KeyChar == 043)
            {
                e.Handled = true;
                btn_Add_Click(null, null);
            }
            else if (e.KeyChar == 13)
            {
                e.Handled = true;
                txt_SPrice.Focus();
            }
        }

        // CPrice
        private void txt_CPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            #region Only Numbers
            // only numbers
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
                if (e.KeyChar != 043) { System.Media.SystemSounds.Hand.Play(); ; }
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
                System.Media.SystemSounds.Hand.Play();
            }
            #endregion

            if (e.KeyChar == 043)
            {
                e.Handled = true;
                btn_Add_Click(null, null);

            }
            else if (e.KeyChar == 13)
            {
                e.Handled = true;
                btn_Add_Click(null, null);
            }
        }
        #endregion

        #region Controls
        private void btn_Add_Click(object sender, EventArgs e)
        {
            txt_Quan.Text = (txt_Quan.Text.Trim() == "" | txt_Quan.Text.Trim() == ".") ? "1" : txt_Quan.Text.Trim();
            txt_SPrice.Text = (txt_SPrice.Text.Trim() == "" | txt_SPrice.Text.Trim() == ".") ? "0" : txt_SPrice.Text.Trim();

            if (com_Item_Name.SelectedValue == null)
            {
                MessageBox.Show("يجب تحديد الصنف", "! حقل فارغ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                com_Item_Name.Focus();
                com_Item_Name.DroppedDown = true;
                return;
            }

            if (Convert.ToDecimal(txt_SPrice.Text) == 0)
            {
                MessageBox.Show("يجب تحديد سعر التكلفة", "! حقل فارغ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txt_SPrice.Text = "";
                txt_SPrice.Focus();
                return;
            }

            if (btn_Add.Text != "تعديل")
            {
                AddRow();

                com_Item_Name.SelectedValue = -1;
                txt_Quan.Text = "";
                txt_SPrice.Text = "";
            }
            else
            {
                dgv.Rows[rowindex].Cells["ID"].Value = com_Item_Name.SelectedValue.ToString();
                dgv.Rows[rowindex].Cells["Name"].Value = com_Item_Name.Text;
                dgv.Rows[rowindex].Cells["Quan"].Value = txt_Quan.Text;
                dgv.Rows[rowindex].Cells["SPrice"].Value = txt_SPrice.Text;
                dgv.Rows[rowindex].Cells["Total"].Value = Math.Round(Convert.ToDecimal(txt_Quan.Text) * Convert.ToDecimal(txt_SPrice.Text), 2).ToString();

                Hide();
            }
            com_Item_Name.Focus();
        }
        #endregion
    }
}
