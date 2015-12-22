using MVC5Course.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC5Course.Controllers
{
    public class MBController : Controller
    {
        // GET: MB
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult FormBinding()
        {
            return View();
        }

        public ActionResult MutiBinding()
        {
            return View();
        }

        [HttpPost]
        public ActionResult MutiBinding(Product data1, Product data2)
        {            
            return Json(data2);
        }
    }
}