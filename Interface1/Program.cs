using System;

namespace Interface1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Gazete gazete = new Gazete();
            gazete.Sayfa = 50;
            gazete.HaberTuru = "Cinayet";
            gazete.KenarBosgu = 10;
            gazete.SayfaSayisi();
            Console.WriteLine(gazete.SayfaSayisi());
            gazete.SayfaOlustur();

            Console.ReadKey();

            //Interface kendisinden miras alacak sınıflarda imzasını barındıran bir yapıdır
        }
    }
    interface IArayuz
    {
        //imzalarda erişim belirleyiciler olmasına gerek yoktur standart publictir. Bir şablon olarak kullanırız.
        //Nesne oluşturulamaz. Ama referans noktası oluşturabiliriz.
        //Bir sınıfa yetenek ve özellik kazandırmak için kullanılır.
        //metotları gövdesi yok
        int Sayfa { get; set; }
        void SayfaOlustur();
        int SayfaSayisi();
        int KenarBosgu { get; set; }
    }

    class Gazete : Haberler, IArayuz
    {
        public int Sayfa { get; set; }
        public int KenarBosgu { get; set; }

        public void SayfaOlustur()
        {
            Console.WriteLine("Haber Turu :" + HaberTuru);
        }

        public int SayfaSayisi()
        {
            return Sayfa;
        }
    }
    class Haberler
    {
        public string KonumAdres { get; set; }
        public string HaberTuru { get; set; }
    }
}
