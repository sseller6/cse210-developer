using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit03
{
    internal class Word
    {
        // Declare Variables for Word Class

        private string _word;

        private string _guesses;

        public Word()
        {
            _word = "crocs";

            _guesses = "";

        }

        public void DisplayGuesses()
        {
            // loop through word, display character when character is in guesses. else display _

            for (int i = 0; i < _word.Length; i++)
            {
                if (_guesses.Contains(_word[i]))
                {
                    Console.Write(_word[i]);
                }
                else
                {
                    Console.Write("_ ");
                }
            }
            Console.WriteLine();
        }

        public void AddToGuesses(char guess)
        {
            _guesses += guess;
        }
        
        // A method for checking for underscores.
        public bool CheckForUnderscores()
        {

            for (int i = 0; i < _word.Length; i++)
            {
                if (!_guesses.Contains(_word[i]))
                {
                    return true;
                }
            }
            return false;
        }
            // foreach (char letter in _word)
            // {
            //     if (letter == '_')
            //     {
            //         return true;
            //     }
            // }
            // return false;


        public bool LetterInWord(char guess)
        {
            foreach (char letter in _word)
            {
                if (guess == letter)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
