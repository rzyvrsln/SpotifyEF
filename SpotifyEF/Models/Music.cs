using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotifyEF.Models
{
    internal class Music
    {
        public int Id { get; set; }
        [StringLength(40)]
        public string Name { get; set; }
        [Range(30, 700)]
        public int Duration { get; set; }
        public int CategorieId { get; set; }
        public Categorie Categorie { get; set; }

    }
}
