using System;
using System.Collections.Generic;


namespace Practice7
{
    class Program {
        static void Main(string[] args) {

            //Створити ліст трінгових змінних, дозволити можливість заповнення з калвіатури. Вивести індекси змінних рівних перевірочній(теж ввести з клавіатури). Скопіювати ліст в масив.

            List<string> list = UserInput.getUserInputInfinite("Enter some words", "STOP");

            string searchInput = UserInput.getUserInputOnce("Enter search string");

            for (int i = 0; i < list.Count; i++)
			{
                if (list[i].Equals(searchInput))
                {
                    Console.WriteLine("Matchind on index: {0}", i);
                }
			}
            
            string[] reslutingArray = list.ToArray();


            Console.WriteLine("Output array:");
            ArrayOutput.WriteElements(reslutingArray);

           
            Console.ReadKey();
        }
    }
    class UserInput
    {
        public static List<string> getUserInputInfinite(string question, string endWord)
        {

            List<string> list = new List<string>();

            while (true) {
                Console.WriteLine("{0}, enter {1} to continue", question, endWord);
                string input = Console.ReadLine();

                if (input.ToLower() == endWord.ToLower()) {
                    break;
                }

                list.Add(input);
            }
            return list;
        }
        public static string getUserInputOnce(string question)
        {
            Console.WriteLine(question);
            return Console.ReadLine();
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
}
