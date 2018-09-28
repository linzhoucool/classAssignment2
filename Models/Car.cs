using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class Car
    {
        public int id { get; set; }
        public int Cost { get; set; }
        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string color { get; set; }



        public class CheckCarInformation

        {
            public int LOOKUPCARBrand { get; set; }
            public string CarYear { get; set; }
            public string CarDescription { get; set; }
    }










}
}