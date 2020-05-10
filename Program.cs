using System;

namespace XOXO_Game_Correction
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var game = new Game(10, new Player(Piece.X, new RandomPlacementBehaviour()), new Player(Piece.O, new ConsoleInputPlacementBehaviour()), new ConsoleDisplayer());
            game.GameLogic();
        }
    }
}
