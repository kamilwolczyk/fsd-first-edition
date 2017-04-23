using Fsd.Kamil.Cs.Ex4.Data.Entities;
using Fsd.Kamil.Cs.Ex4.Services.Products;
using Fsd.Kamil.Cs.Ex4.Web.Models.Pageable;
using Fsd.Kamil.Cs.Ex4.Web.Models.Products;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace Fsd.Kamil.Cs.Ex4.Web.Controllers
{
    public class ProductController : Controller
    {
        private IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public ActionResult List(int? page, int? items)
        {
            int take = items ?? 10;
            int skip = page.HasValue ? (page.Value - 1) * take : 0;

            IEnumerable<ProductBase> entities = _productService
                .GetAllProducts()
                .OrderByDescending(product => product.ProductionDate);

            DataPart<ProductModel> model = DataPart<ProductModel>.GetPartFromEntities(entities, skip, take,
                entity => new ProductModel
                {
                    Producer = entity.Producer,
                    Model = entity.Model,
                    Type = entity.Type,
                    Price = entity.Price,
                    ProductionDate = entity.ProductionDate,
                });

            return View(model);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View(new ProductModel());
        }

        [HttpPost]
        public ActionResult Create(ProductModel product)
        {
            return View(product);
        }

        [HttpGet]
        public ActionResult Edit()
        {
            return View(new ProductModel());
        }

        [HttpPost]
        public ActionResult Edit(ProductModel product)
        {
            return View(product);
        }
    }
}