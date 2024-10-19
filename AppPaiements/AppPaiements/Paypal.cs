using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace AppPaiements
{
    internal class Paypal : Paiement
    {
        // le propriete
        public string Courriel { get; set; }

        //le constructeur
        public Paypal(string email, double montant, string description) : base(montant, description)
        {
            Courriel = email;
        }
        // la methode
        public virtual void AfficheDetails()
        {
            Console.WriteLine($"le montant est {Montant}, la description est {Description} et son email est {Courriel}.");
        }
    }
}
