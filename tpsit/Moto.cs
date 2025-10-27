using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpsit
{
    public class Moto : Veicolo
    {
        public int Cilindrata { get; set; }

        public Moto(string marca, string modello, int anno, int cilindrata)
            : base(marca, modello, anno)
        {
            Cilindrata = cilindrata;
        }

        public override void MostraDettagli()
        {
            Console.WriteLine($"Moto: {Marca} {Modello}, Anno: {Anno}, Cilindrata: {Cilindrata}cc");;
   
        }
    }
}
