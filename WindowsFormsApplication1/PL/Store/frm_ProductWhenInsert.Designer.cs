namespace WindowsFormsApplication1.PL.Store
{
    partial class frm_ProductWhenInsert
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.btn_Continue = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_SelectAll = new System.Windows.Forms.Button();
            this.btn_CancelAll = new System.Windows.Forms.Button();
            this.AlarmID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AlarmName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OK = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.grx = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.grx.SuspendLayout();
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
            this.AlarmID,
            this.AlarmName,
            this.NName,
            this.Quan,
            this.OK});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgv.Location = new System.Drawing.Point(0, 59);
            this.dgv.Name = "dgv";
            this.dgv.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgv.RowHeadersVisible = false;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(614, 162);
            this.dgv.TabIndex = 1;
            this.dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellClick);
            this.dgv.SelectionChanged += new System.EventHandler(this.dgv_SelectionChanged);
            // 
            // btn_Continue
            // 
            this.btn_Continue.Location = new System.Drawing.Point(12, 307);
            this.btn_Continue.Name = "btn_Continue";
            this.btn_Continue.Size = new System.Drawing.Size(93, 30);
            this.btn_Continue.TabIndex = 2;
            this.btn_Continue.Text = "استمرار";
            this.btn_Continue.UseVisualStyleBackColor = true;
            this.btn_Continue.Click += new System.EventHandler(this.btn_Tat3eemAll_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(111, 307);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(93, 30);
            this.btn_Cancel.TabIndex = 3;
            this.btn_Cancel.Text = "تراجع";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // btn_SelectAll
            // 
            this.btn_SelectAll.Location = new System.Drawing.Point(410, 307);
            this.btn_SelectAll.Name = "btn_SelectAll";
            this.btn_SelectAll.Size = new System.Drawing.Size(93, 30);
            this.btn_SelectAll.TabIndex = 4;
            this.btn_SelectAll.Text = "اختيار الجميع";
            this.btn_SelectAll.UseVisualStyleBackColor = true;
            this.btn_SelectAll.Click += new System.EventHandler(this.btn_SelectAll_Click);
            // 
            // btn_CancelAll
            // 
            this.btn_CancelAll.Location = new System.Drawing.Point(509, 307);
            this.btn_CancelAll.Name = "btn_CancelAll";
            this.btn_CancelAll.Size = new System.Drawing.Size(93, 30);
            this.btn_CancelAll.TabIndex = 5;
            this.btn_CancelAll.Text = "إلغاء الجميع";
            this.btn_CancelAll.UseVisualStyleBackColor = true;
            this.btn_CancelAll.Click += new System.EventHandler(this.btn_CancelAll_Click);
            // 
            // AlarmID
            // 
            this.AlarmID.DataPropertyName = "ID";
            this.AlarmID.FillWeight = 27.2208F;
            this.AlarmID.HeaderText = "كود التنبيه";
            this.AlarmID.Name = "AlarmID";
            // 
            // AlarmName
            // 
            this.AlarmName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.AlarmName.DataPropertyName = "Name";
            this.AlarmName.FillWeight = 92.30614F;
            this.AlarmName.HeaderText = "أسم التنبيه";
            this.AlarmName.Name = "AlarmName";
            // 
            // NName
            // 
            this.NName.DataPropertyName = "ItemName";
            this.NName.FillWeight = 84.18045F;
            this.NName.HeaderText = "أسم المنتج";
            this.NName.Name = "NName";
            // 
            // Quan
            // 
            this.Quan.DataPropertyName = "Quan";
            this.Quan.FillWeight = 20F;
            this.Quan.HeaderText = "الكمية";
            this.Quan.Name = "Quan";
            // 
            // OK
            // 
            this.OK.DataPropertyName = "OK";
            this.OK.FillWeight = 18.91412F;
            this.OK.HeaderText = "اختيار";
            this.OK.Name = "OK";
            // 
            // grx
            // 
            this.grx.Controls.Add(this.label1);
            this.grx.Dock = System.Windows.Forms.DockStyle.Top;
            this.grx.Location = new System.Drawing.Point(0, 0);
            this.grx.Name = "grx";
            this.grx.Size = new System.Drawing.Size(614, 59);
            this.grx.TabIndex = 6;
            this.grx.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(170, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(432, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "يوجد تطعيم عند التسجيل على هذه الفئة .. من فضلك قم بإزالة التطعيمات الغير مرغوب ف" +
    "يها .";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frm_ProductWhenInsert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 349);
            this.Controls.Add(this.btn_CancelAll);
            this.Controls.Add(this.btn_SelectAll);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Continue);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.grx);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frm_ProductWhenInsert";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "التنبيهات";
            this.Shown += new System.EventHandler(this.frm_AlarmShow_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.grx.ResumeLayout(false);
            this.grx.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button btn_Continue;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_SelectAll;
        private System.Windows.Forms.Button btn_CancelAll;
        private System.Windows.Forms.DataGridViewTextBoxColumn AlarmID;
        private System.Windows.Forms.DataGridViewTextBoxColumn AlarmName;
        private System.Windows.Forms.DataGridViewTextBoxColumn NName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quan;
        private System.Windows.Forms.DataGridViewCheckBoxColumn OK;
        private System.Windows.Forms.GroupBox grx;
        private System.Windows.Forms.Label label1;
    }
}