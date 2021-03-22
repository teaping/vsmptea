namespace ChaLou
{
    partial class FrmYinYeJzCx
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvjdxx = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmscd = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.结账宾客ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.会员充值ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvjdxx)).BeginInit();
            this.cmscd.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.GreenYellow;
            this.label1.Location = new System.Drawing.Point(1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(735, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "结单状态信息";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvjdxx
            // 
            this.dgvjdxx.AllowUserToAddRows = false;
            this.dgvjdxx.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvjdxx.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvjdxx.BackgroundColor = System.Drawing.Color.White;
            this.dgvjdxx.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvjdxx.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dgvjdxx.ContextMenuStrip = this.cmscd;
            this.dgvjdxx.Location = new System.Drawing.Point(3, 26);
            this.dgvjdxx.Name = "dgvjdxx";
            this.dgvjdxx.RowHeadersVisible = false;
            this.dgvjdxx.RowTemplate.Height = 23;
            this.dgvjdxx.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvjdxx.Size = new System.Drawing.Size(733, 421);
            this.dgvjdxx.TabIndex = 1;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "zdh";
            this.Column1.HeaderText = "账单号";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "cth";
            this.Column2.HeaderText = "餐台号";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "ysje";
            this.Column3.HeaderText = "应收金额";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "jsrq";
            this.Column4.HeaderText = "结算时间";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "jszt";
            this.Column5.HeaderText = "结算状态";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "bz";
            this.Column6.HeaderText = "备注";
            this.Column6.Name = "Column6";
            // 
            // cmscd
            // 
            this.cmscd.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.结账宾客ToolStripMenuItem,
            this.会员充值ToolStripMenuItem});
            this.cmscd.Name = "cmscd";
            this.cmscd.Size = new System.Drawing.Size(125, 48);
            // 
            // 结账宾客ToolStripMenuItem
            // 
            this.结账宾客ToolStripMenuItem.Name = "结账宾客ToolStripMenuItem";
            this.结账宾客ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.结账宾客ToolStripMenuItem.Text = "结账宾客";
            this.结账宾客ToolStripMenuItem.Click += new System.EventHandler(this.结账宾客ToolStripMenuItem_Click);
            // 
            // 会员充值ToolStripMenuItem
            // 
            this.会员充值ToolStripMenuItem.Name = "会员充值ToolStripMenuItem";
            this.会员充值ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.会员充值ToolStripMenuItem.Text = "会员充值";
            this.会员充值ToolStripMenuItem.Click += new System.EventHandler(this.会员充值ToolStripMenuItem_Click);
            // 
            // FrmYinYeJzCx
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 448);
            this.Controls.Add(this.dgvjdxx);
            this.Controls.Add(this.label1);
            this.Name = "FrmYinYeJzCx";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "结账状态查询";
            this.Load += new System.EventHandler(this.FrmYinYeJzCx_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvjdxx)).EndInit();
            this.cmscd.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvjdxx;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.ContextMenuStrip cmscd;
        private System.Windows.Forms.ToolStripMenuItem 结账宾客ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 会员充值ToolStripMenuItem;
    }
}