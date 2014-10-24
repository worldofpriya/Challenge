using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ShoeSwap.Models;

namespace ShoeSwap.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View("ShoeSwap");
        }

        [HttpGet]
        public ActionResult ShoeSwap()
        {
            return View();
        }

        [HttpPost]
        public ActionResult ShoeSwap(ShoeSwapInfo ss)
        {
            var info = ss;
            return View();
        }
    }
}
