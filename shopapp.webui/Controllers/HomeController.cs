using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

    //localhost:5000/home
namespace shopapp.webui.Controllers
{
    public class HomeController:Controller
    {
        //localhost:5000/home/index
        public string Index()
        {
            return "home/index";
        }

        public string About()
        {
            return "home/about";
        }
    }
}