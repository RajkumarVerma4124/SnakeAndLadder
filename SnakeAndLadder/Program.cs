using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Displaying message
            Console.WriteLine("Welcome to the snake and ladder program\n");

            //Starting the game by calling start game method
            SnakeLadderGame.StartGame();
        }
    }
}
