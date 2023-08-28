using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGames
{
    class program
    {
        static void Main()
        {
            while (true)
            {
                Console.WriteLine("________________");
                Console.WriteLine("Games:");
                Console.WriteLine("1. Hundred");
                Console.WriteLine("What game do you want to play? (select by number)");

                int selectedGame = Convert.ToInt32(Console.ReadLine());

                switch (selectedGame)
                {
                    case 1:
                        Console.WriteLine("________________");
                        Hundred hundred = new Hundred();
                        hundred.Play();
                        break;
                }
            }
        }

    }
}
