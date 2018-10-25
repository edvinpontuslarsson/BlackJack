﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlackJack.model
{
    class Dealer : Player
    {
        private Deck m_deck = null;

        private const int g_maxScore = 21;

        private rules.INewGameStrategy m_newGameRule;
        private rules.IHitStrategy m_hitRule;

        private rules.IPickWinnerStrategy m_pickWinnerRule;

        public Dealer(rules.RulesFactory a_rulesFactory)
        {
            m_newGameRule = a_rulesFactory.GetNewGameRule();
            m_hitRule = a_rulesFactory.GetHitRule();
            m_pickWinnerRule = a_rulesFactory.GetPickWinnerRule();
        }

        public bool NewGame(Player a_player)
        {
            if (m_deck == null || IsGameOver())
            {
                m_deck = new Deck();
                ClearHand();
                a_player.ClearHand();
                return m_newGameRule.NewGame(m_deck, this, a_player);   
            }
            return false;
        }

        /// <summary>
        /// Method author: Edvin Larsson,
        /// inspired by Sequence Diagram
        /// </summary>
        public void Stand()
        {
            if (m_deck != null)
            {
                ShowHand();

                while (m_hitRule.DoHit(this))
                {
                    Card card = m_deck.GetCard();
                    card.Show(true);
                    AddCardToHand(card);
                }
            }
        }

        public bool Hit(Player a_player)
        {
            if (m_deck != null && a_player.CalcScore() < g_maxScore && !IsGameOver())
            {
                Card c;
                c = m_deck.GetCard();
                c.Show(true);
                a_player.AddCardToHand(c);

                return true;
            }
            return false;
        }

        // TODO: maybe have some kind of loop too

        /// <summary>
        /// Method created by Edvin Larsson
        /// </summary>
        /// <param name="a_player">Player/Dealer</param>
        public void DealCardTo(Player a_player)
        {
            Card card = m_deck.GetCard();
            card.Show(true);
            a_player.AddCardToHand(card);
        }       

        public bool IsDealerWinner(Player a_player) => 
            m_pickWinnerRule.IsDealerWinner(this, a_player);

        public bool IsGameOver()
        {
            if (m_deck != null && /*CalcScore() >= g_hitLimit*/ m_hitRule.DoHit(this) != true)
            {
                return true;
            }
            return false;
        }
    }
}
