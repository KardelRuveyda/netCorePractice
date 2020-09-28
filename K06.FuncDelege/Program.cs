using System;
using System.Collections.Generic;
using System.Linq;

namespace K06.FuncDelege
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string> { "kardel", "rüveyda", "cetin" };

            Func<string, bool> func = new Func<string, bool>(KardeliBul);

            foreach (var item in list.Where(func))
            {
                Console.WriteLine(item);
            }
        }

        private static bool KardeliBul(string arg)
        {
            return arg == "kardel" || arg == "rüveyda";
        }
    }
}
