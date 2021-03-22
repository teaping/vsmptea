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
    public partial class FrmXtTjSp : Form
    {

        string str = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=MPcLou.accdb";
        OleDbConnection conn = null;
        OleDbCommand cmd = null;
        OleDbDataReader dr = null;
        OleDbDataAdapter oda = null;
        DataSet ds = null;
        public string idbh = null;
        public FrmXtTjSp()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 是否自动编号
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void zhbzd_CheckedChanged(object sender, EventArgs e)
        {
            if (this.zhbzd.Checked == false)
            {
                this.txtbhzd.Enabled = true;
            }
            else
            {
                this.txtbhzd.Enabled = false;
            }
        }
        /// <summary>
        /// 自动编号绑定
        /// </summary>
        private void Szbh()
        {
            conn = new OleDbConnection(str);
            conn.Open();
            string sql = "select count(xmbh) from tb_Chuangku";
            cmd = new OleDbCommand(sql, conn);
            int xmbh =Convert.ToInt32( cmd.ExecuteScalar());
            this.txtbhzd.Text = (xmbh+1).ToString();
            conn.Close();
        }

        private void bD()
        {
            this.txtbhzd.Enabled = false;
            this.txtbjkc.Enabled = false;
            this.txtkc.Enabled = false;
            conn = new OleDbConnection(str);
            conn.Open();
            string sql = "select * from tb_Chuangku a,tb_ckf b where a.leix=b.id and xmbh=" + idbh + "";
            cmd = new OleDbCommand(sql, conn);
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                this.txtbhzd.Text = dr["xmbh"].ToString();
                this.txtxmmc.Text = dr["mc"].ToString();
                this.cmbxmlb.Text = dr["lx"].ToString();
                this.cmbjf.Text = dr["dw"].ToString();
                this.txtysdj.Text = dr["dj"].ToString();

            }


            dr.Close();

            conn.Close();
        }

        private void FrmXtSp_Load(object sender, EventArgs e)
        {
            FjBd();
            Szbh();
            //修改操作
            if (idbh!=null)
            {
                bD();
            }
        }
        /// <summary>
        /// 绑定项目类别
        /// </summary>
        private void FjBd()
        {
            conn = new OleDbConnection(str);
            string bs = "select * from tb_ckf";
            oda = new OleDbDataAdapter(bs, conn);
            ds = new DataSet();
            oda.Fill(ds);
            this.cmbxmlb.DataSource = ds.Tables[0];
            this.cmbxmlb.DisplayMember = "lx";
            this.cmbxmlb.ValueMember = "ID";

        }
        /// <summary>
        /// 添加菜品 往tb_chunagku
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            conn = new OleDbConnection(str);
            conn.Open();
            //修改操作
            if (idbh!=null)
            {
                string xg = "update tb_Chuangku set mc='" + this.txtxmmc.Text + "',leix=" + this.cmbxmlb.SelectedValue + ", dj=" + this.txtysdj.Text + ",dw='" + this.cmbjf.Text + "' where xmbh=" + idbh + " ";
                cmd = new OleDbCommand(xg, conn);
                cmd.ExecuteScalar();
            }
            else
            {
                //添加操作
            string sql = "insert into tb_Chuangku(xmbh,mc,dj,kc,leix,dw,bjkc) values(" + this.txtbhzd.Text + ",'" + this.txtxmmc.Text + "'," + this.txtysdj.Text + "," + this.txtkc.Text + "," + this.cmbxmlb.SelectedValue + ",'" + this.cmbjf.Text + "'," + this.txtbjkc.Text + ")";
            cmd = new OleDbCommand(sql, conn);
            cmd.ExecuteScalar();
            }


           
            conn.Close();
            this.Dispose();
        }
        /// <summary>
        /// 取消
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
