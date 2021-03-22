using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace ChaLou.GuanSz
{
    class GuolvCk
    {


        string str = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=MPcLou.accdb";
        OleDbConnection conn = null;
        OleDbCommand cmd = null;
        OleDbDataReader dr = null;
        OleDbDataAdapter oda = null;
        ListViewItem lv1 = null;
        //定义接受状态
        private string  Wenz;
        /// <summary>
        /// 修改值
        /// </summary>
        /// <param name="ws"></param>
        public GuolvCk(string ws)
        {
            this.Wenz = ws;
        }
        /// <summary>
        /// 传员选项卡
        /// </summary>
        /// <param name="a"></param>
        public void Bang(TabControl a,ListView b)
        {
            ListView lvzs = b; //定义listview
          string   kw = a.SelectedTab.Text;//拿到选中的选项卡文字判断
            switch (kw)
            {
                case "一楼大厅":
                    kw = "大厅";
                    lvzs = b;
                    lvzs.Clear();
                    break;
                case "二楼小包":
                    kw = "包房";
                    lvzs = b;
                    lvzs.Clear();
                    break;

                case "一楼大包":
                    kw = "大包房";
                    lvzs = b;
                    lvzs.Clear();
                    break;
            }
            conn = new OleDbConnection(str);
            conn.Open();
            string sql = "select * from tb_Room where RoomWZ='" + kw + "' ";
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
                lvzs.Items.Add(lv1);
            }
            if (Wenz=="小图标")
            {
                   lvzs.View = View.SmallIcon;
            }
            else if (Wenz=="大图标")
            {
                lvzs.View = View.LargeIcon;
            }
            else if(Wenz=="中图标")
            {
                lvzs.View = View.List;
            }
         
            dr.Close();
            conn.Close();
        }




    }
}
