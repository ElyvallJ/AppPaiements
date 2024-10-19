using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace AppPaiements
{
    internal class CarteCredit : Paiement
    {
        // la propriete
        public int NumeroCarte { get; set; }

        //le constructeur
        public CarteCredit(int numeroCarte, double montant, string description) : base(montant, description)
        {
            NumeroCarte = numeroCarte;
        }
        // la methode
        public override void AfficherDetails()
        {
            Console.WriteLine($"le numéro de la carte est {NumeroCarte},le montant est {Montant} et la description est {Description}.");
        }
    }
}
