using ClassWorkaround;
using System;

namespace ClassCreate2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Country country = new Country();
            country.countryName = "Rusya";
            country.countryCapitalCity = "Moskova";
            country.countryCode = 7;
            country.flagColor = "Beyaz-Mavi-Kırmızı";
            string countryTech = "S-400";
            int siraNo = 1;

            country.countryProperty(siraNo);

            Console.WriteLine($"Ülke teknolojisi :{country.countryTechnology(countryTech)}");

            Console.ReadKey();
        }

    }
}
