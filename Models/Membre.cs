using System;
using System.Collections.Generic;

namespace ProjetC_MVCSalleSport.Models
{
    internal class Membre
    {
        public Membre()
        {
        }
        public int id_membre { get; set; }

        public String nom { get; set; }

        public String prenom { get; set; }

        public int telephone { get; set; }

        public String motDePasse { get; set; }

        public String mail { get; set; }
        public ICollection<Abonnement> Abonnements { get; set; }


        public Progrés progrés { get; set; }

        public Coach coach { get; set; }

        public Admin admin { get; set; }
    }
}
