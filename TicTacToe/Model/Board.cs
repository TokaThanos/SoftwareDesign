namespace TicTacToe.Model
{
    internal class Board
    {
        private readonly PlayingPiece[,] board;
        public int Size { get; }

        public Board(int size)
        {
            Size = size;
            board = new PlayingPiece[Size, Size];
        }

        public bool AddPiece(int row, int col, PlayingPiece piece)
        {
            if (board[row, col] != null)
            {
                return false;
            }
            board[row, col] = piece;
            return true;
        }

        public PlayingPiece GetPiece(int row, int col)
        {
            return board[row, col];
        }

        public void PrintBoard()
        {
            for (int i = 0; i < Size; i++)
            {
                for (int j = 0; j < Size; j++)
                {
                    if (board[i, j] != null)
                    {
                        Console.Write($" {board[i, j].Piece} ");
                    }
                    else
                    {
                        Console.Write("   ");
                    }
                    Console.Write(" | ");
                }
                Console.WriteLine();
            }
        }
    }
}
