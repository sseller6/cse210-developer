using System;
using System.Collections.Generic;
using System.Linq;

namespace Unit02.Game
{

    public class Deck
    {

        private List<int> _cards;

        //  Constructor
        public Deck()
        {
            var random = new Random();

            _cards = Enumerable.Range(1, 13).OrderBy(card => random.Next()).ToList();

        }


        public int Draw()
        {
            var card = _cards[0];
            _cards.RemoveAt(0);
            return card;
            
        }





    }
}