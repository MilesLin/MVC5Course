using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC5Course.Controllers
{
    public class ARController : BaseController
    {
        // GET: AR
        public ActionResult Index()
        {                        
            return View();
        }

        public ActionResult ImageIndex()
        {
            var fileName = Server.MapPath("~/Content/葉子.jpg");
            return File(fileName,"image/jpeg","下載葉子.jpg");
        }
    }
}