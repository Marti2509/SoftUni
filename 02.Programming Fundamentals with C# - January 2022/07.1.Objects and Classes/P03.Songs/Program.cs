using System;
using System.Collections.Generic;

namespace P03.Songs
{
    class Song
    {
        public Song(string type, string name, string time)
        {
            Time = time;
            Name = name;
            Type = type;
        }

        public string Type { get; set; }
        public string Name { get; set; }
        public string Time { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Song> songs = new List<Song>();

            for (int i = 0; i < n; i++)
            {
                string data = Console.ReadLine();

                string typeSong = data.Split('_')[0];
                string nameSong = data.Split('_')[1];
                string timeSong = data.Split('_')[2];

                Song song = new Song(typeSong, nameSong, timeSong);

                songs.Add(song);
            }

            string command = Console.ReadLine();

            if (command == "all")
            {
                foreach (Song song in songs)
                {
                    Console.WriteLine(song.Name);
                }
            }
            else
            {
                foreach (Song song in songs)
                {
                    if (command == song.Type)
                    {
                        Console.WriteLine(song.Name);
                    }
                }
            }
        }
    }
}
