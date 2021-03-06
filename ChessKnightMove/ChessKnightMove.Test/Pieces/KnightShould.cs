using ChessKnightMove.Domain;
using ChessKnightMove.Domain.Pieces;
using Xunit;

namespace ChessKnightMove.Test.Pieces
{
    public class KnightShould
    {
        [Theory]
        [InlineData("A1", "B3")]
        [InlineData("A1", "C2")]
        public void Contain_move_when_at_corner(string knighPositionRaw, string expected)
        {
            var knighPosition = Position.FromString(knighPositionRaw);
            var exptectedPosition = Position.FromString(expected);
            var sut = new Knight(knighPosition);
            var postionList = sut.ListPossibleMovements();
            Assert.Contains(exptectedPosition, postionList);
        }
        [Theory]
        [InlineData("C2", "A1")]
        [InlineData("C2", "A3")]
        [InlineData("C2", "E1")]
        [InlineData("C2", "E3")]
        [InlineData("C2", "B4")]
        [InlineData("C2", "D4")]
        public void Contain_move_when_at_second_row(string knighPositionRaw, string expected)
        {
            var knighPosition = Position.FromString(knighPositionRaw);
            var exptectedPosition = Position.FromString(expected);
            var sut = new Knight(knighPosition);
            var postionList = sut.ListPossibleMovements();
            Assert.Contains(exptectedPosition, postionList);
        }

        [Theory]
        [InlineData("D5", "C3")]
        [InlineData("D5", "E3")]
        [InlineData("D5", "B4")]
        [InlineData("D5", "F4")]
        [InlineData("D5", "B6")]
        [InlineData("D5", "F6")]
        [InlineData("D5", "C7")]
        [InlineData("D5", "E7")]
        public void Contain_move_all_possible_moves (string knighPositionRaw, string expected)
        {
            var knighPosition = Position.FromString(knighPositionRaw);
            var exptectedPosition = Position.FromString(expected);
            var sut = new Knight(knighPosition);
            var postionList = sut.ListPossibleMovements();
            Assert.Contains(exptectedPosition, postionList);
        }
    }
}
