using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPaiements
{
    internal class Utilisateur
    {
        //le propriete
        public string Nom { get; set; }
        public List<Paiement> Paiements { get; set; }

        //le constructeur 
        public Utilisateur(string nom)
        {
            Nom = nom;
            Paiements = new List<Paiement>();
        }

        //la methode 
        public void AjouterPaiement(Paiement paiement)
        {
            Paiements.Add(paiement);
        }
        public void Afficherinfos()
        {
            Console.WriteLine($"le nom d'utilisateur est {Nom} et son paiement est : ");
            foreach (var paiement in Paiements)
            {
                paiement.AfficherDetails();
            }
        }
    }
}
