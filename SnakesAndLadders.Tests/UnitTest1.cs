using Xunit;

namespace SnakesAndLadders.Tests
{
    public class GameTests
    {
        [Fact]
        public void PlayerClimbsLadder()
        {
            var ladders = new System.Collections.Generic.Dictionary<int, int> { { 3, 22 } };
            var board = new Board(new System.Collections.Generic.Dictionary<int, int>(), ladders);
            var player = new Player("Test");

            player.Move(3, board);

            Assert.Equal(22, player.Position);
        }

        [Fact]
        public void PlayerSlidesDownSnake()
        {
            var snakes = new System.Collections.Generic.Dictionary<int, int> { { 17, 7 } };
            var board = new Board(snakes, new System.Collections.Generic.Dictionary<int, int>());
            var player = new Player("Test");

            player.Move(17, board);

            Assert.Equal(7, player.Position);
        }

        [Fact]
        public void PlayerWinsAt100()
        {
            var board = new Board(new System.Collections.Generic.Dictionary<int, int>(), new System.Collections.Generic.Dictionary<int, int>());
            var player = new Player("Test");

            player.Move(100, board);

            Assert.Equal(100, player.Position);
        }
    }
}
