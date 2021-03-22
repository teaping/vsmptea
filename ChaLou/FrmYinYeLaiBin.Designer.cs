namespace ChaLou
{
    partial class FrmYinYeLaiBin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmYinYeLaiBin));
            this.dgvlbxx = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.butcx = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtcxlb = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvlbxx)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvlbxx
            // 
            this.dgvlbxx.AllowUserToAddRows = false;
            this.dgvlbxx.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvlbxx.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvlbxx.BackgroundColor = System.Drawing.Color.White;
            this.dgvlbxx.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvlbxx.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column8,
            this.Column5,
            this.Column6,
            this.Column7});
            this.dgvlbxx.Location = new System.Drawing.Point(2, 78);
            this.dgvlbxx.MultiSelect = false;
            this.dgvlbxx.Name = "dgvlbxx";
            this.dgvlbxx.RowHeadersVisible = false;
            this.dgvlbxx.RowTemplate.Height = 23;
            this.dgvlbxx.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvlbxx.Size = new System.Drawing.Size(669, 334);
            this.dgvlbxx.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "cth";
            this.Column1.HeaderText = "餐台号";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "xm";
            this.Column2.HeaderText = "宾客姓名";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "xb";
            this.Column3.HeaderText = "性别";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "sj";
            this.Column4.HeaderText = "进店时间";
            this.Column4.Name = "Column4";
            // 
            // Column8
            // 
            this.Column8.HeaderText = "离店时间";
            this.Column8.Name = "Column8";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "zt";
            this.Column5.HeaderText = "当前状态";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "dh";
            this.Column6.HeaderText = "结单单号";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "单号";
            this.Column7.HeaderText = "备注";
            this.Column7.Name = "Column7";
            // 
            // butcx
            // 
            this.butcx.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.butcx.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.butcx.FlatAppearance.BorderSize = 0;
            this.butcx.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butcx.Image = ((System.Drawing.Image)(resources.GetObject("butcx.Image")));
            this.butcx.Location = new System.Drawing.Point(394, 20);
            this.butcx.Name = "butcx";
            this.butcx.Size = new System.Drawing.Size(47, 40);
            this.butcx.TabIndex = 1;
            this.butcx.UseVisualStyleBackColor = true;
            this.butcx.Click += new System.EventHandler(this.butcx_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(127, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "餐台号/宾客姓名：";
            // 
            // txtcxlb
            // 
            this.txtcxlb.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtcxlb.Location = new System.Drawing.Point(249, 25);
            this.txtcxlb.Name = "txtcxlb";
            this.txtcxlb.Size = new System.Drawing.Size(100, 21);
            this.txtcxlb.TabIndex = 3;
            // 
            // FrmYinYeLaiBin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 411);
            this.Controls.Add(this.txtcxlb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.butcx);
            this.Controls.Add(this.dgvlbxx);
            this.Name = "FrmYinYeLaiBin";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "来宾信息";
            this.Load += new System.EventHandler(this.FrmYinYeLaiBin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvlbxx)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvlbxx;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.Button butcx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtcxlb;
    }
}