namespace Démineur
{
    public class Cell
    {
        private CellType type;

        public CellType Type
        {
            get => type;
            set => type = value;
        }

        public Cell(CellType type)
        {
            this.type = type;
        }

        public static int CountBombs(Board board, Cell cell, int x, int y)
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
    }
}