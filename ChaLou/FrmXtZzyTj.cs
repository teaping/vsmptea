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
    public partial class FrmXtZzyTj : Form
    {
        string str = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=MPcLou.accdb";
        OleDbConnection conn = null;
        OleDbCommand cmd = null;
        OleDbDataReader dr = null;
        OleDbDataAdapter oda = null;
        DataSet ds = null;
        public string bhczy = null;

        public static int shzbcs=0;  //判断是否确认修改啊
        public FrmXtZzyTj()
        {
            InitializeComponent();
        }

        private void FrmXtZzyTj_Load(object sender, EventArgs e)
        {
            shzbcs = 0;
            conn = new OleDbConnection(str);
            conn.Open();
            if (bhczy!=null)//修改操作
            {
                this.txtbh.Enabled = false;
                string xgcs = "select * from  tb_User where bh='"+bhczy+"' ";
                cmd = new OleDbCommand(xgcs, conn);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    this.txtbh.Text = dr["bh"].ToString();
                    this.txtxm.Text = dr["UserName"].ToString();
                    this.txtmima.Text = dr["UserPwd"].ToString();
                    this.txtbmbh.Text = dr["bm"].ToString();
                    this.cmbqx.Text  =dr["powerr"].ToString();
                }

                dr.Close();
            }
            conn.Close();
        }

        private void Bpd()
        {
            conn = new OleDbConnection(str);
            conn.Open();
            int b=0;
            if (this.cmbqx.Text=="超级管理员")
	        {
		         b=1;
	        }else{
                 b=0;
            }
           //判断是否有该编号
            string bs = "select count(bh) from tb_User where bh='" +this.txtbh.Text+"' ";
            cmd = new OleDbCommand(bs, conn);
            int a=Convert.ToInt32(cmd.ExecuteScalar());
            if (a<1)
            {
                //添加人员
                string tj = "insert into tb_User (UserName,UserPwd,bh,powerr,power,bm)values('" + this.txtxm.Text + "','" + this.txtmima.Text + "','" + this.txtbh.Text + "','" + this.cmbqx.Text + "'," + b + ","+this.txtbmbh.Text+")";
                cmd.CommandText = tj;
                cmd.ExecuteScalar();
            }
            conn.Close();

        }
        /// <summary>
        /// 添加操作员
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void butbc_Click(object sender, EventArgs e)
        {
            conn = new OleDbConnection(str);
                conn.Open();
            int a = 0;
           
            if ( this.cmbqx .Text=="管理员")
            {
                a = 0;
            }
            else
            {
                a = 1;
            }

            if (bhczy!=null)//修改
            {
                
                string xg = "update  tb_User set UserName='" + this.txtxm.Text + "',UserPwd='" + this.txtmima.Text + "' ,bm=" + this.txtbmbh.Text + ",power=" +a+ ",powerr='"+this.cmbqx.Text+"'  where bh='" + bhczy + "'";
                cmd = new OleDbCommand(xg, conn);
                cmd.ExecuteScalar();
                conn.Close();
                shzbcs += 1;
            }
            else//添加
            {
               
                string cxxuz = "select id from  tb_User where  UserName='" + this.txtxm.Text + "'";
                cmd = new OleDbCommand(cxxuz, conn);
                string cxg = cmd.ExecuteScalar().ToString();
                if (cxg!=""||cxg==null)
                {
                    MessageBox.Show("会员已存在！！！");
                    return;
                }
                
                Bpd();
            }
            this.Dispose();
        }
        /// <summary>
        /// 取消
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void butqx_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
