using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice10
{
    static class ArrayExtention
    {
        public static T[] Flip<T>(this T[] array)
        {
            T[] reverseArray = new T[array.Length];
            for (int j = 0, i = array.Length - 1; i > -1; i--, j++)
            {
                reverseArray[j] = array[i];
            }
            return reverseArray;
        }

        public static int[] DecreasingSort(this int[] array)
        {
            Array.Sort(array);
            Array.Reverse(array);
            return array;
        }
    }
    internal class Program
    {

        static void printArray<T>(T[] array)
        {
            foreach (T element in array)
            {
                Console.Write(element + " ");
            }

            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            int a = 123;
            Console.WriteLine(a.Flip());

            string b = "oknemetra";
            Console.WriteLine(b.Flip());

            string c = "yerdna, oknemetra";

            Console.WriteLine(c.Flip(','));

            double d = 86.42;

            Console.WriteLine(d.Flip());

            int[] e = { 1, 2, 3, 2, 4 };

            printArray(e.Flip());

            e.DecreasingSort();
            printArray(e);

            Console.ReadKey();

        }
    }
}
