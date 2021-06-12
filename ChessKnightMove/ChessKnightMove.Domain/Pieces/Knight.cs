using System.Collections.Generic;
using System.Linq;

namespace ChessKnightMove.Domain.Pieces
{
    public class Knight
    {
        private const int TWO_SQUARE_MOVE = 2;
        private const int ONE_SQUARE_MOVE = 1;
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
            }.Select(x => x.GetNext(position))
            .Where(pos => pos != Position.Empty);
        private IEnumerable<Position> FigureHorizontalMoves() =>
            FigurePositionsFromDelta(GetHorizontalMoves()); 

        private IEnumerable<Position> FigurePositionsFromDelta(List<PositionDelta> positionDeltas) =>
            positionDeltas.Select(del => position.Move(del));

        /// <summary>
        /// Generates moves for 2 squares horizontal and 1 vertical
        /// </summary>
        private List<PositionDelta> GetHorizontalMoves() =>
            FigureMoves(TWO_SQUARE_MOVE, ONE_SQUARE_MOVE);

        /// <summary>
        /// Generates moves for 1 squares horizontal and 2 vertical
        /// </summary>
        private List<PositionDelta> GetVertialMoves() =>
            FigureMoves(ONE_SQUARE_MOVE, TWO_SQUARE_MOVE);

        private List<PositionDelta> FigureMoves(int xRange, int yRange) =>
            new List<PositionDelta>()
            {
                new PositionDelta(-xRange, -yRange),
                new PositionDelta(xRange, -yRange),
                new PositionDelta(-xRange, yRange),
                new PositionDelta(xRange, yRange),
            };
    }
}
