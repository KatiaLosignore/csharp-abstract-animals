using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_abstract_animals.@abstract
{
    public class Cane : Animale
    {
        // COSTRUTTORE
        public Cane(string nomeAnimale) : base(nomeAnimale)
        {
        }
        public override void CosaMangi()
        {
            Console.WriteLine("Carne");
        }

        public override void Verso()
        {
            Console.WriteLine("Bau");
        }

        public void FaiNuotare()
        {

        }
    }
}
