namespace WindowsFormsApplication1.PL.Cash
{
    partial class frm_PayOut
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
            this.grbx_Controls = new System.Windows.Forms.GroupBox();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Edit = new System.Windows.Forms.Button();
            this.btn_New = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_ChekNo = new System.Windows.Forms.TextBox();
            this.lbl_ChekNo = new System.Windows.Forms.Label();
            this.txt_CheckDate = new System.Windows.Forms.TextBox();
            this.dtp_ChekDate = new System.Windows.Forms.DateTimePicker();
            this.lbl_CheckDate = new System.Windows.Forms.Label();
            this.btn_JorID = new System.Windows.Forms.Button();
            this.lbl_RefID = new System.Windows.Forms.Label();
            this.com_PayType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_ACC_Del = new System.Windows.Forms.Button();
            this.btn_ACC_Edit = new System.Windows.Forms.Button();
            this.btn_ACC_Search = new System.Windows.Forms.Button();
            this.com_ACC = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Value = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_No = new System.Windows.Forms.TextBox();
            this.txt_Notes = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.com_User = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_Date = new System.Windows.Forms.TextBox();
            this.dtp_BirthDate = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.grbx_Controls.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
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
            this.grbx_Controls.Size = new System.Drawing.Size(808, 106);
            this.grbx_Controls.TabIndex = 5;
            this.grbx_Controls.TabStop = false;
            // 
            // btn_Save
            // 
            this.btn_Save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Save.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Save.FlatAppearance.BorderSize = 0;
            this.btn_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Save.Image = global::WindowsFormsApplication1.Properties.Resources.save_48;
            this.btn_Save.Location = new System.Drawing.Point(347, 19);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(75, 75);
            this.btn_Save.TabIndex = 13;
            this.btn_Save.Text = "حفظ";
            this.btn_Save.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Save.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Visible = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Cancel.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Cancel.FlatAppearance.BorderSize = 0;
            this.btn_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cancel.Image = global::WindowsFormsApplication1.Properties.Resources.cancel_48;
            this.btn_Cancel.Location = new System.Drawing.Point(185, 19);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 75);
            this.btn_Cancel.TabIndex = 14;
            this.btn_Cancel.Text = "تراجع";
            this.btn_Cancel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Cancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_Cancel.UseVisualStyleBackColor = false;
            this.btn_Cancel.Visible = false;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Delete.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Delete.FlatAppearance.BorderSize = 0;
            this.btn_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Delete.Image = global::WindowsFormsApplication1.Properties.Resources.delete_48;
            this.btn_Delete.Location = new System.Drawing.Point(266, 19);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(75, 75);
            this.btn_Delete.TabIndex = 2;
            this.btn_Delete.TabStop = false;
            this.btn_Delete.Text = "حذف";
            this.btn_Delete.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Delete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_Delete.UseVisualStyleBackColor = false;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Edit
            // 
            this.btn_Edit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Edit.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Edit.FlatAppearance.BorderSize = 0;
            this.btn_Edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Edit.Image = global::WindowsFormsApplication1.Properties.Resources.edit_48;
            this.btn_Edit.Location = new System.Drawing.Point(428, 19);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(75, 75);
            this.btn_Edit.TabIndex = 1;
            this.btn_Edit.TabStop = false;
            this.btn_Edit.Text = "تعديل";
            this.btn_Edit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Edit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_Edit.UseVisualStyleBackColor = false;
            this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
            // 
            // btn_New
            // 
            this.btn_New.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_New.BackColor = System.Drawing.SystemColors.Control;
            this.btn_New.FlatAppearance.BorderSize = 0;
            this.btn_New.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_New.Image = global::WindowsFormsApplication1.Properties.Resources.new_48;
            this.btn_New.Location = new System.Drawing.Point(509, 19);
            this.btn_New.Name = "btn_New";
            this.btn_New.Size = new System.Drawing.Size(75, 75);
            this.btn_New.TabIndex = 0;
            this.btn_New.TabStop = false;
            this.btn_New.Text = "جديد";
            this.btn_New.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_New.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_New.UseVisualStyleBackColor = false;
            this.btn_New.Click += new System.EventHandler(this.btn_New_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_ChekNo);
            this.groupBox1.Controls.Add(this.lbl_ChekNo);
            this.groupBox1.Controls.Add(this.txt_CheckDate);
            this.groupBox1.Controls.Add(this.dtp_ChekDate);
            this.groupBox1.Controls.Add(this.lbl_CheckDate);
            this.groupBox1.Controls.Add(this.btn_JorID);
            this.groupBox1.Controls.Add(this.lbl_RefID);
            this.groupBox1.Controls.Add(this.com_PayType);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btn_ACC_Del);
            this.groupBox1.Controls.Add(this.btn_ACC_Edit);
            this.groupBox1.Controls.Add(this.btn_ACC_Search);
            this.groupBox1.Controls.Add(this.com_ACC);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_Value);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txt_No);
            this.groupBox1.Controls.Add(this.txt_Notes);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_ID);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.com_User);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txt_Date);
            this.groupBox1.Controls.Add(this.dtp_BirthDate);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 106);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(808, 230);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // txt_ChekNo
            // 
            this.txt_ChekNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_ChekNo.Location = new System.Drawing.Point(425, 186);
            this.txt_ChekNo.Name = "txt_ChekNo";
            this.txt_ChekNo.ReadOnly = true;
            this.txt_ChekNo.Size = new System.Drawing.Size(97, 20);
            this.txt_ChekNo.TabIndex = 160;
            this.txt_ChekNo.TabStop = false;
            // 
            // lbl_ChekNo
            // 
            this.lbl_ChekNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_ChekNo.AutoSize = true;
            this.lbl_ChekNo.Location = new System.Drawing.Point(525, 188);
            this.lbl_ChekNo.Name = "lbl_ChekNo";
            this.lbl_ChekNo.Size = new System.Drawing.Size(58, 13);
            this.lbl_ChekNo.TabIndex = 159;
            this.lbl_ChekNo.Text = "رقم الشيك";
            // 
            // txt_CheckDate
            // 
            this.txt_CheckDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_CheckDate.Location = new System.Drawing.Point(224, 186);
            this.txt_CheckDate.Name = "txt_CheckDate";
            this.txt_CheckDate.ReadOnly = true;
            this.txt_CheckDate.Size = new System.Drawing.Size(109, 20);
            this.txt_CheckDate.TabIndex = 156;
            this.txt_CheckDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dtp_ChekDate
            // 
            this.dtp_ChekDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtp_ChekDate.CustomFormat = " ";
            this.dtp_ChekDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_ChekDate.Location = new System.Drawing.Point(204, 186);
            this.dtp_ChekDate.Name = "dtp_ChekDate";
            this.dtp_ChekDate.RightToLeftLayout = true;
            this.dtp_ChekDate.Size = new System.Drawing.Size(42, 20);
            this.dtp_ChekDate.TabIndex = 158;
            this.dtp_ChekDate.TabStop = false;
            this.dtp_ChekDate.ValueChanged += new System.EventHandler(this.dtp_ChekDate_ValueChanged);
            // 
            // lbl_CheckDate
            // 
            this.lbl_CheckDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_CheckDate.AutoSize = true;
            this.lbl_CheckDate.Location = new System.Drawing.Point(338, 188);
            this.lbl_CheckDate.Name = "lbl_CheckDate";
            this.lbl_CheckDate.Size = new System.Drawing.Size(62, 13);
            this.lbl_CheckDate.TabIndex = 157;
            this.lbl_CheckDate.Text = "تاريخ الشيك";
            // 
            // btn_JorID
            // 
            this.btn_JorID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_JorID.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_JorID.FlatAppearance.BorderSize = 0;
            this.btn_JorID.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_JorID.ImageKey = "New";
            this.btn_JorID.Location = new System.Drawing.Point(636, 47);
            this.btn_JorID.Name = "btn_JorID";
            this.btn_JorID.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_JorID.Size = new System.Drawing.Size(98, 25);
            this.btn_JorID.TabIndex = 155;
            this.btn_JorID.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_JorID.UseVisualStyleBackColor = true;
            this.btn_JorID.Click += new System.EventHandler(this.btn_JorID_Click);
            // 
            // lbl_RefID
            // 
            this.lbl_RefID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_RefID.AutoSize = true;
            this.lbl_RefID.Location = new System.Drawing.Point(740, 54);
            this.lbl_RefID.Name = "lbl_RefID";
            this.lbl_RefID.Size = new System.Drawing.Size(49, 13);
            this.lbl_RefID.TabIndex = 154;
            this.lbl_RefID.Text = "رقم القيد";
            // 
            // com_PayType
            // 
            this.com_PayType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.com_PayType.DisplayMember = "Name";
            this.com_PayType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.com_PayType.Enabled = false;
            this.com_PayType.FormattingEnabled = true;
            this.com_PayType.Location = new System.Drawing.Point(607, 186);
            this.com_PayType.Name = "com_PayType";
            this.com_PayType.Size = new System.Drawing.Size(127, 21);
            this.com_PayType.TabIndex = 152;
            this.com_PayType.ValueMember = "ID";
            this.com_PayType.SelectedIndexChanged += new System.EventHandler(this.com_PayType_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(740, 189);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 153;
            this.label1.Text = "طريقة الدفع";
            // 
            // btn_ACC_Del
            // 
            this.btn_ACC_Del.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_ACC_Del.Font = new System.Drawing.Font("Arial Unicode MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ACC_Del.ForeColor = System.Drawing.Color.DimGray;
            this.btn_ACC_Del.Location = new System.Drawing.Point(425, 133);
            this.btn_ACC_Del.Name = "btn_ACC_Del";
            this.btn_ACC_Del.Size = new System.Drawing.Size(27, 23);
            this.btn_ACC_Del.TabIndex = 151;
            this.btn_ACC_Del.Text = "X";
            this.btn_ACC_Del.UseVisualStyleBackColor = true;
            this.btn_ACC_Del.Click += new System.EventHandler(this.btn_Cust_Del_Click);
            // 
            // btn_ACC_Edit
            // 
            this.btn_ACC_Edit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_ACC_Edit.Image = global::WindowsFormsApplication1.Properties.Resources.Edit_16;
            this.btn_ACC_Edit.Location = new System.Drawing.Point(453, 133);
            this.btn_ACC_Edit.Name = "btn_ACC_Edit";
            this.btn_ACC_Edit.Size = new System.Drawing.Size(27, 23);
            this.btn_ACC_Edit.TabIndex = 150;
            this.btn_ACC_Edit.UseVisualStyleBackColor = true;
            this.btn_ACC_Edit.Click += new System.EventHandler(this.btn_Cust_Edit_Click);
            // 
            // btn_ACC_Search
            // 
            this.btn_ACC_Search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_ACC_Search.Image = global::WindowsFormsApplication1.Properties.Resources.Search_16;
            this.btn_ACC_Search.Location = new System.Drawing.Point(480, 133);
            this.btn_ACC_Search.Name = "btn_ACC_Search";
            this.btn_ACC_Search.Size = new System.Drawing.Size(27, 23);
            this.btn_ACC_Search.TabIndex = 149;
            this.btn_ACC_Search.UseVisualStyleBackColor = true;
            this.btn_ACC_Search.Click += new System.EventHandler(this.btn_Cust_Search_Click);
            // 
            // com_ACC
            // 
            this.com_ACC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.com_ACC.DisplayMember = "Name";
            this.com_ACC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.com_ACC.Enabled = false;
            this.com_ACC.FormattingEnabled = true;
            this.com_ACC.Location = new System.Drawing.Point(509, 133);
            this.com_ACC.Name = "com_ACC";
            this.com_ACC.Size = new System.Drawing.Size(227, 21);
            this.com_ACC.TabIndex = 147;
            this.com_ACC.ValueMember = "ID";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(741, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 148;
            this.label3.Text = "الحساب";
            // 
            // txt_Value
            // 
            this.txt_Value.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Value.Location = new System.Drawing.Point(607, 160);
            this.txt_Value.Name = "txt_Value";
            this.txt_Value.ReadOnly = true;
            this.txt_Value.Size = new System.Drawing.Size(127, 20);
            this.txt_Value.TabIndex = 142;
            this.txt_Value.TabStop = false;
            this.txt_Value.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Value_KeyPress);
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(740, 163);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 13);
            this.label9.TabIndex = 141;
            this.label9.Text = "المبلغ";
            // 
            // txt_No
            // 
            this.txt_No.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_No.Location = new System.Drawing.Point(229, 21);
            this.txt_No.Name = "txt_No";
            this.txt_No.ReadOnly = true;
            this.txt_No.Size = new System.Drawing.Size(97, 20);
            this.txt_No.TabIndex = 140;
            this.txt_No.TabStop = false;
            // 
            // txt_Notes
            // 
            this.txt_Notes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Notes.Location = new System.Drawing.Point(204, 107);
            this.txt_Notes.Name = "txt_Notes";
            this.txt_Notes.ReadOnly = true;
            this.txt_Notes.Size = new System.Drawing.Size(531, 20);
            this.txt_Notes.TabIndex = 138;
            this.txt_Notes.TabStop = false;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(741, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 139;
            this.label5.Text = "البيان";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(333, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 137;
            this.label4.Text = "سند يدوي";
            // 
            // txt_ID
            // 
            this.txt_ID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_ID.Location = new System.Drawing.Point(636, 21);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.ReadOnly = true;
            this.txt_ID.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_ID.Size = new System.Drawing.Size(98, 20);
            this.txt_ID.TabIndex = 132;
            this.txt_ID.TabStop = false;
            this.txt_ID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(740, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 133;
            this.label2.Text = "رقم السند";
            // 
            // com_User
            // 
            this.com_User.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.com_User.DisplayMember = "Name";
            this.com_User.Enabled = false;
            this.com_User.FormattingEnabled = true;
            this.com_User.Location = new System.Drawing.Point(12, 21);
            this.com_User.Name = "com_User";
            this.com_User.Size = new System.Drawing.Size(117, 21);
            this.com_User.TabIndex = 125;
            this.com_User.ValueMember = "ID";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(135, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 13);
            this.label8.TabIndex = 126;
            this.label8.Text = "المستخدم";
            // 
            // txt_Date
            // 
            this.txt_Date.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Date.Location = new System.Drawing.Point(464, 21);
            this.txt_Date.Name = "txt_Date";
            this.txt_Date.ReadOnly = true;
            this.txt_Date.Size = new System.Drawing.Size(109, 20);
            this.txt_Date.TabIndex = 122;
            this.txt_Date.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dtp_BirthDate
            // 
            this.dtp_BirthDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtp_BirthDate.CustomFormat = " ";
            this.dtp_BirthDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_BirthDate.Location = new System.Drawing.Point(446, 21);
            this.dtp_BirthDate.Name = "dtp_BirthDate";
            this.dtp_BirthDate.RightToLeftLayout = true;
            this.dtp_BirthDate.Size = new System.Drawing.Size(42, 20);
            this.dtp_BirthDate.TabIndex = 124;
            this.dtp_BirthDate.TabStop = false;
            this.dtp_BirthDate.ValueChanged += new System.EventHandler(this.dtp_BirthDate_ValueChanged);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(579, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 123;
            this.label6.Text = "التاريخ";
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AllowUserToResizeRows = false;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv.Location = new System.Drawing.Point(0, 336);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(808, 212);
            this.dgv.TabIndex = 7;
            this.dgv.SelectionChanged += new System.EventHandler(this.dgv_SelectionChanged);
            // 
            // frm_PayOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 548);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grbx_Controls);
            this.Name = "frm_PayOut";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "سند صرف";
            this.Shown += new System.EventHandler(this.frm_PayOut_Shown);
            this.grbx_Controls.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbx_Controls;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Edit;
        private System.Windows.Forms.Button btn_New;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox com_User;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox txt_Date;
        private System.Windows.Forms.DateTimePicker dtp_BirthDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txt_ID;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txt_Notes;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txt_Value;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.TextBox txt_No;
        private System.Windows.Forms.Button btn_ACC_Del;
        private System.Windows.Forms.Button btn_ACC_Edit;
        private System.Windows.Forms.Button btn_ACC_Search;
        private System.Windows.Forms.ComboBox com_ACC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox com_PayType;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button btn_JorID;
        public System.Windows.Forms.Label lbl_RefID;
        public System.Windows.Forms.TextBox txt_ChekNo;
        private System.Windows.Forms.Label lbl_ChekNo;
        public System.Windows.Forms.TextBox txt_CheckDate;
        private System.Windows.Forms.DateTimePicker dtp_ChekDate;
        private System.Windows.Forms.Label lbl_CheckDate;
    }
}