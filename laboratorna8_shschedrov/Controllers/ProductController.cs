using Microsoft.AspNetCore.Mvc;
using laboratorna8_shschedrov.Models;
using System;
using System.Collections.Generic;

namespace laboratorna8_shschedrov.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            var products = new List<Product>
            {
                new Product { ID = 1, Name = "Laptop", Price = 999.99m, CreatedDate = DateTime.Now.AddDays(-10) },
                new Product { ID = 2, Name = "Phone", Price = 499.99m, CreatedDate = DateTime.Now.AddDays(-20) },
                new Product { ID = 3, Name = "Tablet", Price = 299.99m, CreatedDate = DateTime.Now.AddDays(-30) }
            };

            return View(products);
        }
    }
}
