using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//namespace ConsoleGamesSelectPlayers
//{
    class ConsoleGamesSelectPlayers
    {
        public List<String> PlayerSelect()
        {
            Console.WriteLine("How many players are there?");
            int num_of_players = Convert.ToInt32(Console.ReadLine());
            List<String> playerNames = new List<String>();

            for (int i = 1; i < num_of_players + 1; i++)
            {
                Console.WriteLine("Whats is player #" + i + " name?");
                string playername = Console.ReadLine();

                playerNames.Add(playername);
            }

            Console.WriteLine("The players are:");

            for (int i = 0; i <= num_of_players -1; i++)
            {
                Console.WriteLine("#" + i + " " + playerNames[i]);
            }

            Console.WriteLine("Let the game begin!");
            return playerNames;
        }
    }    
//}