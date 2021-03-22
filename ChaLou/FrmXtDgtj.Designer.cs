namespace ChaLou
{
    partial class FrmXtDgtj
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmXtDgtj));
            this.label1 = new System.Windows.Forms.Label();
            this.cmbfjlx = new System.Windows.Forms.ComboBox();
            this.txtzbh = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtwfs = new System.Windows.Forms.TextBox();
            this.butzjctbc = new System.Windows.Forms.Button();
            this.butzjctqx = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dgwbh = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgwbh)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "餐台编号：";
            // 
            // cmbfjlx
            // 
            this.cmbfjlx.FormattingEnabled = true;
            this.cmbfjlx.Location = new System.Drawing.Point(108, 27);
            this.cmbfjlx.Name = "cmbfjlx";
            this.cmbfjlx.Size = new System.Drawing.Size(100, 20);
            this.cmbfjlx.TabIndex = 1;
            // 
            // txtzbh
            // 
            this.txtzbh.Location = new System.Drawing.Point(108, 69);
            this.txtzbh.Name = "txtzbh";
            this.txtzbh.Size = new System.Drawing.Size(100, 21);
            this.txtzbh.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "房间类型：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "服务生：";
            // 
            // txtwfs
            // 
            this.txtwfs.Location = new System.Drawing.Point(108, 114);
            this.txtwfs.Name = "txtwfs";
            this.txtwfs.Size = new System.Drawing.Size(100, 21);
            this.txtwfs.TabIndex = 2;
            // 
            // butzjctbc
            // 
            this.butzjctbc.Location = new System.Drawing.Point(49, 165);
            this.butzjctbc.Name = "butzjctbc";
            this.butzjctbc.Size = new System.Drawing.Size(75, 23);
            this.butzjctbc.TabIndex = 3;
            this.butzjctbc.Text = "保存";
            this.butzjctbc.UseVisualStyleBackColor = true;
            this.butzjctbc.Click += new System.EventHandler(this.butzjctbc_Click);
            // 
            // butzjctqx
            // 
            this.butzjctqx.Location = new System.Drawing.Point(164, 165);
            this.butzjctqx.Name = "butzjctqx";
            this.butzjctqx.Size = new System.Drawing.Size(75, 23);
            this.butzjctqx.TabIndex = 3;
            this.butzjctqx.Text = "取消";
            this.butzjctqx.UseVisualStyleBackColor = true;
            this.butzjctqx.Click += new System.EventHandler(this.butzjctqx_Click);
            // 
            // button3
            // 
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(214, 114);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(25, 23);
            this.button3.TabIndex = 3;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dgwbh
            // 
            this.dgwbh.AllowUserToAddRows = false;
            this.dgwbh.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwbh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwbh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dgwbh.Location = new System.Drawing.Point(60, 35);
            this.dgwbh.MultiSelect = false;
            this.dgwbh.Name = "dgwbh";
            this.dgwbh.RowHeadersVisible = false;
            this.dgwbh.RowTemplate.Height = 23;
            this.dgwbh.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwbh.Size = new System.Drawing.Size(148, 100);
            this.dgwbh.TabIndex = 6;
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
            // FrmXtDgtj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 222);
            this.Controls.Add(this.dgwbh);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.butzjctqx);
            this.Controls.Add(this.butzjctbc);
            this.Controls.Add(this.txtwfs);
            this.Controls.Add(this.txtzbh);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbfjlx);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmXtDgtj";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "增加餐台";
            this.Load += new System.EventHandler(this.FrmXtDgtj_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwbh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbfjlx;
        private System.Windows.Forms.TextBox txtzbh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtwfs;
        private System.Windows.Forms.Button butzjctbc;
        private System.Windows.Forms.Button butzjctqx;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dgwbh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}