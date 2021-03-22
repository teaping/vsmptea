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
    public partial class FrmYinYeTuiD : Form
    {
        string str = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=MPcLou.accdb";
        OleDbConnection conn = null;
        OleDbCommand cmd = null;
        OleDbDataReader dr = null;
        OleDbDataAdapter da = null;
        DataSet ds = null;
        public FrmYinYeTuiD()
        {
            InitializeComponent();
        }

        private void FrmYinYeTuiD_Load(object sender, EventArgs e)
        {
            BangMx();
        }
        /// <summary>
        /// 绑定退单明细
        /// </summary>
        private void BangMx()
        {
            conn = new OleDbConnection(str);
            string sql = "select * from tb_hyxf where jszt='退单'";  
            da = new OleDbDataAdapter(sql, conn);
            ds= new DataSet();
            da.Fill(ds);
            this.dgvtd.AutoGenerateColumns = false;
            this.dgvtd.DataSource = ds.Tables[0];
        }

        /// <summary>
        /// 排序
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 按照远时间ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            conn = new OleDbConnection(str);
            string sql = "select * from tb_hyxf where jszt='退单' order by jsrq asc";  //按照时间排序
            da = new OleDbDataAdapter(sql, conn);
            ds = new DataSet();
            da.Fill(ds);
            this.dgvtd.AutoGenerateColumns = false;
            this.dgvtd.DataSource = ds.Tables[0];
        }

        private void 按照近时间ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            conn = new OleDbConnection(str);
            string sql = "select * from tb_hyxf where jszt='退单' order by jsrq desc";
            da = new OleDbDataAdapter(sql, conn);
            ds = new DataSet();
            da.Fill(ds);
            this.dgvtd.AutoGenerateColumns = false;
            this.dgvtd.DataSource = ds.Tables[0];
        }
    }
}
