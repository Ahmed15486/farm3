namespace WindowsFormsApplication1.PL.Sal
{
    partial class frm_SalSearch
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_Search = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_OK = new System.Windows.Forms.Button();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.n = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(474, 368);
            this.groupBox1.TabIndex = 53;
            this.groupBox1.TabStop = false;
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AllowUserToResizeColumns = false;
            this.dgv.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.OldLace;
            this.dgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgv.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv.ColumnHeadersHeight = 40;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.No,
            this.n});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 10F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgv.Location = new System.Drawing.Point(3, 20);
            this.dgv.MultiSelect = false;
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 10F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgv.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(468, 345);
            this.dgv.TabIndex = 51;
            this.dgv.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_CellDoubleClick);
            this.dgv.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DGV_KeyDown);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_Search);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(474, 54);
            this.groupBox2.TabIndex = 54;
            this.groupBox2.TabStop = false;
            // 
            // txt_Search
            // 
            this.txt_Search.Dock = System.Windows.Forms.DockStyle.Top;
            this.txt_Search.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txt_Search.ForeColor = System.Drawing.Color.Silver;
            this.txt_Search.Location = new System.Drawing.Point(3, 20);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Size = new System.Drawing.Size(468, 27);
            this.txt_Search.TabIndex = 0;
            this.txt_Search.Text = "Search";
            this.txt_Search.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_Search.TextChanged += new System.EventHandler(this.txt_Search_TextChanged);
            this.txt_Search.Enter += new System.EventHandler(this.txt_Search_Enter);
            this.txt_Search.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Search_KeyDown);
            this.txt_Search.Leave += new System.EventHandler(this.txt_Search_Leave);
            this.txt_Search.MouseEnter += new System.EventHandler(this.txt_Search_MouseEnter);
            this.txt_Search.MouseLeave += new System.EventHandler(this.txt_Search_MouseLeave);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_OK);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox3.Location = new System.Drawing.Point(0, 408);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(474, 57);
            this.groupBox3.TabIndex = 55;
            this.groupBox3.TabStop = false;
            // 
            // btn_OK
            // 
            this.btn_OK.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_OK.FlatAppearance.BorderSize = 0;
            this.btn_OK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_OK.ImageKey = "Cancel";
            this.btn_OK.Location = new System.Drawing.Point(3, 20);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(468, 34);
            this.btn_OK.TabIndex = 53;
            this.btn_OK.Text = "موافق";
            this.btn_OK.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_OK.UseVisualStyleBackColor = true;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ID.DataPropertyName = "ID";
            this.ID.Frozen = true;
            this.ID.HeaderText = "الكود";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // No
            // 
            this.No.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.No.DataPropertyName = "No";
            this.No.HeaderText = "الرقم";
            this.No.Name = "No";
            this.No.ReadOnly = true;
            // 
            // n
            // 
            this.n.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.n.DataPropertyName = "Name";
            this.n.FillWeight = 5.686043F;
            this.n.HeaderText = "الأسم";
            this.n.Name = "n";
            this.n.ReadOnly = true;
            // 
            // frm_Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(474, 465);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Font = new System.Drawing.Font("Tahoma", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Search";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search";
            this.Shown += new System.EventHandler(this.FRM_Search_Shown);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.TextBox txt_Search;
        private System.Windows.Forms.GroupBox groupBox3;
        public System.Windows.Forms.Button btn_OK;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn No;
        private System.Windows.Forms.DataGridViewTextBoxColumn n;
    }
}