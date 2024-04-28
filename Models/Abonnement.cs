using System;

namespace ProjetC_MVCSalleSport.Models
{
    internal class Abonnement
    {
        public Abonnement()
        {
        }

        public int id_ab;

        public Date dateDebut;

        public Date dateFin;

        public bool payement;

        public String typeCours;
        public int id_membre { get; set; }
        public Membre Membre { get; set; }
    }
}
