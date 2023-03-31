using System;

namespace RandomDice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Would you kindly give me a number of dices");
            int d = int.Parse(Console.Readline());

            int ad = 0;

            Random dice = new Random();

            for (int i = 1;i <= d; i++);
            {
                int roll = dice.Next(1,7);
                ad += roll;
                Console.WriteLine($"You have rolled a {roll}");

            }
            Console.Writeline($"The final addition of all {d} rolls is {ad}");
        }
    }
}
