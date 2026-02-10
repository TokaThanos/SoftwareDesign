namespace TicTacToe.Model
{
    internal class Player
    {
        public string Name { get; }
        public PlayingPiece Piece { get; }
        public Player(string name, PlayingPiece piece)
        {
            Name = name;
            Piece = piece;
        }
    }
}
