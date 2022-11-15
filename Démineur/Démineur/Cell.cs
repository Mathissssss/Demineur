using System;
using System.Collections.Generic;

// ReSharper disable UselessBinaryOperation

namespace Démineur
{
    public class Cell
    {
        private CellType type;
        private CellState state;

        public CellState State
        {
            get => state;
            set => state = value;
        }
        public CellType Type
        {
            get => type;
            set => type = value;
        }

        public Cell(CellType type, CellState state)
        {
            this.type = type;
            this.state = state;
        }

        public static int CountBombs(Board board, int x, int y)
        {
            
            int count = 0;
            if (x == 0)
            {
                if (y == 0)
                {
                    if (board.BoardArray[x,y+1] != null && board.BoardArray[x,y+1].Type == CellType.Bomb)
                    {
                        count+=1;
                    }

                    if (board.BoardArray[x+1,y+1] != null && board.BoardArray[x+1,y+1].Type == CellType.Bomb)
                    {
                        count+=1;
                    }

                    if (board.BoardArray[x+1,y] != null && board.BoardArray[x+1,y].Type == CellType.Bomb)
                    {
                        count++;
                    }
                }

                if (y == board.size - 1)
                {
                    if (board.BoardArray[x,y-1] != null && board.BoardArray[x,y-1].Type == CellType.Bomb)
                    {
                        count++;
                    }

                    if (board.BoardArray[x+1,y-1] != null && board.BoardArray[x+1,y-1].Type == CellType.Bomb)
                    {
                        count++;
                    }

                    if (board.BoardArray[x+1,y] != null && board.BoardArray[x+1,y].Type == CellType.Bomb)
                    {
                        count++;
                    }
                }

                if (y > 0 && y < board.size - 1)
                {
                    if (board.BoardArray[x,y+1] != null && board.BoardArray[x,y+1].Type == CellType.Bomb)
                    {
                        count++;
                    }

                    if (board.BoardArray[x+1,y+1] != null && board.BoardArray[x+1,y+1].Type == CellType.Bomb)
                    {
                        count++;
                    }

                    if (board.BoardArray[x+1,y] != null && board.BoardArray[x+1,y].Type == CellType.Bomb)
                    {
                        count++;
                    }

                    if (board.BoardArray[x+1,y-1] != null && board.BoardArray[x+1,y-1].Type == CellType.Bomb)
                    {
                        count++;
                    }

                    if (board.BoardArray[x,y-1] != null && board.BoardArray[x,y-1].Type == CellType.Bomb)
                    {
                        count++;
                    }
                }
            }

            if (x == board.size - 1)
            {
                if (y == 0)
                {
                    if (board.BoardArray[x-1,y] != null && board.BoardArray[x-1,y].Type == CellType.Bomb)
                    {
                        count++;
                    }

                    if (board.BoardArray[x-1,y+1] != null && board.BoardArray[x-1,y+1].Type == CellType.Bomb)
                    {
                        count++;
                    }

                    if (board.BoardArray[x,y+1] != null && board.BoardArray[x,y+1].Type == CellType.Bomb)
                    {
                        count++;
                    }
                }

                if (y == board.size - 1)
                {
                    

                    if (board.BoardArray[x,y-1] != null && board.BoardArray[x,y-1].Type == CellType.Bomb)
                    {
                        count++;
                    }

                    if (board.BoardArray[x-1,y-1] != null && board.BoardArray[x-1,y-1].Type == CellType.Bomb)
                    {
                        count++;
                    }

                    if (board.BoardArray[x-1,y] != null && board.BoardArray[x-1,y].Type == CellType.Bomb)
                    {
                        count++;
                    }
                }
                
                if (y > 0 && y < board.size - 1)
                {
                    if (board.BoardArray[x,y-1] != null && board.BoardArray[x,y-1].Type == CellType.Bomb)
                    {
                        count++;
                    }

                    if (board.BoardArray[x-1,y-1] != null && board.BoardArray[x-1,y-1].Type == CellType.Bomb)
                    {
                        count++;
                    }

                    if (board.BoardArray[x-1,y] != null && board.BoardArray[x-1,y].Type == CellType.Bomb)
                    {
                        count++;
                    }

                    if (board.BoardArray[x-1,y+1] != null && board.BoardArray[x-1,y+1].Type == CellType.Bomb)
                    {
                        count++;
                    }

                    if (board.BoardArray[x,y+1] != null && board.BoardArray[x,y+1].Type == CellType.Bomb)
                    {
                        count++;
                    }
                }
            }
            if (x > 0 && x < board.size - 1)
            {
                if (y == 0)
                {
                    if (board.BoardArray[x-1,y] != null && board.BoardArray[x-1,y].Type == CellType.Bomb)
                    {
                        count++;
                    }

                    if (board.BoardArray[x-1,y+1] != null && board.BoardArray[x-1,y+1].Type == CellType.Bomb)
                    {
                        count++;
                    }

                    if (board.BoardArray[x,y+1] != null && board.BoardArray[x,y+1].Type == CellType.Bomb)
                    {
                        count++;
                    }

                    if (board.BoardArray[x+1,y+1] != null && board.BoardArray[x+1,y+1].Type == CellType.Bomb)
                    {
                        count++;
                    }

                    if (board.BoardArray[x+1,y] != null && board.BoardArray[x+1,y].Type == CellType.Bomb)
                    {
                        count++;
                    }
                }

                if (y == board.size - 1)
                {
                    if (board.BoardArray[x-1,y] != null && board.BoardArray[x-1,y].Type == CellType.Bomb)
                    {
                        count++;
                    }

                    if (board.BoardArray[x+1,y] != null && board.BoardArray[x+1,y].Type == CellType.Bomb)
                    {
                        count++;
                    }

                    if (board.BoardArray[x+1,y-1] != null && board.BoardArray[x+1,y-1].Type == CellType.Bomb)
                    {
                        count++;
                    }

                    if (board.BoardArray[x,y-1] != null && board.BoardArray[x,y-1].Type == CellType.Bomb)
                    {
                        count++;
                    }

                    if (board.BoardArray[x-1,y-1] != null && board.BoardArray[x-1,y-1].Type == CellType.Bomb)
                    {
                        count++;
                    }
                }
                if (y > 0 && y < board.size - 1)
                {
                    if (board.BoardArray[x-1,y-1] != null && board.BoardArray[x-1,y-1].Type == CellType.Bomb)
                    {
                        count++;
                    }

                    if (board.BoardArray[x-1,y] != null && board.BoardArray[x-1,y].Type == CellType.Bomb)
                    {
                        count++;
                    }

                    if (board.BoardArray[x-1,y+1] != null && board.BoardArray[x-1,y+1].Type == CellType.Bomb)
                    {
                        count++;
                    }

                    if (board.BoardArray[x,y+1] != null && board.BoardArray[x,y+1].Type == CellType.Bomb)
                    {
                        count++;
                    }

                    if (board.BoardArray[x+1,y+1] != null && board.BoardArray[x+1,y+1].Type == CellType.Bomb)
                    {
                        count++;
                    }

                    if (board.BoardArray[x+1,y] != null && board.BoardArray[x+1,y].Type == CellType.Bomb)
                    {
                        count++;
                    }

                    if (board.BoardArray[x+1,y-1] != null && board.BoardArray[x+1,y-1].Type == CellType.Bomb)
                    {
                        count++;
                    }

                    if (board.BoardArray[x,y-1] != null && board.BoardArray[x,y-1].Type == CellType.Bomb)
                    {
                        count++;
                    }
                }
            }


            return count;
        }
        
