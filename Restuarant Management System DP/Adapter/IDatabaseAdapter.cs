using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restuarant_Management_System_DP.Adapter
{
    internal interface IDatabaseAdapter
    {
        void selectTable(string tableName);
        void withColumns(string columns);
        void where(string key, );
    }
}
