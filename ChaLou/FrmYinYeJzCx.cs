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
    public partial class FrmYinYeJzCx : Form
    {
        string str = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=MPcLou.accdb";
        OleDbConnection conn = null;
        OleDbCommand cmd = null;
        OleDbDataReader dr = null;
        OleDbDataAdapter oda = null;
        DataSet ds = null;
        public FrmYinYeJzCx()
        {
            InitializeComponent();
        }

        private void FrmYinYeJzCx_Load(object sender, EventArgs e)
        {
            BdZd();
        }

        /// <summary>
        /// 绑定结账状态查询
        /// </summary>
        private void BdZd()
        {
            conn = new OleDbConnection(str);
            string sc = "select * from tb_hyxf ";
            oda = new OleDbDataAdapter(sc, conn);
            ds = new DataSet();
            oda.Fill(ds);
            this.dgvjdxx.AutoGenerateColumns = false;
            this.dgvjdxx.DataSource = ds.Tables[0];
        }
        /// <summary>
        /// 结账信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 结账宾客ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            conn = new OleDbConnection(str);
            string sc = "select * from tb_hyxf  where jszt='已结单' ";
            oda = new OleDbDataAdapter(sc, conn);
            ds = new DataSet();
            oda.Fill(ds);
            this.dgvjdxx.AutoGenerateColumns = false;
            this.dgvjdxx.DataSource = ds.Tables[0];
        }

        private void 会员充值ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            conn = new OleDbConnection(str);
            string sc = "select * from tb_hyxf  where jszt='充值卡充值' ";
            oda = new OleDbDataAdapter(sc, conn);
            ds = new DataSet();
            oda.Fill(ds);
            this.dgvjdxx.AutoGenerateColumns = false;
            this.dgvjdxx.DataSource = ds.Tables[0];
        }
    }
}