        public static int CountDiscoveredBombs(Board board, int x, int y)
        {
            int count = 0;
            if (x == 0)
            {
                if (y == 0)
                {
                    if (board.BoardArray[x,y+1].State == CellState.Flag && board.BoardArray[x,y+1].Type == CellType.Bomb)
                    {
                        count+=1;
                    }

                    if (board.BoardArray[x+1,y+1].State == CellState.Flag && board.BoardArray[x+1,y+1].Type == CellType.Bomb)
                    {
                        count+=1;
                    }

                    if (board.BoardArray[x+1,y].State == CellState.Flag && board.BoardArray[x+1,y].Type == CellType.Bomb)
                    {
                        count++;
                    }
                }

                if (y == board.size - 1)
                {
                    if (board.BoardArray[x,y-1].State == CellState.Flag && board.BoardArray[x,y-1].Type == CellType.Bomb)
                    {
                        count++;
                    }

                    if (board.BoardArray[x+1,y-1].State == CellState.Flag && board.BoardArray[x+1,y-1].Type == CellType.Bomb)
                    {
                        count++;
                    }

                    if (board.BoardArray[x+1,y].State == CellState.Flag && board.BoardArray[x+1,y].Type == CellType.Bomb)
                    {
                        count++;
                    }
                }

                if (y > 0 && y < board.size - 1)
                {
                    if (board.BoardArray[x,y+1].State == CellState.Flag && board.BoardArray[x,y+1].Type == CellType.Bomb)
                    {
                        count++;
                    }

                    if (board.BoardArray[x+1,y+1].State == CellState.Flag && board.BoardArray[x+1,y+1].Type == CellType.Bomb)
                    {
                        count++;
                    }

                    if (board.BoardArray[x+1,y].State == CellState.Flag && board.BoardArray[x+1,y].Type == CellType.Bomb)
                    {
                        count++;
                    }

                    if (board.BoardArray[x+1,y-1].State == CellState.Flag && board.BoardArray[x+1,y-1].Type == CellType.Bomb)
                    {
                        count++;
                    }

                    if (board.BoardArray[x,y-1].State == CellState.Flag && board.BoardArray[x,y-1].Type == CellType.Bomb)
                    {
                        count++;
                    }
                }
            }

            if (x == board.size - 1)
            {
                if (y == 0)
                {
                    if (board.BoardArray[x-1,y].State == CellState.Flag && board.BoardArray[x-1,y].Type == CellType.Bomb)
                    {
                        count++;
                    }

                    if (board.BoardArray[x-1,y+1].State == CellState.Flag && board.BoardArray[x-1,y+1].Type == CellType.Bomb)
                    {
                        count++;
                    }

                    if (board.BoardArray[x,y+1].State == CellState.Flag && board.BoardArray[x,y+1].Type == CellType.Bomb)
                    {
                        count++;
                    }
                }

                if (y == board.size - 1)
                {
                    

                    if (board.BoardArray[x,y-1].State == CellState.Flag && board.BoardArray[x,y-1].Type == CellType.Bomb)
                    {
                        count++;
                    }

                    if (board.BoardArray[x-1,y-1].State == CellState.Flag && board.BoardArray[x-1,y-1].Type == CellType.Bomb)
                    {
                        count++;
                    }

                    if (board.BoardArray[x-1,y].State == CellState.Flag && board.BoardArray[x-1,y].Type == CellType.Bomb)
                    {
                        count++;
                    }
                }
                
                if (y > 0 && y < board.size - 1)
                {
                    if (board.BoardArray[x,y-1].State == CellState.Flag && board.BoardArray[x,y-1].Type == CellType.Bomb)
                    {
                        count++;
                    }

                    if (board.BoardArray[x-1,y-1].State == CellState.Flag && board.BoardArray[x-1,y-1].Type == CellType.Bomb)
                    {
                        count++;
                    }

                    if (board.BoardArray[x-1,y].State == CellState.Flag && board.BoardArray[x-1,y].Type == CellType.Bomb)
                    {
                        count++;
                    }

                    if (board.BoardArray[x-1,y+1].State == CellState.Flag && board.BoardArray[x-1,y+1].Type == CellType.Bomb)
                    {
                        count++;
                    }

                    if (board.BoardArray[x,y+1].State == CellState.Flag && board.BoardArray[x,y+1].Type == CellType.Bomb)
                    {
                        count++;
                    }
                }
            }
            if (x > 0 && x < board.size - 1)
            {
                if (y == 0)
                {
                    if (board.BoardArray[x-1,y].State == CellState.Flag && board.BoardArray[x-1,y].Type == CellType.Bomb)
                    {
                        count++;
                    }

                    if (board.BoardArray[x-1,y+1].State == CellState.Flag && board.BoardArray[x-1,y+1].Type == CellType.Bomb)
                    {
                        count++;
                    }

                    if (board.BoardArray[x,y+1].State == CellState.Flag && board.BoardArray[x,y+1].Type == CellType.Bomb)
                    {
                        count++;
                    }

                    if (board.BoardArray[x+1,y+1].State == CellState.Flag && board.BoardArray[x+1,y+1].Type == CellType.Bomb)
                    {
                        count++;
                    }

                    if (board.BoardArray[x+1,y].State == CellState.Flag && board.BoardArray[x+1,y].Type == CellType.Bomb)
                    {
                        count++;
                    }
                }

                if (y == board.size - 1)
                {
                    if (board.BoardArray[x-1,y].State == CellState.Flag && board.BoardArray[x-1,y].Type == CellType.Bomb)
                    {
                        count++;
                    }

                    if (board.BoardArray[x+1,y].State == CellState.Flag && board.BoardArray[x+1,y].Type == CellType.Bomb)
                    {
                        count++;
                    }

                    if (board.BoardArray[x+1,y-1].State == CellState.Flag && board.BoardArray[x+1,y-1].Type == CellType.Bomb)
                    {
                        count++;
                    }

                    if (board.BoardArray[x,y-1].State == CellState.Flag && board.BoardArray[x,y-1].Type == CellType.Bomb)
                    {
                        count++;
                    }

                    if (board.BoardArray[x-1,y-1].State == CellState.Flag && board.BoardArray[x-1,y-1].Type == CellType.Bomb)
                    {
                        count++;
                    }
                }
                if (y > 0 && y < board.size - 1)
                {
                    if (board.BoardArray[x-1,y-1].State == CellState.Flag && board.BoardArray[x-1,y-1].Type == CellType.Bomb)
                    {
                        count++;
                    }

                    if (board.BoardArray[x-1,y].State == CellState.Flag && board.BoardArray[x-1,y].Type == CellType.Bomb)
                    {
                        count++;
                    }

                    if (board.BoardArray[x-1,y+1].State == CellState.Flag && board.BoardArray[x-1,y+1].Type == CellType.Bomb)
                    {
                        count++;
                    }

                    if (board.BoardArray[x,y+1].State == CellState.Flag && board.BoardArray[x,y+1].Type == CellType.Bomb)
                    {
                        count++;
                    }

                    if (board.BoardArray[x+1,y+1].State == CellState.Flag && board.BoardArray[x+1,y+1].Type == CellType.Bomb)
                    {
                        count++;
                    }

                    if (board.BoardArray[x+1,y].State == CellState.Flag && board.BoardArray[x+1,y].Type == CellType.Bomb)
                    {
                        count++;
                    }

                    if (board.BoardArray[x+1,y-1].State == CellState.Flag && board.BoardArray[x+1,y-1].Type == CellType.Bomb)
                    {
                        count++;
                    }

                    if (board.BoardArray[x,y-1].State == CellState.Flag && board.BoardArray[x,y-1].Type == CellType.Bomb)
                    {
                        count++;
                    }
                }
            }
            return count;
        }

