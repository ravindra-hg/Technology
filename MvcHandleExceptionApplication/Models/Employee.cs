using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcHandleExceptionApplication.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Address HomeAddress { get; set; }
    }

    public class Address
    {
        public string Line1 { get; set; }
        public string Line2 { get; set; }
        public string Pincode { get; set; }
    }
}