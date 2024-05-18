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

        public Game()
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
                    case ConsoleKey.UpArrow:
                        chosenDirection = Direction.Up;
                        break;
                    case ConsoleKey.DownArrow:
                        chosenDirection = Direction.Down;
                        break;
                    case ConsoleKey.LeftArrow:
                        chosenDirection = Direction.Left;
                        break;
                    case ConsoleKey.RightArrow:
                        chosenDirection = Direction.Right;
                        break;
                    default:
                        Console.WriteLine("Invalid input");
                        continue;
                }

                Move(chosenDirection);
            }

            Console.WriteLine("END");
        }

        public void Move(Direction direction)
        {

        }
    }
}
