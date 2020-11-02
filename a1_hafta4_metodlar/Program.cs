using System;
using System.Reflection.Metadata;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.WindowsRuntime;

namespace a1_hafta4_metodlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Ekranayaz("Kadir","Bülbül");
           string isim= Adsoyadver();
            Console.WriteLine(isim);
            Console.WriteLine(topla(6, 8));
           Ekranayaz2(metin3: "Yazılım", metin4: "fü");
            Console.WriteLine(toplametodu(58,11));
            Console.ReadKey();
        }
        static void Ekranayaz2(string metin1="Kadir",string metin2="Bülbül",string metin3="",string metin4 = "")
        {
            Console.WriteLine(metin1);
            Console.WriteLine(metin2);
            Console.WriteLine(metin3);
            Console.WriteLine(metin4);
        }
        static string Adsoyadver()
        {
            string metin = "Kadir Bülbül";
            return metin;
        }
        static int topla(int x,int y)
        {
            int toplam = x + y;
            return toplam;
        }
        //// değer döndermeyen ve parametrealmayan metot
        static void yaz()
        {
            Console.WriteLine("selam");
        }
        // değer döndermeyen ancak parametre alan metot
        static void Ekranayaz(string ad, string soyad)
        {
            Console.WriteLine(ad);
            Console.WriteLine(soyad);
        }
        // değer dönderen ancak parametre almayan metod 
         static int toplametodu()
        {
            Console.WriteLine("sayibir gir");
            int s1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("sayi iki");
            int s2 = Convert.ToInt32(Console.ReadLine());
            return s1 + s2;
           }
        // deger dönderen ve parametre alan 
        static int toplametodu(int a, int b)
        {
            return a + b;
        }
    }
}
