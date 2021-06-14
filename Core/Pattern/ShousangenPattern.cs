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
    class ShousangenPattern : IPattern
    {
        public uint Matches(TableContext ctx, ParsedHand hand)
        {
            if (!hand.IsRegularCompleteHand)
            {
                return 0;
            }

            return hand.Groups.Count(x => x is Triple && x.FirstTile.IsDragon()) == 2
                   && hand.Groups.Any(x => x is Pair && x.FirstTile.IsDragon())
                ? 1u
                : 0;
        }

        public string Name() => "Shousangen";

        public uint BigPoints() => 2;

        public uint BigPointsOpenHanded() => 2;
    }
}
