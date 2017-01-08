using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Common;

namespace Project_02_YefengWu
{
    public interface IDBFactory
    {
        DbConnection Connection { get; }

        DbCommand Command { get; }
        
        DbDataAdapter Adapter { get; }
    }
}
