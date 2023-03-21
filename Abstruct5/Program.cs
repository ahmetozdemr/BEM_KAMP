using System;

namespace Abstruct5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Aslan aslan = new Aslan();
            aslan.Ad = "Kral Alex";
            aslan.Ayaksayisi = 4;
            aslan.YedigiHayvan = "Öküz Başlı Antilop";
            aslan.BeslenmeSekli = "Etcil";
            aslan.OzellikleriGoster();


            Console.Read();
        }
    }
    abstract class Canli
    {
        abstract public string Ad { get; set; }

        abstract public void OzellikleriGoster();
    }
    abstract class Hayvan : Canli
    {
        abstract public string BeslenmeSekli { get; set; }
        abstract public int Ayaksayisi { get; set; }
    }
    abstract class Etcil : Hayvan
    {
        abstract public string YedigiHayvan { get; set; }

    }
    abstract class Otcul : Hayvan
    {
        abstract public string YedigiOt { get; set; }

    }
    class Aslan : Etcil
    {
        private string yedigiHayvan;
        private string beslenmeSekli;
        private int ayaksayisi;
        private string ad;
        public override string YedigiHayvan { get; set; }
        public override string BeslenmeSekli { get; set; }
        public override int Ayaksayisi { get; set; }
        public override string Ad { get; set; }

        public override void OzellikleriGoster()
        {
            yedigiHayvan = YedigiHayvan;
            beslenmeSekli=BeslenmeSekli;
            ayaksayisi = Ayaksayisi;    
            ad = Ad;

            Console.WriteLine("Ad : "+ ad);
            Console.WriteLine("Beslenme Şekli: "+ beslenmeSekli);
            Console.WriteLine("Ayak Sayisi : "+ ayaksayisi);
            Console.WriteLine("Yediği Hayvan : "+ yedigiHayvan);
        }
    }
}

/*
 internal class Program
    {
        static void Main(string[] args)
        {
            Etcil aslan = new Etcil();
            aslan.Adi = "Aslan";
            aslan.BeslenmeSekli = "Etçil";
            aslan.Turu = "Memeli";
            aslan.AyakSayisi = 4;
            aslan.HayatSuresi = 10;
            aslan.Info();
            Otcul zebra = new Otcul();
            zebra.Adi = "zebra";
            zebra.BeslenmeSekli = "otcul";
            zebra.Info();



            Console.ReadLine();


        }
    }

    public abstract class Hayvan
    {
        public abstract string Adi { get; set; }
        public abstract string BeslenmeSekli { get; set; }
        public short HayatSuresi { get; set; }
        public string Turu { get; set; }
        public short AyakSayisi { get; set; }
        public abstract void Info();     


    }
    class Etcil : Hayvan
    {
        public override string Adi { get; set; }
        public override string BeslenmeSekli { get; set; }

        public override void Info()
        {
            Console.WriteLine($"{this.Adi} {this.BeslenmeSekli} bir hayvandır");
            if (this.Turu != null)
                Console.WriteLine("Türü=" + Turu);
            if (this.AyakSayisi > -1)
                Console.WriteLine("Ayak Sayısı=" + AyakSayisi);
            if (this.HayatSuresi > -1)
                Console.WriteLine("Hayat Suresi=" + HayatSuresi + " yıl");
        }
        public Etcil()
        {
            AyakSayisi = -1;
            HayatSuresi = -1;
        }


    }
    class Otcul : Hayvan
    {
        public override string Adi { get; set; }
        public override string BeslenmeSekli { get; set; }

        public override void Info()
        {
            Console.WriteLine($"{this.Adi} {this.BeslenmeSekli} bir hayvandır");
            if (this.Turu != null)
                Console.WriteLine("Türü=" + Turu);
            if (this.AyakSayisi > -1)
                Console.WriteLine("Ayak Sayısı=" + AyakSayisi);
            if (this.HayatSuresi > -1)
                Console.WriteLine("Hayat Suresi=" + HayatSuresi + " yıl");
        }
        public Otcul()
        {
            AyakSayisi = -1;
            HayatSuresi = -1;
        }


    }
 */
