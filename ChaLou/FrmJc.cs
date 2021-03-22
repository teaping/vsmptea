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
    public partial class FrmJc : Form
    {


        //准备资源，设全局变量
        string str = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=MPcLou.accdb";
        OleDbConnection conn = null;
        OleDbCommand cmd = null;
        OleDbDataReader dr = null;
        OleDbDataAdapter oda = null;
        DataSet ds;
        public FrmJc()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 寄存商品
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void butjc_Click(object sender, EventArgs e)
        {
            FrmSpjc fq = new  FrmSpjc();
            fq.ShowDialog();
            FrmJc_Load(null, null);
        }

        /// <summary>
        /// 商品寄存股那里  单号绑定
        /// </summary>

        private void JcBang()
        {
            conn = new OleDbConnection(str);
            conn.Open();
            string bsql = "select * from tb_Jc ";
            oda = new OleDbDataAdapter(bsql, conn);
            ds = new DataSet();
            oda.Fill(ds);
            this.dgvjc.AutoGenerateColumns = false;
            this.dgvjc.DataSource = ds.Tables[0];
            conn.Close();

        }

        private void FrmJc_Load(object sender, EventArgs e)
        {
            JcBang();
        }

        /// <summary>
        /// 取出绑定
        /// </summary>
        private void QcBang()
        {
            conn = new OleDbConnection(str);
            string bsql = "select * from tb_Qc ";
            oda = new OleDbDataAdapter(bsql, conn);
            ds = new DataSet();
            oda.Fill(ds);
            this.dgvqc.AutoGenerateColumns = false;
            this.dgvqc.DataSource = ds.Tables[0];
        }



        /// <summary>
        /// 取出按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void butqc_Click(object sender, EventArgs e)
        {  
            
            string id1 = this.dgvjc.CurrentRow.Cells[0].Value.ToString();//id  //获取单号
          

            if (id1==""||id1==null)
            {
                MessageBox.Show("未选中或没有该数据");
            }
            else { 
          
                conn = new OleDbConnection(str);
                conn.Open();
                string yssl = "select sysl from tb_Jc where id=" + id1 + " ";
                cmd = new OleDbCommand(yssl, conn);
            
                int sysl=Convert.ToInt32(   cmd.ExecuteScalar());//拿出剩余数量判断
                conn.Close();
                if (id1 == "" || id1 == null)
                {
                    MessageBox.Show("请选择要取出的数据");

                }else if (sysl==0)
                {
                    MessageBox.Show("已经没有东西可以取了");
                }
                else
                {
                    conn = new OleDbConnection(str);
                    conn.Open();
                    string scsql = "delete from tb_JcQd where id=" + id1 + ""; 
                    cmd = new OleDbCommand(scsql, conn);
                    cmd.ExecuteScalar();
                    conn.Close();
                    FrmSpQc q = new FrmSpQc();
                    q.jsid = id1;
                    q.ShowDialog();
                    QcBang();
                    JcBang();
                }
            }
            
        }

        /// <summary>
        /// 双击单元格查看取出消息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvjc_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            string mcc = this.dgvjc.CurrentRow.Cells[1].Value.ToString();  //获取顾客名称
            string spmcc = this.dgvjc.CurrentRow.Cells[2].Value.ToString();  //商品获取名称
            conn = new OleDbConnection(str);
            string bsql = "select * from tb_Qc where mc='"+mcc+"'and spmc='"+spmcc+"'  "; //根据商品顾客查看消息
            oda = new OleDbDataAdapter(bsql, conn);
            ds = new DataSet();
            oda.Fill(ds);
            this.dgvqc.AutoGenerateColumns = false;
            this.dgvqc.DataSource = ds.Tables[0];
        }

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void butsc_Click(object sender, EventArgs e)
        {
            string mcc = this.dgvjc.CurrentRow.Cells[1].Value.ToString();  //获取顾客名称
            string spmcc = this.dgvjc.CurrentRow.Cells[2].Value.ToString();  //商品获取名称
            conn = new OleDbConnection(str);
            conn.Open();

             DialogResult  dqr = MessageBox.Show("删除后就不能恢复，真的要删除？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation); //弹出删除框判断是否要删除
             if (dqr == DialogResult.OK)
             {
                 string sc = "delete from tb_Jc where mc='" + mcc + "'and spmc='" + spmcc + "' ";
                 cmd = new OleDbCommand(sc, conn);
                 cmd.ExecuteScalar();
                 string sc1 = "delete from tb_Qc where mc='" + mcc + "'and spmc='" + spmcc + "' ";
                 cmd = new OleDbCommand(sc1, conn);
                 cmd.ExecuteScalar();
             }
            conn.Close();
            QcBang();
            JcBang();
        }
        /// <summary>
        /// 查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void butcx_Click(object sender, EventArgs e) 
        {
            if (this.txtdh.Text!=""||this.txtdh.Text!=null)  //判断查询值的文本框是否为空
            {
                conn=new OleDbConnection(str);
                conn.Open();
                string mhsql = "select * from tb_Jc where mc like '%" + this.txtdh.Text + "%' or  ID like '%" + this.txtdh.Text + "%' ";  //按照姓名，单号模糊查询
                oda = new OleDbDataAdapter(mhsql, conn);     //重新绑定dgvjc
                ds = new DataSet();
                oda.Fill(ds);
                this.dgvjc.AutoGenerateColumns = false;
                this.dgvjc.DataSource = ds.Tables[0];
            }
        }
    }
}
