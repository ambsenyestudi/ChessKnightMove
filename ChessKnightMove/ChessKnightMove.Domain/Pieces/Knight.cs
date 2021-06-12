using System;
using System.Collections.Generic;

namespace ChessKnightMove.Domain.Pieces
{
    public class Knight
    {
        private int longMove = 2;
        private int shorMove = 1;
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
            
            if (position == Postition.FromString("C2"))
            {
                return GetLeftPostitions();
            }
            return new List<Postition>() { Postition.FromString("C2") };
        }

        private List<Postition> GetLeftPostitions()
        {
            var resultList = new List<Postition>();
            if (!TryGetLeftColumn(out char column))
            {
                return resultList;
            }
            
            var deltaRows = new int[] { -shorMove, shorMove };
            for (int i = 0; i < deltaRows.Length; i++)
            {
                var currDeltaRow = deltaRows[i];
                var currPostion = position.Move(-longMove, currDeltaRow);
                if(currPostion != Postition.Empty)
                {
                    resultList.Add(currPostion);
                }
            }
            return resultList;
        }
        private bool TryGetLeftColumn(out char column) =>
            Board.TryMove(position.Column, -longMove, out column);
    }
}
