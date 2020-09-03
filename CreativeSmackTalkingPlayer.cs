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

        public override int Roll()
        {
            // Return a random number between 1 and DiceSize
            Random rNum = new Random();
            int numIndex = rNum.Next(tauntList.Count);
            Console.WriteLine($"{tauntList[numIndex]}");
            return new Random().Next(DiceSize) + 1;

        }

    }
}