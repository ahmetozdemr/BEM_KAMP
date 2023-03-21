using System;

namespace Array1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region MyRegion
            //string[] yazilar = new string[10];

            //for (int i = 0; i < 10; i++)
            //{
            //    yazilar[i] = Console.ReadLine();

            //}
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine("i");
            //    Console.WriteLine(yazilar[i]);
            //} 
            #endregion
            #region MyRegion
            //string[] cicekler = new string[10];
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine(i + ". çiçek");
            //    cicekler[i] = Console.ReadLine();
            //}
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine(cicekler[i]);
            //} 
            #endregion
            #region MyRegion
            //Console.WriteLine("Kaç tane sayı üretilsin...");
            //int x = Convert.ToInt32(Console.ReadLine());
            //int[] sayilar = new int[x];
            //Random random = new Random();   

            //for (int i = 0; i < x; i++)
            //{
            //    sayilar[i] = random.Next();
            //}
            //for (int i = 0; i < x; i++)
            //{
            //    Console.WriteLine(sayilar[i]);
            //} 
            #endregion
            #region MyRegion

            // Random rnd= new Random();
            //int[] sade= new int[rnd.Next(1,20)];
            //int T = 0;

            //for (int i = 0; i < sade.Length; i++)
            //{
            //    sade[i] = rnd.Next(1,100);
            //    Console.WriteLine(sade[i] +". değer");
            //    T = T + sade[i];
            //}
            //Console.WriteLine("Ortalaması : " + T/sade.Length);
            //Console.ReadLine(); 
            #endregion
            #region bir dizideki tek sayılar ile çift sayılarının toplamının farkı
            //Random rnd = new Random();
            //int[] sayilar = new int[200];
            //int tek = 0;
            //int cift = 0;

            //for (int i = 0; i < 200; i++)
            //{
            //    sayilar[i] = rnd.Next(1, 100);
            //    if (sayilar[i] % 2 == 0)
            //    {
            //        cift += sayilar[i];
            //    }
            //    else
            //    {
            //        tek += sayilar[i];
            //    }
            //}
            //Console.WriteLine("Tek sayıların toplamı : {0}", tek);
            //Console.WriteLine("Çift sayıların toplamı : {0}", cift);
            //Console.WriteLine("Fark :{0}", (tek - cift));
            #endregion
            #region string dizisi
            //string ad = "Ahmet Özdemir";

            //for (int i = 0; i < ad.Length; i++)
            //{
            //    Console.WriteLine(ad[i]);
            //}

            #endregion
            #region örnek

            //Console.WriteLine("Bir metin giriniz");
            //string metin = Console.ReadLine().ToUpper();

            //int sayac = 0;

            //for (int i = 0; i < metin.Length; i++)
            //{
            //    if (metin[i] == 'A' || 
            //        metin[i] == 'E' || 
            //        metin[i] == 'I' || 
            //        metin[i] == 'İ' || 
            //        metin[i] == 'O' || 
            //        metin[i] == 'Ö' || 
            //        metin[i] == 'U' ||
            //        metin[i] == 'Ü')
            //    {
            //        sayac++;
            //    }
            //}
            //Console.WriteLine(sayac);

            //char[] sesli = { 'A', 'E', 'I', 'İ', 'U', 'Ü', 'O', 'Ö' };
            //string[] sessiz = {"BCDFGĞHJKLMNPRSŞTYVZ"};
            //int sayac = 0;
            //Console.WriteLine("Bir metin giriniz");
            //string metin = Console.ReadLine().ToUpper();

            //for (int i = 0; i < metin.Length; i++)
            //{
            //    for (int j = 0; j < sesli.Length; j++)
            //    {
            //        if (metin[i] == sesli[j])
            //        {
            //            sayac++;
            //        }
            //        else if (metin[i].ToString == sessiz[j].T) 
            //        { 

            //        }
            //    }
            //}
            // Console.WriteLine(sayac); 
            #endregion
            #region Elemanları tam sayı olan bir A dizisinin (20 elemanlı) rastgele sayılar atayan, sonra elemanlarının aritmetik ortalamasını hesaplayan ve elemanlarından kaç tanesinin bu ortalamadan büyük ve küçük olduğunu sayan program.

            //int ort = 0, top= 0, buyuk=0,kucuk=0;

            //Random random = new Random();
            //int[] sayilar = new int[20];    

            //for (int i = 0; i < 20; i++)
            //{
            //    sayilar[i] = random.Next(1,100);
            //    Console.WriteLine("Sayılar :"+ sayilar[i]);
            //    top = top + sayilar[i];
            //}
            //ort = top / 20;
            //Console.WriteLine("Ortalama :"+ort);
            //for (int i = 0; i < 20; i++)
            //{
            //    if (sayilar[i] < ort)
            //    {
            //        kucuk += 1;
            //    }
            //    if (sayilar[i] >= ort)
            //    {
            //       buyuk += 1;
            //    }
            //}
            //Console.WriteLine("Ortlamadan büyüklerin sayısı: {0} ", buyuk);
            //Console.WriteLine("Ortlamadan küçüklerin sayısı: {0} ", kucuk);

            #endregion
            #region Diziye 100 eleman girilecek ve 100 e eşit ve yüzden büyük 100 sayılı bir dizi verek
            //Console.WriteLine("Dizi sayısını giriniz: ");
            //int adet = int.Parse(Console.ReadLine());
            //int sayac = 0, sayac2 = 0;

            //Random random = new Random();
            //int[] sayilar = new int[adet];

            //for (int i = 0; i < adet; i++)
            //{
            //    int rastgele = random.Next(1, 200);
            //    if (rastgele >= 100)
            //    {
            //        sayac++;
            //        sayilar[i] = rastgele;                  
            //    }
            //    i = sayac;
            //}

            //int[] sayilar2 = new int[sayac];
            //for (int i = 0; i < sayac; i++)
            //{
            //    if (sayilar[i] > 0)
            //    {
            //        sayilar2[sayac2] = sayilar[i];
            //        sayac2++;
            //    }
            //}
            //for (int i = 0; i < sayac2; i++)
            //{
            //    Console.WriteLine(sayilar2[i]);
            //}

            ////ilkelin çözümü
            //Random rnd = new Random();
            //int number = 0, i = 0;
            //int number_2;
            //int[] array;
            //Console.Write("dizinin uzunluğunu giriniz:");
            //number = int.Parse(Console.ReadLine());
            //array = new int[number];

            //while (number > i)
            //{
            //    number_2 = rnd.Next(1, 200);
            //    if (number_2 >= 100)
            //    {
            //        array[i] = number_2;
            //        i++;
            //    }
            //}
            //for (i = 0; i < array.Length; i++)
            //{
            //    Console.Write($"{array[i]} ");
            //}
            ////hocanın çözümü
            //int sayi = 0;
            //Console.WriteLine("bir adet giriniz: ");
            //int adet = int.Parse(Console.ReadLine());
            //Random rnd = new Random();
            //int[] sayilar = new int[adet];
            //for (int i = 0; i < adet;)
            //{
            //    sayi = rnd.Next(20, 180);
            //    if (sayi > 100)
            //    {
            //        sayilar[i] = sayi;
            //        i++;
            //    }
            //}
            //for (int i = 0; i < sayilar.Length; i++)
            //{
            //    Console.WriteLine("sayilar:[" + sayi + "]=" + sayilar[i]);
            //} 
            #endregion
            #region Girilen değerden kaç adet var
            //Console.WriteLine("Bir değer gir :");

            //int adet = int.Parse(Console.ReadLine());
            //int[] sayilar = new int[adet];  
            //Random random= new Random();    

            //for (int i = 0; i < sayilar.Length; i++)
            //{

            //    int rnd = random.Next(1,9);
            //    sayilar[i] = rnd;   
            //}
            //int s = 0;

            //for (int i = 0; i < sayilar.Length; i++)
            //{
            //    s = 0;
            //    for (int j = 1; j < sayilar.Length; j++)
            //    {
            //        if (sayilar[i] == sayilar[j])
            //        {
            //            Console.WriteLine(sayilar[i]);
            //            s++;

            //        }
            //    }

            //    Console.WriteLine(i +". indexteki " + sayilar[i] + " değeri {0} defa tekrar ediyor",s);
            //} 
            #endregion
            #region Kelime sayısını veren algoritma
            //Console.WriteLine("Bir cümle girin");
            //string metin = Console.ReadLine();
            //int s = 0;
            //for (int i = 0; i < metin.Length; i++)
            //{

            //    if (metin[i] == ' ')
            //    {
            //        s++;
            //    }
            //}
            //Console.WriteLine(s + 1); 
            #endregion
            #region 1 adet çift boyutlu dizi oluşturulacak bu dizi tek boyutlu diziye dönüştürülecek.
            //int[,] diziçift = new int[3, 3];
            //int[] dizitek = new int[9];
            //Random rast = new Random();
            //int sayac = 0;
            //for (int i = 0; i < diziçift.GetLength(0); i++)
            //{
            //    for (int j = 0; j < diziçift.GetLength(1); j++)
            //    {
            //        diziçift[i, j] = rast.Next(1, 10);
            //        Console.WriteLine(diziçift[i, j] + "\t");
            //    }
            //    Console.WriteLine("\n");
            //}
            //for (int i = 0; i < diziçift.GetLength(0); i++)
            //{
            //    for (int j = 0; j < diziçift.GetLength(1); j++)
            //    {
            //        dizitek[sayac] = diziçift[i, j];
            //        sayac++;
            //    }
            //    Console.WriteLine("\n");
            //}    
            #endregion
            #region iki boyutlu diziyi tek boyuta çevirme örneği
            //int[,] ciftBoyutluDizi = new int[3, 3] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            //int boyut = ciftBoyutluDizi.GetLength(0) * ciftBoyutluDizi.GetLength(1);
            //int[] tekBoyutluDizi = new int[boyut];

            //int index = 0;
            //for (int i = 0; i < ciftBoyutluDizi.GetLength(0); i++)
            //{
            //    for (int j = 0; j < ciftBoyutluDizi.GetLength(1); j++)
            //    {
            //        tekBoyutluDizi[index] = ciftBoyutluDizi[i, j];
            //        index++;
            //    }
            //}

            //Console.WriteLine("Çift boyutlu dizi: ");
            //for (int i = 0; i < ciftBoyutluDizi.GetLength(0); i++)
            //{
            //    for (int j = 0; j < ciftBoyutluDizi.GetLength(1); j++)
            //    {
            //        Console.Write(ciftBoyutluDizi[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}

            //Console.WriteLine("Tek boyutlu dizi: ");
            //for (int i = 0; i < boyut; i++)
            //{
            //    Console.Write(tekBoyutluDizi[i] + " ");
            //}
            //Console.ReadLine();


            ////Fatihin çözümü
            //Random rnd = new Random();
            //int[,] array = new int[4, 5];
            //int[] array_2 = new int[array.Length];
            //int k = 0;
            //Console.WriteLine("çift boyutlu dizi");
            //for (int i = 0; i < array.GetLength(0); i++)
            //{
            //    for (int j = 0; j < array.GetLength(1); j++)
            //    {
            //        array[i, j] = rnd.Next(1, 100);
            //        array_2[k] = array[i, j];
            //        Console.Write($"{array[i, j]}\t");
            //        k++;
            //    }
            //    Console.WriteLine();
            //}
            //Console.WriteLine("\ntek boyutlu dizi");
            //for (int i = 0; i < array_2.Length; i++)
            //{
            //    Console.Write($"{array_2[i]} ");
            //}
            #endregion


            Console.ReadLine();

        }
    }
}
