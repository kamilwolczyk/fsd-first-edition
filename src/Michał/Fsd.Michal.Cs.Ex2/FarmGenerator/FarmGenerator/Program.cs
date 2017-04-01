using FarmGenerator.Interfaces;
using FarmGenerator.Models;
using System.Collections.Generic;

namespace FarmGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            ShowData.ShowIntroduction();
            List<Animal> animalList = new List<Animal>();
            GetUserData.GetInput(animalList);
            ShowData.ShowAnimals(animalList);
            GetUserData.WaitForUser();
        }
    }
}
