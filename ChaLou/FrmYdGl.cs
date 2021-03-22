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
    public partial class FrmYdGl : Form
    {
        string str = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=MPcLou.accdb";
        OleDbConnection conn = null;
        OleDbCommand cmd = null;
        OleDbDataReader dr = null;
        OleDbDataAdapter oda = null;
        DataSet ds = null;
        public static string lxwz = null; //类型
        public static string cthhm = null;//餐台号
        public FrmYdGl()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 预定增加
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void butydtj_Click(object sender, EventArgs e)
        {
            FrmYuDingDJ f = new FrmYuDingDJ();
            f.ShowDialog();
            BangY();
        }

        private void FrmYdGl_Load(object sender, EventArgs e)
        {
            BangY();
        }

        /// <summary>
        /// 绑定预定信息表
        /// </summary>
        private void BangY()
        {
            conn = new OleDbConnection(str);
            string sql = "select * from tb_YuDing";
            oda = new OleDbDataAdapter(sql, conn);
            ds = new DataSet();
            oda.Fill(ds);
            this.dgvyd.AutoGenerateColumns = false;
            this.dgvyd.DataSource = ds.Tables[0];
        }
        /// <summary>
        /// 预定修改
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            string xm = this.dgvyd.CurrentRow.Cells[0].Value.ToString();//名称
            FrmYuDingDJ f = new FrmYuDingDJ();
            f.jsxm = xm;
            f.ShowDialog();
            BangY();
        }
        /// <summary>
        /// 预定删除
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            string xm = this.dgvyd.CurrentRow.Cells[0].Value.ToString();//名称
            string bh = this.dgvyd.CurrentRow.Cells[3].Value.ToString();//b编号
            conn = new OleDbConnection(str);
            conn.Open();
            DialogResult  dqr = MessageBox.Show("删除后就不能恢复，真的要删除？", "登录提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            if (dqr == DialogResult.OK)
            {
             
             string sc = "delete from tb_YuDing where xm='" + xm + "'";
             cmd = new OleDbCommand(sc, conn);
             cmd.ExecuteScalar();
             string xgzy = "update tb_Room  set  RoomZT='待用' where RoomJC='" + bh + "'";
             cmd.CommandText = xgzy;
             cmd.ExecuteScalar();
            }

            BangY();
            conn.Close();

        }
        /// <summary>
        /// 预定开单------------未完成
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button5_Click(object sender, EventArgs e)
        {
           
            string ztlx = this.dgvyd.CurrentRow.Cells[2].Value.ToString();//类型
            FrmYdGl.cthhm = this.dgvyd.CurrentRow.Cells[3].Value.ToString();//编号

            switch (ztlx)
            {
                case "大厅":
                    lxwz = "一楼大厅";
                    break;
                case "包房":
                    lxwz = "二楼小包";
                    break;
                case "大包房":
                    lxwz = "一楼大包";
                    break;
            }
            this.Dispose();

        }
        /// <summary>
        /// 查询房间
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void butchaxfj_Click(object sender, EventArgs e)
        {
            conn = new OleDbConnection(str);
            //按照编号查找
            string sql = "select * from tb_YuDing where bh='" + this.txtchaxfjh .Text+ "'";
            oda = new OleDbDataAdapter(sql, conn);
            ds = new DataSet();
            oda.Fill(ds);
            this.dgvyd.AutoGenerateColumns = false;
            this.dgvyd.DataSource = ds.Tables[0];
        }
    }
}
