using System;
using Microsoft.AspNetCore.Mvc;

namespace CourseApp.Controllers
{
    public class HomeController:Controller
    {
        //localhost:5000/home/index

        public IActionResult Index(){
            int clock = DateTime.Now.Hour;

            ViewBag.Greeting = clock > 12 ? "Good Morning": "Good Night"; //if clock > 12 morning else good night
            ViewBag.UserName = "User";
            return View();  //html page return

        }
        //localhost:5000/home/index

         public IActionResult About(){
            return View();
        }
    }
}