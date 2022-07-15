using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SankeLadderGame
{
    public class SnakeAndLadder
    {
        int Player_Position = 0;
        

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
        
            Console.WriteLine("Start  Position of Player = {0}", Player_Position);

            while (Player_Position < 100)
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
                        Player_Position = Player_Position;
                        break;
                    case Ladder:
                        Console.WriteLine("Player Options = Ladder");
                        if (Player_Position + DiceRolls > 100)
                        {
                            Player_Position = Player_Position;
                        }
                        else
                        {
                            Player_Position += DiceRolls;
                        }
                        break;
                    case Snake:
                        Console.WriteLine("Player Options = Snake");

                        if (Player_Position > DiceRolls)
                        {
                            Player_Position -= DiceRolls;
                        }
                        else
                        {
                            Player_Position = 0;
                        }
                        break;
                }
                Console.WriteLine("Player Current Position : {0}", Player_Position);
            }
            Console.WriteLine("player Win : {0}", Player_Position);
            
           

        }

    }
}
