using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AppexApplication.Controllers
{
    public class PagesController : Controller
    {
        public IActionResult ComingSoon()
        {
            return View();
        }

        public IActionResult HowItWorks()
        {
            return View();
        }

        public IActionResult PageElements()
        {
            return View();
        }

        public IActionResult Page404()
        {
            return View();
        }
        

    }
}