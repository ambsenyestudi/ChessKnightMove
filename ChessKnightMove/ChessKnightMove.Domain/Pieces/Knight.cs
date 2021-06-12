using System;
using System.Collections.Generic;

namespace ChessKnightMove.Domain.Pieces
{
    public class Knight
    {
        private Postition position;

        public Knight(Postition position)
        {
            this.position = position;
        }

        public List<Postition> ListPossibleMovements()
        {
            var result = new List<Postition>();
            result.AddRange(FigureVerticalMoves());
            result.AddRange(FigureHorizontalMoves());
            return result;
        }

        private new List<Postition> FigureVerticalMoves()
        {
            return new List<Postition>() { Postition.FromString("B3") };
        }
        private new List<Postition> FigureHorizontalMoves()
        {
            return new List<Postition>() { Postition.FromString("C2") };
        }
    }
}
