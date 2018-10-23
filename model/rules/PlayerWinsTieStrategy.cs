using System;

namespace BlackJack.model.rules
{
    // class created by Edvin Larsson
    class PlayerWinsTieStrategy : IPickWinnerStrategy
    {
        private const int MaxScore = 21;

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

        private bool IsBusted(model.Player person) => 
            person.CalcScore() > MaxScore;
    }
}