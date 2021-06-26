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
            var markedSolution = MarkRightColorAndPosition(guess);
            return new String('B', CountMarks(markedSolution));
        }

        private int CountMarks(string markedGuess)
        {
            var count = 0;
            foreach (var c in markedGuess)
            {
                if (c == 'X') ++count;
            }

            return count;
        }

        private string MarkRightColorAndPosition(string guess)
        {
            var marked = new StringBuilder(_solution);

            for (var i = 0; i < _solution.Length; ++i)
            {
                if (_solution[i] == guess[i])
                {
                    marked[i] = 'X';
                }
            }

            return marked.ToString();
        }
    }
}