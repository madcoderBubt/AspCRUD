using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ASPMVCRUD.Models;

namespace ASPMVCRUD.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee/GetData
        public ActionResult GetData()
        {
            using (Models.DBModel db = new Models.DBModel())
            {
                List<Employee> emp = db.Employees.ToList<Employee>();
                return Json(new { data = emp },JsonRequestBehavior.AllowGet);
            }            
        }

        //GET: Employee/_AddOrEdit/id
        public ActionResult _AddOrEdit(int id = 0)
        {
            if (id == 0)
            {
                return View(new Employee());
            }else
            {
                using (DBModel db = new DBModel())
                {
                    var emp = db.Employees.Where<Employee>(m => m.EmployeeID == id).FirstOrDefault();
                    //return Json(new { data = emp }, JsonRequestBehavior.AllowGet);
                    return View(emp);
                }
            }
            
            //return View();
        }

        [HttpPost]
        public ActionResult _AddOrEdit(Employee emp)
        {
            using (DBModel db = new DBModel())
            {
                if (emp.EmployeeID == 0)
                {
                    db.Employees.Add(emp);
                    db.SaveChanges();
                    return Json(new { success = true, message = "Saved Successfully" }, JsonRequestBehavior.AllowGet );
                }
                else
                {
                    db.Entry(emp).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                    return Json(new { success = true, message = "Updated Successfully" }, JsonRequestBehavior.AllowGet );
                }                
            }
        }

        public ActionResult Delete(int id)
        {
            //return View();

            using (DBModel db = new DBModel())
            {
                db.Employees.Remove(db.Employees.Where<Employee>(m => m.EmployeeID == id).FirstOrDefault());
                db.SaveChanges();
                return Json(new { success = true, message = "Deleted Successfully" }, JsonRequestBehavior.AllowGet );
            }
        }
    }
}