using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SQLite;
using Project_02_YefengWu.DBLayer;

namespace Project_02_YefengWu
{
    class RoomDB
    {
        public static DataRowCollection GetAll()
        {
            string sql = "Select * From Room";
            
            return DB.ExecuteQuery(sql);
        }

        public static DataRow GetOne(string Name)
        {
            string sql = "Select * From Room Where Name = '" + Name + "'";
            DataRowCollection rows = DB.ExecuteQuery(sql);
            
            return rows[0];
        }

        public static DataRow GetOne(int ID)
        {
            string sql = "Select * From Room Where ID = " + ID.ToString();
            DataRowCollection rows = DB.ExecuteQuery(sql);
            
            return rows[0];
        }
    }
}
