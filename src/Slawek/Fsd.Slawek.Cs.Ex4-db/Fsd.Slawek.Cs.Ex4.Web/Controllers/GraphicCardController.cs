﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Fsd.Slawek.Cs.Ex4.Services.Services.Product;
using Fsd.Slawek.Cs.Ex4.Web.Models;
using Fsd.Slawek.Cs.Ex4.Web.Models.ProductsModels;

namespace Fsd.Slawek.Cs.Ex4.Web.Controllers
{
    public class GraphicCardController : Controller
    {
        IProductService _productService;

        public GraphicCardController(IProductService productService)
        {
            _productService = productService;
        }
        
        // GET: GraphicCard/Create
        public ActionResult Create()
        {
            var model = new GraphicCardModel();
            return View(model);
        }

        // POST: GraphicCard/Create
        [HttpPost]
        public ActionResult Create(GraphicCardModel graphicCardModel)
        {
            try
            {
                if (!ModelState.IsValid)
                    return View();

                _productService.AddProduct(ModelToEntityMaping.MapToEntity(graphicCardModel));
                
                return RedirectToAction("Success","Result", graphicCardModel.Type.ToString());
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
