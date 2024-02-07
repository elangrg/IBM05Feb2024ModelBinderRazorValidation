using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace IBM05Feb2024ModelBinderRazorValidation.Models
{
    public class Employee
    {
        [Display(Name ="Employee ID")]
        public int EmpID { get; set; }


        [Display(Name = "Full Name")]
       // [DataType(DataType.MultilineText)]
        [Required]
        public string EmpName
        { get; set; }
        [Display(Name = "Net Salary")]

        [Range(10000,1000000)]
        public double Salary { get; set; }

    }
    public class BookTitle
    {
        public string Title { get; set; }
        public string DateOfPurchase { get; set; }

    }
}