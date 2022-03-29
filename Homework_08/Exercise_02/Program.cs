using Classes;
using System;
using System.Collections.Generic;

namespace Exercise_02
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Person person = new Person("11aa", "David", "Pavlovski");

            person.AddFavoriteGenre(Genre.Rock);
            person.AddFavoriteGenre(Genre.Metal);

            person.AddFavoriteSong(new Song("Cant stop", "Red Hot Chilli Peppers", Genre.Rock, 2.5));
            person.AddFavoriteSong(new Song("Rain", "The Cult", Genre.Rock, 2.5));
            person.AddFavoriteSong(new Song("Tommorow comes today", "Gorillaz", Genre.Other, 2.9));
            person.AddFavoriteSong(new Song("Two minutes to midnight", "Iron Maiden", Genre.Metal, 3.1));

            person.GetFavoriteSongs();
            person.GetFavoriteGenres();

            Console.WriteLine("*****************");

            Person person2 = new Person("11bb","Grumpy", "Grumpsky");
            person2.GetFavoriteGenres();
            person2.GetFavoriteSongs();

        }
    }
}
