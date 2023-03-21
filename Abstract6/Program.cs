using System;

namespace Struct1
{
    internal class Program
    {
        static void Main(string[] args)
        {         

            Ders drs1 = new Ders();
            drs1.Adi = "Programlama";
            drs1.Saat = 7;
            drs1.Kredi = 5;

            Ogretmen ogretmen1 = new Ogretmen();
            ogretmen1.Adi = "Uğur";
            ogretmen1.SoyAd = "Akbulut";

            Ogrenci ogr1 = new Ogrenci();
            Ogrenci ogr2 = new Ogrenci();
            Ogrenci ogr3 = new Ogrenci();

            ogr1.Ad = "Ahmet";
            ogr1.SoyAd = "Özdemir";
            ogr1.Dersi = drs1;
            ogr1.Ogretmen = ogretmen1;

            Console.WriteLine(ogr1.Ogretmen.Adi);
            Console.WriteLine(ogr1.Dersi.Adi);
          
            Console.WriteLine(Ogrenci.OgrenciSayisi);

            Console.ReadKey();  
        }
    }
    class Ogrenci
    {    
        public Ogrenci()
        {
            OgrenciSayisi++;
        }
        public string Ad { get; set; }
        public string SoyAd { get; set; }

        public int OkulNo { get; set; }
        public int Sinif { get; set; }
        public Ogretmen Ogretmen { get; set; }  
        public Ders Dersi { get; set; } 
        public static int OgrenciSayisi { get; set; }
       
        //Static : sınıftan instance almadan sınıfın sonuna nokta koyarak static elemana ulaşmamızı sağlıyor.

    }
    struct Ders
    {
        public string Adi { get; set; }
        public int Kredi { get; set; }

        public string Kitabi { get; }
        public int Saat { get; set; }
    }
    class Ogretmen
    {
        public string Adi { get; set; }
        public string SoyAd { get; set; }
    }
}
