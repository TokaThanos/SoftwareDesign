using TicTacToe.Engine;

namespace TicTacToe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GameLogic game = new GameLogic(3, "Toka", "Puja");
            game.Start();
            Console.WriteLine("Game ends!");
        }
    }
}
