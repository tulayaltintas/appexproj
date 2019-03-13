using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AppexApplication.Controllers
{
    public class ShopController : Controller
    {
        public IActionResult ShopCatalogue()
        {
            return View();
        }

        public IActionResult ShopCatalogueList()
        {
            return View();
        }
        public IActionResult SingleProduct()
        {
            return View();
        }
    }
}