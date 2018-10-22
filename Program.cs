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
            if (args.Length > 0 && args[0].ToLower() == "test")
            {
                test.Test test = new test.Test();
                test.RunTests();
            }
            else
            {
                model.Game g = new model.Game();
                view.IView v = new view.SimpleView(); // new view.SwedishView();
                controller.PlayGame ctrl = new controller.PlayGame();

                while (ctrl.Play(g, v));
            }
        }
    }
}
