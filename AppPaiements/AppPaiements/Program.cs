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
        Console.WriteLine();

        //les instances de la classe Paypal
        Paypal paypal1 = new Paypal("elyvall@yahoo.com", 100000, "Rich");
        Paypal paypal2 = new Paypal("habib@yahoo.com", 1000, "Poor");

        //Afficher les details de ces objets
        List<Paypal> paypals = new List<Paypal> { paypal1, paypal2 };
        Console.WriteLine("les paypals sont :");
        foreach (var Paypal in paypals)
        {
            Paypal.AfficheDetails();
        }
        Console.WriteLine();

        // les instances Utilisateur 
        
        Utilisateur utilisateur1 = new Utilisateur("Neymar");
        List<Utilisateur> utilisateurs = new List<Utilisateur> { utilisateur1 };
        foreach(var utilisateur in utilisateurs) 
        { 
            utilisateur.AjouterPaiement(paypal1);
            utilisateur.AjouterPaiement(paypal2);
            utilisateur.AjouterPaiement(carteCredit1);
            utilisateur.AjouterPaiement(carteCredit2);
            utilisateur.AjouterPaiement(carteCredit3);

            utilisateur.Afficherinfos();
        }
    }
}