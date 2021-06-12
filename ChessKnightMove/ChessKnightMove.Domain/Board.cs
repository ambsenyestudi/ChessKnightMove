namespace ChessKnightMove.Domain
{
    public class Board
    {
        public const char MIN_COLUMN = 'A';
        public const char MAX_COLUMN = 'H';
        public const int MIN_ROW = 1;
        public const int MAX_ROW = 8;

        public static bool IsInBounds(char column, int row) =>
            !IsOutOfBounds(column) &&
            !IsOutOfBounds(row);

        public static bool IsOutOfBounds(char column) =>
            column < MIN_COLUMN ||
            column > MAX_COLUMN;
        public static bool IsOutOfBounds(int row) =>
            row < MIN_ROW ||
                row > MAX_ROW;

        public static bool TryMove(char originalColumn, int positions, out char column)
        {
            var result = originalColumn + positions;
            column = (char)result;
            return !IsOutOfBounds(column);
        }
    }
}
