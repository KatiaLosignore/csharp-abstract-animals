﻿using csharp_abstract_animals.@interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_abstract_animals.@abstract
{
    public class Cane : Animale, INuotante
    {
        // COSTRUTTORE
        public Cane(string nomeAnimale) : base(nomeAnimale)
        {
        }

        // METODI DELLA CLASSE ASTRATTA
        public override void CosaMangi()
        {
            Console.WriteLine("Carne");
        }

        public override void Verso()
        {
            Console.WriteLine("Bau");
        }

        // METODO DELL' INTERFACCIA
        public void Nuota()
        {
           Console.WriteLine($"{nomeAnimale}: 'Sto nuotando!!!'");
        }
    }
}
