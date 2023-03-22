using System;

namespace Interface3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Penguen penguen = new Penguen();    


            Console.WriteLine("Hello World!");
        }
    }
    abstract class Kus
    {
        public virtual string KusAdi { get; set; }
        public string KusTipi { get; set; }

        public void OzellikleriGoster()
        {
            Console.WriteLine("{0}'nin yetenekleri belirsizdir...kuştan kuşa değişir", KusAdi);
        }
    }
    class Papagan : Kus
    {
        public Papagan(string kusAdi)
        {
            this.KusAdi = kusAdi;
            KusTipi= "Papağan";
        }
        public override string KusAdi { get; set; }
    }
    class Penguen : Kus, IYuzme
    {
        public override string KusAdi { get; set; }

        public void Yuzme()
        {
            throw new NotImplementedException();
        }
    }
    class Yarasa : Kus
    {
        public override string KusAdi { get; set; }
    }

    interface IKonusmaDavranisi
    {
        void Konusma();
    }
    interface IUcabilme
    {
        void Ucabilme();
    }
    interface IYuzme
    {
        void Yuzme();
    }
}
