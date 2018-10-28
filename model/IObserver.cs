using System;

namespace BlackJack.model
{
    public interface IObserver
    {
        void NotifyAboutDealtCard();
    }
}