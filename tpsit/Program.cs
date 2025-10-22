using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpsit
{
    class Program
    {
        static void Main(string[] args)
        {
            Veicolo v = new Veicolo("Generic", "ModelX", 2015);
            Auto a = new Auto("Fiat", "Panda", 2020, 5);
            Moto m = new Moto("Yamaha", "MT-07", 2022, 689);

            v.MostraDettagli();
            a.MostraDettagli();
            m.MostraDettagli();
        }
    }
}
