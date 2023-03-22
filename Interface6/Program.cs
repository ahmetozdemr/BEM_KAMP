using System;

namespace Interface6
{
    internal class Program
    {
        static void Main(string[] args)
        {
         

            Console.ReadLine();
        }
    }
    class Satici : IKisi
    {
        public int Id { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public int VergiNo { get; set; }
        public string Bolge { get; set; }
        public string TcNo { get; set; }
    }
    class Alici : IKisi
    {
        public int Id { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public string TcNo { get; set; }
    }
    class Kargocu : IKisi, ITasiyabilirlik
    {
        public int Id { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public string Bolge { get; set; }
        public Arac Araci { get; set; }

        public void TasimaKapasitesi(Urun urun)
        {
            if (urun.Agirlik > 10)
            {
                Console.WriteLine("Ağırlık 10 kilodan fazla olduğundan kargoyu araba ile gönder");
            }
            else if (urun.Agirlik > 5)
            {
                Console.WriteLine("Ağırlık 5 kilodan fazla olduğundan kargoyu motorsiklet ile gönder");
            }
            else
            {
                Console.WriteLine("Ağırlık 5 kilodan az olduğundan kargoyu bisiklet ile gönder");
            }
        }

    }

    interface ITasiyabilirlik
    {
        public void TasimaKapasitesi(Urun urun);

    }
    class Arac
    {
        public static string AracTuru { get; set; }
    }
    class Urun
    {
        public string UrunAdi { get; set; }
        public string Turu { get; set; }
        public int Fiyat { get; set; }
        public int Agirlik { get; set; }

    }
    interface IKisi
    {
        public int Id { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
    }

}