using System;
using System.Collections.Generic;

namespace Blackjack
{

    public enum AccountStatus
    {
        Active,
        Closed,
        Canceled,
        Blacklisted,
        None
    }

    public abstract class BasePlayer
    {

        public string ID { get; }
        public string Password { get; }
        public double Balance { get; }
        public AccountStatus status { get; }
        public List<Hand> hands { get; set; }

        public bool resetPassword()
        {
            //database stuff
            return true;
        }

        public void addHand(Hand hand)
        {
            hands.Add(hand);
        }

        public void removeHand(Hand hand)
        {
            hands.Remove(hand);
        }

    }
}