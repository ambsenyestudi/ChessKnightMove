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
        public void Contain_move(string knighPositionRaw, string expected)
        {
            var knighPosition = Postition.FromString(knighPositionRaw);
            var exptectedPosition = Postition.FromString(expected);
            var sut = new Knight(knighPosition);
            var postionList = sut.ListPossibleMovements();
            Assert.Contains(exptectedPosition, postionList);
        }
    }
}
