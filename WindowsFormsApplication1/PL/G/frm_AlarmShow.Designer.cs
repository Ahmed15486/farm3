namespace WindowsFormsApplication1.PL.G
{
    partial class frm_AlarmShow
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
            this.dgv = new System.Windows.Forms.DataGridView();
            this.Tat3eemShowID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AlarmID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AlarmName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Reason = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WithoutItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemsNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OK = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btn_Tat3eemAll = new System.Windows.Forms.Button();
            this.btn_OK = new System.Windows.Forms.Button();
            this.btn_SelectAll = new System.Windows.Forms.Button();
            this.btn_CancelAll = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AllowUserToOrderColumns = true;
            this.dgv.AllowUserToResizeRows = false;
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv.BackgroundColor = System.Drawing.Color.LightGray;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Tat3eemShowID,
            this.AlarmID,
            this.AlarmName,
            this.Reason,
            this.WithoutItem,
            this.IID,
            this.ItemsNo,
            this.NName,
            this.Date,
            this.OK});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgv.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgv.Location = new System.Drawing.Point(0, 0);
            this.dgv.Name = "dgv";
            this.dgv.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgv.RowHeadersVisible = false;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(786, 425);
            this.dgv.TabIndex = 1;
            this.dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellClick);
            this.dgv.SelectionChanged += new System.EventHandler(this.dgv_SelectionChanged);
            // 
            // Tat3eemShowID
            // 
            this.Tat3eemShowID.DataPropertyName = "Tat3eemShowID";
            this.Tat3eemShowID.HeaderText = "Tat3eemShowID";
            this.Tat3eemShowID.Name = "Tat3eemShowID";
            this.Tat3eemShowID.Visible = false;
            // 
            // AlarmID
            // 
            this.AlarmID.DataPropertyName = "AlarmID";
            this.AlarmID.FillWeight = 24.25219F;
            this.AlarmID.HeaderText = "كود التنبيه";
            this.AlarmID.Name = "AlarmID";
            // 
            // AlarmName
            // 
            this.AlarmName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.AlarmName.DataPropertyName = "Tat3eemName";
            this.AlarmName.FillWeight = 82.23953F;
            this.AlarmName.HeaderText = "أسم التنبيه";
            this.AlarmName.Name = "AlarmName";
            // 
            // Reason
            // 
            this.Reason.DataPropertyName = "ReasonString";
            this.Reason.HeaderText = "سبب التنبيه";
            this.Reason.Name = "Reason";
            // 
            // WithoutItem
            // 
            this.WithoutItem.DataPropertyName = "WithoutItem";
            this.WithoutItem.HeaderText = "WithoutItem";
            this.WithoutItem.Name = "WithoutItem";
            this.WithoutItem.Visible = false;
            // 
            // IID
            // 
            this.IID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.IID.DataPropertyName = "ItemsID";
            this.IID.FillWeight = 101.5228F;
            this.IID.HeaderText = "الكود";
            this.IID.Name = "IID";
            this.IID.Visible = false;
            this.IID.Width = 50;
            // 
            // ItemsNo
            // 
            this.ItemsNo.DataPropertyName = "ItemsNo";
            this.ItemsNo.FillWeight = 31.97324F;
            this.ItemsNo.HeaderText = "رقم المنتج";
            this.ItemsNo.Name = "ItemsNo";
            // 
            // NName
            // 
            this.NName.DataPropertyName = "ItemsName";
            this.NName.FillWeight = 75F;
            this.NName.HeaderText = "أسم المنتج";
            this.NName.Name = "NName";
            // 
            // Date
            // 
            this.Date.DataPropertyName = "AlarmDate";
            this.Date.FillWeight = 31.7035F;
            this.Date.HeaderText = "التاريخ";
            this.Date.Name = "Date";
            // 
            // OK
            // 
            this.OK.DataPropertyName = "OK";
            this.OK.FillWeight = 16.85141F;
            this.OK.HeaderText = "اختيار";
            this.OK.Name = "OK";
            // 
            // btn_Tat3eemAll
            // 
            this.btn_Tat3eemAll.Location = new System.Drawing.Point(12, 450);
            this.btn_Tat3eemAll.Name = "btn_Tat3eemAll";
            this.btn_Tat3eemAll.Size = new System.Drawing.Size(93, 30);
            this.btn_Tat3eemAll.TabIndex = 2;
            this.btn_Tat3eemAll.Text = "تطعيم";
            this.btn_Tat3eemAll.UseVisualStyleBackColor = true;
            this.btn_Tat3eemAll.Click += new System.EventHandler(this.btn_Tat3eemAll_Click);
            // 
            // btn_OK
            // 
            this.btn_OK.Location = new System.Drawing.Point(111, 450);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(93, 30);
            this.btn_OK.TabIndex = 3;
            this.btn_OK.Text = "إلغاء التنبيهات";
            this.btn_OK.UseVisualStyleBackColor = true;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // btn_SelectAll
            // 
            this.btn_SelectAll.Location = new System.Drawing.Point(582, 450);
            this.btn_SelectAll.Name = "btn_SelectAll";
            this.btn_SelectAll.Size = new System.Drawing.Size(93, 30);
            this.btn_SelectAll.TabIndex = 4;
            this.btn_SelectAll.Text = "اختيار الجميع";
            this.btn_SelectAll.UseVisualStyleBackColor = true;
            this.btn_SelectAll.Click += new System.EventHandler(this.btn_SelectAll_Click);
            // 
            // btn_CancelAll
            // 
            this.btn_CancelAll.Location = new System.Drawing.Point(681, 450);
            this.btn_CancelAll.Name = "btn_CancelAll";
            this.btn_CancelAll.Size = new System.Drawing.Size(93, 30);
            this.btn_CancelAll.TabIndex = 5;
            this.btn_CancelAll.Text = "إلغاء الجميع";
            this.btn_CancelAll.UseVisualStyleBackColor = true;
            this.btn_CancelAll.Click += new System.EventHandler(this.btn_CancelAll_Click);
            // 
            // frm_AlarmShow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 492);
            this.Controls.Add(this.btn_CancelAll);
            this.Controls.Add(this.btn_SelectAll);
            this.Controls.Add(this.btn_OK);
            this.Controls.Add(this.btn_Tat3eemAll);
            this.Controls.Add(this.dgv);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frm_AlarmShow";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "التنبيهات";
            this.Shown += new System.EventHandler(this.frm_AlarmShow_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button btn_Tat3eemAll;
        private System.Windows.Forms.Button btn_OK;
        private System.Windows.Forms.Button btn_SelectAll;
        private System.Windows.Forms.Button btn_CancelAll;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tat3eemShowID;
        private System.Windows.Forms.DataGridViewTextBoxColumn AlarmID;
        private System.Windows.Forms.DataGridViewTextBoxColumn AlarmName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Reason;
        private System.Windows.Forms.DataGridViewTextBoxColumn WithoutItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn IID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemsNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn NName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewCheckBoxColumn OK;
    }
}