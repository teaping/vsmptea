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
    public partial class FrmYinYeXfMx : Form
    {

        string str = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=MPcLou.accdb";
        OleDbConnection conn = null;
        OleDbCommand cmd = null;
        OleDbDataReader dr = null;
        OleDbDataAdapter oda = null;
        DataSet ds = null;
        public FrmYinYeXfMx()
        {
            InitializeComponent();
        }

        private void FrmYinYeXfMx_Load(object sender, EventArgs e)
        {
            this.cmbcxtj.SelectedIndex = 0;
            BangZd();
           // 绑定离店消费
            BangLd();
        }
        /// <summary>
        /// 绑定在店消费
        /// </summary>
        private void BangZd()
        {
            conn = new OleDbConnection(str);
            string sc = "select * from tb_xfxf a ,tb_Room b where a.cth=b.RoomJC and  b.RoomZT='使用' ";
            oda = new OleDbDataAdapter(sc, conn);
            ds = new DataSet();
            oda.Fill(ds);
            this.dgvzdxf.AutoGenerateColumns = false;
            this.dgvzdxf.DataSource = ds.Tables[0];
        }


        /// <summary>
        /// 绑定离店消费 BangLd()
        /// </summary>
        private void BangLd()
        {
            conn = new OleDbConnection(str);
            string sc = "select * from tb_xfcxlx ";
            oda = new OleDbDataAdapter(sc, conn);
            ds = new DataSet();
            oda.Fill(ds);
            this.dgvljmx.AutoGenerateColumns = false;
            this.dgvljmx.DataSource = ds.Tables[0];
        }
        /// <summary>
        /// 查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void butcx_Click(object sender, EventArgs e)
        {
            if (this.cmbcxtj.Text=="按餐台号")
            {
                conn = new OleDbConnection(str);
                string sc = "select * from tb_xfxf a ,tb_Room b where a.cth=b.RoomJC and  b.RoomZT='使用' and a.cth='" + this.txtcxgjz.Text + "' ";
                oda = new OleDbDataAdapter(sc, conn);
                ds = new DataSet();
                oda.Fill(ds);
                this.dgvzdxf.AutoGenerateColumns = false;
                this.dgvzdxf.DataSource = ds.Tables[0];
            }
            else if (this.cmbcxtj.Text=="按消费项目")
            {
                conn = new OleDbConnection(str);
                string sc = "select * from tb_xfxf a ,tb_Room b where a.cth=b.RoomJC and  b.RoomZT='使用' and a.xmmc='" + this.txtcxgjz.Text + "' ";
                oda = new OleDbDataAdapter(sc, conn);
                ds = new DataSet();
                oda.Fill(ds);
                this.dgvzdxf.AutoGenerateColumns = false;
                this.dgvzdxf.DataSource = ds.Tables[0];
            }
        }
    }
}
