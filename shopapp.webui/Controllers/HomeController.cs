
using System;
using Microsoft.AspNetCore.Mvc;

    //localhost:5000/home
namespace shopapp.webui.Controllers
{
    public class HomeController:Controller
    {
        //localhost:5000/home/index
        public IActionResult Index()
        {
           int hour = DateTime.Now.Hour;

          ViewBag.Greeting = hour>12 ? "İyi Günler" : "Günaydın"; 
          ViewBag.UserName = "Mahir";

            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View("MyView");
        }
    }
}