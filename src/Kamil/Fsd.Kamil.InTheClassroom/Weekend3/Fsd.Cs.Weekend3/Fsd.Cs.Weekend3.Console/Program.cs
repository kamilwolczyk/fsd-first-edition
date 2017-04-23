using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Fsd.Cs.Weekend3.Console
{
    public delegate int Calculator(int a, int b);
    
    class Program
    {
        static void Main(string[] args)
        {
            string selectedOperation = "+";
            int a = 4;
            int b = 5;            
            Calculator operation = SelectOperation(selectedOperation);            
            int result = operation(a, b);

            Person kamil = new Person
            {
                FirstName = "Kamil",
                LastName = "Wolczyk"
            };

            string output = JsonConvert.SerializeObject(kamil);

            //{ "FirstName":"Kamil"}
            //"{\"a\":\"Kamil\"}"

            TestCollections();
            System.Console.ReadKey();
        }

        private static Calculator SelectOperation(string operatorChar)
        {
            switch (operatorChar)
            {
                case "+": return (a, b) => a + b;
                case "*": return (a,b)=> { return a * b; };
            }
            return null;
        }

        private static void TestCollections()
        {
            IEnumerable<string> myList = new List<string>
            {
                "Kamil",
                "Sławek",
                "Michał",
                "Maciek",
                "Jacek",
                "Dawid",
                "Łukasz",
            };
            
            IEnumerable < int > xxx2 = myList
                .Where(item => item.Length > 5)
                .Select(item => item.Length)
                .OrderBy(item => item);

            IDictionary<string, string> people = new Dictionary<string, string>();
            people.Add("1", "Kamil");
            people.Add("2", "Sławek");
            people.Add("3", "Michał");
            people.Add("4", "Maciek");
            people.Add("5", "Jacek");
            people.Add("6", "Dawid");
            people.Add("7", "Łukasz");

            string name = people.ContainsKey("4") ? people["4"] : null;

            int? k = 0;
            bool? b = true;

            System.Console.WriteLine(k.HasValue ? k.Value.ToString() : "brak wartości");
        }
    }
    
    [Author("Kamil Wolczyk")]
    [DataContract]
    class Person
    {
        [Author("Kamil Wolczyk")]
        [DataMember(Name ="a")]
        public string FirstName { get; set; }
        
        public string LastName { get; set; }
    }

    [AttributeUsage(AttributeTargets.All)]
    public class AuthorAttribute : Attribute
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public AuthorAttribute(string fullName)
        {
            string[] names = fullName.Split(' ');
            FirstName = names[0];
            LastName = names[1];
        }
    }
}
