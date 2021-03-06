using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    public class SnakeLadderGame
    {
        //Initializing single player position and players die count(UC1 and UC6)
        public static int[] player = new int[3] {0, 0, 0};
        public static int[] playerDieCount = new int[3] { 0, 0, 0 };

        //Constant
        public static int WIN_POSITION = 100;
        
        //Declaring And Initializing Variables, Random Object
        public static int playerPosition;
        public static int currentPosition;
        public static int players = 1;
        public static int dieRolled = 0;
        public static Random dieBoxRoll = new Random();

        public static void StartGame(int playerNum)
        {

            //Initialized the player position after changing players with last known positions
            playerPosition = player[playerNum]; 

            //The Player rolls the die to get a number between 1 to 6(UC2)
            int rollDie = dieBoxRoll.Next(1, 7);

            //The Player checks for a Option For No Play, Ladder or Snake(UC3)
            int checkOptions = dieBoxRoll.Next(0, 3);

            //No. of times the dice played to win the game(UC6)
            dieRolled++;
            playerDieCount[playerNum]++;

            //No Play Option
            if (checkOptions == 0)
            {
                player[playerNum] = playerPosition;
                Console.WriteLine("Player "+playerNum+" Got No Play Option So Current Position : "+player[playerNum] +"\n");
            }

            //Ladder Option To Ensure The Player Gets To Exact Winning Position 100(UC5)
            if (checkOptions == 1)
            {
                currentPosition = playerPosition + rollDie;
                if (currentPosition <= WIN_POSITION)
                {
                    playerPosition = currentPosition;
                    player[playerNum] = playerPosition;
                }
                else
                {
                    player[playerNum] = playerPosition;
                }
                Console.WriteLine("Player "+playerNum+" Got Ladder Option With Dice Value : {0} Current Player Position : {1}", rollDie, player[playerNum] + "\n");
            }

            //Snake Option To Ensure The Player Gets To Exact Winning Position 100(UC5)
            if (checkOptions == 2)
            {
                currentPosition = playerPosition - rollDie;
                if (currentPosition >= 0)
                {
                    playerPosition = currentPosition;
                    player[playerNum] = playerPosition;
                }
                else
                {
                    player[playerNum] = playerPosition;
                }
                Console.WriteLine("Player "+playerNum+" Got Snake Option With Dice Value: {0} Current Player Position : {1}", rollDie, player[playerNum] + "\n");
            }

            //The condition for continue playing if got the ladder(UC7)
            if (checkOptions == 1 && player[playerNum] != 100)
            {
                StartGame(playerNum);
            }
        }

        //Playing Game With Two Players Till One Wins(UC7) 
        public static void PlayGame()
        {
            //Repeating Till A Player Reach Winning Position i.e 100(UC4)
            while (true)
            {
                if (players == 1)
                {
                    StartGame(1);
                    if (player[1] == 100)
                    {
                        Console.WriteLine("Player 1 Won With Dice Count Of : {0} And Reached Win Position : {1} ",playerDieCount[1], player[1]);
                        Console.ReadLine();
                        break;
                    }
                    else
                    {
                        players = 2;
                        continue;
                    }
                }
                if (players == 2)
                {
                    StartGame(2);
                    if (player[2] == 100)
                    {
                        Console.WriteLine("Player 2 Won With Dice Count Of : {0} And Reached Win Position : {1} ",playerDieCount[2], player[2]);
                        Console.ReadLine();
                        break;
                    }
                    else
                    {
                        players = 1;
                        continue;
                    }
                }
            }
        }
    }
}
