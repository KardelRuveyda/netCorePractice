using System;
using System.ComponentModel.DataAnnotations;

namespace K07.SingleResp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    class Musteri
    {
        public int Id { get; set; }
        [Required(ErrorMessage="Ad alanı boş geçilemez. ")]
        public string Ad { get; set; }
        public void SelamVer() => Console.WriteLine("Selam");

    }

    class MusteriValidator
    {
        public static bool AdDogrula(string ad)
        {
            if (string.IsNullOrWhiteSpace(ad))
                return false;
            return true;
        }
    }
}
