namespace ChessKnightMove.Domain
{
    public struct PositionDelta
    {
        public int X { get; }
        public int Y { get; }
        public PositionDelta(int x, int y)
        {
            X = x;
            Y = y;
        }

    }
}
