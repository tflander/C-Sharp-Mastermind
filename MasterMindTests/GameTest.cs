using System;
using MasterMind;
using NUnit.Framework;

namespace MasterMindTests
{
    public class GameTest
    {
        [Test]
        public void Win()
        {
            Given.GameWithSolution("RGBO").WhenGuess("RGBO").ThenAnswerIs("Won!");
        }

        [Test]
        public void AllWrong()
        {
            Given.GameWithSolution("PPPP").WhenGuess("RGBO").ThenAnswerIs("");
        }
        
        [Test]
        public void RightColorAndPosition()
        {
            Given.GameWithSolution("RGBO").WhenGuess("PPPO").ThenAnswerIs("B");
        }

        [Test]
        public void RightColorAndWrongPosition()
        {
            Given.GameWithSolution("RGBO").WhenGuess("OPPP").ThenAnswerIs("W");
        }

        [Test]
        public void TwoRightColorAndWrongPosition()
        {
            Given.GameWithSolution("RGOO").WhenGuess("OOPP").ThenAnswerIs("WW");
        }
        
        [Test]
        public void TwoBlackTwoWhite()
        {
            Given.GameWithSolution("RGBO").WhenGuess("GRBO").ThenAnswerIs("BBWW");
        }

        [Test]
        public void FailNewGameWithInvalidColor()
        {
            Assert.Throws(Is.TypeOf<ArgumentException>()
                    .And.Message.EqualTo("Invalid color A.  valid colors are (R)ed, (B)lue, (G)reen, (O)range, (P)urple, (Y)ellow"),
                delegate { new Game("ABCD"); });
        }
        
    }

    public static class Given
    {
        public static GameUnderTest GameWithSolution(string solution)
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