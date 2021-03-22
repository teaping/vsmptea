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
    public partial class FrmXtFjTj : Form
    {
        string str = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=MPcLou.accdb";
        OleDbConnection conn = null;
        OleDbCommand cmd = null;
        OleDbDataReader dr = null;
        OleDbDataAdapter oda = null;
        public string num = null;
        DataSet ds = null;
        string zid = null;//获取总表id
        public FrmXtFjTj()
        {
            InitializeComponent();
        }

        private void FrmXtFjTj_Load(object sender, EventArgs e)
        {
            if (num!=null)
            {
                Bj();
            }
        }
        /// <summary>
        ///  修改 绑定基本
        /// </summary>
        private void Bj()
        {
            this.Text = "修改房间类型";
            conn = new OleDbConnection(str);
            conn.Open();
            string sc = "select * from tb_RoomLx where fjlx='" + num + "' ";
            cmd = new OleDbCommand(sc, conn);
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                this.txtfjlx.Text = dr["fjlx"].ToString();
                this.txtzdxf.Text = dr["xf"].ToString();
                this.txtrs.Text = dr["rs"].ToString();
                zid = dr["id"].ToString();

            }
            dr.Close();
            conn.Close();
        }


        /// <summary>
        /// 设置消费
        /// </summary>
        private void chbzdbz_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chbzdbz.Checked==true)
	        {
                this.cmbjfbz.Enabled = true;
            }
            else
            {
                this.cmbjfbz.Enabled = false ;
            }
            
        }
        /// <summary>
        /// 修改and 增加保存  
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            conn = new OleDbConnection(str);
            conn.Open();
            
            ////调用类 XtTj.cs这个是添加类型
            //if (this.txtfjlx.Text!=null)
            //{
            //    string tjlx = "insert into tb_RoomLX(fjlx,rs,bz,xf) values('" + this.txtfjlx.Text + "'," + this.txtrs.Text + ",'" + this.cmbjfbz .Text+ "',"+this.txtzdxf.Text+") ";
            //    cmd = new OleDbCommand(tjlx, conn);
            //    cmd.ExecuteScalar();
            //    GuanSz.XtTj ds = new GuanSz.XtTj(); //添加类型
            //    ds.AddPage(FrmMain.tbc, this.txtfjlx.Text); 
            //}


            string xglx = "update  tb_RoomLX set  rs='" + this.txtrs.Text + "',bz='" + this.cmbjfbz.Text + "',xf=" + this.txtzdxf.Text + "";
            cmd = new OleDbCommand(xglx, conn);
            cmd.ExecuteScalar();

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
