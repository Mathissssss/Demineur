using System;
using System.Drawing;

namespace Démineur
{
    public class Board
    {
        private Cell[,] board;
        private int nbBombes;
        private int nbDécouvertes;
        private int nbRestantes;
        public readonly int size = 16;

        public int NbBombe => nbBombes;

        public Cell[,] BoardArray => board;

        public int NbDécouvertes => nbDécouvertes;

        public int NbRestantes => nbRestantes;

        public Board(int Bombes)
        {
            this.nbBombes = 0;
            this.board = new Cell[size, size];
            this.nbDécouvertes = 0;
            this.nbRestantes = Bombes;
            
            Random rnd = new Random();
            Random rnd1 = new Random();
            int x = 0;
            int y = 0;
            while (this.nbBombes < Bombes)
            {
                x = rnd.Next(16);
                y = rnd1.Next(16);
                if (board[x,y] == null)
                {
                    board[x,y] = new Cell(CellType.Bomb);
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
                        int count1 = Cell.CountBombs(this, board[x,y], x, y);
                        board[x,y] = new Cell((CellType) count1);
                    }
                    if (board[x,y].Type != CellType.Bomb)
                    {
                        int count2 = Cell.CountBombs(this, board[x,y], x, y);
                        board[x,y].Type = (CellType) count2;
                    }
                }
            }
        }
        
    }
}