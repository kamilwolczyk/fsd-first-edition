using Fsd.Lukasz.Cs3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fsd.Lukasz.Cs3
{
    class FakeData
    {
        private List<IProduct> _products;

        public FakeData()
        {
            _products = new List<IProduct>();

            _products.Add(new Product() { Name = "LG G4", Quantity = 3, Price = 112.44M });
            _products.Add(new Product() { Name = "Lenovo Yoga", Quantity = 1, Price = 1111.00M });
            _products.Add(new Product() { Name = "Asus Zenfone 5", Quantity = 5, Price = 499M });
            _products.Add(new Product() { Name = "LG G3", Quantity = 1, Price = 1.44M });
            _products.Add(new Product() { Name = "Lenovo Yoga2", Quantity = 0, Price = 111.20M });
            _products.Add(new Product() { Name = "Samsung Edge", Quantity = 11, Price = 125.23M });
        }

        public List<IProduct> GetData()
        {
            return _products;
        }

        //public List<string> GetDictionary()
        //{

        //    List<string> Dictionary = new List<string>();
        //    Dictionary = _products.Select(product => product.Name).ToList();
        //    return Dictionary;
        //}


    }
}
