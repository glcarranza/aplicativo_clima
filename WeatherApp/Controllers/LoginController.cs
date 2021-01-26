using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WeatherApp.Models;

namespace WeatherApp.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Login()
        {
            var redirectUrl = new UrlHelper(Request.RequestContext).Action("Index", "Home");
            return Json(new { Url = redirectUrl });
        }
        public ActionResult Index()
        {
            return View();
        }
    }
}