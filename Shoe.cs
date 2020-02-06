using System;
using System.Collections.Generic;
using System.Linq;

namespace Blackjack
{

    public class Shoe
    {

        public List<BlackjackCard> Cards { get; }
        public int NumberOfDecks { get; }

        public Shoe(int numberOfDecks)
        {
            this.NumberOfDecks = numberOfDecks;
            this.Cards = new List<BlackjackCard>();
            this.createShoe();
            this.shuffle();
        }

        private void createShoe()
        {
            for (int deck = 0; deck < this.NumberOfDecks; deck++)
            {
                Deck newDeck = new Deck();
                foreach (BlackjackCard card in newDeck.Cards)
                {
                    Cards.Add(card);
                }
            }
        }

        private void shuffle()
        {
            int cardCount = this.Cards.Count;
            Random r = new Random();
            for (int idx = 0; idx < cardCount; idx++)
            {
                int swapWithIdx = r.Next(cardCount - idx - 1);
                this.swap(idx, swapWithIdx);
            }
        }

        private void swap(int i, int j)
        {
            BlackjackCard temp = Cards[i];
            Cards[i] = Cards[j];
            Cards[j] = Cards[i];
        }

        //Get the next card from the shoe
        public BlackjackCard dealCard()
        {
            if (Cards.Count == 0)
            {
                createShoe();
            }
            BlackjackCard returnCard = Cards[0];
            Cards.RemoveAt(0);
            return returnCard;
        }

    }

}