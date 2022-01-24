using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    public class SnakeLadderGame
    {
        //Initializing single player position(UC1)
        public static int[] player = new int[2] {0, 0};

        //Constant
        public static int WIN_POSITION = 100;
        
        //Declaring And Initializing Variables, Random Object
        public static int playerPosition;
        public static int currentPosition;
        public static int dieRolled = 0;
        public static Random dieBoxRoll = new Random();

        public static void StartGame()
        {
            playerPosition = player[1]; //Initialized the player position from position zero

            //Repeat Till A Player Reach Winning Position i.e 100(UC4)
            while (playerPosition < WIN_POSITION)
            {
                //The Player rolls the die to get a number between 1 to 6(UC2)
                int rollDie = dieBoxRoll.Next(1, 7);

                //The Player checks for a Option For No Play, Ladder or Snake(UC3)
                int checkOptions = dieBoxRoll.Next(0, 3);

                //No. of times the dice played to win the game
                dieRolled++;

                //No Play Option
                if (checkOptions == 0)
                {
                    player[1] = playerPosition;
                    Console.WriteLine("Player Got No Play Option So Current Position : "+player[1]+"\n");
                }

                //Ladder Option To Ensure The Player Gets To Exact Winning Position 100(UC5)
                if (checkOptions == 1)
                {
                    currentPosition = playerPosition + rollDie;
                    if (currentPosition <= WIN_POSITION)
                    {
                        playerPosition = currentPosition;
                        player[1] = playerPosition;
                    }
                    else
                    {
                        player[1] = playerPosition;
                    }
                    Console.WriteLine("Player Got Ladder Option With Dice Value : {0} Current Player Position : {1}", rollDie, player[1]+"\n");
                }

                //Snake Option To Ensure The Player Gets To Exact Winning Position 100(UC5)
                if (checkOptions == 2)
                {
                    currentPosition = playerPosition - rollDie;
                    if (currentPosition >= 0)
                    {
                        playerPosition = currentPosition;
                        player[1] = playerPosition;
                    }
                    else
                    {
                        player[1] = playerPosition;
                    }
                    Console.WriteLine("Player Got Snake Option With Dice Value: {0} Current Player Position : {1}", rollDie, player[1]+"\n");
                }
            }
            Console.WriteLine("\nPlayer Won With Dice Count Of : {0} And Reached Winning Position : {1}",dieRolled, player[1]);
            Console.ReadLine();
        }
    }
}
