using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int Not1, Not2, Not3,Ortalama;
            Console.Write("\n\n Birinci Notu Girin :");
            Not1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n\n İkinci Notu Girin :");
            Not2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n\n Üçüncü Notu Girin :");
            Not3 = Convert.ToInt32(Console.ReadLine());
            Ortalama = (Not1 + Not2 + Not3) / 3;
            Console.WriteLine("\n\n Öğrenci Ortalaması: " + Ortalama.ToString());
            Console.ReadLine();


        }
    }
}