        public static void Discover(Board board, int x, int y)
        {
            if (x == 0)
            {
                if (y == 0) //check si c'est la case en haut à gauche
                {
                    if (board.BoardArray[x,y+1].Type != CellType.Bomb)
                    {
                        board.BoardArray[x, y + 1].State = CellState.Discovered;
                        if (board.BoardArray[x, y + 1].Type == CellType.Empty)
                        {
                            Empty(board, x, y + 1);
                        }
                    }
                    else
                    {
                        LeftClick(board, x, y + 1);
                    }

                    if (board.BoardArray[x+1,y+1].Type != CellType.Bomb)
                    {
                        board.BoardArray[x+1,y+1].State = CellState.Discovered;
                        if (board.BoardArray[x+1,y+1].Type == CellType.Empty)
                        {
                            Empty(board,x+1,y+1);
                        }
                    }
                    else
                    {
                        LeftClick(board, x + 1, y + 1);
                    }

                    if (board.BoardArray[x+1,y].Type != CellType.Bomb)
                    {
                        board.BoardArray[x+1,y].State = CellState.Discovered;
                        if (board.BoardArray[x+1,y].Type == CellType.Empty)
                        {
                            Empty(board,x+1,y);
                        }
                    }
                    else
                    {
                        LeftClick(board, x+1,y+1);
                    }
                }

                if (y == board.size - 1)
                {
                    if (board.BoardArray[x,y-1].Type != CellType.Bomb)
                    {
                        board.BoardArray[x,y-1].State = CellState.Discovered;
                        if (board.BoardArray[x,y-1].Type == CellType.Empty)
                        {
                            Empty(board, x,y-1);
                        }
                    }
                    else
                    {
                        LeftClick(board, x,y-1);
                    }

                    if (board.BoardArray[x+1,y-1].Type != CellType.Bomb)
                    {
                        board.BoardArray[x+1,y-1].State = CellState.Discovered;
                        if (board.BoardArray[x+1,y-1].Type == CellType.Empty)
                        {
                            Empty(board, x+1,y-1);
                        }
                    }
                    else
                    {
                        LeftClick(board, x+1,y-1);
                    }

                    if (board.BoardArray[x+1,y].Type != CellType.Bomb)
                    {
                        board.BoardArray[x+1,y].State = CellState.Discovered;
                        if (board.BoardArray[x+1,y].Type == CellType.Empty)
                        {
                            Empty(board, x+1,y);
                        }
                    }
                    else
                    {
                        LeftClick(board, x+1,y);
                    }
                }

                if (y > 0 && y < board.size - 1)
                {
                    if (board.BoardArray[x,y+1].Type != CellType.Bomb)
                    {
                        board.BoardArray[x,y+1].State = CellState.Discovered;
                        if (board.BoardArray[x,y+1].Type == CellType.Empty)
                        {
                            Empty(board, x,y+1);
                        }
                    }
                    else
                    {
                        LeftClick(board, x,y+1);
                    }

                    if (board.BoardArray[x+1,y+1].Type != CellType.Bomb)
                    {
                        board.BoardArray[x+1,y+1].State = CellState.Discovered;
                        if (board.BoardArray[x+1,y+1].Type == CellType.Empty)
                        {
                            Empty(board,x+1,y+1 );
                        }
                    }
                    else
                    {
                        LeftClick(board, x+1,y+1);
                    }

                    if (board.BoardArray[x+1,y].Type != CellType.Bomb)
                    {
                        board.BoardArray[x+1,y].State = CellState.Discovered;
                        if (board.BoardArray[x+1,y].Type == CellType.Empty)
                        {
                            Empty(board, x+1,y);
                        }
                    }
                    else
                    {
                        LeftClick(board, x+1,y);
                    }

                    if (board.BoardArray[x+1,y-1].Type != CellType.Bomb)
                    {
                        board.BoardArray[x+1,y-1].State = CellState.Discovered;
                        if (board.BoardArray[x+1,y-1].Type == CellType.Empty)
                        {
                            Empty(board, x+1,y-1);
                        }
                    }
                    else
                    {
                        LeftClick(board, x+1,y-1);
                    }

                    if (board.BoardArray[x,y-1].Type != CellType.Bomb)
                    {
                        board.BoardArray[x,y-1].State = CellState.Discovered;
                        if (board.BoardArray[x,y-1].Type == CellType.Empty)
                        {
                            Empty(board, x,y-1);
                        }
                    }
                    else
                    {
                        LeftClick(board, x,y-1);
                    }
                }
            }

            if (x == board.size - 1)
            {
                if (y == 0)
                {
                    if (board.BoardArray[x-1,y].Type != CellType.Bomb)
                    {
                        board.BoardArray[x-1,y].State = CellState.Discovered;
                        if (board.BoardArray[x-1,y].Type == CellType.Empty)
                        {
                            Empty(board, x-1,y);
                        }
                    }
                    
                    else
                    {
                        LeftClick(board, x-1,y);
                    }

                    if (board.BoardArray[x-1,y+1].Type != CellType.Bomb)
                    {
                        board.BoardArray[x-1,y+1].State = CellState.Discovered;
                        if (board.BoardArray[x-1,y+1].Type == CellType.Empty)
                        {
                            Empty(board, x-1,y+1);
                        }
                    }
                    else
                    {
                        LeftClick(board, x-1,y+1);
                    }

                    if (board.BoardArray[x,y+1].Type != CellType.Bomb)
                    {
                        board.BoardArray[x,y+1].State = CellState.Discovered;
                        if (board.BoardArray[x,y+1].Type == CellType.Empty)
                        {
                            Empty(board, x,y+1);
                        }
                    }
                    else
                    {
                        LeftClick(board, x,y+1);
                    }
                }

                if (y == board.size - 1)
                {
                    

                    if (board.BoardArray[x,y-1].Type != CellType.Bomb)
                    {
                        board.BoardArray[x,y-1].State = CellState.Discovered;
                        if (board.BoardArray[x,y-1].Type == CellType.Empty)
                        {
                            Empty(board, x,y-1);
                        }
                    }
                    else
                    {
                        LeftClick(board, x,y-1);
                    }

                    if (board.BoardArray[x-1,y-1].Type != CellType.Bomb)
                    {
                        board.BoardArray[x-1,y-1].State = CellState.Discovered;
                        if (board.BoardArray[x-1,y-1].Type == CellType.Empty)
                        {
                            Empty(board,x-1,y-1);
                        }
                    }
                    else
                    {
                        LeftClick(board, x-1,y-1);
                    }

                    if (board.BoardArray[x-1,y].Type != CellType.Bomb)
                    {
                        board.BoardArray[x-1,y].State = CellState.Discovered;
                        if (board.BoardArray[x-1,y].Type == CellType.Empty)
                        {
                            Empty(board, x-1,y);
                        }
                    }
                    else
                    {
                        LeftClick(board, x-1,y);
                    }
                }
                
                if (y > 0 && y < board.size - 1)
                {
                    if (board.BoardArray[x,y-1].Type != CellType.Bomb)
                    {
                        board.BoardArray[x,y-1].State = CellState.Discovered;
                        if (board.BoardArray[x,y-1].Type == CellType.Empty)
                        {
                            Empty(board, x,y-1);
                        }
                    }
                    else
                    {
                        LeftClick(board, x,y-1);
                    }

                    if (board.BoardArray[x-1,y-1].Type != CellType.Bomb)
                    {
                        board.BoardArray[x-1,y-1].State = CellState.Discovered;
                        if (board.BoardArray[x-1,y-1].Type == CellType.Empty)
                        {
                            Empty(board, x-1,y-1);
                        }
                    }
                    else
                    {
                        LeftClick(board, x-1,y-1);
                    }

                    if (board.BoardArray[x-1,y].Type != CellType.Bomb)
                    {
                        board.BoardArray[x-1,y].State = CellState.Discovered;
                        if (board.BoardArray[x-1,y].Type == CellType.Empty)
                        {
                            Empty(board, x-1,y);
                        }
                    }
                    else
                    {
                        LeftClick(board, x-1,y);
                    }

                    if (board.BoardArray[x-1,y+1].Type != CellType.Bomb)
                    {
                        board.BoardArray[x-1,y+1].State = CellState.Discovered;
                        if (board.BoardArray[x-1,y+1].Type == CellType.Empty)
                        {
                            Empty(board, x-1,y+1);
                        }
                    }
                    else
                    {
                        LeftClick(board, x-1,y+1);
                    }

                    if (board.BoardArray[x,y+1].Type != CellType.Bomb)
                    {
                        board.BoardArray[x,y+1].State = CellState.Discovered;
                        if (board.BoardArray[x,y+1].Type == CellType.Empty)
                        {
                            Empty(board,x,y+1);
                        }
                    }
                    else
                    {
                        LeftClick(board, x,y+1);
                    }
                }
            }

            if (x > 0 && x < board.size - 1)
            {
                if (y == 0)
                {
                    if (board.BoardArray[x - 1, y].Type != CellType.Bomb)
                    {
                        board.BoardArray[x - 1, y].State = CellState.Discovered;
                        if (board.BoardArray[x - 1, y].Type == CellType.Empty)
                        {
                            Empty(board, x - 1, y);
                        }
                    }
                    else
                    {
                        LeftClick(board, x - 1, y);
                    }

                    if (board.BoardArray[x - 1, y + 1].Type != CellType.Bomb)
                    {
                        board.BoardArray[x - 1, y + 1].State = CellState.Discovered;
                        if (board.BoardArray[x - 1, y + 1].Type == CellType.Empty)
                        {
                            Empty(board, x - 1, y + 1);
                        }
                    }
                    else
                    {
                        LeftClick(board, x - 1, y + 1);
                    }

                    if (board.BoardArray[x, y + 1].Type != CellType.Bomb)
                    {
                        board.BoardArray[x, y + 1].State = CellState.Discovered;
                        if (board.BoardArray[x, y + 1].Type == CellType.Empty)
                        {
                            Empty(board, x, y + 1);
                        }
                    }
                    else
                    {
                        LeftClick(board, x, y + 1);
                    }

                    if (board.BoardArray[x + 1, y + 1].Type != CellType.Bomb)
                    {
                        board.BoardArray[x + 1, y + 1].State = CellState.Discovered;
                        if (board.BoardArray[x + 1, y + 1].Type == CellType.Empty)
                        {
                            Empty(board, x + 1, y + 1);
                        }
                    }
                    else
                    {
                        LeftClick(board, x + 1, y + 1);
                    }

                    if (board.BoardArray[x + 1, y].Type != CellType.Bomb)
                    {
                        board.BoardArray[x + 1, y].State = CellState.Discovered;
                        if (board.BoardArray[x + 1, y].Type == CellType.Empty)
                        {
                            Empty(board, x + 1, y);
                        }
                    }
                    else
                    {
                        LeftClick(board, x + 1, y);
                    }
                }

                if (y == board.size - 1)
                {
                    if (board.BoardArray[x - 1, y].Type != CellType.Bomb)
                    {
                        board.BoardArray[x - 1, y].State = CellState.Discovered;
                        if (board.BoardArray[x - 1, y].Type == CellType.Empty)
                        {
                            Empty(board, x - 1, y);
                        }
                    }
                    else
                    {
                        LeftClick(board, x - 1, y);
                    }

                    if (board.BoardArray[x + 1, y].Type != CellType.Bomb)
                    {
                        board.BoardArray[x + 1, y].State = CellState.Discovered;
                        if (board.BoardArray[x + 1, y].Type == CellType.Empty)
                        {
                            Empty(board, x + 1, y);
                        }
                    }
                    else
                    {
                        LeftClick(board, x + 1, y);
                    }

                    if (board.BoardArray[x + 1, y - 1].Type != CellType.Bomb)
                    {
                        board.BoardArray[x + 1, y - 1].State = CellState.Discovered;
                        if (board.BoardArray[x + 1, y - 1].Type == CellType.Empty)
                        {
                            Empty(board, x + 1, y - 1);
                        }
                    }
                    else
                    {
                        LeftClick(board, x + 1, y - 1);
                    }

                    if (board.BoardArray[x, y - 1].Type != CellType.Bomb)
                    {
                        board.BoardArray[x, y - 1].State = CellState.Discovered;
                        if (board.BoardArray[x, y - 1].Type == CellType.Empty)
                        {
                            Empty(board, x, y - 1);
                        }
                    }
                    else
                    {
                        LeftClick(board, x, y - 1);
                    }

                    if (board.BoardArray[x - 1, y - 1].Type != CellType.Bomb)
                    {
                        board.BoardArray[x - 1, y - 1].State = CellState.Discovered;
                        if (board.BoardArray[x - 1, y - 1].Type == CellType.Empty)
                        {
                            Empty(board, x - 1, y - 1);
                        }
                    }
                    else
                    {
                        LeftClick(board, x - 1, y - 1);
                    }
                }

                if (y > 0 && y < board.size - 1)
                {
                    if (board.BoardArray[x - 1, y - 1].Type != CellType.Bomb)
                    {
                        board.BoardArray[x - 1, y - 1].State = CellState.Discovered;
                        if (board.BoardArray[x - 1, y - 1].Type == CellType.Empty)
                        {
                            Empty(board, x - 1, y - 1);
                        }
                    }
                    else
                    {
                        LeftClick(board, x - 1, y - 1);
                    }

                    if (board.BoardArray[x - 1, y].Type != CellType.Bomb)
                    {
                        board.BoardArray[x - 1, y].State = CellState.Discovered;
                        if (board.BoardArray[x - 1, y].Type == CellType.Empty)
                        {
                            Empty(board, x - 1, y);
                        }
                    }
                    else
                    {
                        LeftClick(board, x - 1, y);
                    }

                    if (board.BoardArray[x - 1, y + 1].Type != CellType.Bomb)
                    {
                        board.BoardArray[x - 1, y + 1].State = CellState.Discovered;
                        if (board.BoardArray[x - 1, y + 1].Type == CellType.Empty)
                        {
                            Empty(board, x - 1, y + 1);
                        }
                    }
                    else
                    {
                        LeftClick(board, x - 1, y + 1);
                    }

                    if (board.BoardArray[x, y + 1].Type != CellType.Bomb)
                    {
                        board.BoardArray[x, y + 1].State = CellState.Discovered;
                        if (board.BoardArray[x, y + 1].Type == CellType.Empty)
                        {
                            Empty(board, x, y + 1);
                        }
                    }
                    else
                    {
                        LeftClick(board, x, y + 1);
                    }

                    if (board.BoardArray[x + 1, y + 1].Type != CellType.Bomb)
                    {
                        board.BoardArray[x + 1, y + 1].State = CellState.Discovered;
                        if (board.BoardArray[x + 1, y + 1].Type == CellType.Empty)
                        {
                            Empty(board, x + 1, y + 1);
                        }
                    }
                    else
                    {
                        LeftClick(board, x + 1, y + 1);
                    }

                    if (board.BoardArray[x + 1, y].Type != CellType.Bomb)
                    {
                        board.BoardArray[x + 1, y].State = CellState.Discovered;
                        if (board.BoardArray[x + 1, y].Type == CellType.Empty)
                        {
                            Empty(board, x + 1, y);
                        }
                    }
                    else
                    {
                        LeftClick(board, x + 1, y);
                    }

                    if (board.BoardArray[x + 1, y - 1].Type != CellType.Bomb)
                    {
                        board.BoardArray[x + 1, y - 1].State = CellState.Discovered;
                        if (board.BoardArray[x + 1, y - 1].Type == CellType.Empty)
                        {
                            Empty(board, x + 1, y - 1);
                        }
                    }
                    else
                    {
                        LeftClick(board, x + 1, y - 1);
                    }

                    if (board.BoardArray[x, y - 1].Type != CellType.Bomb)
                    {
                        board.BoardArray[x, y - 1].State = CellState.Discovered;
                        if (board.BoardArray[x, y - 1].Type == CellType.Empty)
                        {
                            Empty(board, x, y - 1);
                        }
                    }
                    else
                    {
                        LeftClick(board, x, y - 1);
                    }
                }
            }
        }

