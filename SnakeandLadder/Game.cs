using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeandLadder
{
    internal class Game
    {
       public int playerPosition = 0;
        const int NO_PLAY = 0, LADDER = 1, SNAKE = 2;
        Random random = new Random();
        public int DieRoll()
        {
            int dieCount= random.Next(1, 7);
            return dieCount;
        }
        public void Play()
        {
            int option=random.Next(0,3);
            switch(option)
            {
                case NO_PLAY:playerPosition += 0;
                    Console.WriteLine("Player is not Play the Game");
                    break;
                case LADDER:playerPosition += DieRoll();
                    Console.WriteLine("Player is Play Ladder  Game");
                    break;
                case SNAKE:playerPosition -= DieRoll();
                    Console.WriteLine("Player is not Play Snake Game");
                    break;
            }
            Console.WriteLine(playerPosition);
        }
    }
}
