using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Picture picture = new Picture(3);

            Triangle triangle = new Triangle("Triangle");
            Square square = new Square("Square");
            Circle circle = new Circle("Victor");

            picture.AddNewShape(triangle);
            picture.AddNewShape(square);
            picture.AddNewShape(circle);

            picture.Draw();

            Console.WriteLine("Removing Victor because he is a theacher, not a shape\nPress enter to see reult");
            Console.ReadKey();

            picture.RemoveShape("Victor");

            picture.Draw();

            Console.WriteLine("Adding circle with name Circle\nPress enter to see reult");
            Console.ReadKey();

            picture.AddNewShape(new Circle("Circle", 20));
            picture.Draw();

            Console.ReadKey();


        }
    }
}
