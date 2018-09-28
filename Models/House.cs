using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class House
    {
        public int id { get; set; }
        public int Value { get; set; }
        public int LotSize { get; set; }
        public string Address { get; set; }
        public String City { get; set; }
        public string State { get; set;}
        public string PostalCode { get; set; }

        public class CheckHouseInformation

        {
            public int LOOKUPHouseBrand { get; set; }
            public string HouseYear { get; set; }
            public string  HouseAdress{ get; set; }
        }

        
    }
}