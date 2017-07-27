using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Smoke.Models
{
    [Table("Client")]
    public class Client 
    {
        [Key]
        public int IdCli { get; set; }

        [Required]
        [Display(Name = "Nom")]
        [StringLength(50)]
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Adresse { get; set; }
        public virtual ICollection<Commande> Commande { get; set; }
        public Client(int id, string nom, string prenom, string adresse)
        {
            this.IdCli = id;
            this.Nom = nom;
            this.Prenom = prenom;
            this.Adresse = adresse;
        }
        public Client()
        {
            Commande = new HashSet<Commande>();
        }
    }
}