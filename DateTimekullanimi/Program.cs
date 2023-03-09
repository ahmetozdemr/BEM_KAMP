using System;

namespace Metod
{
    public class Program
    {

        static void Main(string[] args)
        {
            //start();
            //TekCiftMethod();
            //UstAlmaBasla();
            //silindir();
            // ToplamayaBasla();
            //  yol = zaman*hız
            //HizZamanYol();
            // Menu();


            Console.WriteLine("Bir uzunluk giriniz ");
            double x = int.Parse(Console.ReadLine());
            Console.WriteLine(kare(x));
        }

        static double kare(double uzunluk)
        {
            return Math.Pow(uzunluk, 2);
        }

        private static void Menu()
        {
            Console.WriteLine("Yiyecek seç Çiğköfte Hamburger Kebab TavukDürüm Ciğer Pideli Köfte");
            string yiyecek = Console.ReadLine();
            Console.WriteLine("İçecek seç Ayran Kola Fanta Şalgam");
            string icecek = Console.ReadLine();

            Hesap(yiyecek, icecek);
        }
        static void Hesap(string yiyecek, string icecek)
        {
            string[] yiyecekListe = { "Çiğköfte", "Hamburger", "Kebab", "TavukDürüm", "Ciğer", "Pideli Köfte" };
            int[] yiyecekFiyat = { 25, 40, 60, 35, 30, 55 };

            string[] icecekListe = { "Ayran", "Kola", "Fanta", "Şalgam" };
            int[] icecekFiyat = { 10, 15, 12, 8 };

            int x = 0;
            int y = 0;

            for (int i = 0; i < 4; i++)
            {
                if (icecekListe[i] == icecek)
                {
                    x = icecekFiyat[i];
                }
            }
            for (int i = 0; i < 6; i++)
            {
                if (yiyecekListe[i] == yiyecek)
                {
                    y = yiyecekFiyat[i];

                }
            }
            Console.WriteLine("Hesap :" + x + y);
        }





        private static void HizZamanYol()
        {
            Console.WriteLine("Hız, Zaman,Yol");
            string secim = Console.ReadLine().ToUpper();

            if (secim == "HIZ")
            {
                Console.WriteLine("Yol giriniz");
                double yol = int.Parse(Console.ReadLine());
                Console.WriteLine("Zaman giriniz");
                double zaman = int.Parse(Console.ReadLine());
                Console.WriteLine("Hızın sonucu :" + hiz(yol, zaman));
            }
            else if (secim == "ZAMAN")
            {
                Console.WriteLine("Yol giriniz");
                double yol = int.Parse(Console.ReadLine());
                Console.WriteLine("Hız giriniz");
                double hiz = int.Parse(Console.ReadLine());
                Console.WriteLine("Zamanın sonucu :" + zaman(hiz, yol));
            }
            else if (secim == "YOL")
            {
                Console.WriteLine("Zaman giriniz");
                double zaman = int.Parse(Console.ReadLine());
                Console.WriteLine("Hız giriniz");
                double hiz = int.Parse(Console.ReadLine());
                Console.WriteLine("Yolun sonucu :" + yol(hiz, zaman));
            }
        }
        static double hiz(double yol, double zaman)
        {
            return yol / zaman;
        }
        static double zaman(double hiz, double yol)
        {
            return yol / hiz;
        }
        static double yol(double hiz, double zaman)
        {
            return zaman * hiz;
        }



        static void ToplamayaBasla()
        {
            Console.WriteLine("Birinci değer");
            double x = int.Parse(Console.ReadLine());
            Console.WriteLine("İkinci değer");
            double y = int.Parse(Console.ReadLine());

            Console.WriteLine(toplamaIslemi(x, y));
        }
        static double toplamaIslemi(double x, double y)
        {
            return x + y;
        }

        static string isimVer()
        {
            Console.WriteLine("Bir isim yaz");
            string isim = Console.ReadLine();
            return isim;
        }
        private static void silindir()
        {
            Console.WriteLine("Taban yarıçapı");
            int r = int.Parse(Console.ReadLine());
            Console.WriteLine("Silindir yükdekliği");
            int h = int.Parse(Console.ReadLine());
            silindirhacim(r, h);
        }
        private static void silindirhacim(int r, int h)
        {
            double pi = Math.PI;
            double hacim = pi * r * r * h;
            Console.WriteLine(hacim);
        }

        private static void UstAlmaBasla()
        {
            Console.WriteLine("Bir sayı ver");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Üst kaç olsun");
            int y = int.Parse(Console.ReadLine());
            ustalma(x, y);
        }
        private static void ustalma(int x, int y)
        {
            int z = 1;
            for (int i = 0; i < y; i++)
            {
                z = z * x;
            }
            Console.WriteLine("Sonuç :" + z);
        }

        private static void TekCiftMethod()
        {
            Console.WriteLine("Bir değer giriniz :");
            int deger = Convert.ToInt32(Console.ReadLine());

            tekciftsonuc(deger);
        }

