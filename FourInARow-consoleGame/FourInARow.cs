using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourInARow_consoleGame
{
    class FourInARow
    {
        public Checkers checkers;
        public Player players;
        public char[,] ConnectFourArray= new char[6,6];
        private bool gameover = false;
            
        public FourInARow()
        {
            checkers = new Checkers(this);
            players = new Player(this);
            checkers.Start();
            while (gameover != true)
            {
                Console.WriteLine(" 1  2  3  4  5  6 ");
                Console.WriteLine("+----------------+");
                Console.Write(checkers);
                Console.WriteLine("+----------------+");
                players.Play1();
                Console.Clear();
                Console.WriteLine(" 1  2  3  4  5  6 ");
                Console.WriteLine("+----------------+");
                Console.Write(checkers);  
                Console.WriteLine("+----------------+");
                players.Play2();
                Console.Clear();
            }
            
        }

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
        }

        
    }   
}
