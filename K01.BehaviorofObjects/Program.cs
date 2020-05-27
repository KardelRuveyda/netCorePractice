using System;
using System.Collections.Generic;

namespace K01.BehaviorofObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            string ad = string.Empty;
            List<string> isimler = new List<String>();

            Musteri musteri = new Musteri();
            List<Musteri> musteriler = new List<Musteri>();

            for (int i = 0; i < 30; i++)
            {
                ad = FakeData.NameData.GetFirstName();
                isimler.Add(ad);
            }
            Console.WriteLine("Primitive");


            foreach (var item in isimler)
            {
                 Console.WriteLine(item);
            }

            for (int i = 0; i < 30; i++)
            {
                musteri.Ad   = FakeData.NameData.GetFirstName();
                musteriler.Add(musteri);
            }
            Console.WriteLine("Refere");


            foreach (var item in musteriler)
            {
                Console.WriteLine(item.Ad);
            }





        }
    }
}

class Musteri
{
    public string Ad { get; set; }
}

