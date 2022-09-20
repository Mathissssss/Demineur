using System;

namespace Démineur
{
    class Program
    {
        static void Main(string[] args)
        {
            Board board = new Board(40);
            for (int i = 0; i < board.size; i++)
            {
                for (int j = 0; j < board.size; j++)
                {
                    Console.Write("{0}  ", board.BoardArray[j,i].Type);
                }
                Console.WriteLine();
            }
        }
    }
}