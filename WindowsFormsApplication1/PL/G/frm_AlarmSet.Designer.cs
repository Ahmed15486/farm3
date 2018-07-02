namespace WindowsFormsApplication1.PL.G
{
    partial class frm_AlarmSet
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
            this.dgv = new System.Windows.Forms.DataGridView();
            this.IID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grbx_Details = new System.Windows.Forms.GroupBox();
            this.btn_Add = new System.Windows.Forms.Button();
            this.chk_Other = new System.Windows.Forms.CheckBox();
            this.dgv_Other = new System.Windows.Forms.DataGridView();
            this.AlarmOther_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AlarmOther_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartDays = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Infinite = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chk_StartBDate = new System.Windows.Forms.CheckBox();
            this.chk_WhenInsert = new System.Windows.Forms.CheckBox();
            this.chk_WithoutItem = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_Quan = new System.Windows.Forms.TextBox();
            this.btn_Items2_Del = new System.Windows.Forms.Button();
            this.btn_Items2_Add = new System.Windows.Forms.Button();
            this.com_Items2 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_StartDayBDate = new System.Windows.Forms.TextBox();
            this.btn_Cat_Del = new System.Windows.Forms.Button();
            this.btn_Cat_Add = new System.Windows.Forms.Button();
            this.com_Cat = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Notes = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grbx_Controls.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.grbx_Details.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Other)).BeginInit();
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
            this.grbx_Controls.Size = new System.Drawing.Size(940, 106);
            this.grbx_Controls.TabIndex = 42;
            this.grbx_Controls.TabStop = false;
            // 
            // btn_Save
            // 
            this.btn_Save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Save.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Save.FlatAppearance.BorderSize = 0;
            this.btn_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Save.Image = global::WindowsFormsApplication1.Properties.Resources.save_48;
            this.btn_Save.Location = new System.Drawing.Point(509, 18);
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
            this.btn_Cancel.Location = new System.Drawing.Point(347, 18);
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
            this.btn_Delete.Location = new System.Drawing.Point(428, 18);
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
            this.btn_Edit.Location = new System.Drawing.Point(590, 18);
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
            this.btn_New.Location = new System.Drawing.Point(671, 18);
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
            this.groupBox1.Controls.Add(this.dgv);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox1.Location = new System.Drawing.Point(651, 106);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(289, 528);
            this.groupBox1.TabIndex = 44;
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
            this.dgv.Location = new System.Drawing.Point(3, 16);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersVisible = false;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(283, 509);
            this.dgv.TabIndex = 1;
            this.dgv.SelectionChanged += new System.EventHandler(this.dgv_SelectionChanged);
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
            // grbx_Details
            // 
            this.grbx_Details.Controls.Add(this.btn_Add);
            this.grbx_Details.Controls.Add(this.chk_Other);
            this.grbx_Details.Controls.Add(this.dgv_Other);
            this.grbx_Details.Controls.Add(this.chk_StartBDate);
            this.grbx_Details.Controls.Add(this.chk_WhenInsert);
            this.grbx_Details.Controls.Add(this.chk_WithoutItem);
            this.grbx_Details.Controls.Add(this.label9);
            this.grbx_Details.Controls.Add(this.txt_Quan);
            this.grbx_Details.Controls.Add(this.btn_Items2_Del);
            this.grbx_Details.Controls.Add(this.btn_Items2_Add);
            this.grbx_Details.Controls.Add(this.com_Items2);
            this.grbx_Details.Controls.Add(this.label8);
            this.grbx_Details.Controls.Add(this.label6);
            this.grbx_Details.Controls.Add(this.txt_StartDayBDate);
            this.grbx_Details.Controls.Add(this.btn_Cat_Del);
            this.grbx_Details.Controls.Add(this.btn_Cat_Add);
            this.grbx_Details.Controls.Add(this.com_Cat);
            this.grbx_Details.Controls.Add(this.label4);
            this.grbx_Details.Controls.Add(this.txt_Notes);
            this.grbx_Details.Controls.Add(this.label5);
            this.grbx_Details.Controls.Add(this.txt_Name);
            this.grbx_Details.Controls.Add(this.label3);
            this.grbx_Details.Controls.Add(this.txt_ID);
            this.grbx_Details.Controls.Add(this.label1);
            this.grbx_Details.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbx_Details.Location = new System.Drawing.Point(0, 106);
            this.grbx_Details.Name = "grbx_Details";
            this.grbx_Details.Size = new System.Drawing.Size(651, 528);
            this.grbx_Details.TabIndex = 45;
            this.grbx_Details.TabStop = false;
            // 
            // btn_Add
            // 
            this.btn_Add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Add.Location = new System.Drawing.Point(396, 358);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(60, 23);
            this.btn_Add.TabIndex = 200;
            this.btn_Add.Text = "اضافة";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // chk_Other
            // 
            this.chk_Other.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chk_Other.AutoSize = true;
            this.chk_Other.Location = new System.Drawing.Point(462, 361);
            this.chk_Other.Name = "chk_Other";
            this.chk_Other.Size = new System.Drawing.Size(106, 17);
            this.chk_Other.TabIndex = 199;
            this.chk_Other.Text = "بعد تنبيهات معينة";
            this.chk_Other.UseVisualStyleBackColor = true;
            this.chk_Other.CheckedChanged += new System.EventHandler(this.chk_Other_CheckedChanged);
            // 
            // dgv_Other
            // 
            this.dgv_Other.AllowUserToAddRows = false;
            this.dgv_Other.AllowUserToResizeRows = false;
            this.dgv_Other.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Other.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AlarmOther_ID,
            this.AlarmOther_Name,
            this.StartDays,
            this.Infinite,
            this.Count});
            this.dgv_Other.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv_Other.Location = new System.Drawing.Point(3, 400);
            this.dgv_Other.Name = "dgv_Other";
            this.dgv_Other.ReadOnly = true;
            this.dgv_Other.RowHeadersVisible = false;
            this.dgv_Other.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Other.Size = new System.Drawing.Size(645, 125);
            this.dgv_Other.TabIndex = 197;
            this.dgv_Other.Visible = false;
            // 
            // AlarmOther_ID
            // 
            this.AlarmOther_ID.DataPropertyName = "ID";
            this.AlarmOther_ID.HeaderText = "كود التنبيه";
            this.AlarmOther_ID.Name = "AlarmOther_ID";
            this.AlarmOther_ID.ReadOnly = true;
            // 
            // AlarmOther_Name
            // 
            this.AlarmOther_Name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.AlarmOther_Name.DataPropertyName = "Name";
            this.AlarmOther_Name.HeaderText = "التعريف";
            this.AlarmOther_Name.Name = "AlarmOther_Name";
            this.AlarmOther_Name.ReadOnly = true;
            // 
            // StartDays
            // 
            this.StartDays.HeaderText = "عدد الأيام";
            this.StartDays.Name = "StartDays";
            this.StartDays.ReadOnly = true;
            // 
            // Infinite
            // 
            this.Infinite.HeaderText = "لانهائي";
            this.Infinite.Name = "Infinite";
            this.Infinite.ReadOnly = true;
            this.Infinite.Width = 50;
            // 
            // Count
            // 
            this.Count.HeaderText = "عدد المرات";
            this.Count.Name = "Count";
            this.Count.ReadOnly = true;
            // 
            // chk_StartBDate
            // 
            this.chk_StartBDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chk_StartBDate.AutoSize = true;
            this.chk_StartBDate.Location = new System.Drawing.Point(461, 327);
            this.chk_StartBDate.Name = "chk_StartBDate";
            this.chk_StartBDate.Size = new System.Drawing.Size(107, 17);
            this.chk_StartBDate.TabIndex = 196;
            this.chk_StartBDate.Text = "بعد تاريخ الميلاد بـ";
            this.chk_StartBDate.UseVisualStyleBackColor = true;
            // 
            // chk_WhenInsert
            // 
            this.chk_WhenInsert.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chk_WhenInsert.AutoSize = true;
            this.chk_WhenInsert.Location = new System.Drawing.Point(481, 305);
            this.chk_WhenInsert.Name = "chk_WhenInsert";
            this.chk_WhenInsert.Size = new System.Drawing.Size(87, 17);
            this.chk_WhenInsert.TabIndex = 195;
            this.chk_WhenInsert.Text = "عند التسجيل";
            this.chk_WhenInsert.UseVisualStyleBackColor = true;
            // 
            // chk_WithoutItem
            // 
            this.chk_WithoutItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chk_WithoutItem.AutoSize = true;
            this.chk_WithoutItem.Location = new System.Drawing.Point(493, 128);
            this.chk_WithoutItem.Name = "chk_WithoutItem";
            this.chk_WithoutItem.Size = new System.Drawing.Size(73, 17);
            this.chk_WithoutItem.TabIndex = 190;
            this.chk_WithoutItem.Text = "بدون صنف";
            this.chk_WithoutItem.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(397, 199);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 13);
            this.label9.TabIndex = 189;
            this.label9.Text = "الكمية";
            // 
            // txt_Quan
            // 
            this.txt_Quan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Quan.Location = new System.Drawing.Point(333, 196);
            this.txt_Quan.Name = "txt_Quan";
            this.txt_Quan.ReadOnly = true;
            this.txt_Quan.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_Quan.Size = new System.Drawing.Size(60, 20);
            this.txt_Quan.TabIndex = 188;
            this.txt_Quan.TabStop = false;
            this.txt_Quan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_Items2_Del
            // 
            this.btn_Items2_Del.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Items2_Del.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Items2_Del.FlatAppearance.BorderSize = 0;
            this.btn_Items2_Del.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Items2_Del.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btn_Items2_Del.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_Items2_Del.Location = new System.Drawing.Point(412, 190);
            this.btn_Items2_Del.Name = "btn_Items2_Del";
            this.btn_Items2_Del.Size = new System.Drawing.Size(30, 24);
            this.btn_Items2_Del.TabIndex = 187;
            this.btn_Items2_Del.TabStop = false;
            this.btn_Items2_Del.Text = "x";
            this.btn_Items2_Del.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_Items2_Del.UseVisualStyleBackColor = false;
            // 
            // btn_Items2_Add
            // 
            this.btn_Items2_Add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Items2_Add.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Items2_Add.FlatAppearance.BorderSize = 0;
            this.btn_Items2_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Items2_Add.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btn_Items2_Add.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_Items2_Add.Location = new System.Drawing.Point(434, 190);
            this.btn_Items2_Add.Name = "btn_Items2_Add";
            this.btn_Items2_Add.Size = new System.Drawing.Size(30, 24);
            this.btn_Items2_Add.TabIndex = 186;
            this.btn_Items2_Add.TabStop = false;
            this.btn_Items2_Add.Text = "+";
            this.btn_Items2_Add.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_Items2_Add.UseVisualStyleBackColor = false;
            // 
            // com_Items2
            // 
            this.com_Items2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.com_Items2.DisplayMember = "Name";
            this.com_Items2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.com_Items2.Enabled = false;
            this.com_Items2.FormattingEnabled = true;
            this.com_Items2.Location = new System.Drawing.Point(470, 193);
            this.com_Items2.Name = "com_Items2";
            this.com_Items2.Size = new System.Drawing.Size(98, 21);
            this.com_Items2.TabIndex = 184;
            this.com_Items2.ValueMember = "ID";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(574, 196);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 13);
            this.label8.TabIndex = 185;
            this.label8.Text = "الصنف";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(369, 327);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(22, 13);
            this.label6.TabIndex = 176;
            this.label6.Text = "يوم";
            // 
            // txt_StartDayBDate
            // 
            this.txt_StartDayBDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_StartDayBDate.Location = new System.Drawing.Point(395, 328);
            this.txt_StartDayBDate.Name = "txt_StartDayBDate";
            this.txt_StartDayBDate.ReadOnly = true;
            this.txt_StartDayBDate.Size = new System.Drawing.Size(60, 20);
            this.txt_StartDayBDate.TabIndex = 174;
            this.txt_StartDayBDate.TabStop = false;
            this.txt_StartDayBDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_Cat_Del
            // 
            this.btn_Cat_Del.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Cat_Del.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Cat_Del.FlatAppearance.BorderSize = 0;
            this.btn_Cat_Del.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cat_Del.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btn_Cat_Del.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_Cat_Del.Location = new System.Drawing.Point(412, 163);
            this.btn_Cat_Del.Name = "btn_Cat_Del";
            this.btn_Cat_Del.Size = new System.Drawing.Size(30, 24);
            this.btn_Cat_Del.TabIndex = 173;
            this.btn_Cat_Del.TabStop = false;
            this.btn_Cat_Del.Text = "x";
            this.btn_Cat_Del.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_Cat_Del.UseVisualStyleBackColor = false;
            this.btn_Cat_Del.Click += new System.EventHandler(this.btn_Cat_Del_Click);
            // 
            // btn_Cat_Add
            // 
            this.btn_Cat_Add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Cat_Add.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Cat_Add.FlatAppearance.BorderSize = 0;
            this.btn_Cat_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cat_Add.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btn_Cat_Add.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_Cat_Add.Location = new System.Drawing.Point(434, 163);
            this.btn_Cat_Add.Name = "btn_Cat_Add";
            this.btn_Cat_Add.Size = new System.Drawing.Size(30, 24);
            this.btn_Cat_Add.TabIndex = 172;
            this.btn_Cat_Add.TabStop = false;
            this.btn_Cat_Add.Text = "+";
            this.btn_Cat_Add.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_Cat_Add.UseVisualStyleBackColor = false;
            this.btn_Cat_Add.Click += new System.EventHandler(this.btn_Cat_Add_Click);
            // 
            // com_Cat
            // 
            this.com_Cat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.com_Cat.DisplayMember = "Name";
            this.com_Cat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.com_Cat.Enabled = false;
            this.com_Cat.FormattingEnabled = true;
            this.com_Cat.Location = new System.Drawing.Point(470, 166);
            this.com_Cat.Name = "com_Cat";
            this.com_Cat.Size = new System.Drawing.Size(98, 21);
            this.com_Cat.TabIndex = 170;
            this.com_Cat.ValueMember = "ID";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(574, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 171;
            this.label4.Text = "الفئة";
            // 
            // txt_Notes
            // 
            this.txt_Notes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Notes.Location = new System.Drawing.Point(15, 237);
            this.txt_Notes.Multiline = true;
            this.txt_Notes.Name = "txt_Notes";
            this.txt_Notes.ReadOnly = true;
            this.txt_Notes.Size = new System.Drawing.Size(553, 56);
            this.txt_Notes.TabIndex = 122;
            this.txt_Notes.TabStop = false;
            this.txt_Notes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(574, 240);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 13);
            this.label5.TabIndex = 123;
            this.label5.Text = "بيان";
            // 
            // txt_Name
            // 
            this.txt_Name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Name.Location = new System.Drawing.Point(232, 102);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.ReadOnly = true;
            this.txt_Name.Size = new System.Drawing.Size(336, 20);
            this.txt_Name.TabIndex = 111;
            this.txt_Name.TabStop = false;
            this.txt_Name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(574, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 112;
            this.label3.Text = "أسم التنبيه";
            // 
            // txt_ID
            // 
            this.txt_ID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_ID.Location = new System.Drawing.Point(467, 73);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.ReadOnly = true;
            this.txt_ID.Size = new System.Drawing.Size(101, 20);
            this.txt_ID.TabIndex = 1;
            this.txt_ID.TabStop = false;
            this.txt_ID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(574, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "الكود";
            // 
            // frm_AlarmSet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 634);
            this.Controls.Add(this.grbx_Details);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grbx_Controls);
            this.Name = "frm_AlarmSet";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "تسجيل التنبيهات";
            this.Shown += new System.EventHandler(this.frm_AlarmSet_Shown);
            this.grbx_Controls.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.grbx_Details.ResumeLayout(false);
            this.grbx_Details.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Other)).EndInit();
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
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn IID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NName;
        private System.Windows.Forms.GroupBox grbx_Details;
        public System.Windows.Forms.TextBox txt_Notes;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txt_ID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox txt_StartDayBDate;
        private System.Windows.Forms.Button btn_Items2_Del;
        private System.Windows.Forms.Button btn_Items2_Add;
        public System.Windows.Forms.ComboBox com_Items2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.TextBox txt_Quan;
        private System.Windows.Forms.CheckBox chk_WithoutItem;
        private System.Windows.Forms.Button btn_Cat_Del;
        private System.Windows.Forms.Button btn_Cat_Add;
        public System.Windows.Forms.ComboBox com_Cat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chk_StartBDate;
        private System.Windows.Forms.CheckBox chk_WhenInsert;
        private System.Windows.Forms.CheckBox chk_Other;
        private System.Windows.Forms.DataGridView dgv_Other;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.DataGridViewTextBoxColumn AlarmOther_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn AlarmOther_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartDays;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Infinite;
        private System.Windows.Forms.DataGridViewTextBoxColumn Count;
    }
}