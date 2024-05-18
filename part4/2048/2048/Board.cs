using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2048
{
    public class Board
    {
        public int[,] Data 
        { 
            get; 
            protected set;
        }

        public Board()
        {
            Data = new int[4, 4];
            AddRandom();
            AddRandom();
        }


        private void AddRandom()
        {
        Random random = new Random();

        int row, col;
            do
            {
                row = random.Next(4);
                col = random.Next(4);
            } while (Data[row, col] != 0);

            if (random.Next(2) == 0)
            {
                Data[row, col] = 4;
            }
            else
            {
                Data[row, col] = 2;
            }
        }

    }
}
