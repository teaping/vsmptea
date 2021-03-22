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
    public partial class FrmZhuanT : Form
    {
        public static string bh;//编号
        public static string mcc;//名称
        public static string jne;//金额
        public string zhuntsl;//数量
        public static string str = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=MPcLou.accdb";
        OleDbConnection conn = null;
        OleDbCommand cmd = null;


        public FrmZhuanT()
        {
            InitializeComponent();
        }

        private void FrmZhuanT_Load(object sender, EventArgs e)
        {
           
            this.labct.Text = FrmZj.cth;
            this.labmc.Text = FrmZhuanT.mcc;
            this.labje.Text = FrmZhuanT.jne;

        }
        /// <summary>
        /// 确认
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            string mb = this.txtmb.Text;
            conn = new OleDbConnection(str);
            conn.Open();
            string sql = "select RoomZT from tb_Room where RoomJC='" +mb  + "' ";  //大厅状态是否使用
            cmd = new OleDbCommand(sql, conn);
            object zt = cmd.ExecuteScalar();
            string zt1 = zt.ToString();
            if (zt1=="使用")
            {
                string sqlw = "select sl from tb_xfxf where xmmc='"+mcc+"' ";  //大厅状态是否使用
                cmd.CommandText=sqlw;
                object bzl = cmd.ExecuteScalar();
                int bs=Convert.ToInt32(bzl);
                
		          //修改本餐台的数据
                    string xgsql1 = "update tb_xfxf set sl=" +(int.Parse(zhuntsl)-1) + " where xfxf=" + bh + " and xmmc='" + mcc+ "'";
                    cmd.CommandText = xgsql1;
                    cmd.ExecuteNonQuery();
                
                //查询目标餐台的数据
                string sqlcx = "select sl from tb_xfxf where xmmc='" +mcc  + "' and cth='"+mb+"' ";
                cmd.CommandText=sqlcx;
                object ch=cmd.ExecuteScalar();
                int ecx=Convert.ToInt32(ch);
                //查询目标餐台是否有该名称
                if (ecx>=1)
                {

                    ecx += 1;
                    string zjs = "update tb_xfxf set sl=" + ecx + "   where xmmc='" + mcc + "' and cth='" + mb + "' ";
                    cmd.CommandText = zjs;
                    cmd.ExecuteScalar();
                }else{
                    string zjsql = "insert into tb_xfxf (cth,xmmc,dj,sl,je,dcsj,jzr,zk) values('" + mb+ "','" + mcc + "'," + jne + ",1," + jne + ",'" + FrmMain.jdzsj + "','" + FrmMain.ryy + "',1) ";
                    cmd.CommandText = zjsql;
                    cmd.ExecuteNonQuery();
                }
            }
            else if (zt1=="待用")
            {
                MessageBox.Show(mb + "未开台");
            }
            conn.Close();
            this.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
