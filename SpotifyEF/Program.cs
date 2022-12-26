using Microsoft.EntityFrameworkCore;
using SpotifyEF.DAL;
using SpotifyEF.Models;
using SpotifyEF.Services;

namespace SpotifyEF
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            #region Categorie

            //CategorieService categorieService = new CategorieService();
            //categorieService.Add("Pop");



            //categorieService.Remove(6);

            //categorieService.Update(2, "Excited");

            //ICollection<Categorie> categories = categorieService.GetAll();

            //foreach (Categorie cat in categories)
            //{
            //    Console.WriteLine($"{cat.Name}");
            //}

            //Categorie categorie = categorieService.GetbyId(1);

            //Console.WriteLine( categorie.Id+" "+categorie.Name);

            #endregion

            #region Music

            //MusicService musicService = new MusicService();
            //musicService.Add(1,400, "Sən olmuşam");

            //ICollection<Music> musics = musicService.GetAll();

            #endregion

        }
    }
}