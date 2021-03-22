namespace ChaLou
{
    partial class FrmSpjc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSpjc));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtyhmc = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvlb = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.butqr = new System.Windows.Forms.Button();
            this.dgvqd = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.buty = new System.Windows.Forms.Button();
            this.butz = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvlb)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvqd)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "寄存单号：";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(71, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "123123";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(231, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "用户名称：";
            // 
            // txtyhmc
            // 
            this.txtyhmc.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtyhmc.Location = new System.Drawing.Point(288, 6);
            this.txtyhmc.Name = "txtyhmc";
            this.txtyhmc.Size = new System.Drawing.Size(100, 21);
            this.txtyhmc.TabIndex = 1;
            this.txtyhmc.TextChanged += new System.EventHandler(this.txtyhmc_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvlb);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(14, 89);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(196, 328);
            this.panel1.TabIndex = 2;
            // 
            // dgvlb
            // 
            this.dgvlb.AllowUserToAddRows = false;
            this.dgvlb.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvlb.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvlb.BackgroundColor = System.Drawing.Color.White;
            this.dgvlb.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvlb.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgvlb.Location = new System.Drawing.Point(3, 62);
            this.dgvlb.MultiSelect = false;
            this.dgvlb.Name = "dgvlb";
            this.dgvlb.RowHeadersVisible = false;
            this.dgvlb.RowTemplate.Height = 23;
            this.dgvlb.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvlb.Size = new System.Drawing.Size(190, 263);
            this.dgvlb.TabIndex = 1;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "bh";
            this.Column1.HeaderText = "项目编号";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "mc";
            this.Column2.HeaderText = "项目名称";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "dw";
            this.Column3.HeaderText = "单位";
            this.Column3.Name = "Column3";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.BackColor = System.Drawing.Color.GreenYellow;
            this.label4.Location = new System.Drawing.Point(3, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(190, 14);
            this.label4.TabIndex = 0;
            this.label4.Text = "库存商品列表";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.butqr);
            this.panel2.Controls.Add(this.dgvqd);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(311, 89);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(216, 328);
            this.panel2.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button2.Location = new System.Drawing.Point(128, 294);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(57, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "取消";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // butqr
            // 
            this.butqr.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.butqr.Enabled = false;
            this.butqr.Location = new System.Drawing.Point(19, 294);
            this.butqr.Name = "butqr";
            this.butqr.Size = new System.Drawing.Size(57, 23);
            this.butqr.TabIndex = 2;
            this.butqr.Text = "确认";
            this.butqr.UseVisualStyleBackColor = true;
            this.butqr.Click += new System.EventHandler(this.butqr_Click);
            // 
            // dgvqd
            // 
            this.dgvqd.AllowUserToAddRows = false;
            this.dgvqd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvqd.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvqd.BackgroundColor = System.Drawing.Color.White;
            this.dgvqd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvqd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.Column4,
            this.dataGridViewTextBoxColumn3,
            this.Column5,
            this.Column6});
            this.dgvqd.Location = new System.Drawing.Point(0, 17);
            this.dgvqd.MultiSelect = false;
            this.dgvqd.Name = "dgvqd";
            this.dgvqd.RowHeadersVisible = false;
            this.dgvqd.RowTemplate.Height = 23;
            this.dgvqd.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvqd.Size = new System.Drawing.Size(216, 264);
            this.dgvqd.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "mc";
            this.dataGridViewTextBoxColumn2.HeaderText = "项目名称";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "sl";
            this.Column4.HeaderText = "数量";
            this.Column4.Name = "Column4";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "dw";
            this.dataGridViewTextBoxColumn3.HeaderText = "单位";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "yxrq";
            this.Column5.HeaderText = "有效日期";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "id";
            this.Column6.HeaderText = "id";
            this.Column6.Name = "Column6";
            this.Column6.Visible = false;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.BackColor = System.Drawing.Color.GreenYellow;
            this.label5.Location = new System.Drawing.Point(1, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(212, 14);
            this.label5.TabIndex = 0;
            this.label5.Text = "寄存商品清单";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buty
            // 
            this.buty.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buty.Image = ((System.Drawing.Image)(resources.GetObject("buty.Image")));
            this.buty.Location = new System.Drawing.Point(30, 122);
            this.buty.Name = "buty";
            this.buty.Size = new System.Drawing.Size(25, 23);
            this.buty.TabIndex = 3;
            this.buty.UseVisualStyleBackColor = true;
            this.buty.Click += new System.EventHandler(this.buty_Click);
            // 
            // butz
            // 
            this.butz.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.butz.Image = ((System.Drawing.Image)(resources.GetObject("butz.Image")));
            this.butz.Location = new System.Drawing.Point(30, 220);
            this.butz.Name = "butz";
            this.butz.Size = new System.Drawing.Size(25, 23);
            this.butz.TabIndex = 3;
            this.butz.UseVisualStyleBackColor = true;
            this.butz.Click += new System.EventHandler(this.butz_Click);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.buty);
            this.panel3.Controls.Add(this.butz);
            this.panel3.Location = new System.Drawing.Point(216, 89);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(89, 328);
            this.panel3.TabIndex = 4;
            // 
            // FrmSpjc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 418);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtyhmc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmSpjc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "商品寄存";
            this.Load += new System.EventHandler(this.FrmSpjc_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvlb)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvqd)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtyhmc;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvlb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button butqr;
        private System.Windows.Forms.DataGridView dgvqd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buty;
        private System.Windows.Forms.Button butz;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.Panel panel3;
    }
}