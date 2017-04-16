using Fsd.Slawek.Cs.Ex4.Data.Entities;
using Fsd.Slawek.Cs.Ex4.Services.Services.Product;
using Fsd.Slawek.Cs.Ex4.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fsd.Slawek.Cs.Ex4.Web.Controllers
{
    public class SingleProductController : Controller
    {
        IProductService _productService;

        public SingleProductController()
        {
            _productService = new MemoryProductService();
        }

        public ActionResult Index(int index = 0)
        {
            var product = new SingleProduct<ProductBase>();

            product = product.GetInfo(_productService.GetAllProducts().ToList()[index]);

            return View(product);
        }
    }
}