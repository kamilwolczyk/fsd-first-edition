using Fsd.Slawek.Cs.Ex3.Models;
using Fsd.Slawek.Cs.Ex3.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fsd.Slawek.Cs.Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            DatabaseFile data = new DatabaseFile();
            Presenter presenter = new Presenter(data);
            presenter.ShowMenu();
        }
    }
}
