namespace WindowsFormsApplication1.PL.ACC
{
    partial class frm_JorAdd
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
            this.panel_Item_Name = new System.Windows.Forms.Panel();
            this.btn_Item_Search = new System.Windows.Forms.Button();
            this.btn_Item_Edit = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.com_Acc = new System.Windows.Forms.ComboBox();
            this.txt_Credit = new System.Windows.Forms.TextBox();
            this.panel_Item_Quan = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_Debit = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel_SPrice = new System.Windows.Forms.Panel();
            this.btn_Add = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Notes = new System.Windows.Forms.TextBox();
            this.panel_Item_Name.SuspendLayout();
            this.panel_Item_Quan.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel_SPrice.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_Item_Name
            // 
            this.panel_Item_Name.Controls.Add(this.btn_Item_Search);
            this.panel_Item_Name.Controls.Add(this.btn_Item_Edit);
            this.panel_Item_Name.Controls.Add(this.label10);
            this.panel_Item_Name.Controls.Add(this.com_Acc);
            this.panel_Item_Name.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Item_Name.Location = new System.Drawing.Point(312, 4);
            this.panel_Item_Name.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel_Item_Name.Name = "panel_Item_Name";
            this.panel_Item_Name.Size = new System.Drawing.Size(200, 66);
            this.panel_Item_Name.TabIndex = 68;
            // 
            // btn_Item_Search
            // 
            this.btn_Item_Search.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_Item_Search.Image = global::WindowsFormsApplication1.Properties.Resources.Search_16;
            this.btn_Item_Search.Location = new System.Drawing.Point(27, 0);
            this.btn_Item_Search.Name = "btn_Item_Search";
            this.btn_Item_Search.Size = new System.Drawing.Size(27, 44);
            this.btn_Item_Search.TabIndex = 48;
            this.btn_Item_Search.UseVisualStyleBackColor = true;
            this.btn_Item_Search.Click += new System.EventHandler(this.btn_Item_Search_Click);
            // 
            // btn_Item_Edit
            // 
            this.btn_Item_Edit.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_Item_Edit.Image = global::WindowsFormsApplication1.Properties.Resources.Edit_16;
            this.btn_Item_Edit.Location = new System.Drawing.Point(0, 0);
            this.btn_Item_Edit.Name = "btn_Item_Edit";
            this.btn_Item_Edit.Size = new System.Drawing.Size(27, 44);
            this.btn_Item_Edit.TabIndex = 49;
            this.btn_Item_Edit.UseVisualStyleBackColor = true;
            this.btn_Item_Edit.Click += new System.EventHandler(this.btn_Item_Edit_Click);
            // 
            // label10
            // 
            this.label10.Dock = System.Windows.Forms.DockStyle.Right;
            this.label10.Location = new System.Drawing.Point(55, 0);
            this.label10.Name = "label10";
            this.label10.Padding = new System.Windows.Forms.Padding(0, 0, 0, 6);
            this.label10.Size = new System.Drawing.Size(145, 44);
            this.label10.TabIndex = 46;
            this.label10.Text = "أسم الصنف";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // com_Acc
            // 
            this.com_Acc.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.com_Acc.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.com_Acc.BackColor = System.Drawing.SystemColors.Window;
            this.com_Acc.DisplayMember = "Name";
            this.com_Acc.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.com_Acc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.com_Acc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.com_Acc.FormattingEnabled = true;
            this.com_Acc.Location = new System.Drawing.Point(0, 44);
            this.com_Acc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.com_Acc.Name = "com_Acc";
            this.com_Acc.Size = new System.Drawing.Size(200, 22);
            this.com_Acc.TabIndex = 47;
            this.com_Acc.Tag = " ";
            this.com_Acc.ValueMember = "ID";
            this.com_Acc.SelectedIndexChanged += new System.EventHandler(this.com_Item_Name_SelectedIndexChanged);
            // 
            // txt_Credit
            // 
            this.txt_Credit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txt_Credit.Location = new System.Drawing.Point(0, 44);
            this.txt_Credit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_Credit.Name = "txt_Credit";
            this.txt_Credit.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_Credit.Size = new System.Drawing.Size(113, 22);
            this.txt_Credit.TabIndex = 45;
            this.txt_Credit.Tag = " ";
            this.txt_Credit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_Credit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_CPrice_KeyPress);
            // 
            // panel_Item_Quan
            // 
            this.panel_Item_Quan.Controls.Add(this.label11);
            this.panel_Item_Quan.Controls.Add(this.txt_Debit);
            this.panel_Item_Quan.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Item_Quan.Location = new System.Drawing.Point(637, 4);
            this.panel_Item_Quan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel_Item_Quan.Name = "panel_Item_Quan";
            this.panel_Item_Quan.Size = new System.Drawing.Size(113, 66);
            this.panel_Item_Quan.TabIndex = 69;
            // 
            // label11
            // 
            this.label11.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label11.Location = new System.Drawing.Point(0, 10);
            this.label11.Name = "label11";
            this.label11.Padding = new System.Windows.Forms.Padding(0, 0, 0, 6);
            this.label11.Size = new System.Drawing.Size(113, 34);
            this.label11.TabIndex = 46;
            this.label11.Text = "مدين";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_Debit
            // 
            this.txt_Debit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txt_Debit.Location = new System.Drawing.Point(0, 44);
            this.txt_Debit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_Debit.Name = "txt_Debit";
            this.txt_Debit.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_Debit.Size = new System.Drawing.Size(113, 22);
            this.txt_Debit.TabIndex = 45;
            this.txt_Debit.Tag = " ";
            this.txt_Debit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_Debit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Quan_KeyPress);
            // 
            // label15
            // 
            this.label15.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label15.Location = new System.Drawing.Point(0, 10);
            this.label15.Name = "label15";
            this.label15.Padding = new System.Windows.Forms.Padding(0, 0, 0, 6);
            this.label15.Size = new System.Drawing.Size(113, 34);
            this.label15.TabIndex = 46;
            this.label15.Text = "دائن";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.panel_Item_Quan);
            this.flowLayoutPanel1.Controls.Add(this.panel_SPrice);
            this.flowLayoutPanel1.Controls.Add(this.panel_Item_Name);
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(753, 77);
            this.flowLayoutPanel1.TabIndex = 7;
            this.flowLayoutPanel1.WrapContents = false;
            // 
            // panel_SPrice
            // 
            this.panel_SPrice.Controls.Add(this.label15);
            this.panel_SPrice.Controls.Add(this.txt_Credit);
            this.panel_SPrice.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_SPrice.Location = new System.Drawing.Point(518, 4);
            this.panel_SPrice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel_SPrice.Name = "panel_SPrice";
            this.panel_SPrice.Size = new System.Drawing.Size(113, 66);
            this.panel_SPrice.TabIndex = 72;
            // 
            // btn_Add
            // 
            this.btn_Add.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_Add.FlatAppearance.BorderSize = 0;
            this.btn_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Add.ImageKey = "New";
            this.btn_Add.Location = new System.Drawing.Point(0, 82);
            this.btn_Add.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(753, 35);
            this.btn_Add.TabIndex = 6;
            this.btn_Add.Text = "+ إضافة";
            this.btn_Add.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txt_Notes);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(6, 4);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 66);
            this.panel1.TabIndex = 73;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.Location = new System.Drawing.Point(0, 10);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 6);
            this.label1.Size = new System.Drawing.Size(300, 34);
            this.label1.TabIndex = 46;
            this.label1.Text = "البيان";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_Notes
            // 
            this.txt_Notes.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txt_Notes.Location = new System.Drawing.Point(0, 44);
            this.txt_Notes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_Notes.Name = "txt_Notes";
            this.txt_Notes.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_Notes.Size = new System.Drawing.Size(300, 22);
            this.txt_Notes.TabIndex = 45;
            this.txt_Notes.Tag = " ";
            this.txt_Notes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frm_JorAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 117);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Font = new System.Drawing.Font("Tahoma", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_JorAdd";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Shown += new System.EventHandler(this.frm_OpenAdd_Shown);
            this.panel_Item_Name.ResumeLayout(false);
            this.panel_Item_Quan.ResumeLayout(false);
            this.panel_Item_Quan.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel_SPrice.ResumeLayout(false);
            this.panel_SPrice.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_Item_Name;
        public System.Windows.Forms.Label label10;
        public System.Windows.Forms.ComboBox com_Acc;
        public System.Windows.Forms.TextBox txt_Credit;
        private System.Windows.Forms.Panel panel_Item_Quan;
        public System.Windows.Forms.Label label11;
        public System.Windows.Forms.TextBox txt_Debit;
        public System.Windows.Forms.Label label15;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel_SPrice;
        public System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Item_Search;
        private System.Windows.Forms.Button btn_Item_Edit;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txt_Notes;
    }
}