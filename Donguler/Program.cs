using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım Geliştirici Yetiştirme kampı";
            string kurs2 = "programlamaya başlangıç için temel kurs";
            string kurs3 = "Java";

            //array-dizi

            string[] kurslar = new string[] { "Yazılım Geliştirici Yetiştirme kampı", "programlamaya başlangıç için temel kurs", "Java" };


            for (int i = 0; i<kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }
            Console.WriteLine("forbitti");

            foreach (string kurs in kurslar) //kursları dolaş //foreach dizilere uygulanır
            {
                Console.WriteLine(kurs);
            }
            Console.WriteLine("Sayfa Sonu - footer");
        }
    }
}
