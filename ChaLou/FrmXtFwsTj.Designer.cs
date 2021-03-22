namespace ChaLou
{
    partial class FrmXtFwsTj
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
            this.txtdjbh = new System.Windows.Forms.TextBox();
            this.txtfwsdj = new System.Windows.Forms.TextBox();
            this.butfwsqx = new System.Windows.Forms.Button();
            this.butwfsbc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "等级编号：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "服务生等级：";
            // 
            // txtdjbh
            // 
            this.txtdjbh.Location = new System.Drawing.Point(113, 32);
            this.txtdjbh.Name = "txtdjbh";
            this.txtdjbh.Size = new System.Drawing.Size(100, 21);
            this.txtdjbh.TabIndex = 1;
            // 
            // txtfwsdj
            // 
            this.txtfwsdj.Location = new System.Drawing.Point(113, 66);
            this.txtfwsdj.Name = "txtfwsdj";
            this.txtfwsdj.Size = new System.Drawing.Size(100, 21);
            this.txtfwsdj.TabIndex = 1;
            // 
            // butfwsqx
            // 
            this.butfwsqx.Location = new System.Drawing.Point(173, 142);
            this.butfwsqx.Name = "butfwsqx";
            this.butfwsqx.Size = new System.Drawing.Size(51, 23);
            this.butfwsqx.TabIndex = 2;
            this.butfwsqx.Text = "取消";
            this.butfwsqx.UseVisualStyleBackColor = true;
            this.butfwsqx.Click += new System.EventHandler(this.butfwsqx_Click);
            // 
            // butwfsbc
            // 
            this.butwfsbc.Location = new System.Drawing.Point(56, 142);
            this.butwfsbc.Name = "butwfsbc";
            this.butwfsbc.Size = new System.Drawing.Size(51, 23);
            this.butwfsbc.TabIndex = 2;
            this.butwfsbc.Text = "保存";
            this.butwfsbc.UseVisualStyleBackColor = true;
            this.butwfsbc.Click += new System.EventHandler(this.butwfsbc_Click);
            // 
            // FrmXtFwsTj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 191);
            this.Controls.Add(this.butwfsbc);
            this.Controls.Add(this.butfwsqx);
            this.Controls.Add(this.txtfwsdj);
            this.Controls.Add(this.txtdjbh);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmXtFwsTj";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "增删服务生等级";
            this.Load += new System.EventHandler(this.FrmXtFwsTj_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtdjbh;
        private System.Windows.Forms.TextBox txtfwsdj;
        private System.Windows.Forms.Button butfwsqx;
        private System.Windows.Forms.Button butwfsbc;
    }
}