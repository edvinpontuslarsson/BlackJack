using System;

namespace BlackJack.test
{
    class Test
    {
        public void RunTests()
        {
            Console.WriteLine("Running tests");
            string soft17Status = Soft17LogicWorks()
                ? "passes"
                : "fails";

            Console.WriteLine(
                $"Soft 17 test {soft17Status}"
            );
        }

        /// <summary>
        /// A simple test of the logic used, 
        /// although simplified
        /// </summary>
        public bool Soft17LogicWorks()
        {
            string[] arrWithAce = {"a", "q"};
            string[] arrWithNoAce = {"q", "q"};

            return DoHit(16, arrWithAce) && 
                DoHit(16, arrWithNoAce) &&
                DoHit(17, arrWithAce) &&
                !DoHit(17, arrWithNoAce) &&
                !DoHit(18, arrWithAce) &&
                !DoHit(18, arrWithNoAce);
        }

        private bool DoHit(int score, string[] cards)
        {
            if (score == 17 && HasAnAce(cards))
            {
                return true;
            }

            return score < 17;
        }

        private bool HasAnAce(string[] cards)
        {
            foreach (string card in cards)
            {
                if (card == "a")
                {
                    return true;
                }
            }

            return false;
        }
    }
}