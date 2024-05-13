using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProjetC_MVCSalleSport.Models
{
    public class Cours
    {
        [Key]
        public int id_cours { get; set; }
        public string nom { get; set; }
        public DateTime date { get; set; }
        public string heure { get; set; }
        public string type { get; set; }
        public string NomCoach { get; set; }
        public ICollection<Membre> membres { get; set; }
        public Coach coach { get; set; }
        public ICollection<Admin> admin { get; set; }
    }
}
