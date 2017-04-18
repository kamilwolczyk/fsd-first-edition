using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fsd.Cs.Weekend3.Console
{
    public delegate int Calculator(int a, int b);
    
    class Program
    {
        static void Main(string[] args)
        {
            Calculator x = new Calculator(CalculationMethods.Add);

            IList<string> names = new List<string>
            {
                "Kamil",
                "Maciek",
                "Michał",
                "Jacek",
                "Sławek",
                "Dawid",
                "Paweł",
                "Justyna",
                "Łukasz"
            };

            IEnumerable<string> result = from name in names
                                        orderby name
                                        where name.Length > 5
                                        select name.Substring(0,3);

            IEnumerable<string> theSameResult = names
                                                    .Where(name => name.Length > 5)
                                                    .Select(name => name.Substring(0, 3))
                                                    .OrderBy(name => name);
        }
    }

    [AuthorName("Kamil", "k.wolczyk@headchannel.co.uk")]
    public class CalculationMethods
    {
        public static int Add(int a, int b)
        {
            return a + b;
        }
    }

    [AttributeUsage(AttributeTargets.Class)]
    public class AuthorNameAttribute: Attribute
    {
        public string Name { get; set; }

        public string Email { get; set; }

        public AuthorNameAttribute(string name, string email)
        {
            Name = name;
            Email = email;
        }
    }
}
