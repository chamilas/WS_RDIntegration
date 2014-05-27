using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace wsRDIntegration
{
    class Outlet_DL
    {
        SqlConnection Connection = new SqlConnection();


        public Outlet_DL(SqlConnection Conn)
        {
            Connection = Conn;
        }

        public bool Add(string Name, string Address, string Owner, string Phone, string DOB, int OutletType, int Territory, int Region, int Route, int UserID, int NoOfEmployees, int Status, int IsKeyOutlet, int OutletNumber, float Longitude, float Latitude)
        {
            try
            {
                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@Name", Name),
                new SqlParameter("@Address",Address),
                new SqlParameter("@Owner",Owner),
                new SqlParameter("@Phone", Phone),
                new SqlParameter("@DOB", DOB),
                new SqlParameter("@OutletType", OutletType),
                new SqlParameter("@Territory", Territory),
                new SqlParameter("@Region", Region),
                new SqlParameter("@Route", Route),
                new SqlParameter("@UserID", UserID),
                new SqlParameter("@Status", Status),
                new SqlParameter("@IsKeyOutlet", IsKeyOutlet),
                new SqlParameter("@NoOfEmployees", NoOfEmployees),
                new SqlParameter("@OutletNumber", OutletNumber),
                new SqlParameter("@Longitude", Longitude),
                new SqlParameter("@Latitude", Latitude)
                };

                Execute.RunSP_Output(Connection, "SPADD_Outlet_WCF", paramList);

                return true;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }


        }
    }
}
