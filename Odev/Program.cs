using System;

namespace kodlamaıoodev6ders2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Urun urun1 = new Urun();
            Urun urun2 = new Urun();
            Urun urun3 = new Urun();

            urun1.urunAdi = "Parfüm";
            urun1.urunFiyati = 34.99;
            urun1.urunYorumlari = "Çok tutkulu bir koku";

            urun2.urunAdi = "Ruj";
            urun2.urunFiyati = 44.99;
            urun2.urunYorumlari = "Rengine bayıldım";

            urun3.urunAdi = "Otostopçunun Galaksi Rehberi";
            urun3.urunFiyati = 100.34;
            urun3.urunYorumlari = "Çok derin bir bilim kurgu";

            Urun[] urunler = new Urun[] { urun1, urun2, urun3 };

            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.urunAdi);
            }

            for (int i = 0; i < urunler.Length; i++)
            {
                Console.WriteLine(urunler[i]);
            }

            int i = 0;
            while (i < urunler.Length)
            {
                Console.WriteLine(urunler[i]);
                i++;
            }

        }

    }

    class Urun
    {
        public string urunAdi { get; set; }
        public double urunFiyati { get; set; }
        public string urunYorumlari { get; set; }
    }




}