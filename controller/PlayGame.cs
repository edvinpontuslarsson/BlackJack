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

            // TODO: perhaps use official C# observer thing instead

            // observer from program
            Observer observer = new Observer(a_view);
            a_game.RegisterObserver(observer);

            // initiate view with model from program
            
            /* 
            a_view.DisplayDealerHand(a_game.GetDealerHand(), a_game.GetDealerScore());
            a_view.DisplayPlayerHand(a_game.GetPlayerHand(), a_game.GetPlayerScore());
            */

            if (a_game.IsGameOver()) a_view.DisplayGameOver(a_game.IsDealerWinner());

            // Code below, changed by Edvin Larsson
            UserWish userWish = a_view.GetUserWish();

            if (userWish == UserWish.Play) a_game.NewGame();
        
            if (userWish == UserWish.Hit) a_game.Hit();  
            
            if (userWish == UserWish.Stand) a_game.Stand();

            return userWish != UserWish.Quit;
        }
    }
}
