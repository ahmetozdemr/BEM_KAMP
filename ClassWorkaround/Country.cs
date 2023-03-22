using System;

namespace ClassWorkaround
{
    public class Country
    {
        public string countryName;
        public int countryCode;
        public string countryCapitalCity;
        public string flagColor;

        public void countryProperty(int num)
        {
            Console.WriteLine("Ülke İsmi : {0}\nÜlke Kodu: {1}\nÜlke Başkenti: {2}\nÜlke Bayrak Rengi: {3}\nSıra No :{4}"
                , countryName, countryCode, countryCapitalCity, flagColor, num);

        }
        public string countryTechnology(string countryTech)
        {
            return countryTech;
        }

    }
}
