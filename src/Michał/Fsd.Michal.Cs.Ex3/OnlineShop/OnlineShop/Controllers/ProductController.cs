using Data.Models;
using OnlineShop.Models;
using Services.ProductServices;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace OnlineShop.Controllers
{
    public class ProductController : Controller
    {
        private IProductList _productList;

        public ProductController()
        {
            _productList = new ProductList();
        }

        public ActionResult List(int page = 1, int items = 5)
        {
            IEnumerable<Product> listOfProducts = _productList.GetProducts();

            ProductModelList listModel = new ProductModelList
            {
                Max = items,
                Page = page,
                Total = listOfProducts.Count(),

                Products = listOfProducts.Skip((page - 1) * items).Take(items).Select(entity =>
                    new ProductModel
                    {
                        Model = entity.Model,
                        Price = entity.Price,
                        Producer = entity.Producer,
                        ProductionDate = entity.ProductionDate,
                        Type = entity.Type,
                    })
            };
            return View(listModel);
        }

        public ActionResult Index()
        {
            IEnumerable<Product> listOfProducts = _productList.GetProducts();

            var listModel = new ProductModelList
            {
                Total = listOfProducts.Count(),
            };
            return View(listModel);
        }
    }
}