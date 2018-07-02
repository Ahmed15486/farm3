namespace WindowsFormsApplication1.PL.Sal
{
    partial class frm_Cust
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
            this.btn_Print = new System.Windows.Forms.Button();
            this.btn_Logo = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Edit = new System.Windows.Forms.Button();
            this.btn_New = new System.Windows.Forms.Button();
            this.grbx_Details = new System.Windows.Forms.GroupBox();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_Phone2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_Phone1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Mobile2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Balance = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_Mobile1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_RespoName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.IID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_ParentACC_Del = new System.Windows.Forms.Button();
            this.com_ParentACC = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.grbx_Controls.SuspendLayout();
            this.grbx_Details.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // grbx_Controls
            // 
            this.grbx_Controls.Controls.Add(this.btn_Print);
            this.grbx_Controls.Controls.Add(this.btn_Logo);
            this.grbx_Controls.Controls.Add(this.btn_Save);
            this.grbx_Controls.Controls.Add(this.btn_Cancel);
            this.grbx_Controls.Controls.Add(this.btn_Delete);
            this.grbx_Controls.Controls.Add(this.btn_Edit);
            this.grbx_Controls.Controls.Add(this.btn_New);
            this.grbx_Controls.Dock = System.Windows.Forms.DockStyle.Top;
            this.grbx_Controls.Location = new System.Drawing.Point(0, 0);
            this.grbx_Controls.Name = "grbx_Controls";
            this.grbx_Controls.Size = new System.Drawing.Size(784, 106);
            this.grbx_Controls.TabIndex = 4;
            this.grbx_Controls.TabStop = false;
            // 
            // btn_Print
            // 
            this.btn_Print.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_Print.FlatAppearance.BorderSize = 0;
            this.btn_Print.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Print.Location = new System.Drawing.Point(3, 19);
            this.btn_Print.Name = "btn_Print";
            this.btn_Print.Size = new System.Drawing.Size(97, 84);
            this.btn_Print.TabIndex = 37;
            this.btn_Print.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_Print.UseVisualStyleBackColor = true;
            // 
            // btn_Logo
            // 
            this.btn_Logo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Logo.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Logo.FlatAppearance.BorderSize = 0;
            this.btn_Logo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Logo.Location = new System.Drawing.Point(697, 23);
            this.btn_Logo.Name = "btn_Logo";
            this.btn_Logo.Size = new System.Drawing.Size(75, 75);
            this.btn_Logo.TabIndex = 5;
            this.btn_Logo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Logo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_Logo.UseVisualStyleBackColor = false;
            // 
            // btn_Save
            // 
            this.btn_Save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Save.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Save.FlatAppearance.BorderSize = 0;
            this.btn_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Save.Image = global::WindowsFormsApplication1.Properties.Resources.save_48;
            this.btn_Save.Location = new System.Drawing.Point(353, 18);
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
            this.btn_Cancel.Location = new System.Drawing.Point(191, 18);
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
            this.btn_Delete.Location = new System.Drawing.Point(272, 18);
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
            this.btn_Edit.Location = new System.Drawing.Point(434, 18);
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
            this.btn_New.Location = new System.Drawing.Point(515, 18);
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
            // grbx_Details
            // 
            this.grbx_Details.Controls.Add(this.btn_ParentACC_Del);
            this.grbx_Details.Controls.Add(this.com_ParentACC);
            this.grbx_Details.Controls.Add(this.label10);
            this.grbx_Details.Controls.Add(this.txt_Email);
            this.grbx_Details.Controls.Add(this.label7);
            this.grbx_Details.Controls.Add(this.txt_Phone2);
            this.grbx_Details.Controls.Add(this.label6);
            this.grbx_Details.Controls.Add(this.txt_Phone1);
            this.grbx_Details.Controls.Add(this.label4);
            this.grbx_Details.Controls.Add(this.txt_Mobile2);
            this.grbx_Details.Controls.Add(this.label2);
            this.grbx_Details.Controls.Add(this.txt_Balance);
            this.grbx_Details.Controls.Add(this.label9);
            this.grbx_Details.Controls.Add(this.txt_Mobile1);
            this.grbx_Details.Controls.Add(this.label8);
            this.grbx_Details.Controls.Add(this.txt_RespoName);
            this.grbx_Details.Controls.Add(this.label5);
            this.grbx_Details.Controls.Add(this.txt_Name);
            this.grbx_Details.Controls.Add(this.label3);
            this.grbx_Details.Controls.Add(this.txt_ID);
            this.grbx_Details.Controls.Add(this.label1);
            this.grbx_Details.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbx_Details.Location = new System.Drawing.Point(0, 106);
            this.grbx_Details.Name = "grbx_Details";
            this.grbx_Details.Size = new System.Drawing.Size(784, 455);
            this.grbx_Details.TabIndex = 39;
            this.grbx_Details.TabStop = false;
            // 
            // txt_Email
            // 
            this.txt_Email.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Email.Location = new System.Drawing.Point(345, 170);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.ReadOnly = true;
            this.txt_Email.Size = new System.Drawing.Size(336, 23);
            this.txt_Email.TabIndex = 136;
            this.txt_Email.TabStop = false;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(687, 173);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 16);
            this.label7.TabIndex = 137;
            this.label7.Text = "الايميل";
            // 
            // txt_Phone2
            // 
            this.txt_Phone2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Phone2.Location = new System.Drawing.Point(345, 144);
            this.txt_Phone2.Name = "txt_Phone2";
            this.txt_Phone2.ReadOnly = true;
            this.txt_Phone2.Size = new System.Drawing.Size(127, 23);
            this.txt_Phone2.TabIndex = 134;
            this.txt_Phone2.TabStop = false;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(478, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 16);
            this.label6.TabIndex = 135;
            this.label6.Text = "هاتف 2";
            // 
            // txt_Phone1
            // 
            this.txt_Phone1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Phone1.Location = new System.Drawing.Point(554, 141);
            this.txt_Phone1.Name = "txt_Phone1";
            this.txt_Phone1.ReadOnly = true;
            this.txt_Phone1.Size = new System.Drawing.Size(127, 23);
            this.txt_Phone1.TabIndex = 132;
            this.txt_Phone1.TabStop = false;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(687, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 16);
            this.label4.TabIndex = 133;
            this.label4.Text = "هاتف 1";
            // 
            // txt_Mobile2
            // 
            this.txt_Mobile2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Mobile2.Location = new System.Drawing.Point(345, 115);
            this.txt_Mobile2.Name = "txt_Mobile2";
            this.txt_Mobile2.ReadOnly = true;
            this.txt_Mobile2.Size = new System.Drawing.Size(127, 23);
            this.txt_Mobile2.TabIndex = 130;
            this.txt_Mobile2.TabStop = false;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(478, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 16);
            this.label2.TabIndex = 131;
            this.label2.Text = "جوال 2";
            // 
            // txt_Balance
            // 
            this.txt_Balance.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Balance.Location = new System.Drawing.Point(564, 258);
            this.txt_Balance.Name = "txt_Balance";
            this.txt_Balance.ReadOnly = true;
            this.txt_Balance.Size = new System.Drawing.Size(117, 23);
            this.txt_Balance.TabIndex = 128;
            this.txt_Balance.TabStop = false;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(687, 260);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 16);
            this.label9.TabIndex = 129;
            this.label9.Text = "الرصيد";
            // 
            // txt_Mobile1
            // 
            this.txt_Mobile1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Mobile1.Location = new System.Drawing.Point(554, 112);
            this.txt_Mobile1.Name = "txt_Mobile1";
            this.txt_Mobile1.ReadOnly = true;
            this.txt_Mobile1.Size = new System.Drawing.Size(127, 23);
            this.txt_Mobile1.TabIndex = 126;
            this.txt_Mobile1.TabStop = false;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(687, 115);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 16);
            this.label8.TabIndex = 127;
            this.label8.Text = "جوال 1";
            // 
            // txt_RespoName
            // 
            this.txt_RespoName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_RespoName.Location = new System.Drawing.Point(345, 83);
            this.txt_RespoName.Name = "txt_RespoName";
            this.txt_RespoName.ReadOnly = true;
            this.txt_RespoName.Size = new System.Drawing.Size(336, 23);
            this.txt_RespoName.TabIndex = 122;
            this.txt_RespoName.TabStop = false;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(687, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 16);
            this.label5.TabIndex = 123;
            this.label5.Text = "اسم المسئول";
            // 
            // txt_Name
            // 
            this.txt_Name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Name.Location = new System.Drawing.Point(345, 55);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.ReadOnly = true;
            this.txt_Name.Size = new System.Drawing.Size(336, 23);
            this.txt_Name.TabIndex = 111;
            this.txt_Name.TabStop = false;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(687, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 16);
            this.label3.TabIndex = 112;
            this.label3.Text = "الاسم";
            // 
            // txt_ID
            // 
            this.txt_ID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_ID.Location = new System.Drawing.Point(540, 26);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.ReadOnly = true;
            this.txt_ID.Size = new System.Drawing.Size(141, 23);
            this.txt_ID.TabIndex = 1;
            this.txt_ID.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(687, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "الكود";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox1.Location = new System.Drawing.Point(522, 106);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(262, 455);
            this.groupBox1.TabIndex = 40;
            this.groupBox1.TabStop = false;
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AllowUserToOrderColumns = true;
            this.dgv.AllowUserToResizeRows = false;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IID,
            this.NName});
            this.dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv.Location = new System.Drawing.Point(3, 19);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(256, 433);
            this.dgv.TabIndex = 1;
            this.dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellClick);
            // 
            // IID
            // 
            this.IID.DataPropertyName = "ID";
            this.IID.HeaderText = "الكود";
            this.IID.Name = "IID";
            this.IID.ReadOnly = true;
            this.IID.Width = 75;
            // 
            // NName
            // 
            this.NName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NName.DataPropertyName = "Name";
            this.NName.HeaderText = "التعريف";
            this.NName.Name = "NName";
            this.NName.ReadOnly = true;
            // 
            // btn_ParentACC_Del
            // 
            this.btn_ParentACC_Del.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_ParentACC_Del.BackColor = System.Drawing.SystemColors.Control;
            this.btn_ParentACC_Del.FlatAppearance.BorderSize = 0;
            this.btn_ParentACC_Del.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ParentACC_Del.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btn_ParentACC_Del.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_ParentACC_Del.Location = new System.Drawing.Point(520, 198);
            this.btn_ParentACC_Del.Name = "btn_ParentACC_Del";
            this.btn_ParentACC_Del.Size = new System.Drawing.Size(30, 24);
            this.btn_ParentACC_Del.TabIndex = 173;
            this.btn_ParentACC_Del.TabStop = false;
            this.btn_ParentACC_Del.Text = "x";
            this.btn_ParentACC_Del.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_ParentACC_Del.UseVisualStyleBackColor = false;
            this.btn_ParentACC_Del.Click += new System.EventHandler(this.btn_ParentACC_Del_Click);
            // 
            // com_ParentACC
            // 
            this.com_ParentACC.DisplayMember = "Name";
            this.com_ParentACC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.com_ParentACC.FormattingEnabled = true;
            this.com_ParentACC.Location = new System.Drawing.Point(550, 199);
            this.com_ParentACC.Name = "com_ParentACC";
            this.com_ParentACC.Size = new System.Drawing.Size(131, 24);
            this.com_ParentACC.TabIndex = 172;
            this.com_ParentACC.ValueMember = "ID";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(686, 202);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 16);
            this.label10.TabIndex = 171;
            this.label10.Text = "يندرج تحت";
            // 
            // frm_Cust
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grbx_Details);
            this.Controls.Add(this.grbx_Controls);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frm_Cust";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "بطاقة عميل";
            this.Shown += new System.EventHandler(this.frm_cust_Shown);
            this.grbx_Controls.ResumeLayout(false);
            this.grbx_Details.ResumeLayout(false);
            this.grbx_Details.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbx_Controls;
        private System.Windows.Forms.Button btn_Print;
        private System.Windows.Forms.Button btn_Logo;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Edit;
        private System.Windows.Forms.Button btn_New;
        private System.Windows.Forms.GroupBox grbx_Details;
        public System.Windows.Forms.TextBox txt_ID;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txt_RespoName;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txt_Mobile1;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox txt_Balance;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.TextBox txt_Phone2;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox txt_Phone1;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txt_Mobile2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn IID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NName;
        private System.Windows.Forms.Button btn_ParentACC_Del;
        private System.Windows.Forms.ComboBox com_ParentACC;
        private System.Windows.Forms.Label label10;
    }
}