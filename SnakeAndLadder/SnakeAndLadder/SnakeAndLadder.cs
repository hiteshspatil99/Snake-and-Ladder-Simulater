using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeAndLadder
{
    public class SnakeAndLadder
    {
        public const int NO_PLAY = 0, LADDER = 1, SNAKE = 2;
        public int playerPosition = 0;
        Random random = new Random();
        public int DieRolling()
        {
            int roll = random.Next(1, 7);
            return roll;
        }
        public void PlayerCheck()
        {
            int dieRolling = this.DieRolling();
            int option = random.Next(0, 3);
            switch (option)
            {
                case NO_PLAY:
                    break;
                case LADDER:
                    this.playerPosition += dieRolling;
                    break;
                case SNAKE:
                    this.playerPosition -= dieRolling;
                    break;
            }
            //Console.WriteLine(this.playerPosition);
        }
    }
}
