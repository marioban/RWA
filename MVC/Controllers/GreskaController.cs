using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC.Controllers
{
    public class GreskaController : Controller
    {
        // GET: Greska
        public ActionResult HttpError404()
        {
            return View("Http404");
        }

        public ActionResult HttpError500()
        {
            return View("Http500");
        }
    }
}