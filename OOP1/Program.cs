using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();// instence creation bunu mutlaka yapman lazım
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "Çilek";
            product1.UnitPrice = 5;
            product1.UnitInStock = 20;

            Product product2 = new Product() { Id = 2, CategoryId = 3, ProductName = "Erik", UnitPrice = 20, UnitInStock = 6 };

            ProductManager productManager = new ProductManager(); //instance creation örnek oluşturma bunu mutlaka yapman lazım 
            productManager.Add(product1);

        }
    }
}
