// See https://aka.ms/new-console-template for more information
using HodinaDesata;

SpravceVozidel spravce = new SpravceVozidel();

spravce.PridejVozidlo(new Automobil(2023, "červená", "Ferrari", 2, "LaFerrari"));
spravce.PridejVozidlo(new Motocykl(2022, "bílý", "Harley Davidson", 2, 1500));
spravce.PridejVozidlo(new Motocykl(2022, "bílý", "ČZ", 2, 50));
for (int i = 0; i < spravce.VratPocetVozidel(); i++)
{
    Vozidlo vozidlo = spravce.VratVozidlo(i);

    Console.WriteLine(vozidlo.ToString());
    Console.WriteLine(vozidlo);
}


//if(vozidlo is Automobil)
//{
//    Automobil auto=(Automobil)vozidlo;
//    Console.WriteLine($"{auto.Vyrobce} {auto.Typ} {auto.RokVyroby}");
//}

spravce.SmazVozidlo(spravce.VratVozidlo(1));
spravce.SmazVozidlo(spravce.VratVozidlo(0));

Console.WriteLine("Počet vozidel: " + spravce.VratPocetVozidel());

Console.ReadLine();
