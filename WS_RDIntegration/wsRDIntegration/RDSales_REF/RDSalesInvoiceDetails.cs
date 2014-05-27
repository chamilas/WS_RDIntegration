using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace wsRDIntegration
{
   public class RDSalesInvoiceDetails
    {

       [DataMember]
       public string ProductCode;
       [DataMember]
       public int Qty;
       [DataMember]
       public decimal SellingPrice;
       [DataMember]
       public int ReturnQty;
       [DataMember]
       public decimal ReturnPrice;
       [DataMember]
       public int DamageQty;
       [DataMember]
       public decimal DamagePrice;
           

    }
}
