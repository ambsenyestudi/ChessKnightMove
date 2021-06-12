namespace ChessKnightMove.Domain
{
    public record Position
    {
        public const char MIN_COLUMN = 'A';
        public const char MAX_COLUMN = 'H';
        public const int MIN_ROW = 1;
        public const int MAX_ROW = 8;

        public static Position Empty { get; } = new Position(' ', 0);

        public char Column { get; }
        public int Row { get; }

        private Position(char column, int row) =>
            (Column, Row) = (column, row);

        public Position Move(PositionDelta delta)
        {
            if(!Board.TryMove(Column, delta.X, out char column))
            {
                return Empty;
            }
            return Create(column, Row + delta.Y);
        }

        public static Position Create(char column, int row)
        {
            if(!Board.IsInBounds(column, row))
            {
                return Empty;
            }
            return new Position(column, row);
        }
        public static Position FromString(string value)
        {
            if (IsValidPostions(value))
            {
                return Empty;
            }
            var column = value[0];
            var row = int.Parse(value.Substring(1));
            return Create(column, row);
        }

        private static bool IsValidPostions(string value)
        {
            return string.IsNullOrWhiteSpace(value) &&
                value.Length == 2 &&
                char.IsLetter(value[0]) &&
                char.IsDigit(value[1]);
        }
    }
}
