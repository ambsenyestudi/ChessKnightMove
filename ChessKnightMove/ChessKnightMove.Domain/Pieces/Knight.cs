using System;
using System.Collections.Generic;
using System.Linq;

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
            return GetHorizontalPostitions();
            /*
            if (position == Postition.FromString("C2"))
            {
                return GetLeftPostitions();
            }
            return new List<Postition>() { Postition.FromString("C2") };
            */
        }

        private List<Postition> GetHorizontalPostitions()
        {
            var deltaColumn = new int[] { -longMove, longMove };
            var deltaRow = new int[] { -shorMove, shorMove };
            return FigurePositions(deltaColumn, deltaRow)
                .Where(x=> x != Postition.Empty)
                .ToList();
        }

        private List<Postition> FigurePositions(int[] deltaColumns, int[] deltaRows)
        {
            var resultList = new List<Postition>();
            for (int y = 0; y < deltaRows.Length; y++)
            {
                var currDeltaRow = deltaRows[y];
                for (int x = 0; x < deltaColumns.Length; x++)
                {
                    var currDeltaColumn = deltaColumns[x];
                    var currPostion = position.Move(currDeltaColumn, currDeltaRow);
                    resultList.Add(currPostion);
                }
                
            }
            return resultList;
        }
    }
}
