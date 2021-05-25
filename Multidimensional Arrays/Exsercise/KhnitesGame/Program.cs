using System;

namespace KhnitesGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char[,] board = new char[n,n];

            for (int row = 0; row < board.GetLength(0); row++)
            {
                char[] input = Console.ReadLine()
                    .ToCharArray();
                for (int col = 0; col < board.GetLength(1); col++)
                {
                    board[row, col] = input[col];

                }
            }

            int kickCounter = 0;

            bool noHorse = false;
            while (!noHorse)
            {
                int hRow = -1;
                int hcol = -1;
                int maxHorsesHit = 0;

                for (int row = 0; row < board.GetLength(0); row++)
                {
                    for (int col = 0; col < board.GetLength(1); col++)
                    {
                        if (board[row, col]== 'K') 
                        {
                            int CurenHorsesHit = 0; 
                            if (IsValid(board, row+2, col-1))
                            {
                                CurenHorsesHit = IsHors(CurenHorsesHit, board[row + 2, col - 1]);
                            }
                            if (IsValid(board, row + 2, col + 1))
                            {
                                CurenHorsesHit = IsHors(CurenHorsesHit, board[row + 2, col + 1]);
                            }
                            if (IsValid(board, row-1, col - 2))
                            {
                                CurenHorsesHit = IsHors(CurenHorsesHit, board[row-1, col - 2]);
                            }
                            if (IsValid(board, row +1, col - 2))
                            {
                                CurenHorsesHit = IsHors(CurenHorsesHit, board[row + 1, col - 2]);
                            }
                            if (IsValid(board, row + 1, col + 2))
                            {
                                CurenHorsesHit = IsHors(CurenHorsesHit, board[row + 1, col + 2]);
                            }
                            if (IsValid(board, row - 1, col + 2))
                            {
                                CurenHorsesHit = IsHors(CurenHorsesHit, board[row - 1, col + 2]);
                            }
                            //down
                            if (IsValid(board, row - 2, col + 1))
                            {
                                CurenHorsesHit = IsHors(CurenHorsesHit, board[row -2, col +1]);
                            }
                            if (IsValid(board, row - 2, col - 1))
                            {
                                CurenHorsesHit = IsHors(CurenHorsesHit, board[row - 2, col - 1]);
                            }
                            if (CurenHorsesHit> maxHorsesHit)
                            {
                                maxHorsesHit = CurenHorsesHit;
                                hRow = row;
                                hcol = col;
                            }
                        }
                    }
                }
                if (maxHorsesHit == 0)
                {
                    noHorse = true;
                }
                else
                {
                    board[hRow, hcol] = '0';
                    kickCounter++;
                }
            }
            Console.WriteLine(kickCounter);
        }

        private static int IsHors(int curenHorsesHit, char v)
        {
            if (v=='K')
            {
                curenHorsesHit++;
            }
            return curenHorsesHit;
        }

        private static bool IsValid(char[,] board, int r, int c)
        {
            return r >= 0 && r < board.GetLength(0) && c >= 0 && c < board.GetLength(0);
        }
    }
}
