using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SQLite;
using System.Data.Common;

namespace Project_02_YefengWu.DBLayer
{
    class SQLiteFactory : IDBFactory
    {
        public SQLiteFactory()
        {
        }

        public DbConnection Connection 
        {
            get
            {
                return new SQLiteConnection();
            }
        }

        public DbCommand Command 
        {
            get
            {
                return new SQLiteCommand();
            }
        }

        public DbDataAdapter Adapter 
        {
            get
            {
                return new SQLiteDataAdapter();
            }
        }
    }
}
