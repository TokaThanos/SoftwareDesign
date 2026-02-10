using TicTacToe.Model;

namespace TicTacToe.Engine
{
    internal class GameLogic
    {
        private readonly Random _random = new Random();
        private Board _board;
        private Player[] _players;
        private int _currentIndex;

        public GameLogic(int size, string player1, string player2)
        {
            _board = new Board(size);
            _players = new Player[] 
            { 
                new Player(player1, new PlayingPieceX()),
                new Player(player2, new PlayingPieceO())
            };
            _currentIndex = _random.Next(0, _players.Length);
        }

        public void Start()
        {
            bool noWinner = true;
            while (noWinner)
            {
                _board.PrintBoard();
                Console.Write($"Player: {_players[_currentIndex].Name} please enter [row, column] - ");
                string input = Console.ReadLine();
                string[] parts = input.Split(',');
                int row = int.Parse(parts[0].Trim());
                int col = int.Parse(parts[1].Trim());
                bool success = _board.AddPiece(row, col, _players[_currentIndex].Piece);
                if (!success)
                {
                    Console.WriteLine("Incorrect position! Please try again...");
                    continue;
                }
                noWinner = !CheckWinner(row, col, _players[_currentIndex].Piece);
                if (noWinner == false)
                {
                    _board.PrintBoard();
                    Console.WriteLine($"Player {_players[_currentIndex].Name} wins!");
                    return;
                }
                if (IsDraw(_board))
                {
                    _board.PrintBoard();
                    Console.WriteLine("It's a draw!");
                    return;
                }
                _currentIndex = 1 - _currentIndex;
            }
        }

        private bool IsDraw(Board board)
        {
            for (int i = 0; i < board.Size; i++)
            {
                for (int j = 0; j < board.Size; j++)
                {
                    if (board.GetPiece(i, j) == null) return false;
                }
            }
            return true;
        }

        private bool CheckWinner(int row, int col, PlayingPiece currentPiece)
        {
            bool rowMatch = true, colMatch = true, diagonalMatch = true, antiDiagonalMatch = true;
            // row check logic
            for (int i = 0; i < _board.Size; i++)
            {
                if (_board.GetPiece(row, i) == null || _board.GetPiece(row, i).Piece != currentPiece.Piece)
                {
                    rowMatch = false;
                    break;
                }
            }
            // col check logic
            for (int i = 0; i < _board.Size; i++)
            {
                if (_board.GetPiece(i, col) == null || _board.GetPiece(i, col).Piece != currentPiece.Piece)
                {
                    colMatch = false;
                    break;
                }
            }
            // diag check logic
            for (int i = 0, j = 0; i < _board.Size; i++, j++)
            {
                if (_board.GetPiece(i, j) == null || _board.GetPiece(i, j).Piece != currentPiece.Piece)
                {
                    diagonalMatch = false;
                    break;
                }
            }
            // anti diag check logic
            for (int i = _board.Size - 1, j = 0; i >= 0; i--, j++)
            {
                if (_board.GetPiece(i, j) == null || _board.GetPiece(i, j).Piece != currentPiece.Piece)
                {
                    antiDiagonalMatch = false;
                    break;
                }
            }
            return rowMatch || colMatch || diagonalMatch || antiDiagonalMatch;
        }
    }
}
