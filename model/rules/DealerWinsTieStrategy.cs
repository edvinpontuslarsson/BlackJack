using System;

namespace BlackJack.model.rules
{
    // class created by Edvin Larsson
    class DealerWinsTieStrategy : IPickWinnerStrategy
    {
        private const int MaxScore = 21;

        public bool IsDealerWinner(
            model.Dealer dealer, model.Player player
        ) =>
            IsBusted(player) ||
            !IsBusted(dealer) && dealer.CalcScore() >= player.CalcScore();

        private bool IsBusted(model.Player person) => 
            person.CalcScore() > MaxScore;
    }
}