        public static void Empty(Board board, int x, int y)
        {
            if (x == 0)
            {
                if (y == 0)
                {
                    if (board.BoardArray[x, y + 1].Type == CellType.Empty && board.BoardArray[x, y + 1].State != CellState.Discovered)
                    {
                        board.BoardArray[x, y + 1].State = CellState.Discovered;
                        Empty(board, x, y + 1);
                    }
                    if (board.BoardArray[x + 1, y + 1].Type == CellType.Empty && board.BoardArray[x + 1, y + 1].State != CellState.Discovered)
                    {
                        board.BoardArray[x + 1, y + 1].State = CellState.Discovered;
                        Empty(board, x + 1, y + 1);
                    }
                    if (board.BoardArray[x + 1, y].Type == CellType.Empty && board.BoardArray[x + 1, y].State != CellState.Discovered)
                    {
                        board.BoardArray[x + 1, y].State = CellState.Discovered;
                        Empty(board, x + 1, y);
                    }
                    board.BoardArray[x, y + 1].State = CellState.Discovered;
                    board.BoardArray[x + 1, y + 1].State = CellState.Discovered;
                    board.BoardArray[x + 1, y].State = CellState.Discovered;
                }

                if (y == board.size - 1)
                {
                    if (board.BoardArray[x + 1, y].Type == CellType.Empty && board.BoardArray[x + 1, y].State != CellState.Discovered)
                    {
                        board.BoardArray[x + 1, y].State = CellState.Discovered;
                        Empty(board, x + 1, y);
                    }
                    if (board.BoardArray[x + 1, y - 1].Type == CellType.Empty && board.BoardArray[x + 1, y - 1].State != CellState.Discovered)
                    {
                        board.BoardArray[x + 1, y - 1].State = CellState.Discovered;
                        Empty(board, x + 1, y - 1);
                    }
                    if (board.BoardArray[x, y - 1].Type == CellType.Empty && board.BoardArray[x, y - 1].State != CellState.Discovered)
                    {
                        board.BoardArray[x, y - 1].State = CellState.Discovered;
                        Empty(board, x, y - 1);
                    }
                    board.BoardArray[x + 1, y].State = CellState.Discovered;
                    board.BoardArray[x + 1, y - 1].State = CellState.Discovered;
                    board.BoardArray[x, y - 1].State = CellState.Discovered;
                }

                if (y > 0 && y < board.size - 1)
                {
                    if (board.BoardArray[x, y + 1].Type == CellType.Empty && board.BoardArray[x, y + 1].State != CellState.Discovered)
                    {
                        board.BoardArray[x, y + 1].State = CellState.Discovered;
                        Empty(board, x, y + 1);
                    }
                    if (board.BoardArray[x + 1, y + 1].Type == CellType.Empty && board.BoardArray[x + 1, y + 1].State != CellState.Discovered)
                    {
                        board.BoardArray[x + 1, y + 1].State = CellState.Discovered;
                        Empty(board, x + 1, y + 1);
                    }
                    if (board.BoardArray[x + 1, y].Type == CellType.Empty && board.BoardArray[x + 1, y].State != CellState.Discovered)
                    {
                        board.BoardArray[x + 1, y].State = CellState.Discovered;
                        Empty(board, x + 1, y);
                    }
                    if (board.BoardArray[x + 1, y - 1].Type == CellType.Empty && board.BoardArray[x + 1, y - 1].State != CellState.Discovered)
                    {
                        board.BoardArray[x + 1, y - 1].State = CellState.Discovered;
                        Empty(board, x + 1, y - 1);
                    }
                    if (board.BoardArray[x, y - 1].Type == CellType.Empty && board.BoardArray[x, y - 1].State != CellState.Discovered)
                    {
                        board.BoardArray[x, y - 1].State = CellState.Discovered;
                        Empty(board, x, y - 1);
                    }
                    board.BoardArray[x, y + 1].State = CellState.Discovered;
                    board.BoardArray[x + 1, y + 1].State = CellState.Discovered;
                    board.BoardArray[x + 1, y].State = CellState.Discovered;
                    board.BoardArray[x + 1, y - 1].State = CellState.Discovered;
                    board.BoardArray[x, y - 1].State = CellState.Discovered;
                }
            }

            if (x == board.size - 1)
            {
                if (y == 0)
                {
                    if (board.BoardArray[x - 1, y].Type == CellType.Empty && board.BoardArray[x - 1, y].State != CellState.Discovered)
                    {
                        board.BoardArray[x - 1, y].State = CellState.Discovered;
                        Empty(board, x - 1, y);
                    }
                    if (board.BoardArray[x - 1, y + 1].Type == CellType.Empty && board.BoardArray[x - 1, y + 1].State != CellState.Discovered)
                    {
                        board.BoardArray[x - 1, y + 1].State = CellState.Discovered;
                        Empty(board, x - 1, y + 1);
                    }
                    if (board.BoardArray[x, y + 1].Type == CellType.Empty && board.BoardArray[x, y + 1].State != CellState.Discovered)
                    {
                        board.BoardArray[x, y + 1].State = CellState.Discovered;
                        Empty(board, x, y + 1);
                    }
                    board.BoardArray[x - 1, y].State = CellState.Discovered;
                    board.BoardArray[x - 1, y + 1].State = CellState.Discovered;
                    board.BoardArray[x, y + 1].State = CellState.Discovered;
                }

                if (y == board.size - 1)
                {
                    if (board.BoardArray[x - 1, y - 1].Type == CellType.Empty && board.BoardArray[x - 1, y - 1].State != CellState.Discovered)
                    {
                        board.BoardArray[x - 1, y - 1].State = CellState.Discovered;
                        Empty(board, x - 1, y - 1);
                    }
                    if (board.BoardArray[x - 1, y].Type == CellType.Empty && board.BoardArray[x - 1, y].State != CellState.Discovered)
                    {
                        board.BoardArray[x - 1, y].State = CellState.Discovered;
                        Empty(board, x - 1, y);
                    }
                    if (board.BoardArray[x, y - 1].Type == CellType.Empty && board.BoardArray[x, y - 1].State != CellState.Discovered)
                    {
                        board.BoardArray[x, y - 1].State = CellState.Discovered;
                        Empty(board, x, y - 1);
                    }
                    board.BoardArray[x - 1, y - 1].State = CellState.Discovered;
                    board.BoardArray[x - 1, y].State = CellState.Discovered;
                    board.BoardArray[x, y - 1].State = CellState.Discovered;
                }

                if (y > 0 && y < board.size - 1)
                {
                    if (board.BoardArray[x - 1, y - 1].Type == CellType.Empty && board.BoardArray[x - 1, y - 1].State != CellState.Discovered)
                    {
                        board.BoardArray[x - 1, y + 1].State = CellState.Discovered;
                        Empty(board, x - 1, y - 1);
                    }
                    if (board.BoardArray[x - 1, y].Type == CellType.Empty && board.BoardArray[x - 1, y].State != CellState.Discovered)
                    {
                        board.BoardArray[x, y + 1].State = CellState.Discovered;
                        Empty(board, x - 1, y);
                    }
                    if (board.BoardArray[x - 1, y + 1].Type == CellType.Empty && board.BoardArray[x - 1, y + 1].State != CellState.Discovered)
                    {
                        board.BoardArray[x - 1, y - 1].State = CellState.Discovered;
                        Empty(board, x - 1, y + 1);
                    }
                    if (board.BoardArray[x, y + 1].Type == CellType.Empty && board.BoardArray[x, y + 1].State != CellState.Discovered)
                    {
                        board.BoardArray[x - 1, y].State = CellState.Discovered;
                        Empty(board, x, y + 1);
                    }
                    if (board.BoardArray[x, y - 1].Type == CellType.Empty && board.BoardArray[x, y - 1].State != CellState.Discovered)
                    {
                        board.BoardArray[x, y - 1].State = CellState.Discovered;
                        Empty(board, x, y - 1);
                    }
                    board.BoardArray[x - 1, y + 1].State = CellState.Discovered;
                    board.BoardArray[x, y + 1].State = CellState.Discovered;
                    board.BoardArray[x - 1, y - 1].State = CellState.Discovered;
                    board.BoardArray[x - 1, y].State = CellState.Discovered;
                    board.BoardArray[x, y - 1].State = CellState.Discovered;
                }
            }

            if (x > 0 && x < board.size - 1)
            {
                if (y == 0)
                {
                    if (board.BoardArray[x - 1, y].Type == CellType.Empty && board.BoardArray[x - 1, y].State != CellState.Discovered)
                    {
                        board.BoardArray[x - 1, y].State = CellState.Discovered;
                        Empty(board, x - 1, y);
                    }
                    if (board.BoardArray[x - 1, y + 1].Type == CellType.Empty && board.BoardArray[x - 1, y + 1].State != CellState.Discovered)
                    {
                        board.BoardArray[x - 1, y + 1].State = CellState.Discovered;
                        Empty(board, x - 1, y + 1);
                    }
                    if (board.BoardArray[x, y + 1].Type == CellType.Empty && board.BoardArray[x, y + 1].State != CellState.Discovered)
                    {
                        board.BoardArray[x, y + 1].State = CellState.Discovered;
                        Empty(board, x, y + 1);
                    }
                    if (board.BoardArray[x + 1, y + 1].Type == CellType.Empty && board.BoardArray[x + 1, y + 1].State != CellState.Discovered)
                    {
                        board.BoardArray[x + 1, y + 1].State = CellState.Discovered;
                        Empty(board, x + 1, y + 1);
                    }
                    if (board.BoardArray[x + 1, y].Type == CellType.Empty && board.BoardArray[x + 1, y].State != CellState.Discovered)
                    {
                        board.BoardArray[x + 1, y].State = CellState.Discovered;
                        Empty(board, x + 1, y);
                    }
                    board.BoardArray[x - 1, y].State = CellState.Discovered;
                    board.BoardArray[x - 1, y + 1].State = CellState.Discovered;
                    board.BoardArray[x, y + 1].State = CellState.Discovered;
                    board.BoardArray[x + 1, y + 1].State = CellState.Discovered;
                    board.BoardArray[x + 1, y].State = CellState.Discovered;
                }

                if (y == board.size - 1)
                {
                    if (board.BoardArray[x + 1, y].Type == CellType.Empty && board.BoardArray[x + 1, y].State != CellState.Discovered)
                    {
                        board.BoardArray[x + 1, y].State = CellState.Discovered;
                        Empty(board, x + 1, y);
                    }
                    if (board.BoardArray[x + 1, y - 1].Type == CellType.Empty && board.BoardArray[x + 1, y - 1].State != CellState.Discovered)
                    {
                        board.BoardArray[x + 1, y - 1].State = CellState.Discovered;
                        Empty(board, x + 1, y - 1);
                    }
                    if (board.BoardArray[x, y - 1].Type == CellType.Empty && board.BoardArray[x, y - 1].State != CellState.Discovered)
                    {
                        board.BoardArray[x, y - 1].State = CellState.Discovered;
                        Empty(board, x, y - 1);
                    }
                    if (board.BoardArray[x - 1, y - 1].Type == CellType.Empty && board.BoardArray[x - 1, y - 1].State != CellState.Discovered)
                    {
                        board.BoardArray[x - 1, y - 1].State = CellState.Discovered;
                        Empty(board, x - 1, y - 1);
                    }
                    if (board.BoardArray[x - 1, y].Type == CellType.Empty && board.BoardArray[x - 1, y].State != CellState.Discovered)
                    {
                        board.BoardArray[x - 1, y].State = CellState.Discovered;
                        Empty(board, x - 1, y);
                    }
                    board.BoardArray[x + 1, y].State = CellState.Discovered;
                    board.BoardArray[x + 1, y - 1].State = CellState.Discovered;
                    board.BoardArray[x, y - 1].State = CellState.Discovered;
                    board.BoardArray[x - 1, y - 1].State = CellState.Discovered;
                    board.BoardArray[x - 1, y].State = CellState.Discovered;
                }

                if (y > 0 && y < board.size - 1)
                {
                    if (board.BoardArray[x - 1, y - 1].Type == CellType.Empty && board.BoardArray[x - 1, y - 1].State != CellState.Discovered)
                    {
                        board.BoardArray[x - 1, y - 1].State = CellState.Discovered;
                        Empty(board, x - 1, y - 1);
                    }
                    if (board.BoardArray[x - 1, y].Type == CellType.Empty && board.BoardArray[x - 1, y].State != CellState.Discovered)
                    {
                        board.BoardArray[x - 1, y].State = CellState.Discovered;
                        Empty(board, x - 1, y);
                    }
                    if (board.BoardArray[x - 1, y + 1].Type == CellType.Empty && board.BoardArray[x - 1, y + 1].State != CellState.Discovered)
                    {
                        board.BoardArray[x - 1, y + 1].State = CellState.Discovered;
                        Empty(board, x - 1, y + 1);
                    }
                    if (board.BoardArray[x, y + 1].Type == CellType.Empty && board.BoardArray[x, y + 1].State != CellState.Discovered)
                    {
                        board.BoardArray[x, y + 1].State = CellState.Discovered;
                        Empty(board, x, y + 1);
                    }
                    if (board.BoardArray[x + 1, y + 1].Type == CellType.Empty && board.BoardArray[x + 1, y + 1].State != CellState.Discovered)
                    {
                        board.BoardArray[x + 1, y + 1].State = CellState.Discovered;
                        Empty(board, x + 1, y + 1);
                    }
                    if (board.BoardArray[x + 1, y].Type == CellType.Empty && board.BoardArray[x + 1, y].State != CellState.Discovered)
                    {
                        board.BoardArray[x + 1, y].State = CellState.Discovered;
                        Empty(board, x + 1, y);
                    }
                    if (board.BoardArray[x + 1, y - 1].Type == CellType.Empty && board.BoardArray[x + 1, y - 1].State != CellState.Discovered)
                    {
                        board.BoardArray[x + 1, y - 1].State = CellState.Discovered;
                        Empty(board, x + 1, y - 1);
                    }
                    if (board.BoardArray[x, y - 1].Type == CellType.Empty && board.BoardArray[x, y - 1].State != CellState.Discovered)
                    {
                        board.BoardArray[x, y - 1].State = CellState.Discovered;
                        Empty(board, x, y - 1);
                    }
                    board.BoardArray[x - 1, y - 1].State = CellState.Discovered;
                    board.BoardArray[x - 1, y].State = CellState.Discovered;
                    board.BoardArray[x - 1, y + 1].State = CellState.Discovered;
                    board.BoardArray[x, y + 1].State = CellState.Discovered;
                    board.BoardArray[x + 1, y + 1].State = CellState.Discovered;
                    board.BoardArray[x + 1, y].State = CellState.Discovered;
                    board.BoardArray[x + 1, y - 1].State = CellState.Discovered;
                    board.BoardArray[x, y - 1].State = CellState.Discovered;
                }
            }
        }
        
