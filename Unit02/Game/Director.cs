using System;
using System.Collections.Generic;


namespace Unit02
{
    /// <summary>
    /// A person who directs the game. 
    ///
    /// The responsibility of a Director is to control the sequence of play.
    /// </summary>
    public class Director
    {
        private Deck _deck;

        private int _score;

        private bool _continuePlaying;
        public Director()
        {
            _deck = new Deck();
            _score = 300;
            _continuePlaying = true;
        }

        private static char GetValidInput(string allowedCharacters)
        {
            while (true)
            {
                var input = Console.ReadLine().Trim();
                foreach (char c in allowedCharacters)
                {
                    if (input == c.ToString())
                    {
                        return c;
                    }

                }
                Console.WriteLine("Please re-enter your choice. ");
            }


        }

        public void StartGame()
        {
            while (_continuePlaying & _deck.IsNextRoundAvailable())
            {
                var firstCard = _deck.Draw();
                Console.WriteLine($"The card is: {firstCard}");
                Console.Write("Higher or lower? [h/l] ");
                var guess = GetValidInput("hl");

                var secondCard = _deck.Draw();
                Console.WriteLine($"The next card is: {secondCard}");

                // If the guess is correct
                if (
                    (guess == 'l' & firstCard > secondCard) ||
                    (guess == 'h' & secondCard > firstCard) )
                {
                    _score += 100;
                }

                // If the guess is not correct
                else
                {
                    _score -= 75;
                }

                // Print off score
                Console.WriteLine($"Your score is: {_score}");

                if (_deck.IsNextRoundAvailable())
                {
                    Console.WriteLine("Play again? [y/n] ");
                    var @continue = GetValidInput("yn");

                    if (@continue == 'n')
                        _continuePlaying = false;
                }

            }

            Console.WriteLine("Thanks for playing! ");
        }
    }
 }
 


