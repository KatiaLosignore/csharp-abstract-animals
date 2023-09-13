using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_abstract_animals.@abstract
{

    public class Delfino : Animale
    {
        // COSTRUTTORE
        public Delfino(string nomeAnimale) : base(nomeAnimale)
        {
        }
        public override void CosaMangi()
        {
            Console.WriteLine("Pesce, crostacei e calamari");
        }

        public override void Verso()
        {
            Console.WriteLine("Buzzes");
        }
    }
}
