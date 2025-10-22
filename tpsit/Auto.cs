using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpsit
{
    public class Auto : Veicolo
    {
        public int NumeroPorte { get; set; }

        public Auto(string marca, string modello, int anno, int numeroPorte)
            : base(marca, modello, anno)
        {
            NumeroPorte = numeroPorte;
        }

        // Override del metodo base
        public override void MostraDettagli()
        {
            Console.WriteLine($"Auto: {Marca} {Modello}, Anno: {Anno}, Porte: {NumeroPorte}");
        }
    }

}
