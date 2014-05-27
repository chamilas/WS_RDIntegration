using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace wsRDIntegration.RDSales_REF
{
    public class RDSalesInvoiceFreeIssues
    {
        [DataMember]
        public int Qty;
        [DataMember]
        public string Group;
        [DataMember]
        public string F1_Code;
        [DataMember]
        public string DiscountCode;
    }
}
