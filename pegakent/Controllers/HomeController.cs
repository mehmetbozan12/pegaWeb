using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace pegakent.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult hakkimizda()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult iletisim()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult devamedenprojeler()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult tamamlananprojeler()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult teklifal()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult grupsirketlerimiz()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult baslanacakprojeler()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}