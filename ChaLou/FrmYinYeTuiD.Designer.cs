namespace ChaLou
{
    partial class FrmYinYeTuiD
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
            this.dgvtd = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.按照远时间ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.按照近时间ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvtd)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvtd
            // 
            this.dgvtd.AllowUserToAddRows = false;
            this.dgvtd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvtd.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvtd.BackgroundColor = System.Drawing.Color.White;
            this.dgvtd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvtd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgvtd.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvtd.Location = new System.Drawing.Point(1, 2);
            this.dgvtd.Name = "dgvtd";
            this.dgvtd.RowHeadersVisible = false;
            this.dgvtd.RowTemplate.Height = 23;
            this.dgvtd.Size = new System.Drawing.Size(706, 379);
            this.dgvtd.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "mc";
            this.Column1.HeaderText = "姓名";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "jsrq";
            this.Column2.HeaderText = "退单时间";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "zdh";
            this.Column3.HeaderText = "账单号";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "jszt";
            this.Column4.HeaderText = "退单状态";
            this.Column4.Name = "Column4";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.按照远时间ToolStripMenuItem,
            this.按照近时间ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(153, 70);
            // 
            // 按照远时间ToolStripMenuItem
            // 
            this.按照远时间ToolStripMenuItem.Name = "按照远时间ToolStripMenuItem";
            this.按照远时间ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.按照远时间ToolStripMenuItem.Text = "按照远时间";
            this.按照远时间ToolStripMenuItem.Click += new System.EventHandler(this.按照远时间ToolStripMenuItem_Click);
            // 
            // 按照近时间ToolStripMenuItem
            // 
            this.按照近时间ToolStripMenuItem.Name = "按照近时间ToolStripMenuItem";
            this.按照近时间ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.按照近时间ToolStripMenuItem.Text = "按照近时间";
            this.按照近时间ToolStripMenuItem.Click += new System.EventHandler(this.按照近时间ToolStripMenuItem_Click);
            // 
            // FrmYinYeTuiD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 381);
            this.Controls.Add(this.dgvtd);
            this.Name = "FrmYinYeTuiD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "退单明细";
            this.Load += new System.EventHandler(this.FrmYinYeTuiD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvtd)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvtd;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 按照远时间ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 按照近时间ToolStripMenuItem;
    }
}