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
    public partial class FrmXtFwsTj : Form
    {
        string str = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=MPcLou.accdb";
        OleDbConnection conn = null;
        OleDbCommand cmd = null;
        OleDbDataReader dr = null;
        OleDbDataAdapter oda = null;
        DataSet ds = null;
        public string xg = null;
        public FrmXtFwsTj()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 保存
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void butwfsbc_Click(object sender, EventArgs e)
        {
            conn = new OleDbConnection(str);
            conn.Open();
            //修改
            if (xg!=null)
            {
                string pd = "update tb_WaireZy set fws='" + this.txtfwsdj.Text + "' where   djbh='" + this.txtdjbh.Text + "' ";
                cmd = new OleDbCommand(pd, conn);
                cmd.ExecuteScalar();
                        
            }
            else
            {
                //添加
             string pd = "select count(djbh) from tb_WaireZy where djbh='" + this.txtdjbh.Text + "'";
                        cmd = new OleDbCommand(pd, conn);
                        int a=Convert.ToInt32( cmd.ExecuteScalar());
                        if (a<1)
                        {
                            string tjd = "insert into  tb_WaireZy(djbh,fws) values('" + this.txtdjbh.Text + "','" + this.txtfwsdj.Text + "')";
                            cmd.CommandText = tjd;
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

        private void FrmXtFwsTj_Load(object sender, EventArgs e)
        {
            conn = new OleDbConnection(str);
            conn.Open();
            if (xg!=null)
            {
                
                string pd = "select * from tb_WaireZy where djbh='"+xg+"'";
                cmd = new OleDbCommand(pd, conn);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    this.txtdjbh.Text = dr["djbh"].ToString();
                    this.txtfwsdj.Text = dr["fws"].ToString();
                }
                dr.Close();
            }

            conn.Close();
        }
    }
}
