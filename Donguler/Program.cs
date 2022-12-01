using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] kurslar = new string[] { "yazılım geliştirme", "java", "kodlamaya başlangıç" }; // buraya eklenen he elemanı dinamik şekilde yazdırabiliyoruz artık for döngüsüyle birlikte
            
            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            foreach (string kurs in kurslar) // dizileri daha kolay dolaşmak için ve tek tek dolaşmak için kullanılır for daha genel bu ise daha özel kullanılır
            {
                Console.WriteLine(kurs);
            }


            for (int i = 0; i < 10; i++)//i++ bir bir arttırmak demek i+=2 iki iki arttırmka demek i=i+2 de iki iki arttırmak demektir.
            {
                Console.WriteLine(i);
            }
        }
    }
}
