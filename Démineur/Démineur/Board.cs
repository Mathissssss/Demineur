using System;

namespace Démineur
{
    public class Board
    {
        private Cell[,] board;
        private int nbBombes;
        public readonly int size = 16;
        
        public int NbBombes => nbBombes;

        public int NbFlags { get; set; }

        public Cell[,] BoardArray => board;

        public Board(int bombes)
        {
            this.board = new Cell[size, size];
            this.nbBombes = 0;
            this.NbFlags = 0;
            
            Random rnd = new Random();
            Random rnd1 = new Random();
            int x;
            int y;
            while (this.nbBombes < bombes)
            {
                x = rnd.Next(16);
                y = rnd1.Next(16);
                if (board[x,y] == null)
                {
                    board[x,y] = new Cell(CellType.Bomb, CellState.Hidden);
                    this.nbBombes++;
                }
                else
                {
                    if (board[x,y].Type != CellType.Bomb)
                    {
                        board[x,y].Type = CellType.Bomb;
                        this.nbBombes++;
                    }
                }
            }

            for (y = 0; y < size; y++)
            {
                for (x = 0; x < size; x++)
                {
                    if (board[x,y] == null)
                    {
                        int count1 = Cell.CountBombs(this, x, y);
                        board[x,y] = new Cell((CellType) count1, CellState.Hidden);
                    }
                    if (board[x,y].Type != CellType.Bomb)
                    {
                        int count2 = Cell.CountBombs(this, x, y);
                        board[x,y].Type = (CellType) count2;
                    }
                }
            }
        }
        
        public static void Print(Board board)
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine();
            for (int i = 0; i < board.size; i++)
            {
                if (i == 0)
                {
                    Console.WriteLine("                          X");
                    Console.WriteLine("                          1   2   3   4   5   6   7   8   9   10  11  12  13  14  15  16");
                    Console.Write("                    Y 1   ");
                }
                
                if (i > 0 && i < 9)
                {
                    Console.Write("                      {0}   ", i + 1);
                }

                if (i >= 9)
                {
                    Console.Write("                      {0}  ", i + 1);
                }
                
                for (int j = 0; j < board.size; j++)
                {
                    if (board.BoardArray[j,i].State == CellState.Hidden)
                    {
                        Console.Write("H | ");
                    }
                    else
                    {
                        if (board.BoardArray[j,i].State == CellState.Flag)
                        {
                            Console.ForegroundColor = ConsoleColor.Magenta;
                            Console.Write("F");
                            Console.ResetColor();
                            Console.Write(" | ");
                        }
                        else
                        {
                            if (board.BoardArray[j,i].Type == CellType.Empty)
                            {
                                Console.Write("  | ");
                            }
                            else
                            {
                                switch (board.BoardArray[j, i].Type)
                                {
                                    case CellType.One:
                                        Console.ForegroundColor = ConsoleColor.Blue;
                                        Console.Write("1");
                                        Console.ResetColor();
                                        Console.Write(" | ");
                                        break;
                                    case CellType.Two:
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.Write("2");
                                        Console.ResetColor();
                                        Console.Write(" | ");
                                        break;
                                    case CellType.Three:
                                        Console.ForegroundColor = ConsoleColor.Red ;
                                        Console.Write("3");
                                        Console.ResetColor();
                                        Console.Write(" | ");
                                        break;
                                    case CellType.Four:
                                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                                        Console.Write("4");
                                        Console.ResetColor();
                                        Console.Write(" | ");
                                        break;
                                    case CellType.Five:
                                        Console.ForegroundColor = ConsoleColor.DarkRed;
                                        Console.Write("5");
                                        Console.ResetColor();
                                        Console.Write(" | ");
                                        break;
                                    case CellType.Six:
                                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                                        Console.Write("6");
                                        Console.ResetColor();
                                        Console.Write(" | ");
                                        break;
                                    case CellType.Seven:
                                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                        Console.Write("7");
                                        Console.ResetColor();
                                        Console.Write(" | ");
                                        break;
                                    default:
                                        Console.ForegroundColor = ConsoleColor.Gray;
                                        Console.Write("8");
                                        Console.ResetColor();
                                        Console.Write(" | ");
                                        break;
                                }
                            }
                        }
                    }
                }
                if (i == 0)
                {
                    Console.Write("         Number of bombs : {0}", board.NbBombes);
                }

                if (i == 1)
                {
                    Console.Write("         Number of flags : {0}", board.NbFlags);
                }
                Console.WriteLine();
            }
        }

        public static void EndScreen(Board board, int x, int y)
        {
            int bombsFound = 0;
            foreach (var cell in board.BoardArray)
            {
                if (cell.Type == CellType.Bomb && cell.State == CellState.Flag)
                {
                    bombsFound++;
                }
            }
            
            Console.WriteLine();
            for (int i = 0; i < board.size; i++)
            {
                if (i == 0)
                {
                    Console.WriteLine("                          X");
                    Console.WriteLine("                          1   2   3   4   5   6   7   8   9   10  11  12  13  14  15  16");
                    Console.Write("                    Y 1   ");
                }

                if (i > 0 && i < 9)
                {
                    Console.Write("                      {0}   ", i + 1);
                }

                if (i >= 9)
                {
                    Console.Write("                      {0}  ", i + 1);
                }

                for (int j = 0; j < board.size; j++)
                {
                    if (j == x && i == y)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("B");
                        Console.ResetColor();
                        Console.Write(" | ");
                    }
                    else
                    {
                        if (board.BoardArray[j,i].Type == CellType.Bomb)
                        {
                            if (board.BoardArray[j,i].State == CellState.Flag)
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.Write("F");
                                Console.ResetColor();
                                Console.Write(" | ");
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.Write("B");
                                Console.ResetColor();
                                Console.Write(" | ");
                            }
                        }
                        else
                        {
                            if (board.BoardArray[j,i].State == CellState.Flag)
                            {
                                Console.ForegroundColor = ConsoleColor.Magenta;
                                Console.Write("F");
                                Console.ResetColor();
                                Console.Write(" | ");
                            }
                            else
                            {
                                Console.Write("  | ");
                            }
                        }
                    }
                    
                }
                if (i == 0)
                {
                    Console.Write("         Bombs found : {0}/{1}", bombsFound, board.nbBombes);
                }
                Console.WriteLine();
            }
        }
        
        public enum GameState
        {
            WON = 1,
            LOST = -1,
            RUNNING = 0
        }
    }
}