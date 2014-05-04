using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poker
{
    public enum PokerResultEnum
    {
        Nothing,
        Pair,
        TwoPair,
        ThreeOfAKind,
        FourOfAKind,
        FullHouse,
        Straight
    }

    public enum SuitEnum
    {
        Hearts,
        Clubs,
        Diamonds,
        Spades
    }
}
