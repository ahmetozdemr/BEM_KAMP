using System;

namespace Metot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Yaz();
            // Topla();
            //TekCift();

            EnBykEnKck();

            Console.ReadLine();
        }

        private static void EnBykEnKck()
        {
            Console.WriteLine("Birin sayıyı giriniz ");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("İkinci sayıyı giriniz ");
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine("Üçüncü sayıyı girniz");
            int z = int.Parse(Console.ReadLine());

            if (x > y)
            {
                Console.WriteLine("En büyük x ");
                Console.WriteLine("En küçük z ");
            }
            else if(x > z && z>y) 
            {
                Console.WriteLine("En büyük x ");
                Console.WriteLine("En küçük y ");
            }
            else if (y>)
            {

            }
        }

        static void TekCift()
        {
            Console.WriteLine("Bir sayı giriniz ");
            int x = int.Parse(Console.ReadLine());

            if (x % 2 == 0)
            {
                Console.WriteLine("{0} sayısı çiftdir", x);
            }
            else if (x==0)
            {
                Console.WriteLine("{0} sayısı nötr bir sayıdır", x);
            }
            else { Console.WriteLine("{0} sayısı tektir", x); }

        }

        static void Topla()
        {
            Console.WriteLine("Bir sayı giriniz ");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Bir sayı giriniz ");
            int y = int.Parse(Console.ReadLine());

            Console.WriteLine(x + y);

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
        static void Yaz1()
        {
            Console.WriteLine("Merhaba");
            Console.WriteLine("Ahmet");
        }
    }
}
