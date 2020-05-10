using System;
using System.Collections.Generic;
using System.Text;

namespace XOXO_Game_Correction
{
    public class ConsoleDisplayer: IDisplayer
    {
        public void Display(Board board, int currentRound)
        {
            var result = board.GetResult();
            Console.Clear();
            Console.WriteLine($"-----Tour {currentRound}");
            Console.WriteLine($"-----Nombre de X : {result.XCount}");
            Console.WriteLine($"-----Nombre de O : {result.OCount}");
            Console.WriteLine("  0 1 2 3 4 5 6 7 8 9");
            for (int x = 0; x < board.GetLinesLength(); x++)
            {
                Console.Write(x);
                for(int y = 0; y < board.GetColumnLength(); y++)
                {
                    Console.Write(" ");
                    switch (board[x, y].CaseType)
                    {
                        case CaseType.X:
                            Console.Write("X");
                            break;
                        case CaseType.O:
                            Console.Write("O");
                            break;
                        default:
                            Console.Write(".");
                            break;
                    }
                }
                Console.Write("\n");
            }

            if (board.IsComplete())
            {
                string winner = result.XCount > result.OCount ? "X" : "O";
                Console.WriteLine($"Le gagnant est {winner}");
            }
        }

    }
}
