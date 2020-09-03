using System;

namespace ShootingDice
{
    // TODO: Complete this class

    // A player the prompts the user to enter a number for a roll
    public class HumanPlayer : Player
    {

        public override int Roll()
        {
            // Return a random number between 1 and DiceSize
            Console.Write($"{Name} Enter a number for your roll. ");
            return int.Parse(Console.ReadLine());

        }
        public override void Play(Player other)
        {
            // Call roll for "this" object and for the "other" object
            Console.Write($"{Name} Enter a number for your roll. ");
            int myRoll = Roll();
            int otherRoll = other.Roll();

            Console.WriteLine($"{Name} rolls a {myRoll}");
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