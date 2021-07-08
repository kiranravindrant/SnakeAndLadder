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
            int option;
            int rollcount = 0;

            Console.WriteLine("Welcome to Snake & Ladder");

            Console.WriteLine("Player is at Position:" + position);
            //Player Rolls dice now
            Random random = new Random();
            while (position < winningPosition)
            {
                dieRoll = random.Next(6) + 1;
                rollcount++;
                Console.WriteLine("DieValue " + dieRoll);
                //User Options 0-Noplay 2-ladder 3-Snake
                //while Winning position is reached

                option = random.Next(3);
                Console.WriteLine("User Option " + option);


                switch (option)
                {
                    case 0:
                        Console.WriteLine("Player stays in the same position : " + position);
                        break;

                    case 1:

                        position += dieRoll;

                        Console.WriteLine("Player moves ahead by : " + position);
                        if (position > winningPosition)
                        {
                            position -= dieRoll;

                        }
                        else if (position == winningPosition)
                        {
                            Console.WriteLine("User Has Won " + position);
                            Console.WriteLine("The Number of Dice played to win: " + rollcount);
                            break;

                        }
                        break;

                    case 2:

                        position -= dieRoll;
                        if (position < 0)
                        {
                            position = 0;
                        }
                        else
                        {
                            Console.WriteLine("Player moves behind by : " + position);
                        }
                        break;

                }



                Console.ReadLine();





            }
        }
    }
}
