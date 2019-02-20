using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab_7A___ASP.NET_MVC_App_Party_Invite____.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult index()
        {
            int hour = DateTime.Now.Hour;
            ViewBag.Greeting = hour < 12 ? "Good Morning" : "Good Afternoon";
            return View();
        }
        // GET: Home
        //public ActionResult Index()
        //{
        //    return View();
        //}
    }
}