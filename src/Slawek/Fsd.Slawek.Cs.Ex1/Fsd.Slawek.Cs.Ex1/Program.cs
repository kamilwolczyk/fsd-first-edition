using System;
using Fsd.Slawek.Cs.Ex1.Models;

namespace Fsd.Slawek.Cs.Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            Presenter presenter = new Presenter();
            presenter.ShowArguments(args);
        }
    }
}
