using System;

namespace Blackjack
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();
            Dealer dealer = new Dealer();
            Game game = new Game(player, dealer);
            // game.start();
        }
    }
}
