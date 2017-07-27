using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Smoke.Models
{
    [Table("Article")]
    public class Article
    {
        [Key]
        public int IdArt { get; set; }
        public float Prix { get; set; }
        public string Nom { get; set; }
        public string Description { get; set; }
        public string UrlImage { get; set; }
        public Categorie IdCat { get; set; }

        public virtual Categorie Categorie { get; set; }
        public virtual ICollection<Commande> Commande { get; set; }
        public Article(int Id, float prix, Categorie idCat,string nom,string description, string urlImage)
        {
            this.IdArt = Id;
            this.Prix = prix;
            this.IdCat = idCat;
            this.Nom = nom;
            this.Description = description;
            this.UrlImage = urlImage;
        }
        public Article()
        {
            Commande = new HashSet<Commande>();
        }
    }
}