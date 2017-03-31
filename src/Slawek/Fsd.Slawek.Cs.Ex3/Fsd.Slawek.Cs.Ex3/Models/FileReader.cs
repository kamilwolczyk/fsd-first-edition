using System;
using System.Collections.Generic;
using System.IO;

namespace Fsd.Slawek.Cs.Ex3.Models
{
    public class FileReader
    {
        string Path = "../../Data\\data.txt";
        
        public IEnumerable<ProductInfo> ReadData()
        {
            IList<ProductInfo> data = new List<ProductInfo>();
            StreamReader file = new StreamReader(Path);

            while(!file.EndOfStream)
            {
                var line = file.ReadLine();
                string[] split = line.Split(new[] { " \t" }, StringSplitOptions.None);
                data.Add(new ProductInfo(new Product(split[0], decimal.Parse(split[1])), int.Parse(split[2])));
            }
            file.Close();

            return data;
        }

        public IEnumerable<ProductInfo> WriteData(List<ProductInfo> products)
        {
            IList<ProductInfo> data = new List<ProductInfo>();
            StreamWriter file = new StreamWriter(Path);

            products.ForEach(d => file.WriteLine($"{d.Item.Name} \t {d.Item.Price} \t {d.Count}"));
            file.Close();

            return data;
        }

        public bool FileCheck()
        {
            FileInfo fileExist = new FileInfo(Path);
            bool exist = fileExist.Exists;
            if (!exist) File.Create(Path);
            StreamReader file = new StreamReader(Path);
            string line = null;
            line = file.ReadLine();
            file.Close();

            return line != null;
        }
    }
}
