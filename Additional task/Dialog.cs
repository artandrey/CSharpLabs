using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Additional_task
{
    internal class Dialog
    {
        public static string AskQuestion(string querstion)
        {
            Console.WriteLine(querstion);
            return Console.ReadLine();
        }

        public static ConsoleColor AskColor(string[] colorsVariants)
        {
            while(true)
            {
                string colorLiteral = AskQuestion($"Pick a color\n{String.Join(", ", colorsVariants)}");
                try
                {
                    ConsoleColor colorValue = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), colorLiteral);
                    return colorValue;
                }
                catch
                {
                    Console.WriteLine("Color was not found");
                }
            }
        }
        public static int AskYear()
        {
            while(true)
            {
                return int.Parse(AskQuestion("Enter a year of creation"));
            }
        }

        public static float AskPrice()
        {
            while(true)
            {
                return float.Parse(AskQuestion("Enter price"));
            }
        }

        public static int AskCamerasCount()
        {
            while(true)
            {
                return int.Parse(AskQuestion("Enter cameras count"));
            }
        }

    }
}
