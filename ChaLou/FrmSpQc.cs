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
    public partial class FrmSpQc : Form
    {
        string str = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=MPcLou.accdb";
        OleDbConnection conn = null;
        OleDbCommand cmd = null;
        OleDbDataReader dr = null;
        OleDbDataAdapter oda = null;
        public string jsid = null;//接受的id
        string rwmc = null;//人
        string idd = null;//id
        int a;//取出后的剩余数量

        public FrmSpQc()
        {
            InitializeComponent();
        }

        private void FrmSpQc_Load(object sender, EventArgs e)
        {
            Bang();
        }
        /// <summary>
        /// 绑定基本数据
        /// </summary>
        private void Bang()
        {
          
            conn = new OleDbConnection(str);
            conn.Open();
            string cxqsl = "select * from tb_Jc where id="+jsid+" ";
            cmd = new OleDbCommand(cxqsl, conn);
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                this.labsp.Text = dr["spmc"].ToString();
                this.labsl.Text = dr["sysl"].ToString();
                this.labsy.Text = dr["dw"].ToString();
                this.labqc.Text = dr["dw"].ToString();
                rwmc = dr["mc"].ToString();
                idd = dr["id"].ToString();
            }
            dr.Close();
            conn.Close();
        }

        /// <summary>
        /// 判断取出数量问题（文本框数量）
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtqc_TextChanged(object sender, EventArgs e)
        {
            int sl=0;
            if (this.txtqc.Text!=""&&this.txtqc.Text!=null)
            {
                sl=int.Parse(this.txtqc.Text);//要取出数量
            
               int syl = int.Parse(this.labsl.Text); //剩余数量
           
               if (syl-sl>=0)
               {
                  a= syl-sl;//取出之后的
               }
               else
               {
                   MessageBox.Show("数量不符");
               }
            }
        }

        private void butqx_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        /// <summary>
        /// 确认 wang取出表添加
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtqr_Click(object sender, EventArgs e)
        {
           string sj=DateTime.Now.ToString();     
            conn = new OleDbConnection(str);
            conn.Open();
            string cxqsl = "insert into tb_Qc (mc,spmc,dw,qcsl,qcrq,czy,bm) values('" + rwmc + "','" + this.labsp.Text + "','" + this.labsy.Text + "'," + this.txtqc.Text + ",'" + sj + "','" + FrmMain.ryy + "','" + idd+ "') ";
            cmd = new OleDbCommand(cxqsl, conn);
            cmd.ExecuteScalar();

            string xgsql = "update tb_Jc set sysl=" + a + " where id=" + jsid + " ";
            cmd.CommandText = xgsql;
            cmd.ExecuteScalar();
            conn.Close();
            this.Dispose();
        }
    }
}
