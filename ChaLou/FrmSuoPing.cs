using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChaLou
{
    public partial class FrmSuoPing : Form
    {
        public FrmSuoPing()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 解锁
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void butJS_Click(object sender, EventArgs e)
        {
            if (this.txtmima.Text=="123")
            {
                MessageBox.Show("解锁成功");
                this.Dispose();
            }
            else
            {
                MessageBox.Show("解锁失败");
                return;
            }
        }

        private void FrmSuoPing_Load(object sender, EventArgs e)
        {
            this.AcceptButton = butJS;
        }


    }
}
