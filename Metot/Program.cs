using System;

namespace Metot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Yaz();
            Console.ReadLine();
        }

        static void Yaz()
        {
            Console.WriteLine("Bir metn yaz");
            string metin = Console.ReadLine();
            Console.WriteLine("Kaç defa yazılsın");
            int adet = int.Parse(Console.ReadLine());

            for (int i = 0; i < adet; i++)
            {
                Console.WriteLine(metin);
            }
        }

        //static void Yaz1()
        //{
        //    Console.WriteLine("Merhaba");
        //    Console.WriteLine("Ahmet");
        //}
    }
}
