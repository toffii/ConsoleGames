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
                Console.WriteLine("1. Hundred (2-6 players)");
                Console.WriteLine("2. Tic Tac Toe (2 Players)");
                Console.WriteLine("What game do you want to play? (select by number)");

                int selectedGame = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("________________");

                switch (selectedGame)
                {
                    case 1:
                        Hundred hundred = new Hundred();
                        hundred.Play();
                        break;
                    case 2:
                        //Console.WriteLine("Do you need reading glasses? IT SAYS COMING SOON!");
                        TicTacToe tictactoe = new TicTacToe();
                        tictactoe.Play();
                        break;
                }
            }
        }

    }
}
