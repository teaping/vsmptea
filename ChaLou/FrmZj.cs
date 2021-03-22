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
    public partial class FrmZj : Form
    {
        public static string cth;//标题（简称）
        public static string str = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=MPcLou.accdb";
        OleDbDataAdapter da = null;
        OleDbDataReader dr = null;
        OleDbConnection conn = null;
        OleDbCommand cmd = null;
        DataSet ds = null;
        public FrmZj()
        {
            InitializeComponent();
        }

        private void FrmZj_Load(object sender, EventArgs e)
        {
            //绑定标题的餐台号
            this.labcth.Text = "餐台号：" + cth + " 消费清单";
            Bind();
            Bingxf();
            Bingtr();
        }
        /// <summary>
        /// 绑定项目清单
        /// </summary>
        private void Bind()
        {
            conn = new OleDbConnection(str);
            string sql = "select * from tb_Chuangku ";
            da = new OleDbDataAdapter(sql, conn);
            ds = new DataSet();
            da.Fill(ds);
            this.dgwqd.AutoGenerateColumns = false;
            this.dgwqd.DataSource = ds.Tables[0];
        }
        /// <summary>
        /// 消费清单
        /// </summary>
        private void Bingxf()
        {
            conn = new OleDbConnection(str);
            string sql = "select * from  tb_xfxf where cth ='"+cth+"' ";
            da = new OleDbDataAdapter(sql, conn);
            ds = new DataSet();
            da.Fill(ds);
            this.dgwxfqd.AutoGenerateColumns = false;
            this.dgwxfqd.DataSource = ds.Tables[0];

            conn.Open();
            string sqlzxf = "select sum(je) from tb_xfxf where cth='" + cth+ "'";
            cmd = new OleDbCommand(sqlzxf, conn);
            object zxf = cmd.ExecuteScalar();
            this.labzq.Text = zxf.ToString();
            conn.Close();
            //cmd.CommandText = sqlzxf;
        }
        /// <summary>
        /// 选中行显示文本
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgwqd_SelectionChanged(object sender, EventArgs e)
        {
            string zhi = null;
            if (this.dgwxfqd.SelectedCells.Count != 0)
            {
                zhi = this.dgwqd.CurrentRow.Cells[1].Value.ToString();
            }
            this.labxs.Text = zhi;

        }
        /// <summary>
        /// 项目清单双击事件添加到消费清单
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgwqd_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
          string xmmc= this.dgwqd.CurrentRow.Cells[1].Value.ToString();//名称
          string djj = this.dgwqd.CurrentRow.Cells[2].Value.ToString();//单价
          string kc = this.dgwqd.CurrentRow.Cells[3].Value.ToString();//数量

          conn = new OleDbConnection(str);
          conn.Open();
          //增加
          string sqlts = "select sl from tb_xfxf where xmmc='"+xmmc+"' and cth='"+FrmZj.cth+"'";//点击的项目名称判断是否相同
          cmd = new OleDbCommand(sqlts, conn);
          object sll = cmd.ExecuteScalar();
          int shu=Convert.ToInt32(sll);//object转数字int
          int r;
            if(shu>=1)
          {        int shull=shu + 1;
                  int jee =int.Parse(djj) * shull;
                  string zjsql = "update  tb_xfxf set sl=" + shull + ",je=" + jee + " where xmmc='" + xmmc + "' and cth='" + FrmZj.cth + "' ";
                  cmd.CommandText = zjsql;
                  r=cmd.ExecuteNonQuery();
          }
          else //密钥中国食物添加，有就修改数值和价钱
          {
            string sql = "insert into tb_xfxf (cth,xmmc,dj,sl,je,dcsj,jzr,zk) values('" + cth + "','" + xmmc + "'," + djj + ",1," + djj + ",'"+ FrmMain.jdzsj + "','" + FrmMain.ryy + "',1) ";
            cmd = new OleDbCommand(sql, conn);
            r = cmd.ExecuteNonQuery();
          }
          conn.Close();
          Bingxf();//重新绑定
          
        }
        /// <summary>
        /// 绑定项目列表
        /// </summary>
        private void Bingtr()
        {
            conn = new OleDbConnection(str);
            conn.Open();
            string sql = "select * from tb_ckf";
            cmd = new OleDbCommand(sql, conn);
            OleDbDataReader dr = cmd.ExecuteReader();
            //循环绑定根节点
            while (dr.Read())
            {
               TreeNode t1 = new TreeNode(dr["lx"].ToString());
                t1.Name = dr["ID"].ToString();
                this.trewlb.Nodes.Add(t1);
            }
            dr.Close();
            string sql1 = "select * from tb_Chuangku";
            cmd.CommandText = sql1;
            OleDbDataReader sd = cmd.ExecuteReader();
            int asd = trewlb.Nodes.Count;
            //历遍根节点判断name，添加子节点
            while (sd.Read())
            {
                foreach (TreeNode temp in trewlb.Nodes)
                {
                    if (temp.Name == "1" && temp.Name == sd["leix"].ToString())
                    {
                        temp.Nodes.Add(sd["mc"].ToString());
                    }
                    else if (temp.Name == "2" && temp.Name == sd["leix"].ToString())
                    {
                        temp.Nodes.Add(sd["mc"].ToString());
                    }
                    else if (temp.Name == "3" && temp.Name == sd["leix"].ToString())
                    {
                        temp.Nodes.Add(sd["mc"].ToString());
                    }
                    else if (temp.Name == "4" && temp.Name == sd["leix"].ToString())
                    {
                        temp.Nodes.Add(sd["mc"].ToString());
                    }
                    else if (temp.Name == "5" && temp.Name == sd["leix"].ToString())
                    {
                        temp.Nodes.Add(sd["mc"].ToString());
                    }
                    else if (temp.Name == "6" && temp.Name == sd["leix"].ToString())
                    {
                        temp.Nodes.Add(sd["mc"].ToString());
                    }
                }

            }
            sd.Close();
            conn.Close();
        }
        /// <summary>
        /// 点击列表添加到清单
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void trewlb_AfterSelect(object sender, TreeViewEventArgs e)
        {
            string djj = null;
            string a = this.trewlb.SelectedNode.Text;
            //文件框中显示鼠标点击的节点名称
            conn = new OleDbConnection(str);
            conn.Open();
            string sqlzj = "select * from tb_Chuangku where mc='" + a + "'  ";
            cmd = new OleDbCommand(sqlzj, conn);
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                djj = dr["dj"].ToString();
            }
            dr.Close();
            if (e.Node.Level == 1) //判断子节点才响应
            {
                //增加
                string sqlts = "select sl from tb_xfxf where xmmc='" + a + "' and cth='"+FrmZj.cth+"' ";//点击的项目名称判断是否相同
                cmd.CommandText = sqlts;
                object sll = cmd.ExecuteScalar();
                int shu = Convert.ToInt32(sll);//object转数字int
                if (shu <= 0)//密钥中国食物添加，有就修改数值和价钱
                {
                    string sql = "insert into tb_xfxf (cth,xmmc,dj,sl,je,dcsj,jzr,zk) values('" + cth + "','" + a + "'," + djj + ",1," + djj + ",'" + FrmMain.jdzsj + "','" + FrmMain.ryy + "',1) ";
                    cmd = new OleDbCommand(sql, conn);
                    dr = cmd.ExecuteReader();
                    dr.Read();
                    dr.Close();
                }
                else if (shu >= 1)
                {
                    int shull = shu + 1;
                    int jee = int.Parse(djj) * shull;
                    string zjsql = "update  tb_xfxf set sl=" + shull + ",je=" + jee + " where xmmc='" + a + "'and cth='"+FrmZj.cth+"' ";
                    cmd.CommandText = zjsql;
                    int r = cmd.ExecuteNonQuery();
                }
            }
            conn.Close();
            Bingxf();//重新绑定
        }
        /// <summary>
        /// 确认按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void butqr_Click(object sender, EventArgs e)
        {
          
            this.Dispose();
        }
        /// <summary>
        /// 项目增加
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {

            if (this.tabControl1.SelectedIndex==0)//判断选项卡索引===0/==1
	        {
                dgwqd_CellDoubleClick(null,null);
            }
            else if (this.tabControl1.SelectedIndex == 1)
            {
                trewlb_AfterSelect(null, null);
            }
            Bingxf();
        }
        /// <summary>
        /// 退菜
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            conn = new OleDbConnection(str);
            conn.Open();
            string mmc = this.dgwxfqd.CurrentRow.Cells[1].Value.ToString();//名称
            string kc1 = this.dgwxfqd.CurrentRow.Cells[4].Value.ToString();//数量
            string dj1 = this.dgwxfqd.CurrentRow.Cells[2].Value.ToString();//单价
            string daqe1 = this.dgwxfqd.CurrentRow.Cells[8].Value.ToString();//编号
            string sql = "select sl from tb_xfxf where xfxf=" +daqe1+ "";//按照名称获取数量
            cmd = new OleDbCommand(sql, conn);
            object sll = cmd.ExecuteScalar();
            int sl1 = Convert.ToInt32(sll);
            if (sl1 > 1)
            {
                sl1 -= 1;
                string sqlxg = "update tb_xfxf set sl=" + sl1 + " where  xfxf=" + daqe1 + " ";   //按照名称修改数量
                cmd.CommandText = sqlxg;
                cmd.ExecuteScalar();

            }
            else if (sl1 == 0 || sl1 == 1)
            {
                sl1 = -1;
                string sqlsc = "delete from tb_xfxf where xfxf=" + daqe1 + " "; //按照名称删除
                cmd.CommandText = sqlsc;
                cmd.ExecuteScalar();
            }
            conn.Close();
            Bingxf();
        }

        /// <summary>
        /// 转台
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button5_Click(object sender, EventArgs e)
        {
            FrmZhuanT zt = new FrmZhuanT();
           
            string da1 =this.dgwxfqd.CurrentRow.Cells[8].Value.ToString();//编号
            string mmc1 = this.dgwxfqd.CurrentRow.Cells[1].Value.ToString();//名称
            string dj1 = this.dgwxfqd.CurrentRow.Cells[5].Value.ToString();//金额
            string shull1= this.dgwxfqd.CurrentRow.Cells[4].Value.ToString();//数量
            zt.zhuntsl = shull1;
            FrmZhuanT.bh = da1;
            FrmZhuanT.mcc = mmc1;
            FrmZhuanT.jne = dj1;    
            zt.ShowDialog();

            FrmZj_Load(null,null);
         
        }
        /// <summary>
        /// 后台催菜
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void butht_Click(object sender, EventArgs e)
        {
            string mmc1 = this.dgwxfqd.CurrentRow.Cells[1].Value.ToString();//名称

            FrmHouTai f = new FrmHouTai();
            f.cm = mmc1;
            f.Show();
        }
        /// <summary>
        /// 选择项目列表
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void butxfli_Click(object sender, EventArgs e)
        {
            this.tabControl1.SelectedTab = tabPage2;
        }
        /// <summary>
        /// 编码/简称
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtcxjcbh_TextChanged(object sender, EventArgs e)
        {
            conn = new OleDbConnection(str);
            conn.Open();
            if (this.txtcxjcbh.Text=="")
            {
                conn = new OleDbConnection(str);
                string sql = "select * from tb_Chuangku ";
                da = new OleDbDataAdapter(sql, conn);
                ds = new DataSet();
                da.Fill(ds);
                this.dgwqd.AutoGenerateColumns = false;
                this.dgwqd.DataSource = ds.Tables[0];

                this.labxs.Text = this.dgwxfqd.CurrentRow.Cells[1].Value.ToString(); //提示文本
            }
            else
            {
                conn = new OleDbConnection(str);
                string sql = "select * from tb_Chuangku where xmbh like '%"+this.txtcxjcbh.Text+"%'  or mc like'%" + this.txtcxjcbh.Text + "%'"; //根据编号或姓名查询
                da = new OleDbDataAdapter(sql, conn);
                ds = new DataSet();
                da.Fill(ds);
                this.dgwqd.AutoGenerateColumns = false;
                this.dgwqd.DataSource = ds.Tables[0];

                //如果为空提示文本清空
                if (this.dgwqd.Rows.Count == 0)
                {
                    this.labxs.Text = "";

                }else{
                    this.labxs.Text=this.dgwqd.CurrentRow.Cells[1].Value.ToString();//提示文本
                }
            }

        }

        /// <summary>
        /// 点击按钮增加
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void butzjf3_Click(object sender, EventArgs e)
        {
            //判断数量框是否为空
            if (this.txtxfsl.Text == "" || this.txtxfsl.Text == null)
            {
                MessageBox.Show("消费数量不能为空");
                return;
            }
            int slf2 =int.Parse( this.txtxfsl.Text);
            string xmmc = this.dgwqd.CurrentRow.Cells[1].Value.ToString();//名称
            string djj = this.dgwqd.CurrentRow.Cells[2].Value.ToString();//单价
            string kc = this.dgwqd.CurrentRow.Cells[3].Value.ToString();//数量

            conn = new OleDbConnection(str);
            conn.Open();
            //增加
            string sqlts = "select sl from tb_xfxf where xmmc='" + xmmc + "' and cth='" + FrmZj.cth + "'";//点击的项目名称判断是否相同
            cmd = new OleDbCommand(sqlts, conn);
            object sll = cmd.ExecuteScalar();
            int shu = Convert.ToInt32(sll);//object转数字int
            int r;
            if (shu >= 1)
            {
                int shull = shu + slf2;
                int jee = int.Parse(djj) * shull;
                string zjsql = "update  tb_xfxf set sl=" + shull + ",je=" + jee + " where xmmc='" + xmmc + "' and cth='" + FrmZj.cth + "' ";
                cmd.CommandText = zjsql;
                r = cmd.ExecuteNonQuery();
            }
            else //没有这个食物添加，有就修改数值和价钱
            {
                string sql = "insert into tb_xfxf (cth,xmmc,dj,sl,je,dcsj,jzr,zk) values('" + cth + "','" + xmmc + "'," + djj + ",1," + djj + ",'" + FrmMain.jdzsj + "','" + FrmMain.ryy + "',"+this.txtxfsl.Text+") ";
                cmd = new OleDbCommand(sql, conn);
                r = cmd.ExecuteNonQuery();
            }
            conn.Close();
            Bingxf();//重新绑定
        }
        }

      






}
