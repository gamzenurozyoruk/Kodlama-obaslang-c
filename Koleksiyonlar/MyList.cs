using System;
using System.Collections.Generic;
using System.Text;

namespace Koleksiyonlar
{
    class MyList<T>// istediğimiz veri tipini verebiliriz
    {
        T[] items;
        public MyList()// constoructer yapısı Sınfla aynı ismi taşır ve newlediğin an otomatik çalışır.voidi yoktur.
        {
            items = new T[0];
        }

        public void Add(T item) 
        {

            T[] tempArray = items;// bunu elemanların ref numaraları kaybolmasın tutsun diye yazdık.
            items = new T[items.Length + 1]; // dizideki elemanları bir arttırıyor.Ama önceki elemanları yazmıyor ref numarası kayboluyor
            for (int i = 0; i < tempArray.Length; i++)
            {
               items[i] = tempArray[i];
            }
         }
        items[items.Length - 1] = item;


    }


}
