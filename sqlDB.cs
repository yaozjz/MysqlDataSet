using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Net.Sockets;
using System.Threading;
using System.Net;

namespace MySQLDataSet
{
    class mysqlDB
    {

        //数据库连接
        public MySqlConnection connetion(string server, string port, string user, string passwd, string database)
        {
            String conStr = string.Format("server={0};port={1};user id={2};password={3};database={4}", server, port, user, passwd, database);
            MySqlConnection DBcon = new MySqlConnection();
            DBcon.ConnectionString = conStr;
            return DBcon;
        }

        //数据库操作
        public static MySqlCommand command(string sql, MySqlConnection DBconn)
        {
            MySqlCommand rt = new MySqlCommand(sql, DBconn);
            return rt;
        }

        //数据库增删改
        public static int Exute(string sql, MySqlConnection DBconn)
        {
            //返回受影响的行数
            return command(sql, DBconn).ExecuteNonQuery();
        }

        //数据库的select
        public static MySqlDataReader read(string sql, MySqlConnection DBconn)
        {
            //数据库查询
            return command(sql, DBconn).ExecuteReader();
        }

    }
}
