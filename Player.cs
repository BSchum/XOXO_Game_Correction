using System;
using System.Collections.Generic;
using System.Text;

namespace XOXO_Game_Correction
{
    public class Player
    {
        IPlacementBehaviour _placementBehaviour;
        Piece _currentPiece;
        public Player(Piece piece, IPlacementBehaviour placementBehaviour)
        {
            _currentPiece = piece;
            _placementBehaviour = placementBehaviour;
        }

        public void Play(Board board)
        {
            bool hasPlayed;
            do
            {
                Placement placement = _placementBehaviour.Place(board);
                if (!board.IsPlacementValid(placement))
                {
                    hasPlayed = false;
                    continue;
                }

                hasPlayed = board[placement.x, placement.y].SetCase(_currentPiece);

                if (hasPlayed == false)
                    continue;

                if(_currentPiece == Piece.X)
                {
                    placement.x = placement.x += 2;
                    
                    if (!board.IsPlacementValid(placement))
                        return;
                    board[placement.x, placement.y].SetCase(_currentPiece);
                }
                else if(_currentPiece == Piece.O)
                {
                    placement.y = placement.y += 2;
                    if (!board.IsPlacementValid(placement))
                        return;
                    board[placement.x, placement.y].SetCase(_currentPiece);
                }

            } while (!hasPlayed);
        }
    }
}
