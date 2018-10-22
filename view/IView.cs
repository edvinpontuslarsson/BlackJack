using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlackJack.view
{
    interface IView
    {
        void DisplayWelcomeMessage();

        // Edvin Larsson has removed int GetInput();

        // Added by Edvin Larsson
        bool UserWantsToPlay();

        bool UserWantsToHit();

        bool UserWantsToStand();

        bool UserWantsToQuit();

        // These were here originally
        void DisplayCard(model.Card a_card);
        void DisplayPlayerHand(IEnumerable<model.Card> a_hand, int a_score);
        void DisplayDealerHand(IEnumerable<model.Card> a_hand, int a_score);
        void DisplayGameOver(bool a_dealerIsWinner);
    }
}
