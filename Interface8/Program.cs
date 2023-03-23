using System;
using System.Collections.Generic;

namespace Interface8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> listTC = new List<int>() { 25643546, 96535429, 58964523, 589643254, 45632541 };
            List<int> listEgliyet = new List<int>() { 32564346, 9655429, 25864523, 858643254, 5462541 };

            Vatandas vatandas = new Vatandas();
            vatandas.Ad = "Ökkeş";
            vatandas.Soyad = "Koyunkesen";
            vatandas.TC = 58964523;
            vatandas.EgliyetNo = 5462541;

            Console.WriteLine(vatandas.TC);

            Kontrol kontrol = new Kontrol();

            Console.WriteLine("1 Tc doğruma");
            Console.WriteLine("2 Eğliyet doğrulama");
            int x = int.Parse(Console.ReadLine());



            kontrol.Dogrulama(listTC, listEgliyet, x, vatandas.TC);

            Console.ReadLine();
        }
    }
    interface IKisi
    {
        string Ad { get; set; }
        string Soyad { get; set; }
        int TC { get; set; }
        int EgliyetNo { get; set; }
        int PasaportNo { get; set; }

    }
    class Vatandas : IKisi
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public int TC { get; set; }
        public int EgliyetNo { get; set; }
        public int PasaportNo { get; set; }
    }




    class Kontrol : Vatandas
    {

        public void Dogrulama(List<int> listTC, List<int> listEgliyet, int sec, int Tc)
        {
            if (sec == 1)
            {
                bool y= true;   
                foreach (var item in listTC)
                {
                    if (Tc == item)
                    {
                        Console.WriteLine("Tc dogrulandı");
                        y= false;
                        break;
                    }                       
                }
                if (y)
                {
                    Console.WriteLine("Tc dogrulanmadı");
                    y = false;
                }


            }
            else if (sec == 2)
            {
                bool y = true;
                foreach (var item in listEgliyet)
                {
                    if (EgliyetNo == item)
                    {
                        y = false;
                        Console.WriteLine("Egliyet dogrulandı");
                        break;
                    }
                   
                }
                if (y)
                {
                    Console.WriteLine("Egliyet dogrulanmadı");
                    y = false;
                }
            }




        }

    }
}

