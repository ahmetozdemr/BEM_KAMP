using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface5
{
    public class Anne : Kisi, IKadin
    {
        public string RujRengi { get; set; }
        public int KacCocukDogurdu { get; set; }

        public override void OzellikleriGoster()
        {
            Console.WriteLine("Adı :"+ Ad);
            Console.WriteLine("Soya Ad :"+ SoyAd);
            Console.WriteLine("Ruj Rengi : " + RujRengi);
            Console.WriteLine("Kaç Çocuk: "+ KacCocukDogurdu);
        }
    }
}
