using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using wsRDIntegration.RDSales_REF;


namespace wsRDIntegration
{
    public class RDSalesInvoice_DL
    {
        SqlConnection Connection = new SqlConnection();


        public RDSalesInvoice_DL(SqlConnection Conn)
        {
            Connection = Conn;
        }
        public bool Add(int InvoiceID, string InvoiceBy, string InvoiceDate, string PaymentType, int OutletID, int RouteID, int TerritoryID, int RegionID, 
            RDSalesInvoiceDetails[] objInvoiceDetails,RDSalesInvoiceDF[] objInvoiceDF)
        {

            try
            {

                int x = 0,y=0,z=0;

                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@InvoiceBy", InvoiceBy),
                new SqlParameter("@InvoiceID",InvoiceID),
                 new SqlParameter("@InvoiceDate",Convert.ToDateTime(InvoiceDate)),
                new SqlParameter("@OutletID", OutletID),
                new SqlParameter("@PaymentType", PaymentType),
                new SqlParameter("@RouteID", RouteID),
                new SqlParameter("@TerritoryID", TerritoryID),
                 new SqlParameter("@Region", RegionID),
                new SqlParameter("@outParam",SqlDbType.Int){Direction=ParameterDirection.Output}};

                x=Execute.RunSP_Output(Connection, "SPADD_Invoice", paramList);


                if (x > 0)
                {

                    foreach (RDSalesInvoiceDetails obj in objInvoiceDetails)
                    {

                        SqlParameter[] paramList2 = new SqlParameter[] { 

                                new SqlParameter("@InvoiceNo",x),
                                new SqlParameter("@ProductCode",Convert.ToString(obj.ProductCode)),
                                new SqlParameter("@Qty",Convert.ToInt32(obj.Qty)),
                                new SqlParameter("@SellingPrice", Convert.ToDecimal(obj.SellingPrice)),
                                new SqlParameter("@ReturnQty", Convert.ToInt32(obj.ReturnQty)),
                                new SqlParameter("@ReturnPrice", Convert.ToDecimal(obj.ReturnPrice)),
                                new SqlParameter("@DamageQty",Convert.ToInt32(obj.DamageQty)),
                                new SqlParameter("@DamagePrice", Convert.ToDecimal(obj.DamagePrice))};

                         y=Execute.RunSP_RowsEffected(Connection, "SPADD_InvoiceDetails", paramList2);

                        // y=y+1;
                    }

                }

                if (x > 0)
                {

                    foreach (RDSalesInvoiceDF obj in objInvoiceDF)
                    {
                       


                        SqlParameter[] paramList2 = new SqlParameter[] {
                
                                new SqlParameter("@InvoiceNo",x ),
                                new SqlParameter("@DiscountCode",Convert.ToString( obj.DiscountCode)),
                                new SqlParameter("@Discount", Convert.ToDecimal(obj.Discount)),
                                new SqlParameter("@F1_Code", Convert.ToString(obj.F1_Code)),
                                new SqlParameter("@F1_Qty", Convert.ToInt32(obj.F1_Qty)),
                                new SqlParameter("@F2_Code", Convert.ToString(obj.F2_Code)),
                                new SqlParameter("@F2_Qty", Convert.ToInt32(obj.F2_Qty)),
                                new SqlParameter("@F3_Code", Convert.ToString(obj.F3_Code)),
                                new SqlParameter("@F3_Qty", Convert.ToInt32(obj.F3_Qty))};

                         Execute.RunSP_RowsEffected(Connection, "SPADD_InvoiceDF", paramList2);

                         z=z+1;
                    }
                }


                if (y > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }


            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }

            
        }


        //------------------------------------------------------------------------------------ New Add Method Requested by Harsha

        public bool Add_NewInvoice(int RegionID, string PaymentType, string InvoiceBy, int InvoiceID, int OutletID, string InvoiceDate, int TerritoryID, int RouteID, RDSalesInvoiceDetails[] objInvoiceDetails
        , RDSalesInvoiceDiscounts[] objInvoiceDiscounts, RDSalesInvoiceFreeIssues[] objInvoiceFreeIssues)
        {

            try
            {

                int x = 0, y = 0, z = 0, w = 0;

                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@InvoiceBy", InvoiceBy),
                new SqlParameter("@InvoiceID",InvoiceID),
                 new SqlParameter("@InvoiceDate",Convert.ToDateTime(InvoiceDate)),
                new SqlParameter("@OutletID", OutletID),
                new SqlParameter("@PaymentType", PaymentType),
                new SqlParameter("@RouteID", RouteID),
                new SqlParameter("@TerritoryID", TerritoryID),
                 new SqlParameter("@Region", RegionID),
                new SqlParameter("@outParam",SqlDbType.Int){Direction=ParameterDirection.Output}};

                x = Execute.RunSP_Output(Connection, "SPADD_Invoice", paramList);


                if (x > 0)
                {

                    foreach (RDSalesInvoiceDetails obj in objInvoiceDetails)
                    {

                        SqlParameter[] paramList2 = new SqlParameter[] { 

                                new SqlParameter("@InvoiceNo",x),
                                new SqlParameter("@ProductCode",Convert.ToString(obj.ProductCode)),
                                new SqlParameter("@Qty",Convert.ToInt32(obj.Qty)),
                                new SqlParameter("@SellingPrice", Convert.ToDecimal(obj.SellingPrice)),
                                new SqlParameter("@ReturnQty", Convert.ToInt32(obj.ReturnQty)),
                                new SqlParameter("@ReturnPrice", Convert.ToDecimal(obj.ReturnPrice)),
                                new SqlParameter("@DamageQty",Convert.ToInt32(obj.DamageQty)),
                                new SqlParameter("@DamagePrice", Convert.ToDecimal(obj.DamagePrice))};

                        y = Execute.RunSP_RowsEffected(Connection, "SPADD_InvoiceDetails", paramList2);

                        // y=y+1;
                    }

                }

                if (x > 0)
                {

                    foreach (RDSalesInvoiceDiscounts obj in objInvoiceDiscounts)
                    {



                        SqlParameter[] paramList2 = new SqlParameter[] {
                
                                new SqlParameter("@InvoiceNo",x ),
                                new SqlParameter("@Qty",Convert.ToInt32( obj.Qty)),
                                new SqlParameter("@Group",Convert.ToString( obj.Group)),
                                new SqlParameter("@DiscountCode",Convert.ToString( obj.DiscountCode)),

                        };

                        Execute.RunSP_RowsEffected(Connection, "SPADD_InvoiceDiscounts", paramList2);

                        z = z + 1;
                    }
                }

                if (x > 0)
                {

                    foreach (RDSalesInvoiceFreeIssues obj in objInvoiceFreeIssues)
                    {



                        SqlParameter[] paramList2 = new SqlParameter[] {
                
                                new SqlParameter("@InvoiceNo",x ),
                                new SqlParameter("@Qty",Convert.ToInt32( obj.Qty)),
                                new SqlParameter("@Group",Convert.ToString( obj.Group)),
                                new SqlParameter("@DiscountCode",Convert.ToString( obj.DiscountCode)),
                                new SqlParameter("@F1_Code",Convert.ToString( obj.F1_Code))

                        };

                        Execute.RunSP_RowsEffected(Connection, "SPADD_InvoiceFreeIssues", paramList2);

                        w = w + 1;
                    }
                }

                if (y > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }


            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }


        }



    }
}
