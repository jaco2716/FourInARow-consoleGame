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
        public int placementy;
        public char player1 = 'O';
        public char player2 = 'X';

        public Player(FourInARow game)
        {
            this.game = game;
        }
        public void Play()
        {
            Console.WriteLine("Hvor x,y vil du lægge din brik?");
             placementx = Convert.ToInt32(Console.ReadLine());
             placementy = Convert.ToInt32(Console.ReadLine());
            game.setSingleValue(placementx, placementy, player1);
           
        }

    }
}
