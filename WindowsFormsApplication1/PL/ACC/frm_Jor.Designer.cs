namespace WindowsFormsApplication1.PL.ACC
{
    partial class frm_Jor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
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

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_TotalCredit = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_TotalDebit = new System.Windows.Forms.TextBox();
            this.txt_Date = new System.Windows.Forms.TextBox();
            this.dtp_Date = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.grpx_Head = new System.Windows.Forms.GroupBox();
            this.com_JorType = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_RefID = new System.Windows.Forms.Button();
            this.lbl_RefID = new System.Windows.Forms.Label();
            this.com_RefType = new System.Windows.Forms.ComboBox();
            this.lbl_RefType = new System.Windows.Forms.Label();
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Notes = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Edit = new System.Windows.Forms.Button();
            this.btn_New = new System.Windows.Forms.Button();
            this.grbx_Controls = new System.Windows.Forms.GroupBox();
            this.grbx_Add = new System.Windows.Forms.GroupBox();
            this.btn_Add = new System.Windows.Forms.Button();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.groupBox_Footer_Controls = new System.Windows.Forms.GroupBox();
            this.lbl_info = new System.Windows.Forms.Label();
            this.txt_Search = new System.Windows.Forms.TextBox();
            this.button_Next = new System.Windows.Forms.Button();
            this.button_Prev = new System.Windows.Forms.Button();
            this.button_Last = new System.Windows.Forms.Button();
            this.button_First = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.grpx_Head.SuspendLayout();
            this.grbx_Controls.SuspendLayout();
            this.grbx_Add.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.groupBox_Footer_Controls.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_TotalCredit);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txt_TotalDebit);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(0, 600);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1107, 71);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            // 
            // txt_TotalCredit
            // 
            this.txt_TotalCredit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txt_TotalCredit.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txt_TotalCredit.Location = new System.Drawing.Point(362, 30);
            this.txt_TotalCredit.Name = "txt_TotalCredit";
            this.txt_TotalCredit.ReadOnly = true;
            this.txt_TotalCredit.Size = new System.Drawing.Size(141, 24);
            this.txt_TotalCredit.TabIndex = 70;
            this.txt_TotalCredit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(759, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 67;
            this.label3.Text = "مدين";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(509, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 69;
            this.label4.Text = "دائن";
            // 
            // txt_TotalDebit
            // 
            this.txt_TotalDebit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txt_TotalDebit.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txt_TotalDebit.Location = new System.Drawing.Point(612, 30);
            this.txt_TotalDebit.Name = "txt_TotalDebit";
            this.txt_TotalDebit.ReadOnly = true;
            this.txt_TotalDebit.Size = new System.Drawing.Size(141, 24);
            this.txt_TotalDebit.TabIndex = 68;
            this.txt_TotalDebit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_Date
            // 
            this.txt_Date.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Date.Location = new System.Drawing.Point(735, 15);
            this.txt_Date.Name = "txt_Date";
            this.txt_Date.ReadOnly = true;
            this.txt_Date.Size = new System.Drawing.Size(109, 20);
            this.txt_Date.TabIndex = 122;
            this.txt_Date.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dtp_Date
            // 
            this.dtp_Date.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtp_Date.CustomFormat = " ";
            this.dtp_Date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_Date.Location = new System.Drawing.Point(715, 15);
            this.dtp_Date.Name = "dtp_Date";
            this.dtp_Date.RightToLeftLayout = true;
            this.dtp_Date.Size = new System.Drawing.Size(42, 20);
            this.dtp_Date.TabIndex = 124;
            this.dtp_Date.TabStop = false;
            this.dtp_Date.ValueChanged += new System.EventHandler(this.dtp_BirthDate_ValueChanged);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(850, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 123;
            this.label6.Text = "التاريخ";
            // 
            // grpx_Head
            // 
            this.grpx_Head.Controls.Add(this.com_JorType);
            this.grpx_Head.Controls.Add(this.label5);
            this.grpx_Head.Controls.Add(this.btn_RefID);
            this.grpx_Head.Controls.Add(this.lbl_RefID);
            this.grpx_Head.Controls.Add(this.com_RefType);
            this.grpx_Head.Controls.Add(this.lbl_RefType);
            this.grpx_Head.Controls.Add(this.txt_ID);
            this.grpx_Head.Controls.Add(this.label2);
            this.grpx_Head.Controls.Add(this.txt_Notes);
            this.grpx_Head.Controls.Add(this.label1);
            this.grpx_Head.Controls.Add(this.txt_Date);
            this.grpx_Head.Controls.Add(this.dtp_Date);
            this.grpx_Head.Controls.Add(this.label6);
            this.grpx_Head.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpx_Head.Location = new System.Drawing.Point(0, 106);
            this.grpx_Head.Name = "grpx_Head";
            this.grpx_Head.Size = new System.Drawing.Size(1107, 70);
            this.grpx_Head.TabIndex = 10;
            this.grpx_Head.TabStop = false;
            // 
            // com_JorType
            // 
            this.com_JorType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.com_JorType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.com_JorType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.com_JorType.BackColor = System.Drawing.SystemColors.Window;
            this.com_JorType.DisplayMember = "Name";
            this.com_JorType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.com_JorType.Enabled = false;
            this.com_JorType.FormattingEnabled = true;
            this.com_JorType.Location = new System.Drawing.Point(475, 15);
            this.com_JorType.Name = "com_JorType";
            this.com_JorType.Size = new System.Drawing.Size(116, 21);
            this.com_JorType.TabIndex = 142;
            this.com_JorType.ValueMember = "ID";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(595, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 141;
            this.label5.Text = "نوع القيد";
            // 
            // btn_RefID
            // 
            this.btn_RefID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_RefID.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_RefID.FlatAppearance.BorderSize = 0;
            this.btn_RefID.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_RefID.ImageKey = "New";
            this.btn_RefID.Location = new System.Drawing.Point(213, 39);
            this.btn_RefID.Name = "btn_RefID";
            this.btn_RefID.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_RefID.Size = new System.Drawing.Size(116, 25);
            this.btn_RefID.TabIndex = 136;
            this.btn_RefID.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_RefID.UseVisualStyleBackColor = true;
            this.btn_RefID.Click += new System.EventHandler(this.btn_RefID_Click);
            // 
            // lbl_RefID
            // 
            this.lbl_RefID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_RefID.AutoSize = true;
            this.lbl_RefID.Location = new System.Drawing.Point(335, 44);
            this.lbl_RefID.Name = "lbl_RefID";
            this.lbl_RefID.Size = new System.Drawing.Size(58, 13);
            this.lbl_RefID.TabIndex = 135;
            this.lbl_RefID.Text = "رقم المرجع";
            // 
            // com_RefType
            // 
            this.com_RefType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.com_RefType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.com_RefType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.com_RefType.BackColor = System.Drawing.SystemColors.Window;
            this.com_RefType.DisplayMember = "Name";
            this.com_RefType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.com_RefType.Enabled = false;
            this.com_RefType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.com_RefType.FormattingEnabled = true;
            this.com_RefType.Location = new System.Drawing.Point(213, 15);
            this.com_RefType.Name = "com_RefType";
            this.com_RefType.Size = new System.Drawing.Size(116, 21);
            this.com_RefType.TabIndex = 134;
            this.com_RefType.ValueMember = "ID";
            // 
            // lbl_RefType
            // 
            this.lbl_RefType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_RefType.AutoSize = true;
            this.lbl_RefType.Location = new System.Drawing.Point(333, 17);
            this.lbl_RefType.Name = "lbl_RefType";
            this.lbl_RefType.Size = new System.Drawing.Size(56, 13);
            this.lbl_RefType.TabIndex = 133;
            this.lbl_RefType.Text = "نوع المرجع";
            // 
            // txt_ID
            // 
            this.txt_ID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_ID.Location = new System.Drawing.Point(927, 15);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.ReadOnly = true;
            this.txt_ID.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_ID.Size = new System.Drawing.Size(98, 20);
            this.txt_ID.TabIndex = 131;
            this.txt_ID.TabStop = false;
            this.txt_ID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1031, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 132;
            this.label2.Text = "رقم القيد";
            // 
            // txt_Notes
            // 
            this.txt_Notes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Notes.Location = new System.Drawing.Point(735, 39);
            this.txt_Notes.Name = "txt_Notes";
            this.txt_Notes.ReadOnly = true;
            this.txt_Notes.Size = new System.Drawing.Size(292, 20);
            this.txt_Notes.TabIndex = 129;
            this.txt_Notes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1033, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 130;
            this.label1.Text = "بيان";
            // 
            // btn_Save
            // 
            this.btn_Save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Save.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Save.FlatAppearance.BorderSize = 0;
            this.btn_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Save.Image = global::WindowsFormsApplication1.Properties.Resources.save_48;
            this.btn_Save.Location = new System.Drawing.Point(597, 18);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(75, 75);
            this.btn_Save.TabIndex = 13;
            this.btn_Save.Text = "حفظ";
            this.btn_Save.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Save.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Visible = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            this.btn_Save.MouseEnter += new System.EventHandler(this.btn_Save_MouseEnter);
            this.btn_Save.MouseLeave += new System.EventHandler(this.btn_Save_MouseLeave);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Cancel.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Cancel.FlatAppearance.BorderSize = 0;
            this.btn_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cancel.Image = global::WindowsFormsApplication1.Properties.Resources.cancel_48;
            this.btn_Cancel.Location = new System.Drawing.Point(435, 18);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 75);
            this.btn_Cancel.TabIndex = 14;
            this.btn_Cancel.Text = "تراجع";
            this.btn_Cancel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Cancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_Cancel.UseVisualStyleBackColor = false;
            this.btn_Cancel.Visible = false;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            this.btn_Cancel.MouseEnter += new System.EventHandler(this.btn_Cancel_MouseEnter);
            this.btn_Cancel.MouseLeave += new System.EventHandler(this.btn_Cancel_MouseLeave);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Delete.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Delete.FlatAppearance.BorderSize = 0;
            this.btn_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Delete.Image = global::WindowsFormsApplication1.Properties.Resources.delete_48;
            this.btn_Delete.Location = new System.Drawing.Point(516, 18);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(75, 75);
            this.btn_Delete.TabIndex = 2;
            this.btn_Delete.TabStop = false;
            this.btn_Delete.Text = "حذف";
            this.btn_Delete.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Delete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_Delete.UseVisualStyleBackColor = false;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            this.btn_Delete.MouseEnter += new System.EventHandler(this.btn_Delete_MouseEnter);
            this.btn_Delete.MouseLeave += new System.EventHandler(this.btn_Delete_MouseLeave);
            // 
            // btn_Edit
            // 
            this.btn_Edit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Edit.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Edit.FlatAppearance.BorderSize = 0;
            this.btn_Edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Edit.Image = global::WindowsFormsApplication1.Properties.Resources.edit_48;
            this.btn_Edit.Location = new System.Drawing.Point(678, 16);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(75, 75);
            this.btn_Edit.TabIndex = 1;
            this.btn_Edit.TabStop = false;
            this.btn_Edit.Text = "تعديل";
            this.btn_Edit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Edit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_Edit.UseVisualStyleBackColor = false;
            this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
            this.btn_Edit.MouseEnter += new System.EventHandler(this.btn_Edit_MouseEnter);
            this.btn_Edit.MouseLeave += new System.EventHandler(this.btn_Edit_MouseLeave);
            // 
            // btn_New
            // 
            this.btn_New.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_New.BackColor = System.Drawing.SystemColors.Control;
            this.btn_New.FlatAppearance.BorderSize = 0;
            this.btn_New.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_New.Image = global::WindowsFormsApplication1.Properties.Resources.new_48;
            this.btn_New.Location = new System.Drawing.Point(759, 18);
            this.btn_New.Name = "btn_New";
            this.btn_New.Size = new System.Drawing.Size(75, 75);
            this.btn_New.TabIndex = 0;
            this.btn_New.TabStop = false;
            this.btn_New.Text = "جديد";
            this.btn_New.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_New.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_New.UseVisualStyleBackColor = false;
            this.btn_New.Click += new System.EventHandler(this.btn_New_Click);
            this.btn_New.MouseEnter += new System.EventHandler(this.btn_New_MouseEnter);
            this.btn_New.MouseLeave += new System.EventHandler(this.btn_New_MouseLeave);
            // 
            // grbx_Controls
            // 
            this.grbx_Controls.Controls.Add(this.btn_Save);
            this.grbx_Controls.Controls.Add(this.btn_Cancel);
            this.grbx_Controls.Controls.Add(this.btn_Delete);
            this.grbx_Controls.Controls.Add(this.btn_Edit);
            this.grbx_Controls.Controls.Add(this.btn_New);
            this.grbx_Controls.Dock = System.Windows.Forms.DockStyle.Top;
            this.grbx_Controls.Location = new System.Drawing.Point(0, 0);
            this.grbx_Controls.Name = "grbx_Controls";
            this.grbx_Controls.Size = new System.Drawing.Size(1107, 106);
            this.grbx_Controls.TabIndex = 9;
            this.grbx_Controls.TabStop = false;
            // 
            // grbx_Add
            // 
            this.grbx_Add.Controls.Add(this.btn_Add);
            this.grbx_Add.Dock = System.Windows.Forms.DockStyle.Top;
            this.grbx_Add.Location = new System.Drawing.Point(0, 176);
            this.grbx_Add.Name = "grbx_Add";
            this.grbx_Add.Size = new System.Drawing.Size(1107, 63);
            this.grbx_Add.TabIndex = 13;
            this.grbx_Add.TabStop = false;
            this.grbx_Add.Visible = false;
            // 
            // btn_Add
            // 
            this.btn_Add.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Add.Location = new System.Drawing.Point(3, 16);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(1101, 44);
            this.btn_Add.TabIndex = 13;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AllowUserToResizeColumns = false;
            this.dgv.AllowUserToResizeRows = false;
            this.dgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv.ColumnHeadersHeight = 25;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv.EnableHeadersVisualStyles = false;
            this.dgv.Location = new System.Drawing.Point(0, 239);
            this.dgv.MultiSelect = false;
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(1107, 361);
            this.dgv.TabIndex = 14;
            this.dgv.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellDoubleClick);
            this.dgv.UserDeletedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.dgv_UserDeletedRow);
            // 
            // groupBox_Footer_Controls
            // 
            this.groupBox_Footer_Controls.Controls.Add(this.lbl_info);
            this.groupBox_Footer_Controls.Controls.Add(this.txt_Search);
            this.groupBox_Footer_Controls.Controls.Add(this.button_Next);
            this.groupBox_Footer_Controls.Controls.Add(this.button_Prev);
            this.groupBox_Footer_Controls.Controls.Add(this.button_Last);
            this.groupBox_Footer_Controls.Controls.Add(this.button_First);
            this.groupBox_Footer_Controls.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox_Footer_Controls.Location = new System.Drawing.Point(0, 671);
            this.groupBox_Footer_Controls.Name = "groupBox_Footer_Controls";
            this.groupBox_Footer_Controls.Size = new System.Drawing.Size(1107, 67);
            this.groupBox_Footer_Controls.TabIndex = 35;
            this.groupBox_Footer_Controls.TabStop = false;
            // 
            // lbl_info
            // 
            this.lbl_info.AutoSize = true;
            this.lbl_info.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbl_info.Location = new System.Drawing.Point(1104, 16);
            this.lbl_info.Name = "lbl_info";
            this.lbl_info.Size = new System.Drawing.Size(0, 13);
            this.lbl_info.TabIndex = 41;
            // 
            // txt_Search
            // 
            this.txt_Search.BackColor = System.Drawing.SystemColors.Control;
            this.txt_Search.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Search.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txt_Search.Location = new System.Drawing.Point(101, 30);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Size = new System.Drawing.Size(90, 13);
            this.txt_Search.TabIndex = 38;
            this.txt_Search.Text = "Search";
            this.txt_Search.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_Search.Enter += new System.EventHandler(this.textBox_Search_Enter);
            this.txt_Search.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Search_KeyPress);
            this.txt_Search.Leave += new System.EventHandler(this.textBox_Search_Leave);
            this.txt_Search.MouseEnter += new System.EventHandler(this.textBox_Search_MouseEnter);
            this.txt_Search.MouseLeave += new System.EventHandler(this.textBox_Search_MouseLeave);
            // 
            // button_Next
            // 
            this.button_Next.FlatAppearance.BorderSize = 0;
            this.button_Next.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Next.Location = new System.Drawing.Point(55, 21);
            this.button_Next.Name = "button_Next";
            this.button_Next.Size = new System.Drawing.Size(40, 30);
            this.button_Next.TabIndex = 37;
            this.button_Next.Text = ">";
            this.button_Next.UseVisualStyleBackColor = true;
            this.button_Next.Click += new System.EventHandler(this.button_Next_Click);
            this.button_Next.MouseEnter += new System.EventHandler(this.button_Next_MouseEnter);
            this.button_Next.MouseLeave += new System.EventHandler(this.button_Next_MouseLeave);
            // 
            // button_Prev
            // 
            this.button_Prev.FlatAppearance.BorderSize = 0;
            this.button_Prev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Prev.Location = new System.Drawing.Point(199, 21);
            this.button_Prev.Name = "button_Prev";
            this.button_Prev.Size = new System.Drawing.Size(40, 30);
            this.button_Prev.TabIndex = 36;
            this.button_Prev.Text = "<";
            this.button_Prev.UseVisualStyleBackColor = true;
            this.button_Prev.Click += new System.EventHandler(this.button_Prev_Click);
            this.button_Prev.MouseEnter += new System.EventHandler(this.button_Prev_MouseEnter);
            this.button_Prev.MouseLeave += new System.EventHandler(this.button_Prev_MouseLeave);
            // 
            // button_Last
            // 
            this.button_Last.FlatAppearance.BorderSize = 0;
            this.button_Last.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Last.Location = new System.Drawing.Point(9, 21);
            this.button_Last.Name = "button_Last";
            this.button_Last.Size = new System.Drawing.Size(40, 30);
            this.button_Last.TabIndex = 35;
            this.button_Last.Text = ">>|";
            this.button_Last.UseVisualStyleBackColor = true;
            this.button_Last.Click += new System.EventHandler(this.button_Last_Click);
            this.button_Last.MouseEnter += new System.EventHandler(this.button_Last_MouseEnter);
            this.button_Last.MouseLeave += new System.EventHandler(this.button_Last_MouseLeave);
            // 
            // button_First
            // 
            this.button_First.FlatAppearance.BorderSize = 0;
            this.button_First.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_First.Location = new System.Drawing.Point(245, 21);
            this.button_First.Name = "button_First";
            this.button_First.Size = new System.Drawing.Size(40, 30);
            this.button_First.TabIndex = 34;
            this.button_First.Text = "|<<";
            this.button_First.UseVisualStyleBackColor = true;
            this.button_First.Click += new System.EventHandler(this.button_First_Click);
            this.button_First.MouseEnter += new System.EventHandler(this.button_First_MouseEnter);
            this.button_First.MouseLeave += new System.EventHandler(this.button_First_MouseLeave);
            // 
            // frm_Jor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1107, 738);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.grbx_Add);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.grpx_Head);
            this.Controls.Add(this.grbx_Controls);
            this.Controls.Add(this.groupBox_Footer_Controls);
            this.Name = "frm_Jor";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "Empty";
            this.Text = "قيود اليومية";
            this.Shown += new System.EventHandler(this.frm_OpenStock_Shown);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.grpx_Head.ResumeLayout(false);
            this.grpx_Head.PerformLayout();
            this.grbx_Controls.ResumeLayout(false);
            this.grbx_Add.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.groupBox_Footer_Controls.ResumeLayout(false);
            this.groupBox_Footer_Controls.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.TextBox txt_Date;
        private System.Windows.Forms.DateTimePicker dtp_Date;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox grpx_Head;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Edit;
        private System.Windows.Forms.Button btn_New;
        private System.Windows.Forms.GroupBox grbx_Controls;
        private System.Windows.Forms.GroupBox grbx_Add;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.GroupBox groupBox_Footer_Controls;
        public System.Windows.Forms.Label lbl_info;
        public System.Windows.Forms.TextBox txt_Search;
        private System.Windows.Forms.Button button_Next;
        private System.Windows.Forms.Button button_Prev;
        private System.Windows.Forms.Button button_Last;
        private System.Windows.Forms.Button button_First;
        public System.Windows.Forms.TextBox txt_Notes;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txt_ID;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txt_TotalCredit;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txt_TotalDebit;
        private System.Windows.Forms.ComboBox com_JorType;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Button btn_RefID;
        public System.Windows.Forms.Label lbl_RefID;
        private System.Windows.Forms.ComboBox com_RefType;
        public System.Windows.Forms.Label lbl_RefType;
    }
}