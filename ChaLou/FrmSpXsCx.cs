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
    public partial class FrmSpXsCx : Form
    {
        public static string str = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=MPcLou.accdb";
        OleDbDataAdapter da = null;
        OleDbDataReader dr = null;
        OleDbConnection conn = null;
        OleDbCommand cmd = null;
        DataSet ds = null;
        public FrmSpXsCx()
        {
            InitializeComponent();
        }

        private void FrmSpXsCx_Load(object sender, EventArgs e)
        {
            BdngXf();
        }

        /// <summary>
        /// 绑定消费
        /// </summary>
        private void BdngXf()
        {
            conn = new OleDbConnection(str);
            string sql = "select * from tb_xfcxlx ";
            da = new OleDbDataAdapter(sql, conn);
            ds = new DataSet();
            da.Fill(ds);
            this.dgvxfcx.AutoGenerateColumns = false;
            this.dgvxfcx.DataSource = ds.Tables[0];
        }

        //按照时间判断
        private void butcx_Click(object sender, EventArgs e)
        {
            conn = new OleDbConnection(str);
            string sql = "select * from tb_xfcxlx where dcsj>=#"+this.dateTimePicker1.Text+"# and dcsj<=#"+this.dateTimePicker2.Text+"#";
            da = new OleDbDataAdapter(sql, conn);
            ds = new DataSet();
            da.Fill(ds);
            this.dgvxfcx.AutoGenerateColumns = false;
            this.dgvxfcx.DataSource = ds.Tables[0];

        }
    }
}
