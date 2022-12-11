using System;

namespace ClassMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri = new Musteri();

            musteri.MusteriAdi = "Gamzenur";
            musteri.MusteriSoyadi = "Özyörükoğulları";
            musteri.TcKimlikNumarası = "35764513688";
            musteri.MusteriId = 1;
            musteri.MusteriYas = 23;

            Musteri musteri1 = new Musteri();
            musteri1.MusteriAdi = "Hatice";
            musteri1.MusteriSoyadi = "Özyörükoğulları";
            musteri1.TcKimlikNumarası = "10022012288";
            musteri1.MusteriId = 2;
            musteri1.MusteriYas = 50;
            
            Musteri musteri2 = new Musteri();
            musteri2.MusteriAdi = "Tuğçe";
            musteri2.MusteriSoyadi = "Özyörükoğulları";
            musteri2.TcKimlikNumarası = "1023447654343";
            musteri2.MusteriId = 3;
            musteri2.MusteriYas = 18;

            //Musteri musteri = new Musteri() { MusteriId = 1, TcKimlikNumarası = "35764513688", MusteriAdi = "Gamzenur", MusteriSoyadi = "Özyörükoğulları",MusteriYas = 23 }; böyle de tanımlanabilir

            Musteri[] musteriler = new Musteri[] {musteri,musteri1,musteri2};
            //Musteri musteri1 = new Musteri() {MusteriId = 2, TcKimlikNumarası = "10022012288", MusteriAdi = "Hatice", MusteriSoyadi = "Özyörükoğulları", MusteriYas = 50 }; böyle de tanımlanabilir
         
            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Silme(musteri);
            musteriManager.Listele(musteriler);
            musteriManager.Silme(musteri2);

        }
    }
}
