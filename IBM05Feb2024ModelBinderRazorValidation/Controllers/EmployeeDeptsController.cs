using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using IBM05Feb2024ModelBinderRazorValidation.Models;

namespace IBM05Feb2024ModelBinderRazorValidation.Controllers
{
    public class EmployeeDeptsController : Controller
    {
        private IBM25Jan24DbEntities db = new IBM25Jan24DbEntities();

       public ActionResult Index()
        {
            return View(db.EmployeeDepts.ToList());
        }

        public ActionResult Create()
        {
            return View();
        }

       [HttpPost]
  
        public ActionResult Create([Bind(Include = "EmployeeID,EmpName,Salary,DeptName")] EmployeeDept employeeDept)
        {
            if (ModelState.IsValid)
            {
                db.EmployeeDepts.Add(employeeDept);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(employeeDept);
        }

      
       

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
