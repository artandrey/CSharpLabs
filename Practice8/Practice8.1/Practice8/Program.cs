using Practice8.controllers;
using Practice8.models;
using System;
using System.Collections.Generic;


namespace Practice8
{
    class Program
    {
        static void Main(string[] args)
        {

            Garage garage = new Garage();

            Car uselessCar = new Car("C# car", "#000", 0, 1998);

            garage.AddCar(uselessCar);
            garage.AddCar(new Car("Ferrari", "#ffffff", 220, 2018));
            garage.AddCar(new Car("Audi", "#222", 420, 2010));
            garage.AddCar(new Car("BMW", "#ff00ff", 230, 2000));
            garage.AddCar(new Car("Ford", "#444", 300, 2016));
            garage.AddCar(new Car("Ford", "#0022ff", 300, 2012));
            garage.AddCar(new Car("BMW", "#daffad", 200, 1992));
            garage.AddCar(new Car("Ferrari", "#fff", 380, 2021));


            HashSet<Car> serachResult = garage.SearchCars(new Car("Ferrari", "#ffffff", 200, 2018));

            garage.DeleteCar(uselessCar);


            Output.PrintList(serachResult);







            Console.ReadKey();
        }

    }
    class Output
    {
        public static void PrintList<T>(List<T> list)
        {
            foreach (T el in list)
            {
                Console.WriteLine(el);
            }

            Console.WriteLine("+++++++++++++++++++++");
        }

        public static void PrintList<T>(HashSet<T> list)
        {
            foreach (T el in list)
            {
                Console.WriteLine(el);
            }

            Console.WriteLine("+++++++++++++++++++++");
        }
    }

}
