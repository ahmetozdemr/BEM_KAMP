using System;

namespace Interface9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime dt = new DateTime(1995, 1, 25);

            nufuscuzdani nfs = new nufuscuzdani();
            nfs.ad = "ibrahim";
            nfs.soyad = "inan";
            nfs.dogumtarihi = dt;
            nfs.dogumyeri = "Londra";
            nfs.kullanim();

            ehliyet ehl = new ehliyet();
            ehl.ad = nfs.ad;
            ehl.sinif = "b2";
            ehl.kullanim();

            // kimlik kml = new kimlik();
            kontrol knt = new kontrol();
            knt.kontrolet(ehl);
            knt.kontrolet(nfs);


            Console.ReadLine();
        }
        interface Ikimlik
        {
            public string ad { get; set; }
            public string soyad { get; set; }
            public int tcno { get; set; }
            public void kullanim();

        }
        class nufuscuzdani : Ikimlik
        {
            public string dogumyeri { get; set; }
            public DateTime dogumtarihi { get; set; }
            public string ad { get; set; }
            public string soyad { get; set; }
            public int tcno { get; set; }

            public void kullanim()
            {
                Console.WriteLine("nüfus cüzdanı kullanıldı.");
            }

        }
        class ehliyet : Ikimlik
        {
            public string sinif { get; set; }
            public string ad { get; set; }
            public string soyad { get; set; }
            public int tcno { get; set; }

            public void kullanim()
            {
                Console.WriteLine("ehliyet kartı kullanıldı.");
            }

        }
        class okul : Ikimlik
        {
            public string okulu { get; set; }
            public string bolumu { get; set; }
            public string ad { get; set; }
            public string soyad { get; set; }
            public int tcno { get; set; }

            public void kullanim()
            {
                Console.WriteLine("ogrenci kartı kullanıldı.");
            }

        }
        class kontrol
        {
            public void kontrolet(Ikimlik kml)
            {
                kml.kullanim();
            }
        }

    }
}