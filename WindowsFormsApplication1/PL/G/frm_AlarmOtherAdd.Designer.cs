namespace WindowsFormsApplication1.PL.G
{
    partial class frm_AlarmOtherAdd
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
            this.label10 = new System.Windows.Forms.Label();
            this.com_Alarm = new System.Windows.Forms.ComboBox();
            this.panel_Item_Quan = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_StartDays = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel_SPrice = new System.Windows.Forms.Panel();
            this.btn_Add = new System.Windows.Forms.Button();
            this.pnl_Count = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Count = new System.Windows.Forms.TextBox();
            this.chk_Infinite = new System.Windows.Forms.CheckBox();
            this.panel_Item_Name.SuspendLayout();
            this.panel_Item_Quan.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel_SPrice.SuspendLayout();
            this.pnl_Count.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_Item_Name
            // 
            this.panel_Item_Name.Controls.Add(this.label10);
            this.panel_Item_Name.Controls.Add(this.com_Alarm);
            this.panel_Item_Name.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Item_Name.Location = new System.Drawing.Point(435, 4);
            this.panel_Item_Name.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel_Item_Name.Name = "panel_Item_Name";
            this.panel_Item_Name.Size = new System.Drawing.Size(200, 66);
            this.panel_Item_Name.TabIndex = 68;
            // 
            // label10
            // 
            this.label10.Dock = System.Windows.Forms.DockStyle.Right;
            this.label10.Location = new System.Drawing.Point(55, 0);
            this.label10.Name = "label10";
            this.label10.Padding = new System.Windows.Forms.Padding(0, 0, 0, 6);
            this.label10.Size = new System.Drawing.Size(145, 44);
            this.label10.TabIndex = 46;
            this.label10.Text = "أسم التنبيه";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // com_Alarm
            // 
            this.com_Alarm.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.com_Alarm.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.com_Alarm.BackColor = System.Drawing.SystemColors.Window;
            this.com_Alarm.DisplayMember = "Name";
            this.com_Alarm.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.com_Alarm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.com_Alarm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.com_Alarm.FormattingEnabled = true;
            this.com_Alarm.Location = new System.Drawing.Point(0, 44);
            this.com_Alarm.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.com_Alarm.Name = "com_Alarm";
            this.com_Alarm.Size = new System.Drawing.Size(200, 22);
            this.com_Alarm.TabIndex = 47;
            this.com_Alarm.Tag = " ";
            this.com_Alarm.ValueMember = "ID";
            this.com_Alarm.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.com_Item_Name_KeyPress);
            // 
            // panel_Item_Quan
            // 
            this.panel_Item_Quan.Controls.Add(this.label11);
            this.panel_Item_Quan.Controls.Add(this.txt_StartDays);
            this.panel_Item_Quan.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Item_Quan.Location = new System.Drawing.Point(316, 4);
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
            this.label11.Text = "بعد عدد الأيام";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_StartDays
            // 
            this.txt_StartDays.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txt_StartDays.Location = new System.Drawing.Point(0, 44);
            this.txt_StartDays.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_StartDays.Name = "txt_StartDays";
            this.txt_StartDays.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_StartDays.Size = new System.Drawing.Size(113, 22);
            this.txt_StartDays.TabIndex = 45;
            this.txt_StartDays.Tag = " ";
            this.txt_StartDays.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_StartDays.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Quan_KeyPress);
            // 
            // label15
            // 
            this.label15.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label15.Location = new System.Drawing.Point(0, 18);
            this.label15.Name = "label15";
            this.label15.Padding = new System.Windows.Forms.Padding(0, 0, 0, 6);
            this.label15.Size = new System.Drawing.Size(113, 34);
            this.label15.TabIndex = 46;
            this.label15.Text = "لا نهائي";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.panel_Item_Name);
            this.flowLayoutPanel1.Controls.Add(this.panel_Item_Quan);
            this.flowLayoutPanel1.Controls.Add(this.panel_SPrice);
            this.flowLayoutPanel1.Controls.Add(this.pnl_Count);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(638, 77);
            this.flowLayoutPanel1.TabIndex = 7;
            this.flowLayoutPanel1.WrapContents = false;
            // 
            // panel_SPrice
            // 
            this.panel_SPrice.Controls.Add(this.label15);
            this.panel_SPrice.Controls.Add(this.chk_Infinite);
            this.panel_SPrice.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_SPrice.Location = new System.Drawing.Point(197, 4);
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
            this.btn_Add.Location = new System.Drawing.Point(0, 91);
            this.btn_Add.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(638, 35);
            this.btn_Add.TabIndex = 6;
            this.btn_Add.Text = "+ إضافة";
            this.btn_Add.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // pnl_Count
            // 
            this.pnl_Count.Controls.Add(this.label1);
            this.pnl_Count.Controls.Add(this.txt_Count);
            this.pnl_Count.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Count.Location = new System.Drawing.Point(78, 4);
            this.pnl_Count.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnl_Count.Name = "pnl_Count";
            this.pnl_Count.Size = new System.Drawing.Size(113, 66);
            this.pnl_Count.TabIndex = 73;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.Location = new System.Drawing.Point(0, 10);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 6);
            this.label1.Size = new System.Drawing.Size(113, 34);
            this.label1.TabIndex = 46;
            this.label1.Text = "عدد المرات";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_Count
            // 
            this.txt_Count.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txt_Count.Location = new System.Drawing.Point(0, 44);
            this.txt_Count.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_Count.Name = "txt_Count";
            this.txt_Count.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_Count.Size = new System.Drawing.Size(113, 22);
            this.txt_Count.TabIndex = 45;
            this.txt_Count.Tag = " ";
            this.txt_Count.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // chk_Infinite
            // 
            this.chk_Infinite.AutoSize = true;
            this.chk_Infinite.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.chk_Infinite.Location = new System.Drawing.Point(0, 52);
            this.chk_Infinite.Name = "chk_Infinite";
            this.chk_Infinite.Size = new System.Drawing.Size(113, 14);
            this.chk_Infinite.TabIndex = 47;
            this.chk_Infinite.UseVisualStyleBackColor = true;
            this.chk_Infinite.CheckedChanged += new System.EventHandler(this.chk_Infinite_CheckedChanged);
            // 
            // frm_AlarmOtherAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 126);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.btn_Add);
            this.Font = new System.Drawing.Font("Tahoma", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_AlarmOtherAdd";
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
            this.pnl_Count.ResumeLayout(false);
            this.pnl_Count.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_Item_Name;
        public System.Windows.Forms.Label label10;
        public System.Windows.Forms.ComboBox com_Alarm;
        private System.Windows.Forms.Panel panel_Item_Quan;
        public System.Windows.Forms.Label label11;
        public System.Windows.Forms.TextBox txt_StartDays;
        public System.Windows.Forms.Label label15;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel_SPrice;
        public System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Panel pnl_Count;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txt_Count;
        private System.Windows.Forms.CheckBox chk_Infinite;
    }
}