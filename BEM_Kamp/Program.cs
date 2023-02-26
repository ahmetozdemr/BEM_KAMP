using System;
using System.Globalization;
using System.Runtime.ConstrainedExecution;
using System.Threading;

namespace BEM_Kamp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region ad soyad
            //string ad, soyad, yas, burc, takım, memleket;
            //Console.Write("lütfen adınızı giriniz=");
            //ad = Console.ReadLine();
            //Console.Write("lütfen soyadınızı giriniz=");
            //soyad = Console.ReadLine();
            //Console.Write("lütfen yaşınızı giriniz=");
            //yas = Console.ReadLine();
            //Console.Write("lütfen burcunuzu giriniz=");
            //burc = Console.ReadLine();
            //Console.Write("lütfen takımınızı giriniz=");
            //takım = Console.ReadLine();
            //Console.Write("lütfen memleketinizi giriniz=");
            //memleket = Console.ReadLine();

            //Console.WriteLine($"adı={ad}\nsoyadı={soyad}\nyaşı={yas}\nburcu={burc}\ntakımı={takım}\nmemleketi={memleket}");
            #endregion
            #region üçgenin alanı
            ////üçgenin alanını bulma
            //double taban, yukseklik;
            //Console.WriteLine("lütfen taban kenarı giriniz=");
            //taban = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("lütfen yüksekliği giriniz=");
            //yukseklik = Convert.ToInt32(Console.ReadLine());
            //double alan = taban * yukseklik / 2;
            //Console.WriteLine($"üçgenin alanı={alan}");
            #endregion
            #region su kaynadı
            //Console.Write("lütfen bir sıcaklık değeri giriniz=");
            //int t=Convert.ToInt32( Console.ReadLine() );
            //if (t >= 100)
            //{
            //    Console.WriteLine("su kaynadı");
            //}
            //else
            //    Console.WriteLine("su kaynamadı.");
            #endregion
            #region katı sıvı gaz
            //Console.Write("lütfen bir sıcaklık değeri giriniz=");
            //int t = Convert.ToInt32(Console.ReadLine());
            //if (t >= 100)
            //{
            //    Console.WriteLine("gaz halinde");
            //}
            //else if(t<0)
            //{
            //    Console.WriteLine("katı halde");
            //}
            //else
            //    Console.WriteLine("sıvı halde");


            #endregion
            #region girilen sayı negatif mi pozitifmi
            //Console.WriteLine("lütfen bir sayı giriniz=");
            //int sayi=Convert.ToInt32(Console.ReadLine());
            //if (sayi >0)
            //{
            //    Console.WriteLine("pozitiftir.");
            //}
            //else if (sayi<0)
            //{
            //    Console.WriteLine("negatiftir.");
            //}
            //else
            //    Console.WriteLine("sayı sıfıra eşittir.");

            #endregion
            #region geçme notu hesaplama
            //Console.WriteLine("lütfen vize notunuzu giriniz=");
            //double vize=Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("lütfen final notunuzu giriniz=");
            //double final = Convert.ToDouble(Console.ReadLine());
            //double ort = vize * 0.4 + final * 0.6;
            //if (ort<60)
            //{
            //    Console.WriteLine("başarısız");
            //}
            //else
            //    Console.WriteLine("başarılı");
            #endregion
            #region kullanıcı adı şifre
            //Console.Write("lütfen kullanıcı adınızı giriniz=");
            //string k=Console.ReadLine();
            //Console.Write("lütfen kullanıcı şifrenizi giriniz=");
            //string s=Console.ReadLine();
            //string sifre = "12345";
            //string kullanıcı = "fatih";
            //if (s==sifre && k==kullanıcı)
            //{
            //    Console.WriteLine("giriş başarılı");
            //}
            //else
            //{
            //    Console.WriteLine("kullanıcı adı veya şifresi yanlış");
            //}
            #endregion
            #region iki sayıdan hangisi büyük
            //Console.WriteLine("lütfen bir sayı giriniz=");
            //int a=Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("lütfen bir sayı giriniz=");
            //int b = Convert.ToInt32(Console.ReadLine());
            //if (a>b)
            //{
            //    Console.WriteLine($"{a} sayısı {b} sayısından büyüktür ");
            //}
            //else if (a==b) 
            //{
            //    Console.WriteLine("sayılar birbirine eşittir");
            //}
            //else
            //    Console.WriteLine($"{b} sayısı {a} sayısından büyüktür ");

            #endregion
            #region 3 sayıdan büyük olan
            //Console.WriteLine("lütfen bir sayı giriniz=");
            //int a = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("lütfen bir sayı giriniz=");
            //int b = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("lütfen bir sayı giriniz=");
            //int c = Convert.ToInt32(Console.ReadLine());
            //if (a > b && b>c)
            //{
            //    Console.WriteLine($"{a} sayısı en büyüktür ");
            //}
            //else if (a == b && b==c)
            //{
            //    Console.WriteLine("sayılar birbirine eşittir");
            //}
            //else if (b>c && c>a)
            //{
            //    Console.WriteLine($"{b} sayısı en büyüktür ");
            //}
            //else
            //    Console.WriteLine($"{c} sayısı en büyüktür ");
            #endregion
            #region ortalama
            //double v1, v2, f,ort;
            //Console.WriteLine("1.vizeyi giriniz=");
            //v1=Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("2.vizeyi giriniz=");
            //v2= Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("final giriniz=");
            //f = Convert.ToDouble(Console.ReadLine());
            //ort = v1 * 0.2 + v2 * 0.2 + f * 0.6;
            //Console.WriteLine($"ortalamanız={ort}");
            //if (ort<45)
            //{
            //    Console.WriteLine("harf notunuz=F");
            //}
            //else if (ort>=45 && ort<55)
            //{
            //    Console.WriteLine("harf notunuz=D");
            //}
            //else if (ort >= 55 && ort < 70)
            //{
            //    Console.WriteLine("harf notunuz=C");
            //}
            //else if (ort >= 70 && ort < 85)
            //{
            //    Console.WriteLine("harf notunuz=B");
            //}
            //else
            //{
            //    Console.WriteLine("harf notunuz=A");
            //}
            #endregion
            #region 4 işlem yaptırılacak
            //string c= "çarpma";
            //string t = "toplama";
            //string cıkarma = "çıkarma";
            //string b = "bölme";
            //Console.WriteLine("yapmak istediğiniz işlemi seçin");
            //string secim=Console.ReadLine();
            //double x=Convert.ToDouble(Console.ReadLine());
            //double y=Convert.ToDouble(Console.ReadLine());
            //if (secim==c)
            //{
            //    Console.WriteLine($"çarpma işlemi sonucu={x*y}");
            //}
            //else if (secim == t)
            //{
            //    Console.WriteLine($"toplama işlemi sonucu={x + y}");
            //}
            //else if (secim == cıkarma)
            //{
            //    Console.WriteLine($"çıkarma işlemi sonucu={x - y}");
            //}
            //else if (secim == b)
            //{
            //    Console.WriteLine($"toplama işlemi sonucu={x / y}");
            //}
            //else
            //    Console.WriteLine("lütfen bir değer seçiniz...");
            #endregion
            #region banknot uygulaması
            //Console.WriteLine("lütfen çekmek istediğiniz miktarı giriniz=");
            //int cekilecek=Convert.ToInt32(Console.ReadLine());
            //int ikiyuzluk=cekilecek/200;
            //int yuzluk = (cekilecek - ikiyuzluk*200) / 100;
            //int elli = (cekilecek - ikiyuzluk*200 - yuzluk*100) / 50;
            //int onluk = (cekilecek - ikiyuzluk * 200 - yuzluk*100-elli * 50) /10;
            //int birlik = (cekilecek - ikiyuzluk*200 - yuzluk*100 - elli*50 - onluk*10);
            //Console.WriteLine($"ikiyüzlük adedi={ikiyuzluk}\nyüzlük adedi={yuzluk}\nellilik adedi={elli}\nonluk adedi={onluk}\nbirlik adedi={birlik}");


            #endregion
            #region banknot uygulması2
            //Console.Write("tutar giriniz: ");
            //int s1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(((s1 - (s1 % 200)) / 200) + "adet 200 lük");
            //Console.WriteLine((((s1 - (s1 % 100)) / 100) % 2) + "adet 100 lük");
            //Console.WriteLine((((s1 % 100) - (s1 % 50)) / 50) + "adet 50 lik");
            //Console.WriteLine(((s1 % 50) / 20) + "adet 20 lik");
            //Console.WriteLine(((s1 % 50) / 30) + "adet 10 luk");
            //Console.ReadLine(); 
            #endregion
            #region tekmi çiftmi
            //Console.WriteLine("bir sayı giriniz=");
            //double x=Convert.ToInt32(Console.ReadLine());
            //if (x%2==0)
            //{
            //    Console.WriteLine($"{x} sayısı çifttir");
            //}
            //else
            //{
            //    Console.WriteLine($"{x} sayısı tektir");
            //}
            #endregion
            #region toupper ve tolower kullanımı
            //Console.WriteLine("bir yazı yazınız...");
            //string metin = Console.ReadLine().ToUpper();//girilen değeri büyük yazar
            //Console.WriteLine("bir yazı yazınız...");
            //string metin1 = Console.ReadLine().ToLower();//girilen değeri küçük yazar
            //Console.WriteLine(metin); 
            #endregion
            #region mevsim girsin ve ayları yazsın
            //Console.WriteLine("lütfen bir mevsim giriniz");
            //string mevsim = Console.ReadLine();
            //if (mevsim.ToLower()=="ilkbahar")
            //{
            //    Console.WriteLine($"{mevsim} ayları mart,nisan,mayıs");
            //}
            //else if (mevsim.ToLower() == "yaz")
            //{
            //    Console.WriteLine($"{mevsim} ayları haziran,temmuz,ağustos");
            //}
            //else if (mevsim.ToLower() == "kış")
            //{
            //    Console.WriteLine($"{mevsim} ayları aralık,ocak,şubat");
            //}
            //else if (mevsim.ToLower() == "sonbahar")
            //{
            //    Console.WriteLine($"{mevsim} ayları eylül,ekim,kasım");
            //}
            //else
            //    Console.WriteLine("lütfen geçerli bir mevsim giriniz...");
            #endregion
            #region km ücret
            /*
             SORU: Kullanıcı taksinin gittiği km yi girecek. Aşağıdaki şartlara göre taksi ücreti hesaplanacak.
                5 km e kadar = 2tl per km
                  12 km e kadar = 1tl per km
                    12 km üstü = 0,5tl per km
             */
            //Console.WriteLine("taksinin km sini giriniz");
            //double km = Convert.ToDouble(Console.ReadLine());
            //if (km <= 5)
            //{
            //    Console.WriteLine($"taksi ücreti={km * 2}");
            //}
            //else if (km > 5 && km <= 12)
            //{
            //    Console.WriteLine($"taksi ücreti={5 * 2 + (km - 5) * 1}");
            //}
            //else
            //    Console.WriteLine($"taksi ücreti={5 * 2 + 7 * 1 + (km - 12) * 0.5}");
            #endregion
            #region yaş soruları

            /*Kadınlar için yaş 5 ten küçükse bebek 10 dan küçükse çocuk  35 ten küçükse genç 55 ten küçükse orta yaşlı diğer türlü emekli
                Kullanıcıdan cinsiyet ve doğum tarihi istenecek Erkekler için  yaş 5 ten küçükse bebek 10 dan küçükse çocuk  25 ten küçükse genç 50 ten küçükse orta yaşlı diğer türlü emekli
             */

            //Console.WriteLine("lütfen cinsiyet seçiniz=");
            //string secim=Console.ReadLine().ToLower();
            //Console.WriteLine("lütfen doğum tarihinizi giriniz=");
            //int doğumt=Convert.ToInt32(Console.ReadLine());
            //int dt = 2023 - doğumt;
            //Console.WriteLine($"yaşı={dt}");
            //if (secim=="kadın")
            //{
            //    if (dt<5)
            //    {
            //        Console.WriteLine("bebek");
            //    }
            //    else if (dt<10)
            //    {
            //        Console.WriteLine("çocuk");
            //    }
            //    else if (dt < 35)
            //    {
            //        Console.WriteLine("genç");
            //    }
            //    else if (dt < 55)
            //    {
            //        Console.WriteLine("yaşlı");
            //    }
            //    else
            //        Console.WriteLine("emekli");
            //}
            //if (secim == "erkek")
            //{
            //    if (dt < 5)
            //    {
            //        Console.WriteLine("bebek");
            //    }
            //    else if (dt < 10)
            //    {
            //        Console.WriteLine("çocuk");
            //    }
            //    else if (dt < 25)
            //    {
            //        Console.WriteLine("genç");
            //    }
            //    else if (dt < 50)
            //    {
            //        Console.WriteLine("orta yaşlı");
            //    }
            //    else
            //        Console.WriteLine("emekli");
            //}
            #endregion
            #region diyet programı
            //Console.WriteLine("lütfen bir mevsim giriniz=");
            //string mevsim = Console.ReadLine().ToLower();
            //Console.WriteLine("kullanıcıdan alınan kilo değeri=");
            //double kilo = Convert.ToDouble(Console.ReadLine());
            //if (mevsim == "kış")
            //{
            //    if (kilo >= 60 && kilo <= 65)
            //    {
            //        Console.WriteLine("kilonuz ideal");
            //    }
            //    else if (kilo > 65)
            //    {
            //        Console.WriteLine($"vermeniz gereken kilo={kilo - 65}");
            //    }
            //    else
            //        Console.WriteLine($"almanız gereken kilo={60 - kilo}");

            //}
            //else if (mevsim == "yaz")//80-85
            //{
            //    if (kilo >= 80 && kilo <= 85)
            //    {
            //        Console.WriteLine("kilonuz ideal");
            //    }
            //    else if (kilo > 85)
            //    {
            //        Console.WriteLine($"vermeniz gereken kilo={kilo - 85}");
            //    }
            //    else
            //        Console.WriteLine($"almanız gereken kilo={80 - kilo}");

            //}
            //else if (mevsim == "bahar")//70-75
            //{
            //    if (kilo >= 70 && kilo <= 75)
            //    {
            //        Console.WriteLine("kilonuz ideal");
            //    }
            //    else if (kilo > 75)
            //    {
            //        Console.WriteLine($"vermeniz gereken kilo={kilo - 75}");
            //    }
            //    else
            //        Console.WriteLine($"almanız gereken kilo={70 - kilo}");

            //}
            //else
            //    Console.WriteLine("lütfen mevsim olarak seçimi düzgün giriniz..."); 
            #endregion
            #region switch case
            //int gun = 0;
            //Console.WriteLine("lütfen bir sayı giriniz=");
            //gun = Convert.ToInt32(Console.ReadLine());

            //switch (gun)
            //{
            //    case 1:
            //        Console.WriteLine("pazar");
            //        break;
            //    case 2:
            //        Console.WriteLine("pazartesi");
            //        break;
            //    default:
            //        break;
            //}

            #endregion
            #region işlem menüsü
            //Console.WriteLine("**************************************************");
            //Console.WriteLine("lütfen yapmak istediğiniz işlemi numarasını seçiniz=\n1-Toplama yap:\n2-Çıkarma yap:\n3-Çarpma yap:\n4-Bölme yap:");
            //Console.WriteLine("**************************************************");
            //int secim = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("lütfen bir sayı giriniz=");
            //double x = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("lütfen bir sayı giriniz=");
            //double y = Convert.ToInt32(Console.ReadLine());
            //switch (secim)
            //{
            //    case 1:
            //        Console.WriteLine($"toplama sonucu={x + y}");
            //        break;
            //    case 2:
            //        Console.WriteLine($"çıkarma sonucu={x - y}");
            //        break;
            //    case 3:
            //        Console.WriteLine($"çarpma sonucu={x * y}");
            //        break;
            //    case 4:
            //        Console.WriteLine($"bölme sonucu={x / y}");
            //        break;

            //    default:
            //        Console.WriteLine("lütfen 1-4 arasında bir sayı giriniz...");
            //        break;

            //}
            //Main(args);

            #endregion
            #region bankamatik

            //    int bakiye = 100000;
            //gel:
            //    Console.WriteLine($"güncel bakiye={bakiye}");
            //    Console.WriteLine("lütfen yapmak istediğiniz işlemi seçiniz=\n1-Para çekme:\n2-Para yatırma:\n3-Havale gönder:\n4-Kart iade:");
            //    int secim = Convert.ToInt32(Console.ReadLine());

            //    switch (secim)
            //    {
            //        case 1:

            //            Console.WriteLine("çekilecek tutarı giriniz=");
            //            int cekilecek = Convert.ToInt32(Console.ReadLine());
            //            Console.WriteLine($"Çekilecek tutar={cekilecek}");
            //            if (bakiye < cekilecek)
            //            {
            //                Console.WriteLine("bakiye çekilecek tutardan küçüktür...");
            //                goto gel;
            //            }
            //            bakiye = bakiye - cekilecek;
            //            Console.WriteLine($"kalan bakiye={bakiye}");
            //            goto gel;
            //            break;
            //        case 2:
            //            Console.WriteLine("yatırılacak tutarı giriniz=");
            //            int yatır = Convert.ToInt32(Console.ReadLine());
            //            Console.WriteLine($"Yatırılacak tutar={yatır}");
            //            bakiye = bakiye + yatır;
            //            Console.WriteLine($"kalan bakiye={bakiye}");
            //            goto gel;
            //            break;
            //        case 3:
            //            Console.WriteLine("havele gönderilecek tutar=");
            //            int havale = Convert.ToInt32(Console.ReadLine());
            //            bakiye = bakiye - havale;
            //            Console.WriteLine($"kalan bakiye={bakiye}");
            //            goto gel;
            //            break;
            //        case 4:
            //            Console.WriteLine("kartınız iade ediliyor...");
            //            break;
            //        default:
            //            Console.WriteLine("lütfen 1-4 arasında bir sayı giriniz...");
            //            break;
            //    }
            #endregion
            #region bankamatikbaşka

            //    byte choice;
            //    int balance = 100000;
            //Menu:
            //    Console.Clear();
            //    Console.WriteLine("Aktif banka hoşgeldiniz");
            //    Console.WriteLine("hangi işlemi yapmak istersiniz");
            //    Console.WriteLine("1-Para çekme");
            //    Console.WriteLine("2-Para Yatırma");
            //    Console.WriteLine("3-Havale gönder");
            //    Console.WriteLine("4-Kart iade");
            //    Console.Write("yapmak istediğiniz işlemi tuşlayın:");
            //    choice = byte.Parse(Console.ReadLine());
            //    if (choice == 1)
            //    {
            //        int get_money;
            //        Console.Clear();
            //    get_money1:
            //        Console.WriteLine($"bakiyeniz:{balance}");
            //        Console.Write("ne kadar para çekme istiyorsunuz:");
            //        get_money = Convert.ToInt32(Console.ReadLine());
            //        if (get_money > balance)
            //        {
            //            Console.Clear();
            //            Console.WriteLine("çekmek istedeiğiniz para miktarı büyük tekrardan bir değer giriniz:");
            //            goto get_money1;
            //        }
            //        balance -= get_money;
            //        Console.WriteLine("lÜTFEN BEKLEYİNİZ....");
            //        System.Threading.Thread.Sleep(1500);
            //        Console.Clear();
            //        Console.WriteLine($"güncel bakiyeniz:{balance}");
            //        byte choice1;
            //        Console.Write("menüye geri dönmek isterseniz 1'e çıkış yapmak isteseniz 2'ye basınız: ");
            //    choice1:
            //        choice1 = byte.Parse(Console.ReadLine());
            //        if (choice1 == 1)
            //        {
            //            Console.WriteLine("lütfen bekleyin...");
            //            System.Threading.Thread.Sleep(1500);
            //            goto Menu;
            //        }
            //        else if (choice1 == 2)
            //            Environment.Exit(0);
            //        else
            //        {
            //            Console.WriteLine("yanlış seçim tekrar tuşa bas");
            //            goto choice1;
            //        }
            //    }


            //    else if (choice == 2)
            //    {
            //        int give_money;
            //        Console.Clear();
            //        Console.WriteLine($"bakiyeniz:{balance}");
            //        Console.Write("ne kadar para yatırmak istiyorsunuz:");
            //        give_money = Convert.ToInt32(Console.ReadLine());

            //        balance += give_money;
            //        Console.WriteLine("lÜTFEN BEKLEYİNİZ....");
            //        System.Threading.Thread.Sleep(1500);
            //        Console.Clear();
            //        Console.WriteLine($"güncel bakiyeniz:{balance}");
            //        byte choice2;
            //        Console.Write("menüye geri dönmek isterseniz 1'e çıkış yapmak isteseniz 2'ye basınız: ");
            //    choice2:
            //        choice2 = byte.Parse(Console.ReadLine());
            //        if (choice2 == 1)
            //        {
            //            Console.WriteLine("lütfen bekleyin...");
            //            System.Threading.Thread.Sleep(1500);
            //            goto Menu;
            //        }
            //        else if (choice2 == 2)
            //            Environment.Exit(0);
            //        else
            //        {
            //            Console.WriteLine("yanlış seçim tekrar tuşa bas");
            //            goto choice2;
            //        }

            //    }

            //    else if (choice == 3)
            //    {
            //        int send_money;
            //        Console.Clear();
            //    send_money1:
            //        Console.WriteLine($"bakiyeniz:{balance}");
            //        Console.Write("ne kadar para göndermek istiyorsunuz:");
            //        send_money = Convert.ToInt32(Console.ReadLine());
            //        if (send_money > balance)
            //        {
            //            Console.Clear();
            //            Console.WriteLine("çekmek istedeiğiniz para miktarı büyük tekrardan bir değer giriniz:");
            //            goto send_money1;
            //        }
            //        Console.Write("kime bu parayı göndermek istiyorsunuz(ad soyad):");
            //        string receiver = Console.ReadLine();
            //        balance -= send_money;
            //        Console.WriteLine("lÜTFEN BEKLEYİNİZ....");
            //        System.Threading.Thread.Sleep(1500);
            //        Console.Clear();
            //        Console.WriteLine($"{receiver} kişisine {send_money} tl gönderildi");
            //        Console.WriteLine($"güncel bakiyeniz:{balance}");
            //        byte choice3;
            //        Console.Write("menüye geri dönmek isterseniz 1'e çıkış yapmak isteseniz 2'ye basınız: ");
            //    choice3:
            //        choice3 = byte.Parse(Console.ReadLine());
            //        if (choice3 == 1)
            //        {
            //            Console.WriteLine("lütfen bekleyin...");
            //            System.Threading.Thread.Sleep(1500);
            //            goto Menu;
            //        }
            //        else if (choice3 == 2)
            //            Environment.Exit(0);
            //        else
            //        {
            //            Console.WriteLine("yanlış seçim tekrar tuşa bas");
            //            goto choice3;
            //        }

            //    }
            //    else if (choice == 4)
            //        Environment.Exit(0);
            //    else
            //    {
            //        Console.WriteLine("yanlış tuşa bastınız");
            //        Console.WriteLine("tekrar deneyiniz");
            //        System.Threading.Thread.Sleep(2000);
            //        goto Menu;
            //    }

            #endregion
            #region randomkullanım
            //Random rnd = new Random();
            //Console.WriteLine(rnd.Next(500));//1.kullanımı
            //Console.WriteLine(rnd.Next(400, 500));//maximumu dahil etmiyor..2.kullanım
            //Console.WriteLine(rnd.Next());//3.kullanım 
            #endregion
            #region random 5000
            //Random rnd = new Random();
            //Console.WriteLine(rnd.Next(5000)); 
            #endregion
            #region zar
            //Random zar = new Random();
            //Console.WriteLine(zar.Next(1, 7)); 
            #endregion
            #region kullanıcıdan alınan iki sayının randomu
            //yeni:
            //Console.WriteLine("lütfen bir sayı giriniz=");
            //int x = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("lütfen bir sayı giriniz=");
            //int y = Convert.ToInt32(Console.ReadLine());
            //Random rnd = new Random();
            //if (x > y)
            //{
            //    Console.WriteLine(rnd.Next(y, x));
            //}
            //else
            //    Console.WriteLine(rnd.Next(x, y));
            //goto yeni;
            #endregion
            #region 500 zar atıldı ve kaçar tane çıktı
            //    //zar var 500 kez atılacak ve kaç tane ne geldiğini gösterecek
            //    Random zar = new Random();

            //    int s = 0;
            //    int s1 = 0, s2 = 0, s3 = 0, s4 = 0, s5 = 0, s6 = 0;
            //g:
            //    if (s < 500)
            //    {
            //        int atılan = zar.Next(1, 7);
            //        s = s + 1;
            //        if (atılan == 1)
            //        {

            //            s1 = s1 + 1;
            //        }
            //        else if (atılan == 2)
            //        {
            //            s2 = s2 + 1;
            //        }
            //        else if (atılan == 3)
            //        {
            //            s3 = s3 + 1;
            //        }
            //        else if (atılan == 4)
            //        {
            //            s4 = s4 + 1;

            //        }
            //        else if (atılan == 5)
            //        {
            //            s5 = s5 + 1;

            //        }
            //        else
            //        {

            //            s6 = s6 + 1;
            //        }


            //        goto g;
            //    }
            //    Console.WriteLine($"s1={s1},s2={s2},s3={s3},s4={s4},s5={s5},s6={s6} toplam={s1 + s2 + s3 + s4 + s5 + s6}");

            #endregion
            #region 10 adet sayıyı goto ile toplatan bi algoritma
            //    int s = 0;
            //    double t = 0;
            //    Random random = new Random();
            //g:
            //    double r = random.Next(58);
            //    if (s < 10)
            //    {
            //        s = s + 1;
            //        Console.WriteLine(r);
            //        t = t + r;
            //        goto g;
            //    }

            //    Console.WriteLine(t); 
            #endregion
            #region kaç kere yazdırılacağı
            //    //kullanıcıdan bi değer al ve bunun kaç defa yazdırması gerektiğini sorgulatan algoritma
            //    Console.WriteLine("lütfen isim giriniz=");
            //    string isim = Console.ReadLine();
            //    Console.WriteLine("kaç kere yazdırmak istersiniz=");
            //    int x = Convert.ToInt32(Console.ReadLine());
            //    int s = 0;
            //g:
            //    if (s < x)
            //    {
            //        s++;
            //        Console.WriteLine($"{s}){isim}");
            //        goto g;
            //    }

            #endregion
            #region geo şekli ve alan hesaplama
            ////Soru: Hesaplamak istediğiniz geometrik şekli seçin. (Üçgen, kare, dikdörtgen). Daha sonra alan bilgileri girilip alan hesaplanacak.
            //g:
            //Console.WriteLine("Hangi şekli seçmek istersiniz=\n1-üçgen\n2-kare\n3-dikdörtgen");
            //int secim=Convert.ToInt32(Console.ReadLine());
            //double alan;
            //switch (secim)
            //{
            //    case 1:
            //        Console.WriteLine("lütfen taban kenarı giriniz=");
            //        int taban=Convert.ToInt32(Console.ReadLine());
            //        Console.WriteLine("lütfen yüksekliği giriniz=");
            //        int yukseklik = Convert.ToInt32(Console.ReadLine());
            //        alan = taban * yukseklik / 2;
            //            Console.WriteLine($"alan={alan}");
            //        goto g;
            //        break;
            //        case 2:
            //        Console.WriteLine("lütfen taban kenarı giriniz=");
            //        int kenar = Convert.ToInt32(Console.ReadLine());
            //        alan = kenar * kenar;
            //        Console.WriteLine($"alan={alan}");
            //        goto g;
            //        break;
            //    case 3:
            //        Console.WriteLine("lütfen kısa kenarı giriniz=");
            //        int kısa = Convert.ToInt32(Console.ReadLine());
            //        Console.WriteLine("lütfen yüksekliği giriniz=");
            //        int uzun = Convert.ToInt32(Console.ReadLine());
            //        alan = kısa * uzun;
            //        Console.WriteLine($"alan={alan}");
            //        goto g;
            //        break;
            //    default:
            //        Console.WriteLine("lütfen geçerli bir seçim yapınız...");
            //        goto g;
            //        break;
            //}
            #endregion
            #region 10 adet random sayı ve bunların 5 e bölünüp bölünemediğinin sayılarını yazdıran program
            //    Random sayi = new Random();
            //    int s = 0, b5 = 0, bm5 = 0;
            //g:
            //    if (s < 10)
            //    {
            //        int sayi1 = sayi.Next(100);
            //        if (sayi1 % 5 == 0)
            //        {
            //            Console.WriteLine("sayı=" + sayi1);
            //            b5++;
            //        }
            //        else
            //        {
            //            Console.WriteLine("sayı=" + sayi1);
            //            bm5++;
            //        }
            //        s++;
            //        goto g;
            //    }
            //    Console.WriteLine($"5 e bölünenlerin sayısı={b5}\n5 e bölünemeyenlerin sayısı={bm5}");
            #endregion
            #region Başlangıç
            //Console.WriteLine("Hello World! I am Ahmet");

            //Console.BackgroundColor = ConsoleColor.Green;
            //Console.WriteLine("Hello World! I am Ahmet");
            //Console.ForegroundColor = ConsoleColor.Blue;   
            //Console.WriteLine("Hello World! I am Ahmet");
            //Console.Beep(659, 125); Console.Beep(659, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(167); Console.Beep(523, 125); Console.Beep(659, 125); Thread.Sleep(125); Console.Beep(784, 125); Thread.Sleep(375); Console.Beep(392, 125); Thread.Sleep(375); Console.Beep(523, 125); Thread.Sleep(250); Console.Beep(392, 125); Thread.Sleep(250); Console.Beep(330, 125); Thread.Sleep(250); Console.Beep(440, 125); Thread.Sleep(125); Console.Beep(494, 125); Thread.Sleep(125); Console.Beep(466, 125); Thread.Sleep(42); Console.Beep(440, 125); Thread.Sleep(125); Console.Beep(392, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(125); Console.Beep(784, 125); Thread.Sleep(125); Console.Beep(880, 125); Thread.Sleep(125); Console.Beep(698, 125); Console.Beep(784, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(125); Console.Beep(523, 125); Thread.Sleep(125); Console.Beep(587, 125); Console.Beep(494, 125); Thread.Sleep(125); Console.Beep(523, 125); Thread.Sleep(250); Console.Beep(392, 125); Thread.Sleep(250); Console.Beep(330, 125); Thread.Sleep(250); Console.Beep(440, 125); Thread.Sleep(125); Console.Beep(494, 125); Thread.Sleep(125); Console.Beep(466, 125); Thread.Sleep(42); Console.Beep(440, 125); Thread.Sleep(125); Console.Beep(392, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(125); Console.Beep(784, 125); Thread.Sleep(125); Console.Beep(880, 125); Thread.Sleep(125); Console.Beep(698, 125); Console.Beep(784, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(125); Console.Beep(523, 125); Thread.Sleep(125); Console.Beep(587, 125); Console.Beep(494, 125); Thread.Sleep(375); Console.Beep(784, 125); Console.Beep(740, 125); Console.Beep(698, 125); Thread.Sleep(42); Console.Beep(622, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(167); Console.Beep(415, 125); Console.Beep(440, 125); Console.Beep(523, 125); Thread.Sleep(125); Console.Beep(440, 125); Console.Beep(523, 125); Console.Beep(587, 125); Thread.Sleep(250); Console.Beep(784, 125); Console.Beep(740, 125); Console.Beep(698, 125); Thread.Sleep(42); Console.Beep(622, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(167); Console.Beep(698, 125); Thread.Sleep(125); Console.Beep(698, 125); Console.Beep(698, 125); Thread.Sleep(625); Console.Beep(784, 125); Console.Beep(740, 125); Console.Beep(698, 125); Thread.Sleep(42); Console.Beep(622, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(167); Console.Beep(415, 125); Console.Beep(440, 125); Console.Beep(523, 125); Thread.Sleep(125); Console.Beep(440, 125); Console.Beep(523, 125); Console.Beep(587, 125); Thread.Sleep(250); Console.Beep(622, 125); Thread.Sleep(250); Console.Beep(587, 125); Thread.Sleep(250); Console.Beep(523, 125); Thread.Sleep(1125); Console.Beep(784, 125); Console.Beep(740, 125); Console.Beep(698, 125); Thread.Sleep(42); Console.Beep(622, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(167); Console.Beep(415, 125); Console.Beep(440, 125); Console.Beep(523, 125); Thread.Sleep(125); Console.Beep(440, 125); Console.Beep(523, 125); Console.Beep(587, 125); Thread.Sleep(250); Console.Beep(784, 125); Console.Beep(740, 125); Console.Beep(698, 125); Thread.Sleep(42); Console.Beep(622, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(167); Console.Beep(698, 125); Thread.Sleep(125); Console.Beep(698, 125); Console.Beep(698, 125); Thread.Sleep(625); Console.Beep(784, 125); Console.Beep(740, 125); Console.Beep(698, 125); Thread.Sleep(42); Console.Beep(622, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(167); Console.Beep(415, 125); Console.Beep(440, 125); Console.Beep(523, 125); Thread.Sleep(125); Console.Beep(440, 125); Console.Beep(523, 125); Console.Beep(587, 125); Thread.Sleep(250); Console.Beep(622, 125); Thread.Sleep(250); Console.Beep(587, 125); Thread.Sleep(250); Console.Beep(523, 125);
            //Console.Read(); 

            //Console.WriteLine("İsnize giriniz");

            //string a = Console.ReadLine(); 

            //Console.WriteLine("Kullanıcı :" + a);

            //Console.ReadKey();
            //Console.WriteLine("Bir sayı giriniz");
            //int a1 = Convert.ToInt32(Console.ReadLine());
            //int b1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(a1 + b1);
            //Console.Read();

            //byte a = 5;
            //short b = 6;
            //sbyte c = 4;
            //int d = a + b + c;


            //char f = 'k';

            //string e = "deneme";
            //object g =d+ e + f + d;

            //Console.WriteLine(g);

            //Console.ReadLine();
            //


            //Console.Write("a değerini giriniz : ");
            //int a =Convert.ToInt32(Console.ReadLine());

            //Console.Write("b değerini giriniz : ");
            //int b= Convert.ToInt32(Console.ReadLine());

            //Console.Write("c değerini giriniz : ");
            //int c = Convert.ToInt32(Console.ReadLine());

            //int g = b * b - 4 * a * c;

            //Console.WriteLine("Diskriminantı : " + g );
            #endregion
            #region Not geçme algoritması
            //double vize, final, not;

            //Console.WriteLine("Vize notu : ");
            //vize = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Final notu : ");
            //final = Convert.ToInt32(Console.ReadLine());

            //not = (vize*40 / 100) + (final*60 / 100);

            //if (not>50)
            //{
            //    Console.WriteLine("Dersi geçtiniz ");
            //}
            //else
            //{
            //    Console.WriteLine("Dersten kaldınız");
            //}

            #endregion
            #region Çarpım toplama çıkarma bölme
            //int a, b;
            //string c;
            //Console.WriteLine("Bir sayı giriniz :");
            //a = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Bir sayı giriniz :");
            //b = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Çarpım için 1 yazınız");

            //Console.WriteLine("Bölme için 2 yazınız");

            //Console.WriteLine("Çıkarma için 3 yazınız");

            //Console.WriteLine("Toplama için 4 yazınız");

            //c = Console.ReadLine();

            //if (c == "1")
            //{

            //    Console.WriteLine("Çarpım Sonucu : " + a*b);
            //}
            //else if (c == "2")
            //{

            //    Console.WriteLine("Bölme Sonucu : " + (a / b));
            //}
            //else if (c == "3")
            //{

            //    Console.WriteLine("Çıkarma Sonucu : " + (a - b));
            //}
            //else if (c == "4")
            //{

            //    Console.WriteLine("Toplama Sonucu : " + (a + b));
            //}

            #endregion
            #region Bir sayının tek ya da çift olduğunu veren algoritma
            //Console.WriteLine("Bir sayı ver :");

            //int a = Convert.ToInt32(Console.ReadLine());

            //if (a % 2 == 0)
            //{
            //    Console.WriteLine(" Sayı çift " + a);
            //}
            //else
            //{
            //    Console.WriteLine(" Sayı tek " + a);
            //}
            #endregion
            #region Bir mevsim giriniz ve girilen mevsimin ayları versin
            //Console.WriteLine("Bir mevsim giriniz ");

            //string a = Console.ReadLine().ToUpper();

            //if (a == "KIŞ")
            //{
            //    Console.WriteLine("Aralık, Ocak, Şubat");
            //}
            //else if (a == "İLKBAHAR")
            //{
            //    Console.WriteLine("Mart, Nisan, Mayıs");
            //}
            //else if (a == "YAZ")
            //{
            //    Console.WriteLine("Haziran, Temmuz, Ağustos");

            //}
            //else if (a == "SONBAHAR")
            //{
            //    Console.WriteLine("Eylül, Ekim, Kasım");
            //}
            //else
            //{
            //    Console.WriteLine("Uygun bir metin yazınız...");
            //}
            #endregion
            #region Kullanıcı taksinin gittiği km yi girecek. Aşağıdaki şartlara göre taksi ücreti hesaplanacak.
            //5 km e kadar = 2tl per km
            //12 km e kadar = 1tl per km
            //12 km üstü = 0,5tl per km
            //Ece Hız20: 53
            //Console.Write("Gittiğiniz km uzunluğunu giriniz: ");
            //            int km = Convert.ToInt32(Console.ReadLine());

            //            double ucret;

            //            if (km <= 5)
            //            {
            //                ucret = km * 2;
            //            }
            //            else if (km <= 12)
            //            {
            //                ucret = 5 * 2 + (km - 5) * 1;
            //            }
            //            else
            //            {
            //                ucret = 5 * 2 + 7 * 1 + (km - 12) * 0.5;
            //            }
            //            Console.WriteLine("Taksi ücreti: " + ucret);
            #endregion
            #region Kadınlar için yaş 5 ten küçükse bebek 10 dan küçükse çocuk  35 ten küçükse genç 55 ten küçükse orta yaşlı diğer türlü emekli
            //Kadınlar için yaş 5 ten küçükse bebek 10 dan küçükse çocuk  35 ten küçükse genç 55 ten küçükse orta yaşlı diğer türlü emekli
            //Kullanıcıdan cinsiyet ve doğum tarihi istenecek Erkekler için yaş 5 ten küçükse bebek 10 dan küçükse çocuk  25 ten küçükse genç 50 ten küçükse orta yaşlı diğer türlü emekli         }

            // Console.WriteLine("Cinsiyeti nedir :");
            // string cinsiyet = Console.ReadLine().ToUpper();
            // Console.WriteLine("Doğum tarihiniz nedir :");
            // int yas = Convert.ToInt32(Console.ReadLine());

            // yas = 2023 - yas;

            //if(cinsiyet == "KADIN")
            // {
            //     if (yas <= 5)
            //     {
            //         Console.WriteLine("Bebek : " + cinsiyet + " " + yas);
            //     }
            //     else if (yas>5 && yas<=35)
            //     {
            //         Console.WriteLine("Genç : " + cinsiyet+" " + yas);
            //     }
            //     else if (yas > 35 && yas <= 55)
            //     {
            //         Console.WriteLine("Orta yaş : " + cinsiyet + " " + yas);
            //     }
            //     else { Console.WriteLine("Emekli : " + cinsiyet + " " + yas); }

            // }
            // if (cinsiyet == "ERKEK")
            // {
            //     if (yas <= 5)
            //     {
            //         Console.WriteLine("Bebek : " + cinsiyet + " " + yas);
            //     }
            //     else if (yas > 5 && yas <= 25)
            //     {
            //         Console.WriteLine("Genç : " + cinsiyet + " " + yas);
            //     }
            //     else if (yas > 25 && yas <= 55)
            //     {
            //         Console.WriteLine("Orta yaş : " + cinsiyet + " " + yas);
            //     }
            //     else { Console.WriteLine("Emekli : " + cinsiyet + " " + yas); }

            // }
            #endregion
            #region Verilen bir para miktarını 200,100,50,20,10 tl cinsinden sonuç veren algoritma
            //    Console.WriteLine("Para miktarına girniz ");

            //    int miktar = Convert.ToInt32(Console.ReadLine());

            //    int tl200, tl100, tl50, tl20, tl10, tl5, tl1;

            //    tl200 = miktar / 200;

            //    miktar = miktar % 200;

            //    tl100 = miktar / 100;

            //    miktar = miktar % 100;

            //    tl50 = miktar / 50;

            //    miktar = miktar % 50;

            //    tl20 = miktar / 20;
            //    miktar = miktar % 20;

            //    tl10 = miktar / 10;
            //    miktar = miktar % 10;
            //    tl5 = miktar / 5;
            //    miktar = miktar % 5;
            //    tl1 = miktar;

            //    Console.WriteLine(" {0} tane 200 \n {1} tane 100 \n {2} tane 50 \n {3} tane 20 \n {4} tane 10 \n {5} tane 5 \n {6} tane 1 \n", tl200, tl100, tl50, tl20, tl10, tl5, tl1);


            //    Console.Read();
            #endregion
            #region 2. çözüm verilen bir para miktarını 200,100,50,20,10 tl cinsinden sonuç veren algoritma

            //adet200 = para / 200;
            //para = para % 200;
            //adet100 = para / 100;
            //para = para % 100;
            //adet50 = para / 50;
            //para = para % 50;
            //adet20 = para / 20;
            //para = para % 20;

            //Console.WriteLine("200LUK ADET" + adet200 + "\n100LUK ADET");

            //Console.WriteLine("Başka bir çözüm*************");

            //Console.Write("tutar giriniz: ");
            //int s1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(((s1 - (s1 % 200)) / 200) + "adet 200 lük");
            //Console.WriteLine((((s1 - (s1 % 100)) / 100) % 2) + "adet 100 lük");
            //Console.WriteLine((((s1 % 100) - (s1 % 50)) / 50) + "adet 50 lik");
            //Console.WriteLine(((s1 % 50) / 20) + "adet 20 lik");
            //Console.WriteLine(((s1 % 50) / 30) + "adet 10 luk");
            //Console.ReadLine();

            #endregion
            #region Mevsime bağlı olarak uygulanan hayali ve ters bir diyet programında
            /*
            Mevsime bağlı olarak uygulanan hayali ve ters bir diyet programında aşağıdaki şartlara bağlı olarak mesaj veren iç içe if sorguları yazın.

            - Bahar mevsimi ise:
            --kişi 70 ile 75 kilo arasında olmalıdır

            - Yaz mevsimi ise:
            --kişi 80 ile 85 kilo arasında olmalıdır
            - Kış mevsimi ise: (diğer mevsimler de diyebiliriz)

            --kişi 60 ile 65 kilo arasında olmalıdır
            Mevsime bağlı olarak uygulanan hayali ve ters bir diyet programında aşağıdaki şartlara bağlı olarak mesaj veren iç içe if sorguları
            Bahar mevsimi ise:

            --kişi 70 ile 75 kilo arasında olmalıdır
            */

            //Console.WriteLine("Mevsim giriniz ");

            //string mevsim = Console.ReadLine().ToUpper();

            //Console.WriteLine("Kilonuzu giriniz: ");

            //int kilo = Convert.ToInt32(Console.ReadLine()); 

            //if(mevsim == "BAHAR" || mevsim == "İLKBAHAR" || mevsim == "SONBAHAR")
            //{
            //    if (kilo>=70 && kilo<=75)
            //    {
            //        Console.WriteLine("Tebrikler bahar mevsiminde ideal kilondasın...");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Kilo almalısın ya da kilo vermelisin...");
            //    }
            //}
            //if (mevsim == "YAZ")
            //{
            //    if (kilo >= 80 && kilo <= 85)
            //    {
            //        Console.WriteLine("Tebrikler yaz mevsiminde ideal kilondasın...");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Kilo almalısın ya da kilo vermelisin...");
            //    }
            //}
            //if (mevsim == "KIŞ" || mevsim == "KIS")
            //{
            //    if (kilo >= 60 && kilo <= 65)
            //    {
            //        Console.WriteLine("Tebrikler Kış mevsiminde ideal kilondasın...");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Kilo almalısın ya da kilo vermelisin...");
            //    }
            //}
            #endregion
            #region Switch-case ile Dört işlem
            //Console.WriteLine("Hesaplanacak 1. sayı");

            //int sayi1 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Hesaplanacak 2. sayı");

            //int sayi2 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine(" Toplam için: 1 \n Çıkarma için: 2 \n Çarpma için: 3\n Bölme için: 4\n");

            //int islem = Convert.ToInt32(Console.ReadLine());

            //switch (islem)
            //{
            //    case 1:
            //        Console.WriteLine("Toplam:  " + (sayi1 + sayi2));
            //        break;
            //    case 2:
            //        Console.WriteLine("Çıkarma:  " + (sayi1 - sayi2));
            //        break;
            //    case 3:
            //        Console.WriteLine("Çarpma:  " + (sayi1 * sayi2));
            //        break;
            //    case 4:
            //        Console.WriteLine("Bölme:  " + (sayi1 / sayi2));
            //        break;
            //    default:
            //        Console.WriteLine("Geçerli bir sayı giriniz");
            //        break;
            //}
            #endregion
            #region Bir arabanın kırmızı ışıkta geçme algoritması
            //Console.WriteLine(" Kırmızı için 1\n Sarı için 2\n Yeşil için 3\n");
            //int isik = Convert.ToInt32( Console.ReadLine() );

            //switch (isik)
            //{
            //    case 1:
            //        Console.WriteLine("Kırmızı ışık yandı ");
            //        break;
            //    case 2:
            //        Console.WriteLine("Sarı ışık yandı ");
            //        break;
            //    case 3:
            //        Console.WriteLine("Yeşil ışık yandı ");
            //        break;
            //    default:
            //        Console.WriteLine("Geçerli bir değer giriniz ");
            //        break;
            //}
            #endregion
            #region bankamatik1

            //    int bakiye = 100000;
            //    int miktar = 0;

            //git:
            //    Console.WriteLine(bakiye);
            //    Console.WriteLine("İşlem seçiniz");
            //    Console.WriteLine(" Para Çekmek İçin 1\n Para Yatırmak için 2\n Havale Gönder İçin 3\n Kart İade içi 4\n");
            //    int islem = Convert.ToInt32(Console.ReadLine());

            //    switch (islem)
            //    {
            //        case 1:
            //            Console.WriteLine("Çekmek istediğiniz miktarı giriniz ");
            //            miktar = Convert.ToInt32(Console.ReadLine());
            //            Console.WriteLine($"{miktar} miktar para çekildi");
            //            Console.WriteLine("Yeni Bakiye :" + (bakiye - miktar));
            //            goto a1;
            //            break;
            //        case 2:
            //            Console.WriteLine("Yatırmak istediğiniz miktarı giriniz. ");
            //            miktar = Convert.ToInt32(Console.ReadLine());
            //            Console.WriteLine($"{miktar} miktar para yatırıldı");
            //            Console.WriteLine("Yeni Bakiye :" + (bakiye + miktar));
            //            goto a1;
            //            break;
            //        case 3:
            //            Console.WriteLine("Havale etmek istediğiniz miktarı giriniz ");
            //            miktar = Convert.ToInt32(Console.ReadLine());
            //            Console.WriteLine($"{miktar} miktar para havale edildi");
            //            Console.WriteLine("Yeni Bakiye :" + (bakiye - miktar));
            //            goto a1;
            //            break;
            //        case 4:
            //        a1:
            //            Console.WriteLine("Başka bir işlem yapmak istiyorsanız 1'e basınız ");
            //            int a = Convert.ToInt32(Console.ReadLine());
            //            if (a == 1)
            //            {
            //                goto git;
            //            }
            //            Console.WriteLine("Kartınız iade edildi....");
            //            break;
            //        default:
            //            Console.WriteLine("Geçerli bir işlem giriniz..");
            //            break;
            //    } 
            #endregion
            #region bankamatik
            //bankamatik uygulaması
            //    byte choice;
            //    int balance = 100000;
            //Menu:
            //    Console.Clear();
            //    Console.WriteLine("Aktif banka hoşgeldiniz");
            //    Console.WriteLine("hangi işlemi yapmak istersiniz");
            //    Console.WriteLine("1-Para çekme");
            //    Console.WriteLine("2-Para Yatırma");
            //    Console.WriteLine("3-Havale gönder");
            //    Console.WriteLine("4-Kart iade");
            //    Console.Write("yapmak istediğiniz işlemi tuşlayın:");
            //    choice = byte.Parse(Console.ReadLine());
            //    if (choice == 1)
            //    {
            //        int get_money;
            //        Console.Clear();
            //    get_money1:
            //        Console.WriteLine($"bakiyeniz:{balance}");
            //        Console.Write("ne kadar para çekme istiyorsunuz:");
            //        get_money = Convert.ToInt32(Console.ReadLine());
            //        if (get_money > balance)
            //        {
            //            Console.Clear();
            //            Console.WriteLine("çekmek istedeiğiniz para miktarı büyük tekrardan bir değer giriniz:");
            //            goto get_money1;
            //        }
            //        balance -= get_money;
            //        Console.WriteLine("lÜTFEN BEKLEYİNİZ....");
            //        System.Threading.Thread.Sleep(1500);
            //        Console.Clear();
            //        Console.WriteLine($"güncel bakiyeniz:{balance}");
            //        byte choice1;
            //        Console.Write("menüye geri dönmek isterseniz 1'e çıkış yapmak isteseniz 2'ye basınız: ");
            //    choice1:
            //        choice1 = byte.Parse(Console.ReadLine());
            //        if (choice1 == 1)
            //        {
            //            Console.WriteLine("lütfen bekleyin...");
            //            System.Threading.Thread.Sleep(1500);
            //            goto Menu;
            //        }
            //        else if (choice1 == 2)
            //            Environment.Exit(0);
            //        else
            //        {
            //            Console.WriteLine("yanlış seçim tekrar tuşa bas");
            //            goto choice1;
            //        }
            //    }


            //    else if (choice == 2)
            //    {
            //        int give_money;
            //        Console.Clear();
            //        Console.WriteLine($"bakiyeniz:{balance}");
            //        Console.Write("ne kadar para yatırmak istiyorsunuz:");
            //        give_money = Convert.ToInt32(Console.ReadLine());

            //        balance += give_money;
            //        Console.WriteLine("lÜTFEN BEKLEYİNİZ....");
            //        System.Threading.Thread.Sleep(1500);
            //        Console.Clear();
            //        Console.WriteLine($"güncel bakiyeniz:{balance}");
            //        byte choice2;
            //        Console.Write("menüye geri dönmek isterseniz 1'e çıkış yapmak isteseniz 2'ye basınız: ");
            //    choice2:
            //        choice2 = byte.Parse(Console.ReadLine());
            //        if (choice2 == 1)
            //        {
            //            Console.WriteLine("lütfen bekleyin...");
            //            System.Threading.Thread.Sleep(1500);
            //            goto Menu;
            //        }
            //        else if (choice2 == 2)
            //            Environment.Exit(0);
            //        else
            //        {
            //            Console.WriteLine("yanlış seçim tekrar tuşa bas");
            //            goto choice2;
            //        }

            //    }

            //    else if (choice == 3)
            //    {
            //        int send_money;
            //        Console.Clear();
            //    send_money1:
            //        Console.WriteLine($"bakiyeniz:{balance}");
            //        Console.Write("ne kadar para göndermek istiyorsunuz:");
            //        send_money = Convert.ToInt32(Console.ReadLine());
            //        if (send_money > balance)
            //        {
            //            Console.Clear();
            //            Console.WriteLine("çekmek istedeiğiniz para miktarı büyük tekrardan bir değer giriniz:");
            //            goto send_money1;
            //        }
            //        Console.Write("kime bu parayı göndermek istiyorsunuz(ad soyad):");
            //        string receiver = Console.ReadLine();
            //        balance -= send_money;
            //        Console.WriteLine("lÜTFEN BEKLEYİNİZ....");
            //        System.Threading.Thread.Sleep(1500);
            //        Console.Clear();
            //        Console.WriteLine($"{receiver} kişisine {send_money} tl gönderildi");
            //        Console.WriteLine($"güncel bakiyeniz:{balance}");
            //        byte choice3;
            //        Console.Write("menüye geri dönmek isterseniz 1'e çıkış yapmak isteseniz 2'ye basınız: ");
            //    choice3:
            //        choice3 = byte.Parse(Console.ReadLine());
            //        if (choice3 == 1)
            //        {
            //            Console.WriteLine("lütfen bekleyin...");
            //            System.Threading.Thread.Sleep(1500);
            //            goto Menu;
            //        }
            //        else if (choice3 == 2)
            //            Environment.Exit(0);
            //        else
            //        {
            //            Console.WriteLine("yanlış seçim tekrar tuşa bas");
            //            goto choice3;
            //        }

            //    }
            //    else if (choice == 4)
            //        Environment.Exit(0);
            //    else
            //    {
            //        Console.WriteLine("yanlış tuşa bastınız");
            //        Console.WriteLine("tekrar deneyiniz");
            //        System.Threading.Thread.Sleep(2000);
            //        goto Menu;
            //    }

            #endregion
            #region random

            //git:
            //    //Random rnd = new  Random();
            //    //Console.WriteLine(rnd.Next(1,7));
            //    Console.WriteLine("İki değer ver...");

            //    Console.WriteLine("ALt limit");
            //    int sayi1 = Convert.ToInt32(Console.ReadLine());

            //    Console.WriteLine("Üst Limit");
            //    int sayi2 = Convert.ToInt32(Console.ReadLine());

            //    Random random = new Random();

            //    Console.WriteLine("Rastgele bir sayı seçiliyor");
            //    Console.WriteLine(random.Next(sayi1, sayi2));

            //    goto git;  
            #endregion
            #region üretilen değer
            //    int sayac = 0;
            //    int deger = 0;
            //    int toplam = 0;
            //    Console.WriteLine("başla");

            //    Random random = new Random();

            //git:

            //    if (sayac < 10)
            //    {
            //        deger = random.Next(10, 20);

            //        Console.WriteLine("Üretilen sayı " + deger);

            //        sayac = sayac + 1;

            //        toplam = toplam + deger;
            //        goto git;
            //    }
            //    Console.WriteLine("toplam :" +toplam);
            #endregion
            #region 500 defa zar atılıyor random olarak kaç defa 1,2,3,4,5,6 gelir
            //    int sayac = 0;
            //    int deger = 0;
            //    int toplam = 0;

            //    int bir= 0, iki=0, uc=0, dort=0, bes=0, alti=0;
            //    Console.WriteLine("başla");

            //    Random random = new Random();

            //git:

            //    if (sayac < 500)
            //    {
            //        deger = random.Next(1, 7);

            //        Console.WriteLine("Üretilen sayı " + deger);            

            //        switch (deger)
            //        {
            //            case 1:
            //                bir = bir + 1;           
            //                break;
            //            case 2:
            //                iki = iki +1;
            //                break;
            //            case 3:
            //                uc = uc + 1;
            //                break;
            //            case 4:
            //                dort = dort + 1;
            //                break;
            //            case 5:
            //                bes = bes + 1;
            //                break;
            //            case 6:
            //                alti = alti + 1;
            //                break;
            //        }
            //        sayac = sayac + 1;
            //        goto git;
            //    }

            //    Console.WriteLine("******************** \n"+
            //        "{0} tane bir geldi \n" +
            //        "{1} tane iki geldi \n" +
            //        "{2} tane üç geldi \n" +
            //        "{3} tane dört geldi \n" +
            //        "{4} tane beş geldi \n" +
            //        "{5} tane altı geldi \n"
            //        , bir,iki,uc,dort,bes,alti);  
            #endregion
            #region Tekrar metni
            //Console.WriteLine("Başla");

            //int s = 0;

            //Console.WriteLine("Metni yaz ");

            //string metin = Console.ReadLine();

            //Console.WriteLine( "Kaç defa yazdılırsın");

            //int deger = Convert.ToInt32(Console.ReadLine());

            //git:

            //if ( s<deger)
            //{
            //    Console.WriteLine(metin);
            //    s = s + 1;
            //    goto git;
            //} 
            #endregion
            #region Kare, dikdörtgen ve üçgenin alanını veren algoritma
            //git:

            //    Console.WriteLine("Başla....");
            //    Console.WriteLine("Bir şekil seçiniz");
            //    Console.WriteLine(" Üçgen için 1\n Kare için 2\n Dikdörtgen için 3\n");

            //    int deger = Convert.ToInt32(Console.ReadLine());


            //    switch (deger)
            //    {
            //        case 1:
            //            Console.WriteLine("Üçgenin yüksekliğine giriniz");
            //            int yukseklik = Convert.ToInt32(Console.ReadLine());
            //            Console.WriteLine("Üçgenin tabanına giriniz");
            //            int taban = Convert.ToInt32(Console.ReadLine());
            //            Console.WriteLine("Üçgenin Alanı : " + (taban*yukseklik)/2);
            //            break;
            //        case 2:
            //            Console.WriteLine("Karenin bir kenarını giriniz");
            //            int kare_kenar = Convert.ToInt32(Console.ReadLine());

            //            Console.WriteLine("Karenin Alanı : " + kare_kenar*kare_kenar);
            //            break;
            //        case 3:
            //            Console.WriteLine("Diktörtgen kısa kenarını giriniz");
            //            int kisa_kenar = Convert.ToInt32(Console.ReadLine());
            //            Console.WriteLine("Diktörtgen uzun kenarını giriniz");
            //            int uzun_kenar = Convert.ToInt32(Console.ReadLine());
            //            Console.WriteLine("Diktörtgenin Alanı : " + kisa_kenar*uzun_kenar);
            //            break;
            //        default:
            //            Console.WriteLine("Geçerli bir değer giriniz");
            //            break;
            //    }

            //    goto git; 
            #endregion
            #region verilen 10 tane random sayıdan 5 bölünenleri veren algoritma
            //    Console.WriteLine("Başla");
            //    int s = 0;
            //    Random rnd = new Random();
            //git:

            //    if (s < 10)
            //    {
            //        int deger = rnd.Next(500);
            //        if (deger % 5 == 0)
            //        {
            //            Console.WriteLine("Bu sayı 5'e bölünüyor...: " + deger);
            //        }
            //        else
            //        {
            //            Console.WriteLine("Bu sayı bölünmüyor......: " + deger);
            //        }
            //        s = s + 1;

            //        goto git;
            //    }
            #endregion
            #region bilgi

            //git:
            //    Console.WriteLine("Bilgi veriniz");

            //    string bilgi = Console.ReadLine();


            //    for (int i = 0; i < 5; i++)
            //    {

            //        Console.WriteLine(bilgi);

            //    }
            //    goto git;
            //    Console.ReadLine(); 
            #endregion
            #region FOR

            //for (int i = 'A'; i < 'Z'; i++)
            //   {

            //   Console.WriteLine(i);

            // } 
            #endregion
            #region MOD FOR
            //int sayi1 = 0, sayi2=0;

            //Console.WriteLine("İlk sayı küçük olan");
            //sayi1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("İkinci sayı büyük olan");
            //sayi2 = Convert.ToInt32(Console.ReadLine());

            //for ( ; sayi1 < sayi2; sayi1++)
            //{
            //    if (sayi1%2 == 1)
            //    {
            //        Console.WriteLine(sayi1);
            //    } 
            #endregion
            #region +=i
            //int sayi = 0;

            //for (int i = 0; i < 10; i++)
            //{
            //  //  sayi = sayi + i;

            //    sayi += i;

            //    Console.WriteLine(sayi);
            //}
            //Console.WriteLine("*************************");

            //Console.WriteLine(sayi); 
            #endregion
            #region MyRegion

            //int sayi1 = 0, sayi2 = 0,Toplam=0, sayac=0;

            //Console.WriteLine("İlk sayı küçük olan");
            //sayi1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("İkinci sayı büyük olan");
            //sayi2 = Convert.ToInt32(Console.ReadLine());
            ////for (int i = sayi1; i < sayi2; i++)
            ////{
            ////    if (sayi1 % 2 == 0)
            ////    {
            ////        Toplam += sayi1;
            ////        sayac = sayac + 1;
            ////    }
            ////}
            //for (; sayi1 < sayi2; sayi1++)
            //{
            //    if (sayi1 % 2 == 0)
            //    {
            //        Toplam += sayi1;
            //        sayac = sayac + 1;
            //    }            
            //}
            //Console.WriteLine("******************");
            //Console.WriteLine(Toplam/sayac); 
            #endregion
            #region Girilen sayıların son rakamı 5 ve 5 den büyük olan
            //int sayi1 = 0, sayi2 = 0, Toplam = 0, sayac = 0;

            //Console.WriteLine("İlk sayı küçük olan");
            //sayi1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("İkinci sayı büyük olan");
            //sayi2 = Convert.ToInt32(Console.ReadLine());

            //for (int i = sayi1; sayi1 < sayi2; sayi1++)
            //{
            //    if (sayi1 % 10 == 5)
            //    {
            //        if(sayi1 >5) 
            //        {
            //            Toplam += sayi1;
            //            sayac += 1;

            //        }

            //    }
            //}

            //Console.WriteLine("******************");
            //Console.WriteLine(Toplam / sayac);
            #endregion
            #region MyRegion
            //int enBuyukSayi = 0,enKucukSayi=0, sayi=0;

            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine("Sayı ver");
            //    sayi = Convert.ToInt32(Console.ReadLine());

            //    if (sayi< enKucukSayi)
            //    {
            //        enBuyukSayi = sayi;             

            //    }
            //    else if (sayi>e)
            //    {
            //        enBuyukSayi
            //    }
            // } 
            #endregion
            #region teklerin küpü çiftlerin karesi

            //int number_1, number_2;
            //int joker;
            //Console.Write("bir sayı gir:");
            //number_1 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("bir sayı gir:");
            //number_2 = Convert.ToInt32(Console.ReadLine());

            //int even_pieces = 0, odd_pieces = 0;
            //int even_square = 0, odd_cube = 0;

            //if (number_1 > number_2)
            //{
            //    joker = number_2;
            //    number_2 = number_1;
            //    number_1 = joker;
            //}
            //for (int i = number_1; i <= number_2; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        even_pieces++;
            //        even_square += i * i;
            //    }
            //    else
            //    {
            //        odd_pieces++;
            //        odd_cube += i * i * i;
            //    }
            //}
            //Console.WriteLine($"çift adedi:{even_pieces} çiftlerin karesi toplam:{even_square}\n" +
            //    $"tek adedi:{odd_pieces} teklerin küpü toplam:{odd_cube}");

            #endregion
            #region MyRegion
            //int karesi = 1, kupu = 1;
            //Console.WriteLine("Büyük sayi ");
            //int sayi1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Küçük sayı ");
            //int sayi2 = Convert.ToInt32(Console.ReadLine());

            //for (int i = sayi1; i < sayi2; i++)
            //{
            //    if (sayi1 % 2 == 0)
            //    {
            //        kupu = sayi1 * sayi1 * sayi1;
            //    }
            //    else
            //    {
            //        karesi = sayi1 * sayi1;
            //    }
            //}
            //Console.WriteLine("Çift sayıları küpü {0} \n" +
            //    "Tek sayıların karesi {1}", kupu, karesi); 
            #endregion
            #region MyRegion

            //int bir = 0, iki =0, uc=0,dort=0,bes=0,alti=0;

            //Random random = new Random();
            //for (int i = 0; i < 1000; i++)
            //{

            // int deger = random.Next(1,7);

            //    switch (deger)
            //    {
            //        case 1:
            //            bir = bir + 1;
            //             break;
            //        case 2:
            //            iki = iki + 1;
            //            break;
            //        case 3:
            //            uc = uc + 1;
            //            break;
            //        case 4:
            //            dort = dort + 1;
            //            break;
            //        case 5:
            //            bes = bes + 1;
            //            break;
            //        case 6:
            //            bir = bir + 1;
            //            break;
            //        default:
            //            break;
            //    }

            //} 
            #endregion
            #region MyRegion
            //int bir = 0, iki = 0, uc = 0, dort = 0, bes = 0, alti = 0;
            //Random random= new Random();
            //for (int i = 0; i < 1000; i++)
            //{
            //    int a = random.Next(1, 7);
            //    if (a==1) { bir++;}
            //    else if (a == 2) { iki++; }
            //    else if (a == 3) { uc++; }
            //    else if (a == 4) { dort++; }
            //    else if (a == 5) { bes++; }
            //    else if (a == 6) { alti++; }     
            //}
            //Console.WriteLine("1 için " + bir);
            //Console.WriteLine("2 için " + iki);
            //Console.WriteLine("3 için " + uc);
            //Console.WriteLine("4 için " + dort);
            //Console.WriteLine("5 için " + bes);
            //Console.WriteLine("6 için " + alti);

            //Console.WriteLine(bir*1 + iki*2 + uc*3 + dort*4 + bes*5+ alti*6); 
            #endregion
            #region MyRegion
            //    double hiz = 100;

            //git:

            //    Console.ReadLine();

            //    hiz = hiz - hiz * 0.1;

            //    Console.WriteLine(hiz);
            //    goto git; 
            #endregion
            #region MyRegion
            //for (int i = 1; i < 11; i++)
            //{
            //    for (int j = 1; j < 11; j++)
            //    {

            //            Console.Write($"{j}x{i}={i * j}\t");

            //    }
            //    Console.WriteLine();
            //} 
            #endregion
            #region Çarpım tablosu
            //for (int a = 1; a <= 10; a++)
            //{
            //    for (int b = 1; b <= 5; b++)
            //    {
            //        Console.Write(b + "x" + a + "=" + (a * b) + "\t");
            //    }
            //    Console.WriteLine();
            //}
            //Console.Write("------------------------------------------------------------------------------------");
            //Console.Write("\n");
            //for (int a = 1; a <= 10; a++)
            //{
            //    for (int b = 6; b <= 10; b++)
            //    {
            //        Console.Write(b + "x" + a + "=" + (a * b) + "\t");
            //    }
            //    Console.WriteLine();
            //}
            //Console.ReadLine(); 
            #endregion
            #region MyRegion
            //git:
            //Console.WriteLine("Kaç satır olsun");
            //int satir = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Yıldız sayısı giriniz");
            //int yildiz =Convert.ToInt32(Console.ReadLine());

            //for (int i = 0; i <satir; i++)
            //{
            //    for (int j = 0;  j< yildiz ; j++)
            //    {
            //        Console.Write("* ");
            //    }
            //    Console.WriteLine();
            //} 
            //goto git;
            #endregion
            #region MyRegion
            //Console.WriteLine("Kaç satır olsun");
            //int satir = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Yıldız sayısı giriniz");
            //int yildiz = Convert.ToInt32(Console.ReadLine());

            //for (int i = 0; i < satir; i++)
            //{
            //    for (int j = 0; j < yildiz; j++)
            //    {
            //        Console.Write("*\t");
            //    }
            //    Console.WriteLine();
            //} 
            #endregion
            #region MyRegion

            //Console.WriteLine("sayı gir");
            //int satir = Convert.ToInt32(Console.ReadLine());


            //for (int i = 0; i < satir; i++)
            //{

            //    for (int j = 0; j<i; j++)
            //    {
            //        Console.Write(" ");
            //    }
            //    for (int j = 0; j < i; j--)
            //    {
            //        Console.Write("**");

            //    }

            //    Console.WriteLine();
            //} 
            #endregion
            #region Karo Baklava
            //Console.Write("Baklava dilimi boyut yazını: ");
            //int boyut = int.Parse(Console.ReadLine());
            //for (int i = 0; i < boyut; i++)
            //{
            //    for (int j = boyut; j > i; j--)
            //    {
            //        Console.Write(" ");
            //    }
            //    for (int k = 0; k < i; k++)
            //    {
            //        Console.Write("*" + " ");
            //    }
            //    Console.WriteLine(" ");
            //}
            //for (int i = 0; i < boyut; i++)
            //{
            //    for (int j = 0; j < i; j++)
            //    {
            //        Console.Write(" ");
            //    }
            //    for (int k = boyut; k > i; k--)
            //    {
            //        Console.Write("*" + " ");
            //    }
            //    Console.WriteLine(" ");
            //}

            #endregion
            #region Baklava dilimi
            //Console.WriteLine("Satır sayısı\n");
            //int row = int.Parse(Console.ReadLine());
            //int space = row;

            //for (int i = 0; i <= row; i++)
            //{
            //    for (int b = space; b >= 1; b--)
            //    {
            //        Console.Write(" ");
            //    }
            //    for (int j = 0; j <= i; j++)
            //    {
            //        Console.Write("* ");
            //    }
            //    Console.Write("\n");
            //    space--;
            //}

            //for (int i = row - 1; i >= 0; i--)
            //{
            //    for (int b = space + 2; b >= 1; b--)
            //    {
            //        Console.Write(" ");
            //    }
            //    for (int j = 0; j <= i; j++)
            //    {
            //        Console.Write("* ");
            //    }
            //    Console.Write("\n");

            //    space++;
            //} 
            #endregion
            #region baklava
            //int num_1 = 0;
            //Console.Write("sayı gir:");
            //Console.WriteLine();
            //num_1 = int.Parse(Console.ReadLine());
            //for (int i = 0; i < num_1; i++)
            //{
            //    for (int z = num_1; z > i + 1; z--)
            //    {
            //        Console.Write(" ");
            //    }
            //    for (int j = 0; j <= i; j++)
            //    {
            //        Console.Write("* ");
            //    }
            //    Console.WriteLine();
            //}

            //for (int i = 1; i < num_1; i++)
            //{
            //    for (int z = 1; z < i + 1; z++)
            //    {
            //        Console.Write(" ");
            //    }
            //    for (int j = num_1; j > i; j--)
            //    {
            //        Console.Write("* ");
            //    }
            //    Console.WriteLine();
            //} 
            #endregion
            #region MyRegion
            //Console.WriteLine("Bir sayı giriniz");

            //int x = Convert.ToInt32(Console.ReadLine());

            //while(true)
            //{
            //    for (int i = 0; i < 5; i--)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine("");
            //    x++;
            //}

            #endregion
            #region MyRegion
            //int num = Convert.ToInt32(Console.ReadLine());
            //int i = 0;
            //int T =0;

            //while (i<10)
            //{
            //    T = T + i;
            //    i++;
            //}

            //int i = 0;
            //int T =0;
            //while (i<50)
            //{
            //    if (i%2==1)
            //    {
            //        T = T + i;
            //    }

            //    i++;
            //}

            //Console.WriteLine(T); 
            #endregion
            #region consoledan sıfır girilene kadar sayıların toplamının ortalamasını veren program

            //    int odd = 0, counter = 0;
            //    double result = 0;
            //go:
            //    Console.WriteLine("Bir sayı giriniz");
            //    int num = Convert.ToInt32(Console.ReadLine());

            //    while (num != 0)
            //    {

            //        odd = odd + num;
            //        counter++;

            //        result = odd / counter;
            //        Console.WriteLine(result);
            //        goto go;
            //    }

            #endregion
            #region Klavyeden girilen sayıların 100  toplamı yüz olduğunda kaç sayıyla girmiş  kodu

            //    int counter = 0;
            //    double sum = 0;
            //go:
            //    Console.WriteLine("Bir sayı giriniz");
            //    int num = Convert.ToInt32(Console.ReadLine());

            //    while (sum <=100)
            //    {
            //        counter++;
            //        sum =sum + num;
            //        goto go;
            //    }
            //    Console.WriteLine($"Toplam : {sum} Adet sayısı {counter}",sum,counter);

            #endregion
            #region Fatihin çözümü
            //Klavyeden girilen sayıların toplamı yüz olduğunda kaç sayıyla girmiş  kodu
            //int top = 0, adet = 0;
            //while (top <= 100)
            //{
            //    Console.WriteLine("lütfen bir değer giriniz");
            //    int x = Convert.ToInt32(Console.ReadLine());
            //    adet++;
            //    top += x;
            //}
            //Console.WriteLine("girilen adet sayısı=" + adet + " ve toplam sayı=" + top);

            #endregion
            #region Bir sayıdan istenildiği kadar girilip kaçınca defa bulunduğunu veren algoritma

            //int counter=0, counter2=0,value;
            //Random random  = new Random();

            //Console.WriteLine("Bir değer giriniz :");
            //value = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Kaç defa tekrar etsin");
            //int again = Convert.ToInt32(Console.ReadLine());

            //while (true)
            //{
            // int myNum= random.Next(1, 100);
            //    counter2++;
            //    if (value == myNum)
            //    {
            //        counter++;
            //        if (counter == again)
            //        {
            //            break;
            //        }
            //    }                
            //}
            //Console.WriteLine("Üretilen değer sayısı=" + counter2 ); 
            #endregion
            #region ilkelin çözümü
            //Random rnd = new Random();
            //int sayi_1, sayi_2;
            //int sayac_1 = 0, sayac_2 = 0;
            //int tekrar = 0;

            //Console.Write("hangi sayıyı bulmak istiyorsunuz:");
            //sayi_1 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("kaç kere bulmak istiyorsunuz:");
            //tekrar = Convert.ToInt32(Console.ReadLine());

            //while (sayac_1 < tekrar)
            //{
            //    sayi_2 = rnd.Next(1, 101);
            //    if (sayi_1 == sayi_2)
            //        sayac_1++;
            //    sayac_2++;
            //}
            //Console.WriteLine($"seçilen sayı:{sayi_1}, {sayac_1} kere bulundu ve toplam:{sayac_2} deneme yapıldı");
            #endregion
            #region Zehranın çözümü
            //Random random = new Random();
            //int sayi = 0, adet = 0, sayacsayi = 0, sayacdongu = 0;
            //int rnd;

            //bool bl = true;


            //Console.WriteLine("Bulunacak sayi:");
            //sayi = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Adet sayisi");
            //adet = Convert.ToInt32(Console.ReadLine());

            //while (bl)
            //{

            //    rnd = random.Next(0, 100);
            //    sayacdongu++;
            //    if (sayi == rnd)
            //    {
            //        sayacsayi++;
            //        if (sayacsayi == adet)
            //        {
            //            bl = false;
            //        }
            //    }
            //}

            //Console.WriteLine("Üretilen toplam rasgele sayı:" + sayacdongu);
            #endregion
            #region MyRegion
            //Console.WriteLine("");
            //int counter = 0, sum = 0;
            //do
            //{              
            //    counter++;
            //    sum += counter;
            //    Console.WriteLine(counter);
            //} while (counter <10);
            //Console.WriteLine("******************");
            //Console.WriteLine("1 den 10'a kadar saıların toplamı : {0}",sum); 
            #endregion
            #region Klavyeden girilen 10 tane sayıdan en büyük ve en küçük sayıyı veren algoritma
            //int enkucuksayi = 0, enbuyuksayi = 0;
            //int counter = 0;
            //Console.Write("Bir değer giriniz :");
            //int value2 = Convert.ToInt32(Console.ReadLine());
            //enkucuksayi = enbuyuksayi = value2;
            //do
            //{
            //    Console.Write("Bir değer giriniz :");
            //    int value = Convert.ToInt32(Console.ReadLine());

            //    if (value < enkucuksayi)
            //    {
            //        enkucuksayi = value;
            //    }
            //    if (value > enbuyuksayi)
            //    {
            //        enbuyuksayi = value;
            //    }

            //    counter++;

            //} while (counter < 9);

            //Console.WriteLine("Enbüyük sayı : " + enbuyuksayi + "En küçük sayı :" + enkucuksayi);
            #endregion
            #region Asalsayı

            //kullanıcının girdiği sayıyı asal yada değil onu yazdırın 1 ve kendisine bölünemeyecek 2den fazla bölen olunca iptall

            //Console.WriteLine("sayı giriniz=");
            //int x = Convert.ToInt32(Console.ReadLine());
            //int kalan = 0;
            //for (int i = x; i > 0; i--)
            //{
            //    if (x % i == 0)
            //    {
            //        kalan++;
            //    }
            //}
            //if (kalan > 2)
            //{
            //    Console.WriteLine("a"); 
            #endregion
            #region Benim çözüm

            //do
            //{
            //    Console.WriteLine("Bir değer giriniz ");
            //    int value = Convert.ToInt32(Console.ReadLine());

            //    if (value == 1 || value == 2 || value == 3 || value == 5 || value == 7)
            //    {
            //        Console.WriteLine("Asal sayıdır");
            //    }
            //    else if (value % 3 == 0 || value % 2 == 0 || value % 5 == 0 || value % 7 == 0)
            //    {
            //        Console.WriteLine("Asal sayi dğildir");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Asal sayıdır");
            //    }
            //    Console.WriteLine("**********************");
            //    System.Threading.Thread.Sleep(2000);
            //    Console.Clear();
            //} while (true);

            #endregion
            #region Asal sayı bulma

            //kullanıcının girdiği sayıyı asal yada değil onu yazdırın 1 ve kendisine bölünemeyecek 2den fazla bölen olunca iptall

            //Console.WriteLine("sayı giriniz=");
            //int x = Convert.ToInt32(Console.ReadLine());
            //int kalan = 0;
            //for (int i = x; i > 0; i--)
            //{
            //    if (x % i == 0)
            //    {
            //        kalan++;
            //    }
            //}
            //if (kalan > 2)
            //{
            //    Console.WriteLine("asal değildir.");
            //}
            //else
            //    Console.WriteLine("asaldır");

            #endregion
            #region Kullanıcı bir sayı girecek. Kullanıcının girdiği sayıdan küçük asal sayıları sıralayacak program.

            //Console.WriteLine("Bir sayı giriniz");
            //int sayi = Convert.ToInt32(Console.ReadLine());

            //int sayac;

            //for (int i = 2; i < sayi; i++)
            //{
            //    sayac= 0;
            //    for (int j = 2; j < i; j++)
            //    {
            //        if (i % j == 0)
            //        {
            //            sayac++;
            //        }

            //    }
            //    if (sayac ==0)
            //    {
            //      Console.WriteLine("Asal Sayılar= {0}",i);

            //    }    

            //}

            #endregion
            /*    Aynı firmada çalışan Ahmet ve Hasan 2 işçiden 1.sinin Ahmedin
                ücreti ilk ay % 50 artmakta 2.ay % 25 azalmaktadır.
                Diğerinin(Hasanın) ise ücreti her ay % 25 artmaktadır.
                Her ikisinin de yılbaşındaki başlangıç ücretleri ve hesaplanacak
                ay bilgisi klavyeden girildikten sonra ay ay ücretlerinin
                ne olacağını ve en sonunda hangi işçinin daha fazla(Veya eşit)
                ücret alacağını hesaplayan programı yazınız.int ahmet = 5000, hasan = 5000; */
            #region Soru-
            /*
            Aynı firmada çalışan Ahmet ve Hasan 2 işçiden 1.sinin Ahmedin
            ücreti ilk ay % 50 artmakta 2.ay % 25 azalmaktadır.
            Diğerinin(Hasanın) ise ücreti her ay % 25 artmaktadır.
            Her ikisinin de yılbaşındaki başlangıç ücretleri ve hesaplanacak
            ay bilgisi klavyeden girildikten sonra ay ay ücretlerinin
            ne olacağını ve en sonunda hangi işçinin daha fazla(Veya eşit)
            ücret alacağını hesaplayan programı yazınız.int ahmet = 5000, hasan = 5000; */

            //// Başlangıç ücretlerini ve ay sayısını kullanıcıdan al
            //Console.Write("Ahmet'in başlangıç ücreti: ");
            //double ahmetBaslangicUcreti = Convert.ToDouble(Console.ReadLine());

            //Console.Write("Hasan'ın başlangıç ücreti: ");
            //double hasanBaslangicUcreti = Convert.ToDouble(Console.ReadLine());

            //Console.Write("Hesaplanacak ay sayısı: ");
            //int aySayisi = Convert.ToInt32(Console.ReadLine());

            //// Ahmet'in aylık ücretini hesapla
            //double ahmetAylikUcreti = ahmetBaslangicUcreti;
            //for (int i = 1; i <= aySayisi; i++)
            //{
            //    if (i % 2 == 1)
            //    {
            //        ahmetAylikUcreti *= 1.5; // İlk ay %50 artış
            //    }
            //    else if (i % 2 == 0)
            //    {
            //        ahmetAylikUcreti *= 0.75; // İkinci ay %25 azalış
            //    }

            //}

            //// Hasan'ın aylık ücretini hesapla
            //double hasanAylikUcreti = hasanBaslangicUcreti;
            //for (int i = 1; i <= aySayisi; i++)
            //{
            //    hasanAylikUcreti *= 1.25; // Her ay %25 artış
            //}

            //// Sonuçları ekrana yazdır
            //Console.WriteLine("Ahmet'in son aylık ücreti: " + ahmetAylikUcreti.ToString("0.00"));
            //Console.WriteLine("Hasan'ın son aylık ücreti: " + hasanAylikUcreti.ToString("0.00"));

            //if (ahmetAylikUcreti > hasanAylikUcreti)
            //{
            //    Console.WriteLine("Ahmet daha fazla ücret alıyor.");
            //}
            //else if (ahmetAylikUcreti < hasanAylikUcreti)
            //{
            //    Console.WriteLine("Hasan daha fazla ücret alıyor.");
            //}
            //else
            //{
            //    Console.WriteLine("Ahmet ve Hasan eşit ücret alıyor.");
            //}
            #endregion
            #region diğer çözüm
            //double ahmetMaas = 5000;
            //double hasanMaas = 5000;

            //Console.Write("Kaç ayın ücretini hesaplamak istiyorsunuz: ");
            //int aySayisi = Convert.ToInt16(Console.ReadLine());

            //for (int ay = 1; ay <= aySayisi; ay++)
            //{
            //    if (ay % 2 == 1)
            //    {
            //        ahmetMaas = ahmetMaas * 1.5;
            //    }

            //    else
            //    {
            //        ahmetMaas = ahmetMaas * 0.75;
            //    }

            //    hasanMaas = hasanMaas * 1.25;

            //    Console.WriteLine("{0}. Ay, Ahmetin maaşı {1}, Hasanın maaşı {2}", ay, ahmetMaas, hasanMaas);

            //}

            //if (ahmetMaas > hasanMaas)
            //{
            //    Console.WriteLine("Ahmetin maaşı Hasanın maaşından fazladır");
            //}
            //else if (hasanMaas > ahmetMaas)
            //{
            //    Console.WriteLine("Hasanın maaşı Ahmetin maaşından fazladır");
            //}
            //else
            //{
            //    Console.WriteLine("Ahmetin maaşı ile Hasanın maaşı eşittir");
            //}
            #endregion
            #region Her 2 saniyede 2 ye bölünen bakteri kolonisi var başlangıç durumunda 16 tane var 24.sn deki bakteri sayısı12.saniyedeki bakteri sayısının kaç katıdır.
            //int N0 = 16; // başlangıçtaki bakteri sayısı
            //double t1 = 12.0; // 12. saniye
            //double t2 = 24.0; // 24. saniye

            //// 12. saniyedeki bakteri sayısını hesapla
            //double N1 = N0 * Math.Pow(2, t1 / 2.0);

            //// 24. saniyedeki bakteri sayısını hesapla
            //double N2 = N0 * Math.Pow(2, t2 / 2.0);

            //// 24. saniyedeki bakteri sayısının kaç katı olduğunu hesapla
            //double kat = N2 / N1;

            //Console.WriteLine("12. saniyedeki bakteri sayısı: " + N1);
            //Console.WriteLine("24. saniyedeki bakteri sayısı: " + N2);
            //Console.WriteLine("24. saniyedeki bakteri sayısı, 12. saniyedeki bakteri sayısının " + kat + " katıdır.");
            #endregion
            #region Hocanın çözümü
            //Console.WriteLine("Saniye Girin");
            //int saniye = Convert.ToInt32(Console.ReadLine());
            //int bakteri = 16;
            //int bakteri1 = 16;
            //int bakteri2 = 16;

            //for (int i = 1; i <= saniye; i += 2)
            //{
            //    bakteri = bakteri * 2;
            //    Console.WriteLine($"{i}.Saniyede Bakteri Sayısı={bakteri}");
            //    Console.WriteLine($"{i + 1}.Saniyede Bakteri Sayısı={bakteri}");

            //}
            //Console.WriteLine($"******************************************");


            //for (int i = 1; i <= 12; i += 2)
            //{
            //    bakteri1 = bakteri1 * 2;
            //}

            //for (int i = 1; i <= 24; i += 2)
            //{
            //    bakteri2 = bakteri2 * 2;
            //}

            //int sonuc = bakteri2 / bakteri1;
            //Console.WriteLine($"12.Saniyede Bakteri Sayısı = {bakteri1}");
            //Console.WriteLine($"24.Saniyede Bakteri Sayısı = {bakteri2}");
            //Console.WriteLine($"kat = {sonuc}");
            #endregion
             


            Console.ReadLine();
        }

    }
}

