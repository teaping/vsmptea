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
    public partial class FrmTj : Form
    {
        string str = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=MPcLou.accdb";
        OleDbConnection conn = null;
        OleDbCommand cmd = null;
        OleDbDataReader dr = null;
        OleDbDataAdapter da = null;
        DataSet ds = null;
        string zhi = null;

        public static string bt = null;//标题
        public static string zd = null;//主单餐台
        public static string xf = null;//最低消费
        public FrmTj()
        {
            InitializeComponent();
        }

        private void FrmTj_Load(object sender, EventArgs e)
        {
           
            this.dgwbh.Hide();
            this.Text = "顾客开单 " + bt;
            this.labzd.Text = zd;
            this.labzud.Text = xf;
            Bangd();
            //隐藏datagridview
            
        }
        /// <summary>
        /// 绑定datagridview
        /// </summary>
        private void Bangd()
        {
            conn = new OleDbConnection(str);
            string sql="select * from tb_Waiter";
            da= new OleDbDataAdapter(sql, conn);
            ds = new DataSet();
            da.Fill(ds);
            this.dgwbh.AutoGenerateColumns = false;
            this.dgwbh.DataSource = ds.Tables[0];
        }

        /// <summary>
        /// 取消
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void butqx_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        /// <summary>
        /// 点击打开图片，显示datagridview
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void butkdt_Click(object sender, EventArgs e)
        {
                this.dgwbh.Show();
            
        }
        /// <summary>
        /// 选中datagridview中的添加上
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgwbh_SelectionChanged(object sender, EventArgs e)
        {
           if (this.dgwbh.SelectedCells.Count != 0)
            {
                //得到选中行的索引
                int intRow = this.dgwbh.SelectedCells[0].RowIndex;
                 //得到列的索引
                int intColumn = this.dgwbh.SelectedCells[0].ColumnIndex;
                 //得到选中行某列的值
               zhi = this.dgwbh.CurrentRow.Cells[1].Value.ToString();
            }
         
           this.txtfw.Text = zhi;
           this.dgwbh.Hide();
        }
        /// <summary>
        /// 确认添加
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void butqr_Click(object sender, EventArgs e)
        {
            //判断用餐人数
            if (this.txtbk.Text.Trim() == "0" || this.txtbk.Text.Trim() == "")
            {
                MessageBox.Show("用餐人数不能为空");
                this.txtbk.Text = "1";
                return;
            }


            conn = new OleDbConnection(str);
            conn.Open();
            DateTime dqsj = DateTime.Now.ToLocalTime();
            string sql = "update tb_room set num=" + int.Parse(this.txtbk.Text) + ",WaiterName='" + this.txtfw.Text + "', RoomBZ='" + this.txtbz.Text + "',RoomZT='使用' ,zhangdanDate='"+dqsj+"' where RoomJC='" + zd + "' ";//修改room中的
            cmd = new OleDbCommand(sql, conn);
            dr = cmd.ExecuteReader();
            dr.Read();
            dr.Close();

            string tjlb = "insert into tb_LaiBing(cth,xm,sj) values('" + zd + "','" + zd + "','" + DateTime.Now + "')";
            cmd.CommandText = tjlb;
            cmd.ExecuteScalar();
            
            //删除预定表的数据
            string scyd = "delete from tb_Yuding where bh='" + zd + "'  ";
            cmd.CommandText = scyd;
            cmd.ExecuteScalar();

            conn.Close();

            this.Dispose();
        }
        /// <summary>
        /// 判断最大人数
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtbk_TextChanged(object sender, EventArgs e)
        {
            int zdrs = 0;
             if ( this.txtbk.Text!="")
                {
                    zdrs = int.Parse(this.txtbk.Text);
                }
                 conn = new OleDbConnection(str);
                 conn.Open();
            //按照餐台简称查询
                 string cxzdrs = "select yczdrs from tb_Room where RoomJC='" + zd + "'  ";
                 cmd = new OleDbCommand(cxzdrs, conn);
                 int aczdrs = Convert.ToInt32(cmd.ExecuteScalar());
                 conn.Close();
                 if (zdrs>aczdrs)
                 {
                     MessageBox.Show("用餐人数不能大于" + aczdrs);
                     return;
                 }
               



        }
    
    }
}
