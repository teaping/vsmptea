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
    public partial class FrmCwGl : Form
    {
        string str = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=MPcLou.accdb";
        OleDbConnection conn = null;
        OleDbCommand cmd = null;
        OleDbDataReader dr = null;
        OleDbDataAdapter oda = null;
        DataSet ds = null;
        public FrmCwGl()
        {
            InitializeComponent();
        }

        private void FrmCwGl_Load(object sender, EventArgs e)
        {
            Bangyg();
        }



        private void Bangyg()
        {
            conn = new OleDbConnection(str);
            string sql = "select * from tb_hyxf";
            oda = new OleDbDataAdapter(sql, conn);
            ds = new DataSet();
            oda.Fill(ds);
            this.dgvcw.AutoGenerateColumns = false;
            this.dgvcw.DataSource = ds.Tables[0];
        }

        private void 会员充值消费ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            conn = new OleDbConnection(str);
            string sql = "select * from tb_hyxf where jszt='充值卡充值'";
            oda = new OleDbDataAdapter(sql, conn);
            ds = new DataSet();
            oda.Fill(ds);
            this.dgvcw.AutoGenerateColumns = false;
            this.dgvcw.DataSource = ds.Tables[0];
        }

        private void 桌台消费ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            conn = new OleDbConnection(str);
            string sql = "select * from tb_hyxf where jszt='已结单'";
            oda = new OleDbDataAdapter(sql, conn);
            ds = new DataSet();
            oda.Fill(ds);
            this.dgvcw.AutoGenerateColumns = false;
            this.dgvcw.DataSource = ds.Tables[0];
        }
    }
}
