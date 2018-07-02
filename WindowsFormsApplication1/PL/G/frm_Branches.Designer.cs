namespace WindowsFormsApplication1.PL.G
{
    partial class frm_Branches
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Branches));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle29 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle30 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DGV_Branches = new System.Windows.Forms.DataGridView();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btn_Edit = new System.Windows.Forms.Button();
            this.txt_BrancheAnm = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Branche_ID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_New = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.groupBox_Branches = new System.Windows.Forms.GroupBox();
            this.txt_BrancheEnm = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_Branche_ID = new System.Windows.Forms.Label();
            this.groupBox_Main_Controls = new System.Windows.Forms.GroupBox();
            this.groupBox_Stores = new System.Windows.Forms.GroupBox();
            this.txt_StoreEnm = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label_Store_Full_Name = new System.Windows.Forms.Label();
            this.button_New_Store = new System.Windows.Forms.Button();
            this.button_Cancel_Store = new System.Windows.Forms.Button();
            this.button_Delete_Store = new System.Windows.Forms.Button();
            this.button_Edit_Store = new System.Windows.Forms.Button();
            this.DGV_Stores = new System.Windows.Forms.DataGridView();
            this.txt_StoreAnm = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_Store_ID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_Save = new System.Windows.Forms.Button();
            this.BrancheID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BrancheName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BrancheEnm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StoreID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StoreName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StoreEnm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Branches)).BeginInit();
            this.groupBox_Branches.SuspendLayout();
            this.groupBox_Main_Controls.SuspendLayout();
            this.groupBox_Stores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Stores)).BeginInit();
            this.SuspendLayout();
            // 
            // DGV_Branches
            // 
            this.DGV_Branches.AllowUserToAddRows = false;
            this.DGV_Branches.AllowUserToDeleteRows = false;
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle21.BackColor = System.Drawing.Color.WhiteSmoke;
            this.DGV_Branches.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle21;
            this.DGV_Branches.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.DGV_Branches.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_Branches.BackgroundColor = System.Drawing.SystemColors.Window;
            this.DGV_Branches.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle22.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle22.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_Branches.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle22;
            this.DGV_Branches.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Branches.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BrancheID,
            this.BrancheName,
            this.BrancheEnm});
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle23.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle23.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGV_Branches.DefaultCellStyle = dataGridViewCellStyle23;
            this.DGV_Branches.Location = new System.Drawing.Point(65, 180);
            this.DGV_Branches.MultiSelect = false;
            this.DGV_Branches.Name = "DGV_Branches";
            this.DGV_Branches.ReadOnly = true;
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle24.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle24.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle24.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_Branches.RowHeadersDefaultCellStyle = dataGridViewCellStyle24;
            dataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.DGV_Branches.RowsDefaultCellStyle = dataGridViewCellStyle25;
            this.DGV_Branches.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_Branches.Size = new System.Drawing.Size(405, 367);
            this.DGV_Branches.TabIndex = 16;
            this.DGV_Branches.SelectionChanged += new System.EventHandler(this.DGV_Branches_SelectionChanged);
            // 
            // btn_Delete
            // 
            this.btn_Delete.FlatAppearance.BorderSize = 0;
            this.btn_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Delete.ImageKey = "Delete";
            this.btn_Delete.ImageList = this.imageList1;
            this.btn_Delete.Location = new System.Drawing.Point(773, 21);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(69, 78);
            this.btn_Delete.TabIndex = 3;
            this.btn_Delete.Text = "حذف";
            this.btn_Delete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.button_Delete_Click);
            this.btn_Delete.MouseEnter += new System.EventHandler(this.button_Delete_MouseEnter);
            this.btn_Delete.MouseLeave += new System.EventHandler(this.button_Delete_MouseLeave);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "New");
            this.imageList1.Images.SetKeyName(1, "Delete");
            this.imageList1.Images.SetKeyName(2, "Cancel");
            this.imageList1.Images.SetKeyName(3, "Edit");
            this.imageList1.Images.SetKeyName(4, "Add");
            this.imageList1.Images.SetKeyName(5, "Update");
            this.imageList1.Images.SetKeyName(6, "Close");
            this.imageList1.Images.SetKeyName(7, "Save");
            // 
            // btn_Edit
            // 
            this.btn_Edit.FlatAppearance.BorderSize = 0;
            this.btn_Edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Edit.ImageKey = "Edit";
            this.btn_Edit.ImageList = this.imageList1;
            this.btn_Edit.Location = new System.Drawing.Point(923, 19);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(69, 78);
            this.btn_Edit.TabIndex = 2;
            this.btn_Edit.Text = "تعديل";
            this.btn_Edit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_Edit.UseVisualStyleBackColor = true;
            this.btn_Edit.Click += new System.EventHandler(this.button_Edit_Click);
            this.btn_Edit.MouseEnter += new System.EventHandler(this.button_Edit_MouseEnter);
            this.btn_Edit.MouseLeave += new System.EventHandler(this.button_Edit_MouseLeave);
            // 
            // txt_BrancheAnm
            // 
            this.txt_BrancheAnm.Location = new System.Drawing.Point(96, 117);
            this.txt_BrancheAnm.Name = "txt_BrancheAnm";
            this.txt_BrancheAnm.ReadOnly = true;
            this.txt_BrancheAnm.Size = new System.Drawing.Size(336, 20);
            this.txt_BrancheAnm.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(438, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "أسم الفرع";
            // 
            // txt_Branche_ID
            // 
            this.txt_Branche_ID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_Branche_ID.Location = new System.Drawing.Point(291, 75);
            this.txt_Branche_ID.Name = "txt_Branche_ID";
            this.txt_Branche_ID.ReadOnly = true;
            this.txt_Branche_ID.Size = new System.Drawing.Size(141, 20);
            this.txt_Branche_ID.TabIndex = 1;
            this.txt_Branche_ID.TextChanged += new System.EventHandler(this.txt_Branche_ID_TextChanged);
            this.txt_Branche_ID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Branche_ID_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(438, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "كود الفرع";
            // 
            // btn_New
            // 
            this.btn_New.FlatAppearance.BorderSize = 0;
            this.btn_New.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_New.ImageKey = "New";
            this.btn_New.ImageList = this.imageList1;
            this.btn_New.Location = new System.Drawing.Point(998, 21);
            this.btn_New.Name = "btn_New";
            this.btn_New.Size = new System.Drawing.Size(69, 78);
            this.btn_New.TabIndex = 1;
            this.btn_New.Text = "جديد";
            this.btn_New.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_New.UseVisualStyleBackColor = true;
            this.btn_New.Click += new System.EventHandler(this.button_New_Click);
            this.btn_New.MouseEnter += new System.EventHandler(this.button_New_MouseEnter);
            this.btn_New.MouseLeave += new System.EventHandler(this.button_New_MouseLeave);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.FlatAppearance.BorderSize = 0;
            this.btn_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cancel.ImageKey = "Cancel";
            this.btn_Cancel.ImageList = this.imageList1;
            this.btn_Cancel.Location = new System.Drawing.Point(698, 19);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(69, 78);
            this.btn_Cancel.TabIndex = 4;
            this.btn_Cancel.Text = "تراجع";
            this.btn_Cancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Visible = false;
            this.btn_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
            this.btn_Cancel.MouseEnter += new System.EventHandler(this.button_Cancel_MouseEnter);
            this.btn_Cancel.MouseLeave += new System.EventHandler(this.button_Cancel_MouseLeave);
            // 
            // groupBox_Branches
            // 
            this.groupBox_Branches.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.groupBox_Branches.Controls.Add(this.txt_BrancheEnm);
            this.groupBox_Branches.Controls.Add(this.label5);
            this.groupBox_Branches.Controls.Add(this.lbl_Branche_ID);
            this.groupBox_Branches.Controls.Add(this.DGV_Branches);
            this.groupBox_Branches.Controls.Add(this.txt_BrancheAnm);
            this.groupBox_Branches.Controls.Add(this.label2);
            this.groupBox_Branches.Controls.Add(this.txt_Branche_ID);
            this.groupBox_Branches.Controls.Add(this.label1);
            this.groupBox_Branches.Location = new System.Drawing.Point(16, 127);
            this.groupBox_Branches.Name = "groupBox_Branches";
            this.groupBox_Branches.Size = new System.Drawing.Size(529, 570);
            this.groupBox_Branches.TabIndex = 14;
            this.groupBox_Branches.TabStop = false;
            this.groupBox_Branches.Text = "الفروع";
            // 
            // txt_BrancheEnm
            // 
            this.txt_BrancheEnm.Location = new System.Drawing.Point(96, 142);
            this.txt_BrancheEnm.Name = "txt_BrancheEnm";
            this.txt_BrancheEnm.ReadOnly = true;
            this.txt_BrancheEnm.Size = new System.Drawing.Size(336, 20);
            this.txt_BrancheEnm.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(438, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Branche Name";
            // 
            // lbl_Branche_ID
            // 
            this.lbl_Branche_ID.AutoSize = true;
            this.lbl_Branche_ID.Font = new System.Drawing.Font("Tahoma", 8F);
            this.lbl_Branche_ID.ForeColor = System.Drawing.Color.IndianRed;
            this.lbl_Branche_ID.Location = new System.Drawing.Point(292, 98);
            this.lbl_Branche_ID.Name = "lbl_Branche_ID";
            this.lbl_Branche_ID.Size = new System.Drawing.Size(0, 13);
            this.lbl_Branche_ID.TabIndex = 17;
            // 
            // groupBox_Main_Controls
            // 
            this.groupBox_Main_Controls.Controls.Add(this.btn_Save);
            this.groupBox_Main_Controls.Controls.Add(this.btn_New);
            this.groupBox_Main_Controls.Controls.Add(this.btn_Cancel);
            this.groupBox_Main_Controls.Controls.Add(this.btn_Delete);
            this.groupBox_Main_Controls.Controls.Add(this.btn_Edit);
            this.groupBox_Main_Controls.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox_Main_Controls.Location = new System.Drawing.Point(0, 0);
            this.groupBox_Main_Controls.Name = "groupBox_Main_Controls";
            this.groupBox_Main_Controls.Size = new System.Drawing.Size(1096, 105);
            this.groupBox_Main_Controls.TabIndex = 13;
            this.groupBox_Main_Controls.TabStop = false;
            // 
            // groupBox_Stores
            // 
            this.groupBox_Stores.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.groupBox_Stores.Controls.Add(this.txt_StoreEnm);
            this.groupBox_Stores.Controls.Add(this.label6);
            this.groupBox_Stores.Controls.Add(this.label_Store_Full_Name);
            this.groupBox_Stores.Controls.Add(this.button_New_Store);
            this.groupBox_Stores.Controls.Add(this.button_Cancel_Store);
            this.groupBox_Stores.Controls.Add(this.button_Delete_Store);
            this.groupBox_Stores.Controls.Add(this.button_Edit_Store);
            this.groupBox_Stores.Controls.Add(this.DGV_Stores);
            this.groupBox_Stores.Controls.Add(this.txt_StoreAnm);
            this.groupBox_Stores.Controls.Add(this.label3);
            this.groupBox_Stores.Controls.Add(this.textBox_Store_ID);
            this.groupBox_Stores.Controls.Add(this.label4);
            this.groupBox_Stores.Location = new System.Drawing.Point(551, 127);
            this.groupBox_Stores.Name = "groupBox_Stores";
            this.groupBox_Stores.Size = new System.Drawing.Size(529, 570);
            this.groupBox_Stores.TabIndex = 15;
            this.groupBox_Stores.TabStop = false;
            this.groupBox_Stores.Text = "المستودعات";
            // 
            // txt_StoreEnm
            // 
            this.txt_StoreEnm.Location = new System.Drawing.Point(96, 142);
            this.txt_StoreEnm.Name = "txt_StoreEnm";
            this.txt_StoreEnm.ReadOnly = true;
            this.txt_StoreEnm.Size = new System.Drawing.Size(336, 20);
            this.txt_StoreEnm.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(438, 145);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Store Name";
            // 
            // label_Store_Full_Name
            // 
            this.label_Store_Full_Name.Location = new System.Drawing.Point(96, 139);
            this.label_Store_Full_Name.Name = "label_Store_Full_Name";
            this.label_Store_Full_Name.Size = new System.Drawing.Size(339, 25);
            this.label_Store_Full_Name.TabIndex = 21;
            this.label_Store_Full_Name.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label_Store_Full_Name.Visible = false;
            // 
            // button_New_Store
            // 
            this.button_New_Store.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_New_Store.FlatAppearance.BorderSize = 0;
            this.button_New_Store.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_New_Store.ImageKey = "New";
            this.button_New_Store.ImageList = this.imageList1;
            this.button_New_Store.Location = new System.Drawing.Point(345, 485);
            this.button_New_Store.Name = "button_New_Store";
            this.button_New_Store.Size = new System.Drawing.Size(69, 78);
            this.button_New_Store.TabIndex = 17;
            this.button_New_Store.Text = "جديد";
            this.button_New_Store.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button_New_Store.UseVisualStyleBackColor = true;
            this.button_New_Store.Click += new System.EventHandler(this.button_New_Store_Click);
            this.button_New_Store.MouseEnter += new System.EventHandler(this.button_New_Store_MouseEnter);
            this.button_New_Store.MouseLeave += new System.EventHandler(this.button_New_Store_MouseLeave);
            // 
            // button_Cancel_Store
            // 
            this.button_Cancel_Store.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_Cancel_Store.FlatAppearance.BorderSize = 0;
            this.button_Cancel_Store.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Cancel_Store.ImageKey = "Cancel";
            this.button_Cancel_Store.ImageList = this.imageList1;
            this.button_Cancel_Store.Location = new System.Drawing.Point(120, 483);
            this.button_Cancel_Store.Name = "button_Cancel_Store";
            this.button_Cancel_Store.Size = new System.Drawing.Size(69, 78);
            this.button_Cancel_Store.TabIndex = 20;
            this.button_Cancel_Store.Text = "تراجع";
            this.button_Cancel_Store.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button_Cancel_Store.UseVisualStyleBackColor = true;
            this.button_Cancel_Store.Visible = false;
            this.button_Cancel_Store.Click += new System.EventHandler(this.button_Cancel_Store_Click);
            this.button_Cancel_Store.MouseEnter += new System.EventHandler(this.button_Cancel_Store_MouseEnter);
            this.button_Cancel_Store.MouseLeave += new System.EventHandler(this.button_Cancel_Store_MouseLeave);
            // 
            // button_Delete_Store
            // 
            this.button_Delete_Store.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_Delete_Store.FlatAppearance.BorderSize = 0;
            this.button_Delete_Store.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Delete_Store.ImageKey = "Delete";
            this.button_Delete_Store.ImageList = this.imageList1;
            this.button_Delete_Store.Location = new System.Drawing.Point(195, 485);
            this.button_Delete_Store.Name = "button_Delete_Store";
            this.button_Delete_Store.Size = new System.Drawing.Size(69, 78);
            this.button_Delete_Store.TabIndex = 19;
            this.button_Delete_Store.Text = "حذف";
            this.button_Delete_Store.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button_Delete_Store.UseVisualStyleBackColor = true;
            this.button_Delete_Store.Click += new System.EventHandler(this.button_Delete_Store_Click);
            this.button_Delete_Store.MouseEnter += new System.EventHandler(this.button_Delete_Store_MouseEnter);
            this.button_Delete_Store.MouseLeave += new System.EventHandler(this.button_Delete_Store_MouseLeave);
            // 
            // button_Edit_Store
            // 
            this.button_Edit_Store.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_Edit_Store.FlatAppearance.BorderSize = 0;
            this.button_Edit_Store.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Edit_Store.ImageKey = "Edit";
            this.button_Edit_Store.ImageList = this.imageList1;
            this.button_Edit_Store.Location = new System.Drawing.Point(270, 483);
            this.button_Edit_Store.Name = "button_Edit_Store";
            this.button_Edit_Store.Size = new System.Drawing.Size(69, 78);
            this.button_Edit_Store.TabIndex = 18;
            this.button_Edit_Store.Text = "تعديل";
            this.button_Edit_Store.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button_Edit_Store.UseVisualStyleBackColor = true;
            this.button_Edit_Store.Click += new System.EventHandler(this.button_Edit_Store_Click);
            this.button_Edit_Store.MouseEnter += new System.EventHandler(this.button_Edit_Store_MouseEnter);
            this.button_Edit_Store.MouseLeave += new System.EventHandler(this.button_Edit_Store_MouseLeave);
            // 
            // DGV_Stores
            // 
            this.DGV_Stores.AllowUserToAddRows = false;
            this.DGV_Stores.AllowUserToDeleteRows = false;
            dataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle26.BackColor = System.Drawing.Color.WhiteSmoke;
            this.DGV_Stores.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle26;
            this.DGV_Stores.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.DGV_Stores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_Stores.BackgroundColor = System.Drawing.SystemColors.Window;
            this.DGV_Stores.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle27.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle27.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle27.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle27.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle27.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle27.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_Stores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle27;
            this.DGV_Stores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Stores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StoreID,
            this.StoreName,
            this.StoreEnm});
            dataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle28.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle28.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle28.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle28.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle28.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle28.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGV_Stores.DefaultCellStyle = dataGridViewCellStyle28;
            this.DGV_Stores.Location = new System.Drawing.Point(60, 180);
            this.DGV_Stores.MultiSelect = false;
            this.DGV_Stores.Name = "DGV_Stores";
            this.DGV_Stores.ReadOnly = true;
            dataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle29.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle29.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle29.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle29.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle29.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle29.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_Stores.RowHeadersDefaultCellStyle = dataGridViewCellStyle29;
            dataGridViewCellStyle30.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.DGV_Stores.RowsDefaultCellStyle = dataGridViewCellStyle30;
            this.DGV_Stores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_Stores.Size = new System.Drawing.Size(405, 299);
            this.DGV_Stores.TabIndex = 16;
            this.DGV_Stores.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_Stores_RowEnter);
            // 
            // txt_StoreAnm
            // 
            this.txt_StoreAnm.Location = new System.Drawing.Point(96, 116);
            this.txt_StoreAnm.Name = "txt_StoreAnm";
            this.txt_StoreAnm.ReadOnly = true;
            this.txt_StoreAnm.Size = new System.Drawing.Size(336, 20);
            this.txt_StoreAnm.TabIndex = 3;
            this.txt_StoreAnm.TextChanged += new System.EventHandler(this.textBox_Store_Name_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(438, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "أسم المستودع";
            // 
            // textBox_Store_ID
            // 
            this.textBox_Store_ID.Location = new System.Drawing.Point(291, 75);
            this.textBox_Store_ID.Name = "textBox_Store_ID";
            this.textBox_Store_ID.ReadOnly = true;
            this.textBox_Store_ID.Size = new System.Drawing.Size(141, 20);
            this.textBox_Store_ID.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(438, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "كود المستودع";
            // 
            // btn_Save
            // 
            this.btn_Save.FlatAppearance.BorderSize = 0;
            this.btn_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Save.ImageKey = "Save";
            this.btn_Save.ImageList = this.imageList1;
            this.btn_Save.Location = new System.Drawing.Point(848, 21);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(69, 78);
            this.btn_Save.TabIndex = 5;
            this.btn_Save.Text = "حفظ";
            this.btn_Save.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Visible = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            this.btn_Save.MouseEnter += new System.EventHandler(this.btn_Save_MouseEnter);
            this.btn_Save.MouseLeave += new System.EventHandler(this.btn_Save_MouseLeave);
            // 
            // BrancheID
            // 
            this.BrancheID.DataPropertyName = "ID";
            this.BrancheID.FillWeight = 25F;
            this.BrancheID.HeaderText = "كود الفرع";
            this.BrancheID.MinimumWidth = 2;
            this.BrancheID.Name = "BrancheID";
            this.BrancheID.ReadOnly = true;
            // 
            // BrancheName
            // 
            this.BrancheName.DataPropertyName = "Anm";
            this.BrancheName.FillWeight = 98.47716F;
            this.BrancheName.HeaderText = "أسم الفرع";
            this.BrancheName.Name = "BrancheName";
            this.BrancheName.ReadOnly = true;
            // 
            // BrancheEnm
            // 
            this.BrancheEnm.DataPropertyName = "Enm";
            this.BrancheEnm.HeaderText = "Branche Name";
            this.BrancheEnm.Name = "BrancheEnm";
            this.BrancheEnm.ReadOnly = true;
            this.BrancheEnm.Visible = false;
            // 
            // StoreID
            // 
            this.StoreID.DataPropertyName = "ID";
            this.StoreID.FillWeight = 25F;
            this.StoreID.HeaderText = "كود المستودع";
            this.StoreID.MinimumWidth = 2;
            this.StoreID.Name = "StoreID";
            this.StoreID.ReadOnly = true;
            // 
            // StoreName
            // 
            this.StoreName.DataPropertyName = "Anm";
            this.StoreName.FillWeight = 98.47716F;
            this.StoreName.HeaderText = "أسم المستودع";
            this.StoreName.Name = "StoreName";
            this.StoreName.ReadOnly = true;
            // 
            // StoreEnm
            // 
            this.StoreEnm.DataPropertyName = "Enm";
            this.StoreEnm.HeaderText = "Store Name";
            this.StoreEnm.Name = "StoreEnm";
            this.StoreEnm.ReadOnly = true;
            this.StoreEnm.Visible = false;
            // 
            // frm_Branches
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1096, 709);
            this.Controls.Add(this.groupBox_Stores);
            this.Controls.Add(this.groupBox_Branches);
            this.Controls.Add(this.groupBox_Main_Controls);
            this.Name = "frm_Branches";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "Select";
            this.Text = "الفروع والمستودعات";
            this.Shown += new System.EventHandler(this.FRM_Branches_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Branches)).EndInit();
            this.groupBox_Branches.ResumeLayout(false);
            this.groupBox_Branches.PerformLayout();
            this.groupBox_Main_Controls.ResumeLayout(false);
            this.groupBox_Stores.ResumeLayout(false);
            this.groupBox_Stores.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Stores)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView DGV_Branches;
        public System.Windows.Forms.Button btn_Delete;
        public System.Windows.Forms.ImageList imageList1;
        public System.Windows.Forms.Button btn_Edit;
        public System.Windows.Forms.TextBox txt_BrancheAnm;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txt_Branche_ID;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button btn_New;
        public System.Windows.Forms.Button btn_Cancel;
        public System.Windows.Forms.GroupBox groupBox_Branches;
        public System.Windows.Forms.GroupBox groupBox_Main_Controls;
        public System.Windows.Forms.GroupBox groupBox_Stores;
        public System.Windows.Forms.DataGridView DGV_Stores;
        public System.Windows.Forms.TextBox txt_StoreAnm;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox textBox_Store_ID;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Button button_New_Store;
        public System.Windows.Forms.Button button_Cancel_Store;
        public System.Windows.Forms.Button button_Delete_Store;
        public System.Windows.Forms.Button button_Edit_Store;
        public System.Windows.Forms.Label label_Store_Full_Name;
        private System.Windows.Forms.Label lbl_Branche_ID;
        public System.Windows.Forms.TextBox txt_BrancheEnm;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txt_StoreEnm;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.DataGridViewTextBoxColumn BrancheID;
        private System.Windows.Forms.DataGridViewTextBoxColumn BrancheName;
        private System.Windows.Forms.DataGridViewTextBoxColumn BrancheEnm;
        private System.Windows.Forms.DataGridViewTextBoxColumn StoreID;
        private System.Windows.Forms.DataGridViewTextBoxColumn StoreName;
        private System.Windows.Forms.DataGridViewTextBoxColumn StoreEnm;
    }
}