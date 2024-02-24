using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

    //localhost:5000/product
namespace shopapp.webui.Controllers
{
    public class ProductController:Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        //localhost:5000/product/list
        public IActionResult List()
        {
            return View();
        }

        //localhost:5000/product/details
        public IActionResult Details(int id)
        {
            return View();
        }
    }
}