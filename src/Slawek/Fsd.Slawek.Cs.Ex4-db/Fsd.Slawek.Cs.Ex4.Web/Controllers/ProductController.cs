using Fsd.Slawek.Cs.Ex4.Data.Entities;
using Fsd.Slawek.Cs.Ex4.Data.Enums;
using Fsd.Slawek.Cs.Ex4.Services.Services.Product;
using Fsd.Slawek.Cs.Ex4.Web.Models;
using Fsd.Slawek.Cs.Ex4.Web.Models.ProductsModels;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace Fsd.Slawek.Cs.Ex4.Web.Controllers
{
    public class ProductController : Controller
    {
        IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
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
                    Id = one.Id,
                    Producer = one.Producer,
                    Model = one.Model,
                    Type = one.Type,
                    ProductionDate = one.ProductionDate,
                    Price = one.Price
                })
            };
            return View(model);
        }

        [HttpGet]
        public ActionResult Create()
        {
            var model = new SoundCardModel();
            return View("~/Views/Product/TypeForms/TypesPartialViews/_SoundCardType.cshtml",model);
        }

        [HttpPost]
        public ActionResult Create(SoundCardModel mod)
        {
            
            if (!ModelState.IsValid)
                return View(mod);

            _productService.AddProduct(ModelToEntityMaping.MapToEntity(mod));

            return RedirectToAction("SaveSuccess");
        }

        [HttpGet]
        public string SaveSuccess()
        {
            return "Success";
        }


        private ProductModel GetNewModelByType(ProductType type)
        {
            switch (type)
            {
                case ProductType.GraphicCard: return new GraphicCardModel();
                case ProductType.Monitor: return new MonitorModel();
                case ProductType.Processor: return new ProcessorModel();
                case ProductType.Motherboard: return new MotherboardModel();
                case ProductType.SoundCard: return new SoundCardModel();
            }

            return null;
        }
    }
}