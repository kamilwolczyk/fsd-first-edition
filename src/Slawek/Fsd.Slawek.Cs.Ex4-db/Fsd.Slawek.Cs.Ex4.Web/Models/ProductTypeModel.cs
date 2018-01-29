using Fsd.Slawek.Cs.Ex4.Web.Models.ProductsModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Fsd.Slawek.Cs.Ex4.Web.Models
{
    public class ProductTypeModel
    {
        public dynamic Models;

        public ProductTypeModel getmodel<T>(T model)
        {
            if (model is GraphicCardModel)
            {
                return new ProductTypeModel
                {
                    Models = new GraphicCardModel()
                };
            }
            return new ProductTypeModel();
        }
    }
    
}
