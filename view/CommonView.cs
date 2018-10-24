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

        private bool IsUserWantsToPlay { get; set; }

        private bool IsUserWantsToHit { get; set; }

        private bool IsUserWantsToStand { get; set; }

        private bool IsUserWantsToQuit { get; set; }

        public bool UserWantsToPlay()
        {
            if (!IsUserWantsToHit && !IsUserWantsToStand && !IsUserWantsToQuit)
            {
                SetUserInputIfNotSet();
                bool userWantsToPlay = UserInput == PlayCommand;
                ResetUserInputIf(userWantsToPlay);
                IsUserWantsToPlay = userWantsToPlay;
                return userWantsToPlay;
            }
            else
            {
                return false;
            }
        }

        public bool UserWantsToHit()
        {
            if (!IsUserWantsToPlay && !IsUserWantsToStand && !IsUserWantsToQuit)
            {
                SetUserInputIfNotSet();
                bool userWantsToHit = UserInput == HitCommand;
                ResetUserInputIf(userWantsToHit);
                IsUserWantsToHit = userWantsToHit;
                return userWantsToHit;
            }
            else
            {
                return false;
            }
        }

        public bool UserWantsToStand()
        {
            if (!IsUserWantsToPlay && !IsUserWantsToHit && !IsUserWantsToQuit)
            {
                SetUserInputIfNotSet();
                bool userWantsToStand = UserInput == StandCommand;
                ResetUserInputIf(userWantsToStand);
                IsUserWantsToStand = userWantsToStand;
                return userWantsToStand;
            }
            else
            {
                return false;
            }
        }

        public bool UserWantsToQuit()
        {
            if (!IsUserWantsToPlay && !IsUserWantsToHit && !IsUserWantsToStand)
            {
                SetUserInputIfNotSet();
                bool userWantsToQuit = UserInput == QuitCommand;
                ResetUserInputIf(userWantsToQuit);
                IsUserWantsToQuit = userWantsToQuit;
                return userWantsToQuit;
            }
            else
            {
                return false;
            }
        }

        private void SetUserInputIfNotSet()
        {
            if (string.IsNullOrEmpty(UserInput))
            {
                UserInput = Console.ReadLine().ToLower();
            }
        }

        private void ResetUserInputIf(bool condition)
        {
            if (condition) UserInput = null;
        }
    }
}