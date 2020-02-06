using System.Collections.Generic;

namespace Blackjack
{

    public class Player : BasePlayer
    {

        public int Bet { get; }
        public int TotalCash { get; }

        public Player()
        {
            this.hands = new List<Hand>();
        }

    }

}