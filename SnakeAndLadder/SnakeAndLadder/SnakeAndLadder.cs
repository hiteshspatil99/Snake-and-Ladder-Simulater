using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeAndLadder
{
    public class SnakeAndLadder
    {
        public const int NO_PLAY = 0, LADDER = 1, SNAKE = 2, WINNING = 100, START = 0;
        public int standingPositionofPlayer = 0, count = 0;
        Random random = new Random();
        public int DieRolling()
        {
            int roll = random.Next(1, 7);
            return roll;
        }
        public void PlayerCheck()
        {
            while (standingPositionofPlayer < WINNING)
            {
                int dieRoll = this.DieRolling();
                int option = random.Next(0, 3);
                switch (option)
                {
                    case NO_PLAY:
                        break;
                    case LADDER:
                        this.standingPositionofPlayer += dieRoll;
                        if (this.standingPositionofPlayer > WINNING)
                        {
                            this.standingPositionofPlayer -= dieRoll;
                        }
                        Console.WriteLine("Got Ladder");
                        break;
                    case SNAKE:
                        this.standingPositionofPlayer -= dieRoll;
                        if (this.standingPositionofPlayer < START)
                        {
                            this.standingPositionofPlayer = START;
                        }
                        Console.WriteLine("Got Snake");
                        break;
                }
                count++;
                Console.WriteLine("The Player Position is :" + this.standingPositionofPlayer + " " + "with a roll of " + dieRoll);
            }
            Console.WriteLine("The number of times dice was rolled to win the Game is : " + count);
            Console.WriteLine("The Player wins the Game");
        }
    }
}
