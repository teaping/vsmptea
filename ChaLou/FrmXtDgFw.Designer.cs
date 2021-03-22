namespace ChaLou
{
    partial class FrmXtDgFw
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
            this.txtfk = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtzw = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbfjlx = new System.Windows.Forms.ComboBox();
            this.butzjctqx = new System.Windows.Forms.Button();
            this.butzjctbc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "餐台范围：";
            // 
            // txtfk
            // 
            this.txtfk.Location = new System.Drawing.Point(88, 43);
            this.txtfk.Name = "txtfk";
            this.txtfk.Size = new System.Drawing.Size(41, 21);
            this.txtfk.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(135, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "至";
            // 
            // txtzw
            // 
            this.txtzw.Location = new System.Drawing.Point(158, 43);
            this.txtzw.Name = "txtzw";
            this.txtzw.Size = new System.Drawing.Size(41, 21);
            this.txtzw.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "房间类型：";
            // 
            // cmbfjlx
            // 
            this.cmbfjlx.FormattingEnabled = true;
            this.cmbfjlx.Location = new System.Drawing.Point(99, 113);
            this.cmbfjlx.Name = "cmbfjlx";
            this.cmbfjlx.Size = new System.Drawing.Size(100, 20);
            this.cmbfjlx.TabIndex = 2;
            // 
            // butzjctqx
            // 
            this.butzjctqx.Location = new System.Drawing.Point(137, 177);
            this.butzjctqx.Name = "butzjctqx";
            this.butzjctqx.Size = new System.Drawing.Size(75, 23);
            this.butzjctqx.TabIndex = 4;
            this.butzjctqx.Text = "取消";
            this.butzjctqx.UseVisualStyleBackColor = true;
            this.butzjctqx.Click += new System.EventHandler(this.butzjctqx_Click);
            // 
            // butzjctbc
            // 
            this.butzjctbc.Location = new System.Drawing.Point(30, 177);
            this.butzjctbc.Name = "butzjctbc";
            this.butzjctbc.Size = new System.Drawing.Size(75, 23);
            this.butzjctbc.TabIndex = 5;
            this.butzjctbc.Text = "保存";
            this.butzjctbc.UseVisualStyleBackColor = true;
            this.butzjctbc.Click += new System.EventHandler(this.butzjctbc_Click);
            // 
            // FrmXtDgFw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(253, 227);
            this.Controls.Add(this.butzjctqx);
            this.Controls.Add(this.butzjctbc);
            this.Controls.Add(this.cmbfjlx);
            this.Controls.Add(this.txtzw);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtfk);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Name = "FrmXtDgFw";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "增加餐台";
            this.Load += new System.EventHandler(this.FrmXtDgFw_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtfk;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtzw;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbfjlx;
        private System.Windows.Forms.Button butzjctqx;
        private System.Windows.Forms.Button butzjctbc;
    }
}