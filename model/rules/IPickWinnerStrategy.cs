using System;

namespace BlackJack.model.rules
{
    // Interface created by Edvin Larsson
    interface IPickWinnerStrategy
    {
        bool IsDealerWinner(
            model.Dealer dealer, model.Player player
        );
    }
}