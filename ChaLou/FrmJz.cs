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
    public partial class FrmJz : Form
    {
        string str = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=MPcLou.accdb";
        OleDbConnection conn = null;
        OleDbCommand cmd = null;
        OleDbDataReader dr = null;
        OleDbDataAdapter da = null;
        DataSet ds = null;
        string je;
        string zongjie = null;//总价ne
        public static string jcc;

        public FrmJz()
        {
            InitializeComponent();

        }

        private void FrmJz_Load(object sender, EventArgs e)
        {
            this.labjzct.Text = "结账餐台" + FrmJz.jcc;
            Bang();
            string a = null;
            Random r = new Random();
            for (int i = 0; i < 6; i++)
            {
                a += r.Next(0, 10);
            }
            this.labzhh.Text = a;
        }
        /// <summary>
        /// 只能选中一个cherbox
        /// </summary>
        private void Xz(CheckBox a)
        {
            int ss = 0;

        }
        /// <summary>
        /// 绑定金额
        /// </summary>
        private void Bang()
        {
            conn = new OleDbConnection(str);
            conn.Open();
            string sqlzxf = "select sum(je) from tb_xfxf where cth='" + FrmJz.jcc + "'";
            cmd = new OleDbCommand(sqlzxf, conn);
            object zxf = cmd.ExecuteScalar();
            if (zxf.ToString() == null || zxf.ToString() == "")
            {
                this.txtshje.Text = "0";
                this.labje.Text = "0";
            }
            else
            {
                this.txtshje.Text = zxf.ToString();//实收金额 
                this.labje.Text = zxf.ToString();
            }

            this.labjz.Text = "消费金额:" + zxf.ToString();

            string sql = "select * from tb_Room";
            cmd.CommandText = sql;
            dr = cmd.ExecuteReader();
            //循环绑定根节点
            while (dr.Read())
            {
                if (dr["RoomZT"].ToString() == "使用" && dr["RoomJC"].ToString() != FrmJz.jcc)
                {
                    TreeNode t1 = new TreeNode(dr["RoomJC"].ToString());
                    this.treezd.Nodes.Add(t1);
                }
            }
            dr.Close();
            string ctjc = FrmJz.jcc;
            TreeNode t2 = new TreeNode(ctjc);
            this.trezj.Nodes.Add(t2);
            string sqltcx = "select count(zjg) from tb_Zongjine  where fjh='" + FrmJz.jcc + "' ";  //查询总金额表中的
            cmd.CommandText = sqltcx;
            object r = cmd.ExecuteScalar();
            if (Convert.ToInt32(r) < 1)   //判断表中是否有这条数据
            {
                string sqltjz = "insert into tb_Zongjine(fjh,zjg) values('" + ctjc + "'," + this.txtshje.Text + ") ";
                cmd.CommandText = sqltjz;
                cmd.ExecuteNonQuery();
            }

            conn.Close();
        }

        /// <summary>
        /// 签单按钮  panlel显示事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ckbqd_CheckedChanged(object sender, EventArgs e)
        {
            //签单是否选中
            if (this.ckbqd.Checked==true)
            {
                this.panlqd.Visible =true;
            }
            else
            {
                this.panlqd.Visible = false;
                this.txtzf.Text = "";
            }


        }
        /// <summary>
        /// 计算顾客结账付钱
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtzf_TextChanged(object sender, EventArgs e)
        {
            string a = this.txtzf.Text;
            string b = this.txtshje.Text;
            int gm = 0;
            int yf = 0;
            if (int.TryParse(a, out gm) && int.TryParse(b, out yf))
            {

                int zq = gm - yf;
                this.labzy.Text = zq.ToString();
            }


        }
        /// <summary>
        /// 右侧出现消费改变
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void trezj_AfterSelect(object sender, TreeViewEventArgs e)
        {
            DataSet ds = new DataSet();
            conn = new OleDbConnection(str);
            conn.Open();
            string a = this.trezj.SelectedNode.Text; //获取选中节点文字去查询

            string sql = " select  b.*,a.WaiterName as Wss from tb_Room a,tb_xfxf b where a.RoomJC=b.cth  and b.cth='" + a + "'";
            da = new OleDbDataAdapter(sql, conn);
            da.Fill(ds);
            this.dgvjz.AutoGenerateColumns = false;
            this.dgvjz.DataSource = ds.Tables[0];
            conn.Close();
        }
        /// <summary>
        /// 向下面的树形添加 删除上面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button6_Click(object sender, EventArgs e)
        {
            //删除节点（父）
            string a = this.treezd.SelectedNode.Text;
            if (a != "" && a != null)
            {
                this.treezd.SelectedNode.Remove();
                // 添加节点
                this.trezj.Nodes.Add(a);

                conn = new OleDbConnection(str);
                conn.Open();
                string sqltjz = "insert into tb_Zongjine(fjh,zjg) values('" + a + "'," + this.txtshje.Text + ") ";
                cmd = new OleDbCommand(sqltjz, conn);
                cmd.ExecuteNonQuery();
            }

            int shul = this.trezj.Nodes.Count;
            if (shul > 1)
            {
                string jie = "select sum(zjg) from tb_Zongjine  ";
                cmd.CommandText = jie;
                int zongji = Convert.ToInt32(cmd.ExecuteScalar());

                this.labjzct.Text = "结合区内餐台";
                this.labjz.Text = "消费金额" + zongji;
                this.labje.Text = zongji.ToString();
                this.txtshje.Text = zongji.ToString();
            }

            conn.Close();
        }
        /// <summary>
        /// 删除下面  向上添加
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button5_Click(object sender, EventArgs e)
        {
            //删除节点（父）
            string a = this.trezj.SelectedNode.Text;
            if (a != "" && a != null)
            {
                this.trezj.SelectedNode.Remove();
                // 添加节点
                this.treezd.Nodes.Add(a);

                conn.Open();
                string sqltjz = "delete from tb_Zongjine where fjh='" + a + "'";
                cmd = new OleDbCommand(sqltjz, conn);
                cmd.ExecuteScalar();
            }
            int shul = this.trezj.Nodes.Count;
            if (shul == 1)
            {
                string jie = "select sum(zjg) from tb_Zongjine  ";
                cmd.CommandText = jie;
                int zongji = Convert.ToInt32(cmd.ExecuteScalar());
                this.labjzct.Text = "结合区内餐台";
                this.labjz.Text = "消费金额" + zongji;
                this.labje.Text = zongji.ToString();
                this.txtshje.Text = zongji.ToString();

            }
            conn.Close();
        }

        /// <summary>
        /// 右侧出现消费改变
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void treezd_AfterSelect(object sender, TreeViewEventArgs e)
        {
            DataSet ds = new DataSet();
            conn = new OleDbConnection(str);
            conn.Open();
            string a = this.treezd.SelectedNode.Text; //获取选中节点文字去查询
            string sql = " select  b.*,a.WaiterName as Wss from tb_Room a,tb_xfxf b where a.RoomJC=b.cth  and b.cth='" + a + "'";
            da = new OleDbDataAdapter(sql, conn);
            da.Fill(ds);
            this.dgvjz.AutoGenerateColumns = false;
            this.dgvjz.DataSource = ds.Tables[0];
            conn.Close();
        }
        /// <summary>
        /// 结账
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {

            //=========================
            if (this.txtzf.Text.Trim() == "")
            {
                MessageBox.Show("没有输入支付金额");
                return;
            }

            string j1 = this.labzy.Text.ToString();
            int jj = int.Parse(j1);
            if (jj >= 0)
            {
                string wz = null;
                conn = new OleDbConnection(str);
                conn.Open();
                string sqlcxz = "select sum(zjg) from  tb_Zongjine ";
                cmd = new OleDbCommand(sqlcxz, conn);
                object jine = cmd.ExecuteScalar();
                for (int i = 0; i < this.trezj.Nodes.Count; i++)
                {
                    wz = this.trezj.Nodes[i].Text;
                    //没有消费结账
                    if (this.txtshje.Text == null)
                    {
                        string sqlxg1 = "update tb_Room set RoomZT='待用' where RoomJC='" + wz + "'";
                        cmd.CommandText = sqlxg1;
                        cmd.ExecuteScalar();
                    }
                    //修改状态为待用跟ROOM时间状态
                    string sqlxg = "update tb_Room set RoomZT='待用',zhangdanDate=null where RoomJC='" + wz + "'";
                    cmd.CommandText = sqlxg;
                    cmd.ExecuteScalar();

                    //添加消费表
                    string cslei = "select * from tb_xfxf where cth='" + wz + "' ";
                    cmd.CommandText = cslei;
                    OleDbDataReader der = cmd.ExecuteReader();
                    //查询餐台号循环添加 到离店消费
                    while (der.Read())
                    {
                        string dqxf = "insert into tb_xfcxlx(cth,xmmc,dj,zk,sl,je,dcsj,jzr)values('" + der["cth"].ToString() + "','" + der["xmmc"].ToString() + "'," + der["dj"].ToString() + "," + der["zk"].ToString() + "," + der["sl"].ToString() + "," + der["je"].ToString() + ",'" + der["dcsj"].ToString() + "','" + der["jzr"].ToString() + "') ";
                        cmd = new OleDbCommand(dqxf, conn);
                        cmd.ExecuteScalar();
                    }
                    der.Close();
                    string sqlsc = "delete from tb_xfxf where cth='" + wz + "'";
                    cmd.CommandText = sqlsc;
                    cmd.ExecuteScalar();

                }
                string bqh = null;

                //往会员卡添加累加金额
                this.zongjie = this.labje.Text;//结算总金额
                if (this.txtbkmc.Text.Trim() != "")
                {
                    string sbqsl = "select c.id from tb_huiyuan a,tb_huiyuk b,tb_kxf c where a.id=b.kx and b.id=c.bh1 and name='" + this.txtbkmc.Text + "'  ";//拿到顾客姓名进行多表联查
                    cmd = new OleDbCommand(sbqsl, conn);
                    int jkid = Convert.ToInt32(cmd.ExecuteScalar());   //获取人手中的金卡id
                    string jkljxf = "update tb_kxf set ljxf = ljxf+" + this.labje.Text + "  where id=" + jkid + "";
                    cmd.CommandText = jkljxf;
                    cmd.ExecuteScalar();
                    string cxhybh = "select hybh from tb_huiyuan where name='" + this.txtbkmc.Text + "' ";
                    cmd = new OleDbCommand(cxhybh, conn);
                    object a = cmd.ExecuteScalar();
                    //判断是否为空
                    if (a == null)
                    {
                        bqh = "";
                    }
                    else
                    {
                        bqh = a.ToString();
                    }
                }
                //-----------------------------------------------添加到消费查询表 tb_htxf

                if (this.checkBox4.Checked == true)
                {
                    string sqljxf = "insert into tb_hyxf (mc,xfrq,jsrq,hybh,zdh,ysje,shje,jszt,cth) values('" + this.txtbkmc.Text + "','" + FrmMain.jdzsj + "','" + DateTime.Now.ToString() + "','" + bqh + "','" + this.labzhh.Text + "'," + FrmJz.jcc + "," + this.txtshje.Text + ",'退单','" + this.labjzct.Text + "') ";
                    cmd = new OleDbCommand(sqljxf, conn);
                    cmd.ExecuteScalar();
                }
                else
                {
                    string sqljxf = "insert into tb_hyxf (mc,xfrq,jsrq,hybh,zdh,ysje,shje,jszt,cth) values('" + this.txtbkmc.Text + "','" + FrmMain.jdzsj + "','" + DateTime.Now.ToString() + "','" + bqh + "','" + this.labzhh.Text + "'," + this.labje.Text + "," + this.txtshje.Text + ",'已结单','" + this.labjzct.Text + "') ";
                    cmd = new OleDbCommand(sqljxf, conn);
                    cmd.ExecuteScalar();
                }


                //----------------------------------------------------------删除来宾消息表
                string sclbn = "delete from tb_LaiBing where cth='" + FrmJz.jcc + "'";
                cmd = new OleDbCommand(sclbn, conn);
                cmd.ExecuteScalar();

                this.Dispose();
            }
            else
            {
                MessageBox.Show("金额不够");
            }
            conn.Close();
        }

        /// <summary>
        /// 免费
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        ///   
        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {


            if (this.checkBox3.Checked == false)
            {
                this.txtshje.Text = je;
            }
            else
            {
                je = this.txtshje.Text;
                this.txtshje.Text = "0";
                this.txtzf.Text = "";
            }
        }
        /// <summary>
        /// 退单
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBox4.Checked == false)
            {
                this.txtshje.Text = je;
            }
            else
            {
                je = this.txtshje.Text;
                this.txtshje.Text = "0";
                this.txtzf.Text = "";
            }
        }
        /// <summary>
        /// 挂账
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBox2.Checked == false)
            {
                this.txtshje.Text = je;
            }
            else
            {
                je = this.txtshje.Text;
                this.txtshje.Text = "0";
                this.txtzf.Text = "";
            }
        }
        /// <summary>
        /// 取消
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button4_Click(object sender, EventArgs e)
        {
            conn = new OleDbConnection(str);
            conn.Open();
            string scsql = "delete from tb_Zongjine";
            cmd = new OleDbCommand(scsql, conn);
            cmd.ExecuteScalar();
            conn.Close();

            this.Dispose();
        }
        /// <summary>
        /// 使用输入的字段为数字  （支付框）
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtzf_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if ((e.KeyChar < '0') || (e.KeyChar > '9'))//这是允许输入0-9数字 
            //{
            //    e.Handled = true;
            //}
        }
        /// <summary>
        /// 签单确认
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void butqdqr_Click(object sender, EventArgs e)
        {
            //判断签单金额是否为空
            if (this.txtqdje.Text == null || this.txtqdje.Text.Trim() == "")
            {
                MessageBox.Show("请输入签单金额");
                return;
            }
            int qdje = int.Parse(this.txtqdje.Text);
            int ysje1 = int.Parse(this.txtshje.Text);

            conn = new OleDbConnection(str);
            conn.Open();
            string drmc = this.txtqdqr.Text.ToString();
            string sqw = "select UserPwd from tb_User where UserName='" + drmc + "'";
            cmd = new OleDbCommand(sqw, conn);
            object miq = cmd.ExecuteScalar();
            if (miq == null)
            {
                MessageBox.Show("账号错误");
                return;
            }
            string mima = miq.ToString();
            //判断密码是否存在
            if (mima != this.txtqdmi.Text)
            {
                MessageBox.Show("密码错误");
                return;
            }
            //支付金额是否大于实收金额
            if (qdje >= ysje1)
            {
                this.txtzf.Text = qdje.ToString();
                this.panlqd.Visible = false;
            }
            else
            {
                MessageBox.Show("金额不够");
                return;
            }

        }
        /// <summary>
        /// 签单×按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void butc_Click(object sender, EventArgs e)
        {
            this.panlqd.Visible = false;
        }
        /// <summary>
        /// 用户
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtbkmc_TextChanged(object sender, EventArgs e)
        {
            if (this.txtbkmc.Text != "" || this.txtbkmc.Text != null)
            {
                this.panel7.Visible = true;
                conn = new OleDbConnection(str);
                string sqlc = "select * from tb_huiyuan  where Name like '%" + this.txtbkmc.Text + "%' or hybh like '%" + this.txtbkmc.Text + "%' ";
                da = new OleDbDataAdapter(sqlc, conn);
                ds = new DataSet();
                da.Fill(ds);
                this.dgvhybm.AutoGenerateColumns = false;
                this.dgvhybm.DataSource = ds.Tables[0];



            }
        }
        /// <summary>
        /// 会员查询确认
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void butcxqr_Click(object sender, EventArgs e)
        {
            string yhbh = this.dgvhybm.CurrentRow.Cells[1].Value.ToString();  //获取类型
            this.txtbkmc.Text = yhbh;
            this.panel7.Visible = false;
            this.labhyxm.Text = yhbh;
            conn = new OleDbConnection(str);
            conn.Open();
            string dblc = "select * from tb_huiyuan a,tb_huiyuk b,tb_kxf c where a.id=b.kx and b.id=c.bh1 and  a.Name='" + yhbh + "'  ";//拿到顾客姓名进行多表联查
            cmd = new OleDbCommand(dblc, conn);
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                this.labhyjb.Text = dr["dengji"].ToString();
                this.labjf.Text = dr["jf"].ToString();

            }
            dr.Close();
            conn.Close();
        }
        /// <summary>
        /// 取消
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void butcxqx_Click(object sender, EventArgs e)
        {
            this.panel7.Visible = false;
        }
        /// <summary>
        /// 打折
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txthyzk_TextChanged(object sender, EventArgs e)
        {

            Double bfb = 0;
            if (this.txthyzk.Text != " " || string.IsNullOrEmpty(this.txthyzk.Text) || this.txthyzk.Text != "无")
            {
                if (Double.TryParse(this.txthyzk.Text, out bfb) == true)
                {
                    this.txtzf.Text = "";
                    this.labzy.Text = "";
                    double zqsd = double.Parse(this.labje.Text);
                    double afsf = zqsd * (bfb / 10);
                    int zsxje = (int)afsf;
                    this.txtshje.Text = zsxje.ToString();
                }
                else
                {
                    MessageBox.Show("请输入数字类型");
                }

            }
        }
        /// <summary>
        /// 双击树形菜单右侧出现信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void trezj_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            trezj_AfterSelect(null, null);
        }
        /// <summary>
        /// 双击上面树形菜单右侧出现显示
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void treezd_DoubleClick(object sender, EventArgs e)
        {
            treezd_AfterSelect(null, null);
        }
    }
}
