using Fsd.Slawek.Cs.Ex4.Data.Entities;
using Fsd.Slawek.Cs.Ex4.Services.Services.Product;
using Fsd.Slawek.Cs.Ex4.Web.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace Fsd.Slawek.Cs.Ex4.Web.Controllers
{
    public class ProductController : Controller
    {
        IProductService _productService;

        public ProductController()
        {
            _productService = new MemoryProductService();
        }

        public ActionResult Index(int page = 1, int items = 4)
        {
            IEnumerable <ProductBase> itemsBase = _productService.GetAllProducts();

            var model = new ProductList
            {
                Max = items,
                Page = page,
                Total = itemsBase.Count(),
                ProductsList = itemsBase.Skip((page -1) *items).Take(items).Select(one =>
                new ProductModel
                {
                    Producer = one.Producer,
                    Model = one.Model,
                    Type = one.Type,
                    ProductionDate = one.ProductionDate,
                    Price = one.Price,
                    Index = itemsBase.ToList().IndexOf(one)
                })
            };
            return View(model);
        }
    }
}