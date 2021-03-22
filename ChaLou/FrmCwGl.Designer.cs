namespace ChaLou
{
    partial class FrmCwGl
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
            this.dgvcw = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.会员充值消费ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.桌台消费ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcw)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvcw
            // 
            this.dgvcw.AllowUserToAddRows = false;
            this.dgvcw.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvcw.BackgroundColor = System.Drawing.Color.White;
            this.dgvcw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvcw.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgvcw.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvcw.Location = new System.Drawing.Point(2, 1);
            this.dgvcw.MultiSelect = false;
            this.dgvcw.Name = "dgvcw";
            this.dgvcw.RowHeadersVisible = false;
            this.dgvcw.RowTemplate.Height = 23;
            this.dgvcw.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvcw.Size = new System.Drawing.Size(667, 376);
            this.dgvcw.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "jsrq";
            this.Column1.HeaderText = "日期";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "shje";
            this.Column2.HeaderText = "项目金额";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "jszt";
            this.Column3.HeaderText = "项目类型";
            this.Column3.Name = "Column3";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.会员充值消费ToolStripMenuItem,
            this.桌台消费ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(149, 48);
            // 
            // 会员充值消费ToolStripMenuItem
            // 
            this.会员充值消费ToolStripMenuItem.Name = "会员充值消费ToolStripMenuItem";
            this.会员充值消费ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.会员充值消费ToolStripMenuItem.Text = "会员充值消费";
            this.会员充值消费ToolStripMenuItem.Click += new System.EventHandler(this.会员充值消费ToolStripMenuItem_Click);
            // 
            // 桌台消费ToolStripMenuItem
            // 
            this.桌台消费ToolStripMenuItem.Name = "桌台消费ToolStripMenuItem";
            this.桌台消费ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.桌台消费ToolStripMenuItem.Text = "桌台消费";
            this.桌台消费ToolStripMenuItem.Click += new System.EventHandler(this.桌台消费ToolStripMenuItem_Click);
            // 
            // FrmCwGl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 378);
            this.Controls.Add(this.dgvcw);
            this.Name = "FrmCwGl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "财务管理";
            this.Load += new System.EventHandler(this.FrmCwGl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvcw)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvcw;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 会员充值消费ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 桌台消费ToolStripMenuItem;

    }
}