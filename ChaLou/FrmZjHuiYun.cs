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
    public partial class FrmZjHuiYun : Form
    {
        string str = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=MPcLou.accdb";
        OleDbConnection conn = null;
        OleDbCommand cmd = null;
        OleDbDataReader dr = null;
        OleDbDataAdapter oda = null;
        public string num = null;
        DataSet ds = null;
        public FrmZjHuiYun()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 设置密码框
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbkm_CheckedChanged(object sender, EventArgs e)
        {
            if (this.cmbkm.Checked==false)
            {
                this.txtmi.Enabled = false;
                this.txtqmi.Enabled = false;
            }
            else
            {
                this.txtmi.Enabled = true;
                this.txtqmi.Enabled =true;
            }
        }
        /// <summary>
        /// 有效日期
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBox2.Checked==false)
            {
                this.dpkyx.Enabled = false;
            }
            else
            {
                this.dpkyx.Enabled = true;
            }
        }
        /// <summary>
        /// 取消
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void butqc_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        /// <summary>
        /// 保存  添加人卡
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void butbc_Click(object sender, EventArgs e)
        {
            conn = new OleDbConnection(str);
            conn.Open();
            if (num==null)  //点击增加进来的
            {
                string tjrsql = "insert into tb_huiyuan(Name,Age,Birth,iphone,djsj,bz,hybh) values('" + this.txthyxm.Text + "','" + this.cmbxb.Text + "','" + this.dtpsq.Text + "','" + this.txthydh.Text + "','" + DateTime.Now.ToString() + "','" + this.txthybz.Text + "','" + this.txthybh.Text + "')";
                cmd = new OleDbCommand(tjrsql, conn);
                cmd.ExecuteScalar();
                string cxrid = "select id from  tb_huiyuan where Name='" + this.txthyxm.Text + "'";
                cmd.CommandText = cxrid;
                object rid = cmd.ExecuteScalar();
                string tjksql = "insert into tb_huiyuk(dengji,kx) values('" + this.cmbhydj.Text + "'," + rid + ") ";
                cmd.CommandText = tjksql;
                cmd.ExecuteScalar();
                string czhyid = "select id from tb_huiyuk where kx=" + rid + "";
                cmd.CommandText = czhyid;
                object ykidcmd = cmd.ExecuteScalar();
                string ksql = "insert into tb_kxf(lx,dj,zkl,ye,jf,mi,bh1,ljxf,zt) values('" + this.cmbllx.Text + "','" + this.cmbhydj.Text + "',1," + this.txthyje.Text + "," + this.txthyjf.Text + ",'" + this.txtqmi.Text + "'," + ykidcmd + ",0,'" + this.cmbzt.Text + "')";
                cmd.CommandText = ksql;
                cmd.ExecuteScalar();
            }
            else   //修改点击后的保存
            {
                MessageBox.Show("修改");
                //修改
                string xgsql = "update tb_huiyuan set Name='" + this.txthyxm.Text + "',Age='" + this.cmbxb.Text + "',Birth='" + this.dtpsq.Text + "',iphone='" + this.txthydh.Text + "'    where  hybh='" + this.txthybh.Text + "'";
                cmd = new OleDbCommand(xgsql, conn);
                cmd.ExecuteScalar();
                //查询id
                string cxsqk = "select id from tb_huiyuan where hybh='" + this.txthybh.Text + "'";
                cmd.CommandText = cxsqk;
                string kids = cmd.ExecuteScalar().ToString();
                //修改
                string xghysql = "update tb_huiyuk set dengji='" + this.cmbhydj.Text + "'   where kx=" + kids + "";
                cmd.CommandText = xghysql;
                cmd.ExecuteScalar();
                //查询id
                string cxhyidj = "select id from tb_huiyuk where kx=" + kids + "";
                cmd.CommandText = cxhyidj;
                string kalid = cmd.ExecuteScalar().ToString();
                //修改
                string xgksql = "update tb_kxf set zt='" + this.cmbzt.Text + "',yxsj='" + this.dpkyx.Text + "'   where bh1=" + kalid + "";
                cmd.CommandText = xgksql;
                cmd.ExecuteScalar();
            }
            
            
            conn.Close();
            this.Dispose();
        }

        private void FrmZjHuiYun_Load(object sender, EventArgs e)
        {
            string hyid = null,hykid=null;

            if (num!=null)  //这是修改绑定操作
            {
                conn = new OleDbConnection(str);
                conn.Open();
                string cx = "select * from tb_huiyuan where hybh='" + num + "'";
                cmd = new OleDbCommand(cx, conn);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    this.txthybh.Text = dr["hybh"].ToString();
                    this.txthyxm.Text = dr["Name"].ToString();
                    this.cmbxb.Text = dr["Age"].ToString();
                    this.dtpsq.Text = dr["Birth"].ToString();
                    this.txthydh.Text = dr["iphone"].ToString();
                    this.txthybz.Text = dr["bz"].ToString();
                    hyid = dr["id"].ToString();
                }
                dr.Close();

                string cx1 = "select * from tb_huiyuk where kx=" + hyid + "";
                cmd.CommandText = cx1;
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    this.cmbhydj.Text = dr["dengji"].ToString();
                    hykid = dr["id"].ToString();
                }
                dr.Close();


                string cx2 = "select * from tb_kxf where bh1=" + hykid + "";
                cmd.CommandText = cx2;
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    this.cmbllx.Text = dr["lx"].ToString();
                    this.txthyjf.Text = dr["jf"].ToString();
                    this.txthyje.Text = dr["ye"].ToString();
                    this.txtcqj.Text = "0";
                    this.txtmi.Text = dr["mi"].ToString();
                    this.txtqmi.Text = dr["mi"].ToString();
                    this.cmbzt.Text = dr["zt"].ToString();
                }
                dr.Close();
                this.txthybh.ReadOnly = false;
                this.cmbllx.Enabled = false;
                this.cmbkm.Enabled = false;
                conn.Close();
            }
        }
    }
}