        public static bool LeftClick(Board board, int x, int y)
        {
            Cell cell = board.BoardArray[x, y];
            if (cell.State != CellState.Discovered)
            {
                if (cell.Type == CellType.Bomb)
                {
                    return true;
                }
                if (cell.Type == CellType.Empty)
                {
                    cell.State = CellState.Discovered;
                    Empty(board, x, y);
                }
                else
                {
                    cell.State = CellState.Discovered;
                }
            }
            else
            {
                Dictionary<string, int> dictionary = new Dictionary<string, int>();
                int count = CountBombs(board, x, y);
                int count1 = CountDiscoveredBombs(board, x, y);
                if (count == count1)
                {
                    Discover(board, x, y);
                }
            }

            return false;
        }

        public static void RightClick(Board board, int x, int y)
        {
            if (board.BoardArray[x,y].State != CellState.Discovered)
            {
                board.BoardArray[x, y].State = CellState.Flag;
                board.NbFlags++;
            }
        }

        public static char GetInputChar()
        {
            var input = Console.ReadLine();
            
            if (input == null)
            {
                Console.Error.WriteLine("Invalid Argument");
                return '0';
            }

            if (input.Length != 1)
            {
                Console.Error.WriteLine("Invalid Argument");
                return '0';
            }

            char input1 = Convert.ToChar(input);
            if (char.IsLetter(input1) == false)
            {
                Console.Error.WriteLine("Invalid Argument");
                return '0';
            }

            char input2 = char.ToLower(input1);
            if (input2 == 'l' || input2 == 'r')
            {
                return input2;
            }

            Console.Error.WriteLine("Invalid Argument");
            return '0';
        }

