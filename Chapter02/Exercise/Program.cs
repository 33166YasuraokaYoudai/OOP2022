using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise {
    class Program {
        static void Main(string[] args) {

            /*
            var songs = new List<Song>();

            var song1 = new Song("歌のタイトル","アーティスト名",1);
            songs.Add(song1);
            var song2 = new Song("歌のタイトル", "アーティスト名", 1);
            songs.Add(song2);
            var song3 = new Song("歌のタイトル", "アーティスト名", 1);
            songs.Add(song3);
            */
            var songs = new Song[] {
                new Song ("ああああ","アーティスト名11",180),
                new Song ("いいいい","アーティスト名22",240),
                new Song ("うううう","アーティスト名33",60),
                new Song ("ええええ","アーティスト名44",600),
            };
            PrintSongs(songs);
        }
        private static void PrintSongs(Song[] songs) {
            foreach (var song in songs) {
                Console.WriteLine("{0},{1},{2:m\\:ss}", song.Title, song.ArtistName, TimeSpan.FromSeconds(song.Length));

            }
        }
    }
}
