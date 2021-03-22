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
    public partial class FrmYinYeLaiBin : Form
    {

        string str = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=MPcLou.accdb";
        OleDbConnection conn = null;
        OleDbCommand cmd = null;
        OleDbDataReader dr = null;
        OleDbDataAdapter oda = null;
        DataSet ds = null;
        public FrmYinYeLaiBin()
        {
            InitializeComponent();
        }

        private void FrmYinYeLaiBin_Load(object sender, EventArgs e)
        {
            BangLin();
        }

        /// <summary>
        /// 绑定在店信息表
        /// </summary>
        private void BangLin()
        {
            conn = new OleDbConnection(str);
            string sc = "select * from tb_LaiBing ";
            oda = new OleDbDataAdapter(sc, conn);
            ds = new DataSet();
            oda.Fill(ds);
            this.dgvlbxx.AutoGenerateColumns = false;
            this.dgvlbxx.DataSource = ds.Tables[0];
        }
        /// <summary>
        /// 根据姓名/餐台号查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void butcx_Click(object sender, EventArgs e)
        {
            conn = new OleDbConnection(str);
            string sc = "select * from tb_LaiBing where cth='"+this.txtcxlb.Text+"' ";
            oda = new OleDbDataAdapter(sc, conn);
            ds = new DataSet();
            oda.Fill(ds);
            this.dgvlbxx.AutoGenerateColumns = false;
            this.dgvlbxx.DataSource = ds.Tables[0];
        }




    }
}
