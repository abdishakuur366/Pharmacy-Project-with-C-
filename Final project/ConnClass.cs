using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Final_project
{
    public  class ConnClass
    {
        public static SqlConnection Connect()
        {
            SqlConnection conn = new SqlConnection("server=.; database=Employees; integrated security=true");
            SqlCommand cmd = new SqlCommand();
            conn.Open();
            
            return conn;
        }
    }
}
