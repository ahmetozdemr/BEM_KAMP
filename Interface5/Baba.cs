using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface5
{
    public class Baba : Kisi, IErkek
    {
        public bool Sakal { get; set; }
        public bool Biyik { get; set; }

        public override void OzellikleriGoster()
        {
            Console.WriteLine("Ad : " + Ad);
            Console.WriteLine("SoyAd : " + SoyAd);

            string sakal = (Sakal = true) ? "Sakal Var" : "Sakal Yok";
            Console.WriteLine(sakal);

            string biyik = (Biyik = true) ? "Bıyık Var" : "Bıyık Yok";
            Console.WriteLine(biyik);
        }
    }
}
