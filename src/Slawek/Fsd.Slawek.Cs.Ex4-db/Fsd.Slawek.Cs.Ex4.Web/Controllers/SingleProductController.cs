using Fsd.Slawek.Cs.Ex4.Data.Entities;
using Fsd.Slawek.Cs.Ex4.Data.Enums;
using Fsd.Slawek.Cs.Ex4.Services.Services.Product;
using Fsd.Slawek.Cs.Ex4.Web.Models;
using System.Web.Mvc;

namespace Fsd.Slawek.Cs.Ex4.Web.Controllers
{
    public class SingleProductController : Controller
    {
        IProductService _productService;

        public SingleProductController(IProductService productService)
        {
            _productService = productService;
        }

        public ActionResult Index(int id, ProductType type = ProductType.GraphicCard)
        {
            var product = new SingleProduct<ProductBase>();

            product = product.GetInfo(_productService.GetProduct(id,type));

            return View(product);
        }

        //[HttpGet]
        //public ActionResult Edit(int id, ProductType type = ProductType.GraphicCard)
        //{
        //    var product = new SingleProduct<ProductBase>();

        //    product = product.GetInfo(_productService.GetProduct(id, type));

        //    return View(product);
        //}

        //[HttpPost]
        //public ActionResult Edit(ProductModel model)
        //{
        //    var x = model;
        //    if (!ModelState.IsValid)
        //        return View(model);

        //    //todo: save in the db

        //    return RedirectToAction("SaveSuccess");
        //}
    }
}