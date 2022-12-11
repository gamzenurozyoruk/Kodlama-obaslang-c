using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class Product
    {
        public int Id { get; set; }//primary key olarak üste yazılmalı
        public int CategoryId { get; set; }//foreign key olarak ikinci yazılmalı
        public string ProductName { get; set; }
        public double UnitPrice { get; set; }
        public int UnitInStock { get; set; }
    }
}
