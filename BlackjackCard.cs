namespace Blackjack
{

    public class BlackjackCard : Card
    {
        public int GameValue { get; }

        public BlackjackCard(SUIT suit, int faceValue) : base(suit, faceValue)
        {
            this.GameValue = faceValue;
            if (this.GameValue > 10) { this.GameValue = 10; }
        }

    }

}