using System;
using System.Collections.Generic;
using System.Text;

namespace XOXO_Game_Correction
{
    public class Game
    {
        Board _board { get; set; }
        Player _playerOne;
        Player _playerTwo;
        IDisplayer _displayer;
        int _currentRound;

        public Game(int length, Player playerOne, Player playerTwo, IDisplayer displayer)
        {
            _board = new Board(length);
            this._playerOne = playerOne;
            this._playerTwo = playerTwo;
            this._displayer = displayer;
            for(int x = 0; x < _board.GetLinesLength(); x++){
                for(int y = 0; y < _board.GetColumnLength(); y++)
                {
                    _board[x, y] = new Case()
                    {
                        CaseType = CaseType.Empty,
                        X = x,
                        Y = y
                    };
                }
            }

        }

        public void GameLogic()
        {
            while(!_board.IsComplete())
            {
                _currentRound++;
                _playerOne.Play(_board);
                _playerTwo.Play(_board);
                _displayer.Display(_board, _currentRound);

                Console.ReadLine();
            }
        }
    }
}
