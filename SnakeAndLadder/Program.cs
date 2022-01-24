using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    public class Program
    {
        //Initializing single player position(UC1) And Declaring Variables
        public static int startPosition = 0;
        public static int playerPosition;
        public static int currentPosition;
        public static Random dieBoxRoll = new Random();
        public static void Main(string[] args)
        {
            //Displaying message
            Console.WriteLine("Welcome to the snake and ladder program\n");

            //The Player rolls the die to get a number between 1 to 6(UC2)
            int rollDie = dieBoxRoll.Next(1, 7);
           
            playerPosition = startPosition; //Initialized the player position from position zero
           
            //The Player checks for a Option For No Play, Ladder or Snake(UC3)
            int checkOptions = dieBoxRoll.Next(0, 3);

            switch(checkOptions)
            {
                case 0:
                    //No Play Option
                    playerPosition += playerPosition;
                    Console.WriteLine("Player Got No Play Option : " + playerPosition + "\n");
                    //Console.ReadLine();
                    break;
                case 1:
                    //Ladder Option
                    currentPosition = playerPosition + rollDie;
                    Console.WriteLine("Player Got Ladder Option With Dice Value : {0} Current Player Position : {1} ",rollDie , currentPosition);
                    break;
                case 2:
                    //Ladder Option
                    currentPosition = playerPosition - rollDie;
                    Console.WriteLine("Player Got Snake Option With Dice Value: {0} Current Player Position : {1} ", rollDie, currentPosition);
                    break;
            }
            Console.ReadLine();
        }
    }
}
