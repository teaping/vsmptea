namespace ChaLou
{
    partial class FrmJcSl
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
            this.label2 = new System.Windows.Forms.Label();
            this.labmc = new System.Windows.Forms.Label();
            this.labdw = new System.Windows.Forms.Label();
            this.txtsl = new System.Windows.Forms.TextBox();
            this.chkrq = new System.Windows.Forms.CheckBox();
            this.dtpsj = new System.Windows.Forms.DateTimePicker();
            this.butqr = new System.Windows.Forms.Button();
            this.butqx = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "商品数量：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "寄存数量：";
            // 
            // labmc
            // 
            this.labmc.AutoSize = true;
            this.labmc.ForeColor = System.Drawing.Color.Red;
            this.labmc.Location = new System.Drawing.Point(98, 35);
            this.labmc.Name = "labmc";
            this.labmc.Size = new System.Drawing.Size(41, 12);
            this.labmc.TabIndex = 0;
            this.labmc.Text = "label1";
            // 
            // labdw
            // 
            this.labdw.AutoSize = true;
            this.labdw.ForeColor = System.Drawing.Color.Red;
            this.labdw.Location = new System.Drawing.Point(172, 71);
            this.labdw.Name = "labdw";
            this.labdw.Size = new System.Drawing.Size(41, 12);
            this.labdw.TabIndex = 0;
            this.labdw.Text = "（瓶）";
            // 
            // txtsl
            // 
            this.txtsl.Location = new System.Drawing.Point(100, 68);
            this.txtsl.Name = "txtsl";
            this.txtsl.Size = new System.Drawing.Size(66, 21);
            this.txtsl.TabIndex = 1;
            this.txtsl.Text = "1";
            // 
            // chkrq
            // 
            this.chkrq.AutoSize = true;
            this.chkrq.Location = new System.Drawing.Point(41, 119);
            this.chkrq.Name = "chkrq";
            this.chkrq.Size = new System.Drawing.Size(84, 16);
            this.chkrq.TabIndex = 2;
            this.chkrq.Text = "有效日期至";
            this.chkrq.UseVisualStyleBackColor = true;
            this.chkrq.CheckedChanged += new System.EventHandler(this.chkrq_CheckedChanged);
            // 
            // dtpsj
            // 
            this.dtpsj.Enabled = false;
            this.dtpsj.Location = new System.Drawing.Point(131, 114);
            this.dtpsj.Name = "dtpsj";
            this.dtpsj.Size = new System.Drawing.Size(98, 21);
            this.dtpsj.TabIndex = 3;
            // 
            // butqr
            // 
            this.butqr.Location = new System.Drawing.Point(41, 168);
            this.butqr.Name = "butqr";
            this.butqr.Size = new System.Drawing.Size(75, 23);
            this.butqr.TabIndex = 4;
            this.butqr.Text = "确认";
            this.butqr.UseVisualStyleBackColor = true;
            this.butqr.Click += new System.EventHandler(this.button1_Click);
            // 
            // butqx
            // 
            this.butqx.Location = new System.Drawing.Point(138, 168);
            this.butqx.Name = "butqx";
            this.butqx.Size = new System.Drawing.Size(75, 23);
            this.butqx.TabIndex = 4;
            this.butqx.Text = "取消";
            this.butqx.UseVisualStyleBackColor = true;
            this.butqx.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmJcSl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 211);
            this.Controls.Add(this.butqx);
            this.Controls.Add(this.butqr);
            this.Controls.Add(this.dtpsj);
            this.Controls.Add(this.chkrq);
            this.Controls.Add(this.txtsl);
            this.Controls.Add(this.labdw);
            this.Controls.Add(this.labmc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmJcSl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "商品寄存数量";
            this.Load += new System.EventHandler(this.FrmJcSl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labmc;
        private System.Windows.Forms.Label labdw;
        private System.Windows.Forms.TextBox txtsl;
        private System.Windows.Forms.CheckBox chkrq;
        private System.Windows.Forms.DateTimePicker dtpsj;
        private System.Windows.Forms.Button butqr;
        private System.Windows.Forms.Button butqx;
    }
}