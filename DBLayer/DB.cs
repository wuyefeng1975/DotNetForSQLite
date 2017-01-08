using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Common;

namespace Project_02_YefengWu.DBLayer
{
    class DB
    {
        public static string ConnectionString { get; set; }
        public static IDBFactory Factory { get; set; }

        public static DataRowCollection ExecuteQuery(string SQL)
        {
            DbConnection connection = Factory.Connection;
            connection.ConnectionString = ConnectionString;
            connection.Open();

            DbCommand command = Factory.Command;
            command.Connection = connection;
            command.CommandText = SQL;

            DbDataAdapter adapter = Factory.Adapter;
            adapter.SelectCommand = command;
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            connection.Close();

            return ds.Tables[0].Rows;
        }

        public static void ExecuteNonQuery(string SQL)
        {
            DbConnection connection = Factory.Connection;
            connection.ConnectionString = ConnectionString;
            connection.Open();

            DbCommand command = Factory.Command;
            command.Connection = connection;
            command.CommandText = SQL;
            command.ExecuteNonQuery();

            connection.Close();
        }
    }
}
