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
    public partial class FrmYinYe : Form
    {
        public FrmYinYe()
        {
            InitializeComponent();
        }
        
        private void FrmYinYe_Load(object sender, EventArgs e)
        {

            this.BackColor = Color.FromArgb(243, 242, 234);
       
        }
        protected override void OnLoad(EventArgs e)
        {
           
            base.OnLoad(e);
        }
        
        /// <summary>
        /// 营业查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void butElbxxcx_Click(object sender, EventArgs e)
        {
             FrmYinYeLaiBin f = new FrmYinYeLaiBin();
             f.ShowDialog();
        }
        /// <summary>
        /// 在店离店消费查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        
        private void butExfmx_Click(object sender, EventArgs e)
        {

            FrmYinYeXfMx f = new FrmYinYeXfMx();
            f.ShowDialog();
        }
        /// <summary>
        /// 结账单查询修改
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void butjEzcx_Click(object sender, EventArgs e)
        {
            FrmYinYeJzCx f = new FrmYinYeJzCx();
            f.ShowDialog();
        }
        /// <summary>
        /// 消费退单明细
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void butEtzx_Click(object sender, EventArgs e)
        {
            FrmYinYeTuiD f = new FrmYinYeTuiD();
            f.ShowDialog();
        }

        private void butExfcx_Click(object sender, EventArgs e)
        {
            FrmSpXsCx f = new FrmSpXsCx();
            f.ShowDialog();
        }
        /// <summary>
        /// 日月销售查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void butEyb_Click(object sender, EventArgs e)
        {
            FrmYinYeYuex f = new FrmYinYeYuex();
            f.ShowDialog();
        }
        /// <summary>
        /// 年销售
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonEx2_Click(object sender, EventArgs e)
        {
            FrmYinYeNianXs f = new FrmYinYeNianXs();
            f.ShowDialog();
        }
        //来宾移入移出
        private void butElbxxcx_MouseMove(object sender, MouseEventArgs e)
        {
            GuanSz.Moues a = new GuanSz.Moues();
            a.MouseJr(this.butElbxxcx);
        }

        private void butElbxxcx_MouseLeave(object sender, EventArgs e)
        {
            GuanSz.Moues a = new GuanSz.Moues();
            a.MouseCr(this.butElbxxcx);
        }
        //结账
        private void butjEzcx_MouseLeave(object sender, EventArgs e)
        {
            GuanSz.Moues a = new GuanSz.Moues();
            a.MouseCr(this.butjEzcx);
        }

        private void butjEzcx_MouseMove(object sender, MouseEventArgs e)
        {
            GuanSz.Moues a = new GuanSz.Moues();
            a.MouseJr(this.butjEzcx);
        }
        //日月
        private void butEyb_MouseLeave(object sender, EventArgs e)
        {
            GuanSz.Moues a = new GuanSz.Moues();
            a.MouseCr(this.butEyb);
        }

        private void butEyb_MouseMove(object sender, MouseEventArgs e)
        {
            GuanSz.Moues a = new GuanSz.Moues();
            a.MouseJr(this.butEyb);
        }
        //销售
        private void butExfcx_MouseLeave(object sender, EventArgs e)
        {
            GuanSz.Moues a = new GuanSz.Moues();
            a.MouseCr(this.butExfcx);
        }

        private void butExfcx_MouseMove(object sender, MouseEventArgs e)
        {
            GuanSz.Moues a = new GuanSz.Moues();
            a.MouseJr(this.butExfcx);
        }
        //年
        private void buttonEx2_MouseLeave(object sender, EventArgs e)
        {
            GuanSz.Moues a = new GuanSz.Moues();
            a.MouseCr(this.buttonEx2);
        }

        private void  buttonEx2_MouseMove(object sender, MouseEventArgs e)
        {
            GuanSz.Moues a = new GuanSz.Moues();
            a.MouseJr(this.buttonEx2);
        }
        //在店
        private void butExfmx_MouseLeave(object sender, EventArgs e)
        {
           GuanSz.Moues a = new GuanSz.Moues();
           a.MouseCr(this.butExfmx);
        }

        private void butExfmx_MouseMove(object sender, MouseEventArgs e)
        {

            GuanSz.Moues a = new GuanSz.Moues();
            a.MouseJr(this.butExfmx);
        }
        //退单
        private void butEtzx_MouseLeave(object sender, EventArgs e)
        {
            GuanSz.Moues a = new GuanSz.Moues();
            a.MouseCr(this.butEtzx);
        }

        private void butEtzx_MouseMove(object sender, MouseEventArgs e)
        {
            GuanSz.Moues a = new GuanSz.Moues();
            a.MouseJr(this.butEtzx);
        }
        
        
    }
}
