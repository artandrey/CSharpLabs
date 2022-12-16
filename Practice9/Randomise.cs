using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_9
{
    internal class Randomise
    {
        static Random random = new Random();
        public static double GetRandomInRange(double min, double max)
        {
            return random.NextDouble() * (max - min) + min;
        }
        public static ConsoleColor GetRandomColor()
        {
            ConsoleColor randomColor = ColorPallete.GetColor((random.Next(ColorPallete.Length)));
            return randomColor;
        }

        public static double GetRandomSideSize()
        {
            return GetRandomInRange(1, 10);
        }

    }

}
