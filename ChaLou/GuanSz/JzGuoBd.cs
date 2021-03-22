using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Windows.Forms;

namespace ChaLou.GuanSz
{
    class JzGuoBd
    {

        string str = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=MPcLou.accdb";
        OleDbConnection conn = null;
        OleDbCommand cmd = null;
        OleDbDataReader dr = null;
        OleDbDataAdapter oda = null;
        ListViewItem lv1 = null;


        /// <summary>
        /// 传入选项卡动态添加tag
        /// </summary>
        /// <param name="tbczy"></param>
        public void AddPage(TabControl tbczy, string tx)
        {
            TabPage vgm = new TabPage(); //实例化选项卡
            vgm.Name = "tabPage4";
            vgm.Text = tx;
            tbczy.Size = new System.Drawing.Size(1056, 491);
            tbczy.Controls.Add(vgm); //绑定上选项卡
            ListView sd = new ListView();
            sd.Size = new System.Drawing.Size(1056, 471);//设置宽度
            vgm.Controls.Add(sd);
            sd.Name = "lvxj";
            sdsd(sd);

        }
        private void sdsd(ListView sd)
        {
            conn = new OleDbConnection(str);
            conn.Open();
            string sql = "select * from tb_Room ";
            cmd = new OleDbCommand(sql, conn);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lv1 = new ListViewItem(dr["RoomName"].ToString());
                if (dr["RoomZT"].ToString() == "使用")
                {
                    lv1.ImageIndex = 0;
                }
                else if (dr["RoomZT"].ToString() == "预定")
                {
                    lv1.ImageIndex = 1;
                }
                else
                {
                    lv1.ImageIndex = 2;
                }
                sd.Items.Add(lv1);
            }
            dr.Close();
            conn.Close();
        }
    }
}
