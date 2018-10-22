using System;

namespace BlackJack.test
{
    class Test
    {
        public void RunTests()
        {
            Console.WriteLine("Running tests");
        }

        public bool Soft17HitWorks()
        {
            model.rules.RulesFactory rulesFactory =
                new model.rules.RulesFactory();
            model.Dealer dealer = new model.Dealer(rulesFactory);

            
        }
    }
}