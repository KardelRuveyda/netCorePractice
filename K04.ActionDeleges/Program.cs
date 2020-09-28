using System;
using System.Collections.Generic;

namespace K04.ActionDeleges
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> sayilar = new List<int> { 1, 2, 3, 4, 5, 6 };
            Action<int> action = new Action<int>(SayiGetir);

            sayilar.ForEach(action);
        }

        private static void SayiGetir(int obj) => Console.WriteLine(obj.ToString());
    }
}
