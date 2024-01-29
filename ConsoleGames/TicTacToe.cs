using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Reflection;

class TicTacToe
{
    private int num_of_players = 2;
    private List<string> playerNames = new List<string>(2);

    public void Play()
    {
        ConsoleGamesSelectPlayers selectPlayers = new ConsoleGamesSelectPlayers();
        playerNames = selectPlayers.PlayerSelect();
    }

    private void ShowGameBoard()
    {

    }



}
