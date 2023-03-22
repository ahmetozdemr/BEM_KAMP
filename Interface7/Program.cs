using System;

namespace Interface7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Oyuncu oyuncu1 = new Oyuncu();
            oyuncu1.Ad = "Davargüden";
            oyuncu1.Yas = 45;
            Kanas kanas1 = new Kanas();
            kanas1.Ad = "Kanas1";
            //oyuncu1.Silahi = new Kanas();
            oyuncu1.Silahi = kanas1;
            Silah AK47 = new Kanas();


            Oyuncu oyuncu2 = new Oyuncu();
            oyuncu2.Ad = "Davarseven";
            oyuncu2.Yas = 40;

            

            oyuncu1.Saldir(oyuncu2);

            Oyuncu oyuncu3 = new Oyuncu();
            oyuncu3.Ad = "Davaryiyen";
            oyuncu3.Yas = 30;

            oyuncu2.Saldir(oyuncu3);
            oyuncu3.Saldir(oyuncu1);
            
            Console.ReadLine();
        }
    }

    class Oyuncu
    {
        protected int can = 100;
        public string Ad { get; set; }
        public string NickName { get; set; }
        public int Yas { get; set; }
        public string Milleti { get; set; }
        public Silah Silahi { get; set; }

        public string NisanAl()
        {
            return null;//Nişan alma işlemleri
        }
        public void Saldir(Oyuncu oyuncu)
        {

            if (oyuncu.can > 0)
            {
                oyuncu.can--;
                Console.WriteLine($"{oyuncu.Ad} adlı oyuncuya saldırdın yeni canı {oyuncu.can} ");
             
            }
            else
            {
                Console.WriteLine("Düşman öldürüldü");
            }
        }
    }

    class Silah
    {
        public string Ad { get; set; }
        public int Vurus { get; set; }
        public double Agirlik { get; set; }
        public int Mesafe { get; set; }
    }
    class AtesliSilahlar : Silah
    {
        public int MaksimumMermiMiktar { get; set; }
        public void SarjorDegistir(int adet)
        {
            while (MaksimumMermiMiktar == 0)
            {
                MaksimumMermiMiktar += adet;
            }

        }

    }
    class KesiciSilahlar : Silah
    {
        public float Dayaniklilik { get; set; }

    }

    interface IYakinlastirilabilir
    {
        string yakinlastir();
    }

    class Kanas : AtesliSilahlar, IYakinlastirilabilir
    {
        public string yakinlastir()
        {
            return "%50 yakınlaştır";
        }
    }
}
