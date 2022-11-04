using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit03
{
    internal class Director
    {
        private bool _isPlaying;

        public string guess;

        public Director()
        {
            _isPlaying = true;

        }

        public void StartGame()
        {
            while (_isPlaying)
            {
                GetInputs();
                DoUpdates();
                DoOutputs();
            }
        }

        public void GetInputs()
        {

            Console.WriteLine("Guess a Letter [a-z]: ");
            guess = Console.ReadLine();

        }

        public void DoUpdates()
        {
            Word.AddToGuesses(guess);
        }

        public void DoOutputs()
        {
            Word.DisplayGuesses();

        }
    }
}
