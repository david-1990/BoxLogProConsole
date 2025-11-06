using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxLogProConsole
{
    public static class InputValidator
    {
        public static int GetValidInt(string prompt, int min = 1, int max = 999)
        {
            int value;
            do
            {
                Console.Write($"{prompt} ");
                string input = Console.ReadLine();
                if (int.TryParse(input, out value) && value >= min && value <= max)
                    return value;

                Console.WriteLine($"❌ Invalid input. Enter a number between {min} and {max}.");
            } while (true);
        }

        public static DateTime GetValidDate(string prompt)
        {
            DateTime date;
            do
            {
                Console.Write($"{prompt} ");
                string input = Console.ReadLine();
                if (DateTime.TryParse(input, out date))
                    return date;

                Console.WriteLine("❌ Invalid date format. Use yyyy-mm-dd.");
            } while (true);
        }
    }
}
