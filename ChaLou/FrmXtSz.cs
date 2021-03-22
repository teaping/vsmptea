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
using System.Threading;

namespace ChaLou
{
    public partial class FrmXtSz : Form
    {
         FrmLogin fds=null;

        string str = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=MPcLou.accdb";
        OleDbConnection conn = null;
        OleDbCommand cmd = null;
        OleDbDataReader dr = null;
        OleDbDataAdapter oda = null;
        DataSet ds = null;
        int num1 = 0;
        public FrmXtSz()
        {
            InitializeComponent();
        }
        
        private void FrmXtSz_Load(object sender, EventArgs e)
        {
            BangBm();

            Cthxx();
            Cthsa();
            Bgl();

            //------------------------
            ///绑定商品项目
            Bsp();
            /// 绑定子菜
            Bdcx();
           // 绑定过商品
            Bglsp();
            //绑定服务生设置
                BdFws();
            // 绑定员工
                BdXiFws();
            // 绑定过滤服务生
                BdFws1();

            // 绑定操作员
                BdCzy();

                num1 += 1;//判断过滤在加载后调用
        }

        /// <summary>
        /// 绑定部门
        /// </summary>
        private void BangBm()
        {
            
            conn = new OleDbConnection(str);
            string sc = "select * from tb_UserZa";
            oda = new OleDbDataAdapter(sc, conn);
            ds = new DataSet();
            oda.Fill(ds);
            this.dgvbm.AutoGenerateColumns = false;
            this.dgvbm.DataSource = ds.Tables[0];
        }



        /// <summary>
        /// 查询所有信息
        /// </summary>
        private void Cthxx()
        {
            conn = new OleDbConnection(str);
            string sc="select * from tb_Room";
            oda = new OleDbDataAdapter(sc, conn);
            ds = new DataSet();
            oda.Fill(ds);
            this.dgvxxdat.AutoGenerateColumns =false;
            this.dgvxxdat.DataSource = ds.Tables[0];

        }
        /// <summary>
        /// 绑定类型
        /// </summary>
        private void Cthsa()
        {
            conn = new OleDbConnection(str);
            string scq = "select * from tb_RoomLx";
            ds = new DataSet();
            oda = new OleDbDataAdapter(scq, conn);
            oda.Fill(ds);
            this.dgvlx.AutoGenerateColumns = false;
            this.dgvlx.DataSource = ds.Tables[0];
        }
        /// <summary>
        /// 添加房间类型
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttjfj_Click(object sender, EventArgs e)
        {
            FrmXtFjTj f = new FrmXtFjTj();
            f.ShowDialog();
            FrmXtSz_Load(null, null);
        }
        /// <summary>
        /// 修改类型
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void butxgfj_Click(object sender, EventArgs e)
        {
            string yhbh = this.dgvlx.CurrentRow.Cells[0].Value.ToString();  //获取类型
            FrmXtFjTj f = new FrmXtFjTj();
            f.num = yhbh;
            f.ShowDialog();
            FrmXtSz_Load(null, null);
        }
        /// <summary>
        /// 单个添加餐台
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttjdg_Click(object sender, EventArgs e)
        {
            FrmXtDgtj f = new FrmXtDgtj();
            f.ShowDialog();
            FrmXtSz_Load(null, null);
            
        }

        private void buttjpl_Click(object sender, EventArgs e)
        {
            FrmXtDgFw f = new FrmXtDgFw();
            f.ShowDialog();
            FrmXtSz_Load(null, null);
        }

        /// <summary>
        /// 绑定过滤房间
        /// </summary>
        private void Bgl()
        {
            conn = new OleDbConnection(str);
            string bs = "select * from tb_RoomLx";
            oda = new OleDbDataAdapter(bs, conn);
            ds = new DataSet();
            oda.Fill(ds);
            this.cmbgllx.DataSource = ds.Tables[0];
            this.cmbgllx.DisplayMember = "fjlx";
            this.cmbgllx.ValueMember = "ID";
        
        }
        /// <summary>
        /// 按房间过滤
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbgllx_SelectedIndexChanged(object sender, EventArgs e)
        {
            conn = new OleDbConnection(str);
            string sqc = "select * from tb_Room  where  Roomsz='"+this.cmbgllx.Text+"'";
            oda = new OleDbDataAdapter(sqc, conn);
            ds = new DataSet();
            oda.Fill(ds);
            this.dgvxxdat.AutoGenerateColumns = false;
            this.dgvxxdat.DataSource = ds.Tables[0];
        }


