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

    public partial class FrmJiaoBan : Form
    {

        //  public static void SetCompatibleTextRenderingDefault(bool defaultValue);
        string str = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=MPcLou.accdb";
        OleDbConnection conn = null;
        OleDbCommand cmd = null;
        OleDbDataReader dr = null;
        OleDbDataAdapter oda = null;
        DataSet ds = null;
        public static bool adsa = false;
        //Sunisoft.IrisSkin.SkinEngine s = null;
        FrmLogin f = null;
        public FrmJiaoBan()
        {
            InitializeComponent();

        }
        //public FrmJiaoBan(Sunisoft.IrisSkin.SkinEngine skin)
        //{
        //    InitializeComponent();
        //    s = skin;

        //}

        /// <summary>
        /// 取消交班
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void butqx交班_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void FrmJiaoBan_Load(object sender, EventArgs e)
        {

            BangDinJb();
            BangDingJb();
        }
        /// <summary>
        /// 绑定基本数据
        /// </summary>
        /// 
        private void BangDingJb()
        {
            int zs =0;
            conn = new OleDbConnection(str);
            conn.Open();
            string cs = "select sum(shje) from tb_hyxf  where  jsrq >=#" + DateTime.Now.Date + "# and  jsrq <=#" + DateTime.Now.Date.AddDays(1) + "#";
            cmd = new OleDbCommand(cs, conn);
            string wzzs=cmd.ExecuteScalar().ToString();
            if(int.TryParse(wzzs,out zs)){
            }
            else
            {
                zs = 0;
            }
            conn.Close();
            this.labje.Text = zs.ToString();  //绑定金额
            this.labjbyg.Text = FrmMain.ryy; //绑定员工

        }


        /// <summary>
        /// 绑定交班
        /// </summary>
        private void BangDinJb()
        {
            conn = new OleDbConnection(str);
            string sql = "select * from tb_JaoBan";
            oda = new OleDbDataAdapter(sql, conn);
            ds = new DataSet();
            oda.Fill(ds);
            this.dgvjb.AutoGenerateColumns = false;
            this.dgvjb.DataSource = ds.Tables[0];


        }
        /// <summary>
        /// 历史交班取消
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        /// <summary>
        /// 当初交班
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void butqrjb_Click(object sender, EventArgs e)
        {
            int jbjq = 0;//上一个交班金钱
            int zgjq = 0;//这个金钱
            DateTime sjqq = DateTime.Now;
            conn = new OleDbConnection(str);
            conn.Open();


            string zsq = "select sum(shje) from tb_hyxf where jsrq <=#" + DateTime.Now + "# and  jsrq >=#" + DateTime.Now.Date + "# ";
            cmd = new OleDbCommand(zsq, conn);
            int shulsd = Convert.ToInt32(cmd.ExecuteScalar());
            string jeqq = "select sum(je)  from tb_JaoBan where jbsj <=#" + DateTime.Now + "# and  jbsj >=#" + DateTime.Now.Date + "# "; //寻找今天是否有该钱入账
            cmd.CommandText = jeqq;
            string jbjqe = cmd.ExecuteScalar().ToString();
            if (int.TryParse(jbjqe, out jbjq))
            {
                zgjq = shulsd - jbjq;
            }
            else
            {
                zgjq = int.Parse(this.labje.Text);
            }


            string tjjb = "insert into tb_JaoBan(jbsj,yg,je) values('" + sjqq + "','" + FrmMain.ryy + "'," + zgjq + ")";
            cmd.CommandText = tjjb;
            cmd.ExecuteScalar();







            conn.Close();
            //FrmLogin f = new FrmLogin();
            //f.ShowDialog();
            //this.Dispose();
            //this.Close();
            //Application.Run(new FrmLogin());
            //Application.ExitThread();
            Application.ExitThread();
            //this.Dispose();
            // base.Dispose();
            f = new FrmLogin();

            Thread t = new Thread(new ThreadStart(FormStart));
            t.Start();
            FrmLogin ff = new FrmLogin();
            ff.s = new Sunisoft.IrisSkin.SkinEngine();
            ff.s.SkinFile = "Skins\\EmeraldColor3.ssk";

            ff.Show();


        }
        private void FormStart()
        {
            Application.Run(f);
        }


        private void button1_Click(object sender, EventArgs e)
        {
            butqrjb_Click(null, null);




        }
    }
}
