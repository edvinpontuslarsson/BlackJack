using System;

namespace BlackJack.model.rules
{
    interface IPickWinnerStrategy
    {
        bool IsDealerWinner(
            model.Dealer dealer, model.Player player
        );
    }
}