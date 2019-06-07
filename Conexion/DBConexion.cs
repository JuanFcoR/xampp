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
            string strconn = "server=bsnapgkczbf2ejnqiqwf-mysql.services.clever-cloud.com; " +
                "database = bsnapgkczbf2ejnqiqwf; Uid=ua2uw7zhs4lowjyz; Port=3306; pwd=CLJ3IanKEAlO21fgexVZ;";

            //string strconn2 = "server =192.168.137.1; database = mibase; Uid=root; Port=3306; pwd=proyecto;";
            MySqlConnection conn = new MySqlConnection(strconn);
            conn.Open();
            return conn;
        }
    }
}
