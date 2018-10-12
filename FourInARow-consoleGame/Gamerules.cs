using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourInARow_consoleGame
{
    class GameRules
    {
        public FourInARow game;
        private int VictoryCount = 0;
        public GameRules(FourInARow game)
        {
            this.game = game;
        }

        public void VictoryCheck()
        {
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (game.ConnectFourArray[j, i] == game.ConnectFourArray[j + 1, i] && game.ConnectFourArray[j, i] != ' ')
                    {
                        VictoryCount++;
                        if (VictoryCount == 3) game.gameover = true;
                    }
                    else VictoryCount = 0;
                }
            }
        }
    }
}
