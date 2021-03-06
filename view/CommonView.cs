using System;
using System.Collections.Generic;
using System.Threading;

namespace BlackJack.view
{
    abstract class CommonView
    {
        protected const string PlayCommand = "p";
        protected const string HitCommand = "h";
        protected const string StandCommand = "s";
        protected const string QuitCommand = "q";

        public controller.UserWish GetUserWish()
        {
            string userRequest = Console.ReadLine().ToLower();

            switch (userRequest)
            {
                case PlayCommand:
                    return controller.UserWish.Play;
                case HitCommand:
                    return controller.UserWish.Hit;
                case StandCommand:
                    return controller.UserWish.Stand;
                case QuitCommand:
                    return controller.UserWish.Quit;
                default:
                    return controller.UserWish.Unrecognized;
            }
        }
        
        public void PauseDramatically() => Thread.Sleep(2000);
    }
}