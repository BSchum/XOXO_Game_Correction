using System;
using System.Collections.Generic;
using System.Text;

namespace XOXO_Game_Correction
{
    public class RandomPlacementBehaviour : IPlacementBehaviour
    {
        Random _random = new Random();
        public Placement Place(Board board)
        {
            return new Placement {
                x = _random.Next(0, board.GetLinesLength()),
                y = _random.Next(0, board.GetColumnLength())
            };
        }
    }
}
