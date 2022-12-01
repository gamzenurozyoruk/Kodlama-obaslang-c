using System;

namespace methotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Adi = "Çilek";
            product1.Fiyati = 10;
            product1.Yorumu = "Bal gibi çilekler";
            product1.StokAdedi = 1;
            Product product2 = new Product();
            product2.Adi = "Şeftali";
            product2.Fiyati = 30;
            product2.Yorumu = "Tüylü şeyftali";
            product2.StokAdedi = 5;

            Product product3 = new Product();
            product3.Adi = "Erik";
            product3.Fiyati = 40;
            product3.Yorumu = "Can eriği bunlar sulu sulu";
            product3.StokAdedi = 6;

            Product[] products = new Product[] {product1,product2,product3};

            foreach (Product product in products)
            {
                Console.WriteLine(product.Fiyati);
                Console.WriteLine(product.Adi);
                Console.WriteLine(product.Yorumu);
                Console.WriteLine(product.StokAdedi);
                Console.WriteLine("................");
            }

            Sepetmanager sepetmanager = new Sepetmanager();
            sepetmanager.Ekle(product1);// ekle fonksiyonun içine parametre olarak ürünü girmelisin
            sepetmanager.Ekle2(product3);





        }






    }
}
