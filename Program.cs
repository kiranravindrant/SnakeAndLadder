﻿
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
            Console.WriteLine("Welcome to Snake & Ladder");

            Console.WriteLine("Player is at Position:" + position);
            //Player Rolls dice now
            Random random = new Random();
            while (position < winningPosition)
            {
                dieRoll = random.Next(6) + 1;
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
                        if (position > winningPosition)
                        {
                            Console.WriteLine("Try Again_Die value exceeds win!!");
                        }
                        else
                        {
                            Console.WriteLine("Player moves ahead by : " + position);
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
