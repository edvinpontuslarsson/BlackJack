using System;
using System.Collections.Generic;

namespace BlackJack.controller
{
    class Observer : model.IObserver
    {
        private model.Game m_game;
        private view.IView m_view;

        public Observer(model.Game a_game, view.IView a_view)
        {
            m_game = a_game;
            m_view = a_view;
        }

        public void NotifyAboutDealtCard()
        {
            m_view.DisplayWelcomeMessage();
            m_view.DisplayDealerHand(
                m_game.GetDealerHand(), m_game.GetDealerScore()
            );
            m_view.DisplayPlayerHand(
                m_game.GetPlayerHand(), m_game.GetPlayerScore()
            );

            m_view.PauseDramatically();
        }
    }
}