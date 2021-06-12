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

        private List<Postition> FigureVerticalMoves()
        {
            var deltaColumn = new int[] { -shorMove, shorMove };
            var deltaRow = new int[] { -longMove, longMove };
            return FigurePositions(deltaColumn, deltaRow)
                .Where(x => x != Postition.Empty)
                .ToList();
        }

        private List<Postition> FigureHorizontalMoves()
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
                    var delta = new PositionDelta(currDeltaColumn, currDeltaRow);
                    var currPostion = position.Move(delta);
                    resultList.Add(currPostion);
                }
                
            }
            return resultList;
        }
    }
}
