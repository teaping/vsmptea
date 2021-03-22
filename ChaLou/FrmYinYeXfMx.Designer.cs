namespace ChaLou
{
    partial class FrmYinYeXfMx
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmYinYeXfMx));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.butcx = new System.Windows.Forms.Button();
            this.txtcxgjz = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbcxtj = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvzdxf = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvljmx = new System.Windows.Forms.DataGridView();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvzdxf)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvljmx)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(3, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(761, 387);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.butcx);
            this.tabPage1.Controls.Add(this.txtcxgjz);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.cmbcxtj);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.dgvzdxf);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(753, 361);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "在店宾客消费明细";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // butcx
            // 
            this.butcx.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.butcx.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.butcx.FlatAppearance.BorderSize = 0;
            this.butcx.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butcx.Image = ((System.Drawing.Image)(resources.GetObject("butcx.Image")));
            this.butcx.Location = new System.Drawing.Point(551, 6);
            this.butcx.Name = "butcx";
            this.butcx.Size = new System.Drawing.Size(45, 35);
            this.butcx.TabIndex = 6;
            this.butcx.UseVisualStyleBackColor = true;
            this.butcx.Click += new System.EventHandler(this.butcx_Click);
            // 
            // txtcxgjz
            // 
            this.txtcxgjz.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtcxgjz.Location = new System.Drawing.Point(454, 11);
            this.txtcxgjz.Name = "txtcxgjz";
            this.txtcxgjz.Size = new System.Drawing.Size(82, 21);
            this.txtcxgjz.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(370, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "查询关键字：";
            // 
            // cmbcxtj
            // 
            this.cmbcxtj.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmbcxtj.FormattingEnabled = true;
            this.cmbcxtj.Items.AddRange(new object[] {
            "按餐台号",
            "按消费项目"});
            this.cmbcxtj.Location = new System.Drawing.Point(254, 11);
            this.cmbcxtj.Name = "cmbcxtj";
            this.cmbcxtj.Size = new System.Drawing.Size(91, 20);
            this.cmbcxtj.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(169, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "选择查询条件：";
            // 
            // dgvzdxf
            // 
            this.dgvzdxf.AllowUserToAddRows = false;
            this.dgvzdxf.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvzdxf.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvzdxf.BackgroundColor = System.Drawing.Color.White;
            this.dgvzdxf.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvzdxf.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column6,
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column11});
            this.dgvzdxf.Location = new System.Drawing.Point(3, 70);
            this.dgvzdxf.MultiSelect = false;
            this.dgvzdxf.Name = "dgvzdxf";
            this.dgvzdxf.RowHeadersVisible = false;
            this.dgvzdxf.RowTemplate.Height = 23;
            this.dgvzdxf.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvzdxf.Size = new System.Drawing.Size(747, 291);
            this.dgvzdxf.TabIndex = 1;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "cth";
            this.Column1.HeaderText = "餐台号";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "xmmc";
            this.Column2.HeaderText = "消费项目";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "dj";
            this.Column3.HeaderText = "单价";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "zk";
            this.Column4.HeaderText = "打折比例";
            this.Column4.Name = "Column4";
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "sl";
            this.Column6.HeaderText = "数量";
            this.Column6.Name = "Column6";
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "je";
            this.Column8.HeaderText = "应收金额";
            this.Column8.Name = "Column8";
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "dcsj";
            this.Column9.HeaderText = "入账时间";
            this.Column9.Name = "Column9";
            // 
            // Column10
            // 
            this.Column10.DataPropertyName = "jzr";
            this.Column10.HeaderText = "记账人";
            this.Column10.Name = "Column10";
            // 
            // Column11
            // 
            this.Column11.DataPropertyName = "WaiterName";
            this.Column11.HeaderText = "服务生";
            this.Column11.Name = "Column11";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.GreenYellow;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(1, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(759, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "在店宾客消费明细";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgvljmx);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(753, 361);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "离店宾客消费明细";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvljmx
            // 
            this.dgvljmx.AllowUserToAddRows = false;
            this.dgvljmx.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvljmx.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvljmx.BackgroundColor = System.Drawing.Color.White;
            this.dgvljmx.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvljmx.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column5,
            this.Column7,
            this.Column12,
            this.Column13,
            this.Column14,
            this.Column15,
            this.Column16,
            this.Column17});
            this.dgvljmx.Location = new System.Drawing.Point(-4, 0);
            this.dgvljmx.MultiSelect = false;
            this.dgvljmx.Name = "dgvljmx";
            this.dgvljmx.RowHeadersVisible = false;
            this.dgvljmx.RowTemplate.Height = 23;
            this.dgvljmx.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvljmx.Size = new System.Drawing.Size(754, 358);
            this.dgvljmx.TabIndex = 0;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "cth";
            this.Column5.HeaderText = "餐台号";
            this.Column5.Name = "Column5";
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "xmmc";
            this.Column7.HeaderText = "消费项目";
            this.Column7.Name = "Column7";
            // 
            // Column12
            // 
            this.Column12.DataPropertyName = "dj";
            this.Column12.HeaderText = "单价";
            this.Column12.Name = "Column12";
            // 
            // Column13
            // 
            this.Column13.DataPropertyName = "zk";
            this.Column13.HeaderText = "折扣";
            this.Column13.Name = "Column13";
            // 
            // Column14
            // 
            this.Column14.DataPropertyName = "sl";
            this.Column14.HeaderText = "数量";
            this.Column14.Name = "Column14";
            // 
            // Column15
            // 
            this.Column15.DataPropertyName = "je";
            this.Column15.HeaderText = "应收金额";
            this.Column15.Name = "Column15";
            // 
            // Column16
            // 
            this.Column16.DataPropertyName = "dcsj";
            this.Column16.HeaderText = "入账时间";
            this.Column16.Name = "Column16";
            // 
            // Column17
            // 
            this.Column17.DataPropertyName = "jzr";
            this.Column17.HeaderText = "记账人";
            this.Column17.Name = "Column17";
            // 
            // FrmYinYeXfMx
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 401);
            this.Controls.Add(this.tabControl1);
            this.Name = "FrmYinYeXfMx";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "在店宾客消费明细";
            this.Load += new System.EventHandler(this.FrmYinYeXfMx_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvzdxf)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvljmx)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgvzdxf;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.TextBox txtcxgjz;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbcxtj;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button butcx;
        private System.Windows.Forms.DataGridView dgvljmx;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column14;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column15;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column16;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column17;
    }
}