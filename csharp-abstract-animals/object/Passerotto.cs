using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_abstract_animals.@abstract
{
    public class Passerotto : Animale
    {
        // COSTRUTTORE
        public Passerotto(string nomeAnimale) : base(nomeAnimale)
        {
        }
        public override void CosaMangi()
        {
            Console.WriteLine("Semi e frutta");
        }

        public override void Verso()
        {
            Console.WriteLine("CipCip");
        }
    }
}
