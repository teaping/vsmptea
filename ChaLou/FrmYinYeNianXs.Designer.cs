namespace ChaLou
{
    partial class FrmYinYeNianXs
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
            this.labzxf = new System.Windows.Forms.Label();
            this.butcxr = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dgvrxs = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvrxs)).BeginInit();
            this.SuspendLayout();
            // 
            // labzxf
            // 
            this.labzxf.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labzxf.AutoSize = true;
            this.labzxf.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labzxf.Location = new System.Drawing.Point(425, 8);
            this.labzxf.Name = "labzxf";
            this.labzxf.Size = new System.Drawing.Size(82, 14);
            this.labzxf.TabIndex = 7;
            this.labzxf.Text = "年总消费：";
            // 
            // butcxr
            // 
            this.butcxr.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.butcxr.Location = new System.Drawing.Point(186, 8);
            this.butcxr.Name = "butcxr";
            this.butcxr.Size = new System.Drawing.Size(68, 23);
            this.butcxr.TabIndex = 6;
            this.butcxr.Text = "查询";
            this.butcxr.UseVisualStyleBackColor = true;
            this.butcxr.Click += new System.EventHandler(this.butcxr_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dateTimePicker1.Location = new System.Drawing.Point(52, 8);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(104, 21);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // dgvrxs
            // 
            this.dgvrxs.AllowUserToAddRows = false;
            this.dgvrxs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvrxs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvrxs.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvrxs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvrxs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column6,
            this.Column5});
            this.dgvrxs.Location = new System.Drawing.Point(12, 35);
            this.dgvrxs.MultiSelect = false;
            this.dgvrxs.Name = "dgvrxs";
            this.dgvrxs.RowHeadersVisible = false;
            this.dgvrxs.RowTemplate.Height = 23;
            this.dgvrxs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvrxs.Size = new System.Drawing.Size(661, 402);
            this.dgvrxs.TabIndex = 4;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "zdh";
            this.Column1.HeaderText = "账单号";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "cth";
            this.Column2.HeaderText = "餐台号";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "mc";
            this.Column3.HeaderText = "宾客姓名";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "shje";
            this.Column4.HeaderText = "消费金额";
            this.Column4.Name = "Column4";
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "jsrq";
            this.Column6.HeaderText = "日期";
            this.Column6.Name = "Column6";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "jzst";
            this.Column5.HeaderText = "结算状态";
            this.Column5.Name = "Column5";
            // 
            // FrmYinYeNianXs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 438);
            this.Controls.Add(this.labzxf);
            this.Controls.Add(this.butcxr);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.dgvrxs);
            this.Name = "FrmYinYeNianXs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "年销售查询";
            this.Load += new System.EventHandler(this.FrmYinYeNianXs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvrxs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labzxf;
        private System.Windows.Forms.Button butcxr;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridView dgvrxs;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}