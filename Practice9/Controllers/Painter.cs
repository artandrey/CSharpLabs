using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_9
{
    internal class Painter
    {
        public static void Paint(string title, Dictionary<string, double> sizes, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            List<string> dimensions = new List<string>();
            foreach (KeyValuePair<string, double> entry in sizes)
            {
                dimensions.Add($"{entry.Key}: {entry.Value}\n");
            }
            Console.WriteLine("\n\nShape: {0}\nWith dimensions:\n{1}\n\n", title, string.Join("\n", dimensions));
            Console.ResetColor();
        }
    }
}
