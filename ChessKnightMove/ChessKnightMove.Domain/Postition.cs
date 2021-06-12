namespace ChessKnightMove.Domain
{
    public record Postition
    {
        public const char MIN_COLUMN = 'A';
        public const char MAX_COLUMN = 'H';
        public const int MIN_ROW = 1;
        public const int MAX_ROW = 8;

        public static Postition Empty { get; } = new Postition(' ', 0);

        public char Column { get; }
        public int Row { get; }

        private Postition(char column, int row) =>
            (Column, Row) = (column, row);

        public Postition Move(int deltaColumn, int deltaRow)
        {
            if(!Board.TryMove(Column, deltaColumn, out char column))
            {
                return Empty;
            }
            return Create(column, Row + deltaRow);
        }

        public static Postition Create(char column, int row)
        {
            if(!Board.IsInBounds(column, row))
            {
                return Empty;
            }
            return new Postition(column, row);
        }
        public static Postition FromString(string value)
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
