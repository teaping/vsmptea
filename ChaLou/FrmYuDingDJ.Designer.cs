namespace ChaLou
{
    partial class FrmYuDingDJ
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvbk = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbsd = new System.Windows.Forms.ComboBox();
            this.cmbbh = new System.Windows.Forms.ComboBox();
            this.cmbgk = new System.Windows.Forms.ComboBox();
            this.txtbz = new System.Windows.Forms.TextBox();
            this.txtbl = new System.Windows.Forms.TextBox();
            this.txtdh = new System.Windows.Forms.TextBox();
            this.txtyd = new System.Windows.Forms.TextBox();
            this.txtxm = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labbkxm = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.butbc = new System.Windows.Forms.Button();
            this.butqx = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvbk)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.cmbsd);
            this.panel1.Controls.Add(this.cmbbh);
            this.panel1.Controls.Add(this.cmbgk);
            this.panel1.Controls.Add(this.txtbz);
            this.panel1.Controls.Add(this.txtbl);
            this.panel1.Controls.Add(this.txtdh);
            this.panel1.Controls.Add(this.txtyd);
            this.panel1.Controls.Add(this.txtxm);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.labbkxm);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(585, 373);
            this.panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvbk);
            this.groupBox1.Location = new System.Drawing.Point(195, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(385, 187);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "预定餐台的宾客";
            // 
            // dgvbk
            // 
            this.dgvbk.AllowUserToAddRows = false;
            this.dgvbk.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvbk.BackgroundColor = System.Drawing.Color.White;
            this.dgvbk.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvbk.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgvbk.Location = new System.Drawing.Point(6, 20);
            this.dgvbk.Name = "dgvbk";
            this.dgvbk.RowHeadersVisible = false;
            this.dgvbk.RowTemplate.Height = 23;
            this.dgvbk.Size = new System.Drawing.Size(379, 161);
            this.dgvbk.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "xm";
            this.Column1.HeaderText = "宾客姓名";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "blsj";
            this.Column2.HeaderText = "预定时间";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "dh";
            this.Column3.HeaderText = "联系电话";
            this.Column3.Name = "Column3";
            // 
            // cmbsd
            // 
            this.cmbsd.FormattingEnabled = true;
            this.cmbsd.Items.AddRange(new object[] {
            "中午",
            "下午"});
            this.cmbsd.Location = new System.Drawing.Point(81, 140);
            this.cmbsd.Name = "cmbsd";
            this.cmbsd.Size = new System.Drawing.Size(99, 20);
            this.cmbsd.TabIndex = 3;
            this.cmbsd.SelectedIndexChanged += new System.EventHandler(this.cmbsd_SelectedIndexChanged);
            // 
            // cmbbh
            // 
            this.cmbbh.FormattingEnabled = true;
            this.cmbbh.Location = new System.Drawing.Point(81, 114);
            this.cmbbh.Name = "cmbbh";
            this.cmbbh.Size = new System.Drawing.Size(99, 20);
            this.cmbbh.TabIndex = 3;
            this.cmbbh.SelectedIndexChanged += new System.EventHandler(this.cmbbh_SelectedIndexChanged);
            // 
            // cmbgk
            // 
            this.cmbgk.FormattingEnabled = true;
            this.cmbgk.Items.AddRange(new object[] {
            "大厅",
            "大包房",
            "包房"});
            this.cmbgk.Location = new System.Drawing.Point(80, 88);
            this.cmbgk.Name = "cmbgk";
            this.cmbgk.Size = new System.Drawing.Size(99, 20);
            this.cmbgk.TabIndex = 3;
            this.cmbgk.SelectedIndexChanged += new System.EventHandler(this.cmbgk_SelectedIndexChanged);
            // 
            // txtbz
            // 
            this.txtbz.Location = new System.Drawing.Point(80, 238);
            this.txtbz.Multiline = true;
            this.txtbz.Name = "txtbz";
            this.txtbz.Size = new System.Drawing.Size(516, 111);
            this.txtbz.TabIndex = 2;
            // 
            // txtbl
            // 
            this.txtbl.Location = new System.Drawing.Point(81, 203);
            this.txtbl.Name = "txtbl";
            this.txtbl.Size = new System.Drawing.Size(100, 21);
            this.txtbl.TabIndex = 2;
            // 
            // txtdh
            // 
            this.txtdh.Location = new System.Drawing.Point(80, 61);
            this.txtdh.Name = "txtdh";
            this.txtdh.Size = new System.Drawing.Size(100, 21);
            this.txtdh.TabIndex = 2;
            // 
            // txtyd
            // 
            this.txtyd.Location = new System.Drawing.Point(81, 174);
            this.txtyd.Name = "txtyd";
            this.txtyd.Size = new System.Drawing.Size(100, 21);
            this.txtyd.TabIndex = 2;
            // 
            // txtxm
            // 
            this.txtxm.Location = new System.Drawing.Point(80, 32);
            this.txtxm.Name = "txtxm";
            this.txtxm.Size = new System.Drawing.Size(100, 21);
            this.txtxm.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(33, 238);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 12);
            this.label9.TabIndex = 1;
            this.label9.Text = "备注：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 177);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 1;
            this.label7.Text = "预抵时间：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 207);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 12);
            this.label8.TabIndex = 1;
            this.label8.Text = "保留时间到：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 1;
            this.label4.Text = "预定规格：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 1;
            this.label6.Text = "预定时段：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 1;
            this.label5.Text = "餐台编号：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "联系电话：";
            // 
            // labbkxm
            // 
            this.labbkxm.AutoSize = true;
            this.labbkxm.Location = new System.Drawing.Point(18, 35);
            this.labbkxm.Name = "labbkxm";
            this.labbkxm.Size = new System.Drawing.Size(65, 12);
            this.labbkxm.TabIndex = 1;
            this.labbkxm.Text = "宾客姓名：";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.GreenYellow;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(-1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(586, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "基本预定信息";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // butbc
            // 
            this.butbc.Location = new System.Drawing.Point(93, 413);
            this.butbc.Name = "butbc";
            this.butbc.Size = new System.Drawing.Size(75, 23);
            this.butbc.TabIndex = 1;
            this.butbc.Text = "保存";
            this.butbc.UseVisualStyleBackColor = true;
            this.butbc.Click += new System.EventHandler(this.butbc_Click);
            // 
            // butqx
            // 
            this.butqx.Location = new System.Drawing.Point(380, 413);
            this.butqx.Name = "butqx";
            this.butqx.Size = new System.Drawing.Size(75, 23);
            this.butqx.TabIndex = 1;
            this.butqx.Text = "取消";
            this.butqx.UseVisualStyleBackColor = true;
            this.butqx.Click += new System.EventHandler(this.butqx_Click);
            // 
            // FrmYuDingDJ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 454);
            this.Controls.Add(this.butqx);
            this.Controls.Add(this.butbc);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmYuDingDJ";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "预定登记";
            this.Load += new System.EventHandler(this.FrmYuDingDJ_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvbk)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmbsd;
        private System.Windows.Forms.ComboBox cmbbh;
        private System.Windows.Forms.ComboBox cmbgk;
        private System.Windows.Forms.TextBox txtbz;
        private System.Windows.Forms.TextBox txtdh;
        private System.Windows.Forms.TextBox txtxm;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labbkxm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvbk;
        private System.Windows.Forms.Button butbc;
        private System.Windows.Forms.Button butqx;
        private System.Windows.Forms.TextBox txtbl;
        private System.Windows.Forms.TextBox txtyd;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}