using System;

namespace ProjetC_MVCSalleSport.Models
{
    internal class Cours
    {
        public Cours()
        {
        }

        public int id_cours;

        public String nom;

        public DateTime date;
        public String heure;

        public String type;

        private Membre membre;

        public Coach coach;

        private Admin admin;
    }
}
