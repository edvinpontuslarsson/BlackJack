using System;
using System.Collections.Generic;

namespace BlackJack.controller
{
    class Observer : model.IObserver
    {
        private view.IView m_view;

        public Observer(view.IView a_view)
        {
            m_view = a_view;
        }

        public void NotifyAboutDealtCard()
        {
            m_view.HandleDealtCard();
        }
    }
}