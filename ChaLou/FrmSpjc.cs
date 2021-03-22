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
    public partial class FrmSpjc : Form
    {
        //准备资源，设全局变量
        string str = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=MPcLou.accdb";
        OleDbConnection conn = null;
        OleDbCommand cmd = null;
        OleDbDataReader dr = null;
        OleDbDataAdapter oda = null;
        DataSet ds = null;
        string zsl;
        public FrmSpjc()
        {
            InitializeComponent();
        }

        private void FrmSpjc_Load(object sender, EventArgs e)
        {
            Blb();//左侧
            Blbg();//右侧
        }

        //绑定库存商品列表
        private void Blb()
        {
            conn = new OleDbConnection(str);
            string bang = "select * from tb_JcCk";
            oda = new OleDbDataAdapter(bang, conn);
            ds = new DataSet();
            oda.Fill(ds);
            this.dgvlb.AutoGenerateColumns = false;
            this.dgvlb.DataSource = ds.Tables[0];
        }

        /// <summary>
        /// 商品清单
        /// </summary>
        private void Blbg()
        {
            conn = new OleDbConnection(str);
            string bang = "select * from tb_JcQd";
            oda = new OleDbDataAdapter(bang, conn);
            ds = new DataSet();
            oda.Fill(ds);
            this.dgvqd.AutoGenerateColumns = false;
            this.dgvqd.DataSource = ds.Tables[0];
        }
        /// <summary>
        /// 添加图片键
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buty_Click(object sender, EventArgs e)
        {
            string xmmc = this.dgvlb.CurrentRow.Cells[1].Value.ToString();//名称
            FrmJcSl fq = new FrmJcSl();
            fq.mc = xmmc;
            fq.ShowDialog();
            Blbg();

        }
        /// <summary>
        /// 文本框值判断  日期控件是否可使用
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtyhmc_TextChanged(object sender, EventArgs e)
        {
            if (this.txtyhmc.Text=="")
	        {
                this.butqr.Enabled = false;
            }
            else
            {
                this.butqr.Enabled = true;
            }
            
        }
        /// <summary>
        /// 取消
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            conn = new OleDbConnection(str);
            conn.Open();
            string bang = "delete * from tb_JcQd";
            cmd = new OleDbCommand(bang, conn);
            cmd.ExecuteScalar();
            conn.Close();
            this.Close();
        }
        /// <summary>
        /// 寄存清单确认按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void butqr_Click(object sender, EventArgs e)
        {
          string dqsjj=  DateTime.Now.ToString(); 
            string mc1=null,dw=null,sll=null,yxrq=null;
            conn = new OleDbConnection(str);
            conn.Open();
            string bang = "select * from tb_JcQd";
            cmd=new OleDbCommand(bang,conn);
            dr=cmd.ExecuteReader();
            if (dr.Read())
	        {
		        mc1=dr["mc"].ToString();
                dw=dr["dw"].ToString();
                sll=dr["sl"].ToString();
                yxrq=dr["yxrq"].ToString();
	        }
            dr.Close();
            //----------------------------------------------------------------------

            //添加tb_Jc

            zsl = sll;
            string tjjcsql = "insert into tb_Jc (mc,spmc,dw,sl,sysl,jcrq,yxrq,czy) values('" + this.txtyhmc.Text + "','" + mc1 + "','" + dw + "'," + sll + "," + zsl + ",'"+dqsjj+"','" + yxrq + "','" + FrmMain.ryy + "') ";
            cmd.CommandText = tjjcsql;
            cmd.ExecuteScalar();
            
            ///删除tb_jaqd中的数
            string scjc = "delete from tb_JcQd ";
            cmd.CommandText =scjc;
            cmd.ExecuteScalar();
            conn.Close();
            this.Dispose();
        
        
        
        }
        /// <summary>
        /// 左边删除 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void butz_Click(object sender, EventArgs e)
        {
            conn = new OleDbConnection(str);
            conn.Open();
            string id1= this.dgvqd.CurrentRow.Cells[4].Value.ToString();//id  //获取id删除
            if (id1 == "" || id1 == null)
            {
                MessageBox.Show("请选择要移除的数据");

            }
            else
            {
                string scsql = "delete from tb_JcQd where id=" + id1 + "";
                cmd = new OleDbCommand(scsql, conn);
                cmd.ExecuteScalar();
            }
            Blbg();  //刷新
            conn.Close();
        }
    }
}
