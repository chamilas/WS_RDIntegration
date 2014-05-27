using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.Data.SqlClient;
using System.Data;
using wsRDIntegration.RDSales_REF;

namespace wsRDIntegration
{



    [ServiceBehavior(InstanceContextMode=InstanceContextMode.Single)]

   public class RDSalesInvoiceService:IRDSalesInvoiceService
    {

        public bool SubmitInvoice(int InvoiceID, string InvoiceBy, string InvoiceDate, string PaymentType, int OutletID, int RouteID, int TerritoryID, int RegionID, RDSalesInvoiceDetails[] objInvoiceDetails, RDSalesInvoiceDF[] objInvoiceDF)
        {
            //RDSalesInvoiceDetails[] objInvoiceDetails
            try
            {
                RDSalesInvoice_DL objRDSalesInvoice_DL = new RDSalesInvoice_DL(ConnectionStringClass.GetConnection());

                bool isSuccess = objRDSalesInvoice_DL.Add(InvoiceID, InvoiceBy, InvoiceDate, PaymentType, OutletID, RouteID, TerritoryID, RegionID, objInvoiceDetails,objInvoiceDF);

                return isSuccess;


            }
            catch (Exception ex)
            {
                return false; 
            }
        }


        public int GetInvoiceCount()
        {
            try
            {
                //RDSalesInvoice_DL objRDSalesInvoice_DL = new RDSalesInvoice_DL(ConnectionStringClass.GetConnection());

                //int RowsEffected = objRDSalesInvoice_DL.ge

                return 1;

                // return x + "Done";

            }
            catch (Exception ex)
            {
                return 0;
            }
        }


        public string GetInvoice(string x)
        {
            try
            {

                return x;

            }
            catch (Exception ex)
            {
                return "error";
            }
        }

        public List<DispatchNote> GetDispatchNote(int TerritoryID)
        {
            RDSalesDispatchNote_DL objRDSalesInvoice_DL = new RDSalesDispatchNote_DL(ConnectionStringClass.GetConnection());  
            DataTable dt = new DataTable(); 
            dt=objRDSalesInvoice_DL.Get(TerritoryID);
            List<DispatchNote> players = new List<DispatchNote>();
            DispatchNote dpl = new DispatchNote();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                dpl.DispatchID = dt.Rows[i][0].ToString();
                dpl.GRNNo = Convert.ToInt32(dt.Rows[i][1].ToString());
                players.Add(dpl);
            }
                return players;

        }

        public bool AddOutlet(string Name, string Address, string Owner, string Phone, string DOB, int OutletType, int Territory, int Region, int Route, int UserID, int NoOfEmployees, int Status, int IsKeyOutlet, int OutletNumber, float Longitude, float Latitude)
        {
            //RDSalesInvoiceDetails[] objInvoiceDetails
            try
            {
                Outlet_DL objOutlet_DL = new Outlet_DL(ConnectionStringClass.GetConnection());

                bool isSuccess = objOutlet_DL.Add( Name,  Address,  Owner,  Phone,  DOB,  OutletType,  Territory, Region,  Route,  UserID,  NoOfEmployees,  Status,  IsKeyOutlet,  OutletNumber,  Longitude,  Latitude);

                return isSuccess;


            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool SubmitNewInvoice(int RegionID, string PaymentType, string InvoiceBy, int InvoiceID, int OutletID, string InvoiceDate, int TerritoryID, int RouteID, RDSalesInvoiceDetails[] objInvoiceDetails, RDSalesInvoiceDiscounts[] objInvoiceDiscounts, RDSalesInvoiceFreeIssues[] objInvoiceFreeIssues)
        {
            //RDSalesInvoiceDetails[] objInvoiceDetails
            try
            {
                RDSalesInvoice_DL objRDSalesInvoice_DL = new RDSalesInvoice_DL(ConnectionStringClass.GetConnection());

                bool isSuccess = objRDSalesInvoice_DL.Add_NewInvoice( RegionID,  PaymentType,  InvoiceBy,  InvoiceID,  OutletID,  InvoiceDate,  TerritoryID, RouteID,  objInvoiceDetails,  objInvoiceDiscounts, objInvoiceFreeIssues);

                return isSuccess;


            }
            catch (Exception ex)
            {
                return false;
            }
        }

    }
}
