using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlackJack.model.rules
{
    class InternationalNewGameStrategy : INewGameStrategy
    {

        public bool NewGame(Deck a_deck, Dealer a_dealer, Player a_player)
        {
            for (int x = 1; x <= 3; x++)
            {
                Player person = x % 2 == 0 ? a_dealer : a_player;
                a_dealer.DealCardTo(person, true);
            }

            return true;
        }
    }
}
