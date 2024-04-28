using System;

namespace ProjetC_MVCSalleSport.Models
{
    internal class Admin
    {
        public Admin()
        {
        }

        public int id_admin;

        public String nom;

        public String prenom;

        public String motDePasse;

        public String mail;

        public Membre[] mebres;

        public Cours[] cours;

        public Coach[] coach;
    }
}