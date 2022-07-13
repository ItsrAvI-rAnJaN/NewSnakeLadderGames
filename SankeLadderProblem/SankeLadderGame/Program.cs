using System;

namespace SankeLadderGame
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t\t\t######################################################");
            Console.WriteLine("\t\t\t\t\tWELCOME TO SNAKE & LADDER GAME PROGRAM");
            Console.WriteLine("\t\t\t\t######################################################");

            //Create Instance of class SnakeAndLadder
            SnakeAndLadder objStartGame=new SnakeAndLadder();

            // Call The Method StartGame Define in Class SnakeAndLadder..
            objStartGame.StartGame();

            Console.ReadKey();
        }
    }
}