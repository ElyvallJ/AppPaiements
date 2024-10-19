using AppPaiements;

internal class Program
{
    private static void Main(string[] args)
    {
        // les instances de la classe CarteCredit
        CarteCredit carteCredit1 = new CarteCredit(30013, 10000, "L'argent de l'école");
        CarteCredit carteCredit2 = new CarteCredit(45213, 5000, "L'argent du nouritture");
        CarteCredit carteCredit3 = new CarteCredit(96313, 1500, "L'argent de loisir");
        
        //Afficher les details de ces objets
        List<CarteCredit> CarteCredits = new List<CarteCredit> { carteCredit1, carteCredit2, carteCredit3 };
        Console.WriteLine("les cartes de credits sont :");
        foreach (var CarteCredit in CarteCredits)
        {
            CarteCredit.AfficherDetails();
        }

    }
}