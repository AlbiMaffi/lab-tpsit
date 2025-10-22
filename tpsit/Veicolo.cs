using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpsit
{
    public class Veicolo
    {
        public string Marca { get; set; }
        public string Modello { get; set; }
        public int Anno { get; set; }

        public Veicolo(string marca, string modello, int anno)
        {
            Marca = marca;
            Modello = modello;
            Anno = anno;
        }

        public virtual void MostraDettagli()
        {
            Console.WriteLine($"Veicolo: {Marca} {Modello}, Anno: {Anno}");
        }
    }
}
