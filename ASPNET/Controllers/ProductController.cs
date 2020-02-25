using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASPNET.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASPNET.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductRepo repo;

        public ProductController(IProductRepo repo)
        {
            this.repo = repo;
        }

        public IActionResult ViewProduct(int id)
        {
            var product = repo.GetProduct(id);

            return View(product);
        }


        public IActionResult Index()
        {
            var products = repo.GetAllProdcuts();

            return View(products);
        }

        public IActionResult UpdateProduct(int id)
        {
            Product prod = repo.GetProduct(id);

            repo.UpdateProduct(prod);

            if (prod == null)
            {
                return View("ProductNotFound");
            }

            return View(prod);
        }

        public IActionResult UpdateProductToDatabase(Product product)
        {
            repo.UpdateProduct(product);

            return RedirectToAction("ViewProduct", new { id = product.productID });
        }


    }
}