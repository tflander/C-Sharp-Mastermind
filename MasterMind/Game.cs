using System;

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
            return "";
        }
    }
}