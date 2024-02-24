using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using shopapp.webui.Models;

//localhost:5000/product
namespace shopapp.webui.Controllers
{
    public class ProductController:Controller
    {
        public IActionResult Index()
        {
            //ViewBag 
            //Model
            //ViewData

            var product = new Product{Name = "Ipone 6", Price = "6000", Description = "Güzel Telefon"};

            // ViewData["Category"] = "Telefon";
            // ViewData["Product"] = product;

            ViewBag.Category = "Telefonlar";
            // ViewBag.Product = product;

            return View(product);
        }

        //localhost:5000/product/list
        public IActionResult List()
        {
            return View();
        }

        //localhost:5000/product/details
        public IActionResult Details(int id)
        {
            // ViewBag.Name = "Samsung S6";
            // ViewBag.Price = 2000;
            // ViewBag.Description = "İyi Telefon";

            var p = new Product();
            p.Name = "Samsung S6";
            p.Price = "2000";
            p.Description = "İyi Telefon";

            return View(p);
        }
    }
}