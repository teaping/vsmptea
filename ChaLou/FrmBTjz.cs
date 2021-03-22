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
    public partial class FrmBTjz : Form
    {
        string str = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=MPcLou.accdb";
        OleDbConnection conn = null;
        OleDbCommand cmd = null;
        OleDbDataReader dr = null;
        OleDbDataAdapter oda = null;
        public string jzdh;//单号
        int je;//总钱
        public FrmBTjz()
        {
            InitializeComponent();
        }

        private void FrmBTjz_Load(object sender, EventArgs e)
        {
            Bang();
        }
        /// <summary>
        /// 绑定基本数据
        /// </summary>
        private void Bang()
        {
            this.labdh.Text = jzdh;
            conn = new OleDbConnection(str);
            conn.Open();
            string sql = "select sum(jine) from tb_BtXs";
            cmd = new OleDbCommand(sql, conn);
            je=Convert.ToInt32(  cmd.ExecuteScalar());
            conn.Close();
            this.labje.Text = je.ToString();
            this.labysje.Text = je.ToString();
            this.labssje.Text = je.ToString();
        }

        private void txtzf_TextChanged(object sender, EventArgs e)
        {
           
            if (this.txtzf.Text!=""&& this.txtzf.Text!=null)
            { int zf=  int.Parse(this.txtzf.Text);
                this.labzl.Text = (je - zf).ToString();
            }
        }
        /// <summary>
        /// 结账确认
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void butjcqr_Click(object sender, EventArgs e)
        {
            conn = new OleDbConnection(str);
            conn.Open();
            int a=int.Parse( this.labzl.Text);
            if (a <=0)
            {
                string qc = "delete from tb_BtXs";
                cmd = new OleDbCommand(qc, conn);
                cmd.ExecuteScalar();
            }
            else
            {
                MessageBox.Show("输入金额不足以结账");
                return;
            }
            conn.Close();
            this.Dispose();
        }
        /// <summary>
        /// 结账退出
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
