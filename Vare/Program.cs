// instans af varekartotek, så dent metoder kan benyuttes
VareKartotek vareKartotek = new VareKartotek();

// objekter at typen Vare oprettes
Vare appelsin = new Vare { VareNr = 1, VareNavn = "Appelsin", Antal = 10, Pris = 5 };
Vare æble = new Vare { VareNr = 2, VareNavn = "Appelsin", Antal = 5, Pris = 3 };
Vare tomat = new Vare { VareNr = 3, VareNavn = "Tomat", Antal = 15, Pris = 2 };
Vare vandmelon = new Vare { VareNr = 4, VareNavn = "Vandmelon", Antal = 2, Pris = 20 };

// tester om objekter kan indsættes i liste i vareKartotek via IndSet metoden
vareKartotek.IndSet(appelsin);
vareKartotek.IndSet(æble);
vareKartotek.IndSet(tomat);
bool isSucces = vareKartotek.IndSet(vandmelon);
Console.WriteLine($"Blev vandmelon oprette i Listen ? {isSucces}\n");

// tester om PrintVare kan printe, når den får passet et id
//! vareKartotek.PrintVare(1);

// tester om PrintAlle metoden virker
vareKartotek.PrintAlle();

// tester BeregnVerdi
int resultat = vareKartotek.BeregnVerdi();
Console.WriteLine("\nLagerværdi er: " + resultat + " kr.");

// tester om Slet metoden virker
bool isDeleted = vareKartotek.Slet(4);
Console.WriteLine($"\nBlev vare slettet ? {isDeleted}");



class VareKartotek
{
    List<Vare> vareKartotek;

    public VareKartotek()
    {
        vareKartotek = new List<Vare>();
    }

    public bool IndSet(Vare vare)
    {
        vareKartotek.Add(vare);
        return true;
    }

    public bool Slet(int id)
    {
        foreach (var vare in vareKartotek)
        {
            if (vare.VareNr == id)
            {
                vareKartotek.Remove(vare);
                return true;
            }
        }
        return false;
    }

    public void PrintVare(int id)
    {
        var toPrint = vareKartotek.Where(p => p.VareNr == id);

        foreach (var vare in vareKartotek)
        {
            Console.WriteLine($"VareNr {vare.VareNr} printes:\n\tNavn: {vare.VareNavn}\n\tPris: {vare.Pris}\n\tAntal på lager: {vare.Antal}");
        }
    }

    public void PrintAlle()
    {
        vareKartotek.ForEach(vare => Console.WriteLine($"VareNr {vare.VareNr} printes:\n\tNavn: {vare.VareNavn}\n\tPris: {vare.Pris}\n\tAntal på lager: {vare.Antal}"));
    }

    public int BeregnVerdi()
    {
        var Total = vareKartotek.Sum(p => p.Pris * p.Antal);
        return Total;
    }
}

class Vare
{
    public int VareNr { get; set; }
    public string VareNavn { get; set; }
    public int Pris { get; set; }
    public int Antal { get; set; }
}



