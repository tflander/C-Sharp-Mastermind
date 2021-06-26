using System.IO.Compression;
using MasterMind;
using NUnit.Framework;

namespace MasterMindTests
{
    public class GameTest
    {
        [Test]
        public void Win()
        {
            var game = new Game("RGBO");
            Assert.That(game.Guess("RGBO"), Is.EqualTo("Won!"));
            // Given.GameWithSolution("RGBO").WhenGuess("RGBO").ThenAnswerIs("Won!");
        }

        [Test]
        public void AllWrong()
        {
            var game = new Game("PPPP");
            Assert.That(game.Guess("RGBO"), Is.EqualTo(""));
        }
    }
}