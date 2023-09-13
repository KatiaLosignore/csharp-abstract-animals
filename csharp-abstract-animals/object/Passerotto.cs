using csharp_abstract_animals.@interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_abstract_animals.@abstract
{
    public class Passerotto : Animale, IVolante
    {
        // COSTRUTTORE
        public Passerotto(string nomeAnimale) : base(nomeAnimale)
        {
        }

        // METODI DELLA CLASSE ASTRATTA
        public override void CosaMangi()
        {
            Console.WriteLine("Semi e frutta");
        }

        public override void Verso()
        {
            Console.WriteLine("CipCip");
        }

        // METODO DELL' INTERFACCIA
        public void Vola()
        {
            Console.WriteLine($"{nomeAnimale}: 'Sto volando!!!'");
        }
    }
}
