using System;

namespace ProjetC_MVCSalleSport.Models
{
    internal class Coach
    {
        public Coach()
        {
        }

        public int id_coach;

        public String nom;

        public String prenom;

        public int telephone;

        public String motDePasse;

        public String mail;

        public Admin admin;

        public Membre membre;
    }
}
