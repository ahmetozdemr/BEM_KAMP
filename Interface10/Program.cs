using Interface10;
using System;

namespace Interface10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime dt1 = new DateTime(1996, 3, 25);
            DateTime dt2 = new DateTime(1996, 3, 25);

            Arsa arsa = new Arsa();
            arsa.Ad = "Ahmet";
            arsa.Soyaad = "Özdemir";
            arsa.Il = "Adıyaman";
            arsa.Ilce = "Gerger";
            arsa.Yuzolcumu = 120;
            arsa.Tarih = dt1;
            arsa.Kullanim();

            Ev ev = new Ev();
            ev.Il = "İstanbul";
            ev.Ilce = "Esenler";
            ev.MetreKare = 80;
            ev.Tarih = dt2;
            ev.Kullanim();



            Console.ReadLine();
        }
    }

    interface IKisi
    {
        string Ad { get; set; }
        string Soyaad { get; set; }
    }
    interface ITapubilgileri : IKisi
    {
        string Il { get; set; }
        string Ilce { get; set; }
        DateTime Tarih { get; set; }
        void Kullanim();
    }
    class Arsa : ITapubilgileri
    {
        public int Yuzolcumu { get; set; }
        public string Il { get; set; }
        public string Ilce { get; set; }
        public DateTime Tarih { get; set; }
        public string Ad { get; set; }
        public string Soyaad { get; set; }

        public void Kullanim()
        {
            Console.WriteLine("Arsa tapu bilgileri kullanıldı ");
        }
    }
    class Ev : ITapubilgileri
    {
        public int MetreKare { get; set; }
        public string Il { get; set; }
        public string Ilce { get; set; }
        public DateTime Tarih { get; set; }
        public string Ad { get; set; }
        public string Soyaad { get; set; }

        public void Kullanim()
        {
            Console.WriteLine("Ev tapu bilgileri kullanıldı ");
        }

    }
}
