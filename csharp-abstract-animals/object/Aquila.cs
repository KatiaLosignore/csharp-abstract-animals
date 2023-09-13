using csharp_abstract_animals.@interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_abstract_animals.@abstract
{
    public class Aquila : Animale, IVolante
    {
        // COSTRUTTORE
        public Aquila(string nomeAnimale) : base(nomeAnimale)
        {
        }

        // METODI DELLA CLASSE ASTRATTA
        public override void CosaMangi()
        {
            Console.WriteLine("Piccoli e medi mammiferi");
        }

        public override void Verso()
        {
            Console.WriteLine("Strido");
        }

        // METODO DELL' INTERFACCIA
        public void Vola()
        {
            Console.WriteLine($"{nomeAnimale}: 'Sto volando!!!'");
        }
    }
}
