using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;

namespace Fsd.Slawek.Cs.Ex4.Web.Models
{
    public class SingleProduct<TProduct>
    {
        public IDictionary<string, string> Properties { get; set; }

        public SingleProduct<TProduct> GetInfo(TProduct product)
        {
            var type = product.GetType();

            List<PropertyInfo> props = type.GetProperties().ToList();

            Dictionary<string, string> spr = new Dictionary<string, string>();

            props.ForEach(p => spr.Add(p.Name, InfoValidator(p.Name, p.GetValue(product).ToString())));

            return new SingleProduct<TProduct>
            {
                Properties = spr
            };
        }

        private string InfoValidator(string name, string value)
        {
            switch (name)
            {
                case "Price":
                    return $"{value} zł";
                case "ProductionDate":
                    return Convert.ToDateTime(value).ToShortDateString();
            }
            return value;
        }
    }
}