using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RiichiCalc.Core.Hand;
using RiichiCalc.Tiles;

namespace RiichiCalc.Core.Pattern
{
    // A hand with at least one group of dragon tiles, seat wind, or round wind tiles. This hand can be valued at 1 han for each group. 
    class ToitoiPattern : IPattern
    {
        public uint Matches(TableContext ctx, ParsedHand hand)
        {
            return hand.Groups.Count(x => x is Triple) == 4
                   && hand.Groups.Count(x => x is Pair) == 1 ? 1u : 0;
        }

        public string Name() => "Toitoi";

        public uint BigPoints() => 2;

        public uint BigPointsOpenHanded() => 2;
    }
}
