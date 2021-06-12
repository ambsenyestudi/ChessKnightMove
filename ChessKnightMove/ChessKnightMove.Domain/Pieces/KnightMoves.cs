namespace ChessKnightMove.Domain.Pieces
{
    public class KnightMoves
    {
        private const int TWO_SQUARE_MOVE = 2;
        private const int ONE_SQUARE_MOVE = 1;
        private readonly PositionDelta delta;

        public static KnightMoves ForwardLeft { get; } = 
            new KnightMoves(new PositionDelta(-ONE_SQUARE_MOVE, TWO_SQUARE_MOVE));
        public static KnightMoves ForwardRight { get; } =
            new KnightMoves(new PositionDelta(ONE_SQUARE_MOVE, TWO_SQUARE_MOVE));

        public static KnightMoves BackwardLeft { get; } =
            new KnightMoves(new PositionDelta(-ONE_SQUARE_MOVE, -TWO_SQUARE_MOVE));
        public static KnightMoves BackwardRight { get; } =
            new KnightMoves(new PositionDelta(ONE_SQUARE_MOVE, -TWO_SQUARE_MOVE));


        private KnightMoves(PositionDelta delta)
        {
            this.delta = delta;
        }
        public Position GetNext(Position origin) =>
            origin.Move(delta);
        
    }
}
