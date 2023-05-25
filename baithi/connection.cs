using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace baithi
{
     class connection
    {
        
        private static string stringconnection = @"Data Source=VIETDZAI;Initial Catalog=tempdb;Integrated Security=True";

     
        public static SqlConnection getConnection() 
        {
            return new SqlConnection(stringconnection);
        }
    }
}
