using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlackJack.view
{
    class SimpleView : IView
    {
        // OK, seems like I need Console,
        // at least for public methods

        public void DisplayWelcomeMessage()
        {
            Console.Clear();
            Console.WriteLine("Hello Black Jack World");
            DisplayInstructions();
        }

        // TODO: I'll use my way of reading instead,
        // perhaps add removing, Console.Clear(); ???

        // error message if wrong input, instructions

        /* 
        public int GetInput()
        {
            return Console.In.Read();
        }
        */

        public void DisplayCard(model.Card a_card)
        {
            Console.WriteLine("{0} of {1}", a_card.GetValue(), a_card.GetColor());
        }

        public void DisplayPlayerHand(IEnumerable<model.Card> a_hand, int a_score)
        {
            DisplayHand("Player", a_hand, a_score);
        }

        public void DisplayDealerHand(IEnumerable<model.Card> a_hand, int a_score)
        {
            DisplayHand("Dealer", a_hand, a_score);
        }

        private void DisplayHand(String a_name, IEnumerable<model.Card> a_hand, int a_score)
        {
            Console.WriteLine("{0} Has: ", a_name);
            foreach (model.Card c in a_hand)
            {
                DisplayCard(c);
            }
            Console.WriteLine("Score: {0}", a_score);
            Console.WriteLine("");
        }

        public void DisplayGameOver(bool a_dealerIsWinner)
        {
            Console.Write("GameOver: ");
            if (a_dealerIsWinner)
            {
                Console.WriteLine("Dealer Won!");
            }
            else
            {
                Console.WriteLine("You Won!");
            }
            
        }

        /// <summary>
        /// Method created by Edvin Larsson
        /// </summary>
        private void DisplayInstructions()
        {
            Console.WriteLine(
                "Type 'p' to Play, 'h' to Hit, 's' to Stand or 'q' to Quit\n"
            );
        }
    }
}
