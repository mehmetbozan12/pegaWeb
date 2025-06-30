using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace pegakent.Controllers
{
    public class ProjelerController : Controller
    {
        // GET: devamedenprojeler
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult PegalifeKonutlari()
        {
            return View();
        }

        public ActionResult PegapremiumKonutlari()
        {
            return View();
        }

        public ActionResult PegaloftKonutlari()
        {
            return View();
        }
    }
}