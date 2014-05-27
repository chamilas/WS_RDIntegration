using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace wsRDIntegration.RDSales_REF
{
    class Outlet
    {
        [DataMember]
        public string Name;

        [DataMember]
        public string Address;

        [DataMember]
        public string Owner;

        [DataMember]
        public string Phone;

        [DataMember]
        public string DOB;

        [DataMember]
        public int OutletType;

        [DataMember]
        public int Territory;

        [DataMember]
        public int RegionID;

        [DataMember]
        public int Route;

        [DataMember]
        public int UserID;

        [DataMember]
        public int NoOfEmployees;

        [DataMember]
        public int Status;

        [DataMember]
        public int IsKeyOutlet;

        [DataMember]
        public int OutletNumber;

        [DataMember]
        public float Longitude;

        [DataMember]
        public float Latitude;

        public Outlet(string _Name, string _Address, string _Owner, string _Phone, string _DOB, int _OutletType, int _Territory, int _RegionID, int _Route, int _UserID, int _NoOfEmployees, int _Status, int _IsKeyOutlet, int _OutletNumber, float _Longitude, float _Latitude)
        {
            this.Name=_Name;
            this.Address=_Address;
            this.Owner=_Owner;
            this.Phone=_Phone;
            this.DOB=_DOB;
            this.OutletType=_OutletType;
            this.Territory=_Territory;
            this.RegionID=_RegionID;
            this.Route=_Route;
            this.UserID=_UserID;
            this.NoOfEmployees=_NoOfEmployees;
            this.Status = _Status;
            this.IsKeyOutlet = _IsKeyOutlet;
            this.OutletNumber = _OutletNumber;
            this.Longitude = _Longitude;
            this.Latitude = _Latitude;
        }
    }
}
