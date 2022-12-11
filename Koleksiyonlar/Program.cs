using System;
using System.Collections.Generic;

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] names = new string[] { "Gamze", "Tuğçe", "Damla", "Hatice" };
            //Console.WriteLine(names[0]);
            //Console.WriteLine(names[1]);
            //Console.WriteLine(names[2]);
            //Console.WriteLine(names[3]);
            //Console.WriteLine(names[4]);//out of range yani sınırların dışında hatası verecek
            /*names = new string [5];*///diziye yeni elaman eklemek için yeni kod satrıına ihtiyacımız oluyor
                                   //Bu yüzden koleksiyonlarla bunu kolayca çözebiliyoruz.
            //names[4] = "Ben";
            //Console.WriteLine(names[4]);
            //Console.WriteLine(names[0]);// heapte bir adres tanımlıyor ama önceki değeri tutamıyor. 
            
            // KOLEKSİYON KULLANIMI
            List<string> names1 = new List<string> { "Gamze", "Tuğçe", "Damla", "Hatice" };
            
            Console.WriteLine(names1[0]);
            Console.WriteLine(names1[1]);
            Console.WriteLine(names1[2]);
            Console.WriteLine(names1[3]);
            


        }



    }
}
