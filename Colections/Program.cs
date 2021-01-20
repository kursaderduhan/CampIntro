using System;
using System.Collections.Generic;

namespace Colections
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] isimler = new string[] {"Kürşad","Ali","Murat","Veli" };
            //Console.WriteLine(isimler[0]);
            //Console.WriteLine(isimler[1]);
            //Console.WriteLine(isimler[2]);
            //Console.WriteLine(isimler[3]);


            List<string> isimler2 = new List<string> { "Kürşad", "Ali" };
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            isimler2.Add("İlker");
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[0]);



        }
    }
}
