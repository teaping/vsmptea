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
using System.Runtime.InteropServices;
using Microsoft.VisualBasic;
using System.Data.SqlClient;
using System.Data.Common;
using System.Drawing;
using System.IO;

namespace ChaLou
{
    public partial class FrmMain : Form
    {
        public static string ry = null;//储存操作人员值

        //准备资源，设全局变量
        string str = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=MPcLou.accdb";
        OleDbConnection conn = null;
        OleDbCommand cmd = null;
        OleDbDataReader dr = null;
        OleDbDataAdapter oda = null;
        ListViewItem lv1 = null;
        string kw = "大厅";
        string kdcz = null;//存是否选中改项的文本
        string s = null;//接受是否在使用
        string jc = null;//接受简称
        string bjf = null;//接受包间费
        object zb = 0;//总包房数
        object ky = 0;//可用
        object zy = 0;//占用
        object yus = 0;//预定
        string zuidi = null;//最低消费
        string jifbz = null;//计费标准
        string jidsj = null;//进店时间
        public static string jdzsj;//全局进店时间
        public static string ryy;//操作人员
        public static TabControl tbc;//选项卡
        string jstbms = null;
        string asd = null;
        Sunisoft.IrisSkin.SkinEngine skin;
        public FrmMain()
        {
            InitializeComponent();
        }
       
        public FrmMain(Sunisoft.IrisSkin.SkinEngine s )
        {
            InitializeComponent();
            skin = s;
        }
       
            
      
        /// <summary>
        /// 显示时间
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            labsj.Text = DateTime.Now.ToString();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
           this.cmbhh.DataSource = new DirectoryInfo("Skins").GetFiles();
           this.cmbhh.DisplayMember = "Name";
         
            FrmMain.tbc = this.tbczy;
            timer1_Tick(null, null);
            // Bind();
            tbczy_SelectedIndexChanged(null, null);
            this.tssry.Text = "当前操作人员：" + ry;
            ryy = ry;
            CtZs();
            this.labctzs.Text = zb.ToString();
            this.labkg.Text = ky.ToString();
            this.labzy.Text = zy.ToString();
            this.labyd.Text = yus.ToString();
            //上座率
            double zzsy = Convert.ToDouble(zy);//正在使用的坐台
            double zszw = Convert.ToDouble(zb);//总数桌台
            int sadsad = Convert.ToInt32(zzsy / zszw * 100);
            this.labszl.Text = sadsad.ToString() + "%"; //给上座率赋值
            
        }



        /// <summary>
        /// 餐台总数/可用，待用
        /// </summary>
        private void CtZs()
        {
            conn = new OleDbConnection(str);
            conn.Open();
            string sql = "select count(RoomName) from tb_Room ";
            cmd = new OleDbCommand(sql, conn);
            zb = cmd.ExecuteScalar();
            string sqlky = "select count(RoomName) from tb_Room where  RoomzT='待用' ";
            cmd.CommandText = sqlky;
            ky = cmd.ExecuteScalar();
            string sqlzy = "select count(RoomName) from tb_Room where  RoomzT='使用' ";
            cmd.CommandText = sqlzy;
            zy = cmd.ExecuteScalar();
            string sqlyd = "select count(RoomName) from tb_Room where  RoomzT='预定' ";
            cmd.CommandText = sqlyd;
            yus = cmd.ExecuteScalar();
            conn.Close();
        }

