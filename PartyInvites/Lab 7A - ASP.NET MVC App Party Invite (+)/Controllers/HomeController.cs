using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PartyInvites.Models;

namespace PartyInvites
    {
    public class HomeController : Controller
    {
        public ViewResult index()
        {
            int hour = DateTime.Now.Hour;
            ViewBag.Greeting = hour < 12 ? "Good Morning" : "Good Afternoon";
            return View();
        }
        [HttpGet]
        public ViewResult RsvpForm()
        {
            return View();
        }
        [HttpPost]
        public ViewResult RsvpForm(GuestResponse guestResponse)
        {
            if (ModelState.IsValid)
            {
                //TOD: Email respont to a party organizer
                return View("Thanks!", guestResponse);
            }
            else
            {
                //there is a validation error
                return View();
            }
        }
        // GET: Home
        //public ActionResult Index()
        //{
        //    return View();
        //}
    }
}