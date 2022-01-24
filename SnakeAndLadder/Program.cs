using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    public class Program
    {
        //Initializing single player position(UC1)
        public static int startPosition = 0;
        public static Random dieBoxRoll = new Random();
        public static void Main(string[] args)
        {
            //Displaying message
            Console.WriteLine("Welcome to the snake and ladder program");

            //The Player rolls the die to get a number between 1 to 6(UC2)
            int rollDie = dieBoxRoll.Next(1, 7);
            Console.WriteLine("The Die Rolled at : "+rollDie);
            Console.ReadLine();
        }
    }
}