        /// <summary>
        /// Bsp()绑定商品项目
        /// </summary>
        private void Bsp()
        {
            conn = new OleDbConnection(str);
            string sc = "select * from tb_ckf ";
            oda = new OleDbDataAdapter(sc, conn);
            ds = new DataSet();
            oda.Fill(ds);
            this.dgvspxm.AutoGenerateColumns = false;
            this.dgvspxm.DataSource = ds.Tables[0];
        }

        /// <summary>
        /// 绑定子菜
        /// </summary>
        private void Bdcx()
        {
             conn = new OleDbConnection(str);
             string sc = "select *,a.lx as Xmlxs from tb_ckf a ,tb_Chuangku b where a.id=b.leix  ";
            oda = new OleDbDataAdapter(sc, conn);
            ds = new DataSet();
            oda.Fill(ds);
            this.dgvspx.AutoGenerateColumns = false;
            this.dgvspx.DataSource = ds.Tables[0];
        }
        /// <summary>
        /// 添加商品项目
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttjcp_Click(object sender, EventArgs e)
        {
            FrmXtTjSp f = new FrmXtTjSp();
            f.ShowDialog();
            FrmXtSz_Load(null, null);
        
        }
        /// <summary>
        /// 修改餐台
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void butxgct_Click(object sender, EventArgs e)
        {
            string yhbh = this.dgvxxdat.CurrentRow.Cells[0].Value.ToString();  //获取类型
            FrmXtXg xg = new FrmXtXg();
            xg.cthh = yhbh;
            xg.ShowDialog();
            FrmXtSz_Load(null,null);
        }
        /// <summary>
        /// 删除房间
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void butscct_Click(object sender, EventArgs e)
        {
            string yhbh = this.dgvxxdat.CurrentRow.Cells[0].Value.ToString();  //获取类型
            conn = new OleDbConnection(str);
            conn.Open();
            DialogResult dqr = MessageBox.Show("删除后就不能恢复，真的要删除？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            if (dqr == DialogResult.OK)
            {

                string sc = "delete from tb_Room where RoomJC='" + yhbh + "'";
                cmd = new OleDbCommand(sc, conn);
                cmd.ExecuteScalar();
            }
            conn.Close();
            FrmXtSz_Load(null, null);
        }
        /// <summary>
        /// 删除房间类
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void butscfj_Click(object sender, EventArgs e)
        {
            string yhbh = this.dgvlx.CurrentRow.Cells[0].Value.ToString();  //获取类型
            conn = new OleDbConnection(str);
            conn.Open();
            DialogResult dqr = MessageBox.Show("删除后就不能恢复，真的要删除？", "登录提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            if (dqr == DialogResult.OK)
            {

                string sc = "delete from tb_RoomLx where fjlx='" + yhbh + "'";
                cmd = new OleDbCommand(sc, conn);
                cmd.ExecuteScalar();
            }
            conn.Close();
            FrmXtSz_Load(null, null);
        }
        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            string yhbh = this.dgvspx.CurrentRow.Cells[0].Value.ToString();  //获取类型

            FrmXtTjSp f = new FrmXtTjSp();
            f.idbh = yhbh;
            f.ShowDialog();
            FrmXtSz_Load(null, null);
        }
        /// <summary>
        /// 商品删除
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            string yhbh = this.dgvspx.CurrentRow.Cells[0].Value.ToString();  //获取类型
            conn = new OleDbConnection(str);
            conn.Open();
            DialogResult dqr = MessageBox.Show("删除后就不能恢复，真的要删除？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            if (dqr == DialogResult.OK)
            {

                string sc = "delete from tb_Chuangku where xmbh=" + yhbh + "";
                cmd = new OleDbCommand(sc, conn);
                cmd.ExecuteScalar();
            }
            conn.Close();
            FrmXtSz_Load(null, null);
        }


        /// <summary>
        /// 绑定过商品Bglsp()
        /// </summary>
        private void Bglsp()
        {
            conn = new OleDbConnection(str);
            string bs = "select * from tb_ckf";
            oda = new OleDbDataAdapter(bs, conn);
            ds = new DataSet();
            oda.Fill(ds);
            this.cmbglspq.DataSource = ds.Tables[0];
            this.cmbglspq.DisplayMember = "lx";
            this.cmbglspq.ValueMember = "ID";
        }

        /// <summary>
        /// 项目过滤
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbglspq_SelectedIndexChanged(object sender, EventArgs e)
        {
            //判断加载后点击调用
            if (num1>=1)
            {
               conn = new OleDbConnection(str);
            string scq = "select * from tb_Chuangku  where leix=" + this.cmbglspq.SelectedValue + "";
            oda = new OleDbDataAdapter(scq, conn);
            ds = new DataSet();
            oda.Fill(ds);
            this.dgvspx.AutoGenerateColumns = false;
            this.dgvspx.DataSource = ds.Tables[0]; 
            }
            
        }


        /// <summary>
        /// 绑定服务生设置BdFws()  ------------------------------------问题
        /// </summary>
        private void BdFws()
        {
            conn = new OleDbConnection(str);
            string sc = "select * from tb_WaireZy ";
            oda = new OleDbDataAdapter(sc, conn);
            ds = new DataSet();
            oda.Fill(ds);
            this.dgvygdj.AutoGenerateColumns = false;
            this.dgvygdj.DataSource = ds.Tables[0];
        }
       /// <summary>
        /// 绑定员工BdXiFws()
       /// </summary>
        private void BdXiFws()
        {
            conn = new OleDbConnection(str);
            string sc = "select * from tb_WaireZy a,tb_Waiter b where  a.djbh=b.bhd ";
            oda = new OleDbDataAdapter(sc, conn);
            ds = new DataSet();
            oda.Fill(ds);
            this.dgvxyg.AutoGenerateColumns = false;
            this.dgvxyg.DataSource = ds.Tables[0];
        }
        /// <summary>
        /// 服务员设置添加等级
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttjfw_Click(object sender, EventArgs e)
        {
            FrmXtFwsTj f = new FrmXtFwsTj();
            f.ShowDialog();
            FrmXtSz_Load(null, null);
        }
        /// <summary>
        /// 服务员修改等级
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button10_Click(object sender, EventArgs e)
        {
            string yhbh = this.dgvygdj.CurrentRow.Cells[0].Value.ToString();  //获取类型

            FrmXtFwsTj f = new FrmXtFwsTj();
            f.xg = yhbh;
            f.ShowDialog();
            FrmXtSz_Load(null, null);
        }
        /// <summary>
        /// 删除等级
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void butscfw_Click(object sender, EventArgs e)
        {
            string yhbh = this.dgvygdj.CurrentRow.Cells[0].Value.ToString();  //获取类型
            conn = new OleDbConnection(str);
            conn.Open();
            DialogResult dqr = MessageBox.Show("删除后就不能恢复，真的要删除？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            if (dqr == DialogResult.OK)
            {

                string sc = "delete from tb_WaireZy where djbh='" + yhbh + "'";
                cmd = new OleDbCommand(sc, conn);
                cmd.ExecuteScalar();
            }
            conn.Close();
            FrmXtSz_Load(null, null);
        }
        /// <summary>
        /// 添加服务生
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttjfws_Click(object sender, EventArgs e)
        {
            FrmXtFwsTjS f = new FrmXtFwsTjS();
            f.ShowDialog();
            FrmXtSz_Load(null, null);

        }
        /// <summary>
        /// 修改服务生
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void butxgfws_Click(object sender, EventArgs e)
        {
            string yhbh = this.dgvxyg.CurrentRow.Cells[0].Value.ToString();  //获取类型

            FrmXtFwsTjS f = new FrmXtFwsTjS();
            f.fwsbh = yhbh;
            f.ShowDialog();
            FrmXtSz_Load(null, null);
        }
        /// <summary>
        /// 删除服务生
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void butscfws_Click(object sender, EventArgs e)
        {
            string yhbh = this.dgvxyg.CurrentRow.Cells[0].Value.ToString();  //获取类型
            conn = new OleDbConnection(str);
            conn.Open();
            DialogResult dqr = MessageBox.Show("删除后就不能恢复，真的要删除？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            if (dqr == DialogResult.OK)
            {

                string sc = "delete from tb_Waiter where WaiterNum='" + yhbh + "'";
                cmd = new OleDbCommand(sc, conn);
                cmd.ExecuteScalar();
            }
            conn.Close();
            FrmXtSz_Load(null, null);
        }
        /// <summary>
        /// 绑定过滤服务生BdFws1()
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BdFws1()
        {
            conn = new OleDbConnection(str);
            string bs = "select * from tb_WaireZy";
            oda = new OleDbDataAdapter(bs, conn);
            ds = new DataSet();
            oda.Fill(ds);
            this.cmbglfws.DataSource = ds.Tables[0];
            this.cmbglfws.DisplayMember = "fws";
            this.cmbglfws.ValueMember = "djbh";
        
        }
        /// <summary>
        /// 过滤服务生
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbglfws_SelectedIndexChanged(object sender, EventArgs e)
        {
            conn = new OleDbConnection(str);
            string sqc = "select * from tb_Waiter where  bhd='" + this.cmbglfws.SelectedValue + "'";
            oda = new OleDbDataAdapter(sqc, conn);
            ds = new DataSet();
            oda.Fill(ds);
            this.dgvxyg.AutoGenerateColumns = false;
            this.dgvxyg.DataSource = ds.Tables[0];
        }
        /// <summary>
        /// 绑定操作员 BdCzy()
        /// </summary>
        private void BdCzy()
        {
            conn = new OleDbConnection(str);
            string sc = "select * from tb_User ";
            oda = new OleDbDataAdapter(sc, conn);
            ds = new DataSet();
            oda.Fill(ds);
            this.dgvhyf.AutoGenerateColumns = false;
            this.dgvhyf.DataSource = ds.Tables[0];
        }
        /// <summary>
        /// 添加操作员
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void butjzcy_Click(object sender, EventArgs e)
        {
            FrmXtZzyTj f = new FrmXtZzyTj();
            f.ShowDialog();
            FrmXtSz_Load(null, null);

        }



         private void FormStart()
        {
            Application.Run(fds);
        }

        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void butxgczy_Click(object sender, EventArgs e)
        {
            string yhbh = this.dgvhyf.CurrentRow.Cells[0].Value.ToString();  //获取类型
            string yhname = this.dgvhyf.CurrentRow.Cells[1].Value.ToString();  //获取name 
            FrmXtZzyTj f = new FrmXtZzyTj();
            f.bhczy = yhbh;
            f.ShowDialog(); 


            //判断修改的是否是当前管理员
            if (FrmMain.ryy==yhname)
            {
                if (FrmXtZzyTj.shzbcs!=0)
                {
                    Application.ExitThread();
                    fds = new FrmLogin();
                    Thread t = new Thread(new ThreadStart(FormStart));
                    t.Start();
                    FrmLogin ff = new FrmLogin();
                    ff.Show();
                }

             }
       
            FrmXtSz_Load(null, null);
           
           
        }
        /// <summary>
        /// 删除操作员
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void butscczy_Click(object sender, EventArgs e)
        {
            string yhbh = this.dgvhyf.CurrentRow.Cells[0].Value.ToString();  //获取类型
            conn = new OleDbConnection(str);
            conn.Open();
            DialogResult dqr = MessageBox.Show("删除后就不能恢复，真的要删除？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            if (dqr == DialogResult.OK)
            {

                string sc = "delete from tb_User where bh='" + yhbh + "'";
                cmd = new OleDbCommand(sc, conn);
                cmd.ExecuteScalar();
            }
            conn.Close();
            FrmXtSz_Load(null, null);
        }
        /// <summary>
        /// 添加部门
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button9_Click(object sender, EventArgs e)
        {

        }


    }
}
