namespace WindowsFormsApplication1.PL.Farm
{
    partial class frm_ItemCard
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
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.grbx_Details = new System.Windows.Forms.GroupBox();
            this.txt_ItemID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_pic_item_Delete = new System.Windows.Forms.Button();
            this.btn_pic_item_Edit = new System.Windows.Forms.Button();
            this.pic_Item = new System.Windows.Forms.PictureBox();
            this.txt_ItemCode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_ItemName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_WorkDir_Add = new System.Windows.Forms.Button();
            this.btn_EntryPort_Add = new System.Windows.Forms.Button();
            this.com_Group = new System.Windows.Forms.ComboBox();
            this.com_Kind = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_BirthDate = new System.Windows.Forms.TextBox();
            this.dtp_BirthDate = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.com_Case = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_age = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.grbx_Controls.SuspendLayout();
            this.grbx_Details.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Item)).BeginInit();
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
            this.grbx_Controls.Size = new System.Drawing.Size(989, 106);
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
            this.btn_Logo.Location = new System.Drawing.Point(902, 23);
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
            this.btn_Save.Location = new System.Drawing.Point(479, 18);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(75, 75);
            this.btn_Save.TabIndex = 13;
            this.btn_Save.Text = "حفظ";
            this.btn_Save.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Save.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Visible = false;
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Cancel.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Cancel.FlatAppearance.BorderSize = 0;
            this.btn_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cancel.Image = global::WindowsFormsApplication1.Properties.Resources.cancel_48;
            this.btn_Cancel.Location = new System.Drawing.Point(317, 18);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 75);
            this.btn_Cancel.TabIndex = 14;
            this.btn_Cancel.Text = "تراجع";
            this.btn_Cancel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Cancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_Cancel.UseVisualStyleBackColor = false;
            this.btn_Cancel.Visible = false;
            // 
            // btn_Delete
            // 
            this.btn_Delete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Delete.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Delete.FlatAppearance.BorderSize = 0;
            this.btn_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Delete.Image = global::WindowsFormsApplication1.Properties.Resources.delete_48;
            this.btn_Delete.Location = new System.Drawing.Point(398, 18);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(75, 75);
            this.btn_Delete.TabIndex = 2;
            this.btn_Delete.TabStop = false;
            this.btn_Delete.Text = "حذف";
            this.btn_Delete.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Delete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_Delete.UseVisualStyleBackColor = false;
            // 
            // btn_Edit
            // 
            this.btn_Edit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Edit.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Edit.FlatAppearance.BorderSize = 0;
            this.btn_Edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Edit.Image = global::WindowsFormsApplication1.Properties.Resources.edit_48;
            this.btn_Edit.Location = new System.Drawing.Point(560, 18);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(75, 75);
            this.btn_Edit.TabIndex = 1;
            this.btn_Edit.TabStop = false;
            this.btn_Edit.Text = "تعديل";
            this.btn_Edit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Edit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_Edit.UseVisualStyleBackColor = false;
            // 
            // btn_New
            // 
            this.btn_New.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_New.BackColor = System.Drawing.SystemColors.Control;
            this.btn_New.FlatAppearance.BorderSize = 0;
            this.btn_New.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_New.Image = global::WindowsFormsApplication1.Properties.Resources.new_48;
            this.btn_New.Location = new System.Drawing.Point(641, 18);
            this.btn_New.Name = "btn_New";
            this.btn_New.Size = new System.Drawing.Size(75, 75);
            this.btn_New.TabIndex = 0;
            this.btn_New.TabStop = false;
            this.btn_New.Text = "جديد";
            this.btn_New.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_New.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_New.UseVisualStyleBackColor = false;
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(790, 112);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(196, 431);
            this.treeView1.TabIndex = 38;
            // 
            // grbx_Details
            // 
            this.grbx_Details.Controls.Add(this.button1);
            this.grbx_Details.Controls.Add(this.comboBox1);
            this.grbx_Details.Controls.Add(this.label10);
            this.grbx_Details.Controls.Add(this.textBox2);
            this.grbx_Details.Controls.Add(this.label9);
            this.grbx_Details.Controls.Add(this.txt_age);
            this.grbx_Details.Controls.Add(this.label8);
            this.grbx_Details.Controls.Add(this.com_Case);
            this.grbx_Details.Controls.Add(this.label7);
            this.grbx_Details.Controls.Add(this.textBox1);
            this.grbx_Details.Controls.Add(this.label5);
            this.grbx_Details.Controls.Add(this.txt_BirthDate);
            this.grbx_Details.Controls.Add(this.dtp_BirthDate);
            this.grbx_Details.Controls.Add(this.label6);
            this.grbx_Details.Controls.Add(this.btn_WorkDir_Add);
            this.grbx_Details.Controls.Add(this.btn_EntryPort_Add);
            this.grbx_Details.Controls.Add(this.com_Group);
            this.grbx_Details.Controls.Add(this.com_Kind);
            this.grbx_Details.Controls.Add(this.label11);
            this.grbx_Details.Controls.Add(this.label4);
            this.grbx_Details.Controls.Add(this.txt_ItemName);
            this.grbx_Details.Controls.Add(this.label3);
            this.grbx_Details.Controls.Add(this.txt_ItemCode);
            this.grbx_Details.Controls.Add(this.label2);
            this.grbx_Details.Controls.Add(this.btn_pic_item_Delete);
            this.grbx_Details.Controls.Add(this.btn_pic_item_Edit);
            this.grbx_Details.Controls.Add(this.pic_Item);
            this.grbx_Details.Controls.Add(this.txt_ItemID);
            this.grbx_Details.Controls.Add(this.label1);
            this.grbx_Details.Location = new System.Drawing.Point(0, 112);
            this.grbx_Details.Name = "grbx_Details";
            this.grbx_Details.Size = new System.Drawing.Size(784, 431);
            this.grbx_Details.TabIndex = 39;
            this.grbx_Details.TabStop = false;
            // 
            // txt_ItemID
            // 
            this.txt_ItemID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_ItemID.Location = new System.Drawing.Point(553, 26);
            this.txt_ItemID.Name = "txt_ItemID";
            this.txt_ItemID.ReadOnly = true;
            this.txt_ItemID.Size = new System.Drawing.Size(141, 23);
            this.txt_ItemID.TabIndex = 1;
            this.txt_ItemID.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(700, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "كود الصنف";
            // 
            // btn_pic_item_Delete
            // 
            this.btn_pic_item_Delete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_pic_item_Delete.FlatAppearance.BorderSize = 0;
            this.btn_pic_item_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_pic_item_Delete.Font = new System.Drawing.Font("Verdana", 9F);
            this.btn_pic_item_Delete.ForeColor = System.Drawing.Color.DimGray;
            this.btn_pic_item_Delete.ImageKey = "(none)";
            this.btn_pic_item_Delete.Location = new System.Drawing.Point(57, 186);
            this.btn_pic_item_Delete.Name = "btn_pic_item_Delete";
            this.btn_pic_item_Delete.Size = new System.Drawing.Size(30, 30);
            this.btn_pic_item_Delete.TabIndex = 108;
            this.btn_pic_item_Delete.TabStop = false;
            this.btn_pic_item_Delete.Text = "x";
            this.btn_pic_item_Delete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_pic_item_Delete.UseVisualStyleBackColor = true;
            // 
            // btn_pic_item_Edit
            // 
            this.btn_pic_item_Edit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_pic_item_Edit.FlatAppearance.BorderSize = 0;
            this.btn_pic_item_Edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_pic_item_Edit.Font = new System.Drawing.Font("Tahoma", 9F);
            this.btn_pic_item_Edit.ForeColor = System.Drawing.Color.DimGray;
            this.btn_pic_item_Edit.ImageKey = "(none)";
            this.btn_pic_item_Edit.Location = new System.Drawing.Point(90, 186);
            this.btn_pic_item_Edit.Name = "btn_pic_item_Edit";
            this.btn_pic_item_Edit.Size = new System.Drawing.Size(30, 30);
            this.btn_pic_item_Edit.TabIndex = 107;
            this.btn_pic_item_Edit.TabStop = false;
            this.btn_pic_item_Edit.Text = "O";
            this.btn_pic_item_Edit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_pic_item_Edit.UseVisualStyleBackColor = true;
            // 
            // pic_Item
            // 
            this.pic_Item.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_Item.Location = new System.Drawing.Point(21, 28);
            this.pic_Item.Name = "pic_Item";
            this.pic_Item.Size = new System.Drawing.Size(139, 158);
            this.pic_Item.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_Item.TabIndex = 106;
            this.pic_Item.TabStop = false;
            // 
            // txt_ItemCode
            // 
            this.txt_ItemCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_ItemCode.Location = new System.Drawing.Point(228, 22);
            this.txt_ItemCode.Name = "txt_ItemCode";
            this.txt_ItemCode.ReadOnly = true;
            this.txt_ItemCode.Size = new System.Drawing.Size(147, 23);
            this.txt_ItemCode.TabIndex = 109;
            this.txt_ItemCode.TabStop = false;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(381, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 16);
            this.label2.TabIndex = 110;
            this.label2.Text = "رقم الصنف";
            // 
            // txt_ItemName
            // 
            this.txt_ItemName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_ItemName.Location = new System.Drawing.Point(228, 55);
            this.txt_ItemName.Name = "txt_ItemName";
            this.txt_ItemName.ReadOnly = true;
            this.txt_ItemName.Size = new System.Drawing.Size(466, 23);
            this.txt_ItemName.TabIndex = 111;
            this.txt_ItemName.TabStop = false;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(700, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 16);
            this.label3.TabIndex = 112;
            this.label3.Text = "تعريف الصنف";
            // 
            // btn_WorkDir_Add
            // 
            this.btn_WorkDir_Add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_WorkDir_Add.BackColor = System.Drawing.SystemColors.Control;
            this.btn_WorkDir_Add.FlatAppearance.BorderSize = 0;
            this.btn_WorkDir_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_WorkDir_Add.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btn_WorkDir_Add.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_WorkDir_Add.Location = new System.Drawing.Point(531, 84);
            this.btn_WorkDir_Add.Name = "btn_WorkDir_Add";
            this.btn_WorkDir_Add.Size = new System.Drawing.Size(30, 24);
            this.btn_WorkDir_Add.TabIndex = 118;
            this.btn_WorkDir_Add.TabStop = false;
            this.btn_WorkDir_Add.Text = "+";
            this.btn_WorkDir_Add.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_WorkDir_Add.UseVisualStyleBackColor = false;
            // 
            // btn_EntryPort_Add
            // 
            this.btn_EntryPort_Add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_EntryPort_Add.BackColor = System.Drawing.SystemColors.Control;
            this.btn_EntryPort_Add.FlatAppearance.BorderSize = 0;
            this.btn_EntryPort_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_EntryPort_Add.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btn_EntryPort_Add.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_EntryPort_Add.Location = new System.Drawing.Point(194, 84);
            this.btn_EntryPort_Add.Name = "btn_EntryPort_Add";
            this.btn_EntryPort_Add.Size = new System.Drawing.Size(30, 24);
            this.btn_EntryPort_Add.TabIndex = 117;
            this.btn_EntryPort_Add.TabStop = false;
            this.btn_EntryPort_Add.Text = "+";
            this.btn_EntryPort_Add.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_EntryPort_Add.UseVisualStyleBackColor = false;
            // 
            // com_Group
            // 
            this.com_Group.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.com_Group.DisplayMember = "Name";
            this.com_Group.Enabled = false;
            this.com_Group.FormattingEnabled = true;
            this.com_Group.Location = new System.Drawing.Point(228, 84);
            this.com_Group.Name = "com_Group";
            this.com_Group.Size = new System.Drawing.Size(123, 24);
            this.com_Group.TabIndex = 113;
            this.com_Group.ValueMember = "ID";
            // 
            // com_Kind
            // 
            this.com_Kind.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.com_Kind.DisplayMember = "Name";
            this.com_Kind.Enabled = false;
            this.com_Kind.FormattingEnabled = true;
            this.com_Kind.Items.AddRange(new object[] {
            "ذكر",
            "انثى"});
            this.com_Kind.Location = new System.Drawing.Point(567, 84);
            this.com_Kind.Name = "com_Kind";
            this.com_Kind.Size = new System.Drawing.Size(127, 24);
            this.com_Kind.TabIndex = 114;
            this.com_Kind.ValueMember = "ID";
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(700, 87);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(34, 16);
            this.label11.TabIndex = 116;
            this.label11.Text = "النوع";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(357, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 16);
            this.label4.TabIndex = 115;
            this.label4.Text = "الفئة";
            // 
            // txt_BirthDate
            // 
            this.txt_BirthDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_BirthDate.Location = new System.Drawing.Point(585, 114);
            this.txt_BirthDate.Name = "txt_BirthDate";
            this.txt_BirthDate.ReadOnly = true;
            this.txt_BirthDate.Size = new System.Drawing.Size(109, 23);
            this.txt_BirthDate.TabIndex = 119;
            this.txt_BirthDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dtp_BirthDate
            // 
            this.dtp_BirthDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtp_BirthDate.CustomFormat = " ";
            this.dtp_BirthDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_BirthDate.Location = new System.Drawing.Point(567, 114);
            this.dtp_BirthDate.Name = "dtp_BirthDate";
            this.dtp_BirthDate.RightToLeftLayout = true;
            this.dtp_BirthDate.Size = new System.Drawing.Size(42, 23);
            this.dtp_BirthDate.TabIndex = 121;
            this.dtp_BirthDate.TabStop = false;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(700, 115);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 16);
            this.label6.TabIndex = 120;
            this.label6.Text = "تاريخ الميلاد";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(228, 146);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(121, 23);
            this.textBox1.TabIndex = 122;
            this.textBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(357, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 16);
            this.label5.TabIndex = 123;
            this.label5.Text = "الوزن";
            // 
            // com_Case
            // 
            this.com_Case.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.com_Case.DisplayMember = "Name";
            this.com_Case.Enabled = false;
            this.com_Case.FormattingEnabled = true;
            this.com_Case.Items.AddRange(new object[] {
            "جديد",
            "مولود"});
            this.com_Case.Location = new System.Drawing.Point(567, 170);
            this.com_Case.Name = "com_Case";
            this.com_Case.Size = new System.Drawing.Size(127, 24);
            this.com_Case.TabIndex = 124;
            this.com_Case.ValueMember = "ID";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(700, 173);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 16);
            this.label7.TabIndex = 125;
            this.label7.Text = "الحالة";
            // 
            // txt_age
            // 
            this.txt_age.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_age.Location = new System.Drawing.Point(567, 141);
            this.txt_age.Name = "txt_age";
            this.txt_age.ReadOnly = true;
            this.txt_age.Size = new System.Drawing.Size(127, 23);
            this.txt_age.TabIndex = 126;
            this.txt_age.TabStop = false;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(700, 143);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 16);
            this.label8.TabIndex = 127;
            this.label8.Text = "العمر";
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.Location = new System.Drawing.Point(21, 373);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(117, 23);
            this.textBox2.TabIndex = 128;
            this.textBox2.TabStop = false;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(144, 375);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 16);
            this.label9.TabIndex = 129;
            this.label9.Text = "التكلفة";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Tahoma", 12F);
            this.button1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button1.Location = new System.Drawing.Point(194, 114);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(30, 24);
            this.button1.TabIndex = 132;
            this.button1.TabStop = false;
            this.button1.Text = "+";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox1.DisplayMember = "Name";
            this.comboBox1.Enabled = false;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "ذكر",
            "انثى"});
            this.comboBox1.Location = new System.Drawing.Point(228, 113);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(123, 24);
            this.comboBox1.TabIndex = 130;
            this.comboBox1.ValueMember = "ID";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(357, 116);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 16);
            this.label10.TabIndex = 131;
            this.label10.Text = "الحظيرة";
            // 
            // frm_ItemCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 616);
            this.Controls.Add(this.grbx_Details);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.grbx_Controls);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frm_ItemCard";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "بطاقة تعريف";
            this.grbx_Controls.ResumeLayout(false);
            this.grbx_Details.ResumeLayout(false);
            this.grbx_Details.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Item)).EndInit();
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
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.GroupBox grbx_Details;
        public System.Windows.Forms.TextBox txt_ItemID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox com_Case;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txt_BirthDate;
        private System.Windows.Forms.DateTimePicker dtp_BirthDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_WorkDir_Add;
        private System.Windows.Forms.Button btn_EntryPort_Add;
        public System.Windows.Forms.ComboBox com_Group;
        private System.Windows.Forms.ComboBox com_Kind;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txt_ItemName;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txt_ItemCode;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Button btn_pic_item_Delete;
        public System.Windows.Forms.Button btn_pic_item_Edit;
        public System.Windows.Forms.PictureBox pic_Item;
        public System.Windows.Forms.TextBox txt_age;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label9;
    }
}