        /// <summary>
        /// 获取每一个界面的值，传入绑定工程调用每一个bind绑上去
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbczy_SelectedIndexChanged(object sender, EventArgs e)
        {

            ListView lvzs = lvdt; //定义listview
            kw = tbczy.SelectedTab.Text;//拿到选中的选项卡文字判断
            labwd.Text = this.tbczy.SelectedTab.Text;
            //判断位置，把获取的lsitview 保存到listview
            switch (kw)
            {
                case "一楼大厅":
                    kw = "大厅";
                    lvzs = lvdt;
                    lvzs.Clear();
                    break;
                case "二楼小包":
                    kw = "包房";
                    lvzs = lvxb;
                    lvzs.Clear();
                    break;

                case "一楼大包":

                    kw = "大包房";
                    lvzs = lvdb;
                    lvzs.Clear();
                    break;
            }
            //开数据库获取数据 逐一绑定
            conn = new OleDbConnection(str);
            conn.Open();
            string sql = "select * from tb_Room where RoomWZ='" + kw + "' ";
            cmd = new OleDbCommand(sql, conn);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lv1 = new ListViewItem(dr["RoomName"].ToString());
                if (dr["RoomZT"].ToString() == "使用")
                {
                    lv1.ImageIndex = 0;
                }
                else if (dr["RoomZT"].ToString() == "预定")
                {
                    lv1.ImageIndex = 1;
                }
                else
                {
                    lv1.ImageIndex = 2;
                }
                lvzs.Items.Add(lv1);
            }
            dr.Close();
            conn.Close();

        }
        /// <summary>
        /// 顾客开单
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void butkd_Click(object sender, EventArgs e)
        {

            if (kdcz == null)
            {
                MessageBox.Show("请选择餐台后开单");
            }
            else if (s == "使用")
            {
                MessageBox.Show("此餐台处于非可用状态");

            }
            else
            {
                string xxbt = this.tbczy.SelectedTab.Text;
                FrmTj tj = new FrmTj();
                FrmTj.bt = xxbt;
                FrmTj.zd = jc;
                FrmTj.xf = bjf;
                tj.ShowDialog();
                FrmMain_Load(null, null);

            }
        }
        /// <summary>
        /// 绑定菜单在lvstview上
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lvdt_MouseClick(object sender, MouseEventArgs e)
        {
            //鼠标在list上的点击事件
            this.Cursor = Cursors.Default;
            ListView listView = (ListView)sender;
            ListViewItem item = listView.GetItemAt(e.X, e.Y);
            if (item != null && e.Button == MouseButtons.Right)
            {
                this.cmsda.Show(listView, e.X, e.Y);
            }
            //获取items中的文字
            for (int i = 0; i < lvdt.Items.Count; i++)
            {
                ListViewItem iwtem = lvdt.Items[i];
                for (int j = 0; j < iwtem.SubItems.Count; j++)
                {
                    kdcz = item.SubItems[j].Text;
                }
            }
            conn = new OleDbConnection(str);
            conn.Open();
            string sql = "select * from tb_Room where RoomName='" + kdcz + "' ";
            cmd = new OleDbCommand(sql, conn);
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                jc = dr["RoomJC"].ToString();//接受简称
                s = dr["RoomZT"].ToString();//接受是否在使用
                bjf = dr["RoomBJF"].ToString();//接受包间费
                zuidi = dr["RoomBJF"].ToString();//最低消费
                jifbz = dr["RoomType"].ToString();//类型
                jidsj = dr["zhangdanDate"].ToString();//进店时间;
            }
            jdzsj = jidsj;//全局接受进店时间
            dr.Close();
            //消费金额
            string sqlcxjq = "select sum(je) from tb_xfxf where cth='" + jc + "'";
            cmd.CommandText = sqlcxjq;
            this.labxfje.Text = cmd.ExecuteScalar().ToString();

            conn.Close();
            switch (jifbz)
            {
                case "普通":
                    this.labjfbz.Text = "不计房间费";
                    break;
                case "中级":
                    this.labjfbz.Text = "小包";
                    break;
                case "高级":
                    this.labjfbz.Text = "大包";
                    break;
            }
            this.labzuidi.Text = zuidi;//计费标准
            this.labjdsj.Text = jidsj;//进店时间

            //给予判断是否在使用
            if (s == "使用")
            {
                //计算已用时间
                DateTime d = new DateTime();
                d = DateTime.Parse(jidsj);
                //调用时间类
                SJTime sjj = new SJTime(d);
                sjj.SjTime01();
                this.labyysj.Text = sjj.SjTime01().ToString();
            }
            else
            {
                this.labyysj.Text = "";
            }
            Pdshiy(s);

            Zyxxm(jc);

        }
        /// <summary>
        /// 离开菜单隐藏
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmsda_MouseLeave(object sender, EventArgs e)
        {
            this.cmsda.Hide();
        }

        /// <summary>
        /// 判断菜单里面按钮是否可以使用
        /// </summary>
        /// <param name="s"></param>
        private void Pdshiy(string s)
        {
            //遍历每一个下拉选项 全部可以使用
            foreach (ToolStripItem info in this.cmsda.Items)
            {
                info.Enabled = true;
            }
            //判断是否使用
            if (s == "使用")
            {
                this.顾客开单ToolStripMenuItem.Enabled = false;
                this.宾客预定ToolStripMenuItem.Enabled = false;
            }
            else
            {
                this.宾客预定ToolStripMenuItem.Enabled = true;
                this.宾客消费ToolStripMenuItem.Enabled = false;
                this.增加消费ToolStripMenuItem.Enabled = false;

            }
        }

        private void 增加消费ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            butxf_Click(null, null);
        }
        /// <summary>
        /// 顾客开单
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 顾客开单ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            butkd_Click(null, null);
        }
        /// <summary>
        ///增加消费
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void butxf_Click(object sender, EventArgs e)
        {
            if (kdcz == null || s == "待用")
            {
                MessageBox.Show("不能对处于非占用状态的餐台进行此项操作");
            }
            else if (s == "使用")
            {
                string xxbt = this.tbczy.SelectedTab.Text;
                FrmZj tj = new FrmZj();
                FrmZj.cth = jc;
                tj.ShowDialog();
                FrmMain_Load(null, null);

            }
        }
        /// <summary>
        /// 结账
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void butjz_Click(object sender, EventArgs e)
        {
            if (kdcz == null || s == "待用" || s == "预定")
            {
                MessageBox.Show("不能对处于非占用状态的餐台进行此项操作");
            }
            else if (s == "使用")
            {
                string xxbt = this.tbczy.SelectedTab.Text;
                FrmJz tj = new FrmJz();
                FrmJz.jcc = jc;
                tj.ShowDialog();
                FrmMain_Load(null, null);

            }
        }
        /// <summary>
        /// 吧台销售
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void butbt_Click(object sender, EventArgs e)
        {
            FrmBTxs fq = new FrmBTxs();
            fq.ShowDialog();
            FrmMain_Load(null, null);
        }

        /// <summary>
        /// 商品寄存
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void butjc_Click(object sender, EventArgs e)
        {
            FrmJc fq = new FrmJc();
            fq.ShowDialog();
            FrmMain_Load(null, null);
        }

        /// <summary>
        /// 预定
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void butyd_Click(object sender, EventArgs e)
        {
            FrmYdGl fq = new FrmYdGl();
            fq.ShowDialog();
            FrmMain_Load(null, null);
            //判断预定是否点击开单传数据
            if (FrmYdGl.lxwz != null)
            {
                //判断类型选中位置
                switch (FrmYdGl.lxwz)
                {
                    case "一楼大厅":
                        this.tbczy.SelectedTab = tabPage4;
                        break;
                    case "二楼包房":
                        this.tbczy.SelectedTab = tabPage5;
                        break;
                    case "一楼大包":
                        this.tbczy.SelectedTab = tabPage6;
                        break;
                }
            }




        }

        /// <summary>
        /// 清单显示
        /// </summary>
        private void Zyxxm(string s)
        {
            DataSet ds = new DataSet();
            conn = new OleDbConnection(str);
            //两表联查绑定
            string sql = " select a.*,b.WaiterName as fws,b.RoomBZ as bz from tb_xfxf a,tb_Room b where a.cth=b.RoomJC and a.cth='" + s + "' ";
            oda = new OleDbDataAdapter(sql, conn);
            oda.Fill(ds);
            this.dgvzck.AutoGenerateColumns = false;
            this.dgvzck.DataSource = ds.Tables[0];
            conn.Open();
            string slsql = "select count(sl) from tb_xfxf where cth='" + jc + "'"; //查询数量
            cmd = new OleDbCommand(slsql, conn);
            object sl = cmd.ExecuteScalar();
            string zssql = "select sum(sl) from tb_xfxf where cth='" + jc + "'";//查询金额
            cmd = new OleDbCommand(zssql, conn);
            object zsl = cmd.ExecuteScalar();
            this.labzyx.Text = jc + "房间 消费清单如下 消费数量" + sl.ToString() + "总金额" + zsl.ToString();
            conn.Close();

        }
        /// <summary>
        /// 过滤方式占用
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 显示占用ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListView lvasd = lvdt; //定义listview
            conn = new OleDbConnection(str);
            string xxk = this.tbczy.SelectedTab.Text;
            string ys;
            if (xxk == "一楼大厅") //判断位置
            {
                ys = "大厅";
                lvasd = lvdt;
                lvasd.Clear();
            }
            else if (xxk == "二楼小包")
            {
                ys = "包房";
                lvasd = lvxb;
                lvasd.Clear();
            }
            else
            {
                ys = "大包房";
                lvasd = lvdb;
                lvasd.Clear();
            }
            conn.Open();
            string sql = "select * from tb_Room where RoomZT='使用' and RoomWZ='" + ys + "'  ";   //判断位置 和状态
            cmd = new OleDbCommand(sql, conn);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lv1 = new ListViewItem(dr["RoomName"].ToString());
                if (dr["RoomZT"].ToString() == "使用")
                {
                    lv1.ImageIndex = 0;
                }
                else if (dr["RoomZT"].ToString() == "预定")
                {
                    lv1.ImageIndex = 1;
                }
                else
                {
                    lv1.ImageIndex = 2;
                }
                lvasd.Items.Add(lv1);
            }
            dr.Close();

            conn.Close();
        }
        /// <summary>
        /// 可用餐台
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 显示可供ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListView lvasd = lvdt; //定义listview
            conn = new OleDbConnection(str);
            string xxk = this.tbczy.SelectedTab.Text;
            string ys = null;
            if (xxk == "一楼大厅") //判断位置
            {
                ys = "大厅";
                lvasd = lvdt;
                lvasd.Clear();
            }
            else if (xxk == "二楼小包")
            {
                ys = "包房";
                lvasd = lvxb;
                lvasd.Clear();
            }
            else if (xxk == "一楼大包")
            {
                ys = "大包房";
                lvasd = lvdb;
                lvasd.Clear();
            }
            conn.Open();
            string sql = "select * from tb_Room where RoomZT='待用' and RoomWZ='" + ys + "'  ";   //判断位置 和状态
            cmd = new OleDbCommand(sql, conn);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lv1 = new ListViewItem(dr["RoomName"].ToString());
                if (dr["RoomZT"].ToString() == "待用")
                {
                    lv1.ImageIndex = 2;
                }
                lvasd.Items.Add(lv1);
            }
            dr.Close();

            conn.Close();
        }

        /// <summary>
        /// 显示预定
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 显示预定ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ListView lvasd = lvdt; //定义listview
            conn = new OleDbConnection(str);
            string xxk = this.tbczy.SelectedTab.Text;
            string ys = null;
            if (xxk == "一楼大厅") //判断位置
            {
                ys = "大厅";
                lvasd = lvdt;
                lvasd.Clear();
            }
            else if (xxk == "二楼小包")
            {
                ys = "包房";
                lvasd = lvxb;
                lvasd.Clear();
            }
            else if (xxk == "一楼大包")
            {
                ys = "大包房";
                lvasd = lvdb;
                lvasd.Clear();
            }
            conn.Open();
            string sql = "select * from tb_Room where RoomZT='预定' and RoomWZ='" + ys + "'  ";   //判断位置 和状态
            cmd = new OleDbCommand(sql, conn);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lv1 = new ListViewItem(dr["RoomName"].ToString());
                if (dr["RoomZT"].ToString() == "预定")
                {
                    lv1.ImageIndex = 1;
                }
                lvasd.Items.Add(lv1);
            }
            dr.Close();

            conn.Close();
        }

        /// <summary>
        /// 刷新
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button4_Click(object sender, EventArgs e)
        {
            FrmMain_Load(null, null);
        }
        /// <summary>
        /// 日历
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void butrl_Click(object sender, EventArgs e)
        {
            //this.txtbq1.Text += DateTime.Now.ToString()+"\n";   
            this.txtbq1.Text += DateTime.Now.ToString() + Environment.NewLine; //获取当前日期 换行
        }
        /// <summary>
        /// 计算器
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button5_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("calc.exe");
        }
        /// <summary>
        /// 清除文本框中的内容
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button6_Click(object sender, EventArgs e)
        {
            this.txtbq1.Text = "";
        }
        /// <summary>
        /// 会员管理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buthy_Click(object sender, EventArgs e)
        {
            FrmHuiYuan f = new FrmHuiYuan();
            f.ShowDialog();
            FrmMain_Load(null, null);
        }
        /// <summary>
        /// 营业查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void butyy_Click(object sender, EventArgs e)
        {
            FrmYinYe f = new FrmYinYe();
            f.ShowDialog();
            FrmMain_Load(null, null);
        }
        /// <summary>
        /// 系统管理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void butxt_Click(object sender, EventArgs e)
        {
            FrmXtSz f = new FrmXtSz();
            f.ShowDialog();
            FrmMain_Load(null, null);
        }
        /// <summary>
        /// 显示全部
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            ListView lvasd = lvdt; //定义listview
            conn = new OleDbConnection(str);
            string xxk = this.tbczy.SelectedTab.Text;
            string ys;
            if (xxk == "一楼大厅") //判断位置
            {
                ys = "大厅";
                lvasd = lvdt;
                lvasd.Clear();
            }
            else if (xxk == "二楼小包")
            {
                ys = "包房";
                lvasd = lvxb;
                lvasd.Clear();
            }
            else
            {
                ys = "大包房";
                lvasd = lvdb;
                lvasd.Clear();
            }
            conn.Open();
            string sql = "select * from tb_Room where  RoomWZ='" + ys + "'  ";   //判断位置 和状态
            cmd = new OleDbCommand(sql, conn);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lv1 = new ListViewItem(dr["RoomName"].ToString());
                if (dr["RoomZT"].ToString() == "使用")
                {
                    lv1.ImageIndex = 0;
                }
                else if (dr["RoomZT"].ToString() == "预定")
                {
                    lv1.ImageIndex = 1;
                }
                else
                {
                    lv1.ImageIndex = 2;
                }
                lvasd.Items.Add(lv1);
            }
            dr.Close();

            conn.Close();
        }
        /// <summary>
        /// 商品管理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void butsp_Click(object sender, EventArgs e)
        {
            ;
        }
        /// <summary>
        /// 财务管理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void butvwgl_Click(object sender, EventArgs e)
        {
        }
        /// <summary>
        /// 交班管理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void butjb_Click(object sender, EventArgs e)
        {  
            
            FrmJiaoBan f = new FrmJiaoBan();
            f.ShowDialog();
          
           
            
        }
        /// <summary>
        /// 查看模式
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 大图片ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListView ls = null;
            jstbms = "大图标";
            string d1s = this.tbczy.SelectedTab.Text;
            if (d1s == "一楼大厅")
            {
                ls = lvdt;
            }
            else if (d1s == "二楼小包")
            {
                ls = lvxb;
            }
            else
            {
                ls = lvdb;
            }
            GuanSz.GuolvCk f = new GuanSz.GuolvCk(jstbms);
            f.Bang(tbczy, ls);
        }

        private void 小图标ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListView ls = null;
            jstbms = "小图标";
            string d1s = this.tbczy.SelectedTab.Text;
            if (d1s == "一楼大厅")
            {
                ls = lvdt;
            }
            else if (d1s == "二楼小包")
            {
                ls = lvxb;
            }
            else
            {
                ls = lvdb;
            }
            GuanSz.GuolvCk f = new GuanSz.GuolvCk(jstbms);
            f.Bang(tbczy, ls);

        }

        private void 中图片ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListView ls = null;
            jstbms = "中图标";
            string d1s = this.tbczy.SelectedTab.Text;
            if (d1s == "一楼大厅")
            {
                ls = lvdt;
            }
            else if (d1s == "二楼小包")
            {
                ls = lvxb;
            }
            else
            {
                ls = lvdb;
            }
            GuanSz.GuolvCk f = new GuanSz.GuolvCk(jstbms);
            f.Bang(tbczy, ls);
        }

        private void 退出系统ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// 锁定系统
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 锁定系统ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LockWorkStation();
            this.Enabled = false;
            FrmSuoPing f = new FrmSuoPing();
            f.ShowDialog();
            this.Enabled = true;

        }

        [DllImport("user32.dll")]
        public static extern bool LockWorkStation();
        /// <summary>
        /// 关于
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 关于ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmGuanYu f = new FrmGuanYu();
            f.ShowDialog();
        }
        /// <summary>
        /// 过滤方式
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 显示全部ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button1_Click(null, null);
        }
        /// <summary>
        /// 宾客结账
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 宾客消费ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            butjz_Click(null, null);
        }
        /// <summary>
        /// 预定
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void 宾客预定ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            butyd_Click(null, null);
        }
        /// <summary>
        /// 顶部开单
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 顾客开单ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            butkd_Click(null, null);
        }

        private void 吧台销售ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            butbt_Click(null, null);
        }

        private void 预定管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            butyd_Click(null, null);
        }
        /// <summary>
        /// 换皮肤
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbhh_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (this.cmbhh.SelectedItem != null)

                skin.SkinFile = (this.cmbhh.SelectedItem as FileInfo).FullName;
        }
        /// <summary>
        /// 结算
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 收银结算SToolStripMenuItem_Click(object sender, EventArgs e)
        {
            butjz_Click(null, null);
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        //移入移出
        //private void butkd_MouseMove(object sender, MouseEventArgs e)
        //{
        //   this.butkd.FlatAppearance.BorderSize = 1;
        //   this.butkd.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
        //}

        //private void butkd_MouseLeave(object sender, EventArgs e)
        //{
        //    this.butkd.FlatAppearance.BorderSize = 0;
        //    this.butkd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        //}

    }
}
