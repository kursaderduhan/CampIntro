using System;

namespace CampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
           
            //type safety - tip güvenliği
            // do not repeat yourself!!
            //değer tutucu alias takma isim (kategori etiketi)
            
            string kategoriEtiketi = "Kategoriler";
            int öğrenciSayisi = 32000;
            double faizOranı = 1.45; //ondalıklı sayılar(double)
            double dolarDun = 7.35;
            double dolarBugun = 7.45;

            //if (dolarDun>dolarBugun)
            {
            //    Console.WriteLine("Azalış butonu");
            }
            //else if { dolarDun<dolarBugun}
            {
            //    Console.WriteLine("Artış Butonu");
            //}else
            {
            //    Console.WriteLine("değişmedi butonu");
            }

            bool sistemeGirisYapmisMi = true; //şartBloğuDenebilir

            if (sistemeGirisYapmisMi == true)
            {
                Console.WriteLine("Kullanıcı ayarları butonu");
            }
            else
            {
                Console.WriteLine("Giris yap butonu");
            }

            
            Console.WriteLine("kategoriEtiketi");

            
        }
    }
}
