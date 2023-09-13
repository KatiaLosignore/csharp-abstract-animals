// See https://aka.ms/new-console-template for more information

using csharp_abstract_animals;

// Istanzio le classi create

Cane caneOne = new Cane();
Passerotto passerottoOne = new Passerotto();
Aquila aquilaOne = new Aquila();
Delfino delfinoOne = new Delfino();

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
    Console.WriteLine($"Animale {numero}:");
    Console.WriteLine($"Verso: ");
    animale.Verso();
    Console.WriteLine($"Cosa Mangia: ");
    animale.CosaMangi();
    Console.WriteLine($"Come dorme: ");
    animale.Dormi();

    Console.WriteLine();
    numero++;
}