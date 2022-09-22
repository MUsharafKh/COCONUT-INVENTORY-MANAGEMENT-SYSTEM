using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace Coco_Master
{
    class DbConnection
    {
        public static SqlConnection SqlServerConnection()
        {
            String connection_string = @"Data Source=DESKTOP-QI6H2EA;Initial Catalog=Coco_Master;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connection_string);
            return connection;
        }
    }
}
