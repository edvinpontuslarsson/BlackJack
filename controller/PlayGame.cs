using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlackJack.controller
{
    class PlayGame
    {
        private bool GameStarted { get; set; }

        public bool Play(model.Game a_game, view.IView a_view, DealtCardObserver observer)
        {         
            a_game.RegisterObserver(observer);

            if (!GameStarted) a_view.DisplayWelcomeMessage();

            if (a_game.IsGameOver()) a_view.DisplayGameOver(a_game.IsDealerWinner());

            UserWish userWish = a_view.GetUserWish();

            if (userWish == UserWish.Play)
            {
                GameStarted = true;
                a_game.NewGame();
            }
        
            if (userWish == UserWish.Hit) a_game.Hit();  
            
            if (userWish == UserWish.Stand) a_game.Stand();

            return userWish != UserWish.Quit;
        }
    }
}
