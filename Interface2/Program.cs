using System;

namespace Interface2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sekreter sekreter1 = new Sekreter();
            sekreter1.Pozisyon = "Sekreter";
            sekreter1.Maas = 20_000;
            sekreter1.Yemek = Yemek.Cigköfte;
            sekreter1.YemekYediMi();
            Console.WriteLine("------------------");
            Stajyer stajyer1 = new Stajyer();
            stajyer1.Pozisyon = "Stajyer";
            stajyer1.Maas = 10_000;
            stajyer1.Yemek = Yemek.Börek;
            stajyer1.YemekYediMi();
            Console.WriteLine("------------------");
            Mudur mudur1 = new Mudur();
            mudur1.Pozisyon = "Müdür";
            mudur1.Yemek = Yemek.Kadayıf;
            mudur1.YemekYediMi();


            Console.WriteLine("Kişi sayısı : " + Kisi.CalisanSayisi);
            Console.ReadLine();
        }
    }
    interface IArayuz
    {
        string Pozisyon { get; set; }
        int Maas { get; set; }
        Yemek Yemek { get; set; }
    }



    abstract class Islemler : IArayuz
    {

        public int Maas { get; set; }
        public Yemek Yemek { get; set; }
        public string Pozisyon { get; set; }

        abstract public void YemekYediMi();
    }

    class Kisi : Islemler
    {

        public Kisi()
        {
            Pozisyon = null;
            Maas = 0;
            Yemek = 0;
            CalisanSayisi++;
        }
        public static int CalisanSayisi { get; set; }
        public override void YemekYediMi()
        {
            throw new NotImplementedException();
        }
    }

    class Mudur : Kisi
    {

        public override void YemekYediMi()
        {
            Console.WriteLine("Pozisyon: " + Pozisyon);
            Console.WriteLine("Maas : " + Maas);
            Console.WriteLine("Yenilen Yemek : " + Yemek);
        }
    }
    class Sekreter : Kisi
    {
        public override void YemekYediMi()
        {
            Console.WriteLine("Pozisyon: " + Pozisyon);
            Console.WriteLine("Maas : " + Maas);
            Console.WriteLine("Yenilen Yemek : " + Yemek);
        }
    }

    class Stajyer : Kisi
    {
        public override void YemekYediMi()
        {
            Console.WriteLine("Pozisyon: " + Pozisyon);
            Console.WriteLine("Maas : " + Maas);
            Console.WriteLine("Yenilen Yemek : " + Yemek);
        }
    }
    enum Yemek
    {
        Cigköfte,
        Köfte,
        Börek,
        Kadayıf
    }
}

/*
 class Calisan
    {
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public decimal Maas { get; set; }
        public string Gorev { get; set; }
    }
    class Memur : Calisan, IYemekYiyebilme, IMaasAlabilme
    {
        public string Departman { get; set; }

        public void MaasAlma()
        {
            throw new NotImplementedException();
        }

        public void Yemek()
        {
            throw new NotImplementedException();
        }
    }
   
    class Sekreter: Calisan, IYemekYiyebilme, IMaasAlabilme
    {
        public string Departman { get; set; }

        public void MaasAlma()
        {
            throw new NotImplementedException();
        }

        public void Yemek()
        {
            throw new NotImplementedException();
        }
    }

    class Patron : Calisan, IYemekYiyebilme
    {
        public void Yemek()
        {
            throw new NotImplementedException();
        }
    }
    class Robot: Calisan
    {

    }

    interface IYemekYiyebilme
    {
        void Yemek();
    }
    interface IMaasAlabilme
    {
        void MaasAlma();
    }

 */