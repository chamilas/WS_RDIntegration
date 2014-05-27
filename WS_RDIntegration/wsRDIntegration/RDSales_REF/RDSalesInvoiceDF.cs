using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace wsRDIntegration
{
   public class RDSalesInvoiceDF
    {

        [DataMember]
        public string DiscountCode;
        [DataMember]
        public decimal Discount;
        [DataMember]
        public string F1_Code;
        [DataMember]
        public int F1_Qty;
        [DataMember]
        public string F2_Code;
        [DataMember]
        public int F2_Qty;
        [DataMember]
        public string F3_Code;
        [DataMember]
        public int F3_Qty;

    }
}
