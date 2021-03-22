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
using System.Text.RegularExpressions;//正则表达式引用

namespace ChaLou
{
    public partial class FrmXtDgFw : Form
    {
        string str = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=MPcLou.accdb";
        OleDbConnection conn = null;
        OleDbCommand cmd = null;
        OleDbDataReader dr = null;
        OleDbDataAdapter oda = null;
        DataSet ds = null;
        public FrmXtDgFw()
        {
            InitializeComponent();
        }

        private void FrmXtDgFw_Load(object sender, EventArgs e)
        {
            FjBd();
        }
        private void FjBd()
        {
            conn = new OleDbConnection(str);
            string bs = "select * from tb_RoomLx";
            oda = new OleDbDataAdapter(bs, conn);
            ds = new DataSet();
            oda.Fill(ds);
            this.cmbfjlx.DataSource = ds.Tables[0];
            this.cmbfjlx.DisplayMember = "fjlx";
            this.cmbfjlx.ValueMember = "ID";
        }

        private void Fw()
        {
            
            string rs = null, bz = null, xf = null, name1 = null, jc = null, typer = null, bjf = null, wz = null;
            string cunclx = null, dxbh = null ;
            string cunwez = this.cmbfjlx.Text;
            int zdrs = 0;
            int a = 0, b = 0;

            bool zx=Regex.IsMatch(this.txtfk.Text, @"^[-+]?\d+(\.\d+)?$");
            bool zs = Regex.IsMatch(this.txtzw.Text, @"^[-+]?\d+(\.\d+)?$");
            if (zx==true&&zs==true)
            {
                a =int.Parse(this.txtfk.Text);
                b = int.Parse(this.txtzw.Text);
                if (b-a>5)
                {
                    MessageBox.Show("一次性只能添加五个！！！");
                    return;
                }
                else
                {
                    for (int i = a; i <=b; i++)
                    {


                        switch (this.cmbfjlx.Text)
                        {
                            case "一楼大厅":
                                cunclx = "大厅-";
                                name1 = "大厅-" + i;
                                jc =i.ToString();
                                dxbh =null;
                                typer = "普通";
                                bjf = "10";
                                wz = "大厅";
                                zdrs = 10;
                                break;
                            case "一楼大包":
                                cunclx = "大包房-";
                                name1 = "大包房-" + i;
                                jc = "A" +i;
                                dxbh = "A";
                                typer = "高级";
                                bjf = "80";
                                wz = "大包房";
                                zdrs = 12;
                                break;
                            case "二楼小包":
                                cunclx = "包房-";
                                name1 = "包房-" + i;
                                jc = "B" + i;
                                typer = "中级";
                                bjf = "40";
                                wz = "包房";
                                dxbh = "B";
                                zdrs=8;
                                break;
                        }

                        name1 = cunclx + i;
                        jc = dxbh+i;

                        conn = new OleDbConnection(str);
                        conn.Open();
                        string cssql = "select count(RoomJC) from tb_Room where RoomName='" + name1 + "'";
                        cmd = new OleDbCommand(cssql, conn);
                        int a1 = Convert.ToInt32(cmd.ExecuteScalar());
                        if (a1 >= 1)
                        {
                            conn.Close();
                            MessageBox.Show("已有该房间");
                            return;
                        }
                        else
                        {
                            string sql = "insert into tb_Room (RoomName,RoomJC,RoomBJF,RoomWZ,Roomsz,RoomType,yczdrs) values('" + name1 + "','" + jc + "'," + bjf + ",'" + wz + "','" + cunwez + "','" + typer + "',"+zdrs+")";
                            cmd.CommandText = sql;
                            cmd.ExecuteScalar();
                            conn.Close();
                            this.Dispose();
                        }

                    }
                   /// =====================================================================

                }

            }
            else
            {
                MessageBox.Show("只能输入数字");
                return;
            }
        }




        /// <summary>
        /// 保存
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void butzjctbc_Click(object sender, EventArgs e)
        {
            Fw();
            this.Dispose();
        }
        /// <summary>
        /// 取消
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void butzjctqx_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
