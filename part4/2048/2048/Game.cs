using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2048
{
    public class Game
    {
        public Board GameBoard
        {
            get; protected set;
        }
        public int Points 
        {  
            get; protected set; 
        }
        public GameStatus Status 
        {  
            get; protected set; 
        }

        public Game(int boardSize = 4)
        {
            GameBoard = new Board();
            Points = 0;
            Status = GameStatus.InProgress;
        }

        public void StartGame()
        {
            Console.WriteLine("2048 Game starts");

            while (Status == GameStatus.InProgress)
            {
                GameBoard.Display();
                ConsoleKeyInfo keyInfo = Console.ReadKey();

                Direction chosenDirection;
                switch (keyInfo.Key)
                {
                    case ConsoleKey.W:
                        chosenDirection = Direction.Up;
                        break;
                    case ConsoleKey.S:
                        chosenDirection = Direction.Down;
                        break;
                    case ConsoleKey.A:
                        chosenDirection = Direction.Left;
                        break;
                    case ConsoleKey.D:
                        chosenDirection = Direction.Right;
                        break;
                    default:
                        Console.WriteLine("\nInvalid input. Please use W, A, S, D to move or Q to quit.");
                        continue;
                }
            }
        }

    }
}
