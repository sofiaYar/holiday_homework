﻿using System;
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

        public void Display()
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4 ; j++)
                {
                    Console.Write($"{Data[i, j]} \t");
                }
                Console.WriteLine();
            }
        }

        public bool Move(Direction direction)
        {
            bool successfulMove = false;

            switch (direction)
            {
                case Direction.Up:
                    successfulMove = Up();
                    break;
                case Direction.Down:
                    successfulMove = Down();
                    break;
                case Direction.Left:
                    successfulMove = Left();
                    break;
                case Direction.Right:
                    successfulMove = Right();
                    break;
            }

            if (successfulMove)
            {
                AddRandom();
            }

            return successfulMove;
        }

        private bool Right()
        {
            throw new NotImplementedException();
        }

        private bool Left()
        {
            throw new NotImplementedException();
        }

        private bool Down()
        {
            throw new NotImplementedException();
        }

        private bool Up()
        {
            throw new NotImplementedException();
        }
    }
}
