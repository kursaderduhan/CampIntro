using System;

namespace Class_Intro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "Kürşad";
            int yas = 29;

            kurs kurs1 = new kurs();
            kurs1.kursAdi = "C#";
            kurs1.Eğitmen = "Engin Demiroğ";
            kurs1.IzlenmeOrani = 68;

            kurs kurs2 = new kurs();
            kurs2.kursAdi = "Java";
            kurs2.Eğitmen = "Kerem";
            kurs2.IzlenmeOrani = 64;

            kurs kurs3 = new kurs();
            kurs3.kursAdi = "python";
            kurs3.Eğitmen = "Berkay";
            kurs3.IzlenmeOrani = 80;

            //Console.WriteLine(kurs1.kursAdi + " " + kurs1.Eğitmen);

            kurs[] kurslar = new kurs[] {kurs1, kurs2, kurs3 };

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.kursAdi + " : " + kurs.Eğitmen);
            }





            //Console.WriteLine("Hello World!");
        }
    }

    class kurs
    {
        public string kursAdi { get; set; }

        public string Eğitmen { get; set; }

        public int IzlenmeOrani { get; set; }
    }
}
