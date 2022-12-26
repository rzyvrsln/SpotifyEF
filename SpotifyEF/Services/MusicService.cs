using Microsoft.EntityFrameworkCore;
using SpotifyEF.DAL;
using SpotifyEF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotifyEF.Services
{
    internal class MusicService
    {
        public void Add(int categorieId, int duration,string name)
        {
            Music music = new Music();
            music.Name = name;
            music.Duration = duration;
            music.CategorieId = categorieId;
            using (AppDbContext db = new AppDbContext())
            {
                db.musics.Add(music);
                db.SaveChanges();
            }

        }

        public ICollection<Music> GetAll()
        {
            ICollection<Music> music;

            using (AppDbContext db = new AppDbContext())
            {
                music = db.musics.ToList();
            }
            return music;
        }
    }
}
