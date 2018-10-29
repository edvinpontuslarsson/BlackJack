using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlackJack.view
{
    interface IView
    {
        void DisplayWelcomeMessage();
        controller.UserWish GetUserWish();
        // void DisplayGameStatus(IEnumerable<model.Card> a_hand, int a_score);
        void DisplayCard(model.Card a_card);
        void DisplayDealerHand(IEnumerable<model.Card> a_hand, int a_score);
        void DisplayPlayerHand(IEnumerable<model.Card> a_hand, int a_score);
        void PauseDramatically();
        void DisplayGameOver(bool a_dealerIsWinner);
    }
}
