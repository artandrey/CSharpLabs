using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice10
{
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
            string[] strArray = doubl.ToString().Split(',');
            return flip(strArray[0]) + "," + flip(strArray[1]);

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

        public static void flipArrayWithRef<T>(ref T[] array)
        {
            T[] reverseArray = new T[array.Length];
            for (int j = 0, i = array.Length - 1; i > -1; i--, j++)
            {
                reverseArray[j] = array[i];
            }
            array = reverseArray;
        }
    }
}
