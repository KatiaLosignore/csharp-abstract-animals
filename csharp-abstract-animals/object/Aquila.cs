using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_abstract_animals.@abstract
{
    public class Aquila : Animale
    {
        // COSTRUTTORE
        public Aquila(string nomeAnimale) : base(nomeAnimale)
        {
        }
        public override void CosaMangi()
        {
            Console.WriteLine("Piccoli e medi mammiferi");
        }

        public override void Verso()
        {
            Console.WriteLine("Strido");
        }
    }
}
