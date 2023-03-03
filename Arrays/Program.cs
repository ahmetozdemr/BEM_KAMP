using System;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] sayilar = { 10,5,83,14,5,6};

            //sayilar[0] = 1; 

            //int[] adet = new int[10];

            //string[] ilceler = new string[10];
            //ilceler[0] = "Eminönü";
            //ilceler[1] = "Kadıköy";
            //ilceler[2] = "Beşiktaş";

            string[] yazilar = new string[10];

            for (int i = 0; i < 10; i++)
            {
                yazilar[i]= Console.ReadLine();

            }
            for (int i = 0; i < 9; i++)
            {
                Console.WriteLine(yazilar[i]);
            }

           Console.ReadLine();

        }
    }
}
