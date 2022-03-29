using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    public class Song
    {
        public string Title { get; set; }
        public string Artist { get; set; }  
        public Genre Genre { get; set; }
        public double Duration { get; set; }

        public Song(string title , string artist , Genre genre , double duration)
        {
            Title = title; ;
            Artist = artist;
            Genre = genre;
            Duration = duration;
        }

    }
}
