﻿// See https://aka.ms/new-console-template for more information

using csharp_abstract_animals.@abstract;
using csharp_abstract_animals.@interface;


// Istanzio le classi create

Cane caneOne = new Cane("Cane");
Passerotto passerottoOne = new Passerotto("Passerotto");
Aquila aquilaOne = new Aquila("Aquila");
Delfino delfinoOne = new Delfino("Delfino");

// Creo una lista della classe astratta Animale

List<Animale> animali = new List<Animale>();

// aggiungo le classi create alla Lista Animale
animali.Add(caneOne);
animali.Add(passerottoOne);
animali.Add(aquilaOne);
animali.Add(delfinoOne);


int numero = 1;

// Ciclo la lista Animale creata

foreach (Animale animale in animali)
{
    Console.WriteLine($"Animale {numero} - {animale.nomeAnimale}:");
    Console.Write($"Verso: ");
    animale.Verso();
    Console.Write($"Cosa Mangia: ");
    animale.CosaMangi();
    Console.Write($"Come dorme: ");
    animale.Dormi();

    Console.WriteLine();
    numero++;
}

Console.WriteLine("-------------------------------------------------");


// INTERFACCE


// Richiamo i metodi creati e li applico nelle classi corrispondenti
/*
caneOne.Nuota();
passerottoOne.Vola();
aquilaOne.Vola();
delfinoOne.Nuota();
*/

// Creo i metodi FaiVolare / FaiNuotare passandogli come parametro l'animale corretto.
static void FaiNuotare(INuotante animale)
{
    animale.Nuota();
}

static void FaiVolare(IVolante animale)
{
    animale.Vola();
}

// Ciclo e richiamo i metodi FaiVolare / FaiNuotare creati 

foreach (Animale animale in animali)
{
    if (animale is IVolante)
        FaiVolare((IVolante)animale);
    else if (animale is INuotante)
        FaiNuotare((INuotante)animale);

    Console.WriteLine();
}