using FarmGenerator.Models;
using System;
using System.Collections.Generic;

namespace FarmGenerator.Interfaces
{
    public class GetUserData
    {
        public static void GetInput(List<Animal> animalList)
        {
            CatInput(animalList);
            DogInput(animalList);
            CowInput(animalList);
            SheepInput(animalList);
        }

        private static void DogInput(List<Animal> animalList)
        {
            Console.Write("Insert number of Dogs ");
            try
            {
                int input = int.Parse(Console.ReadLine());

                for (int i = 0; i < input; i++)
                {
                    Console.Write("dog name:");
                    string animal = Console.ReadLine();
                    Dog dog = new Dog(animal);

                    animalList.Add(dog);
                }
            }
            catch (SystemException exception)
            {
                Console.WriteLine("count must be integer value");
            }
        }

        private static void CatInput(List<Animal> animalList)
        {
            Console.Write("Insert number of Cats: ");
            try
            {
                int input = int.Parse(Console.ReadLine());

                for (int i = 0; i < input; i++)
                {
                    Console.Write("cat name:");
                    string animal = Console.ReadLine();
                    Cat cat = new Cat(animal);

                    animalList.Add(cat);
                }
            }
            catch (SystemException exception)
            {
                Console.WriteLine("count must be integer value");
            }
        }

        private static void CowInput(List<Animal> animalList)
        {
            Console.Write("Insert number of cows: ");
            try
            {
                int input = int.Parse(Console.ReadLine());

                for (int i = 0; i < input; i++)
                {
                    Console.Write("cow name:");
                    string animal = Console.ReadLine();

                    Cow cow = new Cow(animal);

                    animalList.Add(cow);
                }
            }
            catch (SystemException exception)
            {
                Console.WriteLine("count must be integer value");
            }
        }

        private static void SheepInput(List<Animal> animalList)
        {
            Console.Write("Insert number of sheeps: ");
            try
            {
                int input = int.Parse(Console.ReadLine());

                for (int i = 0; i < input; i++)
                {
                    Console.Write("sheep name:");
                    string animal = Console.ReadLine();

                    Sheep sheep = new Sheep(animal);

                    animalList.Add(sheep);
                }
            }
            catch (SystemException exception)
            {
                Console.WriteLine("count must be integer value");
            }
        }

        public static void WaitForUser()
        {
            Console.ReadKey();
        }
    }
}
