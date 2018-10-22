using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlackJack.view
{
    class SimpleView : IView
    {        
        private const string PlayCommand = "p";
        private const string HitCommand = "h";
        private const string StandCommand = "s";
        private const string QuitCommand = "q";
        private string _instructions = 
            $"Type '{PlayCommand}' to Play, '{HitCommand}' to Hit, " +
            $"'{StandCommand}' to Stand or '{QuitCommand}' to Quit\n";

        // encapsulated with property because it is not a constant
        public string Instructions { get => _instructions; }

        public void DisplayWelcomeMessage()
        {
            Console.Clear();
            Console.WriteLine("Hello Black Jack World");
            DisplayInstructions();
        }

        // use Console.Clear();

        public void DisplayCard(model.Card a_card) => 
            Console.WriteLine("{0} of {1}", a_card.GetValue(), a_card.GetColor());

        public void DisplayPlayerHand(IEnumerable<model.Card> a_hand, int a_score) => 
            DisplayHand("Player", a_hand, a_score);

        public void DisplayDealerHand(IEnumerable<model.Card> a_hand, int a_score) => 
            DisplayHand("Dealer", a_hand, a_score);

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

        // Method created by Edvin Larsson
        private void DisplayInstructions() => Console.WriteLine(Instructions);

        // Method created by Edvin Larsson
        private string GetUserInput() => Console.ReadLine().ToLower();
    }
}
