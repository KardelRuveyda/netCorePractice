using System;

namespace K02.ExtensionMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            MatematikselHesaplama matematiksel = new MatematikselHesaplama();
            int sonucCikarma= matematiksel.Cikar(5, 3);
            int sonucCarpma = matematiksel.Carp(6, 2);

            Console.WriteLine(sonucCarpma);
            Console.WriteLine(sonucCikarma);
           
            Console.ReadLine();
        }
    }

    class MatematikselHesaplama
    {
        public int Topla(int sayi1, int sayi2) => sayi1 + sayi2;
        public int Bol(int sayi1, int sayi2) => sayi1 * sayi2;

    }

    static class MathExtension
    {
        public static int Cikar(this MatematikselHesaplama islem, int sayi1, int sayi2) => sayi1 - sayi2;
        public static int Carp(this MatematikselHesaplama islem, int sayi1, int sayi2) => sayi1 * sayi2;
    }
}
