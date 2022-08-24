﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeandLadder
{
    internal class Game
    {
       public int playerPosition = 0;
        const int NO_PLAY = 0, LADDER = 1, SNAKE = 2,WINNINGPOSITION=100;
        Random random = new Random();
        public int DieRoll()
        {
            int dieCount= random.Next(1, 7);
            return dieCount;
        }
        public void Play()
        {
            while(playerPosition < 100)
            { 

            int option=random.Next(0,3);
            switch (option)
            {
                case NO_PLAY:
                    playerPosition += 0;
                    Console.WriteLine("Player is not Play the Game");
                    break;
                case LADDER:
                        int die=DieRoll();
                     playerPosition += die;
                    Console.WriteLine("Player is Play Ladder  Game");
                       if(playerPosition > 100)
                        {
                            playerPosition += die;
                        }
                    break;
                case SNAKE:
                    playerPosition -= DieRoll();
                    Console.WriteLine("Player is not Play Snake Game");
                    if (playerPosition < 0)
                    {
                        playerPosition = 0;
                    }

                    break;
            }
            }
            if(playerPosition==WINNINGPOSITION)
            {
                Console.WriteLine(playerPosition);
            }
        }
            
    }
}
