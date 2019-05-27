using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace davidocTest.Controllers
{
    public class HomeController : Controller
    {
        string repos = "https://api.github.com/search/repositories?q=";
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public JsonResult saveBM(string bm)
        {
            var response = "true";
            Session.Add("Bookmark",bm);
            return Json(response);
        }

    }
}