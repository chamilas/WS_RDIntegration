using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.ServiceModel.Web;
using wsRDIntegration.RDSales_REF;


namespace wsRDIntegration
{
   [ServiceContract]
        
  public  interface IRDSalesInvoiceService
    {
       [OperationContract]

       [WebInvoke(Method = "POST",
            UriTemplate = "SubmitInvoice",
            BodyStyle = WebMessageBodyStyle.Wrapped,
            ResponseFormat = WebMessageFormat.Json,
            RequestFormat = WebMessageFormat.Json)]

       bool SubmitInvoice(int InvoiceID, string InvoiceBy, string InvoiceDate, string PaymentType, int OutletID, int RouteID, int TerritoryID, int RegionID, 
           RDSalesInvoiceDetails[] objInvoiceDetails, RDSalesInvoiceDF[] objInvoiceDF);

       [OperationContract]

       [WebGet(UriTemplate = "GetInvoiceCount",
            BodyStyle = WebMessageBodyStyle.Wrapped,
            ResponseFormat = WebMessageFormat.Json,
            RequestFormat = WebMessageFormat.Json)]

       int GetInvoiceCount();

       [OperationContract]

       [WebInvoke(Method = "POST",
           UriTemplate = "GetInvoice",
            BodyStyle = WebMessageBodyStyle.Wrapped,
            ResponseFormat = WebMessageFormat.Json,
            RequestFormat = WebMessageFormat.Json)]

       string GetInvoice(string x);

       [OperationContract]

       [WebInvoke(Method = "POST",
           UriTemplate = "GetDispatchNote",
            BodyStyle = WebMessageBodyStyle.Wrapped,
            ResponseFormat = WebMessageFormat.Json,
            RequestFormat = WebMessageFormat.Json)]

       List<DispatchNote> GetDispatchNote(int TerritoryID);

       [OperationContract]

       [WebInvoke(Method = "POST",
            UriTemplate = "AddOutlet",
            BodyStyle = WebMessageBodyStyle.Wrapped,
            ResponseFormat = WebMessageFormat.Json,
            RequestFormat = WebMessageFormat.Json)]

       bool AddOutlet(string Name, string Address, string Owner, string Phone, string DOB, int OutletType, int Territory, int Region, int Route, int UserID,
           int NoOfEmployees, int Status, int IsKeyOutlet, int OutletNumber, float Longitude, float Latitude);

       [OperationContract]

       [WebInvoke(Method = "POST",
            UriTemplate = "SubmitInvoice",
            BodyStyle = WebMessageBodyStyle.Wrapped,
            ResponseFormat = WebMessageFormat.Json,
            RequestFormat = WebMessageFormat.Json)]

       bool SubmitNewInvoice(int RegionID, string PaymentType, string InvoiceBy, int InvoiceID, int OutletID, string InvoiceDate, int TerritoryID, int RouteID,
           RDSalesInvoiceDetails[] objInvoiceDetails, RDSalesInvoiceDiscounts[] objInvoiceDiscounts, RDSalesInvoiceFreeIssues[] objInvoiceFreeIssues);


    }
}
