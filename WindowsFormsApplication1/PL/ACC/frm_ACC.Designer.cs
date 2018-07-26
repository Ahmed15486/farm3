namespace WindowsFormsApplication1.PL.ACC
{
    partial class frm_ACC
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
            this.grpx_tree = new System.Windows.Forms.GroupBox();
            this.btn_Dowen = new System.Windows.Forms.Button();
            this.btn_UP = new System.Windows.Forms.Button();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.grbx_Details = new System.Windows.Forms.GroupBox();
            this.txt_ItemName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grbx_SubDetails = new System.Windows.Forms.GroupBox();
            this.btn_Unit_Add = new System.Windows.Forms.Button();
            this.txt_Balance = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.com_ACCProper = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.IID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Used = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grbx_Controls.SuspendLayout();
            this.grpx_tree.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.grbx_Details.SuspendLayout();
            this.grbx_SubDetails.SuspendLayout();
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
            this.grbx_Controls.Size = new System.Drawing.Size(784, 106);
            this.grbx_Controls.TabIndex = 41;
            this.grbx_Controls.TabStop = false;
            // 
            // btn_Save
            // 
            this.btn_Save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Save.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Save.FlatAppearance.BorderSize = 0;
            this.btn_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Save.Image = global::WindowsFormsApplication1.Properties.Resources.save_48;
            this.btn_Save.Location = new System.Drawing.Point(349, 18);
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
            this.btn_Cancel.Location = new System.Drawing.Point(187, 18);
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
            this.btn_Delete.Location = new System.Drawing.Point(268, 18);
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
            this.btn_Edit.Location = new System.Drawing.Point(430, 18);
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
            this.btn_New.Location = new System.Drawing.Point(511, 18);
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
            // grpx_tree
            // 
            this.grpx_tree.Controls.Add(this.btn_Dowen);
            this.grpx_tree.Controls.Add(this.btn_UP);
            this.grpx_tree.Controls.Add(this.dgv);
            this.grpx_tree.Dock = System.Windows.Forms.DockStyle.Left;
            this.grpx_tree.Location = new System.Drawing.Point(0, 106);
            this.grpx_tree.Name = "grpx_tree";
            this.grpx_tree.Size = new System.Drawing.Size(241, 455);
            this.grpx_tree.TabIndex = 44;
            this.grpx_tree.TabStop = false;
            // 
            // btn_Dowen
            // 
            this.btn_Dowen.Location = new System.Drawing.Point(62, 11);
            this.btn_Dowen.Name = "btn_Dowen";
            this.btn_Dowen.Size = new System.Drawing.Size(52, 35);
            this.btn_Dowen.TabIndex = 141;
            this.btn_Dowen.Text = "Dowen";
            this.btn_Dowen.UseVisualStyleBackColor = true;
            this.btn_Dowen.Click += new System.EventHandler(this.btn_Dowen_Click);
            // 
            // btn_UP
            // 
            this.btn_UP.Location = new System.Drawing.Point(120, 11);
            this.btn_UP.Name = "btn_UP";
            this.btn_UP.Size = new System.Drawing.Size(52, 35);
            this.btn_UP.TabIndex = 140;
            this.btn_UP.Text = "UP";
            this.btn_UP.UseVisualStyleBackColor = true;
            this.btn_UP.Click += new System.EventHandler(this.btn_UP_Click);
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AllowUserToOrderColumns = true;
            this.dgv.AllowUserToResizeRows = false;
            this.dgv.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IID,
            this.NName,
            this.Used});
            this.dgv.Location = new System.Drawing.Point(3, 52);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(235, 400);
            this.dgv.TabIndex = 0;
            this.dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellClick);
            this.dgv.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellDoubleClick);
            // 
            // grbx_Details
            // 
            this.grbx_Details.Controls.Add(this.txt_ItemName);
            this.grbx_Details.Controls.Add(this.label3);
            this.grbx_Details.Controls.Add(this.txt_ID);
            this.grbx_Details.Controls.Add(this.label1);
            this.grbx_Details.Dock = System.Windows.Forms.DockStyle.Top;
            this.grbx_Details.Location = new System.Drawing.Point(241, 106);
            this.grbx_Details.Name = "grbx_Details";
            this.grbx_Details.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.grbx_Details.Size = new System.Drawing.Size(543, 87);
            this.grbx_Details.TabIndex = 45;
            this.grbx_Details.TabStop = false;
            // 
            // txt_ItemName
            // 
            this.txt_ItemName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_ItemName.Location = new System.Drawing.Point(134, 52);
            this.txt_ItemName.Name = "txt_ItemName";
            this.txt_ItemName.Size = new System.Drawing.Size(319, 20);
            this.txt_ItemName.TabIndex = 111;
            this.txt_ItemName.TabStop = false;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(459, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 112;
            this.label3.Text = "أسم الحساب";
            // 
            // txt_ID
            // 
            this.txt_ID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_ID.Location = new System.Drawing.Point(355, 26);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.ReadOnly = true;
            this.txt_ID.Size = new System.Drawing.Size(98, 20);
            this.txt_ID.TabIndex = 1;
            this.txt_ID.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(459, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "الكود";
            // 
            // grbx_SubDetails
            // 
            this.grbx_SubDetails.Controls.Add(this.btn_Unit_Add);
            this.grbx_SubDetails.Controls.Add(this.txt_Balance);
            this.grbx_SubDetails.Controls.Add(this.label4);
            this.grbx_SubDetails.Controls.Add(this.com_ACCProper);
            this.grbx_SubDetails.Controls.Add(this.label11);
            this.grbx_SubDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbx_SubDetails.Location = new System.Drawing.Point(241, 193);
            this.grbx_SubDetails.Name = "grbx_SubDetails";
            this.grbx_SubDetails.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.grbx_SubDetails.Size = new System.Drawing.Size(543, 368);
            this.grbx_SubDetails.TabIndex = 142;
            this.grbx_SubDetails.TabStop = false;
            this.grbx_SubDetails.Visible = false;
            // 
            // btn_Unit_Add
            // 
            this.btn_Unit_Add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Unit_Add.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Unit_Add.FlatAppearance.BorderSize = 0;
            this.btn_Unit_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Unit_Add.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btn_Unit_Add.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_Unit_Add.Location = new System.Drawing.Point(320, 165);
            this.btn_Unit_Add.Name = "btn_Unit_Add";
            this.btn_Unit_Add.Size = new System.Drawing.Size(30, 24);
            this.btn_Unit_Add.TabIndex = 163;
            this.btn_Unit_Add.TabStop = false;
            this.btn_Unit_Add.Text = "+";
            this.btn_Unit_Add.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_Unit_Add.UseVisualStyleBackColor = false;
            this.btn_Unit_Add.Click += new System.EventHandler(this.btn_Unit_Add_Click);
            // 
            // txt_Balance
            // 
            this.txt_Balance.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Balance.Location = new System.Drawing.Point(355, 196);
            this.txt_Balance.Name = "txt_Balance";
            this.txt_Balance.ReadOnly = true;
            this.txt_Balance.Size = new System.Drawing.Size(98, 20);
            this.txt_Balance.TabIndex = 161;
            this.txt_Balance.TabStop = false;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(459, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 162;
            this.label4.Text = "الرصيد";
            // 
            // com_ACCProper
            // 
            this.com_ACCProper.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.com_ACCProper.DisplayMember = "Name";
            this.com_ACCProper.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.com_ACCProper.Enabled = false;
            this.com_ACCProper.FormattingEnabled = true;
            this.com_ACCProper.Location = new System.Drawing.Point(355, 169);
            this.com_ACCProper.Name = "com_ACCProper";
            this.com_ACCProper.Size = new System.Drawing.Size(98, 21);
            this.com_ACCProper.TabIndex = 146;
            this.com_ACCProper.ValueMember = "ID";
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(459, 172);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(42, 13);
            this.label11.TabIndex = 148;
            this.label11.Text = "الخاصية";
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
            this.NName.HeaderText = "أسم الحساب";
            this.NName.Name = "NName";
            this.NName.ReadOnly = true;
            // 
            // Used
            // 
            this.Used.DataPropertyName = "Used";
            this.Used.HeaderText = "Used";
            this.Used.Name = "Used";
            this.Used.ReadOnly = true;
            this.Used.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Used.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Used.Visible = false;
            // 
            // frm_ACC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.grbx_SubDetails);
            this.Controls.Add(this.grbx_Details);
            this.Controls.Add(this.grpx_tree);
            this.Controls.Add(this.grbx_Controls);
            this.Name = "frm_ACC";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "دليل الحسابات";
            this.Shown += new System.EventHandler(this.frm_ItemsCard_Shown);
            this.grbx_Controls.ResumeLayout(false);
            this.grpx_tree.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.grbx_Details.ResumeLayout(false);
            this.grbx_Details.PerformLayout();
            this.grbx_SubDetails.ResumeLayout(false);
            this.grbx_SubDetails.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbx_Controls;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Edit;
        private System.Windows.Forms.Button btn_New;
        private System.Windows.Forms.GroupBox grpx_tree;
        private System.Windows.Forms.Button btn_Dowen;
        private System.Windows.Forms.Button btn_UP;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.GroupBox grbx_Details;
        public System.Windows.Forms.TextBox txt_ItemName;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txt_ID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grbx_SubDetails;
        public System.Windows.Forms.TextBox txt_Balance;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox com_ACCProper;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btn_Unit_Add;
        private System.Windows.Forms.DataGridViewTextBoxColumn IID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Used;
    }
}