using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace pegakent.Controllers
{
    public class devamedenprojelerController : Controller
    {
        // GET: devamedenprojeler
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult pegalifekonutlari()
        {
            return View();
        }

        public ActionResult pegapremiumkonutlari()
        {
            return View();
        }

        public ActionResult pegaloftkonutlari()
        {
            return View();
        }
    }
}