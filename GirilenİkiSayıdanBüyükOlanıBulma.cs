using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int Sayi1, Sayi2;
            Console.Write("\n\n Birinci Sayıyı Girin :");
            Sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n\n İkinci Sayıyı Girin :");
            Sayi2 = Convert.ToInt32(Console.ReadLine());
            if (Sayi1 > Sayi2)
            {
                Console.WriteLine(Sayi1.ToString() + " , " + Sayi2.ToString() + "'den büyüktür.");
            }
            else if (Sayi1 < Sayi2)
            {
                Console.WriteLine(Sayi2.ToString() + " , " + Sayi1.ToString() + "'den büyüktür.");
            }
            else
            {
                Console.WriteLine("İki Sayı Eşittir.");
            }
            Console.ReadLine();


        }
    }
}
