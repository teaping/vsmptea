namespace ChaLou
{
    partial class FrmYdGl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmYdGl));
            this.butydtj = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtchaxfjh = new System.Windows.Forms.TextBox();
            this.butchaxfj = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvyd = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvyd)).BeginInit();
            this.SuspendLayout();
            // 
            // butydtj
            // 
            this.butydtj.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.butydtj.Location = new System.Drawing.Point(12, 24);
            this.butydtj.Name = "butydtj";
            this.butydtj.Size = new System.Drawing.Size(48, 23);
            this.butydtj.TabIndex = 0;
            this.butydtj.Text = "增加";
            this.butydtj.UseVisualStyleBackColor = true;
            this.butydtj.Click += new System.EventHandler(this.butydtj_Click);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button2.Location = new System.Drawing.Point(93, 24);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(48, 23);
            this.button2.TabIndex = 0;
            this.button2.Text = "修改";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button3.Location = new System.Drawing.Point(179, 24);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(48, 23);
            this.button3.TabIndex = 0;
            this.button3.Text = "删除";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button5
            // 
            this.button5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button5.Location = new System.Drawing.Point(273, 24);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(48, 23);
            this.button5.TabIndex = 0;
            this.button5.Text = "开单";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(476, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "餐台号：";
            // 
            // txtchaxfjh
            // 
            this.txtchaxfjh.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtchaxfjh.Location = new System.Drawing.Point(535, 24);
            this.txtchaxfjh.Name = "txtchaxfjh";
            this.txtchaxfjh.Size = new System.Drawing.Size(46, 21);
            this.txtchaxfjh.TabIndex = 2;
            // 
            // butchaxfj
            // 
            this.butchaxfj.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.butchaxfj.FlatAppearance.BorderSize = 0;
            this.butchaxfj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butchaxfj.Image = ((System.Drawing.Image)(resources.GetObject("butchaxfj.Image")));
            this.butchaxfj.Location = new System.Drawing.Point(587, 14);
            this.butchaxfj.Name = "butchaxfj";
            this.butchaxfj.Size = new System.Drawing.Size(42, 39);
            this.butchaxfj.TabIndex = 0;
            this.butchaxfj.UseVisualStyleBackColor = true;
            this.butchaxfj.Click += new System.EventHandler(this.butchaxfj_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.dgvyd);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(1, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(681, 349);
            this.panel1.TabIndex = 3;
            // 
            // dgvyd
            // 
            this.dgvyd.AllowUserToAddRows = false;
            this.dgvyd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvyd.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvyd.BackgroundColor = System.Drawing.Color.White;
            this.dgvyd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvyd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column8,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.dgvyd.Location = new System.Drawing.Point(0, 21);
            this.dgvyd.MultiSelect = false;
            this.dgvyd.Name = "dgvyd";
            this.dgvyd.RowHeadersVisible = false;
            this.dgvyd.RowTemplate.Height = 23;
            this.dgvyd.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvyd.Size = new System.Drawing.Size(681, 328);
            this.dgvyd.TabIndex = 2;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "xm";
            this.Column1.HeaderText = "宾客姓名";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "dh";
            this.Column2.HeaderText = "联系电话";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "ydlx";
            this.Column3.HeaderText = "预定房间类型";
            this.Column3.Name = "Column3";
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "bh";
            this.Column8.HeaderText = "预定餐台编号";
            this.Column8.Name = "Column8";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "ydsj";
            this.Column4.HeaderText = "预抵时间";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "blsj";
            this.Column5.HeaderText = "保留时间直到";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "xdsj";
            this.Column6.HeaderText = "下订时间";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "bz";
            this.Column7.HeaderText = "备注";
            this.Column7.Name = "Column7";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.BackColor = System.Drawing.Color.GreenYellow;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(681, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "宾客预定信息";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmYdGl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 411);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtchaxfjh);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.butchaxfj);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.butydtj);
            this.Name = "FrmYdGl";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "预定管理";
            this.Load += new System.EventHandler(this.FrmYdGl_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvyd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butydtj;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtchaxfjh;
        private System.Windows.Forms.Button butchaxfj;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvyd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
    }
}