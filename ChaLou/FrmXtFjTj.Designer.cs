namespace ChaLou
{
    partial class FrmXtFjTj
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
            this.cmbjfbz = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtzdxf = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtrs = new System.Windows.Forms.TextBox();
            this.chbzdbz = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtfjlx = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(117, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "房间类型：";
            // 
            // cmbjfbz
            // 
            this.cmbjfbz.Enabled = false;
            this.cmbjfbz.FormattingEnabled = true;
            this.cmbjfbz.Items.AddRange(new object[] {
            "大厅",
            "小包",
            "大包房"});
            this.cmbjfbz.Location = new System.Drawing.Point(188, 120);
            this.cmbjfbz.Name = "cmbjfbz";
            this.cmbjfbz.Size = new System.Drawing.Size(90, 20);
            this.cmbjfbz.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(117, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "最低消费：";
            // 
            // txtzdxf
            // 
            this.txtzdxf.Location = new System.Drawing.Point(188, 62);
            this.txtzdxf.Name = "txtzdxf";
            this.txtzdxf.Size = new System.Drawing.Size(90, 21);
            this.txtzdxf.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(117, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "容纳人数：";
            // 
            // txtrs
            // 
            this.txtrs.Location = new System.Drawing.Point(188, 89);
            this.txtrs.Name = "txtrs";
            this.txtrs.Size = new System.Drawing.Size(90, 21);
            this.txtrs.TabIndex = 1;
            // 
            // chbzdbz
            // 
            this.chbzdbz.AutoSize = true;
            this.chbzdbz.Location = new System.Drawing.Point(62, 120);
            this.chbzdbz.Name = "chbzdbz";
            this.chbzdbz.Size = new System.Drawing.Size(120, 16);
            this.chbzdbz.TabIndex = 3;
            this.chbzdbz.Text = "指定标准计费方式";
            this.chbzdbz.UseVisualStyleBackColor = true;
            this.chbzdbz.CheckedChanged += new System.EventHandler(this.chbzdbz_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(86, 170);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(61, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "保存";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(217, 170);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(61, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "取消";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtfjlx
            // 
            this.txtfjlx.Location = new System.Drawing.Point(188, 26);
            this.txtfjlx.Name = "txtfjlx";
            this.txtfjlx.Size = new System.Drawing.Size(90, 21);
            this.txtfjlx.TabIndex = 1;
            // 
            // FrmXtFjTj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 206);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.chbzdbz);
            this.Controls.Add(this.cmbjfbz);
            this.Controls.Add(this.txtrs);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtfjlx);
            this.Controls.Add(this.txtzdxf);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmXtFjTj";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "增加房间类型";
            this.Load += new System.EventHandler(this.FrmXtFjTj_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbjfbz;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtzdxf;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtrs;
        private System.Windows.Forms.CheckBox chbzdbz;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtfjlx;
    }
}