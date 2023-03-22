using System;

namespace Interface5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Baba baba1 = new Baba();
            baba1.Ad = "Mario";
            baba1.SoyAd = "Gomez";
            baba1.Biyik = true;
            baba1.Sakal = false;
            baba1.OzellikleriGoster();



            Console.ReadKey();
        }
    }
}
