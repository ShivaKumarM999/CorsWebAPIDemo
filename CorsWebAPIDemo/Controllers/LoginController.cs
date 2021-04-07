using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CorsWebAPIDemo.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult AddLogin()
        {
            return View();
        }
        public ActionResult DeleteLogin()
        {
            return View();
        }

        public ActionResult UpdateLogin()
        {
            return View();
        }
        public ActionResult GetLoginById()
        {
            return View();
        }
    }
}