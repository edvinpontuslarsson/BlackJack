using System;
using System.Diagnostics;

namespace BlackJack.view
{
    abstract class CommonView
    {
        protected const string PlayCommand = "p";
        protected const string HitCommand = "h";
        protected const string StandCommand = "s";
        protected const string QuitCommand = "q";

        private string UserInput { get; set; }

        public bool UserWantsToPlay()
        {
            SetUserInputIfNotSet();
            return UserInput == PlayCommand;
        }

        public bool UserWantsToHit()
        {
            SetUserInputIfNotSet();
            return UserInput == HitCommand;
        }

        public bool UserWantsToStand()
        {
            SetUserInputIfNotSet();
            return UserInput == StandCommand;
        }

        /// <summary>
        /// Also resets user input
        /// </summary>
        public bool UserWantsToQuit()
        {
            SetUserInputIfNotSet();
            bool userWantsToQuit = UserInput == QuitCommand;
            UserInput = null;
            return userWantsToQuit;
        }

        private void SetUserInputIfNotSet()
        {
            if (string.IsNullOrEmpty(UserInput))
            {
                UserInput = Console.ReadLine().ToLower();
            }
        }
    }
}