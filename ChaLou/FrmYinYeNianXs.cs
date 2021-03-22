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
    public partial class FrmYinYeNianXs : Form
    {
        string str = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=MPcLou.accdb";
        OleDbConnection conn = null;
        OleDbCommand cmd = null;
        OleDbDataReader dr = null;
        OleDbDataAdapter oda = null;
        DataSet ds = null;
        public FrmYinYeNianXs()
        {
            InitializeComponent();
        }

        private void FrmYinYeNianXs_Load(object sender, EventArgs e)
        {
            BdRxf();
        }

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

        private void butcxr_Click(object sender, EventArgs e)
        {
            DateTime dtime = this.dateTimePicker1.Value;   //获取时间
            string sjja = dtime.ToString("yyyy-01-01");
            DateTime sjiq = DateTime.Parse(sjja);
            conn = new OleDbConnection(str);
            string sqlw = "select * from tb_hyxf where jsrq>=#" + sjiq + "#  and   jsrq<#" + sjiq.AddYears(1).ToString() + "#  "; //按照时间查询
            oda = new OleDbDataAdapter(sqlw, conn);
            ds = new DataSet();
            oda.Fill(ds);
            this.dgvrxs.AutoGenerateColumns = false;
            this.dgvrxs.DataSource = ds.Tables[0];



            //显示总钱
            conn.Open();
            string sqlwa = "select sum(shje) from tb_hyxf where jsrq>=#" + sjiq + "#  and   jsrq<#" + sjiq.AddYears(1).ToString() + "#  "; //按照时间查询
            cmd = new OleDbCommand(sqlwa, conn);
            string pdsy = cmd.ExecuteScalar().ToString();
            if (pdsy==""||pdsy==null)
            {
                this.labzxf.Text = "年总消费：0";
            }
            else
            {
                this.labzxf.Text = "年总消费：" + pdsy;
            }
          
            conn.Close();
        }
    }
}
