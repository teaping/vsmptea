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
    public partial class FrmJcSl : Form
    {
        //准备资源，设全局变量
        string str = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=MPcLou.accdb";
        OleDbConnection conn = null;
        OleDbCommand cmd = null;
        OleDbDataReader dr = null;
        public string mc;//接受名称
        string dw;
        public FrmJcSl()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 确认
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
           string d= this.dtpsj.Text;
           DateTime.Parse(d);
            conn = new OleDbConnection(str);
            conn.Open();
            string qdsql = "insert into tb_JcQd(mc,sl,dw,yxrq) values('" + this.labmc.Text + "','" + this.txtsl.Text + "','" + this.labdw.Text + "','" + this.dtpsj.Text + "')";
            cmd = new OleDbCommand(qdsql,conn);
            cmd.ExecuteNonQuery();





            conn.Close();
            this.Dispose();
        }

        /// <summary>
        /// 绑定储存数据基本值
        /// </summary>
        private void Bang1()
        {
            this.labmc.Text = mc;
            conn = new OleDbConnection(str);
            conn.Open();
            string cssql = "select * from tb_JcCk";
            cmd = new OleDbCommand(cssql, conn);
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                dw=dr["dw"].ToString();
            }
            dr.Close();
            conn.Close();
        }

        private void FrmJcSl_Load(object sender, EventArgs e)
        {
            Bang1();
            this.labdw.Text = dw;
        }
        /// <summary>
        /// 有效日期至
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chkrq_CheckedChanged(object sender, EventArgs e)
        {
          if (this.chkrq.Checked==true)
	        {
                this.dtpsj.Enabled = true; 
            }
          else
          {
             this.dtpsj.Enabled = false;
          }

        }
    }
}
