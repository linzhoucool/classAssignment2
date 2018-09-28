using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;


namespace WebApplication2.Models
{
    public class Person
    {




        public int id { get; set; }
        public int UserID { get; set; }
        public int LOOKRoleID { get; set; }
        public string RoleName { get; set; }
        public bool? IsRoleActive { get; set; }
       
        public string LoginName { get; set; }
       
        public string Password { get; set; }
       
        public string FirstName { get; set; }
       
        public string LastName { get; set; }
        public string Gender { get; set; }
    }

}