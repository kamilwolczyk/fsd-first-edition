using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Fsd.Slawek.Cs.Ex4.Services.Services.Product;
using Fsd.Slawek.Cs.Ex4.Web.Models;
using Fsd.Slawek.Cs.Ex4.Web.Models.ProductsModels;

namespace Fsd.Slawek.Cs.Ex4.Web.Controllers
{
    public class ProcessorController : Controller
    {
        IProductService _productService;

        public ProcessorController(IProductService productService)
        {
            _productService = productService;
        }

        // GET: Processor/Create
        public ActionResult Create()
        {
            var model = new ProcessorModel();
            return View(model);
        }

        // POST: Processor/Create
        [HttpPost]
        public ActionResult Create(ProcessorModel processorModel)
        {
            try
            {
                if (!ModelState.IsValid)
                    return View();

                _productService.AddProduct(ModelToEntityMaping.MapToEntity(processorModel));
                
                return RedirectToAction("Success","Result", processorModel.Type.ToString());
            }
            catch
            {
                return RedirectToAction("Error","Result");
            }
        }

        // GET: GraphicCard/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: GraphicCard/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: GraphicCard/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: GraphicCard/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
