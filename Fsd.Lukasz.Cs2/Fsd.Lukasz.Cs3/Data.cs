using Fsd.Lukasz.Cs3.Models;
using System.Collections.Generic;
using System.Linq;

namespace Fsd.Lukasz.Cs3
{
    public class Data
    {
        public List<IProduct> products { get; set; }
        private static Data instance;
  
        public List<string> GetDictionary()
        {
            List<string> dictionary = new List<string>();
            dictionary = products.Select(product => product.Name).ToList();
            return dictionary;
        }


        public static Data Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Data();
                }
                return instance;
            }
        }


    }
}
