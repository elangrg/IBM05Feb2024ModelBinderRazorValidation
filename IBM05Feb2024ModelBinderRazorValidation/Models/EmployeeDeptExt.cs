using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace IBM05Feb2024ModelBinderRazorValidation.Models
{
    public  class EmployeeDeptValid
    {
      
        [Required]
        public string EmpName { get; set; }
        [Range(10000,100000)]
        public decimal Salary { get; set; }
        [Required]
        public string DeptName { get; set; }
    }

    [MetadataType(typeof(EmployeeDeptValid))]
    public partial class EmployeeDept
    {
     
    }
}