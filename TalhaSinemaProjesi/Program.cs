using System;
using System.Collections;

namespace TalhaSinemaProjesi
{
    class Program
    {
        static void Main(string[] args)
        {
            int koltuk = 0;
            string isim = "";
            ArrayList aksiyon = new ArrayList(15);
            ArrayList korku = new ArrayList(10);
            for (int i = 0; i < 15; i++)
            {
                aksiyon.Add(i + 1);
            }

            for (int i = 0; i < 10; i++)
            {
                korku.Add(i + 1);
            }
            int sayac = 0;
            int sayac2 = 0;
        label:
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n**** Sinema Salonuna Hoş Geldiniz ****\n");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("-----AKSİYON SALONU BOŞ KOLTUKLAR-----");

            foreach (var item in aksiyon)
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                if (item.ToString() != "1" && item.ToString() != "2" && item.ToString() != "3" &&
                    item.ToString() != "4" && item.ToString() != "5" && item.ToString() != "6" &&
                    item.ToString() != "7" && item.ToString() != "8" && item.ToString() != "9" &&
                    item.ToString() != "10" && item.ToString() != "11" && item.ToString() != "12"
                    && item.ToString() != "13" && item.ToString() != "14" && item.ToString() != "15")
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                }
                Console.Write(item + "\t");
                if (sayac == 4)
                {
                    Console.Write("   \n");
                    sayac = -1;
                }

                sayac++;
            }
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("--------------------------------------\n\n");
            Console.WriteLine("-----KORKU SALONU BOŞ KOLTUKLAR-------");
            foreach (var item in korku)
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                if (item.ToString() != "1" && item.ToString() != "2" && item.ToString() != "3" &&
                    item.ToString() != "4" && item.ToString() != "5" && item.ToString() != "6" &&
                    item.ToString() != "7" && item.ToString() != "8" && item.ToString() != "9" &&
                    item.ToString() != "10")
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                }
                Console.Write(item + "\t");
                if (sayac == 4)
                {
                    Console.WriteLine();
                    sayac = -1;
                }
                sayac++;
            }
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("--------------------------------------\n");
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Write("Hangi Salon \nAksiyon : 1\nKorku   : 2 : ");
            switch (Console.ReadLine())
            {
                case "1":
                    #region Aksiyon
                    Console.ForegroundColor = ConsoleColor.White;
                label2:
                    Console.Write("Hangi Koltuğa Oturmak İstiyorsunuz : ");
                    try
                    {
                        koltuk = Convert.ToInt32(Console.ReadLine());
                    }
                    catch
                    {
                        Console.WriteLine("Hatalı giriş");
                        goto label2;
                    }
                    if (koltuk != 1 && koltuk != 2 && koltuk != 3 && koltuk != 4 && koltuk != 5 &&
                        koltuk != 6 && koltuk != 7 && koltuk != 8 && koltuk != 9 && koltuk != 10 &&
                        koltuk != 11 && koltuk != 12 && koltuk != 13 && koltuk != 14 && koltuk != 15)
                    {
                        Console.Clear();
                        Console.WriteLine("Böyle bir Koltuk Yok");
                        goto label;
                    }
                    else
                    {
                        if (aksiyon.Contains(koltuk))
                        {
                        label5:
                            Console.Write("İsminiz Nedir(En Fazla 7 Karakter Rakam İçeremez) ? : ");
                            isim = Console.ReadLine();
                            if (isim.Length <= 7 && isim.Length > 0)
                            {
                                for (int i = 0; i < isim.Length; i++)
                                {
                                    if (isim[i] == '1' || isim[i] == '2' || isim[i] == '3' || isim[i] == '4' || isim[i] == '5' ||
                                        isim[i] == '6' || isim[i] == '7' || isim[i] == '8' || isim[i] == '9')
                                    {
                                        sayac2++;
                                    }
                                }
                                if (sayac2 == 0)
                                {
                                    Console.Write("Rezervasyon Yapılıyor");
                                    for (int i = 0; i < 5; i++)
                                    {
                                        Console.Write(".");
                                        System.Threading.Thread.Sleep(1000);
                                    }
                                    aksiyon.RemoveAt(koltuk - 1);
                                    aksiyon.Insert(koltuk - 1, isim);
                                    Console.Clear();
                                    Console.WriteLine("Rezervasyon Yapıldı !!!");
                                    goto label;
                                }
                                else
                                {
                                    Console.WriteLine("İsim İçerisinde Rakam Bulunamaz ve İsim 7 Karakterden Fazla olamaz");
                                    goto label5;
                                }
                            }
                            else
                            {
                                Console.WriteLine("İsim İçerisinde Rakam Bulunamaz ve İsim 7 Karakterden Fazla olamaz");
                                goto label5;
                            }
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Bu koltuk Dolu !!");
                            goto label;
                        }

                    }
                #endregion
                case "2":
                    #region Korku
                    Console.ForegroundColor = ConsoleColor.White;
                label3:
                    Console.Write("Hangi Koltuğa Oturmak İstiyorsunuz : ");
                    try
                    {
                        koltuk = Convert.ToInt32(Console.ReadLine());
                    }
                    catch
                    {
                        Console.WriteLine("Hatalı giriş");
                        goto label3;
                    }
                    if (koltuk != 1 && koltuk != 2 && koltuk != 3 && koltuk != 4 && koltuk != 5 &&
                koltuk != 6 && koltuk != 7 && koltuk != 8 && koltuk != 9 && koltuk != 10)
                    {
                        Console.Clear();
                        Console.WriteLine("Böyle bir Koltuk Yok");
                        goto label;
                    }
                    else
                    {
                        if (korku.Contains(koltuk))
                        {
                        label4:
                            Console.Write("İsminiz Nedir(En Fazla 7 Karakter Rakam İçeremez) ? : ");
                            isim = Console.ReadLine();
                            if (isim.Length <= 7 && isim.Length > 0)
                            {
                                for (int i = 0; i < isim.Length; i++)
                                {
                                    if (isim[i] == '1' || isim[i] == '2' || isim[i] == '3' || isim[i] == '4' || isim[i] == '5' ||
                                        isim[i] == '6' || isim[i] == '7' || isim[i] == '8' || isim[i] == '9')
                                    {
                                        sayac2++;
                                    }
                                }
                                if (sayac2 == 0)
                                {
                                    Console.Write("Rezervasyon Yapılıyor");
                                    for (int i = 0; i < 5; i++)
                                    {
                                        Console.Write(".");
                                        System.Threading.Thread.Sleep(1000);
                                    }
                                    korku.RemoveAt(koltuk - 1);
                                    korku.Insert(koltuk - 1, isim);
                                    Console.Clear();
                                    Console.WriteLine("Rezervasyon Yapıldı !!!");
                                    goto label;
                                }
                                else
                                {
                                    Console.WriteLine("İsim İçerisinde Rakam Bulunamaz ve İsim 7 Karakterden Fazla olamaz");
                                    goto label4;
                                }
                            }
                            else
                            {
                                Console.WriteLine("İsim İçerisinde Rakam Bulunamaz ve İsim 7 Karakterden Fazla olamaz");
                                goto label4;
                            }
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Bu koltuk Dolu !!");
                            goto label;
                        }

                    }
                #endregion
                default:
                    Console.Clear();
                    Console.WriteLine("Yanlış Giriş");
                    goto label;
            }
        }
    }
}
