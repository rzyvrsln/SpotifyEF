using Microsoft.EntityFrameworkCore;
using SpotifyEF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotifyEF.DAL
{
    internal class AppDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=DESKTOP-LKEG3NN\\SQLEXPRESS;Database=SpotifyEF;Trusted_Connection=true;Encrypt=false");
        }

        public DbSet<Categorie> categories { get; set; }
        public DbSet<Music> musics { get; set; }
    }
}
