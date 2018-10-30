using System;

namespace BlackJack.model.rules
{
    abstract class CommonPickWinnerStrategy
    {
        private const int MaxScore = 21;

        protected bool IsBusted(model.Player person) => 
            person.CalcScore() > MaxScore;
    }
}