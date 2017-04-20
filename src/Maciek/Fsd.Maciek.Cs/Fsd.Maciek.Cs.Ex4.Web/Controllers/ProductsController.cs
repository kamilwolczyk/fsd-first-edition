﻿using Fsd.Maciek.Cs.Ex4.Services;
using Fsd.Maciek.Cs.Ex4.Services.Interfaces;
using Fsd.Maciek.Cs.Ex4.Web.Models;
using System.Linq;
using System.Web.Mvc;

namespace Fsd.Maciek.Cs.Ex4.Web.Controllers
{
    public class ProductsController : Controller
    {
        public IProductService ProductService { get; set; }

        public ProductsController()
        {
            ProductService = new MockProductService();
        }

        public ActionResult Index(int page = 1, int items = 20)
        {
            ProductListWebModel ProductModel = new ProductListWebModel()
            {
                Products = ProductService.GetListOfProducts().ToList()
                    .Skip((page - 1) * items).Take(items)
                    .Select(item => new ProductWebModel
                    {
                        Manufacturer = item.Manufacturer,
                        Model = item.Model,
                        Price = item.Price,
                        ProductionYear = item.ProductionYear,
                        ProductType = item.ProductType.ToString()
                    })
            };

            return View(ProductModel);
        }
    }
}
