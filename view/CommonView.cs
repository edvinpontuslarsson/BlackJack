using System;
using System.Diagnostics;

namespace BlackJack.view
{
    /// <summary>
    /// Class author: Edvin Larsson
    /// </summary>
    abstract class CommonView
    {
        protected const string PlayCommand = "p";
        protected const string HitCommand = "h";
        protected const string StandCommand = "s";
        protected const string QuitCommand = "q";

        protected string UserInput { get; set; }

        public void AskForUserInput()
        {
            UserInput = Console.ReadLine().ToLower();
        }

        public bool UserWantsToPlay()
        {
            Debug.Assert(IsUserInputSet());
            return UserInput == PlayCommand;
        }

        public bool UserWantsToHit()
        {
            Debug.Assert(IsUserInputSet());
            return UserInput == HitCommand;
        }

        public bool UserWantsToStand()
        {
            Debug.Assert(IsUserInputSet());
            return UserInput == StandCommand;
        }

        public bool UserWantsToQuit()
        {
            Debug.Assert(IsUserInputSet());
            return UserInput == QuitCommand;
        }

        private bool IsUserInputSet() => !string.IsNullOrEmpty(UserInput);
    }
}