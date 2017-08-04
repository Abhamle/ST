using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ORA.Controllers
{
    public class CuisineController : Controller
    {
        // GET: Cuisine
        //[Authorize]
        public ActionResult Search(String name)
        {
            throw new Exception("Something Terrible has happend!");
            string message = Server.HtmlEncode(name);
            return Json(new { Message = message, Name = "Abel" }, JsonRequestBehavior.AllowGet);
        }
    }
}