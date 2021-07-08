using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeAndLadder
{
    class SnakeAndLadder
    {
        static void Main(string[] args)
        {
            int position = 0;
            int winningPosition = 100;
            int dieRoll;
            Console.WriteLine("Welcome to Snake & Ladder");
            Console.WriteLine("Player is at Position:" + position);
            //Player Rolls dice now
            Random random = new Random();
            dieRoll = random.Next(6) + 1;
            Console.WriteLine(dieRoll);

            Console.ReadLine();



        }
    }
}


