using System;
using Xunit;

namespace Bowling.Tests
{
    public class TestBowlingGame
    {
        [Fact]
        public void AllStrikes()
        {
            var input = "X X X X X X X X X X X X";
            var bowlingGame = new BowlingGame(input);
            var score = bowlingGame.Score();

            Assert.Equal(300, score);
        }

        [Fact]
        public void AllSpare()
        {
            var input = "5/ 5/ 5/ 5/ 5/ 5/ 5/ 5/ 5/ 5/5";
            var bowlingGame = new BowlingGame(input);
            var score = bowlingGame.Score();

            Assert.Equal(150, score);
        }

        [Fact]
        public void HitAndMiss()
        {
            var input = "9- 9- 9- 9- 9- 9- 9- 9- 9- 9-";
            var bowlingGame = new BowlingGame(input);
            var score = bowlingGame.Score();

            Assert.Equal(90, score);
        }
    }
}
