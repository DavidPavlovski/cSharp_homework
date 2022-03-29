using System;
using System.Collections.Generic;

namespace Classes
{
    public class Person
    {
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName => $"{FirstName} {LastName}";
        public List<Genre> FavoriteGenre { get; set; }
        public List<Song> FavoriteSongs { get; set; }

        public Person(string id, string firstName, string lastName)
        {
            Id=id;
            FirstName = firstName;
            LastName = lastName;
            FavoriteGenre = new List<Genre>();
            FavoriteSongs = new List<Song>();
        }
        public void AddFavoriteSong(Song song)
        {
            FavoriteSongs.Add(song);
        }
        public void AddFavoriteGenre(Genre genre)
        {
            FavoriteGenre.Add(genre);
        }

        public void GetFavoriteSongs()
        {
            if (FavoriteSongs.Count == 0)
            {
                Console.WriteLine($"{FullName} hates music :(");
                return;
            }
            Console.WriteLine($"{FullName}'s favorite songs:");
            foreach (Song song in FavoriteSongs)
            {
                Console.WriteLine($"{song.Title} by {song.Artist} - {song.Duration}min");
            }
        }
        public void GetFavoriteGenres()
        {
            if (FavoriteGenre.Count == 0)
            {
                Console.WriteLine($"{FullName} does not like anything.");
                return;
            }
            Console.WriteLine($"{FullName}'s favorite music genres : ");
            foreach (Genre genre in FavoriteGenre)
            {
                Console.WriteLine(genre);
            }
        }

    }
}
