using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface4.Interfacler
{
    public interface IElektrikli
    {
        void PilSeviyesi();
        int elektrikOrani { get; set; }
    }
}
