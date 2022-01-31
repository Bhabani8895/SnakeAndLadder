using System;

namespace SnakeAndLadder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Snake and Ladder");
            //int Position = 0;
            //Console.WriteLine("Player is at starting  Position: " + Position);
            int player1 = 0;
            Random random = new Random();
            player1 = random.Next(1, 6);
            Console.WriteLine(player1);
        }
    }
}
