using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo06kotitehtävät
{
    class Program
    {
        static void Main(string[] args)
        {



            Vinyl album = new Vinyl { Album = "A Hard Days Night", Artist = " The Beatles " };


            Song song1 = new Song { Songs = " 1. A Hard Days Night ", Length = 2.34 };
            Song song2 = new Song { Songs = " 2. I Should Have Known Better ", Length = 2.43 };
            Song song3 = new Song { Songs = " 3. If I Fell ", Length = 2.19 };
            Song song4 = new Song { Songs = " 4. Im Happy Just To Dance With You ", Length = 1.56 };
            Song song5 = new Song { Songs = " 5. And I Love Her ", Length = 2.30 };
            Song song6 = new Song { Songs = " 6. Tell Me Why ", Length = 2.09 };
            Song song7 = new Song { Songs = " 7. Cant Buy Me Love ", Length = 2.12 };
            Song song8 = new Song { Songs = " 8. Any Time At All ", Length = 2.11 };
            Song song9 = new Song { Songs = " 9. Ill Cry Instead ", Length = 1.46 };
            Song song10 = new Song { Songs = "10. Things We Said Today ", Length = 2.35 };
            Song song11 = new Song { Songs = "11. When I Get Home ", Length = 2.17 };
            Song song12 = new Song { Songs = "12. You Cant Do That ", Length = 2.35 };
            Song song13 = new Song { Songs = "13. Ill Be Back ", Length = 2.24 };


            album.AddSong(song1);
            album.AddSong(song2);
            album.AddSong(song3);
            album.AddSong(song4);
            album.AddSong(song5);
            album.AddSong(song6);
            album.AddSong(song7);
            album.AddSong(song8);
            album.AddSong(song9);
            album.AddSong(song10);
            album.AddSong(song11);
            album.AddSong(song12);
            album.AddSong(song13);

            album.PrintCollection();

        }
        }
        }