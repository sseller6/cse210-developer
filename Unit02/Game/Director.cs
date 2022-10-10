using System;
using System.Collections.Generic;


namespace Unit02.Game
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

        public void StartGame()
        {

        }
    }
 }
 


