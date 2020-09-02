using System;
using System.Collections.Generic;
using System.Linq;

namespace ShootingDice
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player1 = new Player();
            player1.Name = "Bob";

            Player player2 = new Player();
            player2.Name = "Sue";

            player2.Play(player1);

            Console.WriteLine("-------------------");

            Player player3 = new Player();
            player3.Name = "Wilma";

            player3.Play(player2);

            Console.WriteLine("-------------------");

            Player large = new LargeDicePlayer();
            large.Name = "Bigun Rollsalot";

            player1.Play(large);

            Console.WriteLine("-------------------");

            SmackTalkingPlayer mackthesmack = new SmackTalkingPlayer();
            mackthesmack.Name = "Mack";
            mackthesmack.Taunt = "You're a loser who always loses.";

            mackthesmack.Play(player2);
            Console.WriteLine("-------------------");

            OneHigherPlayer highBall = new OneHigherPlayer();
            highBall.Name = "Willie";

            highBall.Play(player3);
            Console.WriteLine("-------------------");

            HumanPlayer dumbmortal = new HumanPlayer();
            dumbmortal.Name = "BillyBob";

            dumbmortal.Play(large);
            Console.WriteLine("-------------------");

            CreativeSmackTalkingPlayer Mack2 = new CreativeSmackTalkingPlayer();
            Mack2.Name = "Mackie";
            Mack2.Play(player1);
            Console.WriteLine("-------------------");

            SoreLoserPlayer sadBoi = new SoreLoserPlayer();
            sadBoi.Name = "Brandon";

            sadBoi.Play(large);
            Console.WriteLine("-------------------");

            List<Player> players = new List<Player>()
            {
                player1,
                player2,
                player3,
                large,
                mackthesmack,
                highBall,
                dumbmortal,
                sadBoi
            };

            PlayMany(players);
        }

        static void PlayMany(List<Player> players)
        {
            Console.WriteLine();
            Console.WriteLine("Let's play a bunch of times, shall we?");

            // We "order" the players by a random number
            // This has the effect of shuffling them randomly
            Random randomNumberGenerator = new Random();
            List<Player> shuffledPlayers = players.OrderBy(p => randomNumberGenerator.Next()).ToList();

            // We are going to match players against each other
            // This means we need an even number of players
            int maxIndex = shuffledPlayers.Count;
            if (maxIndex % 2 != 0)
            {
                maxIndex = maxIndex - 1;
            }

            // Loop over the players 2 at a time
            for (int i = 0; i < maxIndex; i += 2)
            {
                Console.WriteLine("-------------------");

                // Make adjacent players play noe another
                Player player1 = shuffledPlayers[i];
                Player player2 = shuffledPlayers[i + 1];
                player1.Play(player2);
            }
        }
    }
}