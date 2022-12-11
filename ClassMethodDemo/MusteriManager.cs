using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMethodDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri MusteriEkleme)
        {
            Console.WriteLine("Müşteri başarılı şekilde eklendi" + MusteriEkleme.MusteriAdi);
            Console.WriteLine("Müşteri başarılı şekilde eklendi" + MusteriEkleme.MusteriId);
            Console.WriteLine("Müşteri başarılı şekilde eklendi" + MusteriEkleme.MusteriSoyadi);
            Console.WriteLine("Müşteri başarılı şekilde eklendi" + MusteriEkleme.MusteriYas);
            Console.WriteLine("Müşteri başarılı şekilde eklendi" + MusteriEkleme.TcKimlikNumarası);
        }

        public void Silme(Musteri MusteriSilme)
        {
            Console.WriteLine("Müşteri başarılı şekilde silindi" + MusteriSilme.MusteriAdi);
            Console.WriteLine("Müşteri başarılı şekilde silindi" + MusteriSilme.MusteriSoyadi);
            Console.WriteLine("Müşteri başarılı şekilde silindi" + MusteriSilme.TcKimlikNumarası);
            Console.WriteLine("Müşteri başarılı şekilde silindi" + MusteriSilme.MusteriId);
            Console.WriteLine("Müşteri başarılı şekilde silindi" + MusteriSilme.MusteriYas);
            
        }



        public void Listele(params Musteri[] musteriler)
        {
            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine("Id : " + musteri.MusteriId + "\n" + "Tc : " + musteri.TcKimlikNumarası + "\n" + "Müşteri Adı : " +
                    musteri.MusteriAdi + "\n" + "Müşteri Soyadı : " + musteri.MusteriSoyadi);
                Console.WriteLine("----------------------------------");
            }
            
        //public void Listele(Musteri MusteriListele)
        //{
        //    for (int i = 0; i < musteriler.Length; i++)
        //    {
        //        if (musteriler[i] != null)
        //        {
                  
        //            Console.WriteLine("ID: " + MusteriListele.MusteriId + "Tc Kimlik Numarası: " + MusteriListele.TcKimlikNumarası + "Adı: " + MusteriListele.MusteriAdi + "Soyadı: " + MusteriListele.MusteriSoyadi + "Yaşı: " + MusteriListele.MusteriYas);
        //        }
        //        else
        //        {
        //            break;
        //        }

        //    }

        }
    }
}
