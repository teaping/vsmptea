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
    public partial class FrmLogin : Form
    {
        //定义全部变量
        string str = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=MPcLou.accdb";
        OleDbConnection conn = null;
        OleDbCommand cmd = null;
        OleDbDataReader dr = null;
        OleDbDataAdapter oda = null;
        //定义变量存储数据库中账号和密码
        string uspss = null;
        string usmen = null;
        public Sunisoft.IrisSkin.SkinEngine s = new Sunisoft.IrisSkin.SkinEngine();

        public FrmLogin()
        {
            InitializeComponent();

            // s.SkinFile = "Skins\\EmeraldColor3.ssk";//调用美化包

        }
        //public FrmLogin(Sunisoft.IrisSkin.SkinEngine skin)
        //{
        //    InitializeComponent();
        //    s = skin;
        //   // s.SkinFile = "Skins\\EmeraldColor3.ssk";//调用美化包
        //}

        private void Frmtj_KeyDown(object sender, KeyEventArgs e)
        {
            //键盘键keyvlalues==13才等于tab
            if (e.KeyValue == 13)
            {

                SendKeys.Send("{Tab}");  //向活动应用程序发送击键 注意格式：Send("{Tab}");中的{}
            }
        }
        private void FrmLogin_Load(object sender, EventArgs e)
        {
            this.AcceptButton = button1;
            //tab换行
            foreach (Control c in this.Controls) //获取页面中的所有控件
            {
                if (c.GetType().ToString() == "System.Windows.Forms.TextBox")//如果是TextBox控件，则添加事件
                {
                    TextBox tb1 = c as TextBox;
                    c.KeyDown += new KeyEventHandler(Frmtj_KeyDown);
                }
            }


            string sjyzm;//接受验证码
            GuanSz.YanZhengMa y = new GuanSz.YanZhengMa();
            sjyzm= y.CreateValidateCode(6);
            this.labyzm.Text = sjyzm; //提示验证码

            //s.AddForm(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn = new OleDbConnection(str);
            conn.Open();
            //判断是否为空
            if (!Py())
            {
                this.tabts.Text = "用户名/密码不能为空";
                this.txtname.Text = "";
                this.txtmi.Text = "";
                this.txtyzm.Text = "";
                FrmLogin_Load(null, null);
                return;
            }
            else
            {
                this.tabts.Text = "";
            }
            string sql = "select count(UserName) from [tb_User] where UserName='" + this.txtname.Text + "' "; //按照账号查询是否有该条
            cmd = new OleDbCommand(sql, conn);
            string su1 = cmd.ExecuteScalar().ToString();
            if (su1 == "0") //没有输出错误并且清空
            {
                this.tabts.Text = "账号错误";
                this.txtname.Text = "";
                this.txtmi.Text = "";
                this.txtyzm.Text = "";
                FrmLogin_Load(null, null);
                return;
            }
            //按照账号和密码去验证输入的账号和密码是否正确
            string sql1 = "select count(UserName) from [tb_User] where UserName='" + this.txtname.Text + "' and UserPwd='" + this.txtmi.Text + "' ";
            cmd.CommandText = sql1;
            string su2 = cmd.ExecuteScalar().ToString();
            if (su2 == "0")//没有输出错误并且清空
            {
                this.tabts.Text = "密码错误";
                this.txtname.Text = "";
                this.txtmi.Text = "";
                this.txtyzm.Text = "";
                FrmLogin_Load(null, null);
                return;
            }
            //如果全部正确  查询 账号和密码赋值到变量为传值准备
            string sql2 = "select * from [tb_User] where UserName='" + this.txtname.Text + "' and UserPwd='" + this.txtmi.Text + "' ";
            cmd.CommandText = sql2;
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                uspss = dr["UserPwd"].ToString();
                usmen = dr["UserName"].ToString();
            }
            dr.Close();
            conn.Close();
            //验证验证码是否正确
            if (this.labyzm.Text!=this.txtyzm.Text)
            {
                this.tabts.Text = "验证码错误";

                this.txtname.Text = "";
                this.txtmi.Text = "";
                this.txtyzm.Text = "";
                FrmLogin_Load(null, null);
                return;
                
            }


            //new 到主窗口
            FrmMain f1 = new FrmMain(s);
            FrmMain.ry = usmen;


            this.Hide();
            f1.ShowDialog();
            this.Dispose();


        }
        /// <summary>
        /// 判断是否为空
        /// </summary>
        private bool Py()
        {
            if (this.txtmi.Text == "" || this.txtname.Text == "")
            {
                return false;
            }
            else
            {
                return true;
            }
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
