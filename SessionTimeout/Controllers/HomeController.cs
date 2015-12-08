using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SessionTimeout.Controllers
{
    public class HomeController : Controller
    {
        /// <summary>
        /// HTTP-GET
        /// </summary>
        /// <returns>VIEW</returns>
        public ActionResult Index()
        {
            return View();
        }
        /// <summary>
        /// HTTP-POST
        /// </summary>
        /// <returns>LOGOFF - REDIRECT TO LOGIN PAGE</returns>
        public ActionResult LogOff()
        {
            // Code
            // ...
            return RedirectToAction("Login","Home");
        }
        /// <summary>
        /// HTTP-GET
        /// </summary>
        /// <returns>VIEW</returns>
        public ActionResult Login()
        {
            return View();
        }
    }
}