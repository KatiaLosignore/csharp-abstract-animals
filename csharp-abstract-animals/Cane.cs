using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_abstract_animals
{
    public class Cane : Animale
    {
        public override void CosaMangi()
        {
            Console.WriteLine("Carne");
        }

        public override void Verso()
        {
            Console.WriteLine("Bau");
        }
    }
}
