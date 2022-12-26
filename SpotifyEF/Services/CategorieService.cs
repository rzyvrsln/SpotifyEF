using Microsoft.EntityFrameworkCore;
using SpotifyEF.DAL;
using SpotifyEF.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotifyEF.Services
{
    internal class CategorieService
    {
        public void Add(string name)
        {
            Categorie categorie = new Categorie();
            categorie.Name = name;
            using (AppDbContext db = new AppDbContext())
            {
                db.categories.Add(categorie);
                db.SaveChanges();
            }
        }

        public void Remove(int id)
        {
            Categorie categorie;
            using (AppDbContext db = new AppDbContext())
            {
                categorie = db.categories.FirstOrDefault(c => c.Id == id);
                db.categories.Remove(categorie);
                db.SaveChanges();
            }
        }

        public ICollection<Categorie> GetAll()
        {
            ICollection <Categorie> categorie;

            using (AppDbContext db = new AppDbContext())
            {
                categorie = db.categories.ToList();
            }
            return categorie;
        }

        public Categorie GetbyId(int id)
        {
            Categorie categorie;
            using (AppDbContext db = new AppDbContext())
            {
                categorie = db.categories.FirstOrDefault(x => x.Id == id);
            }
            return categorie;
        }

        public void Update(int id,string name)
        {
            Categorie categorie;
            using(AppDbContext db = new AppDbContext())
            {
                categorie = db.categories.FirstOrDefault(c => c.Id == id);
                categorie.Name = name;
                db.categories.Update(categorie);
                db.SaveChanges();
            }
        }
    }
}
