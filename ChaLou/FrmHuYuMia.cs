using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace ChaLou
{
    public partial class FrmHuYuMia : Form
    {
        string str = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=MPcLou.accdb";
        OleDbConnection conn = null;
        OleDbCommand cmd = null;
        OleDbDataReader dr = null;
        OleDbDataAdapter oda = null;
        public string hyid = null;
        public FrmHuYuMia()
        {
            InitializeComponent();
        }

        private void FrmHuYuMia_Load(object sender, EventArgs e)
        {
            this.txthybh.Text=hyid;
           
        }
        /// <summary>
        /// 清空全部文本
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            this.txtjmima.Text = "";
            this.txtxmima.Text = "";
            this.txtqrxmima.Text = "";
        }
        /// <summary>
        ///确认
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void butmiqr_Click(object sender, EventArgs e)
        {
            conn = new OleDbConnection(str);
            conn.Open();
            if (this.txtjmima.Text.Trim()==null)
            {
                MessageBox.Show("旧密码不能为空");
            }
            string cx = "select id from tb_huiyuan where hybh='" + hyid + "' ";
            cmd = new OleDbCommand(cx, conn);
            string lxid = cmd.ExecuteScalar().ToString();


            string cxhyidj = "select id from tb_huiyuk where kx=" + lxid + "";
            cmd.CommandText = cxhyidj;
            string kalid = cmd.ExecuteScalar().ToString();
            string xgksq = "select mi from  tb_kxf  where bh1=" + kalid + "";
            cmd.CommandText = xgksq;
            string mima = cmd.ExecuteScalar().ToString();
          
            if (this.txtjmima.Text==mima)
            {
                if (this.txtqrxmima.Text == this.txtxmima.Text && this.txtxmima.Text.Trim()!=null)
                {

                    string xgksql = "update tb_kxf set mi='"+this.txtqrxmima.Text+"'   where bh1=" + kalid + "";
                    cmd.CommandText = xgksql;
                    cmd.ExecuteScalar();
                }
                else
                {
                    MessageBox.Show("新密码或确认新密码错误");
                }
            }
            else
            {
                MessageBox.Show("旧密码错误");
            }

            conn.Close();
            this.Dispose();
        }
        /// <summary>
        /// 取消
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void butmaqx_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
