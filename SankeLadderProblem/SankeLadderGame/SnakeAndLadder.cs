using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SankeLadderGame
{
    public class SnakeAndLadder
    {
        int Position = 0;
        int DiceRolls;

        public  void StartGame()
        {
            Console.WriteLine("The Game Begins....\n");
        
            Console.WriteLine($"Start  Position of Player = {0}",Position);

            Random random = new Random();
            DiceRolls= random.Next(1,7);
            Console.WriteLine("Player gets the Number After Rolling Dice = {0}",DiceRolls);
        }

    }
}
