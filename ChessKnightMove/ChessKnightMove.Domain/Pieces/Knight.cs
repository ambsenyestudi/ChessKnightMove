using System;
using System.Collections.Generic;

namespace ChessKnightMove.Domain.Pieces
{
    public class Knight
    {
        private string position;

        public Knight(string position)
        {
            this.position = position;
        }

        public List<string> ListPossibleMovements()
        {
            return new List<string>();
        }
    }
}
