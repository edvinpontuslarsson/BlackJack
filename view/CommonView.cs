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

        private bool DoesUserWantsToPlay { get; set; }
        private bool DoesUserWantsToHit { get; set; }
        private bool DoesUserWantsToStand { get; set; }
        private bool DoesUserWantsToQuit { get; set; }

        public bool UserWantsToPlay()
        {
            if (!DoesUserWantsToHit && !DoesUserWantsToStand && !DoesUserWantsToQuit)
            {
                bool userWantsToPlay = UserInputEquals(PlayCommand);
                DoesUserWantsToPlay = userWantsToPlay;
                return userWantsToPlay;
            }
            else
                return false;
        }

        public bool UserWantsToHit()
        {
            if (!DoesUserWantsToPlay && !DoesUserWantsToStand && !DoesUserWantsToQuit)
            {
                bool userWantsToHit = UserInputEquals(HitCommand);
                DoesUserWantsToHit = userWantsToHit;
                return userWantsToHit;
            }
            else
                return false;
        }

        public bool UserWantsToStand()
        {
            if (!DoesUserWantsToPlay && !DoesUserWantsToHit && !DoesUserWantsToQuit)
            {
                bool userWantsToStand = UserInputEquals(StandCommand);
                DoesUserWantsToStand = userWantsToStand;
                return userWantsToStand;
            }
            else
                return false;
        }

        public bool UserWantsToQuit()
        {
            if (!DoesUserWantsToPlay && !DoesUserWantsToHit && !DoesUserWantsToStand)
            {
                bool userWantsToQuit = UserInputEquals(QuitCommand);
                DoesUserWantsToQuit = userWantsToQuit;
                return userWantsToQuit;
            }
            else
                return false;
        }

        private bool UserInputEquals(string command)
        {
            SetUserInputIfNotSet();
            bool inputEqualsCommand = UserInput == command;
            ResetUserInputIf(inputEqualsCommand);
            return inputEqualsCommand;
        }

        private void SetUserInputIfNotSet()
        {
            if (string.IsNullOrEmpty(UserInput)) 
                UserInput = Console.ReadLine().ToLower();
        }

        private void ResetUserInputIf(bool condition)
        {
            if (condition) UserInput = null;
        }
    }
}