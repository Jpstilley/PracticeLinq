using System;
using System.Collections.Generic;
using System.Linq;

namespace PracticeLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            var myGames = new List<string>();

            myGames.Add("Pacman");
            myGames.Add("Tetris");
            myGames.Add("Wii Sports");
            myGames.Add("Sonic the HedgeHog");
            myGames.Add("The Sims");
            myGames.Add("Diablo III");
            myGames.Add("Super Mario Bros");
            myGames.Add("The Legend of Zelda");
            myGames.Add("Metal Gear Solid");
            myGames.Add("Halo");
            myGames.Add("Final Fantasy");

            myGames = myGames.OrderBy(value => value.Length).ToList();
            foreach(string value in myGames)
            {
                Console.WriteLine(value);
            }

        }
    }
}
