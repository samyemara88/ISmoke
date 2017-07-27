using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Smoke.Models
{
    [Table("Categorie")]
    public class Categorie  
    {
        [Key]
        public int IdCat { get; set; }
        public string Nom { get; set; }
        public string UrlImage { get; set; }

        public virtual ICollection<Article> Article { get; set; }
        public Categorie(int Id, string nomCat,string urlImage )
        {
            this.IdCat = Id;
            this.Nom = nomCat;
            this.UrlImage = urlImage;
        }

        public Categorie()
        {
            Article = new HashSet<Article>();
        }
    }
}
