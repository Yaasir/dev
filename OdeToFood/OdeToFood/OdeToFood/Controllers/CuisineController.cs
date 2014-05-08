using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OdeToFood.Infrastructure;

namespace OdeToFood.Controllers
{
    //[Authorize]
    [Log] //no need to use, already add filter LogAttribute in Global.asax
    public class CuisineController : Controller
    {
        //
        // GET: /Cuisine/
        
        public ActionResult Search(string name = "*")
        {
            //throw new Exception("oops!");
            //if (name == "*")
            //{
            //    return Json(new { cuisineName = name }, JsonRequestBehavior.AllowGet);
            //    //return File(Server.MapPath("~/Content/Site.css"), "text/css");
            //    //return RedirectToRoute("Cuisine", new { name = "German" });
            //    //return RedirectToAction("Search", "Cuisine", new { name = "french" });
            //}

            name = Server.HtmlEncode(name);

            //return RedirectToAction("Index", "Home");
            return Content(name);
        }

    }
}
