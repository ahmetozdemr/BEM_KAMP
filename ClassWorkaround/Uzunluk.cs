using System;

namespace ClassWorkaround
{
    public class Uzunluk
    {
        public int kisaKenar = 10;
        public int uzunKenar = 20;

        public void dikdörtgen()
        {
            this.kisaKenar = 30;
            this.uzunKenar = 45;
            Console.WriteLine("Dikdörtgenin alanı : " + (30 * 45) / 2);
        }
        public void dikdörtgenAlan(int a, int b)
        {
            Console.WriteLine("Dikdörtgenin alanı : " + (a * b) / 2);
        }
    }
}
