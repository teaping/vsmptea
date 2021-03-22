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
    public partial class FrmHuYuCz : Form
    {
        public string bh;
        string kaid = null;
        string str = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=MPcLou.accdb";
        OleDbConnection conn = null;
        OleDbCommand cmd = null;
        OleDbDataReader dr = null;
        OleDbDataAdapter oda = null;
        public FrmHuYuCz()
        {
            InitializeComponent();
        }

        private void FrmHuYuCz_Load(object sender, EventArgs e)
        {
            string id = null;
            conn = new OleDbConnection(str);
            conn.Open();
            string sql= "select * from tb_huiyuan where hybh='" + bh + "'";
            cmd = new OleDbCommand(sql, conn);
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                this.labbh.Text = bh;
                this.labxm.Text = dr["name"].ToString();
                id = dr["id"].ToString();
            }
            dr.Close();
            string sql1 = "select id from tb_huiyuk where kx=" + id + "";
            cmd.CommandText = sql1;
            object hykid= cmd.ExecuteScalar();

            string sql2 = "select ye from tb_kxf where bh1=" + hykid + "";
            cmd.CommandText = sql2;
            object ye = cmd.ExecuteScalar();
            kaid = ye.ToString();
            this.labye.Text = ye.ToString();
            conn.Close();
        }
        /// <summary>
        /// 充值金额改变
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtczje_TextChanged(object sender, EventArgs e)
        {
            this.labxj.Text = this.txtczje.Text;
        }
        /// <summary>
        /// 确认
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void butczqr_Click(object sender, EventArgs e)
        {
            int a = 0;
            conn = new OleDbConnection(str);
            conn.Open();
            string sql = "select c.id from tb_huiyuan a,tb_huiyuk b,tb_kxf c where a.id=b.kx and b.id=c.bh1 and a.hybh='" + this.labbh .Text+ "'  ";//拿到顾客姓名进行多表联查
            cmd = new OleDbCommand(sql, conn);
            string kxfid = cmd.ExecuteScalar().ToString();
            
            string czsql = "update tb_kxf set ye=ye+" + int.Parse(this.txtczje.Text) + " where id=" +kxfid+ " ";
            cmd.CommandText = czsql;
            cmd.ExecuteScalar();

            Random r = new Random();
            for (int i = 0; i < 6; i++)
            {
                a += r.Next(0, 10);
            }

            string tjsql = "insert into tb_hyxf(mc,xfrq,jsrq,hybh,zdh,cth,ysje,shje,jszt) values('" + this.labxm.Text + "','" + DateTime.Now + "','" + DateTime.Now + "','" + this.labbh.Text + "','" + a + "','*'," + this.txtczje.Text + "," + this.txtczje .Text+ ",'充值卡充值')";
            cmd.CommandText = tjsql;
            cmd.ExecuteScalar();
            conn.Close();
            this.Dispose();
        }
        /// <summary>
        /// 取消
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void butczqx_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
