namespace ChaLou
{
    partial class FrmSuoPing
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
            this.txtmima = new System.Windows.Forms.TextBox();
            this.butJS = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(3, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "请输入当前用户密码：";
            // 
            // txtmima
            // 
            this.txtmima.Location = new System.Drawing.Point(157, 17);
            this.txtmima.Name = "txtmima";
            this.txtmima.Size = new System.Drawing.Size(100, 21);
            this.txtmima.TabIndex = 1;
            // 
            // butJS
            // 
            this.butJS.Location = new System.Drawing.Point(279, 17);
            this.butJS.Name = "butJS";
            this.butJS.Size = new System.Drawing.Size(75, 23);
            this.butJS.TabIndex = 2;
            this.butJS.Text = "解锁";
            this.butJS.UseVisualStyleBackColor = true;
            this.butJS.Click += new System.EventHandler(this.butJS_Click);
            // 
            // FrmSuoPing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(378, 58);
            this.Controls.Add(this.butJS);
            this.Controls.Add(this.txtmima);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmSuoPing";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmSuoPing";
            this.Load += new System.EventHandler(this.FrmSuoPing_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtmima;
        private System.Windows.Forms.Button butJS;
    }
}