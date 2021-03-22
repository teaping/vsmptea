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
    public partial class FrmYinYeYuex : Form
    {
        string str = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=MPcLou.accdb";
        OleDbConnection conn = null;
        OleDbCommand cmd = null;
        OleDbDataReader dr = null;
        OleDbDataAdapter oda = null;
        DataSet ds = null;
        public FrmYinYeYuex()
        {
            InitializeComponent();
        }

        private void FrmYinYeYuex_Load(object sender, EventArgs e)
        {
            BdRxf();
            BangDy();
        }
        /// <summary>
        /// 绑定日消费
        /// </summary>

        private void BdRxf()
        {

            conn = new OleDbConnection(str);
            string sql = "select * from tb_hyxf ";
            oda = new OleDbDataAdapter(sql, conn);
            ds = new DataSet();
            oda.Fill(ds);
            this.dgvrxs.AutoGenerateColumns = false;
            this.dgvrxs.DataSource = ds.Tables[0];
        }
        /// <summary>
        /// 查询日
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void butcxr_Click(object sender, EventArgs e)
        {
         
            DateTime dtim = this.dateTimePicker1.Value;   //获取时间
            string sjja =dtim.ToString("yyyy-MM-dd");
            conn = new OleDbConnection(str);
            string sql12 = "select * from tb_hyxf where jsrq>=#" + sjja + "# and  jsrq<#" + dtim.AddDays(1).ToString() + "# "; //按照时间查询
            oda = new OleDbDataAdapter(sql12, conn);
            ds = new DataSet();
            oda.Fill(ds);
            this.dgvrxs.AutoGenerateColumns = false;
            this.dgvrxs.DataSource = ds.Tables[0];

            //显示总钱
            conn.Open();
            string sqlcx = "select sum(shje) from tb_hyxf where jsrq>=#" + sjja + "# and  jsrq<#" + dtim.AddDays(1).ToString() + "#"; //按照时间查询
            cmd = new OleDbCommand(sqlcx,conn);
            string pdsy = cmd.ExecuteScalar().ToString();
            if (pdsy == "" || pdsy == null)
            {
                this.labzxf.Text = "日总消费：0";
            }
            else
            {
                this.labzxf.Text ="日总消费：" +pdsy;
            }


            
            conn.Close();

        }


        /// <summary>
        /// 绑定月
        /// </summary>
        private void BangDy()
        {
            conn = new OleDbConnection(str);
            string sql = "select * from tb_hyxf ";
            oda = new OleDbDataAdapter(sql, conn);
            ds = new DataSet();
            oda.Fill(ds);
            this.dgvycx.AutoGenerateColumns = false;
            this.dgvycx.DataSource = ds.Tables[0];
        }
        /// <summary>
        /// 月消费
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void butycx_Click(object sender, EventArgs e)
        {
            DateTime dtime = this.dateTimePicker2.Value;   //获取时间
            string sjja = dtime.ToString("yyyy-MM-01");
            DateTime sjiq = DateTime.Parse(sjja);
            
            conn = new OleDbConnection(str);
            string sqlw = "select * from tb_hyxf where jsrq>=#" + sjiq + "#  and   jsrq<#" + sjiq.AddMonths(1).ToString() + "#  "; //按照时间查询
            oda = new OleDbDataAdapter(sqlw, conn);
            ds = new DataSet();
            oda.Fill(ds);
            this.dgvycx.AutoGenerateColumns = false;
            this.dgvycx.DataSource = ds.Tables[0];


            //显示总钱
            conn.Open();
            string sqlcx = "select sum(shje) from tb_hyxf where jsrq>=#" + sjiq + "#  and   jsrq<#" + sjiq.AddMonths(1).ToString() + "#"; //按照时间查询
            cmd = new OleDbCommand(sqlcx, conn);

            string pdsy = cmd.ExecuteScalar().ToString();
            if (pdsy == "" || pdsy == null)
            {
                this.label1.Text = "月总消费：0";
            }
            else
            {
                this.label1.Text = "月总消费：" + pdsy;
            }
            conn.Close();

        }
    }
}
