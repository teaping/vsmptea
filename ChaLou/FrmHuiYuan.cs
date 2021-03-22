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
    public partial class FrmHuiYuan : Form
    {
        string str = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=MPcLou.accdb";
        OleDbConnection conn = null;
        OleDbCommand cmd = null;
        OleDbDataReader dr = null;
        OleDbDataAdapter oda = null;
        DataSet ds = null;
        DateTime sd;
        DateTime sd1;
        public FrmHuiYuan()
        {
            InitializeComponent();
        }

        private void FrmHuiYuan_Load(object sender, EventArgs e)
        {
            this.labglzt.Text = "过滤状态：所有会员";
            HyXinBn();
            BdHyXf();
            Bdsr();
            //起始
            this.cmbqsy.Items.Clear();//清空 月下拉框
            this.cmbqsy.Items.Clear();//清空 日下拉框
            for (int i = 1; i <= 12; i++)//循环
            {
                this.cmbqsy.Items.Add(i);//添加到 月 下拉框中
            }
            this.cmbqsy.SelectedIndex = 0;//默认选中 第一项
            //截至
            this.cmbjz.Items.Clear();//清空 月下拉框
            this.cmbjz.Items.Clear();//清空 日下拉框
            for (int i = 1; i <= 12; i++)//循环
            {
                this.cmbjz.Items.Add(i);//添加到 月 下拉框中
            }
            this.cmbjz.SelectedIndex = 0;//默认选中 第一项


        }
        /// <summary>
        /// 绑定会员信息
        /// </summary>
        private void HyXinBn()
        {
            conn = new OleDbConnection(str);
            string sql = "select * from tb_huiyuan a,tb_huiyuk b,tb_kxf c where a.id=b.kx and b.id=c.bh1    ";//拿到顾客姓名进行多表联查
            oda = new OleDbDataAdapter(sql, conn);
            ds = new DataSet();
            oda.Fill(ds);
            this.dgvhyxx.AutoGenerateColumns = false;
            this.dgvhyxx.DataSource = ds.Tables[0];
        }
        /// <summary>
        /// 双击查看消费明细
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvhyxx_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string yhbh = this.dgvhyxx.CurrentRow.Cells[0].Value.ToString();  //获取编号
            conn = new OleDbConnection(str);
            string cxsql = "select * from tb_hyxf where hybh='" + yhbh + "' ";
            oda = new OleDbDataAdapter(cxsql, conn);
            ds = new DataSet();
            oda.Fill(ds);
            this.dgvhymx.AutoGenerateColumns = false;
            this.dgvhymx.DataSource = ds.Tables[0];

            conn.Open();  //查询绑定会员名字
            string cxm = "select mc from tb_hyxf where hybh='" + yhbh + "' ";
            cmd = new OleDbCommand(cxm, conn);
            object a = cmd.ExecuteScalar();
            conn.Close();
            this.labhyxm.Text = "会员姓名：" + a;
        }
        /// <summary>
        /// 增加会员
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void butzjhy_Click(object sender, EventArgs e)
        {
            FrmZjHuiYun f = new FrmZjHuiYun();
            f.ShowDialog();
            FrmHuiYuan_Load(null, null);
        }
        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void butxghy_Click(object sender, EventArgs e)
        {
            string yhbh = this.dgvhyxx.CurrentRow.Cells[0].Value.ToString();  //获取编号
            FrmZjHuiYun f = new FrmZjHuiYun();
            f.num = yhbh;
            f.ShowDialog();
            FrmHuiYuan_Load(null, null);
        }
        /// <summary>
        /// 删除会员
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void butschy_Click(object sender, EventArgs e)
        {
            string yhbh1 = this.dgvhyxx.CurrentRow.Cells[0].Value.ToString();  //获取编号
            conn = new OleDbConnection(str);
            conn.Open();
            DialogResult dqr = MessageBox.Show("删除后就不能恢复，真的要删除？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            if (dqr == DialogResult.OK)
            {
                string cxid = "select id from tb_huiyuan where hybh='" + yhbh1 + "'";
                cmd = new OleDbCommand(cxid, conn);
                int hyid = Convert.ToInt32(cmd.ExecuteScalar());
                string scsql = "delete from tb_huiyuan where id=" + hyid + "";
                cmd.CommandText = scsql;
                cmd.ExecuteScalar();

            }
            conn.Close();
            FrmHuiYuan_Load(null, null);

        }
        /// <summary>
        /// 充值
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void butczhy_Click(object sender, EventArgs e)
        {
            string yhid = this.dgvhyxx.CurrentRow.Cells[0].Value.ToString();  //获取编号
            string hylx = this.dgvhyxx.CurrentRow.Cells[3].Value.ToString();  //获取类型
            if (hylx == "储存卡")
            {
                FrmHuYuCz f = new FrmHuYuCz();
                f.bh = yhid;
                f.ShowDialog();
                FrmHuiYuan_Load(null, null);
            }
            else
            {
                MessageBox.Show("不是储存卡不能充值");
            }

        }
        /// <summary>
        /// 修改密码
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void butmihy_Click(object sender, EventArgs e)
        {
            FrmHuYuMia f = new FrmHuYuMia();
            string yhid = this.dgvhyxx.CurrentRow.Cells[0].Value.ToString();  //获取编号
            f.hyid = yhid;
            f.ShowDialog();
            FrmHuiYuan_Load(null, null);
        }
        /// <summary>
        /// 金卡会员管理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 金卡会员ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            conn = new OleDbConnection(str);
            string sql = "select * from tb_huiyuan a,tb_huiyuk b,tb_kxf c where a.id=b.kx and b.id=c.bh1 and dengji='金卡会员'  ";//拿到顾客姓名进行多表联查
            oda = new OleDbDataAdapter(sql, conn);
            ds = new DataSet();
            oda.Fill(ds);
            this.dgvhyxx.AutoGenerateColumns = false;
            this.dgvhyxx.DataSource = ds.Tables[0];
            this.labglzt.Text = "过滤状态：金卡会员";
        }

        private void 银卡会员ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            conn = new OleDbConnection(str);
            string sql = "select * from tb_huiyuan a,tb_huiyuk b,tb_kxf c where a.id=b.kx and b.id=c.bh1 and dengji='银卡会员'  ";//拿到顾客姓名进行多表联查
            oda = new OleDbDataAdapter(sql, conn);
            ds = new DataSet();
            oda.Fill(ds);
            this.dgvhyxx.AutoGenerateColumns = false;
            this.dgvhyxx.DataSource = ds.Tables[0];
            this.labglzt.Text = "过滤状态：银卡会员";
        }

        private void 所有会员ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HyXinBn();
        }


        /// <summary>
        /// 绑定会员消费查询
        /// </summary>
        private void BdHyXf()
        {
            conn = new OleDbConnection(str);
            string sql = "select * from tb_hyxf where hybh<>''  ";//拿到顾客姓名进行多表联查
            oda = new OleDbDataAdapter(sql, conn);
            ds = new DataSet();
            oda.Fill(ds);
            this.dgvxfxx.AutoGenerateColumns = false;
            this.dgvxfxx.DataSource = ds.Tables[0];
        }
        /// <summary>
        /// 查询账单
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbcx_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cmbcx.Text == "全部账单")
            {
                BdHyXf();
            }
            else if (this.cmbcx.Text == "已结账账单")
            {
                conn = new OleDbConnection(str);
                string sql = "select * from tb_hyxf where jszt='已结单' and  hybh<>''   ";//拿到顾客姓名进行多表联查
                oda = new OleDbDataAdapter(sql, conn);
                ds = new DataSet();
                oda.Fill(ds);
                this.dgvxfxx.AutoGenerateColumns = false;
                this.dgvxfxx.DataSource = ds.Tables[0];
            }
            else if (this.cmbcx.Text == "充值账单")
            {
                conn = new OleDbConnection(str);
                string sql = "select * from tb_hyxf where jszt='充值卡充值' and  hybh<>''  ";//拿到顾客姓名进行多表联查
                oda = new OleDbDataAdapter(sql, conn);
                ds = new DataSet();
                oda.Fill(ds);
                this.dgvxfxx.AutoGenerateColumns = false;
                this.dgvxfxx.DataSource = ds.Tables[0];
            }
            else if (this.cmbcx.Text=="退账账单")
            {
                 conn = new OleDbConnection(str);
                string sql = "select * from tb_hyxf where jszt='退单' and  hybh<>''  ";//拿到顾客姓名进行多表联查
                oda = new OleDbDataAdapter(sql, conn);
                ds = new DataSet();
                oda.Fill(ds);
                this.dgvxfxx.AutoGenerateColumns = false;
                this.dgvxfxx.DataSource = ds.Tables[0];
            }
        }
        /// <summary>
        /// 查询消费值
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void butcxfx_Click(object sender, EventArgs e)
        {
            string wz = this.cmbcx.Text;
            if (wz == "已结账账单")
            {
                wz = "已结单";

            }
            else if (wz == "充值账单")
            {
                wz = "充值卡充值";
            }


            conn = new OleDbConnection(str);
            string sql = "select * from tb_hyxf where 1=1 and hybh='" + this.txtxfcx.Text + "'  or   mc like '%" + this.txtxfcx.Text + "%'   ";//拿到顾客姓名进行多表联查
            if (this.cmbcx.Text != null && this.cmbcx.Text != "" && this.cmbcx.Text != "全部账单")
            {
                sql += " and jszt='" + wz + "' ";
            }
            oda = new OleDbDataAdapter(sql, conn);
            ds = new DataSet();
            oda.Fill(ds);
            this.dgvxfxx.AutoGenerateColumns = false;
            this.dgvxfxx.DataSource = ds.Tables[0];
        }
        /// <summary>
        /// 会员查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void butsqcx_Click(object sender, EventArgs e)
        {
            Hqy();
            conn = new OleDbConnection(str);
            string sql1 = "select * from tb_huiyuan a,tb_huiyuk b,tb_kxf c where a.id=b.kx and b.id=c.bh1 and a.hybh='" + this.txtsrcx.Text + "' and a.Birth>=#" + sd + "#  and a.Birth <=#" + sd1
+ "#   ";//拿到顾客姓名进行多表联查
            oda = new OleDbDataAdapter(sql1, conn);
            ds = new DataSet();
            oda.Fill(ds);
            this.dvgsr.AutoGenerateColumns = false;
            this.dvgsr.DataSource = ds.Tables[0];
        }
        /// <summary>
        /// 获取时间
        /// </summary>
        private void Hqy()
        {
            string qsrq = this.cmbqsy.Text + "/" + this.numericUpDown1.Value;
            sd = DateTime.Parse(qsrq);
            string jzrq = this.cmbjz.Text + "/" + this.numericUpDown2.Value;
            sd1 = DateTime.Parse(jzrq);
        }
        /// <summary>
        /// 绑定生日
        /// </summary>
        private void Bdsr()
        {
            conn = new OleDbConnection(str);
            string sql1 = "select * from tb_huiyuan a,tb_huiyuk b,tb_kxf c where a.id=b.kx and b.id=c.bh1  ";//拿到顾客姓名进行多表联查
            oda = new OleDbDataAdapter(sql1, conn);
            ds = new DataSet();
            oda.Fill(ds);
            this.dvgsr.AutoGenerateColumns = false;
            this.dvgsr.DataSource = ds.Tables[0];
        }

        /// <summary>
        /// 数字控件控制大小
        /// </summary>
        private void bRq()
        {

            int month = int.Parse(this.cmbqsy.Text);

            switch (month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    numericUpDown1.Maximum = 31;
                    break;
                case 2:
                    numericUpDown1.Maximum = 29;

                    break;
                default:
                    numericUpDown1.Maximum = 30;

                    break;
            }

        }
        /// <summary>
        /// 起始
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbqsy_SelectedIndexChanged(object sender, EventArgs e)
        {
            bRq();
        }
        /// <summary>
        /// 截至
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            bRq();
        }
        /// <summary>
        /// 查询表
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            
            conn = new OleDbConnection(str);
            string sql = "select * from tb_huiyuan a,tb_huiyuk b,tb_kxf c where a.id=b.kx and b.id=c.bh1 and a.Name like'%" + this.txtcxhymz.Text + "%'";//拿到顾客姓名进行多表联查
            oda = new OleDbDataAdapter(sql, conn);
            ds = new DataSet();
            oda.Fill(ds);
            this.dgvhyxx.AutoGenerateColumns = false;
            this.dgvhyxx.DataSource = ds.Tables[0];
        }
    }
}