        private static void tekciftsonuc(int deger)
        {
            if (deger / 2 == 0)
            {
                Console.WriteLine("Bu sayı Çift");
            }
            else
            {
                Console.WriteLine("bu sayı tek ");
            }
        }

        private static void Ileti()
        {
            string metin;
            int adet;
            Console.WriteLine("Bir metin yazınız");
            metin = Console.ReadLine();
            Console.WriteLine("Kaç adet tekrar edildin");
            adet = int.Parse(Console.ReadLine());
            Yaz(metin, adet);

        }

        private static void Yaz(string metin, int adet)
        {
            for (int i = 0; i < adet; i++)
            {
                Console.WriteLine(metin);
            }
        }

        static void Toplama()
        {
            Console.WriteLine("Birinci değer giriniz :");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("İkinci değeri giriniz :");
            int y = int.Parse(Console.ReadLine());

            Console.WriteLine(x + y);
        }
        static void Cıkarma()
        {
            Console.WriteLine("Birinci değer giriniz :");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("İkinci değeri giriniz :");
            int y = int.Parse(Console.ReadLine());

            Console.WriteLine(x - y);
        }
        static void Carpma()
        {
            Console.WriteLine("Birinci değer giriniz :");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("İkinci değeri giriniz :");
            int y = int.Parse(Console.ReadLine());

            Console.WriteLine(x * y);
        }
        static void Bolme()
        {
            Console.WriteLine("Birinci değer giriniz :");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("İkinci değeri giriniz :");
            int y = int.Parse(Console.ReadLine());

            Console.WriteLine(x / y);
        }


        static void Taki()
        {
            int[] takımlar = new int[8];
            for (int i = 0; i < 8; i++)
            {
                takımlar[i] = i + 1;
            }
            int sayac = 0, sayac2 = 0, sayac3 = 0, sayac4 = 0;
            Random ran = new Random();
            int[] dizi2 = new int[takımlar.Length / 2];
            int[] dizi3 = new int[takımlar.Length / 2];
            for (int i = 0; i < takımlar.Length;)
            {
                int eleman = ran.Next(1, 9);
                for (int j = 0; j < dizi2.Length; j++)
                {
                    if (eleman == dizi2[j])
                    {
                        sayac++;
                    }
                    if (eleman == dizi3[j])
                    {
                        sayac++;
                    }
                }
                if (sayac2 % 2 == 1)
                {
                    if (sayac == 0)
                    {
                        dizi2[sayac3] = eleman;
                        i++;
                        sayac3++;
                        sayac2++;
                    }
                }
                else if (sayac2 % 2 == 0)
                {
                    if (sayac == 0)
                    {
                        dizi3[sayac4] = eleman;
                        i++;
                        sayac4++;
                        sayac2++;
                    }
                }
                sayac = 0;
            }
            Console.WriteLine("İlk Turnuva Maçları\n----------------------");
            for (int i = 0; i < dizi2.Length; i++)
            {
                Console.WriteLine("Takım" + dizi2[i] + " Vs " + "Takım" + dizi3[i]);
            }
            for (int i = 0; i < dizi2.Length; i++)
            {
                int mac = ran.Next(1, 3);
                if (mac == 1)
                {
                    dizi2[i] = 0;
                }
                else if (mac == 2)
                {
                    dizi3[i] = 0;
                }
            }
            int[] dizi4 = new int[4];
            int sayac5 = 0;
            Console.WriteLine("Maçlar Başlasın mı ?");
            Console.Read();
            Console.WriteLine("!!!!!...Turnuva 1 Başlıyor...!!!!");
            for (int i = 0; i < dizi2.Length; i++)
            {
                Console.Write((i + 1) + ". Maç Yapılıyor.");
                System.Threading.Thread.Sleep(1000);
                Console.Write(".");
                System.Threading.Thread.Sleep(1000);
                Console.Write(".\n");
                System.Threading.Thread.Sleep(1000);
                if (dizi2[i] != 0)
                {
                    Console.WriteLine((i + 1) + ". Maçın Kazananı = Takım" + dizi2[i]);
                    dizi4[sayac5] = dizi2[i];
                    sayac5++;
                }
                else if (dizi3[i] != 0)
                {
                    Console.WriteLine((i + 1) + ". Maçın Kazananı = Takım" + dizi3[i]);
                    dizi4[sayac5] = dizi3[i];
                    sayac5++;
                }
            }

            int[] dizi5 = new int[2];
            int[] dizi6 = new int[2];
            sayac4 = 0;
            sayac3 = 0;
            sayac5 = 0;
            sayac2 = 0;
            for (int i = 0; i < 4;)
            {
                int eleman = ran.Next(0, 4);
                for (int j = 0; j < dizi5.Length; j++)
                {
                    if (dizi4[eleman] == dizi5[j])
                    {
                        sayac++;
                    }
                    if (dizi4[eleman] == dizi6[j])
                    {
                        sayac++;
                    }
                }
                if (sayac2 % 2 == 1)
                {
                    if (sayac == 0)
                    {
                        dizi5[sayac3] = dizi4[eleman];
                        i++;
                        sayac3++;
                        sayac2++;
                    }
                }
                else if (sayac2 % 2 == 0)
                {
                    if (sayac == 0)
                    {
                        dizi6[sayac4] = dizi4[eleman];
                        i++;
                        sayac4++;
                        sayac2++;
                    }
                }
                sayac = 0;
            }
            Console.WriteLine("5 Sn Sonra 1. Tur Turnuva Maçları Bitiyor");
            System.Threading.Thread.Sleep(5000);
            Console.Clear();
            Console.WriteLine("2. Turnuva Maçları\n----------------------");
            for (int i = 0; i < dizi5.Length; i++)
            {
                Console.WriteLine("Takım" + dizi5[i] + " Vs " + "Takım" + dizi6[i]);
            }
            for (int i = 0; i < dizi6.Length; i++)
            {
                int mac = ran.Next(1, 2);
                if (mac == 1)
                {
                    dizi5[i] = 0;
                }
                else if (mac == 2)
                {
                    dizi6[i] = 0;
                }
            }
            Console.WriteLine();
            sayac5 = 0;
            int[] dizi7 = new int[2];
            Console.WriteLine("!!!!!...Turnuva 2 Başlıyor...!!!!");
            Console.WriteLine("5 Sn Sonra 2. Turnuva Maçları Başlıyor");
            System.Threading.Thread.Sleep(5000);
            for (int i = 0; i < dizi5.Length; i++)
            {
                Console.Write((i + 1) + ". Maç Yapılıyor.");
                System.Threading.Thread.Sleep(1000);
                Console.Write(".");
                System.Threading.Thread.Sleep(1000);
                Console.Write(".\n");
                System.Threading.Thread.Sleep(1000);
                if (dizi2[i] != 0)
                {
                    Console.WriteLine((i + 1) + ". Maçın Kazananı = Takım" + dizi5[i]);
                    dizi7[sayac5] = dizi5[i];
                    sayac5++;
                }
                else if (dizi3[i] != 0)
                {
                    Console.WriteLine((i + 1) + ". Maçın Kazananı = Takım" + dizi6[i]);
                    dizi7[sayac5] = dizi6[i];
                    sayac5++;
                }
            }
            Console.WriteLine("!!!! Final !!!!\n----------------");
            Console.WriteLine("Takım" + dizi7[0] + " Vs " + "Takım" + dizi7[1]);
            Console.WriteLine("Final 5 Sn sonra Başlıyacak ?");
            System.Threading.Thread.Sleep(5000);
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("!!!!!...Final Başlıyor...!!!!");
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("Maç Yapılıyor " + "Takım" + dizi7[0] + " Vs " + "Takım" + dizi7[1]);
            System.Threading.Thread.Sleep(3000);
            Console.Clear();
            int mac2 = ran.Next(3, 5);
            if (mac2 == 3)
            {
                Console.WriteLine("Final Maçın Kazananı = Takım" + dizi7[0]);
            }
            else if (mac2 == 4)
            {
                Console.WriteLine("Final Maçın Kazananı = Takım" + dizi7[1]);
            }
            Console.ReadKey();
        }
    }
}




