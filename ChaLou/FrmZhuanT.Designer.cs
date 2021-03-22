namespace ChaLou
{
    partial class FrmZhuanT
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labct = new System.Windows.Forms.Label();
            this.labmc = new System.Windows.Forms.Label();
            this.labje = new System.Windows.Forms.Label();
            this.txtmb = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "当前餐台：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "转单项目：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(71, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "转单金额：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(71, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "目标餐台：";
            // 
            // labct
            // 
            this.labct.AutoSize = true;
            this.labct.Location = new System.Drawing.Point(129, 43);
            this.labct.Name = "labct";
            this.labct.Size = new System.Drawing.Size(41, 12);
            this.labct.TabIndex = 0;
            this.labct.Text = "label1";
            // 
            // labmc
            // 
            this.labmc.AutoSize = true;
            this.labmc.Location = new System.Drawing.Point(129, 79);
            this.labmc.Name = "labmc";
            this.labmc.Size = new System.Drawing.Size(41, 12);
            this.labmc.TabIndex = 0;
            this.labmc.Text = "label1";
            // 
            // labje
            // 
            this.labje.AutoSize = true;
            this.labje.Location = new System.Drawing.Point(129, 112);
            this.labje.Name = "labje";
            this.labje.Size = new System.Drawing.Size(41, 12);
            this.labje.TabIndex = 0;
            this.labje.Text = "label1";
            // 
            // txtmb
            // 
            this.txtmb.Location = new System.Drawing.Point(131, 139);
            this.txtmb.Name = "txtmb";
            this.txtmb.Size = new System.Drawing.Size(100, 21);
            this.txtmb.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(37, 209);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "确定";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(152, 209);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "取消";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FrmZhuanT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtmb);
            this.Controls.Add(this.labje);
            this.Controls.Add(this.labmc);
            this.Controls.Add(this.labct);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmZhuanT";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "消费转单";
            this.Load += new System.EventHandler(this.FrmZhuanT_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labct;
        private System.Windows.Forms.Label labmc;
        private System.Windows.Forms.Label labje;
        private System.Windows.Forms.TextBox txtmb;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}