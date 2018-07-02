namespace WindowsFormsApplication1.PL.ACC
{
    partial class frm_JorBAdd
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
            this.com_ACC = new System.Windows.Forms.ComboBox();
            this.txt_Notes = new System.Windows.Forms.TextBox();
            this.panel_Item_Quan = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.chk_ACCInDoc = new System.Windows.Forms.CheckBox();
            this.label15 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pnl_Value = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.com_Value = new System.Windows.Forms.ComboBox();
            this.pnl_Rate = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.num_Rate = new System.Windows.Forms.NumericUpDown();
            this.pnl_Side = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.com_Side = new System.Windows.Forms.ComboBox();
            this.panel_SPrice = new System.Windows.Forms.Panel();
            this.btn_Add = new System.Windows.Forms.Button();
            this.panel_Item_Name.SuspendLayout();
            this.panel_Item_Quan.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.pnl_Value.SuspendLayout();
            this.pnl_Rate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_Rate)).BeginInit();
            this.pnl_Side.SuspendLayout();
            this.panel_SPrice.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_Item_Name
            // 
            this.panel_Item_Name.Controls.Add(this.btn_Item_Search);
            this.panel_Item_Name.Controls.Add(this.btn_Item_Edit);
            this.panel_Item_Name.Controls.Add(this.label10);
            this.panel_Item_Name.Controls.Add(this.com_ACC);
            this.panel_Item_Name.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Item_Name.Location = new System.Drawing.Point(446, 4);
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
            this.label10.Text = "أسم الحساب";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // com_ACC
            // 
            this.com_ACC.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.com_ACC.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.com_ACC.BackColor = System.Drawing.SystemColors.Window;
            this.com_ACC.DisplayMember = "Name";
            this.com_ACC.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.com_ACC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.com_ACC.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.com_ACC.FormattingEnabled = true;
            this.com_ACC.Location = new System.Drawing.Point(0, 44);
            this.com_ACC.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.com_ACC.Name = "com_ACC";
            this.com_ACC.Size = new System.Drawing.Size(200, 22);
            this.com_ACC.TabIndex = 47;
            this.com_ACC.Tag = " ";
            this.com_ACC.ValueMember = "ID";
            this.com_ACC.SelectedIndexChanged += new System.EventHandler(this.com_Item_Name_SelectedIndexChanged);
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
            this.txt_Notes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_CPrice_KeyPress);
            // 
            // panel_Item_Quan
            // 
            this.panel_Item_Quan.Controls.Add(this.label11);
            this.panel_Item_Quan.Controls.Add(this.chk_ACCInDoc);
            this.panel_Item_Quan.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Item_Quan.Location = new System.Drawing.Point(327, 4);
            this.panel_Item_Quan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel_Item_Quan.Name = "panel_Item_Quan";
            this.panel_Item_Quan.Size = new System.Drawing.Size(113, 66);
            this.panel_Item_Quan.TabIndex = 69;
            // 
            // label11
            // 
            this.label11.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label11.Location = new System.Drawing.Point(0, 18);
            this.label11.Name = "label11";
            this.label11.Padding = new System.Windows.Forms.Padding(0, 0, 0, 6);
            this.label11.Size = new System.Drawing.Size(113, 34);
            this.label11.TabIndex = 46;
            this.label11.Text = "الحساب بالسند";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chk_ACCInDoc
            // 
            this.chk_ACCInDoc.AutoSize = true;
            this.chk_ACCInDoc.Checked = true;
            this.chk_ACCInDoc.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_ACCInDoc.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.chk_ACCInDoc.Location = new System.Drawing.Point(0, 52);
            this.chk_ACCInDoc.Name = "chk_ACCInDoc";
            this.chk_ACCInDoc.Size = new System.Drawing.Size(113, 14);
            this.chk_ACCInDoc.TabIndex = 47;
            this.chk_ACCInDoc.UseVisualStyleBackColor = true;
            this.chk_ACCInDoc.CheckedChanged += new System.EventHandler(this.chk_ACCInDoc_CheckedChanged);
            // 
            // label15
            // 
            this.label15.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label15.Location = new System.Drawing.Point(0, 10);
            this.label15.Name = "label15";
            this.label15.Padding = new System.Windows.Forms.Padding(0, 0, 0, 6);
            this.label15.Size = new System.Drawing.Size(300, 34);
            this.label15.TabIndex = 46;
            this.label15.Text = "بيان";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.pnl_Side);
            this.flowLayoutPanel1.Controls.Add(this.pnl_Value);
            this.flowLayoutPanel1.Controls.Add(this.pnl_Rate);
            this.flowLayoutPanel1.Controls.Add(this.panel_Item_Name);
            this.flowLayoutPanel1.Controls.Add(this.panel_Item_Quan);
            this.flowLayoutPanel1.Controls.Add(this.panel_SPrice);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1030, 77);
            this.flowLayoutPanel1.TabIndex = 7;
            this.flowLayoutPanel1.WrapContents = false;
            // 
            // pnl_Value
            // 
            this.pnl_Value.Controls.Add(this.label1);
            this.pnl_Value.Controls.Add(this.com_Value);
            this.pnl_Value.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Value.Location = new System.Drawing.Point(771, 4);
            this.pnl_Value.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnl_Value.Name = "pnl_Value";
            this.pnl_Value.Size = new System.Drawing.Size(150, 66);
            this.pnl_Value.TabIndex = 73;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Right;
            this.label1.Location = new System.Drawing.Point(5, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 6);
            this.label1.Size = new System.Drawing.Size(145, 44);
            this.label1.TabIndex = 46;
            this.label1.Text = "القيمة";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // com_Value
            // 
            this.com_Value.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.com_Value.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.com_Value.BackColor = System.Drawing.SystemColors.Window;
            this.com_Value.DisplayMember = "Name";
            this.com_Value.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.com_Value.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.com_Value.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.com_Value.FormattingEnabled = true;
            this.com_Value.Location = new System.Drawing.Point(0, 44);
            this.com_Value.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.com_Value.Name = "com_Value";
            this.com_Value.Size = new System.Drawing.Size(150, 22);
            this.com_Value.TabIndex = 47;
            this.com_Value.Tag = " ";
            this.com_Value.ValueMember = "ID";
            // 
            // pnl_Rate
            // 
            this.pnl_Rate.Controls.Add(this.label2);
            this.pnl_Rate.Controls.Add(this.num_Rate);
            this.pnl_Rate.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Rate.Location = new System.Drawing.Point(652, 4);
            this.pnl_Rate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnl_Rate.Name = "pnl_Rate";
            this.pnl_Rate.Size = new System.Drawing.Size(113, 66);
            this.pnl_Rate.TabIndex = 74;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label2.Location = new System.Drawing.Point(0, 10);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(0, 0, 0, 6);
            this.label2.Size = new System.Drawing.Size(113, 34);
            this.label2.TabIndex = 46;
            this.label2.Text = "النسبة";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // num_Rate
            // 
            this.num_Rate.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.num_Rate.Location = new System.Drawing.Point(0, 44);
            this.num_Rate.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_Rate.Name = "num_Rate";
            this.num_Rate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.num_Rate.Size = new System.Drawing.Size(113, 22);
            this.num_Rate.TabIndex = 47;
            this.num_Rate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.num_Rate.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // pnl_Side
            // 
            this.pnl_Side.Controls.Add(this.label3);
            this.pnl_Side.Controls.Add(this.com_Side);
            this.pnl_Side.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Side.Location = new System.Drawing.Point(927, 4);
            this.pnl_Side.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnl_Side.Name = "pnl_Side";
            this.pnl_Side.Size = new System.Drawing.Size(100, 66);
            this.pnl_Side.TabIndex = 75;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Right;
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(0, 0, 0, 6);
            this.label3.Size = new System.Drawing.Size(97, 44);
            this.label3.TabIndex = 46;
            this.label3.Text = "الجانب";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // com_Side
            // 
            this.com_Side.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.com_Side.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.com_Side.BackColor = System.Drawing.SystemColors.Window;
            this.com_Side.DisplayMember = "Name";
            this.com_Side.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.com_Side.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.com_Side.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.com_Side.FormattingEnabled = true;
            this.com_Side.Location = new System.Drawing.Point(0, 44);
            this.com_Side.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.com_Side.Name = "com_Side";
            this.com_Side.Size = new System.Drawing.Size(100, 22);
            this.com_Side.TabIndex = 47;
            this.com_Side.Tag = " ";
            this.com_Side.ValueMember = "ID";
            // 
            // panel_SPrice
            // 
            this.panel_SPrice.Controls.Add(this.label15);
            this.panel_SPrice.Controls.Add(this.txt_Notes);
            this.panel_SPrice.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_SPrice.Location = new System.Drawing.Point(21, 4);
            this.panel_SPrice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel_SPrice.Name = "panel_SPrice";
            this.panel_SPrice.Size = new System.Drawing.Size(300, 66);
            this.panel_SPrice.TabIndex = 72;
            // 
            // btn_Add
            // 
            this.btn_Add.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_Add.FlatAppearance.BorderSize = 0;
            this.btn_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Add.ImageKey = "New";
            this.btn_Add.Location = new System.Drawing.Point(0, 74);
            this.btn_Add.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(1030, 35);
            this.btn_Add.TabIndex = 6;
            this.btn_Add.Text = "+ إضافة";
            this.btn_Add.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // frm_JorBAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 109);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.btn_Add);
            this.Font = new System.Drawing.Font("Tahoma", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_JorBAdd";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Shown += new System.EventHandler(this.frm_OpenAdd_Shown);
            this.panel_Item_Name.ResumeLayout(false);
            this.panel_Item_Quan.ResumeLayout(false);
            this.panel_Item_Quan.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.pnl_Value.ResumeLayout(false);
            this.pnl_Rate.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.num_Rate)).EndInit();
            this.pnl_Side.ResumeLayout(false);
            this.panel_SPrice.ResumeLayout(false);
            this.panel_SPrice.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_Item_Name;
        public System.Windows.Forms.Label label10;
        public System.Windows.Forms.ComboBox com_ACC;
        public System.Windows.Forms.TextBox txt_Notes;
        private System.Windows.Forms.Panel panel_Item_Quan;
        public System.Windows.Forms.Label label11;
        public System.Windows.Forms.Label label15;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel_SPrice;
        public System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Item_Search;
        private System.Windows.Forms.Button btn_Item_Edit;
        private System.Windows.Forms.Panel pnl_Value;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox com_Value;
        private System.Windows.Forms.Panel pnl_Rate;
        public System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnl_Side;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.ComboBox com_Side;
        public System.Windows.Forms.CheckBox chk_ACCInDoc;
        public System.Windows.Forms.NumericUpDown num_Rate;
    }
}