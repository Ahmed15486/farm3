namespace WindowsFormsApplication1.PL.ACC
{
    partial class frm_JorB
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
            this.grbx_Add = new System.Windows.Forms.GroupBox();
            this.btn_Add = new System.Windows.Forms.Button();
            this.com_DocType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.grpx_Head = new System.Windows.Forms.GroupBox();
            this.com_DocPayType = new System.Windows.Forms.ComboBox();
            this.lbl_DocPayType = new System.Windows.Forms.Label();
            this.grbx_Controls = new System.Windows.Forms.GroupBox();
            this.btn_Save = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.grbx_Add.SuspendLayout();
            this.grpx_Head.SuspendLayout();
            this.grbx_Controls.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToResizeColumns = false;
            this.dgv.AllowUserToResizeRows = false;
            this.dgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv.ColumnHeadersHeight = 25;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv.EnableHeadersVisualStyles = false;
            this.dgv.Location = new System.Drawing.Point(0, 239);
            this.dgv.MultiSelect = false;
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(1118, 502);
            this.dgv.TabIndex = 40;
            this.dgv.UserDeletedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.dgv_UserDeletedRow);
            // 
            // grbx_Add
            // 
            this.grbx_Add.Controls.Add(this.btn_Add);
            this.grbx_Add.Dock = System.Windows.Forms.DockStyle.Top;
            this.grbx_Add.Location = new System.Drawing.Point(0, 189);
            this.grbx_Add.Name = "grbx_Add";
            this.grbx_Add.Size = new System.Drawing.Size(1118, 50);
            this.grbx_Add.TabIndex = 39;
            this.grbx_Add.TabStop = false;
            // 
            // btn_Add
            // 
            this.btn_Add.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Add.Location = new System.Drawing.Point(3, 16);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(1112, 31);
            this.btn_Add.TabIndex = 13;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // com_DocType
            // 
            this.com_DocType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.com_DocType.DisplayMember = "Name";
            this.com_DocType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.com_DocType.FormattingEnabled = true;
            this.com_DocType.Location = new System.Drawing.Point(884, 25);
            this.com_DocType.Name = "com_DocType";
            this.com_DocType.Size = new System.Drawing.Size(148, 21);
            this.com_DocType.TabIndex = 140;
            this.com_DocType.ValueMember = "ID";
            this.com_DocType.SelectedIndexChanged += new System.EventHandler(this.com_DocType_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1038, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 141;
            this.label3.Text = "السند";
            // 
            // grpx_Head
            // 
            this.grpx_Head.Controls.Add(this.com_DocPayType);
            this.grpx_Head.Controls.Add(this.lbl_DocPayType);
            this.grpx_Head.Controls.Add(this.com_DocType);
            this.grpx_Head.Controls.Add(this.label3);
            this.grpx_Head.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpx_Head.Location = new System.Drawing.Point(0, 0);
            this.grpx_Head.Name = "grpx_Head";
            this.grpx_Head.Size = new System.Drawing.Size(1118, 83);
            this.grpx_Head.TabIndex = 37;
            this.grpx_Head.TabStop = false;
            // 
            // com_DocPayType
            // 
            this.com_DocPayType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.com_DocPayType.DisplayMember = "Name";
            this.com_DocPayType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.com_DocPayType.FormattingEnabled = true;
            this.com_DocPayType.Location = new System.Drawing.Point(658, 25);
            this.com_DocPayType.Name = "com_DocPayType";
            this.com_DocPayType.Size = new System.Drawing.Size(112, 21);
            this.com_DocPayType.TabIndex = 142;
            this.com_DocPayType.ValueMember = "ID";
            this.com_DocPayType.SelectedIndexChanged += new System.EventHandler(this.com_DocPayType_SelectedIndexChanged);
            // 
            // lbl_DocPayType
            // 
            this.lbl_DocPayType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_DocPayType.AutoSize = true;
            this.lbl_DocPayType.Location = new System.Drawing.Point(775, 28);
            this.lbl_DocPayType.Name = "lbl_DocPayType";
            this.lbl_DocPayType.Size = new System.Drawing.Size(29, 13);
            this.lbl_DocPayType.TabIndex = 143;
            this.lbl_DocPayType.Text = "النوع";
            // 
            // grbx_Controls
            // 
            this.grbx_Controls.Controls.Add(this.btn_Save);
            this.grbx_Controls.Dock = System.Windows.Forms.DockStyle.Top;
            this.grbx_Controls.Location = new System.Drawing.Point(0, 83);
            this.grbx_Controls.Name = "grbx_Controls";
            this.grbx_Controls.Size = new System.Drawing.Size(1118, 106);
            this.grbx_Controls.TabIndex = 36;
            this.grbx_Controls.TabStop = false;
            // 
            // btn_Save
            // 
            this.btn_Save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Save.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Save.FlatAppearance.BorderSize = 0;
            this.btn_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Save.Image = global::WindowsFormsApplication1.Properties.Resources.save_48;
            this.btn_Save.Location = new System.Drawing.Point(1012, 19);
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
            // frm_JorB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1118, 741);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.grbx_Add);
            this.Controls.Add(this.grbx_Controls);
            this.Controls.Add(this.grpx_Head);
            this.Name = "frm_JorB";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "بناء القيود";
            this.Shown += new System.EventHandler(this.frm_JorB_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.grbx_Add.ResumeLayout(false);
            this.grpx_Head.ResumeLayout(false);
            this.grpx_Head.PerformLayout();
            this.grbx_Controls.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.GroupBox grbx_Add;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.ComboBox com_DocType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.GroupBox grpx_Head;
        private System.Windows.Forms.GroupBox grbx_Controls;
        private System.Windows.Forms.ComboBox com_DocPayType;
        private System.Windows.Forms.Label lbl_DocPayType;
    }
}