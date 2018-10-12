using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourInARow_consoleGame
{
    class FourInARow
    {
        public Checkers checkers = new Checkers();
       
        public char[,] ConnectFourArray= new char[6,6];
        
        /// <summary>
        /// get a single value from our two dimensional array
        /// </summary>
        /// <param name="x">x axis</param>
        /// <param name="y">y axis</param>
        /// <returns></returns>
        public char getSingleValue(int x, int y)
        {
            return ConnectFourArray[x, y];
        }

        /// <summary>
        /// Set a single value our two dimensional array
        /// </summary>
        /// <param name="x">x axis position</param>
        /// <param name="y">y axis position</param>
        /// <param name="value">the char you want to set</param>
        /// <returns></returns>
      public void setSingleValue(int x, int y, char value)
        {
            ConnectFourArray[x, y] = value;
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    ConnectFourArray[i, j] = 'O';
                }
            }
        }

        public FourInARow()
        {
            Console.WriteLine(checkers);
        }
    }   
}
