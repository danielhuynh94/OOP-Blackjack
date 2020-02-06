namespace Blackjack
{

    public enum SUIT
    {
        HEART, SPADE, CLUB, DIAMOND
    }

    public class Card
    {
        public SUIT Suit { get; }
        public int FaceValue { get; }

        public Card(SUIT suit, int faceValue)
        {
            this.Suit = suit;
            this.FaceValue = faceValue;
        }
    }

}