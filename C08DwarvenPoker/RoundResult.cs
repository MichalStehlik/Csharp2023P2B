using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C08DwarvenPoker
{
    internal enum RoundResult
    {
        Nothing = 0,
        Pair = 1,
        TwoPairs = 2,
        ThreeOfKind = 3,
        FiveHighStraight = 4,
        SixHighStraight = 5,
        FullHouse = 6,
        FourOfKind = 7,
        FiveOfKind = 8
    }
}
