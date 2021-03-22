namespace ChaLou
{
    partial class FrmHuYuMia
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
            this.txthybh = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtjmima = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtxmima = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtqrxmima = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.butmiqr = new System.Windows.Forms.Button();
            this.butmaqx = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "会员编号:";
            // 
            // txthybh
            // 
            this.txthybh.Enabled = false;
            this.txthybh.Location = new System.Drawing.Point(105, 17);
            this.txthybh.Name = "txthybh";
            this.txthybh.Size = new System.Drawing.Size(100, 21);
            this.txthybh.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "旧密码：";
            // 
            // txtjmima
            // 
            this.txtjmima.Location = new System.Drawing.Point(105, 55);
            this.txtjmima.Name = "txtjmima";
            this.txtjmima.Size = new System.Drawing.Size(100, 21);
            this.txtjmima.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "新密码：";
            // 
            // txtxmima
            // 
            this.txtxmima.Location = new System.Drawing.Point(105, 96);
            this.txtxmima.Name = "txtxmima";
            this.txtxmima.Size = new System.Drawing.Size(100, 21);
            this.txtxmima.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "确认新密码：";
            // 
            // txtqrxmima
            // 
            this.txtqrxmima.Location = new System.Drawing.Point(105, 135);
            this.txtqrxmima.Name = "txtqrxmima";
            this.txtqrxmima.Size = new System.Drawing.Size(100, 21);
            this.txtqrxmima.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(26, 195);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "密码置空";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // butmiqr
            // 
            this.butmiqr.Location = new System.Drawing.Point(135, 195);
            this.butmiqr.Name = "butmiqr";
            this.butmiqr.Size = new System.Drawing.Size(45, 23);
            this.butmiqr.TabIndex = 2;
            this.butmiqr.Text = "确认";
            this.butmiqr.UseVisualStyleBackColor = true;
            this.butmiqr.Click += new System.EventHandler(this.butmiqr_Click);
            // 
            // butmaqx
            // 
            this.butmaqx.Location = new System.Drawing.Point(210, 195);
            this.butmaqx.Name = "butmaqx";
            this.butmaqx.Size = new System.Drawing.Size(45, 23);
            this.butmaqx.TabIndex = 2;
            this.butmaqx.Text = "取消";
            this.butmaqx.UseVisualStyleBackColor = true;
            this.butmaqx.Click += new System.EventHandler(this.butmaqx_Click);
            // 
            // FrmHuYuMia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 247);
            this.Controls.Add(this.butmaqx);
            this.Controls.Add(this.butmiqr);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtqrxmima);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtxmima);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtjmima);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txthybh);
            this.Controls.Add(this.label1);
            this.Name = "FrmHuYuMia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "修改密码";
            this.Load += new System.EventHandler(this.FrmHuYuMia_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txthybh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtjmima;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtxmima;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtqrxmima;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button butmiqr;
        private System.Windows.Forms.Button butmaqx;
    }
}