        public static int GetCoordinates()
        {
            var input = Console.ReadLine();
            if (input == null)
            {
                Console.Error.WriteLine("Invalid Argument");
                return 0;
            }

            if (input.Length > 2)
            {
                Console.Error.WriteLine("Invalid Argument");
                return 0;
            }

            try
            {
                int input1 = Int32.Parse(input);
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid Argument");
                return 0;
            }
            int input2 = Int32.Parse(input);
            if (input2 <= 0 || input2 > 16)
            {
                Console.Error.WriteLine("Invalid Argument");
                return 0;
            }

            return input2;
        }

        public static Board.GameState Play()
        {
            Board board = new Board(40);
            while (true)
            { 
                Board.Print(board);
                Console.WriteLine();
                Console.WriteLine("What do you want to do ? (Enter l or r for Left or Right Click)");
                char input = GetInputChar();
                while (input == '0')
                {
                    Console.WriteLine("What do you want to do ? (Enter l or r for Left or Right Click)");
                    input = GetInputChar();
                }
                 
                Console.WriteLine("Enter X coordinates of the case you are clicking");
                int x = GetCoordinates();
                while (x == 0)
                {
                    Console.WriteLine("Enter X coordinates of the case you are clicking");
                    x = GetCoordinates();
                }
                Console.WriteLine("Enter Y coordinates of the case you are clicking");
                int y = GetCoordinates();
                while (y == 0)
                {
                    Console.WriteLine("Enter Y coordinates of the case you are clicking");
                    y = GetCoordinates();
                }
                if (input == 'l')
                {
                    if (LeftClick(board, x - 1, y - 1))
                    {
                        Console.WriteLine();
                        Console.WriteLine("Naaaah ! You lost mate !!");
                        Board.EndScreen(board, x - 1, y - 1);
                        return Board.GameState.LOST;
                    }
                }
                else
                {
                    RightClick(board, x - 1, y - 1);
                }

                int count = 0;
                foreach (var cell in board.BoardArray)
                {
                    if (cell.Type == CellType.Bomb && cell.State == CellState.Flag)
                    {
                        count++;
                    }
                }

                if (count == board.NbBombes)
                {
                    Board.Print(board);
                    return Board.GameState.WON;
                }
            }
        }

        public static void LaunchGame()
        {
            Board.GameState gameState = Play();
            if (gameState == Board.GameState.WON)
            {
                Console.WriteLine();
                Console.WriteLine("GG !! You won !!");
            }
            else
            {
                Console.WriteLine("Try again ? (y/n)");
                var c = Console.ReadLine();
                while (c == null)
                {
                    c = Console.ReadLine();
                }

                while (c != "y" && c != "n")
                {
                    Console.WriteLine("Wrong argument ! I said y or n ?");
                    c = Console.ReadLine();
                }
                if (c == "y")
                { 
                    Console.Clear(); 
                    LaunchGame();
                }
            }
        }
    }
}