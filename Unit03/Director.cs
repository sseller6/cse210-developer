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
        private char _guess;
        private Word _word = new Word();
        private Jumper _jumper = new Jumper();

        public Director()
        {
            _isPlaying = true;

        }

        public void StartGame()
        {
            //This is a do while loop.
            _jumper.DisplayJumper();

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
            _guess = char.Parse(Console.ReadLine());
           
        }

        public void DoUpdates()
        {
            _word.AddToGuesses(_guess);

            // update the jumper
            // code end-game conditions.
        }

        public void DoOutputs()
        {
            _word.DisplayGuesses();

            // print updated jumper by calling DisplayJumper
            _jumper.DisplayJumper();

        }
    }
}
