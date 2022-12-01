using System;

namespace Kodlamaıobaslangıc
{
    class Program
    {
        static void Main(string[] args)
        {
            string katagoriEtiketi = "katagori";
            int ogrencisayisi = 32;
            double faizOrani = 1.45;
            double dolarDun = 1.10;
            double dolarBugun = 1.9;
            bool sistemeGirisyapmismi = true; //false da olabilir sadece iki değer döndürür

            if (dolarDun<dolarBugun)
            {
                Console.WriteLine("artış oku");
            }
            else if (dolarDun > dolarBugun) 
            {
                Console.WriteLine("azalış oku");
            }
            else
            {
                Console.WriteLine("eşittir oku");
            }





            if (sistemeGirisyapmismi == false)
            {
                Console.WriteLine("giris yapıldı butonu");
            }
            else
            {
                Console.WriteLine("kayıt yapıldı butonu");
            }
            Console.WriteLine(katagoriEtiketi);
        }
    }
}
