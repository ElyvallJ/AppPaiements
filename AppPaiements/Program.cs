using AppPaiements;

internal class Program
{
    private static void Main(string[] args)
    {
        CarteCredit carteCredit1 = new CarteCredit(30013,10000,"L'argent de l'école");
        CarteCredit carteCredit2 = new CarteCredit(30013, 5000, "L'argent du nouritture");
        CarteCredit carteCredit3 = new CarteCredit(30013, 1500, "L'argent de sport");

        List<CarteCredit> CarteCredits = new List<CarteCredit> { carteCredit1, carteCredit2, carteCredit3 };
        
        Console.WriteLine("les livres dans la liste, leurs details est :");
        foreach (var CarteCredit in CarteCredits)
        {
            CarteCredit.AfficherDetails();
        }
    }
}