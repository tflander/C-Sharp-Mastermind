using System;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MasterMind
{
    public class Game
    {
        private readonly string _solution;

        public Game(string solution)
        {
            _solution = solution;
        }

        public string Guess(string guess)
        {
            if (guess.Equals(_solution))
                return "Won!";
            var (markedSolution, markedGuess) = MarkRightColorAndPosition(guess);
            var blacks = new String('B', CountMarks(markedSolution, 'X'));
            var whites = new String('W', CountMarks(markedSolution, 'Z'));
            return blacks + whites;
        }

        private int CountMarks(string markedGuess, char charToMatch)
        {
            var count = 0;
            foreach (var c in markedGuess)
            {
                if (c == charToMatch) ++count;
            }

            return count;
        }

        private (string, string) MarkRightColorAndPosition(string guess)
        {
            var markedSolution = new StringBuilder(_solution);
            var markedGuess = new StringBuilder(guess);

            for (var i = 0; i < _solution.Length; ++i)
            {
                if (_solution[i] == guess[i])
                {
                    markedSolution[i] = 'X';
                    markedGuess[i] = 'X';
                }
            }

            return (markedSolution.ToString(), markedGuess.ToString());
        }
    }
}