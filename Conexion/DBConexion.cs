using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XamppTest.Conexion
{
    public class DBConexion
    {
        public static MySqlConnection ObtenerConexion()
        {
            string strconn = "server =192.168.8.21; database = mibase; Uid=root; Port=3306; pwd=proyecto;";
            MySqlConnection conn = new MySqlConnection(strconn);
            conn.Open();
            return conn;
        }
    }
}
