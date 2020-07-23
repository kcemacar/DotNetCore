using System.Collections.Generic;
using System.Linq;

namespace MovieApp.Models
{
    public static class Repository
    {
        private static List<Moviem> _movies = null ;

        static Repository(){
            _movies = new List<Moviem>()
            {
                new Moviem() {Id = 1, Name = "Minik Ağaç", ShortDescription="kaya ağaç" ,Description = "Kayanın üzerinde minik ağaç", ImageUrl = "1.jpg"},
                new Moviem() {Id = 2, Name = "Martı",ShortDescription="4 martı" , Description = "4 martı 4 şezlongun üzerinde", ImageUrl = "2.jpg"},
                new Moviem() {Id = 3, Name = "Kafatası",ShortDescription="koyun derisi" , Description = "Koyunun derisi gitmiş yazık", ImageUrl = "3.jpg"},
                
            };
        }

        public static List<Moviem> Movies
        {
            get
            {
                return _movies;
            }

        }

        public static void AddMovie(Moviem entity)
        {
            _movies.Add(entity);
        }

        public static Moviem GetById(int id)
        {
            return _movies.FirstOrDefault(i => i.Id == id); // gelen her filmin id sine bakar eğer istediğimiz id ile eşleşirse geri gönderir.
        }


    }



}