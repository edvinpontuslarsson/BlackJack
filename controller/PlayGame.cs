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
            // have an initializeView method instead

            // DisplayStatus
            a_view.DisplayWelcomeMessage();

            Observer observer = new Observer(a_game, a_view);
            a_game.RegisterObserver(observer);

            if (a_game.IsGameOver()) a_view.DisplayGameOver(a_game.IsDealerWinner());

            UserWish userWish = a_view.GetUserWish();

            if (userWish == UserWish.Play) a_game.NewGame();
        
            if (userWish == UserWish.Hit) a_game.Hit();  
            
            if (userWish == UserWish.Stand) a_game.Stand();

            return userWish != UserWish.Quit;
        }
    }
}
