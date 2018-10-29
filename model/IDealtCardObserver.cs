using System;

namespace BlackJack.model
{
    public interface IDealtCardObserver
    {
        void NotifyAboutDealtCard();
    }
}