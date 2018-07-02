using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1.PL.ACC
{
    public partial class frm_ST : Form
    {
        #region Declarations
        public bool Demo;
        BL.BL.G g = new BL.BL.G();
        BL.BL.ST st = new BL.BL.ST();
        DataTable dt_st = new DataTable();
        PL.G.frm_Search search = new G.frm_Search();
        #endregion

        public frm_ST()
        {
            InitializeComponent();

            dgv.AutoGenerateColumns = false;
            com_ACC.DataSource = g.Select2("Select * From ACC Where Parent = 0");
            com_ACC.SelectedValue = -1;
        }

        #region Pro
        void EmptyZero()
        {
            foreach (DataGridViewRow r in dgv.Rows)
            {
                for (int i = 0; i < 2; i++)
                {
                    if (Convert.ToDecimal(r.Cells[i].Value) == 0) { r.Cells[i].Style.ForeColor = Color.Transparent; }
                }
            }
        }
        #endregion

        #region Form
        private void frm_ST_Shown(object sender, EventArgs e)
        {
            if (dgv.SelectedRows.Count > 0) { dgv.SelectedRows[0].Selected = false; }

            if (Parent == null & dgv.RowCount > 0)
            {
                // Balance
                foreach (DataGridViewRow r in dgv.Rows)
                {
                    if (dgv.Rows[r.Index].Index >= 1)
                    {
                        r.Cells["Balance"].Value = Convert.ToDecimal(dgv.Rows[r.Index - 1].Cells["Balance"].Value) + (Convert.ToDecimal(r.Cells["Debit"].Value) - Convert.ToDecimal(r.Cells["Credit"].Value));
                    }
                    else if (dgv.Rows[r.Index].Cells["Balance"].RowIndex >= 0)
                    {
                        r.Cells["Balance"].Value = (Convert.ToDecimal(r.Cells["Debit"].Value) - Convert.ToDecimal(r.Cells["Credit"].Value));
                    }
                }
            }
        }
        #endregion

        #region Controls

        #region Display
        private void button_Display_MouseEnter(object sender, EventArgs e)
        {
            button_Display.FlatStyle = FlatStyle.Popup;
        }
        private void button_Display_MouseLeave(object sender, EventArgs e)
        {
            button_Display.FlatStyle = FlatStyle.Flat;
        }
        #endregion

        public void button_Display_Click(object sender, EventArgs e)
        {
            if (com_ACC.SelectedValue == null)
            {
                MessageBox.Show("يجب تحديد حساب", "عرض كشف حساب", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }

            // Validate values
            st.ID = com_ACC.SelectedValue.ToString();
            if (dtp_form.Checked == false) { st.date_From = "01/01/1753"; } else { st.date_From = dtp_form.Value.Date.ToString("dd/MM/yyyy"); }
            if (dtp_to.Checked == false) { st.date_To = "12/31/9998"; } else { st.date_To = dtp_to.Value.Date.ToString("dd/MM/yyyy"); }

            // Get data from database
            dt_st = st.Select();

            // remove or leav first row of Open Balance
            if (dt_st.Rows[0]["Debit"].ToString() != "" & dt_st.Rows[0]["Credit"].ToString() != "")
            {
                if (Convert.ToDecimal(dt_st.Rows[0]["Debit"]) == 0 && Convert.ToDecimal(dt_st.Rows[0]["Credit"]) == 0)
                {
                    dt_st.Rows.RemoveAt(0);
                }
            }
            else
            {
                dt_st.Rows.RemoveAt(0);
            }


            dgv.DataSource = null;
            dgv.DataSource = dt_st;

            dt_st.DefaultView.Sort = "Date ASC";
            dt_st = dt_st.DefaultView.ToTable();

            // Balance
            foreach (DataGridViewRow r in dgv.Rows)
            {
                if (dgv.Rows[r.Index].Index >= 1)
                {
                    r.Cells["Balance"].Value = Convert.ToDecimal(dgv.Rows[r.Index - 1].Cells["Balance"].Value) + (Convert.ToDecimal(r.Cells["Debit"].Value) - Convert.ToDecimal(r.Cells["Credit"].Value));
                }
                else if (dgv.Rows[r.Index].Cells["Balance"].RowIndex >= 0)
                {
                    r.Cells["Balance"].Value = (Convert.ToDecimal(r.Cells["Debit"].Value) - Convert.ToDecimal(r.Cells["Credit"].Value));
                }
            }

            // Total Debit & Total Credit
            decimal d = 0;
            decimal c = 0;
            foreach (DataGridViewRow dr in dgv.Rows)
            {
                d += Convert.ToDecimal(dr.Cells["Debit"].Value);
                c += Convert.ToDecimal(dr.Cells["Credit"].Value);
            }

            txt_TotalDebit.Text = d.ToString();
            txt_TotalCredit.Text = c.ToString();
            txt_TotalBalance.Text = (d - c).ToString();

            if (dgv.RowCount >= 1)
            {
                txt_TotalOpen.Text = (dgv.Rows[0].Cells["Notes"].Value.ToString() == "رصيد إفتتاحي") ? dgv.Rows[0].Cells["Balance"].Value.ToString() : "0.00";
            }

            if (dgv.SelectedRows.Count > 0) { dgv.SelectedRows[0].Selected = false; }
            EmptyZero();
        }
        private void dtp_form_ValueChanged(object sender, EventArgs e)
        {
            if (dtp_form.Checked == true) { dtp_form.Format = DateTimePickerFormat.Short; }
        }
        private void dtp_form_MouseUp(object sender, MouseEventArgs e)
        {
            if (dtp_form.Checked == true) { dtp_form.Format = DateTimePickerFormat.Short; }
            if (dtp_form.Checked == false) { dtp_form.Format = DateTimePickerFormat.Custom; }
        }
        private void dtp_to_ValueChanged(object sender, EventArgs e)
        {
            if (dtp_to.Checked == true) { dtp_to.Format = DateTimePickerFormat.Short; }
        }
        private void dtp_to_MouseUp(object sender, MouseEventArgs e)
        {
            if (dtp_to.Checked == true) { dtp_to.Format = DateTimePickerFormat.Short; }
            if (dtp_to.Checked == false) { dtp_to.Format = DateTimePickerFormat.Custom; }
        }
        private void btn_ACC_Search_Click(object sender, EventArgs e)
        {
            search.com = com_ACC;
            search.Text = "بحث عن حساب";

            search.dt = (DataTable)com_ACC.DataSource;

            search.dgv.Columns[0].DataPropertyName = "ID";
            search.dgv.Columns[1].DataPropertyName = "Name";

            search.dgv.AutoGenerateColumns = false;
            search.dgv.DataSource = search.dt;
            search.ShowDialog();

            com_ACC.Text = search.txt;
        }

        #endregion

        #region Print

        #region Declarations
        int Page_W = 840;
        int Page_H = 1180;
        int RepHeader_H = 120;
        int PageHeader_H = 110;
        int ColumnsHeader_H = 60;
        int Row_H = 24;
        int RepFooter_H = 300;
        int PageFooter_H = 75;
        int PagesConnt = 1;

        bool Page_RL = true;
        int Page_LMargin = 10;

        Pen p = new Pen(Brushes.Black, 1);
        Font fh = new Font("Calibri", 12);
        Font fb = new Font("Calibri", 10);
        Font fs = new Font("Calibri", 8);

        int Cell_W = 200;
        int Table_W = 0;
        int row_no = 0;
        int page_no = 1;

        int rowh = 24;

        DataTable dt_PrintSettings = new DataTable();
        DataTable dt_Footer = new DataTable();
        #endregion

        #region Pro
        public int GetPageCount()
        {
            int PageCount = 1;
            int RowStart = RepHeader_H + PageHeader_H + ColumnsHeader_H;

            foreach (DataGridViewRow r in dgv.Rows)
            {
                if (RowStart > Page_H - PageFooter_H - Row_H)
                {
                    PageCount++;
                    RowStart = RepHeader_H + PageHeader_H + ColumnsHeader_H;
                }

                using (System.Drawing.Graphics graphics = System.Drawing.Graphics.FromImage(new Bitmap(1, 1)))
                {
                    SizeF size = graphics.MeasureString(r.Cells["Notes"].Value.ToString(), fb);
                    decimal sw = Convert.ToDecimal(dt_PrintSettings.Rows[0]["NotesWidth"]);
                    if ((decimal)size.Width > sw)
                    {
                        decimal d = Math.Ceiling((decimal)size.Width / sw);
                        RowStart += Row_H * (int)d;
                    }
                    else
                    {
                        RowStart += Row_H;
                    }
                }

            }
            return PageCount;
        }
        #endregion

        private void btn_PrintPreview_Click(object sender, EventArgs e)
        {
            ((Form)printPreviewDialog1).WindowState = FormWindowState.Maximized;
            printPreviewDialog1.PrintPreviewControl.Zoom = 1;
            if (Demo) ((ToolStripButton)((ToolStrip)printPreviewDialog1.Controls[1]).Items[0]).Enabled = false;
            printPreviewDialog1.ShowDialog();
        }
        private void btn_Print_Click(object sender, EventArgs e)
        {
            if (printDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }
        private void printDocument1_BeginPrint(object sender, PrintEventArgs e)
        {
            dt_PrintSettings.Columns.Clear();
            dt_PrintSettings.Rows.Clear();

            dt_PrintSettings.Columns.Add("DocName", typeof(string));
            dt_PrintSettings.Columns.Add("DebitWidth", typeof(int));
            dt_PrintSettings.Columns.Add("CreditWidth", typeof(int));
            dt_PrintSettings.Columns.Add("BalanceWidth", typeof(int));
            dt_PrintSettings.Columns.Add("NotesWidth", typeof(int));
            dt_PrintSettings.Columns.Add("JorIDWidth", typeof(int));
            dt_PrintSettings.Columns.Add("DateWidth", typeof(int));
            dt_PrintSettings.Columns.Add("RefTypeNameWidth", typeof(int));
            dt_PrintSettings.Columns.Add("RefIDWidth", typeof(int));

            dt_PrintSettings.Rows.Add("St", 70, 70, 70, 250, 85, 90, 85, 75);

            dt_Footer.Columns.Clear();
            dt_Footer.Rows.Clear();

            dt_Footer.Columns.Add("Anm", typeof(string));
            dt_Footer.Columns.Add("Enm", typeof(string));
            dt_Footer.Columns.Add("Val", typeof(string));

            PagesConnt = GetPageCount();
            page_no = 1;
            row_no = 0;

            printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("PaperA4", Page_W, Page_H);
        }
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            var format = new StringFormat() { Alignment = (Page_RL) ? StringAlignment.Center : StringAlignment.Center };
            RectangleF rect;

            Image img = Image.FromFile(@"D:\GAS\01\logo1.bmp");

            #region Columns
            int top = RepHeader_H + PageHeader_H;
            int Cell_Left = Page_LMargin;
            Graphics g = this.CreateGraphics();

            Table_W = 0;

            int i = (Page_RL) ? dgv.Columns.Count - 1 : 0;
            foreach (DataGridViewColumn c in dgv.Columns)
            {
                if (dgv.Columns[i].Visible == false) continue;

                string s = dgv.Columns[dgv.Columns[i].Index].HeaderText.ToString();
                if (dgv.Columns[i].Name == "Debit")
                {
                    Cell_W = Convert.ToInt32(dt_PrintSettings.Rows[0]["DebitWidth"]);
                }
                else if (dgv.Columns[i].Name == "Credit")
                {
                    Cell_W = Convert.ToInt32(dt_PrintSettings.Rows[0]["CreditWidth"]);
                }
                else if (dgv.Columns[i].Name == "Balance")
                {
                    Cell_W = Convert.ToInt32(dt_PrintSettings.Rows[0]["BalanceWidth"]);
                }
                else if (dgv.Columns[i].Name == "Notes")
                {
                    Cell_W = Convert.ToInt32(dt_PrintSettings.Rows[0]["NotesWidth"]);
                }
                else if (dgv.Columns[i].Name == "JorID")
                {
                    Cell_W = Convert.ToInt32(dt_PrintSettings.Rows[0]["JorIDWidth"]);
                }
                else if (dgv.Columns[i].Name == "Date")
                {
                    Cell_W = Convert.ToInt32(dt_PrintSettings.Rows[0]["DateWidth"]);
                }
                else if (dgv.Columns[i].Name == "RefTypeName")
                {
                    Cell_W = Convert.ToInt32(dt_PrintSettings.Rows[0]["RefTypeNameWidth"]);
                }
                else if (dgv.Columns[i].Name == "RefID")
                {
                    Cell_W = Convert.ToInt32(dt_PrintSettings.Rows[0]["RefIDWidth"]);
                }

                e.Graphics.FillRectangle(Brushes.LightGray, new Rectangle(Cell_Left, top, Cell_W, ColumnsHeader_H));
                e.Graphics.DrawRectangle(p, new Rectangle(Cell_Left, top, Cell_W, ColumnsHeader_H));
                e.Graphics.DrawString(s, fb, Brushes.Black, new Rectangle(Cell_Left + 10, top + 8, Cell_W, ColumnsHeader_H));

                Table_W += Cell_W;
                Cell_Left += Cell_W;

                if (Page_RL) { i--; } else { i++; }
            }
            i = (Page_RL) ? dgv.Columns.Count - 1 : 0;

            Page_LMargin = 10;
            #endregion

            #region Rep_Header
            rect = new RectangleF(Page_LMargin, 0, Table_W, RepHeader_H);
            e.Graphics.DrawImage(img, rect);
            #endregion

            #region Page_Header
            rect = new RectangleF((Page_W / 2) - 100, RepHeader_H, 200, 20);
            e.Graphics.DrawRectangle(p, rect.X, rect.Y, rect.Width, rect.Height);
            e.Graphics.DrawString(((Page_RL) ? "كشف حساب" : "Account Statment"), fh, Brushes.Black, rect, format);

            format = new StringFormat() { Alignment = (Page_RL) ? StringAlignment.Far : StringAlignment.Near };

            // Draw Head Rect
            e.Graphics.DrawRectangle(p, new Rectangle(Page_LMargin, RepHeader_H, Table_W, PageHeader_H));

            rect = new RectangleF((Page_RL) ? Table_W - 200 : Page_LMargin + 5, 150, 200, 20);
            e.Graphics.DrawString(((Page_RL) ? "الحساب : " : "Account : ") + com_ACC.Text + "   " + com_ACC.SelectedValue, fb, Brushes.Black, rect, format);

            rect = new RectangleF((Page_RL) ? Table_W - 200 : Page_LMargin + 5, 170, 200, 30);
            e.Graphics.DrawString(((Page_RL) ? "من : " : "From : ") + dtp_form.Value.ToString("dd/MM/yyyy"), fb, Brushes.Black, rect, format);

            rect = new RectangleF((Page_RL) ? Table_W - 200 : Page_LMargin + 5, 190, 200, 30);
            e.Graphics.DrawString(((Page_RL) ? "إلى : " : "To : ") + dtp_to.Value.ToString("dd/MM/yyyy"), fb, Brushes.Black, rect, format);
            #endregion

            #region Page_Footer
            e.Graphics.FillRectangle(Brushes.LightGray, new Rectangle(Page_LMargin, Page_H - PageFooter_H, Table_W, 20));
            e.Graphics.DrawRectangle(p, new Rectangle(Page_LMargin, Page_H - PageFooter_H, Table_W, 20));
            rect = new RectangleF((Page_RL) ? (Table_W - 200) : Page_LMargin + 5, Page_H - PageFooter_H + 3, 200, 20);
            e.Graphics.DrawString(((Page_RL) ? " صفحة رقم" : "Page No ") + " : " + page_no + " / " + PagesConnt, fs, Brushes.Black, rect, format);
            #endregion

            #region Rows

            Cell_Left = Page_LMargin;
            top = RepHeader_H + PageHeader_H + ColumnsHeader_H;


            while (row_no < dgv.RowCount)
            {
                if (top > Page_H - PageFooter_H - Row_H)
                {
                    e.HasMorePages = true;
                    top = RepHeader_H + PageHeader_H + ColumnsHeader_H;
                    page_no++;
                    return;
                }



                using (System.Drawing.Graphics graphics = System.Drawing.Graphics.FromImage(new Bitmap(1, 1)))
                {
                    SizeF size = graphics.MeasureString(dgv.Rows[row_no].Cells["Notes"].Value.ToString(), fb);
                    decimal sw = Convert.ToDecimal(dt_PrintSettings.Rows[0]["NotesWidth"]);
                    if ((decimal)size.Width > sw)
                    {
                        decimal d = Math.Ceiling((decimal)size.Width / sw);
                        rowh = rowh * (int)d;
                    }
                    else
                    {
                        rowh = Row_H;

                    }
                }


                foreach (DataGridViewColumn c in dgv.Columns)
                {
                    if (dgv.Columns[i].Visible == false) continue;


                    string s = s = (dgv.Rows[row_no].Cells[dgv.Columns[i].Index].Value == null) ? "" : dgv.Rows[row_no].Cells[dgv.Columns[i].Index].Value.ToString();



                    if (dgv.Columns[i].Name == "Debit")
                    {
                        Cell_W = Convert.ToInt32(dt_PrintSettings.Rows[0]["DebitWidth"]);
                        if (dgv.Rows[row_no].Cells[dgv.Columns[i].Index].Value.ToString() == "0.00")
                        {
                            s = "";
                        }
                    }
                    else if (dgv.Columns[i].Name == "Credit")
                    {
                        Cell_W = Convert.ToInt32(dt_PrintSettings.Rows[0]["CreditWidth"]);
                        if (dgv.Rows[row_no].Cells[dgv.Columns[i].Index].Value.ToString() == "0.00")
                        {
                            s = "";
                        }
                    }
                    else if (dgv.Columns[i].Name == "Balance")
                    {
                        Cell_W = Convert.ToInt32(dt_PrintSettings.Rows[0]["BalanceWidth"]);
                    }
                    else if (dgv.Columns[i].Name == "Notes")
                    {
                        Cell_W = Convert.ToInt32(dt_PrintSettings.Rows[0]["NotesWidth"]);
                    }
                    else if (dgv.Columns[i].Name == "JorID")
                    {
                        Cell_W = Convert.ToInt32(dt_PrintSettings.Rows[0]["JorIDWidth"]);
                    }
                    else if (dgv.Columns[i].Name == "Date")
                    {
                        Cell_W = Convert.ToInt32(dt_PrintSettings.Rows[0]["DateWidth"]);
                        if(dgv.Rows[row_no].Cells[dgv.Columns[i].Index].Value is DBNull)
                        {
                            s = "";
                        }
                        else
                        {
                            s = (Convert.ToDateTime(dgv.Rows[row_no].Cells[dgv.Columns[i].Index].Value)).ToString("dd/MM/yyyy");
                        }

                    }
                    else if (dgv.Columns[i].Name == "RefTypeName")
                    {
                        Cell_W = Convert.ToInt32(dt_PrintSettings.Rows[0]["RefTypeNameWidth"]);
                    }
                    else if (dgv.Columns[i].Name == "RefID")
                    {
                        Cell_W = Convert.ToInt32(dt_PrintSettings.Rows[0]["RefIDWidth"]);
                    }


                    e.Graphics.DrawRectangle(p, new Rectangle(Cell_Left, top, Cell_W, rowh));
                    e.Graphics.DrawString(s, fb, Brushes.Black, new Rectangle(Cell_Left + 8, top + 5, Cell_W, rowh));

                    Cell_Left += Cell_W;
                    if (Page_RL) { i--; } else { i++; }
                }
                i = (Page_RL) ? dgv.Columns.Count - 1 : 0;
                row_no++;
                Cell_Left = Page_LMargin;
                top += rowh;
            }
            #endregion

            #region Rep_Footer
            dt_Footer.Rows.Add("رصيد افتتاحي", "Opening Balance", txt_TotalOpen.Text);
            dt_Footer.Rows.Add("مدين", "Debit", txt_TotalDebit.Text);
            dt_Footer.Rows.Add("دائن", "Credit", txt_TotalCredit.Text);
            dt_Footer.Rows.Add("الرصيد", "Balance", txt_TotalBalance.Text);

            i = (Page_RL) ? dt_Footer.Rows.Count - 1 : 0;
            Cell_W = Table_W / 4;


            if (top > Page_H - PageFooter_H - RepFooter_H)
            {
                e.HasMorePages = true;
                top = RepHeader_H + PageHeader_H + ColumnsHeader_H;
                page_no++;
                return;
            }

            top += Row_H;

            foreach (DataRow r in dt_Footer.Rows)
            {
                string name = ((Page_RL) ? dt_Footer.Rows[i]["Anm"].ToString() : dt_Footer.Rows[i]["Enm"].ToString()) + " :   " + dt_Footer.Rows[i]["Val"].ToString(); ;
                string val = dt_Footer.Rows[i]["Val"].ToString();

                e.Graphics.DrawRectangle(p, new Rectangle(Cell_Left, top, Cell_W, rowh));
                e.Graphics.DrawString(name, fb, Brushes.Black, new Rectangle(Cell_Left + 8, top + 5, Cell_W, rowh));

                Cell_Left += Cell_W;
                if (Page_RL) { i--; } else { i++; }
            }

            top = Page_H - PageFooter_H - 100;

            e.Graphics.DrawString("المدير المالي", fb, Brushes.Black, new Rectangle(Page_LMargin +(Table_W/4), top, (Table_W / 4), 20));
            e.Graphics.DrawString("المحاسب", fb, Brushes.Black, new Rectangle(Page_LMargin + (Table_W / 4) * 3, top, (Table_W / 4), 20));

            top += 50;

            e.Graphics.DrawString("-----------------", fb, Brushes.Black, new Rectangle(Page_LMargin + (Table_W / 4)-10, top, (Table_W / 4), 20));
            e.Graphics.DrawString("-----------------", fb, Brushes.Black, new Rectangle(Page_LMargin + (Table_W / 4) * 3-10, top, (Table_W / 4), 20));
            #endregion
        }
    }
         #endregion
}
