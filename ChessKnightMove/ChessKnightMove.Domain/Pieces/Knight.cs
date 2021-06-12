using System.Collections.Generic;
using System.Linq;

namespace ChessKnightMove.Domain.Pieces
{
    public class Knight
    {
        private Position position;

        public Knight(Position position)
        {
            this.position = position;
        }

        public List<Position> ListPossibleMovements() =>
            FigureVerticalMoves()
                .Concat(FigureHorizontalMoves())
                .Where(pos => pos != Position.Empty)
                .ToList();

        private IEnumerable<Position> FigureVerticalMoves() =>
            new List<KnightMoves>{
                KnightMoves.ForwardLeft,
                KnightMoves.ForwardRight,
                KnightMoves.BackwardLeft,
                KnightMoves.BackwardRight,
            }.Select(x => x.GetNext(position));
        private IEnumerable<Position> FigureHorizontalMoves() =>
            new List<KnightMoves>{
                KnightMoves.RightForward,
                KnightMoves.LeftForward,
                KnightMoves.RightBackward,
                KnightMoves.LeftBackward,
            }.Select(x => x.GetNext(position));

        
    }
}