//HESAP ALMA SORUSU(YİYECEK/İÇECEK) 

//static void Main(string[] args)
//{
//    Console.WriteLine("Hesap = " + HesapAl(Yiyecek(), Icecek()) + " TL");

//    Console.Read();

//}
//static int Yiyecek()
//{
//    Console.WriteLine("Ne Yemek İstiyorsunuz?\n");

//    Console.WriteLine("Yiyecek Menüsü:");
//    Console.WriteLine("1-Hamburger Menüsü:");
//    Console.WriteLine("2-Çiğköfte Menüsü:");
//    Console.WriteLine("3-Kebap/İskender Menüsü:");
//    int fiyat = 0;
//    int menu = Convert.ToInt32(Console.ReadLine());
//    if (menu == 1)
//    {
//        fiyat = 80;
//    }
//    else if (menu == 2)
//    {
//        fiyat = 30;
//    }
//    else if (menu == 3)
//    {
//        fiyat = 70;
//    }

//    return fiyat;

//}
//static int Icecek()
//{
//    Console.WriteLine("Ne İçmek İstiyorsunuz?\n");

//    Console.WriteLine("İçecek Menüsü:");
//    Console.WriteLine("1-Kola");
//    Console.WriteLine("2-Şalgam");
//    Console.WriteLine("3-Ayran");
//    Console.WriteLine("4-Ice Tea");
//    Console.WriteLine("5-Limonata");
//    int fiyat = 0;
//    int menu = Convert.ToInt32(Console.ReadLine());
//    if (menu == 1)
//    {
//        fiyat = 15;
//    }
//    else if (menu == 2)
//    {
//        fiyat = 10;
//    }
//    else if (menu == 3)
//    {
//        fiyat = 7;
//    }
//    else if (menu == 4)
//    {
//        fiyat = 12;
//    }
//    else if (menu == 5)
//    {
//        fiyat = 20;
//    }

//    return fiyat;

//}

//static int HesapAl(int y, int i)
//{
//    return y + i;
//}

//    }