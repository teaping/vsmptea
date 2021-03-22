namespace ChaLou
{
    partial class FrmHouTai
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHouTai));
            this.labcm = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labcm
            // 
            this.labcm.BackColor = System.Drawing.Color.Transparent;
            this.labcm.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labcm.Location = new System.Drawing.Point(60, 57);
            this.labcm.Name = "labcm";
            this.labcm.Size = new System.Drawing.Size(130, 33);
            this.labcm.TabIndex = 0;
            this.labcm.Text = "label1";
            this.labcm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmHouTai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(269, 170);
            this.Controls.Add(this.labcm);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmHouTai";
            this.ShowIcon = false;
            this.Text = "后台催菜";
            this.Load += new System.EventHandler(this.FrmHouTai_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labcm;
    }
}