using ChessKnightMove.Domain.Pieces;
using Xunit;

namespace ChessKnightMove.Test.Pieces
{
    public class KnightShould
    {
        [Fact]
        public void Contain_move()
        {
            var sut = new Knight("A1");
            var postionList = sut.ListPossibleMovements();
            Assert.Contains("B3", postionList);
        }
    }
}
