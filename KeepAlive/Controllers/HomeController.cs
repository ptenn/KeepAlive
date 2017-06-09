using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using log4net;
using Microsoft.AspNetCore.Mvc;

namespace KeepAlive.Controllers
{
    public class HomeController : Controller
    {
        private static ILog logger = LogManager.GetLogger(typeof(HomeController));

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }

        public void KeepAlive()
        {
            logger.Info("Execute KeepAlive Method.");
        }
    }
}
