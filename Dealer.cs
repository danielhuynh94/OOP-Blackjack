namespace Blackjack
{

    public class Dealer
    {

        public Hand hand { get; }

        public int getTotalScore()
        {
            return hand.resolveScore();
        }

    }

}