using System;
using System.Collections.Generic;

namespace ShootingDice
{
    // A SmackTalkingPlayer who randomly selects a taunt from a list to say to the other player
    public class CreativeSmackTalkingPlayer : Player
    {
        private List<string> tauntList = new List<string>()
        {
            "You will never beat me!",
            "I'm the best ever!",
            "High Roller in the house! It's me. I'm hte high roller",
            "BOOOOOOOOOOOO. You're gonna lose!",
            "You can't even count to 6 much less roll one!"
        };
        public override void Play(Player other)
        {

            Random rNum = new Random();
            int numIndex = rNum.Next(tauntList.Count);

            // Call roll for "this" object and for the "other" object
            int myRoll = Roll();
            int otherRoll = other.Roll();

            Console.WriteLine($"{Name} rolls a {myRoll}  {tauntList[numIndex]}");
            Console.WriteLine($"{other.Name} rolls a {otherRoll}");
            if (myRoll > otherRoll)
            {
                Console.WriteLine($"{Name} Wins!");
            }
            else if (myRoll < otherRoll)
            {
                Console.WriteLine($"{other.Name} Wins!");
            }
            else
            {
                // if the rolls are equal it's a tie
                Console.WriteLine("It's a tie");
            }
        }
    }
}