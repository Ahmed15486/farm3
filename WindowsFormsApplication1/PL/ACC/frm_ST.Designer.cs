namespace WindowsFormsApplication1.PL.ACC
{
    partial class frm_ST
    {
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_ST));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_Display = new System.Windows.Forms.Button();
            this.btn_Print = new System.Windows.Forms.Button();
            this.btn_PrintPreview = new System.Windows.Forms.Button();
            this.groupBox_Header = new System.Windows.Forms.GroupBox();
            this.btn_ACC_Search = new System.Windows.Forms.Button();
            this.com_ACC = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtp_to = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dtp_form = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox_Details = new System.Windows.Forms.GroupBox();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.groupBox_Footer_Details = new System.Windows.Forms.GroupBox();
            this.txt_TotalBalance = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_TotalCredit = new System.Windows.Forms.TextBox();
            this.txt_TotalDebit = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txt_TotalOpen = new System.Windows.Forms.TextBox();
            this.groupBox_Footer_Controls = new System.Windows.Forms.GroupBox();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.Debit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Credit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Balance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Notes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JorID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RefTypeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RefID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox_Header.SuspendLayout();
            this.groupBox_Details.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.groupBox_Footer_Details.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_Display);
            this.groupBox1.Controls.Add(this.btn_Print);
            this.groupBox1.Controls.Add(this.btn_PrintPreview);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1167, 87);
            this.groupBox1.TabIndex = 53;
            this.groupBox1.TabStop = false;
            // 
            // button_Display
            // 
            this.button_Display.Dock = System.Windows.Forms.DockStyle.Left;
            this.button_Display.FlatAppearance.BorderSize = 0;
            this.button_Display.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Display.Image = global::WindowsFormsApplication1.Properties.Resources.Display_48__2_;
            this.button_Display.Location = new System.Drawing.Point(141, 16);
            this.button_Display.Name = "button_Display";
            this.button_Display.Size = new System.Drawing.Size(69, 68);
            this.button_Display.TabIndex = 4;
            this.button_Display.Text = "عرض";
            this.button_Display.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button_Display.UseVisualStyleBackColor = true;
            this.button_Display.Click += new System.EventHandler(this.button_Display_Click);
            this.button_Display.MouseEnter += new System.EventHandler(this.button_Display_MouseEnter);
            this.button_Display.MouseLeave += new System.EventHandler(this.button_Display_MouseLeave);
            // 
            // btn_Print
            // 
            this.btn_Print.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_Print.FlatAppearance.BorderSize = 0;
            this.btn_Print.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Print.ImageKey = "Print";
            this.btn_Print.Location = new System.Drawing.Point(72, 16);
            this.btn_Print.Name = "btn_Print";
            this.btn_Print.Size = new System.Drawing.Size(69, 68);
            this.btn_Print.TabIndex = 8;
            this.btn_Print.Text = "طباعة";
            this.btn_Print.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_Print.UseVisualStyleBackColor = true;
            this.btn_Print.Click += new System.EventHandler(this.btn_Print_Click);
            // 
            // btn_PrintPreview
            // 
            this.btn_PrintPreview.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_PrintPreview.FlatAppearance.BorderSize = 0;
            this.btn_PrintPreview.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_PrintPreview.ImageKey = "Settings";
            this.btn_PrintPreview.Location = new System.Drawing.Point(3, 16);
            this.btn_PrintPreview.Name = "btn_PrintPreview";
            this.btn_PrintPreview.Size = new System.Drawing.Size(69, 68);
            this.btn_PrintPreview.TabIndex = 7;
            this.btn_PrintPreview.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_PrintPreview.UseVisualStyleBackColor = true;
            this.btn_PrintPreview.Click += new System.EventHandler(this.btn_PrintPreview_Click);
            // 
            // groupBox_Header
            // 
            this.groupBox_Header.Controls.Add(this.btn_ACC_Search);
            this.groupBox_Header.Controls.Add(this.com_ACC);
            this.groupBox_Header.Controls.Add(this.label3);
            this.groupBox_Header.Controls.Add(this.dtp_to);
            this.groupBox_Header.Controls.Add(this.label1);
            this.groupBox_Header.Controls.Add(this.dtp_form);
            this.groupBox_Header.Controls.Add(this.label7);
            this.groupBox_Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox_Header.Location = new System.Drawing.Point(0, 87);
            this.groupBox_Header.Name = "groupBox_Header";
            this.groupBox_Header.Size = new System.Drawing.Size(1167, 107);
            this.groupBox_Header.TabIndex = 54;
            this.groupBox_Header.TabStop = false;
            this.groupBox_Header.Tag = "";
            // 
            // btn_ACC_Search
            // 
            this.btn_ACC_Search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_ACC_Search.Image = global::WindowsFormsApplication1.Properties.Resources.Search_16;
            this.btn_ACC_Search.Location = new System.Drawing.Point(808, 36);
            this.btn_ACC_Search.Name = "btn_ACC_Search";
            this.btn_ACC_Search.Size = new System.Drawing.Size(27, 23);
            this.btn_ACC_Search.TabIndex = 154;
            this.btn_ACC_Search.UseVisualStyleBackColor = true;
            this.btn_ACC_Search.Click += new System.EventHandler(this.btn_ACC_Search_Click);
            // 
            // com_ACC
            // 
            this.com_ACC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.com_ACC.DisplayMember = "Name";
            this.com_ACC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.com_ACC.FormattingEnabled = true;
            this.com_ACC.Location = new System.Drawing.Point(836, 37);
            this.com_ACC.Name = "com_ACC";
            this.com_ACC.Size = new System.Drawing.Size(227, 21);
            this.com_ACC.TabIndex = 152;
            this.com_ACC.ValueMember = "ID";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1068, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 153;
            this.label3.Text = "الحساب";
            // 
            // dtp_to
            // 
            this.dtp_to.Checked = false;
            this.dtp_to.CustomFormat = " ";
            this.dtp_to.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_to.Location = new System.Drawing.Point(26, 37);
            this.dtp_to.Name = "dtp_to";
            this.dtp_to.RightToLeftLayout = true;
            this.dtp_to.ShowCheckBox = true;
            this.dtp_to.Size = new System.Drawing.Size(150, 20);
            this.dtp_to.TabIndex = 36;
            this.dtp_to.Value = new System.DateTime(2015, 9, 3, 0, 0, 0, 0);
            this.dtp_to.ValueChanged += new System.EventHandler(this.dtp_to_ValueChanged);
            this.dtp_to.MouseUp += new System.Windows.Forms.MouseEventHandler(this.dtp_to_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(182, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 35;
            this.label1.Text = "إلى تاريخ";
            // 
            // dtp_form
            // 
            this.dtp_form.Checked = false;
            this.dtp_form.CustomFormat = " ";
            this.dtp_form.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_form.Location = new System.Drawing.Point(239, 36);
            this.dtp_form.Name = "dtp_form";
            this.dtp_form.RightToLeftLayout = true;
            this.dtp_form.ShowCheckBox = true;
            this.dtp_form.Size = new System.Drawing.Size(150, 20);
            this.dtp_form.TabIndex = 27;
            this.dtp_form.Value = new System.DateTime(2015, 9, 3, 18, 11, 44, 0);
            this.dtp_form.ValueChanged += new System.EventHandler(this.dtp_form_ValueChanged);
            this.dtp_form.MouseUp += new System.Windows.Forms.MouseEventHandler(this.dtp_form_MouseUp);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(395, 39);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "من تاريخ";
            // 
            // groupBox_Details
            // 
            this.groupBox_Details.Controls.Add(this.dgv);
            this.groupBox_Details.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_Details.Location = new System.Drawing.Point(0, 194);
            this.groupBox_Details.Name = "groupBox_Details";
            this.groupBox_Details.Size = new System.Drawing.Size(1167, 380);
            this.groupBox_Details.TabIndex = 55;
            this.groupBox_Details.TabStop = false;
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgv.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Debit,
            this.Credit,
            this.Balance,
            this.Notes,
            this.JorID,
            this.Date,
            this.RefTypeName,
            this.RefID});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.CadetBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv.Location = new System.Drawing.Point(3, 16);
            this.dgv.MultiSelect = false;
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgv.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgv.RowTemplate.Height = 30;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(1161, 361);
            this.dgv.TabIndex = 16;
            // 
            // groupBox_Footer_Details
            // 
            this.groupBox_Footer_Details.Controls.Add(this.txt_TotalBalance);
            this.groupBox_Footer_Details.Controls.Add(this.label2);
            this.groupBox_Footer_Details.Controls.Add(this.label4);
            this.groupBox_Footer_Details.Controls.Add(this.txt_TotalCredit);
            this.groupBox_Footer_Details.Controls.Add(this.txt_TotalDebit);
            this.groupBox_Footer_Details.Controls.Add(this.label15);
            this.groupBox_Footer_Details.Controls.Add(this.label14);
            this.groupBox_Footer_Details.Controls.Add(this.txt_TotalOpen);
            this.groupBox_Footer_Details.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox_Footer_Details.Location = new System.Drawing.Point(0, 574);
            this.groupBox_Footer_Details.Name = "groupBox_Footer_Details";
            this.groupBox_Footer_Details.Size = new System.Drawing.Size(1167, 100);
            this.groupBox_Footer_Details.TabIndex = 68;
            this.groupBox_Footer_Details.TabStop = false;
            // 
            // txt_TotalBalance
            // 
            this.txt_TotalBalance.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txt_TotalBalance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txt_TotalBalance.Location = new System.Drawing.Point(172, 48);
            this.txt_TotalBalance.Name = "txt_TotalBalance";
            this.txt_TotalBalance.ReadOnly = true;
            this.txt_TotalBalance.Size = new System.Drawing.Size(100, 24);
            this.txt_TotalBalance.TabIndex = 66;
            this.txt_TotalBalance.Text = "0.00";
            this.txt_TotalBalance.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(517, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 63;
            this.label2.Text = "دائن";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(195, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 65;
            this.label4.Text = "رصيد نهائي";
            // 
            // txt_TotalCredit
            // 
            this.txt_TotalCredit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txt_TotalCredit.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txt_TotalCredit.Location = new System.Drawing.Point(477, 48);
            this.txt_TotalCredit.Name = "txt_TotalCredit";
            this.txt_TotalCredit.ReadOnly = true;
            this.txt_TotalCredit.Size = new System.Drawing.Size(100, 24);
            this.txt_TotalCredit.TabIndex = 64;
            this.txt_TotalCredit.Text = "0.00";
            this.txt_TotalCredit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_TotalDebit
            // 
            this.txt_TotalDebit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txt_TotalDebit.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txt_TotalDebit.Location = new System.Drawing.Point(583, 48);
            this.txt_TotalDebit.Name = "txt_TotalDebit";
            this.txt_TotalDebit.ReadOnly = true;
            this.txt_TotalDebit.Size = new System.Drawing.Size(100, 24);
            this.txt_TotalDebit.TabIndex = 62;
            this.txt_TotalDebit.Text = "0.00";
            this.txt_TotalDebit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(885, 28);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(70, 13);
            this.label15.TabIndex = 59;
            this.label15.Text = "رصيد إفتتاحي";
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(616, 28);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(30, 13);
            this.label14.TabIndex = 61;
            this.label14.Text = "مدين";
            // 
            // txt_TotalOpen
            // 
            this.txt_TotalOpen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txt_TotalOpen.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txt_TotalOpen.Location = new System.Drawing.Point(864, 48);
            this.txt_TotalOpen.Name = "txt_TotalOpen";
            this.txt_TotalOpen.ReadOnly = true;
            this.txt_TotalOpen.Size = new System.Drawing.Size(100, 24);
            this.txt_TotalOpen.TabIndex = 60;
            this.txt_TotalOpen.Text = "0.00";
            this.txt_TotalOpen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox_Footer_Controls
            // 
            this.groupBox_Footer_Controls.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox_Footer_Controls.Location = new System.Drawing.Point(0, 674);
            this.groupBox_Footer_Controls.Name = "groupBox_Footer_Controls";
            this.groupBox_Footer_Controls.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox_Footer_Controls.Size = new System.Drawing.Size(1167, 61);
            this.groupBox_Footer_Controls.TabIndex = 67;
            this.groupBox_Footer_Controls.TabStop = false;
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.ShowIcon = false;
            this.printPreviewDialog1.Visible = false;
            // 
            // printDocument1
            // 
            this.printDocument1.BeginPrint += new System.Drawing.Printing.PrintEventHandler(this.printDocument1_BeginPrint);
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printDialog1
            // 
            this.printDialog1.Document = this.printDocument1;
            this.printDialog1.UseEXDialog = true;
            // 
            // Debit
            // 
            this.Debit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Debit.DataPropertyName = "Debit";
            this.Debit.HeaderText = "مدين";
            this.Debit.MinimumWidth = 2;
            this.Debit.Name = "Debit";
            this.Debit.ReadOnly = true;
            // 
            // Credit
            // 
            this.Credit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Credit.DataPropertyName = "Credit";
            this.Credit.HeaderText = "دائن";
            this.Credit.Name = "Credit";
            this.Credit.ReadOnly = true;
            // 
            // Balance
            // 
            this.Balance.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Balance.DataPropertyName = "Balance";
            this.Balance.FillWeight = 23.87588F;
            this.Balance.HeaderText = "الرصيد";
            this.Balance.Name = "Balance";
            this.Balance.ReadOnly = true;
            // 
            // Notes
            // 
            this.Notes.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Notes.DataPropertyName = "Notes";
            this.Notes.HeaderText = "البيان";
            this.Notes.MinimumWidth = 100;
            this.Notes.Name = "Notes";
            this.Notes.ReadOnly = true;
            // 
            // JorID
            // 
            this.JorID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.JorID.DataPropertyName = "JorID";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.NullValue = null;
            this.JorID.DefaultCellStyle = dataGridViewCellStyle3;
            this.JorID.FillWeight = 23.87588F;
            this.JorID.HeaderText = "رقم القيد";
            this.JorID.Name = "JorID";
            this.JorID.ReadOnly = true;
            // 
            // Date
            // 
            this.Date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Date.DataPropertyName = "Date";
            this.Date.FillWeight = 23.87588F;
            this.Date.HeaderText = "تاريخ القيد";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            // 
            // RefTypeName
            // 
            this.RefTypeName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.RefTypeName.DataPropertyName = "RefTypeName";
            this.RefTypeName.FillWeight = 23.87588F;
            this.RefTypeName.HeaderText = "نوع السند";
            this.RefTypeName.Name = "RefTypeName";
            this.RefTypeName.ReadOnly = true;
            this.RefTypeName.Width = 120;
            // 
            // RefID
            // 
            this.RefID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.RefID.DataPropertyName = "RefID";
            this.RefID.HeaderText = "رقم السند";
            this.RefID.Name = "RefID";
            this.RefID.ReadOnly = true;
            // 
            // frm_ST
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1167, 735);
            this.Controls.Add(this.groupBox_Details);
            this.Controls.Add(this.groupBox_Footer_Details);
            this.Controls.Add(this.groupBox_Footer_Controls);
            this.Controls.Add(this.groupBox_Header);
            this.Controls.Add(this.groupBox1);
            this.Name = "frm_ST";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "كشف حساب";
            this.Shown += new System.EventHandler(this.frm_ST_Shown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox_Header.ResumeLayout(false);
            this.groupBox_Header.PerformLayout();
            this.groupBox_Details.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.groupBox_Footer_Details.ResumeLayout(false);
            this.groupBox_Footer_Details.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.Button btn_Print;
        public System.Windows.Forms.Button btn_PrintPreview;
        public System.Windows.Forms.Button button_Display;
        public System.Windows.Forms.GroupBox groupBox_Header;
        private System.Windows.Forms.DateTimePicker dtp_form;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.GroupBox groupBox_Details;
        public System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.GroupBox groupBox_Footer_Details;
        public System.Windows.Forms.TextBox txt_TotalDebit;
        public System.Windows.Forms.Label label15;
        public System.Windows.Forms.Label label14;
        public System.Windows.Forms.TextBox txt_TotalOpen;
        private System.Windows.Forms.GroupBox groupBox_Footer_Controls;
        private System.Windows.Forms.DateTimePicker dtp_to;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txt_TotalBalance;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txt_TotalCredit;
        private System.Windows.Forms.Button btn_ACC_Search;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintDialog printDialog1;
        public System.Windows.Forms.ComboBox com_ACC;
        private System.Windows.Forms.DataGridViewTextBoxColumn Debit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Credit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Balance;
        private System.Windows.Forms.DataGridViewTextBoxColumn Notes;
        private System.Windows.Forms.DataGridViewTextBoxColumn JorID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn RefTypeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn RefID;
    }
}