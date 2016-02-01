using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo06kotitehtävät
{
    class Vinyl
    {

        public string Album { get; set; }
        public string Artist { get; set; }

        private List<Song> songs;




        public Vinyl()
        {
            songs = new List<Song>();
        }

        public void AddSong(Song song)
        {

            songs.Add(song);

        }




        public void PrintCollection()
        {
            Console.WriteLine("Name Of The Artist : " +Artist);
            Console.WriteLine("Name Of The Vinyl : " +Album);
            Console.WriteLine(" ");
            foreach (Song song in songs)
           {
              Console.WriteLine(song.ToString());
           }
        }



    }
}