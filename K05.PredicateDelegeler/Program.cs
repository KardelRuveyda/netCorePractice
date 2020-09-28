using System;
using System.Collections.Generic;

namespace K05.PredicateDelegeler
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string> { "kardel", "rüveyda", "cetin" };
            Predicate<string> predicate = new Predicate<string>(KardeliBul);
            list.Find(predicate);

            Console.WriteLine(list.Find(KardeliBul));

        }

        private static bool KardeliBul(string obj)
        {
            return obj.ToLower() == "kardel";
        }
    }
}
