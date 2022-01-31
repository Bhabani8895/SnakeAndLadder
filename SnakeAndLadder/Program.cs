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
            //int player1 = 0;
            //Random random = new Random();
            //player1 = random.Next(1, 6);
            //Console.WriteLine(player1);
            const int NO_PLAY = 1;
            const int LADDER = 2;
            const int SNAKE_BITE = 3;
            int position = 0;
            Random random = new Random();
            int dice = random.Next(1, 7);
            int checkOption = random.Next(1, 4);
            switch (checkOption)
            {
                case NO_PLAY:
                    position = 0;
                    break;
                case LADDER:
                    position = position + dice;
                    break;
                case SNAKE_BITE:
                    position = position - dice;
                    break;
                default:
                    position = 0;
                    break;
            }
            Console.WriteLine("postion of player is :" + position);
        }
    }
}
