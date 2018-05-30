using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASPMVCRUD.Controllers
{
    public class DefaultController : Controller
    {
        
        // GET: Default
        public ActionResult Index()
        {
            ViewBag.Title = "CRUD Operation";
            return View();
        }
    }
}