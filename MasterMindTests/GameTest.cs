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
            Given.gameWithSolution("RGBO").WhenGuess("RGBO").ThenAnswerIs("Won!");
        }

        [Test]
        public void AllWrong()
        {
            Given.gameWithSolution("PPPP").WhenGuess("RGBO").ThenAnswerIs("");
        }
    }

    public class Given
    {
        public static GameUnderTest gameWithSolution(string solution)
        {
            return new(solution);
        }
    }

    public class GameUnderTest
    {
        private string _answerFromGuess;
        private readonly Game _game;

        public GameUnderTest(string solution)
        {
            _game = new Game(solution);
        }

        public GameUnderTest WhenGuess(string guess)
        {
            _answerFromGuess = _game.Guess(guess);
            return this;
        }

        public void ThenAnswerIs(string expectedAnswer)
        {
            Assert.That(_answerFromGuess, Is.EqualTo(expectedAnswer));
        }
    }
}