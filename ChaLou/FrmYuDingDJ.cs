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
    public partial class FrmYuDingDJ : Form
    {

        string str = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=MPcLou.accdb";
        OleDbConnection conn = null;
        OleDbCommand cmd = null;
        OleDbDataReader dr = null;
        OleDbDataAdapter oda = null;
        DataSet ds = null;
        public string jsxm = null;
        int a = 0,i=0;
        string fjjc=null;//房间简称
        public FrmYuDingDJ()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 取消
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void butqx_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }


        //判断数据是否为空
        private void Pd()
        {
           if (this.txtxm.Text.Trim()==null)
	       {
              MessageBox.Show("请填写宾客姓名");  
	       }

           if (this.txtdh.Text.Trim() == null)
           {
               MessageBox.Show("请填写联系电话");
           }

           if (this.cmbbh.Text.Trim() == null)
           {
               MessageBox.Show("请选择餐台");
           }

           if (this.cmbsd.Text.Trim() == null)
           {
               MessageBox.Show("请选择时段");
           }
        }
        /// <summary>
        /// 增加保存
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void butbc_Click(object sender, EventArgs e)
        {
            string tj = null ;
            conn = new OleDbConnection(str);
            conn.Open();
            Pd();
            if (jsxm==null)
            {
                 //增加
                
                if (this.txtbz.Text.Trim()!="")
                {
                    tj = "insert into tb_YuDing(xm,dh,ydlx,bh,ydsj,blsj,xdsj,bz) values('" + this.txtxm.Text + "','" + this.txtdh.Text + "','" + this.cmbgk.Text + "','" + this.cmbbh.Text + "','" + this.cmbsd.Text + "','" + this.txtyd.Text + "','" + this.txtbl.Text + "','"+this.txtbz.Text+"') ";
                }
                else
                {
                    tj = "insert into tb_YuDing(xm,dh,ydlx,bh,ydsj,blsj,xdsj) values('" + this.txtxm.Text + "','" + this.txtdh.Text + "','" + this.cmbgk.Text + "','" + this.cmbbh.Text + "','" + this.cmbsd.Text + "','" + this.txtyd.Text + "','" + this.txtbl.Text + "') ";
                }
                cmd = new OleDbCommand(tj, conn);
                cmd.ExecuteScalar();
                string xgzhuy = "update tb_Room  set  RoomZT='预定' where RoomJC='" + this.cmbbh.Text + "' ";
                 cmd.CommandText = xgzhuy;
                 cmd.ExecuteScalar();
               
              
            }
            else    
            {
                
                //修改
                string cxid = "select id from tb_YuDing where xm='" + jsxm + "'";
                cmd = new OleDbCommand(cxid, conn);
                int ids=Convert.ToInt32( cmd.ExecuteScalar());
                tj = "update tb_YuDing set xm='" + this.txtxm.Text + "',dh='" + this.txtdh.Text + "',ydlx='" + this.cmbgk.Text + "',bh='" + this.cmbbh.Text + "',ydsj='" + this.cmbsd.Text + "',blsj='" + this.txtyd.Text + "',xdsj='" + this.txtbl.Text + "',bz='" + this.txtbz.Text + "' where id="+ids+" ";
                cmd = new OleDbCommand(tj, conn);
                cmd.ExecuteScalar();
                if (this.cmbbh.Text!=fjjc)
                {
                    string xgzhuy = "update tb_Room  set  RoomZT='待用' where RoomJC='" + fjjc + "' ";
                    cmd = new OleDbCommand(xgzhuy, conn);
                    cmd.ExecuteScalar();
                    string xgz = "update tb_Room  set  RoomZT='预定' where RoomJC='" + this.cmbbh.Text + "' ";
                    cmd.CommandText = xgz;
                    cmd.ExecuteScalar();
                }
            }
           
            conn.Close();
            this.Dispose();
        }

        /// <summary>
        /// 绑定餐台
        /// </summary>
        private void Bgk()
        {
            this.cmbbh.Text="";
            this.cmbbh.Items.Clear();
            conn = new OleDbConnection(str);
            conn.Open();
            string ctsql = "select * from tb_Room where RoomWZ='" + this.cmbgk.Text + "' and RoomZT='待用' ";
            cmd = new OleDbCommand(ctsql, conn);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                this.cmbbh.Items.Add(dr["RoomJC"].ToString());
            }
            dr.Close();
            conn.Close();
        }
        /// <summary>
        /// 规格选择时
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbgk_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (a>=1){
                if (this.cmbgk.Text!=null)  {
                Bgk();
                }
            }
            else if (i>=1)
            {
                if (this.cmbgk.Text!=null)  {
                Bgk();
                }
            }
            
        }
        /// <summary>
        /// 绑定两个时间
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmYuDingDJ_Load(object sender, EventArgs e)
        {
            if (jsxm!=null)
            {
               BJc();
               a += 1;
            }
            else
            {
                i += 1;
            }
            
            
        }

        /// <summary>
        /// 修改传值
        /// </summary>
        private void BJc()
        {
            conn = new OleDbConnection(str);
            conn.Open();
            string cscs = "select * from tb_YuDing where xm='" + jsxm + "'";
            cmd = new OleDbCommand(cscs, conn);
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                this.txtxm.Text = dr["xm"].ToString();
                this.txtdh.Text = dr["dh"].ToString();
                this.cmbgk.Text = dr["ydlx"].ToString();
                this.cmbbh.Text = dr["bh"].ToString();
                this.cmbsd.Text = dr["ydsj"].ToString();
                this.txtyd.Text = dr["blsj"].ToString();
                this.txtbl.Text = dr["xdsj"].ToString();
                this.txtbz.Text = dr["bz"].ToString();
                fjjc = this.cmbbh.Text;
            }
            dr.Close();
            conn.Close();

        }


        /// <summary>
        /// 绑定预定餐台的宾客
        /// </summary>
        private void BanC()
        {
            conn = new OleDbConnection(str);
            string ydsql = "select * from tb_YuDing where bh='" +this.cmbbh.Text + "'";
            oda = new OleDbDataAdapter(ydsql, conn);
            ds = new DataSet();
            oda.Fill(ds);
            this.dgvbk.AutoGenerateColumns = false;
            this.dgvbk.DataSource = ds.Tables[0];
        }

        /// <summary>
        /// 选择编号绑定data表
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbbh_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cmbbh.Text!=null)
            {
                BanC();
            }
        }
        /// <summary>
        /// 时间段
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbsd_SelectedIndexChanged(object sender, EventArgs e)
        {
            DateTime szsj = DateTime.Now;
            string sj = szsj.ToString("yyyy-MM-dd ");
            string sj1 =sj+"12-00-00";
            string sj2 = sj + "15-00-00";

            if (this.cmbsd.Text=="中午")
            {
                this.txtyd.Text =sj1;
                string sj1a =sj+"14-00-00";
                this.txtbl.Text =sj1a;   //加n小时
            }
            else
            {
                this.txtyd.Text =sj2;
                string sj2a = sj + "18-00-00";
                this.txtbl.Text = sj2a;   //加n小时
            }
        }
    }
}
