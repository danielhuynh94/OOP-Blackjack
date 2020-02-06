using System.Collections.Generic;

namespace Blackjack
{
    public class Hand
    {

        public List<BlackjackCard> Cards { get; }

        private List<int> getScores()
        {

            List<int> totals = new List<int>();
            totals.Add(0);

            foreach (BlackjackCard card in Cards)
            {
                List<int> newTotals = new List<int>();
                foreach (int score in totals)
                {
                    newTotals.Add(card.FaceValue + score);
                    if (card.FaceValue == 1)
                    {
                        newTotals.Add(11 + score);
                    }
                }
                totals = newTotals;
            }

            return totals;

        }

        public Hand(BlackjackCard c1, BlackjackCard c2)
        {
            this.Cards = new List<BlackjackCard>();
            this.Cards.Add(c1);
            this.Cards.Add(c2);
        }

        public void addCard(BlackjackCard card)
        {
            Cards.Add(card);
        }

        //Get highest score which is less than or equal to 21
        public int resolveScore()
        {
            List<int> scores = getScores();
            int bestScore = 0;
            foreach (int score in scores)
            {
                if (score <= 21 && score > bestScore)
                {
                    bestScore = score;
                }
            }
            return bestScore;
        }

    }
}