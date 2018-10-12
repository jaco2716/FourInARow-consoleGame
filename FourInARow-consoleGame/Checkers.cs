using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourInARow_consoleGame
{
    class Checkers
    {
        public FourInARow game;
      
        public Checkers(FourInARow game)
        {
            this.game = game; 
        }
      


        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    sb.Append(game.getSingleValue(i, j));
                }
                sb.Append("\n");
            }

            return sb.ToString();
        }
    }
}
