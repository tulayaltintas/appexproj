using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AppexApplication.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult BlogStyle1()
        {
            return View();
        }
        public IActionResult BlogStyle1Full()
        {
            return View();
        }
        public IActionResult BlogStyle2()
        {
            return View();
        }
        public IActionResult BlogStyle2Full()
        {
            return View();
        }


    }
}