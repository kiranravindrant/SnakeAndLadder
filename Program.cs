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
            int positionPlayer2 = 0;
            int winningPosition = 15;
            int dieRoll;
            int option;
            int optionPlayer2;
            int rollcount = 0;

            Console.WriteLine("Welcome to Snake & Ladder");

            Console.WriteLine("Player1 is at Position:" + position);
            Console.WriteLine("Player2 is at Position:" + positionPlayer2);

            //Player Rolls dice now
            Random random = new Random();

            while (position < winningPosition && positionPlayer2 < winningPosition)
            {
                dieRoll = random.Next(6) + 1;
                rollcount++;
                Console.WriteLine("DieValue " + dieRoll);
                //User Options 0-Noplay 1-ladder 2-Snake
                //while Winning position is reached

                option = random.Next(3);
                optionPlayer2 = random.Next(3);
              
                


                switch (option)
                {
                    case 0:
                        Console.WriteLine("PLAYER 1 HAS NO PLAY");
                        Console.WriteLine("Player1 stays in the same position : " + position);
                        break;

                    case 1:


                        Console.WriteLine("PLAYER 1 GOT LADDER !!");

                        if (position + dieRoll > winningPosition)
                        {

                            Console.WriteLine("Player1 stays as exact value is not reached  : ");
                        }
                        else if (position + dieRoll == winningPosition)
                        {
                            Console.WriteLine("Player1 Has Won ");
                            Console.WriteLine("The Number of Dice played to win: " + rollcount);
                            goto Afterloop;

                        }
                        else
                        {
                            position += dieRoll;

                            Console.WriteLine("Player1 Moves Ahead to : " + position);
                        }
                        break;

                    case 2:

                        position -= dieRoll;
                        if (position < 0)
                        {
                            position = 0;
                        }
                        Console.WriteLine("PLAYER 1 GOT SNAKE !!");
                        Console.WriteLine("Player1 moves behind to : " + position);
                        break;

                }
                //FOR PLAYER 2

                switch (optionPlayer2)
                {
                    case 0:
                        Console.WriteLine("PLAYER 2 HAS NO PLAY");
                        Console.WriteLine("Player2 stays in the same position : " + positionPlayer2);
                        break;

                    case 1:
                        Console.WriteLine("PLAYER 2 GOT LADDER !!");


                        if (positionPlayer2 + dieRoll > winningPosition)
                        {

                            Console.WriteLine("Player2 stays as exact value is not reached  : ");
                        }
                        else if (positionPlayer2 + dieRoll == winningPosition)
                        {
                            Console.WriteLine("Player2 Has Won ");
                            Console.WriteLine("The Number of Dice played to win: " + rollcount);
                            goto Afterloop;

                        }
                        else
                        {

                            positionPlayer2 += dieRoll;
                            Console.WriteLine("Player2 Moves Ahead to : " + positionPlayer2);
                        }
                        break;



                    case 2:
                        Console.WriteLine("PLAYER 2 GOT SNAKE !!");

                        positionPlayer2 -= dieRoll;
                        if (positionPlayer2 < 0)
                        {
                            positionPlayer2 = 0;
                        }
                        Console.WriteLine("Player2 moves behind to  : " + positionPlayer2);
                        break;
                }
               // Console.ReadLine();       To see step by step, uncomment the dode
            } Afterloop:
                     Console.ReadLine();





            
        }
    }
}
