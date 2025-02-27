using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace AmeltaManagement
{
    internal class koneksi
    {
        public SqlConnection GetConn()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=MSI;Initial Catalog=AmeltaManagement;Integrated Security=True";
            return conn;
        }
    }
}
