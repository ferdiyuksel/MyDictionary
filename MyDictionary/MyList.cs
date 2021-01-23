using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class MyList<Dizi>
    {
        Dizi[] items;
        public MyList()
        {
            items = new Dizi[0];
        }
        public void Add(Dizi item)
        {
            Dizi[] tempArray = items;
            items = new Dizi[items.Length+1];
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }

            items[items.Length - 1] = item;

        }
        public int Lenght
        {
            get { return items.Length; }
        }

        public Dizi[] Items
        {
            get { return items; }
        }

    }
}
