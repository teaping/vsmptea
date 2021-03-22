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
    public partial class FrmXtXg : Form
    {
        string str = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=MPcLou.accdb";
        OleDbConnection conn = null;
        OleDbCommand cmd = null;
        OleDbDataReader dr = null;
        OleDbDataAdapter oda = null;
        DataSet ds = null;
        public string cthh = null;
        public FrmXtXg()
        {
            InitializeComponent();
        }

        private void FrmXtXg_Load(object sender, EventArgs e)
        {
            FjBd();
            Bangd();
        }

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
        /// 绑定房间类型
        /// </summary>
        private void FjBd()
        {
            conn = new OleDbConnection(str);
            conn.Open();
            string bs = "select * from tb_RoomLx";
            oda = new OleDbDataAdapter(bs, conn);
            ds = new DataSet();
            oda.Fill(ds);
            this.cmbxglx.DataSource = ds.Tables[0];
            this.cmbxglx.DisplayMember = "fjlx";
            this.cmbxglx.ValueMember = "ID";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.dgwbh.Show();
        }
        /// <summary>
        /// 选择服务员修改
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

            this.txtfws.Text = zhi;
            this.dgwbh.Hide();
        }
        /// <summary>
        /// 保存
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void butxgbc_Click(object sender, EventArgs e)
        {
            conn = new OleDbConnection(str);
            conn.Open();
            string name1 = null, jc = null, typer = null, bjf = null, wz = null,idl=null;
            switch (this.cmbxglx.Text)
            {
                case "一楼大厅":
                    name1 = "大厅-" + this.txtxgbh.Text;
                    jc = this.txtxgbh.Text;
                    typer = "普通";
                    bjf = "10";
                    wz="大厅";
                    idl = "1";
                    break;
                case "一楼大包":
                    name1 = "大包房-" + this.txtxgbh.Text;
                    jc = "A" + this.txtxgbh.Text;
                    bjf = "80";
                    typer = "高级";
                      wz="大包房";
                      idl = "3";
                    break;
                case "二楼小包":
                    name1 = "包房-" + this.txtxgbh.Text;
                    jc = "B" + this.txtxgbh.Text;
                    typer = "中级";
                    bjf = "40";
                    idl = "2";
                     wz="包房";
                    break;
            }
            //按名字查询是否有该条数据
            string cssql = "select count(RoomJC) from tb_Room where RoomName='" + name1 + "'";
            cmd = new OleDbCommand(cssql, conn);
            int a = Convert.ToInt32(cmd.ExecuteScalar());
            if (a >= 1)
            {
                MessageBox.Show("已有该房间");
                conn.Close();
                return;
            }
            else
            {

            //按编号修改桌台信息
            string tjsql = "update tb_Room set idl="+idl+", RoomName='" + name1 + "',RoomJc='" + this.txtxgbh.Text + "',RoomBJF=" + bjf + ",RoomWz='" + wz + "',RoomSz='" + this.cmbxglx.Text + "',RoomType='" + typer + "',WaiterName='" + this.txtfws.Text + "' where RoomJC='"+cthh+"'  ";
            cmd.CommandText=tjsql;
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
        private void butxgqx_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
         
     
    }
}
