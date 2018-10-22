using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlackJack.controller
{
    class PlayGame
    {
        public bool Play(model.Game a_game, view.IView a_view)
        {
            // was here originally
            a_view.DisplayWelcomeMessage();
            
            a_view.DisplayDealerHand(a_game.GetDealerHand(), a_game.GetDealerScore());
            a_view.DisplayPlayerHand(a_game.GetPlayerHand(), a_game.GetPlayerScore());

            if (a_game.IsGameOver())
            {
                a_view.DisplayGameOver(a_game.IsDealerWinner());
            }

            // Code below, changed by Edvin Larsson
            a_view.AskForUserInput();

            if (a_view.UserWantsToPlay()) 
            {
                a_game.NewGame();
            }            
            
            if (a_view.UserWantsToHit())
            {
                a_game.Hit();
            }            
            
            if (a_view.UserWantsToStand())
            {
                a_game.Stand();
            }

            return !a_view.UserWantsToQuit();
        }
    }
}
