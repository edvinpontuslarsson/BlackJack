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
            for (int x = 1; x <= 4; x++)
            {
                Player person = x % 2 == 1 ? a_player : a_dealer;

                bool shouldShowCard = x < 4 ? true : false;

                a_dealer.DealCardTo(person, shouldShowCard);
            }

            return true;
        }
    }
}
