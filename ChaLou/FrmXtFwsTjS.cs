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
    public partial class FrmXtFwsTjS : Form
    {

        string str = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=MPcLou.accdb";
        OleDbConnection conn = null;
        OleDbCommand cmd = null;
        OleDbDataReader dr = null;
        OleDbDataAdapter oda = null;
        DataSet ds = null;
        public string fwsbh = null;
        public FrmXtFwsTjS()
        {
            InitializeComponent();
        }

        private void FrmXtFwsTjS_Load(object sender, EventArgs e)
        {
            // 绑定服务生等级
            BdFwsDj();
            if (fwsbh != null)
            {
                XgC();
            }
        }

        /// <summary>
        /// 绑定服务生等级BdFwsDj()
        /// </summary>
        private void BdFwsDj()
        {
            conn = new OleDbConnection(str);
            string bs = "select * from tb_WaireZy ";
            oda = new OleDbDataAdapter(bs, conn);
            ds = new DataSet();
            oda.Fill(ds);
            this.cmbfwsdj.DataSource = ds.Tables[0];
            this.cmbfwsdj.DisplayMember = "fws";
            this.cmbfwsdj.ValueMember = "djbh";
        }
        /// <summary>
        /// 添加保存
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void butfwsbc_Click(object sender, EventArgs e)
        {
            conn = new OleDbConnection(str);
            conn.Open();

            if (fwsbh != null)
            {
                string xgstr = "update tb_Waiter set WaiterName='" + this.txtfwsxm.Text + "',CardNum='" + this.txtsfz.Text + "',Sex='" + this.cmbxb.Text + "',Age='" + this.txtnl.Text + "' ,Tel='" + this.txtdh.Text + "',ms='" + this.txtms.Text + "',bhd='" + this.cmbfwsdj.SelectedValue + "' where WaiterNum='"+fwsbh+"'";
                cmd = new OleDbCommand(xgstr, conn);
                cmd.ExecuteScalar();

            }
            else { 
            string bcsql = "select count(WaiterNum) from tb_Waiter where  WaiterNum='" + this.txtfwsbh.Text + "'";
            cmd = new OleDbCommand(bcsql, conn);
            int a = Convert.ToInt32(cmd.ExecuteScalar());
            if (a < 1)
            {
                string tj = "insert into tb_Waiter(WaiterNum,WaiterName,Sex,Age,jsrq,bhd,ms,Tel,CardNum) values('" + this.txtfwsbh.Text + "','" + this.txtfwsxm.Text + "','" + this.cmbxb.Text + "','" + this.txtnl.Text + "','" + this.dateTimePicker1.Text + "','" + this.cmbfwsdj.SelectedValue + "','" + this.txtms.Text + "','" + this.txtdh.Text + "','" +this.txtsfz.Text + "')";
                cmd.CommandText = tj;
                cmd.ExecuteScalar();
            }
            else
            {
                MessageBox.Show("已有该编号");
                return;
            }
            }

            conn.Close();
            this.Dispose();
        }
        /// <summary>
        /// 取消
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void butfwsqx_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }


        /// <summary>
        /// 修改
        /// </summary>
        private void XgC()
        {
            this.txtfwsbh.Text = fwsbh;
            this.txtfwsbh.Enabled = false;
            conn = new OleDbConnection(str);
            conn.Open();
            string cssql = "select * from tb_Waiter a,tb_WaireZy b where a.bhd=b.djbh and   WaiterNum='" + fwsbh + "'";
            cmd = new OleDbCommand(cssql, conn);
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                this.txtfwsxm.Text = dr["WaiterName"].ToString();
                this.txtsfz.Text = dr["CardNum"].ToString();
                this.txtms.Text = dr["ms"].ToString();
                this.cmbxb.Text = dr["Sex"].ToString();
                this.txtdh.Text = dr["Tel"].ToString();
                this.txtnl.Text = dr["Age"].ToString();
                this.cmbfwsdj.Text = dr["fws"].ToString();
                this.dateTimePicker1.Text = dr["jsrq"].ToString();
            }
            this.dateTimePicker1.Enabled = false;
            dr.Close();
            conn.Close();
        }
    }
}
