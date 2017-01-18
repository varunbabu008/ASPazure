using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyEmployees.Web.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public String FullName { get; set; }
        public String Department { get; set; }
    }
}