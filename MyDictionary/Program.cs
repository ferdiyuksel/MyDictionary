using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> sehirler = new MyList<string>();
            sehirler.Add("Ankara");
            sehirler.Add("Bursa");
            sehirler.Add("Aksaray");

            Console.WriteLine(sehirler.Lenght);
        }
    }
}
