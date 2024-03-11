using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace WindowsFormsApp2.Classes
{
    public class SqlConnectionClass
    {
        public static SqlConnection connect = new SqlConnection("Data Source=DESKTOP-UJFOKIV\\BAYRAKTARSERVER;Initial Catalog=BayraktarDB;Integrated Security=True;");

        public static void CheckConnection(SqlConnection tempConnection)
        {
            if (tempConnection.State == System.Data.ConnectionState.Closed)
            {
                tempConnection.Open();
            }
            else
            {
                
            }
        }
    }
}
