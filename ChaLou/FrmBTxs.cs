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
    public partial class FrmBTxs : Form
    {
        string str = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=MPcLou.accdb";
        OleDbConnection conn = null;
        OleDbCommand cmd = null;
        OleDbDataReader dr = null;
        OleDbDataAdapter oda = null;
        DataSet ds = null;
        string sl;//单价
        string mcc;//接受项目名称
        public FrmBTxs()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 开始结账
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button4_Click(object sender, EventArgs e)
        {
            FrmBTjz tj = new FrmBTjz();
            tj.jzdh = this.txtxsdh.Text;
            tj.ShowDialog();
            Bnagbt();
        }

        private void FrmBTxs_Load(object sender, EventArgs e)
        {
            BangdJz();
        }

       //用随机器编辑单号
        private void BangdJz()
        {
            //用随机器编辑单号
            System.Random a = new Random(System.DateTime.Now.Millisecond);
            int[] sj = new int[10];
            string dh = null;//单号定义
            for (int i = 0; i < sj.Length; i++)
            {
                sj[i] = a.Next(0, 10);
                dh += sj[i];
            }
            this.txtxsdh.Text = dh;


        }
        /// <summary>
        /// 菜品搜索
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtcp_TextChanged(object sender, EventArgs e)
        {
            this.panel1.Visible = true; 
            string dhh = this.txtcp.Text;
            if (dhh!=""&dhh!=null)
            {
                conn = new OleDbConnection(str);
                string cxcd = "select * from tb_ChuangKu where xmbh="+dhh+"";
                oda = new OleDbDataAdapter(cxcd, conn);
                ds = new DataSet();
                oda.Fill(ds);
                this.dgvcd.AutoGenerateColumns = false;
                this.dgvcd.DataSource = ds.Tables[0];
            }
            

        }
        /// <summary>
        /// 添加菜品 取消
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void butcdqx_Click(object sender, EventArgs e)
        {
            this.panel1.Visible = false;
        }
        /// <summary>
        /// 添加菜品确认
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void butcdqr_Click(object sender, EventArgs e)
        {

            string mcc = this.dgvcd.CurrentRow.Cells[1].Value.ToString();  //名称
            string spmcc = this.dgvcd.CurrentRow.Cells[2].Value.ToString();  //单价
            string time=  DateTime.Now.ToString();    //当前时间
            int sl=int.Parse(  this.txtsl.Text);
            int djj=int.Parse(spmcc);
            int zj=sl*djj;
            conn = new OleDbConnection(str);
            conn.Open();
            string tjsql = "insert into tb_BtXs(mc,dj,dh,dabl,sl,jine,jzr,rzsj) values('" + mcc + "'," + spmcc + ",'" + this.txtxsdh.Text + "',1,'" + this.txtsl.Text + "'," + zj + ",'" + FrmMain.ryy + "','" + time + "')";
            cmd = new OleDbCommand(tjsql, conn);
            cmd.ExecuteScalar();
            conn.Close();
            this.panel1.Visible = false;
            Bnagbt();
        
        }
        /// <summary>
        /// 修改菜品
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void butbtxg_Click(object sender, EventArgs e)
        {
            mcc = this.dgwqd.CurrentRow.Cells[0].Value.ToString();  //名称
            sl= this.dgwqd.CurrentRow.Cells[1].Value.ToString();  //单价
            this.labxgmc.Text = mcc;
            this.panel2.Visible = true;  
        }
        /// <summary>
        /// 修改框确认
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void butxgqr_Click(object sender, EventArgs e)
        {
            int s = int.Parse(this.txtxgsl.Text);
            int zj = int.Parse(sl) * s;
            conn = new OleDbConnection(str);
            conn.Open();
            string xg = "update tb_BtXs set sl=" + this.txtxgsl.Text + " ,jine="+zj+" where mc='" + mcc + "'";
            cmd = new OleDbCommand(xg, conn);
            cmd.ExecuteScalar();
            conn.Close();
            Bnagbt();
            this.panel2.Visible = false;  
        }
        /// <summary>
        /// 修改取消
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void butxgqx_Click(object sender, EventArgs e)
        {
            this.panel2.Visible = false;  

        }
        /// <summary>
        /// 取消退出
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button5_Click(object sender, EventArgs e)
        {
            conn = new OleDbConnection(str);
            conn.Open();
            string sc = "delete from tb_BtXs";
            cmd = new OleDbCommand(sc, conn);
            cmd.ExecuteScalar();
            conn.Close();
            this.Dispose();
        }
        /// <summary>
        /// 绑定吧台清单
        /// </summary>
        private void Bnagbt()
        {
            conn = new OleDbConnection(str);
            string sql = "select * from tb_BtXs";
            oda = new OleDbDataAdapter(sql, conn);
            ds = new DataSet();
            oda.Fill(ds);
            this.dgwqd.AutoGenerateColumns = false;
            this.dgwqd.DataSource = ds.Tables[0];
            string sqlz = "select sum(jine) from tb_BtXs ";
            conn.Open();
            cmd = new OleDbCommand(sqlz,conn);
            this.labzje.Text= cmd.ExecuteScalar().ToString();
            conn.Close();
        }
        /// <summary>
        /// 吧台销售删除菜品
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
           string mcc1 = this.dgwqd.CurrentRow.Cells[0].Value.ToString();  //名称
            DialogResult d1r= MessageBox.Show("确认要删除？？？","对话框标题", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (d1r == DialogResult.OK)
            {
                    conn = new OleDbConnection(str);
                    conn.Open();
                    string sc = "delete from tb_BtXs where mc='" + mcc1 + "' ";
                    cmd = new OleDbCommand(sc, conn);
                    cmd.ExecuteScalar();
                    conn.Close();
            }
            Bnagbt();
        }
        /// <summary>
        /// 吧台关闭
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmBTxs_FormClosing(object sender, FormClosingEventArgs e)
        {
            conn = new OleDbConnection(str);
            conn.Open();
            string qc = "delete from tb_BtXs";
            cmd = new OleDbCommand(qc, conn);
            cmd.ExecuteScalar();
            conn.Close();
        }
    }
}
