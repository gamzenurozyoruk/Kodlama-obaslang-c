using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class ProductManager
    {
        public void Add(Product product) {

            Console.WriteLine(product.ProductName + "Kamera");
          

        }
        // referans tipler ve deger tipler arasındaki fark asağıda BiseyYap fonksiyonunki değer tiptir.
        // Burdaki sayi değerini almaz ama yukardaki referans tiptir adrese yazılır kamera değerini alır her türlü
        public void BiseyYap(int sayi)
        {
            sayi = 99;
        }

        public void Update(Product product)
        {

            Console.WriteLine(product.Id + "güncellendi");
        }


        //return ile void farkı return kullandığımızda sonucu sonradan başka işlem için kullanabiliyoruz voidde ise böyle bir şey yapmıyoruz sadee işlemi yapıp geçiyor. 
        public int Topla (int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }

    }
}
