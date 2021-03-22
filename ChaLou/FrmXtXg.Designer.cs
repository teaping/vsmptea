namespace ChaLou
{
    partial class FrmXtXg
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmXtXg));
            this.label1 = new System.Windows.Forms.Label();
            this.cmbxglx = new System.Windows.Forms.ComboBox();
            this.txtxgbh = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtfws = new System.Windows.Forms.TextBox();
            this.butxgbc = new System.Windows.Forms.Button();
            this.butxgqx = new System.Windows.Forms.Button();
            this.dgwbh = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwbh)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "房间类型：";
            // 
            // cmbxglx
            // 
            this.cmbxglx.FormattingEnabled = true;
            this.cmbxglx.Location = new System.Drawing.Point(97, 29);
            this.cmbxglx.Name = "cmbxglx";
            this.cmbxglx.Size = new System.Drawing.Size(100, 20);
            this.cmbxglx.TabIndex = 1;
            // 
            // txtxgbh
            // 
            this.txtxgbh.Location = new System.Drawing.Point(97, 65);
            this.txtxgbh.Name = "txtxgbh";
            this.txtxgbh.Size = new System.Drawing.Size(100, 21);
            this.txtxgbh.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "餐台编号：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "服务生：";
            // 
            // txtfws
            // 
            this.txtfws.Location = new System.Drawing.Point(97, 93);
            this.txtfws.Name = "txtfws";
            this.txtfws.Size = new System.Drawing.Size(100, 21);
            this.txtfws.TabIndex = 2;
            // 
            // butxgbc
            // 
            this.butxgbc.Location = new System.Drawing.Point(28, 147);
            this.butxgbc.Name = "butxgbc";
            this.butxgbc.Size = new System.Drawing.Size(75, 23);
            this.butxgbc.TabIndex = 3;
            this.butxgbc.Text = "保存";
            this.butxgbc.UseVisualStyleBackColor = true;
            this.butxgbc.Click += new System.EventHandler(this.butxgbc_Click);
            // 
            // butxgqx
            // 
            this.butxgqx.Location = new System.Drawing.Point(153, 147);
            this.butxgqx.Name = "butxgqx";
            this.butxgqx.Size = new System.Drawing.Size(75, 23);
            this.butxgqx.TabIndex = 3;
            this.butxgqx.Text = "取消";
            this.butxgqx.UseVisualStyleBackColor = true;
            this.butxgqx.Click += new System.EventHandler(this.butxgqx_Click);
            // 
            // dgwbh
            // 
            this.dgwbh.AllowUserToAddRows = false;
            this.dgwbh.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwbh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwbh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dgwbh.Location = new System.Drawing.Point(49, 14);
            this.dgwbh.MultiSelect = false;
            this.dgwbh.Name = "dgwbh";
            this.dgwbh.RowHeadersVisible = false;
            this.dgwbh.RowTemplate.Height = 23;
            this.dgwbh.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwbh.Size = new System.Drawing.Size(148, 100);
            this.dgwbh.TabIndex = 7;
            this.dgwbh.Visible = false;
            this.dgwbh.SelectionChanged += new System.EventHandler(this.dgwbh_SelectionChanged);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "WaiterNum";
            this.Column1.HeaderText = "编号";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "WaiterName";
            this.Column2.HeaderText = "姓名";
            this.Column2.Name = "Column2";
            // 
            // button3
            // 
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(203, 96);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(25, 23);
            this.button3.TabIndex = 8;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // FrmXtXg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(239, 190);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dgwbh);
            this.Controls.Add(this.butxgqx);
            this.Controls.Add(this.butxgbc);
            this.Controls.Add(this.txtfws);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtxgbh);
            this.Controls.Add(this.cmbxglx);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmXtXg";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "修改餐台";
            this.Load += new System.EventHandler(this.FrmXtXg_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwbh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbxglx;
        private System.Windows.Forms.TextBox txtxgbh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtfws;
        private System.Windows.Forms.Button butxgbc;
        private System.Windows.Forms.Button butxgqx;
        private System.Windows.Forms.DataGridView dgwbh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Button button3;
    }
}