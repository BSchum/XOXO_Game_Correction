using System;
using System.Collections.Generic;
using System.Text;

namespace XOXO_Game_Correction
{
    public class ConsoleInputPlacementBehaviour : IPlacementBehaviour
    {
        public Placement Place(Board board)
        {
            Placement placement = new Placement();

            bool isInputInteger = false;
            do
            {

                Console.WriteLine("Choisissez un X:");
                isInputInteger = int.TryParse(Console.ReadLine(), out placement.x);
            }
            while (!isInputInteger);

            isInputInteger = false;
            do
            {

                Console.WriteLine("Choisissez un Y:");
                isInputInteger = int.TryParse(Console.ReadLine(), out placement.y);
            }
            while (!isInputInteger);

            return placement;
        }
    }
}
