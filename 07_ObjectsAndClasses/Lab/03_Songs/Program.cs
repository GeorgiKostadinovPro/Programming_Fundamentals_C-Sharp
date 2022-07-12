using System;
using System.Linq;

namespace _03_Songs
{
    public class Song
    {
        public Song(string typeList, string name, string time)
        {
            this.TypeList = typeList;
            this.Name = name;
            this.Time = time;
        }

        public string TypeList { get; set; }

        public string Name { get; set; }

        public string Time { get; set; }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Song[] songs = new Song[n];

            for (int i = 0; i < n; i++)
            {
                string[] songInfo = Console.ReadLine()
                    .Split('_', StringSplitOptions.RemoveEmptyEntries);

                string typeList = songInfo[0];
                string name = songInfo[1];
                string time = songInfo[2];

                Song song = new Song(typeList, name, time);
                songs[i] = song;
            }

            string printTypeListOrAll = Console.ReadLine();

            Song[] result = printTypeListOrAll != "all" 
                ? songs.Where(s => s.TypeList == printTypeListOrAll).ToArray() 
                : songs;

            foreach (var song in result)
            {
                Console.WriteLine(song.Name);
            }
        }
    }
}