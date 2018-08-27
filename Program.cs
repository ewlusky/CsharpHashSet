using System;
using System.Collections.Generic;

namespace nickelback
{
    class Program
    {
        static void Main(string[] args)
        {
            List<(string, string)> goodSongs = new List<(string, string)>();
            HashSet<(string Band, string Song)> allSongs = new HashSet<(string, string)>()
            {
                ("TTNG", "Coconut Crab"),
                ("TTNG", "In Praise of Idleness"),
                ("Nickelback", "Some Mediocre Song"),
                ("Nickelback", "I Mean Plenty of People Liked them"),
                ("Nickelback", "Memes Last Forever"),
                ("Polyphia", "Euphoria"),
                ("Carpenter Brut", "Turbo Killer"),
            };

            foreach (var item in allSongs)
            {
                if (item.Band != "Nickelback")
                {
                    goodSongs.Add(item);
                }
            }

            foreach (var item in goodSongs)
            {
                Console.WriteLine(item);
            }
        }
    }
}
