using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;


namespace wsRDIntegration
{
    public class RDSalesDispatchNote_DL
    {
        SqlConnection Connection = new SqlConnection();


        public RDSalesDispatchNote_DL(SqlConnection Conn)
        {
            Connection = Conn;
        }

        public DataTable Get(int DispatchID)
        {

            try
            {

                int x = 0,y=0,z=0;

                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@TerritoryID", DispatchID)};

                return Execute.RunSP_DataTable(Connection, "SPGET_DispatchNote", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }

            
        }




    }
}
