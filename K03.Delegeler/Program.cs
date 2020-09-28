using System;

namespace K03.Delegeler
{
    class Program
    {
        delegate void BenimDelegem(int sayi1, int sayi2);
        static void Main(string[] args)
        {
            BenimDelegem delege = new BenimDelegem(Topla);
            delege += Carp;
            delege.Invoke(2, 3);
            

        }

        static void Topla(int sayi1, int sayi2) => Console.WriteLine("$ Toplam: ", sayi1 + sayi2);
        static void Carp(int sayi1, int sayi2) => Console.WriteLine("$ Carpma: ", sayi1*sayi2);
    }
}
