using System;
using System.Collections.Generic;
using System.Text;

namespace methotlar
{
    class Sepetmanager
    {
        public void Ekle(Product product)
        {
            Console.WriteLine("Sepete Eklendi :" + product.Adi);
        }
        // encapsulation- kapsülleme
        public void Ekle2(Product product)
        {
            Console.WriteLine("Sepete Eklendi :" + product.StokAdedi);
        }
    }
}
