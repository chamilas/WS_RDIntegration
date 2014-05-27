using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Configuration;

namespace wsRDIntegration
{
  public static class ConnectionStringClass
    {


        public static System.Data.SqlClient.SqlConnection GetConnection()
        {
            //return new System.Data.SqlClient.SqlConnection("Data Source=192.168.1.100;Initial Catalog=RDSales;User ID=dbadmin;Password=Abc123");
            //return new System.Data.SqlClient.SqlConnection("Data Source=ARIMAC ;Initial Catalog=RDSales; Security=True; providerName=System.Data.SqlClient");
            return new System.Data.SqlClient.SqlConnection(getConnectionStr());
        }

        public static string getConnectionStr()
        {
            string value = ConfigurationManager.ConnectionStrings["MRPConnectionString"].ConnectionString;
            return value;

        }

    }
}
