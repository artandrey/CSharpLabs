using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice4
{
    class Program {

        //Даний масив розміру N. Вивести спочатку його елементи з парними(непарними) індексами, а потім — з непарними (парними).
        static void Main(string[] args) {
            Console.Write("Enter the length of the array: ");

            int[] arr = new int[int.Parse(Console.ReadLine())];


            for (int i = 0; i < arr.Length; i++) {
                //Console.Write("Enter " + i + " array element = ");
                //arr[i] = int.Parse(Console.ReadLine());
                arr[i] = i;
            }
            
            bool isOdd = Prompt.Question("Output n (othervise n+1)");

            Console.Write("----------------------------\n");
            ArrayOutput.WriteElementsConsideringParity(arr, isOdd: isOdd);
            Console.Write("----------------------------\n");
            ArrayOutput.WriteElementsConsideringParity(arr, isOdd: !isOdd);

            Console.ReadKey(true);
        }
    }

    class ArrayOutput
    {
        public static void WriteElements<T>(T[]array, int step = 1, int start = 0)
        {
            for (int i = start; i < array.Length; i+=step)
			{
                Console.WriteLine(array[i]);
			}
        }
        public static void WriteElementsConsideringParity<T>(T[]array, bool isOdd)
        {
            if (isOdd)
            {
                WriteElements(array, step: 2, start: 1);
            }
            else
            {
                WriteElements(array, step: 2, start: 0);
            }
        }
    }

    class Prompt
    {
        public static bool Question (string question)
        {
            while (true)
            {
                Console.WriteLine("{0}: Y/N", question);
                string userPrompt = Console.ReadLine().ToUpper();
                if (userPrompt == "Y")
                {
                    return true;
                }
                else if (userPrompt == "N")
                {
                    return false;
                }
            }
        }
    }
}
