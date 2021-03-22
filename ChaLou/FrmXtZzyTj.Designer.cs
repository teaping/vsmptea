namespace ChaLou
{
    partial class FrmXtZzyTj
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
            this.txtbh = new System.Windows.Forms.TextBox();
            this.cmbqx = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtxm = new System.Windows.Forms.TextBox();
            this.butqx = new System.Windows.Forms.Button();
            this.butbc = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtmima = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtbmbh = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "编号：";
            // 
            // txtbh
            // 
            this.txtbh.Location = new System.Drawing.Point(104, 13);
            this.txtbh.Name = "txtbh";
            this.txtbh.Size = new System.Drawing.Size(100, 21);
            this.txtbh.TabIndex = 1;
            // 
            // cmbqx
            // 
            this.cmbqx.FormattingEnabled = true;
            this.cmbqx.Items.AddRange(new object[] {
            "管理员",
            "超级管理员"});
            this.cmbqx.Location = new System.Drawing.Point(104, 140);
            this.cmbqx.Name = "cmbqx";
            this.cmbqx.Size = new System.Drawing.Size(100, 20);
            this.cmbqx.TabIndex = 2;
            this.cmbqx.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "权限：";
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "姓名：";
            // 
            // txtxm
            // 
            this.txtxm.Location = new System.Drawing.Point(104, 48);
            this.txtxm.Name = "txtxm";
            this.txtxm.Size = new System.Drawing.Size(100, 21);
            this.txtxm.TabIndex = 1;
            // 
            // butqx
            // 
            this.butqx.Location = new System.Drawing.Point(173, 182);
            this.butqx.Name = "butqx";
            this.butqx.Size = new System.Drawing.Size(75, 23);
            this.butqx.TabIndex = 3;
            this.butqx.Text = "取消";
            this.butqx.UseVisualStyleBackColor = true;
            this.butqx.Click += new System.EventHandler(this.butqx_Click);
            // 
            // butbc
            // 
            this.butbc.Location = new System.Drawing.Point(23, 182);
            this.butbc.Name = "butbc";
            this.butbc.Size = new System.Drawing.Size(75, 23);
            this.butbc.TabIndex = 3;
            this.butbc.Text = "保存";
            this.butbc.UseVisualStyleBackColor = true;
            this.butbc.Click += new System.EventHandler(this.butbc_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "密码：";
            // 
            // txtmima
            // 
            this.txtmima.Location = new System.Drawing.Point(104, 84);
            this.txtmima.Name = "txtmima";
            this.txtmima.Size = new System.Drawing.Size(100, 21);
            this.txtmima.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "部门编号：";
            // 
            // txtbmbh
            // 
            this.txtbmbh.Location = new System.Drawing.Point(104, 113);
            this.txtbmbh.Name = "txtbmbh";
            this.txtbmbh.Size = new System.Drawing.Size(100, 21);
            this.txtbmbh.TabIndex = 1;
            // 
            // FrmXtZzyTj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 217);
            this.Controls.Add(this.butbc);
            this.Controls.Add(this.butqx);
            this.Controls.Add(this.cmbqx);
            this.Controls.Add(this.txtbmbh);
            this.Controls.Add(this.txtmima);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtxm);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtbh);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmXtZzyTj";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "添加/修改操作员";
            this.Load += new System.EventHandler(this.FrmXtZzyTj_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbh;
        private System.Windows.Forms.ComboBox cmbqx;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtxm;
        private System.Windows.Forms.Button butqx;
        private System.Windows.Forms.Button butbc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtmima;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtbmbh;
    }
}