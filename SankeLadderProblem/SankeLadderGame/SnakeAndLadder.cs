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
        

        // Declaring const Variables to Check options...
        const int  NoPlay= 0;
        const int Ladder= 1;
        const int Snake= 2;

        int DiceRolls;
        int CheckOptions;
        Random random = new Random();

        public  void StartGame()
        {
            Console.WriteLine("The Game Begins....\n");
        
            Console.WriteLine("Start  Position of Player = {0}",Position);

            while (Position < 100)
            {
                // To roll the Dice..
                DiceRolls = random.Next(1, 7);
                Console.WriteLine("Player gets the Number After Rolling Dice = {0}", DiceRolls);

                // To Check options..
                CheckOptions = random.Next(0, 3);
                switch (CheckOptions)
                {
                    case NoPlay:
                        Console.WriteLine("Player Options = NoPlay");
                        Position=Position;
                        break;
                    case Ladder:
                        Console.WriteLine("Player Options = Ladder");
                        if (Position + DiceRolls > 100)
                        {
                            Position = Position ;
                        }
                        else
                        {
                            Position += DiceRolls;
                        }
                        break;
                    case Snake:
                        Console.WriteLine("Player Options = Snake");

                        if (Position > DiceRolls)
                        {
                            Position -= DiceRolls;
                        }
                        else
                        {
                            Position = 0;
                        }
                        break;
                }
                Console.WriteLine("Player Current Position : {0}", Position);
            }
            Console.WriteLine("player Win : {0}",Position);
            
           

        }

    }
}
