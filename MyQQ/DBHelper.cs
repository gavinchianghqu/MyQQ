using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace MyQQ
{
    class DBHelper
    {
        private static string connString;        //数据库连接字符串
        public static SqlConnection connection;  //数据库连接对象
    }
}
