using System;
using System.Collections.Generic;

namespace Blackjack
{

    public class Deck
    {
        public List<BlackjackCard> Cards { get; }
        public DateTime CreationDate { get; }

        public Deck()
        {
            //Set the creation date
            this.CreationDate = DateTime.Now;
            //Add the cards
            this.Cards = new List<BlackjackCard>();
            for (int value = 1; value <= 13; value++)
            {
                foreach (SUIT suit in Enum.GetValues(typeof(SUIT)))
                {
                    this.Cards.Add(new BlackjackCard(suit, value));
                }
            }

        }

    }

}