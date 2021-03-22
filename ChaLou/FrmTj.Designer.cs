namespace ChaLou
{
    partial class FrmTj
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTj));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgwbh = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.butkdt = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtbz = new System.Windows.Forms.TextBox();
            this.txtfw = new System.Windows.Forms.TextBox();
            this.txtbk = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labzud = new System.Windows.Forms.Label();
            this.labzd = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.butqr = new System.Windows.Forms.Button();
            this.butqx = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwbh)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.dgwbh);
            this.panel1.Controls.Add(this.butkdt);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtbz);
            this.panel1.Controls.Add(this.txtfw);
            this.panel1.Controls.Add(this.txtbk);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.labzud);
            this.panel1.Controls.Add(this.labzd);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(419, 223);
            this.panel1.TabIndex = 0;
            // 
            // dgwbh
            // 
            this.dgwbh.AllowUserToAddRows = false;
            this.dgwbh.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dgwbh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwbh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dgwbh.Location = new System.Drawing.Point(148, 93);
            this.dgwbh.MultiSelect = false;
            this.dgwbh.Name = "dgwbh";
            this.dgwbh.RowHeadersVisible = false;
            this.dgwbh.RowTemplate.Height = 23;
            this.dgwbh.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwbh.Size = new System.Drawing.Size(201, 92);
            this.dgwbh.TabIndex = 5;
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
            // butkdt
            // 
            this.butkdt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.butkdt.Image = ((System.Drawing.Image)(resources.GetObject("butkdt.Image")));
            this.butkdt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butkdt.Location = new System.Drawing.Point(355, 66);
            this.butkdt.Name = "butkdt";
            this.butkdt.Size = new System.Drawing.Size(27, 21);
            this.butkdt.TabIndex = 4;
            this.butkdt.UseVisualStyleBackColor = true;
            this.butkdt.Click += new System.EventHandler(this.butkdt_Click);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Location = new System.Drawing.Point(127, 6);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(151, 14);
            this.label7.TabIndex = 3;
            this.label7.Text = "房间计费方法：不计房间费";
            // 
            // txtbz
            // 
            this.txtbz.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtbz.Location = new System.Drawing.Point(148, 133);
            this.txtbz.Multiline = true;
            this.txtbz.Name = "txtbz";
            this.txtbz.Size = new System.Drawing.Size(177, 52);
            this.txtbz.TabIndex = 2;
            // 
            // txtfw
            // 
            this.txtfw.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtfw.Location = new System.Drawing.Point(294, 66);
            this.txtfw.Name = "txtfw";
            this.txtfw.Size = new System.Drawing.Size(55, 21);
            this.txtfw.TabIndex = 2;
            // 
            // txtbk
            // 
            this.txtbk.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtbk.Location = new System.Drawing.Point(148, 66);
            this.txtbk.Name = "txtbk";
            this.txtbk.Size = new System.Drawing.Size(55, 21);
            this.txtbk.TabIndex = 2;
            this.txtbk.Text = "1";
            this.txtbk.TextChanged += new System.EventHandler(this.txtbk_TextChanged);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(88, 133);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 0;
            this.label6.Text = "开单备注：";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(246, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "服务生：";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(246, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "最低消费：";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(88, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "宾客人数：";
            // 
            // labzud
            // 
            this.labzud.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labzud.AutoSize = true;
            this.labzud.Location = new System.Drawing.Point(317, 27);
            this.labzud.Name = "labzud";
            this.labzud.Size = new System.Drawing.Size(65, 12);
            this.labzud.TabIndex = 0;
            this.labzud.Text = "主单餐台：";
            // 
            // labzd
            // 
            this.labzd.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labzd.AutoSize = true;
            this.labzd.Location = new System.Drawing.Point(146, 27);
            this.labzd.Name = "labzd";
            this.labzd.Size = new System.Drawing.Size(65, 12);
            this.labzd.TabIndex = 0;
            this.labzd.Text = "主单餐台：";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "主单餐台：";
            // 
            // butqr
            // 
            this.butqr.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.butqr.Location = new System.Drawing.Point(81, 232);
            this.butqr.Name = "butqr";
            this.butqr.Size = new System.Drawing.Size(75, 23);
            this.butqr.TabIndex = 1;
            this.butqr.Text = "确认";
            this.butqr.UseVisualStyleBackColor = true;
            this.butqr.Click += new System.EventHandler(this.butqr_Click);
            // 
            // butqx
            // 
            this.butqx.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.butqx.Location = new System.Drawing.Point(253, 232);
            this.butqx.Name = "butqx";
            this.butqx.Size = new System.Drawing.Size(75, 23);
            this.butqx.TabIndex = 1;
            this.butqx.Text = "取消";
            this.butqx.UseVisualStyleBackColor = true;
            this.butqx.Click += new System.EventHandler(this.butqx_Click);
            // 
            // FrmTj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 261);
            this.Controls.Add(this.butqx);
            this.Controls.Add(this.butqr);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FrmTj";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "giao";
            this.Load += new System.EventHandler(this.FrmTj_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwbh)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbz;
        private System.Windows.Forms.Button butqr;
        private System.Windows.Forms.Button butqx;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtfw;
        private System.Windows.Forms.TextBox txtbk;
        private System.Windows.Forms.Label labzud;
        private System.Windows.Forms.Label labzd;
        private System.Windows.Forms.Button butkdt;
        private System.Windows.Forms.DataGridView dgwbh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}