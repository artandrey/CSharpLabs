using System;
using System.Collections;

namespace Practice5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Дана матриця розміру m *  n. Знайти суми елементів всіх її 1) парних; 2) непарних  строк (стовпчиків). 


            int[,] matrix = {
                { 1,0,1,0 },
                { 1,0,1,0 },
                { 1,0,1,0 }
            };

            int oddSum = 0;
            int evenSum = 0;

            int rows = matrix.GetUpperBound(0) + 1;
            int columns = matrix.Length / rows;

            for (int i = 0; i < columns; i++)
            {
                for (int j = 0; j < rows; j++)
                {
                    if (i%2 == 0)
                    {
                        evenSum += matrix[j, i];
                    }
                    else
                    {
                        oddSum += matrix[j, i];
                    }
                }
            }

            Console.WriteLine("Odd sum {0}", oddSum);
            Console.WriteLine("Even sum {0}", evenSum);


            Console.ReadKey();
        }




    }
}
