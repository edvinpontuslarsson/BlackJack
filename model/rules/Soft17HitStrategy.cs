using System;

namespace BlackJack.model.rules
{
    // Tested in BlackJack.test.Test
    class Soft17HitStrategy : IHitStrategy
    {
        private const int SoftHitLimit = 17;

        public bool DoHit(model.Player a_dealer)
        {
            if (a_dealer.CalcScore() == SoftHitLimit && 
                HasAnAce(a_dealer))
            {
                return true;
            }

            return a_dealer.CalcScore() < SoftHitLimit;
        }

        private bool HasAnAce(model.Player a_dealer)
        {
            foreach (Card card in a_dealer.GetHand())
            {
                if (card.GetValue() == Card.Value.Ace)
                {
                    return true;
                }
            }

            return false;
        }
    }
}