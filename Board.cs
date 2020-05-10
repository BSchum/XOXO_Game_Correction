using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XOXO_Game_Correction
{
    public class Board
    {
        Case[,] _innerBoard;

        public Board(int length)
        {
            _innerBoard = new Case[length, length];
        }
        public struct Result
        {
            public int XCount;
            public int OCount;
        }

        public Result GetResult()
        {
            return new Result()
            {
                XCount = _innerBoard.Cast<Case>().Count(c => c.CaseType == CaseType.X),
                OCount = _innerBoard.Cast<Case>().Count(c => c.CaseType == CaseType.O)
            };
        }
        public Case this[int x, int y]
        {
            get
            {
                return _innerBoard[x, y];
            }
            set
            {
                _innerBoard[x, y] = value;
            }
        }

        public bool IsPlacementValid(Placement placement)
        {
            return placement.x > 0 && placement.x <= GetLinesLength() && placement.y > 0 && placement.y <= GetColumnLength();
        }
        public int GetLinesLength()
        {
            return _innerBoard.GetLength(0);
        }

        public int GetColumnLength()
        {
            return _innerBoard.GetLength(1);
        }
        public bool IsComplete()
        {
            return !_innerBoard.Cast<Case>().Any(c => c.CaseType == CaseType.Empty);
        }
    }
}
