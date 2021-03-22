namespace ChaLou
{
    partial class FrmBTxs
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtcp = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtsl = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.butxgqx = new System.Windows.Forms.Button();
            this.butxgqr = new System.Windows.Forms.Button();
            this.txtxgsl = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.labxgmc = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dgwqd = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labzje = new System.Windows.Forms.Label();
            this.butbtxg = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtxsdh = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.butcdqx = new System.Windows.Forms.Button();
            this.butcdqr = new System.Windows.Forms.Button();
            this.dgvcd = new System.Windows.Forms.DataGridView();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwqd)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcd)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(229, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "添加菜品：";
            // 
            // txtcp
            // 
            this.txtcp.Location = new System.Drawing.Point(289, 22);
            this.txtcp.Name = "txtcp";
            this.txtcp.Size = new System.Drawing.Size(100, 21);
            this.txtcp.TabIndex = 1;
            this.txtcp.TextChanged += new System.EventHandler(this.txtcp_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(395, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "点菜数量：";
            // 
            // txtsl
            // 
            this.txtsl.Location = new System.Drawing.Point(455, 22);
            this.txtsl.Name = "txtsl";
            this.txtsl.Size = new System.Drawing.Size(100, 21);
            this.txtsl.TabIndex = 1;
            this.txtsl.Text = "1";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(13, 69);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(486, 306);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Controls.Add(this.dgwqd);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(478, 280);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "消费清单";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.butxgqx);
            this.panel2.Controls.Add(this.butxgqr);
            this.panel2.Controls.Add(this.txtxgsl);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.labxgmc);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(137, 76);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(165, 126);
            this.panel2.TabIndex = 1;
            this.panel2.Visible = false;
            // 
            // butxgqx
            // 
            this.butxgqx.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.butxgqx.Location = new System.Drawing.Point(103, 86);
            this.butxgqx.Name = "butxgqx";
            this.butxgqx.Size = new System.Drawing.Size(48, 23);
            this.butxgqx.TabIndex = 2;
            this.butxgqx.Text = "取消";
            this.butxgqx.UseVisualStyleBackColor = true;
            this.butxgqx.Click += new System.EventHandler(this.butxgqx_Click);
            // 
            // butxgqr
            // 
            this.butxgqr.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.butxgqr.Location = new System.Drawing.Point(24, 86);
            this.butxgqr.Name = "butxgqr";
            this.butxgqr.Size = new System.Drawing.Size(48, 23);
            this.butxgqr.TabIndex = 2;
            this.butxgqr.Text = "确认";
            this.butxgqr.UseVisualStyleBackColor = true;
            this.butxgqr.Click += new System.EventHandler(this.butxgqr_Click);
            // 
            // txtxgsl
            // 
            this.txtxgsl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtxgsl.Location = new System.Drawing.Point(79, 50);
            this.txtxgsl.Name = "txtxgsl";
            this.txtxgsl.Size = new System.Drawing.Size(47, 21);
            this.txtxgsl.TabIndex = 1;
            this.txtxgsl.Text = "1";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 0;
            this.label6.Text = "点菜数量：";
            // 
            // labxgmc
            // 
            this.labxgmc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labxgmc.AutoSize = true;
            this.labxgmc.ForeColor = System.Drawing.Color.Red;
            this.labxgmc.Location = new System.Drawing.Point(85, 22);
            this.labxgmc.Name = "labxgmc";
            this.labxgmc.Size = new System.Drawing.Size(41, 12);
            this.labxgmc.TabIndex = 0;
            this.labxgmc.Text = "label5";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "项目名称：";
            // 
            // dgwqd
            // 
            this.dgwqd.AllowUserToAddRows = false;
            this.dgwqd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgwqd.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwqd.BackgroundColor = System.Drawing.Color.White;
            this.dgwqd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwqd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.dgwqd.Location = new System.Drawing.Point(3, 3);
            this.dgwqd.MultiSelect = false;
            this.dgwqd.Name = "dgwqd";
            this.dgwqd.RowHeadersVisible = false;
            this.dgwqd.RowTemplate.Height = 23;
            this.dgwqd.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwqd.Size = new System.Drawing.Size(472, 277);
            this.dgwqd.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "mc";
            this.Column1.HeaderText = "项目名称";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "dj";
            this.Column2.HeaderText = "单价";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "dabl";
            this.Column3.HeaderText = "打折比例";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "sl";
            this.Column4.HeaderText = "数量";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "jine";
            this.Column5.HeaderText = "金额";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "jzr";
            this.Column6.HeaderText = "记账人";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "rzsj";
            this.Column7.HeaderText = "入账时间";
            this.Column7.Name = "Column7";
            // 
            // labzje
            // 
            this.labzje.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.labzje.AutoSize = true;
            this.labzje.ForeColor = System.Drawing.Color.Red;
            this.labzje.Location = new System.Drawing.Point(278, 374);
            this.labzje.Name = "labzje";
            this.labzje.Size = new System.Drawing.Size(11, 12);
            this.labzje.TabIndex = 3;
            this.labzje.Text = "0";
            // 
            // butbtxg
            // 
            this.butbtxg.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.butbtxg.Location = new System.Drawing.Point(517, 94);
            this.butbtxg.Name = "butbtxg";
            this.butbtxg.Size = new System.Drawing.Size(75, 23);
            this.butbtxg.TabIndex = 4;
            this.butbtxg.Text = "修改菜品";
            this.butbtxg.UseVisualStyleBackColor = true;
            this.butbtxg.Click += new System.EventHandler(this.butbtxg_Click);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button2.Location = new System.Drawing.Point(517, 123);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "删除菜品";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button4
            // 
            this.button4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button4.Location = new System.Drawing.Point(517, 293);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 4;
            this.button4.Text = "开始结账";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button5.Location = new System.Drawing.Point(517, 333);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 4;
            this.button5.Text = "取消退出";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "单号：";
            // 
            // txtxsdh
            // 
            this.txtxsdh.Location = new System.Drawing.Point(69, 22);
            this.txtxsdh.Name = "txtxsdh";
            this.txtxsdh.Size = new System.Drawing.Size(100, 21);
            this.txtxsdh.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.Controls.Add(this.butcdqx);
            this.panel1.Controls.Add(this.butcdqr);
            this.panel1.Controls.Add(this.dgvcd);
            this.panel1.Location = new System.Drawing.Point(289, 46);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(268, 244);
            this.panel1.TabIndex = 5;
            this.panel1.Visible = false;
            // 
            // butcdqx
            // 
            this.butcdqx.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.butcdqx.Location = new System.Drawing.Point(155, 204);
            this.butcdqx.Name = "butcdqx";
            this.butcdqx.Size = new System.Drawing.Size(63, 23);
            this.butcdqx.TabIndex = 1;
            this.butcdqx.Text = "取消";
            this.butcdqx.UseVisualStyleBackColor = true;
            this.butcdqx.Click += new System.EventHandler(this.butcdqx_Click);
            // 
            // butcdqr
            // 
            this.butcdqr.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.butcdqr.Location = new System.Drawing.Point(37, 204);
            this.butcdqr.Name = "butcdqr";
            this.butcdqr.Size = new System.Drawing.Size(63, 23);
            this.butcdqr.TabIndex = 1;
            this.butcdqr.Text = "确认";
            this.butcdqr.UseVisualStyleBackColor = true;
            this.butcdqr.Click += new System.EventHandler(this.butcdqr_Click);
            // 
            // dgvcd
            // 
            this.dgvcd.AllowUserToAddRows = false;
            this.dgvcd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvcd.BackgroundColor = System.Drawing.Color.White;
            this.dgvcd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvcd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column11});
            this.dgvcd.Location = new System.Drawing.Point(4, 4);
            this.dgvcd.MultiSelect = false;
            this.dgvcd.Name = "dgvcd";
            this.dgvcd.RowHeadersVisible = false;
            this.dgvcd.RowTemplate.Height = 23;
            this.dgvcd.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvcd.Size = new System.Drawing.Size(264, 194);
            this.dgvcd.TabIndex = 0;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "xmbh";
            this.Column8.HeaderText = "项目编号";
            this.Column8.Name = "Column8";
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "mc";
            this.Column9.HeaderText = "项目名称";
            this.Column9.Name = "Column9";
            // 
            // Column10
            // 
            this.Column10.DataPropertyName = "dj";
            this.Column10.HeaderText = "单价";
            this.Column10.Name = "Column10";
            // 
            // Column11
            // 
            this.Column11.DataPropertyName = "kc";
            this.Column11.HeaderText = "当前库存";
            this.Column11.Name = "Column11";
            // 
            // FrmBTxs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 425);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.butbtxg);
            this.Controls.Add(this.labzje);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.txtsl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtxsdh);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtcp);
            this.Controls.Add(this.label1);
            this.Name = "FrmBTxs";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "吧台销售";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmBTxs_FormClosing);
            this.Load += new System.EventHandler(this.FrmBTxs_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwqd)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvcd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtcp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtsl;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dgwqd;
        private System.Windows.Forms.Label labzje;
        private System.Windows.Forms.Button butbtxg;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtxsdh;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button butcdqx;
        private System.Windows.Forms.Button butcdqr;
        private System.Windows.Forms.DataGridView dgvcd;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button butxgqx;
        private System.Windows.Forms.Button butxgqr;
        private System.Windows.Forms.TextBox txtxgsl;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labxgmc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
    }
}