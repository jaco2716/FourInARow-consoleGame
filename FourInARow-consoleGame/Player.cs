using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourInARow_consoleGame
{
    class Player
    {
        public FourInARow game;
        public int placementx;
        public char player1 = 'O';
        public char player2 = 'X';

        public Player(FourInARow game)
        {
            this.game = game;
        }
        public void Play1()
        {
            Console.WriteLine("Player 1: Hvor vil du ligge din brik?");
            placementx = Convert.ToInt32(Console.ReadLine());
            for (int i = 5; i >= 0; i--)
            {
                if (game.ConnectFourArray[i, placementx-1] == ' ')
                {
                    game.setSingleValue(i,placementx-1,player1);
                    break;
                }
            }                                   
        }
        public void Play2()
        {
            Console.WriteLine("Player 2: Hvor vil du ligge din brik?");
            placementx = Convert.ToInt32(Console.ReadLine());
            for (int i = 5; i >= 0; i--)
            {
                if (game.ConnectFourArray[i, placementx-1] == ' ')
                {
                    game.setSingleValue(i,placementx-1, player2);
                    break;
                }
            }          
        }
    }
}
