using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Reflection;

class Hundred
{

    private Random random = new Random();
    private int num_of_players = 1;
    private int turnpoints = 0;
    private List<string> playerNames = new List<string>();
    private List<int> playerScores = new List<int>();



    public void Play()
    {
        playerSelect();

        int playernumber = 0;



        while (true)
        {
            turnpoints = DiceTurn(playernumber);

            playerScores[playernumber] += turnpoints;

            if (playernumber == num_of_players - 1)
            {
                ShowScoreboard();
            }

            if (playerScores[playernumber] >= 100)
            {
                Console.WriteLine(playerNames[playernumber] + " WON THE GAME!");
                break; // Exit the loop if user hits 100 points or more
            }
            playernumber = (playernumber + 1) % num_of_players;

        }
        ShowScoreboard();


    }

    private void playerSelect()
    {
        Console.WriteLine("Welcome to first to 100!");
        Console.WriteLine("How many players are there?");

        num_of_players = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i < num_of_players + 1; i++)
        {
            Console.WriteLine("Whats is player #" + i + " name?");
            string playername = Console.ReadLine();

            playerNames.Add(playername);
            playerScores.Add(0);
        }

        Console.WriteLine("The players are:");

        for (int i = 0; i <= num_of_players - 1; i++)
        {
            Console.WriteLine(playerNames[i]);
        }

        ShowScoreboard();
        Console.WriteLine("Let the game begin!");
    }

    private int DiceTurn(int playernumber)
    {
        Console.WriteLine("________________");
        Console.WriteLine("It is " + playerNames[playernumber] + "'s turn!");

        int turnpoints = 0;
        string diceagain = "y";


        while (diceagain == "y")
        {
            int newDice = RollDice();

            if (newDice == 1)
            {
                Console.WriteLine("Unfortunally you rolled a 1 and lose your points this round.");
                turnpoints = 0;

                break;
            }
            turnpoints += newDice;

            if (playerScores[playernumber] + turnpoints >= 100)
            {
                Console.WriteLine(playerNames[playernumber] + " WON THE GAME!");
                return turnpoints;
            }

            Console.WriteLine("Points this far in this round: " + turnpoints);
            Console.WriteLine("Roll dice again? (y/n)");
            diceagain = Console.ReadLine();
            if (diceagain == "n")
            {
                continue;
            }
        }

        Console.WriteLine("You gathered " + turnpoints + " points this round, amazing!");
        return turnpoints;
    }

    private int RollDice()
    {
        int diceRoll = random.Next(1, 7);
        Console.WriteLine("You rolled a :" + diceRoll);
        return diceRoll;
    }

    private void ShowScoreboard()
    {
        Console.WriteLine("___SCOREBOARD___");
        for (int i = 0; i < playerScores.Count; i++)
        {
            Console.WriteLine(playerNames[i] + ": " + playerScores[i]);
        }
        Console.WriteLine("________________");

    }
}