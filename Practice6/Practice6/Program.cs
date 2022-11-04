using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Написати програму, що виконує наступні функції (ВИКОНАТИ ВСІ 8 (ВІСІМ) ПУНКТІВ):

            //Виводить на екран введене число з клавіатури в зворотному порядку (1234->4321)
            //Виводить будь-яку строку в зворотному порядку (АБВ->ВБА)
            //Дробові числа виводяться в зворотному порядку і ціла частина і дробова (123.456->321.654)
            //Виводити будь-яку строку в зворотному порядку і всі елементи після “магічного знаку” теж в зворотному (АБВ,ГДЕ->ВБА,ЕДГ)
            //Реалізувати пункти 1-4 за допомогою методів, перевантаживши методи для різних типів
            //Реалізувати пункти 1-4 за допомогою рекурсії, методи для різних типів перевантажити
            //Реалізувати метод, що буде масив повертати задом навпаки (Використання Arrayay.Reverse() заборонено!)
            //Виконати пункт 7 з використанням ключових слів ref i out

            string[] strArray = new string[] { "fsd", "s2df", "dddsf };

            Console.WriteLine(Reverser.flip(1234) + "\n" +
                              Reverser.flip("АБВ") + "\n" +
                              Reverser.flip(123.456) + "\n" +
                              Reverser.flip("АБВ,ГДЕ", ',') + "\n" 
                              );

            printArray(strArray);
            Reverser.flipArrayWithRef(ref strArray);
            printArray(strArray);

            int[] array  = new int [4]{1,2,3,4};
            Console.WriteLine(array.Length);
            ArrayayModifier.ChangeSizeOfArray(out array, 1);
            Console.WriteLine(array.Length);

            Console.ReadKey();
        }



        static void printArray<T>(T[] array)
        {
            foreach(T element in  array)
            {
                Console.Write(element + " ");
            }

            Console.WriteLine();
        }
    }

    class Reverser
    {
        public static string flip(int integer)
        {
            string result = "";
            while (integer != 0)
            {
                result += integer % 10;
                integer /= 10;
            }

            return result;
        }

        public static string flip(string str)
        {
            string result = "";
            for (int i = str.Length - 1; i > -1; i--)
            {
               result += str[i];
            }

            return result;
        }

        public static string flip(double doubl)
        {
            string [] strArray = doubl.ToString().Split(',');
            return flip(strArray[0]) + "." + flip(strArray[1]);
            
        }

        public static string flip(string str, char magicSymbol)
        {
            string[] strArray = str.Split(magicSymbol);
            string result = "";
            foreach (string i in strArray)
            {
                result += flip(i) + magicSymbol;
            }

            return result.Substring(0, result.Length - 1);
        }

        public static void flipArrayWithRef<T>(ref T [] array ) {
            T[] reverseArray = new T [array.Length];
            for (int j = 0, i = array.Length -1 ; i > -1 ; i--, j++) {
                reverseArray[j] = array[i];
            }
            array = reverseArray;
        }
    }

    class ArrayayModifier
    {
        public static void ChangeSizeOfArray(out int [] array, int newSize)
        {
            array = new int [newSize];
            for (int i = 0; i < newSize; i++)
            {
                array[i] = 0;
            }
        }
    }

}
