using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Smoke.Models
{
    [Table("Commande")]
    public class Commande
    {
        [Key]
        public int IdCmd { get; set; }
        public Categorie IdCat { get; set; }
        public Article IdArt { get; set; }
        public Client IdCli { get; set; }
        public virtual Categorie Categorie { get; set; }
        public virtual Client Client { get; set; }
        public virtual Article Article { get; set; }

        public Commande(int Id, Categorie idCat, Article idArt, Client idCli)
        {
            this.IdCmd = Id;
            this.IdCat = idCat;
            this.IdArt = idArt;
            this.IdCli = idCli;

        }

        public Commande()
        {
            
        }
    }
}
