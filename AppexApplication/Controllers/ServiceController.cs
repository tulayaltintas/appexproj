using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AppexApplication.Controllers
{
    public class ServiceController : Controller
    {
        public IActionResult Services()
        {
            return View();
        }

        public IActionResult Prices()
        {
            return View();
        }
    }
}