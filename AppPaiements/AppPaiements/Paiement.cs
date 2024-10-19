using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPaiements
{
    internal class Paiement
    {
        // la propriété
        public double Montant { get; set; }
        public string Description { get; set; }

        //Un constructeur
        public Paiement(double montant, string description)
        {
            Montant = montant;
            Description = description;
        }

        //Une methode
        public virtual void AfficherDetails()
        {
            Console.WriteLine($"le montant est {Montant} et ça description est {Description}");
        }
    }
}
