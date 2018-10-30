using System;

namespace BlackJack.model.rules
{
    class DealerWinsTieStrategy : CommonPickWinnerStrategy, IPickWinnerStrategy
    {
        public bool IsDealerWinner(
            model.Dealer dealer, model.Player player
        ) =>
            IsBusted(player) ||
            !IsBusted(dealer) && dealer.CalcScore() >= player.CalcScore();
    }
}