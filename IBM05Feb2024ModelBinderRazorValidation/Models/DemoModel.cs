using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IBM05Feb2024ModelBinderRazorValidation.Models
{
    public class Employee
    {
        public int EmpID { get; set; }
        public string EmpName
        { get; set; }

        public double Salary { get; set; }

    }
    public class BookTitle
    {
        public string Title { get; set; }
        public string DateOfPurchase { get; set; }

    }
}