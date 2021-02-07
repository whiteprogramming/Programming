using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi1, sayi2;
            int toplama, cikarma, carpma, bolme;
            Console.Write("\n\n Birinci Sayıyı Girin :");
            sayi1 = Convert.ToInt32(Console.ReadLine());

            Console.Write(" İkinci Sayıyı Girin :");
            sayi2 = Convert.ToInt32(Console.ReadLine());

            toplama = sayi1 + sayi2 ;
            cikarma = sayi1 - sayi2 ;
            carpma =  sayi1 * sayi2 ;
            bolme  =  sayi1 / sayi2 ;
            Console.WriteLine("Toplama İşleminin Sonucu =" + toplama.ToString());
            Console.WriteLine("Çıkarma İşleminin Sonucu =" + cikarma.ToString());
            Console.WriteLine("Çarpma İşleminin Sonucu =" + carpma.ToString());
            Console.WriteLine("Bölme İşleminin Sonucu =" + bolme.ToString());
            Console.ReadLine();


        }
    }
}
