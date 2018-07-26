using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1.PL.Rep
{
    public partial class frm_RepDes : Form
    {
        #region Declarations
        public int UserID;
        BL.BL.Rep rep = new BL.BL.Rep();

        ListBox lst_Translated = new ListBox();
        DateTimePicker dtp;
        DataTable dt_Rep_Info;
        DataTable dt_Rep;
        DataTable dt_RepD;
        DataTable dt_g;
        DataTable Temp_dgv;
        DataRow dr_g;
        Microsoft.Office.Interop.Excel.Range myRange;
        Microsoft.Office.Interop.Excel.Range lastcol;
        Microsoft.Office.Interop.Excel.Range firstrow;

        public string Rep_TABLE_NAME;
        public string Rep_TABLE_SCHEMA;

        string select;
        string top;
        string from;
        string where;
        string condition;
        string nocondition;
        string Mcondition;
        string logcondition;
        string m;
        string union;

        Color c;
        #endregion

        public frm_RepDes()
        {
            InitializeComponent();
           
            tab_dis.TabPages.RemoveAt(2);

            dtp = new DateTimePicker();
            dtp.Format = DateTimePickerFormat.Short;
            dtp.Visible = false;
            dtp.Width = 120;
            dgv_Conditions.Controls.Add(dtp);
            dtp.ValueChanged += this.dtp_Value_Changed;

            dt_RepD = rep.Select_Rep("select * from RepD");
            //dt_g.DefaultView.RowFilter = string.Format("Rep_View = '" + Rep_TABLE_NAME + "' and User_ID = " + UserID.ToString());


            if (com_SelectedRep.SelectedValue == null)
            {
                dt_RepD.DefaultView.RowFilter = string.Format("Rep_ID = -1 ");
            }
            else
            {
                dt_RepD.DefaultView.RowFilter = string.Format("Rep_ID = " + com_SelectedRep.SelectedValue.ToString());
            }
            dgv_Conditions.AutoGenerateColumns = false;

            Temp_dgv = table(1);
            dgv_Conditions.DataSource = null;
            foreach (DataRow row in Temp_dgv.Rows)
            {
                dgv_Conditions.Rows.Add();
                dgv_Conditions.CurrentCell = dgv_Conditions.Rows[0].Cells[0];

                dgv_Conditions.CurrentRow.Cells[0].Value = row[0].ToString();
                dgv_Conditions.CurrentRow.Cells[1].Value = row[1].ToString();
                dgv_Conditions.CurrentRow.Cells[2].Value = row[2].ToString();
                dgv_Conditions.CurrentRow.Cells[3].Value = row[3].ToString();
                dgv_Conditions.CurrentRow.Cells[4].Value = row[4].ToString();
                dgv_Conditions.CurrentRow.Cells[5].Value = row[5].ToString();
                dgv_Conditions.CurrentRow.Cells[6].Value = row[6].ToString();

            }
            dgv_Conditions.AllowUserToAddRows = true;
        }

        #region Pro
        string SELECT(int i)
        {
            string t = "";
            select = "SELECT ";
            TOP();
            union = "";
            bool u = false;
            if (i > -1)
            {
                foreach (string item in lst_Translated.Items)
                {
                    com_Fields.Text = item;
                    if (com_Fields.SelectedValue.ToString() != "decimal" && item == TranArToEn(dgv_Conditions.Rows[i].Cells[0].Value.ToString()))
                    {
                        select += ",[" + item + "] ";
                        union += ",null";
                    }
                    else
                    {
                        if (com_Fields.SelectedValue.ToString() == "decimal")
                        {
                            select += ",SUM([" + item + "]) as [" + item + "] ";

                            if (item == "الرصيد")
                            {
                                union += ",null";
                            }
                            else
                            {
                                union += ",SUM([" + item + "]) ";
                                u = true;
                            }
                        }
                    }
                }
            }
            else
            {
                foreach (string item in lst_Translated.Items)
                {
                    com_Fields.Text = item;
                    select += ",[" + item + "] ";

                    if (com_Fields.SelectedValue.ToString() != "decimal")
                    {
                        union += ",null";
                    }
                    else
                    {
                        if (item == "الرصيد")
                        {
                            union += ",null";
                        }
                        else
                        {
                            union += ",SUM([" + item + "]) ";
                            u = true;
                        }
                    }
                }
            }
            if (u == false) { union = ""; }
            if (top == "")
            {
                return select.Substring(0, 7) + select.Substring(8);
            }
            else
            {
                select = select.Substring(0, 7) + top + select.Substring(8);
                return select;
            }
        }
        string TOP()
        {
            top = "";
            if (rad_Only.Checked)
            {
                top = "TOP " + num_TopRecords.Value.ToString() + " ";
            }
            return top;
        }
        string FROM()
        {
            return from = "\r\nFROM " + Rep_TABLE_NAME + " ";
        }
        string WHERE()
        {
            where = "\r\nWHERE ";
            condition = "";
            for (int i = 0; i < dgv_Conditions.Rows.Count; i++)
            {
                if (dgv_Conditions.Rows[i].Cells[0].Value == null || dgv_Conditions.Rows[i].Cells[2].Value == null || dgv_Conditions.Rows[i].Cells[3].Value == null) { continue; }

                com_Fields.Text = TranArToEn(dgv_Conditions.Rows[i].Cells[0].Value.ToString());

                if (dgv_Conditions.Rows[i].Cells[0].Value.ToString() != "" && dgv_Conditions.Rows[i].Cells[2].Value.ToString() != "" && dgv_Conditions.Rows[i].Cells[3].Value.ToString() != "")
                {
                    if (dgv_Conditions.Rows[i].Cells[2].Value.ToString() == "يبدأ بـ")
                    {
                        where += log(i - 1) + "[" + TranArToEn(dgv_Conditions.Rows[i].Cells[0].Value.ToString()) + "] " + no(i) + " LIKE '" + dgv_Conditions.Rows[i].Cells[3].Value + "%' ";
                        Mcondition = "يبدأ بـ ";
                    }
                    else if (dgv_Conditions.Rows[i].Cells[2].Value.ToString() == "يتضمن")
                    {
                        where += log(i - 1) + "[" + TranArToEn(dgv_Conditions.Rows[i].Cells[0].Value.ToString()) + "] " + no(i) + " LIKE '%" + dgv_Conditions.Rows[i].Cells[3].Value + "%' ";
                        Mcondition = "يتضمن ";
                    }
                    else if (com_Fields.SelectedValue.ToString() != "decimal")
                    {
                        where += log(i - 1) + "[" + TranArToEn(TranArToEn(dgv_Conditions.Rows[i].Cells[0].Value.ToString())) + "] " + no(i) + M(i) + "'" + dgv_Conditions.Rows[i].Cells[3].Value.ToString() + "' ";
                    }
                    else
                    {
                        where += log(i - 1) + "[" + TranArToEn(dgv_Conditions.Rows[i].Cells[0].Value.ToString()) + "] " + no(i) + M(i) + dgv_Conditions.Rows[i].Cells[3].Value + " ";
                    }

                    condition += logcondition + dgv_Conditions.Rows[i].Cells[0].Value.ToString() + " " + nocondition + Mcondition + dgv_Conditions.Rows[i].Cells[3].Value.ToString() + " ";
                }
            }

            if (where == "\r\nWHERE ") { where = ""; condition = ""; }
            return where;
        }
        void ORDER_BY()
        {
            foreach (DataGridViewRow r in dgv_Conditions.Rows)
            {
                if (r.Cells[6].Value != null && r.Cells[0].Value != null)
                {
                    if (r.Cells[6].Value.ToString() == "تصاعدياً")
                    {
                        dt_Rep.DefaultView.Sort = r.Cells[0].Value.ToString() + " ASC";
                        dt_Rep = dt_Rep.DefaultView.ToTable();
                    }
                    else if (r.Cells[6].Value.ToString() == "تنازلياً")
                    {
                        dt_Rep.DefaultView.Sort = r.Cells[0].Value.ToString() + " DESC";
                        dt_Rep = dt_Rep.DefaultView.ToTable();
                    }
                }
            }
        }
        string UNION_ALL()
        {
            if (union == "")
            {
                from = "";
                where = "";
                return "";
            }
            else
            {
                return "\r\nUNION ALL \r\nSELECT " + union.Substring(1);
            }
        }

        string no(int i)
        {
            nocondition = "";
            string n = "";
            if (i < 0) { return n; }

            if (Convert.ToBoolean(dgv_Conditions.Rows[i].Cells[1].Value) == true)
            {
                n = "!";
                nocondition = "ليس ";
            }
            return n;
        }
        string log(int i)
        {
            string l = "AND ";
            logcondition = "  و  ";
            if (i < 0) { l = ""; return l; }

            if (dgv_Conditions.Rows[i].Cells[0].Value == null | dgv_Conditions.Rows[i].Cells[2].Value == null | dgv_Conditions.Rows[i].Cells[3].Value == null)
            {
                l = ""; return l;
            }

            if (dgv_Conditions.Rows[i].Cells[4].Value != null)
            {
                if (dgv_Conditions.Rows[i].Cells[4].Value.ToString() == "أو")
                {
                    l = "OR ";
                    logcondition = "  أو  ";
                }
            }
            return l;
        }
        string M(int i)
        {
            m = "";
            switch (dgv_Conditions.Rows[i].Cells[2].Value.ToString())
            {
                case "أختيار":
                    m = "= ";
                    Mcondition = "مساو لـ ";
                    break;

                case "يبدأ بـ":
                    m = "= ";
                    break;

                case "مساو لـ":
                    m = "= ";
                    Mcondition = "مساو لـ ";
                    break;

                case "أكبر من":
                    m = "> ";
                    Mcondition = "أكبر من ";
                    break;

                case "أقل من":
                    m = "< ";
                    Mcondition = "أقل من ";
                    break;

                case "أكبر من أو يساوي":
                    m = ">= ";
                    Mcondition = "أكبر من أو يساوي ";
                    break;

                case "أقل من أو يساوي":
                    m = "<= ";
                    Mcondition = "أقل من أو يساوي ";
                    break;

                case "يتضمن":
                    m = "like ";
                    break;
            }
            return m;
        }

        void var()
        {
            rep.Name = txt_RepName.Text;
            rep.Content = Content();
            rep.Rep_View = Rep_TABLE_NAME;
            rep.Row_Count = (rad_Only.Checked) ? Convert.ToInt16(num_TopRecords.Value) : 0;
            rep.Row_Index = chk_index.Checked;
            rep.Font_Size = Convert.ToInt16(num_FontSize.Value);
            rep.User_ID = UserID;
            rep.RepD = table();
        }
        DataTable table()
        {
            DataTable dt = new DataTable();
            foreach (DataGridViewColumn col in dgv_Conditions.Columns)
            {
                if (col.Index == dgv_Conditions.Columns.Count - 1) { break; }
                dt.Columns.Add(col.HeaderText);
            }

            foreach (DataGridViewRow row in dgv_Conditions.Rows)
            {
                if (row.Cells[0].Value == null) { break; }
                DataRow dRow = dt.NewRow();
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.ColumnIndex == dgv_Conditions.Columns.Count - 1) { break; }
                    if (cell.Value == null) { dRow[cell.ColumnIndex] = ""; }
                    else if (cell.Value.ToString() == "") { dRow[cell.ColumnIndex] = null; }
                    else { dRow[cell.ColumnIndex] = cell.Value; }
                }
                dt.Rows.Add(dRow);
            }
            return dt;
        }
        string Content()
        {
            string c = "";
            foreach (string item in list_Forward.Items)
            {
                c += item + ",";
            }
            return c;
        }
        DataTable table(int t)
        {
            DataTable dt = new DataTable();
            foreach (DataGridViewColumn col in dgv_Conditions.Columns)
            {
                dt.Columns.Add(col.HeaderText);
            }

            foreach (DataGridViewRow row in dgv_Conditions.Rows)
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
            if (dt.Rows.Count > 0) { dt.Rows.RemoveAt(dt.Rows.Count - 1); }
            return dt;
        }
        void DGV_Finish()
        {
            // حجم الخط
            DGV.DefaultCellStyle.Font = new Font("Tahoma", Convert.ToInt16(num_FontSize.Value));
            DGV.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", Convert.ToInt16(num_FontSize.Value) + 2);
            DGV.RowTemplate.MinimumHeight = Convert.ToInt16(25 + (Convert.ToInt16(num_FontSize.Value) - 8));

            txt_Title.Text = txt_RepName.Text;
            if (condition == "")
            {
                txt_Condition.Visible = false;
                DGV.Dock = DockStyle.Fill;
            }
            else
            {
                txt_Condition.Visible = true;
                txt_Condition.Text = "     " + condition.Substring(5);
            }
            // الترقيم
            if (chk_index.Checked)
            {
                foreach (DataGridViewRow indexrow in DGV.Rows)
                {
                    indexrow.Cells[0].Value = indexrow.Index + 1;
                }
                DGV.Columns[0].Visible = true;
                DGV.Rows[DGV.RowCount - 1].Cells[0].Value = "";
            }
            else
            {
                DGV.Columns[0].Visible = false;
            }
            //EmptyZero();
        }
        void EmptyZero()
        {
            foreach (DataGridViewRow r in DGV.Rows)
            {
                foreach (DataGridViewCell c in r.Cells)
                {
                    if (r.Cells[c.ColumnIndex].Value.ToString() == "0.00")
                    {
                        r.Cells[c.ColumnIndex].Style.ForeColor = Color.Transparent;
                    }
                }              
            }
        }
        string TranEnToAr(string s)
        {
            switch (s)
            {
                case "Document ID":
                    s = "كود السند";
                    break;
                case "Document Date":
                    s = "تاريخ السند";
                    break;
                case "Item ID":
                    s = "كود الصنف";
                    break;
                case "Item Name":
                    s = "أسم الصنف";
                    break;
                case "Quantity":
                    s = "الكمية";
                    break;
                case "Category":
                    s = "الفئة";
                    break;
                case "Farm":
                    s = "الحظيرة";
                    break;
                case "Type":
                    s = "النوع";
                    break;
                case "Note":
                    s = "البيان";
                    break;
                case "User":
                    s = "المستخدم";
                    break;
                case "Purchasing Price":
                    s = "سعر الشراء";
                    break;
                case "Selling Price":
                    s = "سعر البيع";
                    break;
                case "Average Cost":
                    s = "متوسط التكلفة";
                    break;
                case "Unit":
                    s = "الوحدة";
                    break;
                case "Customer ID":
                    s = "كود العميل";
                    break;
                case "Customer Name":
                    s = "أسم العميل";
                    break;
                case "Responsible Name":
                    s = "أسم المسؤل";
                    break;
                case "Mobile1":
                    s = "جوال1";
                    break;
                case "Mobile2":
                    s = "جوال2";
                    break;
                case "Phone1":
                    s = "هاتف1";
                    break;
                case "Phone2":
                    s = "هاتف2";
                    break;
                case "Email":
                    s = "البريد الالكتروني";
                    break;
                case "Registered Under":
                    s = "مقيد تحت";
                    break;
                case "Balance":
                    s = "الرصيد";
                    break;

                case "Document Type":
                    s = "نوع السند";
                    break;

                case "In":
                    s = "الوارد";
                    break;

                case "Out":
                    s = "المنصرف";
                    break;

                case "Cost Price":
                    s = "سعر التكلفة";
                    break;

                case "Total Purchasing Price":
                    s = "الإجمالي بسعر الشراء";
                    break;

                case "Total Selling Price":
                    s = "الإجمالي بسعر البيع";
                    break;

                case "Total Cost Price":
                    s = "الإجمالي بسعر التكلفة";
                    break;

                case "Total Average Cost":
                    s = "الإجمالي بمتوسط التكلفة";
                    break;

                case "Account ID":
                    s = "كود الحساب";
                    break;

                case "Account Name":
                    s = "أسم الحساب";
                    break;

                case "Payment Type":
                    s = "طريقة الدفع";
                    break;

                case "Product ID":
                    s = "كود المنتج";
                    break;

                case "Product Name":
                    s = "أسم المنتج";
                    break;

                case "Product Nomber":
                    s = "رقم المنتج";
                    break;

                case "Gender":
                    s = "الجنس";
                    break;

                case "Case":
                    s = "الحالة";
                    break;

                case "Mother Nomber":
                    s = "رقم الأم";
                    break;

                case "Birth Date":
                    s = "تاريخ الميلاد";
                    break;

                case "Weight":
                    s = "الوزن";
                    break;

                case "Initial Cost":
                    s = "التكلفة المبدئية";
                    break;

                case "Current Cost":
                    s = "التكلفة الحالية";
                    break;

                case "Health Status":
                    s = "الحالة الصحية";
                    break;

                case "Sale Date":
                    s = "تاريخ البيع";
                    break;

                case "Death Date":
                    s = "تاريخ النفوق";
                    break;

                case "Entry ID":
                    s = "كود القيد";
                    break;

                case "Vendor ID":
                    s = "كود المورد";
                    break;

                case "Vendor Name":
                    s = "أسم المورد";
                    break;

                case "Vendor Document ID":
                    s = "كود سند المورد";
                    break;

                case "Total":
                    s = "الإجمالي";
                    break;

                case "Discount":
                    s = "الخصم";
                    break;

                case "Net":
                    s = "الصافي";
                    break;

                case "Date":
                    s = "التاريخ";
                    break;

                case "Profit":
                    s = "الربح";
                    break;

                case "Manual Document Number":
                    s = "رقم السند اليدوي";
                    break;

                case "Check Date":
                    s = "تاريخ الشيك";
                    break;

                case "Check Number":
                    s = "رقم الشيك";
                    break;

                case "Amount":
                    s = "المبلغ";
                    break;
            }
            return s;
        }
        string TranArToEn(string s)
        {
            switch (s)
            {
                case "كود السند":
                    s = "Document ID";
                    break;
                case "تاريخ السند":
                    s = "Document Date";
                    break;
                case "كود الصنف":
                    s = "Item ID";
                    break;
                case "أسم الصنف":
                    s = "Item Name";
                    break;
                case "الكمية":
                    s = "Quantity";
                    break;
                case "الفئة":
                    s = "Category";
                    break;
                case "الحظيرة":
                    s = "Farm";
                    break;
                case "النوع":
                    s = "Type";
                    break;
                case "البيان":
                    s = "Note";
                    break;
                case "المستخدم":
                    s = "User";
                    break;
                case "سعر الشراء":
                    s = "Purchasing Price";
                    break;
                case "سعر البيع":
                    s = "Selling Price";
                    break;
                case "متوسط التكلفة":
                    s = "Average Cost";
                    break;
                case "الوحدة":
                    s = "Unit";
                    break;
                case "كود العميل":
                    s = "Customer ID";
                    break;
                case "أسم العميل":
                    s = "Customer Name";
                    break;
                case "أسم المسؤل":
                    s = "Responsible Name";
                    break;
                case "جوال1":
                    s = "Mobile1";
                    break;
                case "جوال2":
                    s = "Mobile2";
                    break;
                case "هاتف1":
                    s = "Phone1";
                    break;
                case "هاتف2":
                    s = "Phone2";
                    break;
                case "البريد الالكتروني":
                    s = "Email";
                    break;
                case "مقيد تحت":
                    s = "Registered Under";
                    break;
                case "الرصيد":
                    s = "Balance";
                    break;

                case "نوع السند":
                    s = "Document Type";
                    break;

                case "الوارد":
                    s = "In";
                    break;

                case "المنصرف":
                    s = "Out";
                    break;

                case "سعر التكلفة":
                    s = "Cost Price";
                    break;

                case "الإجمالي بسعر الشراء":
                    s = "Total Purchasing Price";
                    break;

                case "الإجمالي بسعر البيع":
                    s = "Total Selling Price";
                    break;

                case "الإجمالي بسعر التكلفة":
                    s = "Total Cost Price";
                    break;

                case "الإجمالي بمتوسط التكلفة":
                    s = "Total Average Cost";
                    break;

                case "كود الحساب":
                    s = "Account ID";
                    break;

                case "أسم الحساب":
                    s = "Account Name";
                    break;

                case "طريقة الدفع":
                    s = "Payment Type";
                    break;

                case "كود المنتج":
                    s = "Product ID";
                    break;

                case "أسم المنتج":
                    s = "Product Name";
                    break;

                case "رقم المنتج":
                    s = "Product Nomber";
                    break;

                case "الجنس":
                    s = "Gender";
                    break;

                case "الحالة":
                    s = "Case";
                    break;

                case "رقم الأم":
                    s = "Mother Nomber";
                    break;

                case "تاريخ الميلاد":
                    s = "Birth Date";
                    break;

                case "الوزن":
                    s = "Weight";
                    break;

                case "التكلفة المبدئية":
                    s = "Initial Cost";
                    break;

                case "التكلفة الحالية":
                    s = "Current Cost";
                    break;

                case "الحالة الصحية":
                    s = "Health Status";
                    break;

                case "تاريخ البيع":
                    s = "Sale Date";
                    break;

                case "تاريخ النفوق":
                    s = "Death Date";
                    break;

                case "كود القيد":
                    s = "Entry ID";
                    break;

                case "كود المورد":
                    s = "Vendor ID";
                    break;

                case "أسم المورد":
                    s = "Vendor Name";
                    break;

                case "كود سند المورد":
                    s = "Vendor Document ID";
                    break;

                case "الإجمالي":
                    s = "Total";
                    break;

                case "الخصم":
                    s = "Discount";
                    break;

                case "الصافي":
                    s = "Net";
                    break;

                case "التاريخ":
                    s = "Date";
                    break;

                case "الربح":
                    s = "Profit";
                    break;

                case "رقم السند اليدوي":
                    s = "Manual Document Number";
                    break;

                case "تاريخ الشيك":
                    s = "Check Date";
                    break;

                case "رقم الشيك":
                    s = "Check Number";
                    break;

                case "المبلغ":
                    s = "Amount";
                    break;
            }
            return s;
        }
        #endregion

        #region Form
        private void FRM_rep_Shown(object sender, EventArgs e)
        {
            dt_g = rep.Select_Rep("select * from Rep where Rep_View = '" + Rep_TABLE_NAME + "'");
            com_SelectedRep.ValueMember = "Rep_ID";
            com_SelectedRep.DisplayMember = "Rep_Name";
            com_SelectedRep.DataSource = dt_g;
            com_SelectedRep.SelectedValue = -1;

            dt_Rep_Info = rep.Select_Rep_Info(Rep_TABLE_NAME, Rep_TABLE_SCHEMA);
            foreach (DataRow r in dt_Rep_Info.Rows)
            {
                list_Back.Items.Add(TranEnToAr(r[0].ToString()));
            }

            foreach (DataRow dr in dt_Rep_Info.Rows)
            {
                (dgv_Conditions.Columns[0] as DataGridViewComboBoxColumn).Items.Add(TranEnToAr(dr[0].ToString()));
            }
            com_Fields.DataSource = dt_Rep_Info;

            if ((dgv_Conditions.Rows[0].Cells[0] as DataGridViewComboBoxCell).Items.Count == 0)
            {
                foreach (DataRow r in dt_Rep_Info.Rows)
                {
                    list_Back.Items.Add(r[0].ToString());
                    (dgv_Conditions.Rows[0].Cells[0] as DataGridViewComboBoxCell).Items.Add(TranEnToAr(r[0].ToString()));
                }
            }
            ((DataGridViewImageCell)dgv_Conditions.Rows[0].Cells["Delete"]).Value = Properties.Resources.close2_16;
        }
        #endregion

        #region Controls

        #region display
        private void btn_Display_MouseEnter(object sender, EventArgs e)
        {
            btn_Display.FlatStyle = FlatStyle.Popup;
        }
        private void btn_Display_MouseLeave(object sender, EventArgs e)
        {
            btn_Display.FlatStyle = FlatStyle.Flat;
        }
        private void EXCEL_MouseEnter(object sender, EventArgs e)
        {
            EXCEL.FlatStyle = FlatStyle.Popup;
        }
        private void EXCEL_MouseLeave(object sender, EventArgs e)
        {
            EXCEL.FlatStyle = FlatStyle.Popup;
        }
        #endregion

        #region fields
        private void btn_Forward_Click(object sender, EventArgs e)
        {
            if (list_Back.SelectedItem != null)
            {
                list_Forward.Items.Add(list_Back.SelectedItem);
                list_Back.Items.Remove(list_Back.SelectedItem);
            }
        }
        private void btn_Back_Click(object sender, EventArgs e)
        {
            if (list_Forward.SelectedItem != null)
            {
                list_Back.Items.Add(list_Forward.SelectedItem);
                list_Forward.Items.Remove(list_Forward.SelectedItem);
            }
        }
        private void btn_ForwardAll_Click(object sender, EventArgs e)
        {
            list_Forward.Items.AddRange(list_Back.Items);
            list_Back.Items.Clear();
        }
        private void btn_BackAll_Click(object sender, EventArgs e)
        {
            list_Back.Items.AddRange(list_Forward.Items);
            list_Forward.Items.Clear();
        }
        private void list_Back_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            btn_Forward_Click(null, null);
        }
        private void list_Forward_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            btn_Back_Click(null, null);
        }

        private void btn_MoveFirst_Click(object sender, EventArgs e)
        {
            if (list_Forward.SelectedItem != null)
            {
                ListBox list = new ListBox();
                list.Items.Insert(0, list_Forward.SelectedItem);

                int i = list_Forward.SelectedIndex;

                list_Forward.Items.Remove(list_Forward.SelectedItem);
                list_Forward.Items.Insert(0, list.Items[0]);
                list_Forward.SelectedIndex = i;
            }
        }
        private void btn_MoveLast_Click(object sender, EventArgs e)
        {
            if (list_Forward.SelectedItem != null)
            {
                ListBox list = new ListBox();
                list.Items.Insert(0, list_Forward.SelectedItem);

                int i = list_Forward.SelectedIndex;

                list_Forward.Items.Remove(list_Forward.SelectedItem);
                list_Forward.Items.Insert(list_Forward.Items.Count, list.Items[0]);
                list_Forward.SelectedIndex = i;
            }
        }
        private void btn_MoveUp_Click(object sender, EventArgs e)
        {
            if (list_Forward.Items.Count <= 1) { return; }

            if (list_Forward.SelectedIndex >= 1)
            {
                ListBox list = new ListBox();
                list.Items.Insert(0, list_Forward.SelectedItem);

                int i = list_Forward.SelectedIndex;

                list_Forward.Items.Remove(list_Forward.SelectedItem);
                list_Forward.Items.Insert(i - 1, list.Items[0]);
                list_Forward.SelectedIndex = i - 1;
            }
        }
        private void btn_MoveDowen_Click(object sender, EventArgs e)
        {
            if (list_Forward.Items.Count <= 1) { return; }

            if (list_Forward.SelectedIndex <= list_Forward.Items.Count - 2)
            {
                ListBox list = new ListBox();
                list.Items.Insert(0, list_Forward.SelectedItem);

                int i = list_Forward.SelectedIndex;

                list_Forward.Items.Remove(list_Forward.SelectedItem);
                list_Forward.Items.Insert(i + 1, list.Items[0]);
                list_Forward.SelectedIndex = i + 1;
            }
        }
        #endregion

        private void btn_SaveRep_Click(object sender, EventArgs e)
        {
            if (list_Forward.Items.Count == 0) { MessageBox.Show("لا يوجد حقول بالتقرير", "لم يتم الحفظ", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); return; }
            if (txt_RepName.TextLength == 0) { MessageBox.Show("من فضلك أدخل أسم للتقرير", "لم يتم الحفظ", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); return; }
            if (com_SelectedRep.Text == txt_RepName.Text)
            {
                if (MessageBox.Show("سيتم تعديل التقرير الحالي", "حفظ", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.Cancel)
                {
                    return;
                }
            }

            var();

            string t = rep.Insert();
            if (t.Length > 6)
            {
                if (t.Substring(0, 6) == "SQL : ")
                {
                    MessageBox.Show(t, "! حفظ", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
            }

            // fill combo
            dt_g = rep.Select_Rep("select * from Rep");
            dt_g.DefaultView.RowFilter = string.Format("Rep_View = '" + Rep_TABLE_NAME + "' and User_ID = " + UserID.ToString());
            dt_RepD = rep.Select_Rep("select * from RepD");
            com_SelectedRep.DataSource = dt_g;
            com_SelectedRep.Text = txt_RepName.Text;

            MessageBox.Show("تم الحفظ بنجاح", "حفظ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void btn_RepDelete_Click(object sender, EventArgs e)
        {
            if (com_SelectedRep.SelectedValue != null)
            {
                rep.Rep_ID = Convert.ToInt16(com_SelectedRep.SelectedValue);
                string t = rep.Delete();

                // fill combo
                dt_g = rep.Select_Rep("select * from Rep");
                dt_g.DefaultView.RowFilter = string.Format("Rep_View = '" + Rep_TABLE_NAME + "' and User_ID = " + UserID.ToString());
                com_SelectedRep.DataSource = dt_g;
                com_SelectedRep.SelectedValue = -1;

                MessageBox.Show("تم الحذف بنجاح", "حذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void com_RepGenerator_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (com_SelectedRep.Focused)
            {
                txt_RepName.Text = com_SelectedRep.Text;
                foreach (DataRow r in dt_g.Rows)
                {
                    if (r["Rep_ID"].ToString() == com_SelectedRep.SelectedValue.ToString())
                    {
                        dr_g = r;
                        break;
                    }
                }
                if (dr_g == null) { return; }

                // Contents
                list_Forward.Items.Clear();
                list_Back.Items.Clear();
                foreach (DataRow r in dt_Rep_Info.Rows)
                {
                    list_Back.Items.Add(TranEnToAr(r[0].ToString()));
                }

                string c = dr_g["Contents"].ToString();
                string n = "";
                for (int i = 0; i < c.Length; i++)
                {
                    if (c[i] == ',')
                    {
                        for (int p = 0; p < list_Back.Items.Count; p++)
                        {
                            if (list_Back.Items[p].ToString() == n)
                            {
                                list_Back.SelectedIndex = p;
                                btn_Forward_Click(null, null);
                                break;
                            }
                        }
                        n = "";
                        continue;
                    }
                    n += c[i];
                }

                // Row_Count
                if (Convert.ToInt16(dr_g["Row_Count"]) != 0)
                {
                    rad_Only.Checked = true;
                    num_TopRecords.Value = Convert.ToInt16(dr_g["Row_Count"]);
                }
                else
                {
                    rad_AllRecords.Checked = true;
                }

                // Row_Index
                chk_index.Checked = Convert.ToBoolean(dr_g["Row_Index"]);

                // Font_Size
                num_FontSize.Value = Convert.ToInt16(dr_g["Font_Size"]);

                dt_RepD.DefaultView.RowFilter = string.Format("Rep_ID = " + com_SelectedRep.SelectedValue.ToString());
                dgv_Conditions.DataSource = dt_RepD;

                Temp_dgv = table(1);
                dgv_Conditions.DataSource = null;

                if (Temp_dgv.Rows.Count == 0)
                {
                    return;
                }
                else
                {
                    foreach (DataRow row in Temp_dgv.Rows)
                    {
                        dgv_Conditions.Rows.Add();
                    }
                }

                int h = 0;
                foreach (DataRow row in Temp_dgv.Rows)
                {
                    dgv_Conditions.Rows[h].Cells[0].Value = row[0].ToString();
                    dgv_Conditions.Rows[h].Cells[1].Value = row[1].ToString();
                    dgv_Conditions.Rows[h].Cells[2].Value = row[2].ToString();
                    dgv_Conditions.Rows[h].Cells[3].Value = row[3].ToString();
                    dgv_Conditions.Rows[h].Cells[4].Value = row[4].ToString();
                    dgv_Conditions.Rows[h].Cells[5].Value = row[5].ToString();
                    dgv_Conditions.Rows[h].Cells[6].Value = row[6].ToString();
                    ((DataGridViewImageCell)dgv_Conditions.Rows[h].Cells["Delete"]).Value = Properties.Resources.close2_16;
                    h++;
                }
                dgv_Conditions.AllowUserToAddRows = true;

                foreach (DataGridViewRow rr in dgv_Conditions.Rows)
                {
                    if (rr.Cells[0].Value != null && rr.Cells[2].Value.ToString() == "أختيار")
                    {
                        string s = rr.Cells[3].Value.ToString();
                        rr.Cells[3] = new DataGridViewComboBoxCell();
                        DataGridViewComboBoxCell box = new DataGridViewComboBoxCell();
                        box = (DataGridViewComboBoxCell)rr.Cells[3];
                        box.DataSource = rep.Select("select DISTINCT [" + TranArToEn(rr.Cells[0].Value.ToString()) + "] from " + Rep_TABLE_NAME);
                        box.DisplayMember = TranArToEn(rr.Cells[0].Value.ToString());
                        rr.Cells[3].Value = s;
                    }
                }
            }
        }
        private void btn_Display_Click(object sender, EventArgs e)
        {
                if (list_Forward.Items.Count == 0)
                {
                    DGV.Columns.Clear();
                    return;
                }

                lst_Translated.Items.Clear();
                foreach (var i in list_Forward.Items)
                {
                    lst_Translated.Items.Add(TranArToEn(i.ToString()));
                }             

                #region Group By
                foreach (DataGridViewRow r in dgv_Conditions.Rows)
                {
                    if (r.Cells[5].Value != null && r.Cells[0].Value != null)
                    {
                        if (Convert.ToBoolean(r.Cells[5].Value) == true)
                        {
                            txt_SQL.Text = SELECT(r.Cells[5].RowIndex) + FROM() + WHERE() + "Group By [" + TranArToEn(r.Cells[0].Value.ToString()) + "] " + UNION_ALL() + from + where;

                            dt_Rep = rep.Select(txt_SQL.Text);
                        #region Translate dgv.Columns
                        foreach (DataColumn c in dt_Rep.Columns)
                        {
                            c.ColumnName = list_Forward.Items[c.Ordinal].ToString();
                        }
                        #endregion
                        DGV.DataSource = null;

                            DataRow total_rowG = dt_Rep.NewRow();
                            total_rowG.ItemArray = dt_Rep.Rows[dt_Rep.Rows.Count - 1].ItemArray;
                            dt_Rep.Rows.RemoveAt(dt_Rep.Rows.Count - 1);
                            ORDER_BY();
                            dt_Rep.Rows.Add(total_rowG.ItemArray);
                            DGV.DataSource = dt_Rep;

                            if (DGV.SelectedRows.Count > 0) { DGV.SelectedRows[0].Selected = false; }

                            if (union == "")
                            {
                                dt_Rep.Rows.Add();
                            }

                            DGV.Rows[DGV.Rows.Count - 1].DefaultCellStyle.Font = new Font("Tahoma", Convert.ToInt16(num_FontSize.Value) + 2);
                            DGV.Rows[DGV.Rows.Count - 1].DefaultCellStyle.ForeColor = Color.Navy;
                            DGV.Rows[DGV.Rows.Count - 1].DefaultCellStyle.BackColor = Color.Silver;

                            txt_Title.Text = txt_RepName.Text;
                            if (condition == "")
                            {
                                txt_Condition.Visible = false;
                                DGV.Dock = DockStyle.Fill;
                            }
                            else
                            {
                                txt_Condition.Visible = true;
                                txt_Condition.Text = "     " + condition.Substring(5);
                            }
                            DGV_Finish();
                            return;
                        }
                    }
                }
                #endregion

                #region Normal
                txt_SQL.Text = SELECT(-1) + FROM() + WHERE() + UNION_ALL() + from + where;

                dt_Rep = rep.Select(txt_SQL.Text);
                #region Translate dgv.Columns
                foreach (DataColumn c in dt_Rep.Columns)
                {
                    c.ColumnName = list_Forward.Items[c.Ordinal].ToString();
                }
                #endregion

                DGV.DataSource = null;

                DataRow total_row = dt_Rep.NewRow();
                total_row.ItemArray = dt_Rep.Rows[dt_Rep.Rows.Count - 1].ItemArray;
                dt_Rep.Rows.RemoveAt(dt_Rep.Rows.Count - 1);

                ORDER_BY();
                dt_Rep.Rows.Add(total_row.ItemArray);



                DGV.DataSource = dt_Rep;

                if (DGV.SelectedRows.Count > 0) { DGV.SelectedRows[0].Selected = false; }

                if (union == "")
                {
                    dt_Rep.Rows.Add();
                }

                DGV.Rows[DGV.Rows.Count - 1].DefaultCellStyle.Font = new Font("Tahoma", Convert.ToInt16(num_FontSize.Value) + 2);
                DGV.Rows[DGV.Rows.Count - 1].DefaultCellStyle.ForeColor = Color.Navy;
                DGV.Rows[DGV.Rows.Count - 1].DefaultCellStyle.BackColor = Color.Silver;

                DGV_Finish();
                #endregion
        }
        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            if (DGV.Rows.Count == 0) { return; }
            try
            {
                Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
                excel.Visible = true;
                excel.DefaultSheetDirection = (int)DGV.RightToLeft;
                Microsoft.Office.Interop.Excel.Workbook workbook = excel.Workbooks.Add(System.Reflection.Missing.Value);
                Microsoft.Office.Interop.Excel.Worksheet sheet1 = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Sheets[1];
                int StartCol = 1;
                int StartRow = 4;
                int j = 0, i = 0;
                int indexcol = 0;
                if (DGV.Columns[0].Visible == true) { indexcol = 0; } else { indexcol = 1; }

                myRange = (Microsoft.Office.Interop.Excel.Range)sheet1.Range["A1", "Z10000"];
                myRange.RowHeight = 20;
                myRange.HorizontalAlignment = 3;
                myRange.VerticalAlignment = 2;
                myRange.Font.Name = "Tahoma";
                myRange.Font.Size = 8;

                // Report Title
                if (txt_Title.Text != "")
                {
                    lastcol = (Microsoft.Office.Interop.Excel.Range)sheet1.Cells[1, DGV.ColumnCount - indexcol];
                    myRange = (Microsoft.Office.Interop.Excel.Range)sheet1.Range["A1", lastcol];
                    myRange.MergeCells = true;
                    myRange.Value2 = txt_Title.Text;
                    myRange.RowHeight = 30;
                    myRange.HorizontalAlignment = 3;
                    myRange.VerticalAlignment = 2;
                    myRange.Interior.Color = txt_Title.BackColor;
                    myRange.Font.Name = "Tahoma";
                    myRange.Font.Color = txt_Title.ForeColor;
                    myRange.Font.Size = 12;
                }
                else
                {
                    StartRow--;
                }

                // Report Conditions
                lastcol = (Microsoft.Office.Interop.Excel.Range)sheet1.Cells[StartRow - 2, DGV.ColumnCount - indexcol];
                firstrow = (Microsoft.Office.Interop.Excel.Range)sheet1.Cells[StartRow - 2, 1];

                if (txt_Condition.Visible == true)
                {
                    myRange = (Microsoft.Office.Interop.Excel.Range)sheet1.Range[firstrow, lastcol];
                    myRange.MergeCells = true;
                    myRange.Value2 = txt_Condition.Text;
                    myRange.RowHeight = 30;
                    myRange.HorizontalAlignment = 1;
                    myRange.Interior.Color = txt_Condition.BackColor;
                    myRange.Font.Color = txt_Condition.ForeColor;
                }
                else
                {
                    StartRow--;
                }

                //Write Headers                
                for (j = 1; j <= DGV.Columns.Count - indexcol; j++)
                {
                    myRange = (Microsoft.Office.Interop.Excel.Range)sheet1.Cells[StartRow - 1, j];
                    myRange.Value2 = DGV.Columns[j + indexcol - 1].HeaderText;
                    myRange.RowHeight = 30;
                    myRange.ColumnWidth = DGV.Columns[j + indexcol - 1].Width / 6;
                    myRange.Font.Size = 10;
                    myRange.Font.FontStyle = FontStyle.Bold;
                    myRange.Borders.Color = Color.Gray;
                    myRange.Interior.Color = Color.Silver;
                }

                //Write datagridview content
                for (i = 0; i < DGV.Rows.Count; i++)
                {
                    for (j = 0; j < DGV.Columns.Count - indexcol; j++)
                    {
                        myRange = (Microsoft.Office.Interop.Excel.Range)sheet1.Cells[StartRow + i, StartCol + j];
                        myRange.Value2 = DGV[j + indexcol, i].Value == null ? "" : DGV[j + indexcol, i].Value.ToString();

                    }

                    firstrow = (Microsoft.Office.Interop.Excel.Range)sheet1.Cells[StartRow + i, 1];
                    myRange = (Microsoft.Office.Interop.Excel.Range)sheet1.Range[firstrow, myRange];
                    myRange.Borders.Color = Color.Gray;

                    if ((i % 2) > 0)
                    {
                        myRange.Interior.Color = Color.OldLace;
                    }
                    if (i == DGV.Rows.Count - 1)
                    {
                        myRange.Font.Color = Color.Navy;
                        myRange.Interior.Color = Color.Silver;
                        myRange.Font.Size = 10;
                    }
                }

                lastcol = (Microsoft.Office.Interop.Excel.Range)sheet1.Cells[DGV.RowCount + StartRow - 1, DGV.ColumnCount - indexcol];
                myRange = (Microsoft.Office.Interop.Excel.Range)sheet1.Range["A1", lastcol];
                myRange.BorderAround(Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous, Microsoft.Office.Interop.Excel.XlBorderWeight.xlThin, Microsoft.Office.Interop.Excel.XlColorIndex.xlColorIndexAutomatic,
                Microsoft.Office.Interop.Excel.XlColorIndex.xlColorIndexAutomatic);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region DGV_1
        private void DGV_1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_Conditions.CurrentCell == null || dgv_Conditions.Focused == false) { return; }

            if (e.ColumnIndex == 2 & dgv_Conditions.CurrentRow.Cells[0].Value != null || e.ColumnIndex == 0 & dgv_Conditions.CurrentRow.Cells[2].Value != null)
            {
                if (dgv_Conditions.Focused)
                {
                    if (dgv_Conditions.CurrentRow.Cells[2].Value.ToString() == "أختيار")
                    {
                        dgv_Conditions.CurrentRow.Cells[3] = new DataGridViewComboBoxCell();
                        DataGridViewComboBoxCell box = new DataGridViewComboBoxCell();
                        box = (DataGridViewComboBoxCell)dgv_Conditions.CurrentRow.Cells[3];
                        box.DataSource = rep.Select("select DISTINCT [" + TranArToEn(dgv_Conditions.CurrentRow.Cells[0].Value.ToString()) + "] from " + Rep_TABLE_NAME);
                        box.DisplayMember = TranArToEn(dgv_Conditions.CurrentRow.Cells[0].Value.ToString());
                    }
                    else
                    {
                        dgv_Conditions.CurrentRow.Cells[3] = new DataGridViewTextBoxCell();
                    }
                }
            }
            else if (e.ColumnIndex == 6) // Order
            {
                if (dgv_Conditions.CurrentCell != null)
                {
                    if (dgv_Conditions.CurrentCell.Value != null)
                    {
                        if ((dgv_Conditions.CurrentCell as DataGridViewComboBoxCell).Items.IndexOf(dgv_Conditions.CurrentCell.Value) > -1)
                        {
                            for (int i = 0; i < dgv_Conditions.Rows.Count - 1; i++)
                            {
                                if (dgv_Conditions.CurrentCell.RowIndex == i) { continue; }
                                dgv_Conditions.Rows[i].Cells[6].Value = "";
                            }
                        }
                    }
                }
            }
        }
        private void DGV_1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (e.Control is ComboBox)
            {
                ComboBox box = e.Control as ComboBox;
                box.DropDownStyle = ComboBoxStyle.DropDown;
                box.AutoCompleteSource = AutoCompleteSource.ListItems;
                box.AutoCompleteMode = AutoCompleteMode.Suggest;
            }
        }
        private void DGV_1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 7)
            {
                if (dgv_Conditions.CurrentRow.Index != dgv_Conditions.Rows.Count - 1)
                {
                    dgv_Conditions.Rows.Remove(dgv_Conditions.CurrentRow);
                    dtp.Visible = false;
                }
            }
        }
        private void DGV_1_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            try
            {
                if (dgv_Conditions.Rows[e.RowIndex].Cells[0].Value == null || dgv_Conditions.Rows[e.RowIndex].Cells[2].Value == null) { return; }
                if ((dgv_Conditions.Rows[e.RowIndex].Cells[2] as DataGridViewComboBoxCell).Items.IndexOf(dgv_Conditions.Rows[e.RowIndex].Cells[2].Value) == 0) { return; }

                com_Fields.Text = TranArToEn(dgv_Conditions.Rows[e.RowIndex].Cells[0].Value.ToString());
                if (dgv_Conditions.Focused && dgv_Conditions.CurrentCell.ColumnIndex == 3 && com_Fields.SelectedValue.ToString() == "datetime")
                {
                    dtp.Location = dgv_Conditions.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, false).Location;
                    dtp.Visible = true;

                    if (dgv_Conditions.CurrentCell.Value != null)// إذا كان يوجد قيمة
                    {
                        DateTime temp;
                        if (DateTime.TryParse(dgv_Conditions.CurrentCell.Value.ToString(), out temp))// هل القيمة تاريخ ؟
                        {
                            dtp.Value = temp;
                        }
                        else
                        {
                            dtp.Value = DateTime.Today;
                            dtp_Value_Changed(null, null);
                        }
                    }
                    else
                    {
                        dtp.Value = DateTime.Today;
                        dtp_Value_Changed(null, null);
                    }
                }
                else
                {
                    dtp.Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "DGV_1_CellEnter", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }
        private void DGV_1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            dtp.Visible = false;
        }
        private void dtp_Value_Changed(object sender, EventArgs e)
        {
            dgv_Conditions.CurrentCell.Value = dtp.Value.Date.ToString("yyyy/MM/dd");
        }
        #endregion

        #region DGV
        private void DGV_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) { return; }
            c = DGV.Rows[e.RowIndex].DefaultCellStyle.BackColor;
            DGV.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Pink;
        }
        private void DGV_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) { return; }
            DGV.Rows[e.RowIndex].DefaultCellStyle.BackColor = c;
        }
        #endregion

        private void dgv_Conditions_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            ((DataGridViewImageCell)dgv_Conditions.Rows[dgv_Conditions.RowCount - 1].Cells["Delete"]).Value = Properties.Resources.close2_16;
        }
    }
}
