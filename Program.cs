using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlackJack
{
    class Program
    {
        static void Main(string[] args)
        {
            if (ShouldRunTests(args))
            {
                test.Test test = new test.Test();
                test.RunTests();
            }
            else
            {
                InitializeApp();
            }
        }

        private static bool ShouldRunTests(string[] args) => 
            args.Length > 0 && args[0].ToLower() == "test";

        private static void InitializeApp()
        {
            model.Game g = new model.Game();
            view.IView v = new view.SimpleView(); // new view.SwedishView();
            controller.PlayGame ctrl = new controller.PlayGame();

            while (ctrl.Play(g, v));
        }
    }
}
