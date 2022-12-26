using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotifyEF.Models
{
    internal class Categorie
    {
        public int Id { get; set; }
        [StringLength(10)]
        public string Name { get; set; }
        public List<Music> musics { get; set; }
    }
}
