using System;
using System.Text.RegularExpressions;

using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace FootBallOPP
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Players> playerList = new List<Players>();

            Players player1 = new Players();
            player1.PlayerName = "Carson Wentz";
            player1.TeamOf = "Eagles";
            player1.PlayerNum = "11";
            player1.Position = "QB";
            playerList.Add(player1);

            Players player2 = new Players();
            player2.PlayerName = "Odell Beckham Jr";
            player2.TeamOf = "Giants";
            player2.PlayerNum = "13";
            player2.Position = "WR";
            playerList.Add(player2);

            Players player3 = new Players();
            player3.PlayerName = "Todd Gurley";
            player3.TeamOf = "Rams";
            player3.PlayerNum = "24";
            player3.Position = "RB";
            playerList.Add(player3);

            Players player4 = new Players();
            player4.PlayerName = "Alshon Jeffrey";
            player4.TeamOf = "Eagles";
            player4.PlayerNum = "17";
            player4.Position = "WR";
            playerList.Add(player4);



            Console.WriteLine("Enter a player, team, or position.");
            string input = Console.ReadLine();

            
            foreach (Players x in playerList)
            {
                if (x.PlayerName == input)
                {
                    Players disdude = x;
                    ReturnINfo(disdude);
                }
            }

            foreach (Players x in playerList)
            {
                if (x.TeamOf == input)
                {
                    Players disdude = x;
                    ReturnINfo(disdude);
                }
            }

            foreach (Players x in playerList)
            {
                if (x.Position == input)
                {
                    Players disdude = x;
                    ReturnINfo(disdude);
                }
            }
            Console.ReadLine();

        }
        public static void ReturnINfo(Players disdude)
        {
            Console.WriteLine(disdude.PlayerName + " " + disdude.PlayerNum + " " + disdude.TeamOf + " " + disdude.Position + " ");
        }
    }
}

