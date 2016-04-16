using Cart.Models;
using Cart.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Cart.Controllers
{
    [RoutePrefix("")]
    public class HomeController : Controller
    {
        [Route("")]
        public ActionResult Index()
        {
            return RedirectToAction("ProductList");
        }

        [Route("products/{page:int=1}/{count:int=9}")]
        public ActionResult ProductList(int page, int count)
        {
            var products = new List<Product>();
            for (int i = 0; i < 100; i++)
            {
                products.Add(new Product()
                {
                    ProductId = Guid.NewGuid(),
                    Name = "Product " + i,
                    Description = "A description for product " + i,
                    Price = 1M + (i * 1.3M)
                });
            }

            var viewModel = new ProductListViewModel();
            viewModel.Products = products.Skip((page - 1) * count).Take(count);

            return View(viewModel);
        }





        [HttpPost, Route("products/{page:int=1}/{count:int=9}")]
        public ActionResult ProductList(ProductListViewModel viewModel)
        {
            var quantity = Request["Quantity"];
            var x = Request["FeaturedProduct.Name"];

            return View();
        }
    }
}