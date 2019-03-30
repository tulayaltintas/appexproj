using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AppexApplication.CodeLayer.Entity;
using AppexApplication.Models;
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
            SingleProductModel spm = new SingleProductModel();
            using (var context = new AppexContext())
            {
                var query = context.Products
                                   .Where(s => s.Id == 1)
                                   .FirstOrDefault<Product>();

                spm.Name = query.Name;
            }


            int result = Deneme(Enums.Deneme.Efus);


            return View(spm);
        }

        public int Deneme(Enums.Deneme ddd)
        {
            if (ddd == Enums.Deneme.Tulis)
            {
                return 1;
            }
            else
            {
                return 2;
            }
        } 

    }
}