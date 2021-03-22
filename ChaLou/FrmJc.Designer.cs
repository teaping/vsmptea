namespace ChaLou
{
    partial class FrmJc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmJc));
            this.butjc = new System.Windows.Forms.Button();
            this.butqc = new System.Windows.Forms.Button();
            this.butsc = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtdh = new System.Windows.Forms.TextBox();
            this.butcx = new System.Windows.Forms.Button();
            this.dgvjc = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvqc = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvjc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvqc)).BeginInit();
            this.SuspendLayout();
            // 
            // butjc
            // 
            this.butjc.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.butjc.Location = new System.Drawing.Point(22, 25);
            this.butjc.Name = "butjc";
            this.butjc.Size = new System.Drawing.Size(75, 23);
            this.butjc.TabIndex = 0;
            this.butjc.Text = "商品寄存";
            this.butjc.UseVisualStyleBackColor = true;
            this.butjc.Click += new System.EventHandler(this.butjc_Click);
            // 
            // butqc
            // 
            this.butqc.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.butqc.Location = new System.Drawing.Point(120, 25);
            this.butqc.Name = "butqc";
            this.butqc.Size = new System.Drawing.Size(75, 23);
            this.butqc.TabIndex = 0;
            this.butqc.Text = "商品取出";
            this.butqc.UseVisualStyleBackColor = true;
            this.butqc.Click += new System.EventHandler(this.butqc_Click);
            // 
            // butsc
            // 
            this.butsc.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.butsc.Location = new System.Drawing.Point(222, 25);
            this.butsc.Name = "butsc";
            this.butsc.Size = new System.Drawing.Size(75, 23);
            this.butsc.TabIndex = 0;
            this.butsc.Text = "删除";
            this.butsc.UseVisualStyleBackColor = true;
            this.butsc.Click += new System.EventHandler(this.butsc_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(398, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "单据号/姓名：";
            // 
            // txtdh
            // 
            this.txtdh.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtdh.Location = new System.Drawing.Point(474, 25);
            this.txtdh.Name = "txtdh";
            this.txtdh.Size = new System.Drawing.Size(100, 21);
            this.txtdh.TabIndex = 2;
            // 
            // butcx
            // 
            this.butcx.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.butcx.BackColor = System.Drawing.Color.Transparent;
            this.butcx.FlatAppearance.BorderSize = 0;
            this.butcx.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butcx.Image = ((System.Drawing.Image)(resources.GetObject("butcx.Image")));
            this.butcx.Location = new System.Drawing.Point(595, 12);
            this.butcx.Name = "butcx";
            this.butcx.Size = new System.Drawing.Size(49, 42);
            this.butcx.TabIndex = 0;
            this.butcx.UseVisualStyleBackColor = false;
            this.butcx.Click += new System.EventHandler(this.butcx_Click);
            // 
            // dgvjc
            // 
            this.dgvjc.AllowUserToAddRows = false;
            this.dgvjc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvjc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvjc.BackgroundColor = System.Drawing.Color.White;
            this.dgvjc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvjc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9});
            this.dgvjc.Location = new System.Drawing.Point(1, 55);
            this.dgvjc.MultiSelect = false;
            this.dgvjc.Name = "dgvjc";
            this.dgvjc.RowHeadersVisible = false;
            this.dgvjc.RowTemplate.Height = 23;
            this.dgvjc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvjc.Size = new System.Drawing.Size(763, 249);
            this.dgvjc.TabIndex = 3;
            this.dgvjc.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvjc_CellContentDoubleClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "ID";
            this.Column1.HeaderText = "单号";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "mc";
            this.Column2.HeaderText = "宾客名称";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "spmc";
            this.Column3.HeaderText = "商品名称";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "dw";
            this.Column4.HeaderText = "单位";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "sl";
            this.Column5.HeaderText = "寄存数量";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "sysl";
            this.Column6.HeaderText = "剩余数量";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "jcrq";
            this.Column7.HeaderText = "寄存日期";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "yxrq";
            this.Column8.HeaderText = "有效日期";
            this.Column8.Name = "Column8";
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "czy";
            this.Column9.HeaderText = "操作员";
            this.Column9.Name = "Column9";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label2.Location = new System.Drawing.Point(-1, 307);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "商品取出明细";
            // 
            // dgvqc
            // 
            this.dgvqc.AllowUserToAddRows = false;
            this.dgvqc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvqc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvqc.BackgroundColor = System.Drawing.Color.White;
            this.dgvqc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvqc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.Column10,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.dgvqc.Location = new System.Drawing.Point(1, 322);
            this.dgvqc.MultiSelect = false;
            this.dgvqc.Name = "dgvqc";
            this.dgvqc.RowHeadersVisible = false;
            this.dgvqc.RowTemplate.Height = 23;
            this.dgvqc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvqc.Size = new System.Drawing.Size(763, 199);
            this.dgvqc.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn1.HeaderText = "单号";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "mc";
            this.dataGridViewTextBoxColumn2.HeaderText = "宾客名称";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // Column10
            // 
            this.Column10.DataPropertyName = "bm";
            this.Column10.HeaderText = "编码";
            this.Column10.Name = "Column10";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "spmc";
            this.dataGridViewTextBoxColumn3.HeaderText = "商品名称";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "dw";
            this.dataGridViewTextBoxColumn4.HeaderText = "单位";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "qcsl";
            this.dataGridViewTextBoxColumn6.HeaderText = "数量";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "qcrq";
            this.dataGridViewTextBoxColumn8.HeaderText = "取出日期";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "czy";
            this.dataGridViewTextBoxColumn9.HeaderText = "操作员";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // FrmJc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 521);
            this.Controls.Add(this.dgvqc);
            this.Controls.Add(this.dgvjc);
            this.Controls.Add(this.txtdh);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.butsc);
            this.Controls.Add(this.butqc);
            this.Controls.Add(this.butcx);
            this.Controls.Add(this.butjc);
            this.Name = "FrmJc";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "商品寄存管理";
            this.Load += new System.EventHandler(this.FrmJc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvjc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvqc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butjc;
        private System.Windows.Forms.Button butqc;
        private System.Windows.Forms.Button butsc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtdh;
        private System.Windows.Forms.Button butcx;
        private System.Windows.Forms.DataGridView dgvjc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvqc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
    }
}