using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface5
{
    public class Kisi
    {
        public string Ad { get; set; }
        public string SoyAd { get; set; }

        public virtual void OzellikleriGoster()
        {
            Console.WriteLine("Ekrana Yazır");
        }
    }
}
