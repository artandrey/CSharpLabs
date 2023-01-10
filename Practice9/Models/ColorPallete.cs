using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_9
{
    internal class ColorPallete
    {
        static List<ConsoleColor> values = Enum.GetValues(typeof(ConsoleColor)).OfType<ConsoleColor>().ToList();

        public static int Length
        {
            get => values.Count;
        }
        
        static ColorPallete()
        {
            values.Remove(ConsoleColor.Black);
        }

        public static ConsoleColor GetColor(int index)
        {
            return values[index];
        }

    }
}
