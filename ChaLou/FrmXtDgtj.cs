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
    public partial class FrmXtDgtj : Form
    {
        string str = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=MPcLou.accdb";
        OleDbConnection conn = null;
        OleDbCommand cmd = null;
        OleDbDataReader dr = null;
        OleDbDataAdapter oda = null;
        DataSet ds = null;
        public FrmXtDgtj()
        {
            InitializeComponent();
        }

        private void FrmXtDgtj_Load(object sender, EventArgs e)
        {
            FjBd();
            Bangd();
        }


        /// <summary>
        /// 绑定点击的小框
        /// </summary>
        private void Bangd()
        {
            conn = new OleDbConnection(str);
            string sql = "select * from tb_Waiter";
            oda = new OleDbDataAdapter(sql, conn);
            ds = new DataSet();
            oda.Fill(ds);
            this.dgwbh.AutoGenerateColumns = false;
            this.dgwbh.DataSource = ds.Tables[0];
        }
        /// <summary>
        /// 绑定基本
        /// </summary>
        private void FjBd()
        {
            conn = new OleDbConnection(str);
            conn.Open();
            string bs = "select * from tb_RoomLx";
            oda = new OleDbDataAdapter(bs, conn);
            ds = new DataSet();
            oda.Fill(ds);
            this.cmbfjlx.DataSource = ds.Tables[0];
            this.cmbfjlx.DisplayMember = "fjlx";
            this.cmbfjlx.ValueMember = "ID";

        }
        /// <summary>
        /// 取消
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void butzjctqx_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.dgwbh.Show();
        }

        private void dgwbh_SelectionChanged(object sender, EventArgs e)
        {
            string zhi = null;
            if (this.dgwbh.SelectedCells.Count != 0)
            {
                //得到选中行的索引
                int intRow = this.dgwbh.SelectedCells[0].RowIndex;
                 //得到列的索引
                int intColumn = this.dgwbh.SelectedCells[0].ColumnIndex;
                 //得到选中行某列的值
               zhi = this.dgwbh.CurrentRow.Cells[1].Value.ToString();
            }

            this.txtwfs.Text = zhi;
           this.dgwbh.Hide();
        }
        /// <summary>
        /// 保存
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void butzjctbc_Click(object sender, EventArgs e)
        {
            string rs = null, bz = null, xf = null, name1 = null, jc = null, typer = null, bjf = null, wz = null ;
            int zdrs = 0;
            conn = new OleDbConnection(str);
            conn.Open();
            string tjfl = "select * from tb_RoomLx where  fjlx ='" + this.cmbfjlx.Text + "'";
            cmd = new OleDbCommand(tjfl, conn);
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                rs = dr["rs"].ToString();
                bz = dr["bz"].ToString();
                xf = dr["xf"].ToString();
            }
            dr.Close();
            //加文字到达效果
            switch (this.cmbfjlx.Text)
	        {
                case "一楼大厅":
                    name1="大厅-"+this.txtzbh.Text;
                    jc=this.txtzbh.Text;
                    typer="普通";
                    bjf="10";
                    wz="大厅";
                    zdrs = 10;
                    break;
                case "一楼大包":
                    name1="大包房-"+this.txtzbh.Text;
                    jc="A"+this.txtzbh.Text;
                    typer="高级";
                    bjf="80";
                    wz="大包房";
                    zdrs = 12;
                    break;
                case "二楼小包":
                    name1="包房-"+this.txtzbh.Text;
                    jc="B"+this.txtzbh.Text;
                    typer="中级";
                    bjf="40";
                    wz="包房";
                    zdrs=8;
                    break;
	        }
               string cssql = "select count(RoomJC) from tb_Room where RoomName='" + name1 + "'";
               cmd.CommandText = cssql;
               int a=Convert.ToInt32( cmd.ExecuteScalar());
            if (a>=1)
            {
                MessageBox.Show("已有该房间");
                conn.Close();
            }
            else
            {
                string sql = "insert into tb_Room (RoomName,RoomJC,RoomBJF,RoomWZ,Roomsz,RoomType,WaiterName,yczdrs) values('" + name1 + "','" + jc + "'," + bjf + ",'" + wz + "','" + this.cmbfjlx.Text + "','" + typer + "','" + this.txtwfs.Text + "',"+zdrs+")";
                cmd.CommandText = sql;
                cmd.ExecuteScalar();
                conn.Close();
                this.Dispose();
            }

        }
    }
}
