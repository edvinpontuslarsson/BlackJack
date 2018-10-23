using System;

namespace BlackJack.model.rules
{
    // class created by Edvin Larsson
    class PlayerWinsTieStrategy : CommonPickWinnerStrategy, IPickWinnerStrategy
    {
        /// <summary>
        /// Unless player is busted,
        /// dealer has to be not busted and have a higher score to win,
        /// if tie, player wins
        /// </summary>
        public bool IsDealerWinner(
            model.Dealer dealer, model.Player player
        ) =>
            IsBusted(player) ||
            !IsBusted(dealer) && dealer.CalcScore() > player.CalcScore();
    }
}