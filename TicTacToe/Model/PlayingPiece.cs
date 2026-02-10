using TicTacToe.Enum;

namespace TicTacToe.Model
{
    internal abstract class PlayingPiece
    {
        public PieceType Piece { get; }
        public PlayingPiece(PieceType type)
        {
            Piece = type;
        }
    }
}
