using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace ChaLou
{
    class BangDzhok
    {
        //string str = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=MPcLou.accdb";
        //OleDbConnection conn = null;
        //OleDbCommand cmd = null;
        //OleDbDataReader dr = null;
        //ListViewItem lv1 = null;
        //string kw = "大厅";

        //private void Bind1()
        //{
        //    lvxb.Clear();
        //    conn = new OleDbConnection(str);
        //    conn.Open();
        //    string sql = "select * from tb_Room where RoomWZ='" + kw + "' ";
        //    cmd = new OleDbCommand(sql, conn);
        //    dr = cmd.ExecuteReader();
        //    while (dr.Read())
        //    {
        //        lv1 = new ListViewItem(dr["RoomName"].ToString());
        //        if (dr["RoomZT"].ToString() == "使用")
        //        {
        //            lv1.ImageIndex = 0;
        //        }
        //        else
        //        {
        //            lv1.ImageIndex = 1;
        //        }
        //        this.lvxb.Items.Add(lv1);
        //    }
        //}

        //private void Bind2()
        //{
        //    lvdb.Clear();
        //    conn = new OleDbConnection(str);
        //    conn.Open();
        //    string sql = "select * from tb_Room where RoomWZ='" + kw + "' ";
        //    cmd = new OleDbCommand(sql, conn);
        //    dr = cmd.ExecuteReader();
        //    while (dr.Read())
        //    {
        //        lv1 = new ListViewItem(dr["RoomName"].ToString());
        //        if (dr["RoomZT"].ToString() == "使用")
        //        {
        //            lv1.ImageIndex = 0;
        //            Bind();
        //        }
        //        else
        //        {
        //            lv1.ImageIndex = 1;
        //        }
        //        this.lvdb.Items.Add(lv1);
        //    }
        //}
    }
}
