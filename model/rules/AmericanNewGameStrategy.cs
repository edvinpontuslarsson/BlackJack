using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlackJack.model.rules
{
    class AmericanNewGameStrategy : INewGameStrategy
    {
        public bool NewGame(Deck a_deck, Dealer a_dealer, Player a_player)
        {
            Card c;

            c = a_deck.GetCard();
            c.Show(true);
            a_player.AddCardToHand(c);

            c = a_deck.GetCard();
            c.Show(true);
            a_dealer.AddCardToHand(c);

            c = a_deck.GetCard();
            c.Show(true);
            a_player.AddCardToHand(c);

            c = a_deck.GetCard();
            c.Show(false);
            a_dealer.AddCardToHand(c);

            return true;
        }
    }
}
