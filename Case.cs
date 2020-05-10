using System;
using System.Collections.Generic;
using System.Text;

namespace XOXO_Game_Correction
{
    public class Case
    {
        public int X { get; set; }
        public int Y { get; set; }
        public CaseType CaseType { get; set; }

        public bool SetCase(Piece piece)
        {
            if (CaseType == CaseType.X || CaseType == CaseType.O)
                return false;
            Console.WriteLine($"Le jouer {piece} joue sur une case en {CaseType.ToString()}");
            switch (piece)
            {
                case Piece.O:
                    CaseType = CaseType.O;
                    break;
                case Piece.X:
                    CaseType = CaseType.X;
                    break;
            }

            return true;
        }
    }
}
